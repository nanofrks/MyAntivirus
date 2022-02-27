
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
            this.lbl_ruta.Location = new System.Drawing.Point(160, 103);
            this.lbl_ruta.Name = "lbl_ruta";
            this.lbl_ruta.Size = new System.Drawing.Size(38, 15);
            this.lbl_ruta.TabIndex = 0;
            this.lbl_ruta.Text = "label1";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(562, 112);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(160, 187);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(38, 15);
            this.lbl_res.TabIndex = 2;
            this.lbl_res.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nano antivirus";
            // 
            // txt_secuencia
            // 
            this.txt_secuencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_secuencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_secuencia.Location = new System.Drawing.Point(151, 252);
            this.txt_secuencia.Multiline = true;
            this.txt_secuencia.Name = "txt_secuencia";
            this.txt_secuencia.ReadOnly = true;
            this.txt_secuencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_secuencia.Size = new System.Drawing.Size(540, 161);
            this.txt_secuencia.TabIndex = 5;
            this.txt_secuencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_secuencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_ruta);
            this.Name = "Form1";
            this.Text = "Form1";
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

