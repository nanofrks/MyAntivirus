
namespace MyAntivirus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_ruta = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_res = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_secuencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_ruta
            // 
            this.lbl_ruta.AutoSize = true;
            this.lbl_ruta.Location = new System.Drawing.Point(99, 112);
            this.lbl_ruta.Name = "lbl_ruta";
            this.lbl_ruta.Size = new System.Drawing.Size(25, 15);
            this.lbl_ruta.TabIndex = 0;
            this.lbl_ruta.Text = "aaa";
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_buscar.Font = new System.Drawing.Font("Crystal Radio Kit", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_buscar.Location = new System.Drawing.Point(508, 80);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(166, 70);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(645, 331);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(38, 15);
            this.lbl_res.TabIndex = 2;
            this.lbl_res.Text = "label2";
            this.lbl_res.Click += new System.EventHandler(this.lbl_res_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Crystal Radio Kit", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(508, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Analizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Japanese 2020", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(264, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nano antivirus";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_secuencia
            // 
            this.txt_secuencia.BackColor = System.Drawing.SystemColors.Control;
            this.txt_secuencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_secuencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_secuencia.Location = new System.Drawing.Point(70, 231);
            this.txt_secuencia.Multiline = true;
            this.txt_secuencia.Name = "txt_secuencia";
            this.txt_secuencia.ReadOnly = true;
            this.txt_secuencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_secuencia.Size = new System.Drawing.Size(355, 275);
            this.txt_secuencia.TabIndex = 5;
            this.txt_secuencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.txt_secuencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_ruta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Antivirus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ruta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_secuencia;
    }
}

