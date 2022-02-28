
namespace MyAntivirus
{
    partial class frm_antivirus
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_antivirus));
            this.lbl_ruta = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_res = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_secuencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ruta
            // 
            this.lbl_ruta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ruta.ForeColor = System.Drawing.Color.White;
            this.lbl_ruta.Location = new System.Drawing.Point(52, 137);
            this.lbl_ruta.Name = "lbl_ruta";
            this.lbl_ruta.Size = new System.Drawing.Size(531, 37);
            this.lbl_ruta.TabIndex = 0;
            this.lbl_ruta.Click += new System.EventHandler(this.lbl_ruta_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_buscar.Location = new System.Drawing.Point(604, 139);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(166, 35);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Seleccionar archivo";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_res
            // 
            this.lbl_res.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_res.ForeColor = System.Drawing.Color.White;
            this.lbl_res.Location = new System.Drawing.Point(472, 309);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(298, 176);
            this.lbl_res.TabIndex = 2;
            this.lbl_res.Click += new System.EventHandler(this.lbl_res_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(516, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Analizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_secuencia
            // 
            this.txt_secuencia.BackColor = System.Drawing.Color.LightSlateGray;
            this.txt_secuencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_secuencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_secuencia.ForeColor = System.Drawing.Color.White;
            this.txt_secuencia.Location = new System.Drawing.Point(61, 193);
            this.txt_secuencia.Multiline = true;
            this.txt_secuencia.Name = "txt_secuencia";
            this.txt_secuencia.ReadOnly = true;
            this.txt_secuencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_secuencia.Size = new System.Drawing.Size(368, 275);
            this.txt_secuencia.TabIndex = 5;
            this.txt_secuencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 37);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyAntivirus.Properties.Resources.nanologo;
            this.pictureBox1.Location = new System.Drawing.Point(259, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_antivirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.txt_secuencia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_ruta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frm_antivirus";
            this.Text = "Antivirus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ruta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_secuencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

