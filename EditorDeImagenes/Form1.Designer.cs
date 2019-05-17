namespace EditorDeImagenes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.opf_dialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_cargar_img = new System.Windows.Forms.Button();
            this.btn_clonar = new System.Windows.Forms.Button();
            this.cld_nuevo_color = new System.Windows.Forms.ColorDialog();
            this.btn_elegir_color = new System.Windows.Forms.Button();
            this.lbl_color_original = new System.Windows.Forms.Label();
            this.lbl_color_nuevo = new System.Windows.Forms.Label();
            this.lbl_original_code = new System.Windows.Forms.Label();
            this.lbl_nuevo_code = new System.Windows.Forms.Label();
            this.tkb_tolerancia = new System.Windows.Forms.TrackBar();
            this.lbl_tolerancia = new System.Windows.Forms.Label();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.btn_deshacer = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_rehacer = new System.Windows.Forms.Button();
            this.sfd_savedialog = new System.Windows.Forms.SaveFileDialog();
            this.pbx_nuevo = new System.Windows.Forms.PictureBox();
            this.pbx_original = new System.Windows.Forms.PictureBox();
            this.img_nueva = new System.Windows.Forms.PictureBox();
            this.btn_rotar = new System.Windows.Forms.Button();
            this.btn_espejo = new System.Windows.Forms.Button();
            this.btnTransparantarSel = new System.Windows.Forms.Button();
            this.tkb_transparencia = new System.Windows.Forms.TrackBar();
            this.lbl_transparencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_tolerancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_nuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_nueva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_transparencia)).BeginInit();
            this.SuspendLayout();
            // 
            // opf_dialog
            // 
            this.opf_dialog.FileName = "openFileDialog1";
            // 
            // btn_cargar_img
            // 
            this.btn_cargar_img.Location = new System.Drawing.Point(13, 324);
            this.btn_cargar_img.Name = "btn_cargar_img";
            this.btn_cargar_img.Size = new System.Drawing.Size(129, 22);
            this.btn_cargar_img.TabIndex = 2;
            this.btn_cargar_img.Text = "Cargar imagen";
            this.btn_cargar_img.UseVisualStyleBackColor = true;
            this.btn_cargar_img.Click += new System.EventHandler(this.btn_cargar_img_Click);
            // 
            // btn_clonar
            // 
            this.btn_clonar.Location = new System.Drawing.Point(13, 352);
            this.btn_clonar.Name = "btn_clonar";
            this.btn_clonar.Size = new System.Drawing.Size(75, 23);
            this.btn_clonar.TabIndex = 4;
            this.btn_clonar.Text = "Clonar";
            this.btn_clonar.UseVisualStyleBackColor = true;
            this.btn_clonar.Click += new System.EventHandler(this.btn_clonar_Click);
            // 
            // btn_elegir_color
            // 
            this.btn_elegir_color.Location = new System.Drawing.Point(13, 381);
            this.btn_elegir_color.Name = "btn_elegir_color";
            this.btn_elegir_color.Size = new System.Drawing.Size(75, 23);
            this.btn_elegir_color.TabIndex = 5;
            this.btn_elegir_color.Text = "Elegir Color";
            this.btn_elegir_color.UseVisualStyleBackColor = true;
            this.btn_elegir_color.Click += new System.EventHandler(this.btn_elegir_color_Click);
            // 
            // lbl_color_original
            // 
            this.lbl_color_original.AutoSize = true;
            this.lbl_color_original.Location = new System.Drawing.Point(117, 357);
            this.lbl_color_original.Name = "lbl_color_original";
            this.lbl_color_original.Size = new System.Drawing.Size(67, 13);
            this.lbl_color_original.TabIndex = 8;
            this.lbl_color_original.Text = "Color original";
            // 
            // lbl_color_nuevo
            // 
            this.lbl_color_nuevo.AutoSize = true;
            this.lbl_color_nuevo.Location = new System.Drawing.Point(276, 357);
            this.lbl_color_nuevo.Name = "lbl_color_nuevo";
            this.lbl_color_nuevo.Size = new System.Drawing.Size(64, 13);
            this.lbl_color_nuevo.TabIndex = 9;
            this.lbl_color_nuevo.Text = "Color nuevo";
            // 
            // lbl_original_code
            // 
            this.lbl_original_code.AutoSize = true;
            this.lbl_original_code.Location = new System.Drawing.Point(117, 446);
            this.lbl_original_code.Name = "lbl_original_code";
            this.lbl_original_code.Size = new System.Drawing.Size(67, 13);
            this.lbl_original_code.TabIndex = 10;
            this.lbl_original_code.Text = "Color original";
            // 
            // lbl_nuevo_code
            // 
            this.lbl_nuevo_code.AutoSize = true;
            this.lbl_nuevo_code.Location = new System.Drawing.Point(117, 473);
            this.lbl_nuevo_code.Name = "lbl_nuevo_code";
            this.lbl_nuevo_code.Size = new System.Drawing.Size(67, 13);
            this.lbl_nuevo_code.TabIndex = 11;
            this.lbl_nuevo_code.Text = "Color original";
            // 
            // tkb_tolerancia
            // 
            this.tkb_tolerancia.Location = new System.Drawing.Point(93, 509);
            this.tkb_tolerancia.Maximum = 255;
            this.tkb_tolerancia.Name = "tkb_tolerancia";
            this.tkb_tolerancia.Size = new System.Drawing.Size(244, 45);
            this.tkb_tolerancia.TabIndex = 12;
            this.tkb_tolerancia.Value = 25;
            this.tkb_tolerancia.Scroll += new System.EventHandler(this.tkb_tolerancia_Scroll);
            // 
            // lbl_tolerancia
            // 
            this.lbl_tolerancia.AutoSize = true;
            this.lbl_tolerancia.Location = new System.Drawing.Point(343, 519);
            this.lbl_tolerancia.Name = "lbl_tolerancia";
            this.lbl_tolerancia.Size = new System.Drawing.Size(57, 13);
            this.lbl_tolerancia.TabIndex = 13;
            this.lbl_tolerancia.Text = "Tolerancia";
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Location = new System.Drawing.Point(148, 323);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(75, 23);
            this.btn_restaurar.TabIndex = 14;
            this.btn_restaurar.Text = "Restaurar";
            this.btn_restaurar.UseVisualStyleBackColor = true;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_deshacer
            // 
            this.btn_deshacer.Location = new System.Drawing.Point(248, 324);
            this.btn_deshacer.Name = "btn_deshacer";
            this.btn_deshacer.Size = new System.Drawing.Size(75, 23);
            this.btn_deshacer.TabIndex = 15;
            this.btn_deshacer.Text = "Deshacer";
            this.btn_deshacer.UseVisualStyleBackColor = true;
            this.btn_deshacer.Click += new System.EventHandler(this.btn_deshacer_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardar.Location = new System.Drawing.Point(12, 509);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 16;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_rehacer
            // 
            this.btn_rehacer.Location = new System.Drawing.Point(329, 324);
            this.btn_rehacer.Name = "btn_rehacer";
            this.btn_rehacer.Size = new System.Drawing.Size(75, 23);
            this.btn_rehacer.TabIndex = 17;
            this.btn_rehacer.Text = "Rehacer";
            this.btn_rehacer.UseVisualStyleBackColor = true;
            this.btn_rehacer.Click += new System.EventHandler(this.btn_rehacer_Click);
            // 
            // pbx_nuevo
            // 
            this.pbx_nuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_nuevo.Location = new System.Drawing.Point(279, 381);
            this.pbx_nuevo.Name = "pbx_nuevo";
            this.pbx_nuevo.Size = new System.Drawing.Size(100, 50);
            this.pbx_nuevo.TabIndex = 7;
            this.pbx_nuevo.TabStop = false;
            // 
            // pbx_original
            // 
            this.pbx_original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_original.Location = new System.Drawing.Point(120, 381);
            this.pbx_original.Name = "pbx_original";
            this.pbx_original.Size = new System.Drawing.Size(100, 50);
            this.pbx_original.TabIndex = 6;
            this.pbx_original.TabStop = false;
            // 
            // img_nueva
            // 
            this.img_nueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.img_nueva.Image = global::EditorDeImagenes.Properties.Resources.PicsArt_01_08_09_58_00;
            this.img_nueva.Location = new System.Drawing.Point(12, 12);
            this.img_nueva.Name = "img_nueva";
            this.img_nueva.Size = new System.Drawing.Size(392, 305);
            this.img_nueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_nueva.TabIndex = 1;
            this.img_nueva.TabStop = false;
            this.img_nueva.Paint += new System.Windows.Forms.PaintEventHandler(this.img_nueva_Paint);
            this.img_nueva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.img_original_MouseClick);
            this.img_nueva.MouseDown += new System.Windows.Forms.MouseEventHandler(this.img_nueva_MouseDown_1);
            this.img_nueva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.img_nueva_MouseMove_1);
            this.img_nueva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.img_nueva_MouseUp_1);
            // 
            // btn_rotar
            // 
            this.btn_rotar.Location = new System.Drawing.Point(13, 408);
            this.btn_rotar.Name = "btn_rotar";
            this.btn_rotar.Size = new System.Drawing.Size(75, 23);
            this.btn_rotar.TabIndex = 18;
            this.btn_rotar.Text = "Rotar";
            this.btn_rotar.UseVisualStyleBackColor = true;
            this.btn_rotar.Click += new System.EventHandler(this.btn_rotar_Click);
            // 
            // btn_espejo
            // 
            this.btn_espejo.Location = new System.Drawing.Point(13, 436);
            this.btn_espejo.Name = "btn_espejo";
            this.btn_espejo.Size = new System.Drawing.Size(75, 23);
            this.btn_espejo.TabIndex = 19;
            this.btn_espejo.Text = "Espejo";
            this.btn_espejo.UseVisualStyleBackColor = true;
            this.btn_espejo.Click += new System.EventHandler(this.btn_espejo_Click);
            // 
            // btnTransparantarSel
            // 
            this.btnTransparantarSel.Location = new System.Drawing.Point(13, 463);
            this.btnTransparantarSel.Name = "btnTransparantarSel";
            this.btnTransparantarSel.Size = new System.Drawing.Size(75, 23);
            this.btnTransparantarSel.TabIndex = 20;
            this.btnTransparantarSel.Text = "Alpha";
            this.btnTransparantarSel.UseVisualStyleBackColor = true;
            this.btnTransparantarSel.Click += new System.EventHandler(this.BtnTransparantarSel_Click);
            // 
            // tkb_transparencia
            // 
            this.tkb_transparencia.Location = new System.Drawing.Point(93, 553);
            this.tkb_transparencia.Maximum = 255;
            this.tkb_transparencia.Name = "tkb_transparencia";
            this.tkb_transparencia.Size = new System.Drawing.Size(244, 45);
            this.tkb_transparencia.TabIndex = 21;
            this.tkb_transparencia.Value = 25;
            this.tkb_transparencia.Scroll += new System.EventHandler(this.Tkb_transparencia_Scroll);
            // 
            // lbl_transparencia
            // 
            this.lbl_transparencia.AutoSize = true;
            this.lbl_transparencia.Location = new System.Drawing.Point(329, 567);
            this.lbl_transparencia.Name = "lbl_transparencia";
            this.lbl_transparencia.Size = new System.Drawing.Size(75, 13);
            this.lbl_transparencia.TabIndex = 22;
            this.lbl_transparencia.Text = "Transparencia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 610);
            this.Controls.Add(this.lbl_transparencia);
            this.Controls.Add(this.tkb_transparencia);
            this.Controls.Add(this.btnTransparantarSel);
            this.Controls.Add(this.btn_espejo);
            this.Controls.Add(this.btn_rotar);
            this.Controls.Add(this.btn_rehacer);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_deshacer);
            this.Controls.Add(this.btn_restaurar);
            this.Controls.Add(this.lbl_tolerancia);
            this.Controls.Add(this.tkb_tolerancia);
            this.Controls.Add(this.lbl_nuevo_code);
            this.Controls.Add(this.lbl_original_code);
            this.Controls.Add(this.lbl_color_nuevo);
            this.Controls.Add(this.lbl_color_original);
            this.Controls.Add(this.pbx_nuevo);
            this.Controls.Add(this.pbx_original);
            this.Controls.Add(this.btn_elegir_color);
            this.Controls.Add(this.btn_clonar);
            this.Controls.Add(this.btn_cargar_img);
            this.Controls.Add(this.img_nueva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tkb_tolerancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_nuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_nueva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkb_transparencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox img_nueva;
        private System.Windows.Forms.OpenFileDialog opf_dialog;
        private System.Windows.Forms.Button btn_cargar_img;
        private System.Windows.Forms.Button btn_clonar;
        private System.Windows.Forms.ColorDialog cld_nuevo_color;
        private System.Windows.Forms.Button btn_elegir_color;
        private System.Windows.Forms.PictureBox pbx_original;
        private System.Windows.Forms.PictureBox pbx_nuevo;
        private System.Windows.Forms.Label lbl_color_original;
        private System.Windows.Forms.Label lbl_color_nuevo;
        private System.Windows.Forms.Label lbl_original_code;
        private System.Windows.Forms.Label lbl_nuevo_code;
        private System.Windows.Forms.TrackBar tkb_tolerancia;
        private System.Windows.Forms.Label lbl_tolerancia;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Button btn_deshacer;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_rehacer;
        private System.Windows.Forms.SaveFileDialog sfd_savedialog;
        private System.Windows.Forms.Button btn_rotar;
        private System.Windows.Forms.Button btn_espejo;
        private System.Windows.Forms.Button btnTransparantarSel;
        private System.Windows.Forms.TrackBar tkb_transparencia;
        private System.Windows.Forms.Label lbl_transparencia;
    }
}

