using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeImagenes
{
    public partial class Form1 : Form
    {
        const int porcentajeSimilitud = 10;

        int indice_image = 0;
        SolidBrush blackPen = new SolidBrush(Color.Red);

        bool draw = false;

        Point lastPoint = Point.Empty;
        int alphaComponent;

        private PictureBox pictureBox1 = new PictureBox();
        private Font fnt = new Font("Arial", 10);

        string ruta_imagen;
        Color pixel_color;
        Color nuevo_color;

        PropertyInfo imageRectangleProperty = typeof(PictureBox).GetProperty("ImageRectangle", BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Instance);
        private int tolerance;

        Bitmap original_image;
        List<Bitmap> img_tmp = new List<Bitmap>();

        //Prueba selección
        private Point RectStartPoint;
        private Rectangle Rect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));

        public Bitmap ImageModified { get; set; }

        public Form1()
        {
            InitializeComponent();
            original_image = new Bitmap(img_nueva.Image);
            img_tmp.Add(original_image);
        }

        private void btn_cargar_img_Click(object sender, EventArgs e)
        {
            img_tmp.Clear();
            indice_image = 0;
            if (Obtener_ruta_imagen() != null)
            {
                Bitmap bitmapCopia = new Bitmap(ruta_imagen);
                original_image = bitmapCopia;
                img_nueva.Image = (Image)bitmapCopia;
                img_tmp.Add(bitmapCopia);
            }            
        }

        private string Obtener_ruta_imagen() {

            opf_dialog.InitialDirectory = @"D:\abujalance\Imágenes";

            if (opf_dialog.ShowDialog() == DialogResult.OK)
            {
                ruta_imagen = opf_dialog.FileName;
                return ruta_imagen;
            }

            return null;
        }

        private void RotarImagen() {
            Bitmap bitmapCopia = new Bitmap(img_nueva.Image);

            bitmapCopia.RotateFlip(RotateFlipType.Rotate90FlipNone);
            img_nueva.Image = bitmapCopia;
        }

        private void Espejo() {
            Bitmap bitmapCopia = new Bitmap(img_nueva.Image);

            bitmapCopia.RotateFlip(RotateFlipType.Rotate180FlipY);
            img_nueva.Image = bitmapCopia;
        }

        private void img_original_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rectangle rectangle = (Rectangle)imageRectangleProperty.GetValue(img_nueva, null);
                if (rectangle.Contains(e.Location))
                {
                    using (Bitmap copy = new Bitmap(img_nueva.ClientSize.Width, img_nueva.ClientSize.Height))
                    {
                        using (Graphics g = Graphics.FromImage(copy))
                        {
                            g.DrawImage(img_nueva.Image, rectangle);
                            lastPoint = e.Location;

                            pixel_color = copy.GetPixel(e.X, e.Y);

                            pbx_original.BackColor = pixel_color;
                            lbl_original_code.Text = pixel_color.ToString();
                        }
                    }                    
                }
            }
        }

        private void ClonarImagen() {
            Bitmap bitmapCopia = new Bitmap(img_nueva.Image);
            Color pixel_actual;

            object o = EditorDeImagenes.Properties.Resources.ResourceManager.GetObject("carga.gif");
            img_nueva.Image = (Image)o;

            img_tmp.Add(bitmapCopia);
            indice_image++;

            for (int i = 0; i < bitmapCopia.Width; i++)
            {
                for (int j = 0; j < bitmapCopia.Height; j++)
                {
                    pixel_actual = bitmapCopia.GetPixel(i, j);

                    if (j != 0 && i != 0)
                    {
                        double a = (double)bitmapCopia.Height / (double)j;
                        double b = (double)img_nueva.ClientSize.Height / (double)RectStartPoint.Y;
                        double c = (double)bitmapCopia.Width / (double)i;
                        double d = (double)img_nueva.ClientSize.Width / (double)RectStartPoint.X;

                       /* if (a > b || c > d)
                        {
                            continue;
                        }*/
                    }            

                    /*if (pixel_actual == pixel_color)
                    {
                        bitmapCopia.SetPixel(i, j,nuevo_color);
                    }
                    else 
                    {   */
                        if (AreaColorSimilar(pixel_actual,pixel_color,tolerance))
                            bitmapCopia.SetPixel(i, j, Color_nuevo(pixel_actual,pixel_color));                  
                   // }   
                }
            }

            img_nueva.Image = (Image)bitmapCopia;
        }

        private void btn_clonar_Click(object sender, EventArgs e)
        {
            ClonarImagen();
        }

        private void btn_elegir_color_Click(object sender, EventArgs e)
        {
            if (cld_nuevo_color.ShowDialog() == DialogResult.OK)
            {
                nuevo_color = cld_nuevo_color.Color;
                pbx_nuevo.BackColor = nuevo_color;
                lbl_nuevo_code.Text = nuevo_color.ToString();
            }
        }

        private Color Color_nuevo(Color c1, Color c2)
        {
            int[] color_establecer = new int[3];

            int difR = c1.R - c2.R;
            int difG = c1.G - c2.G;
            int difB = c1.B - c2.B;

            int[] difOrd = new int[3];
            difOrd[0] =  - difR;
            difOrd[1] =  - difG;
            difOrd[2] =  - difB;

            Array.Sort(difOrd, (a, b) => a - b);

            // Establecemos el color mayor

            if (nuevo_color.R > nuevo_color.G)
            {
                if (nuevo_color.R > nuevo_color.B)
                {
                    color_establecer = new int[]{ 1, 0, 0};
                }
                else
                {
                    color_establecer = new int[] { 0, 0, 1 };
                }
            }
            else if (nuevo_color.G > nuevo_color.B)
            {
                color_establecer = new int[] { 0, 1, 0 };
            }
            else
            {
                color_establecer = new int[] { 0, 0, 1 };
            }

            if (color_establecer[0] != 0)
            {
                if (nuevo_color.G > nuevo_color.B)
                {
                    color_establecer = new int[]{nuevo_color.R - difOrd[0],
                        nuevo_color.G - difOrd[1],
                        nuevo_color.B - difOrd[2] };
                }
                else
                {
                    color_establecer = new int[]{nuevo_color.R - difOrd[0],
                        nuevo_color.G - difOrd[2],
                        nuevo_color.B - difOrd[1] };
                }
            }
            else if (color_establecer[1] != 0)
            {
                if (nuevo_color.R > nuevo_color.B)
                {
                    color_establecer = new int[]{nuevo_color.R - difOrd[1],
                        nuevo_color.G - difOrd[0],
                        nuevo_color.B - difOrd[2] };
                }
                else
                {
                    color_establecer = new int[]{ nuevo_color.R - difOrd[2],
                        nuevo_color.G - difOrd[0],
                        nuevo_color.B - difOrd[1] };
                }
            }
            else
            {
                if (nuevo_color.B > nuevo_color.G)
                {
                    color_establecer = new int[]{nuevo_color.R - difOrd[2],
                        nuevo_color.G - difOrd[1],
                        nuevo_color.B - difOrd[0] };
                }
                else
                {
                    color_establecer = new int[]{nuevo_color.R - difOrd[1],
                        nuevo_color.G - difOrd[2],
                        nuevo_color.B - difOrd[0] };
                }

            }

            for (int i = 0; i < color_establecer.Length; i++)
            {
                if (color_establecer[i] < 0)
                {
                    color_establecer[i] = 0;
                }
                else if (color_establecer[i] > 255)
                {
                    color_establecer[i] = 255;
                }
            }

            return Color.FromArgb(alphaComponent,color_establecer[0], color_establecer[1], color_establecer[2]);
        }

        private bool AreaColorSimilar(Color c1, Color c2, int tolerancia) {
            return Math.Abs(c1.R - c2.R) < tolerance &&
            Math.Abs(c1.G - c2.G) < tolerance &&
            Math.Abs(c1.B - c2.B) < tolerance;
        }

        private void tkb_tolerancia_Scroll(object sender, EventArgs e)
        {
            tolerance = tkb_tolerancia.Value;
            lbl_tolerancia.Text = tolerance.ToString();
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            img_nueva.Image = (Image)original_image;
        }

        private void btn_deshacer_Click(object sender, EventArgs e)
        {
            if (img_tmp != null && indice_image > 0)
            {
                img_nueva.Image = img_tmp[--indice_image];
            }
        }

        private void btn_brocha_Click(object sender, EventArgs e)
        {
        }

        private void img_nueva_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            lastPoint = e.Location;
        }

        private void img_nueva_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void img_nueva_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw == true)
            {
                using (Graphics g = img_nueva.CreateGraphics())
                {
                    img_nueva.Refresh();
                    g.FillEllipse(Brushes.Red, lastPoint.X, lastPoint.Y,
                        Math.Abs(lastPoint.X - e.X), 
                        Math.Abs(lastPoint.Y - e.Y));

                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            sfd_savedialog.InitialDirectory = @"D:\abujalance\Imágenes";

            if (sfd_savedialog.ShowDialog() == DialogResult.OK)
            {
                if (!Path.HasExtension(sfd_savedialog.FileName))
                {
                    sfd_savedialog.FileName += ".png";
                }

                img_nueva.Image.Save(sfd_savedialog.FileName,System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void btn_rehacer_Click(object sender, EventArgs e)
        {
            if (indice_image < img_tmp.Count-1)
            {
                img_nueva.Image = img_tmp[++indice_image];
            }
        }

        private void btn_rotar_Click(object sender, EventArgs e)
        {
            RotarImagen();
        }

        private void btn_espejo_Click(object sender, EventArgs e)
        {
            Espejo();
        }

        private void img_nueva_MouseUp_1(object sender, MouseEventArgs e)
        {
        }

        private void img_nueva_MouseDown_1(object sender, MouseEventArgs e)
        {
            RectStartPoint = e.Location;
            Debug.Write(RectStartPoint);
            Debug.Write(lastPoint);
            Invalidate();
        }

        private void img_nueva_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            Rect.Location = new Point(
                Math.Min(RectStartPoint.X, tempEndPoint.X),
                Math.Min(RectStartPoint.Y, tempEndPoint.Y));
            Rect.Size = new Size(
                Math.Abs(RectStartPoint.X - tempEndPoint.X),
                Math.Abs(RectStartPoint.Y - tempEndPoint.Y));
            img_nueva.Invalidate();
        }

        private void img_nueva_Paint(object sender, PaintEventArgs e)
        {
            if (img_nueva.Image != null)
            {
                if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                {
                    e.Graphics.FillRectangle(selectionBrush, Rect);
                }
            }
        }

        private void BtnTransparantarSel_Click(object sender, EventArgs e)
        {
            Bitmap bitmapCopia = new Bitmap(img_nueva.Image);
            Color pixel_actual;
            Color transparente = Color.FromArgb(alphaComponent,0,0,0);

            object o = EditorDeImagenes.Properties.Resources.ResourceManager.GetObject("carga.gif");
            img_nueva.Image = (Image)o;

            img_tmp.Add(bitmapCopia);
            indice_image++;

            for (int i = 0; i < bitmapCopia.Width; i++)
            {
                for (int j = 0; j < bitmapCopia.Height; j++)
                {
                    pixel_actual = bitmapCopia.GetPixel(i, j);

                    if (j != 0 && i != 0)
                    {
                        double a = (double)bitmapCopia.Height / (double)j;
                        double b = (double)img_nueva.ClientSize.Height / (double)RectStartPoint.Y;
                        double c = (double)bitmapCopia.Width / (double)i;
                        double d = (double)img_nueva.ClientSize.Width / (double)RectStartPoint.X;

                        /* if (a > b || c > d)
                         {
                             continue;
                         }*/
                    }

                    if (AreaColorSimilar(pixel_actual, pixel_color, tolerance))
                            bitmapCopia.SetPixel(i, j,transparente);
                }
            }

            img_nueva.Image = (Image)bitmapCopia;
        }

        private void Tkb_transparencia_Scroll(object sender, EventArgs e)
        {
            alphaComponent = tkb_transparencia.Value;
            //lbl_tolerancia.Text = .ToString();
        }
    }
}
