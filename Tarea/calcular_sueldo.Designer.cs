
namespace Tarea
{
    partial class calcular_sueldo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Calcular_Sueldo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Sueldo_Diaro = new System.Windows.Forms.TextBox();
            this.lbl_r = new System.Windows.Forms.Label();
            this.txt_horas_l = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Calcular_Sueldo
            // 
            this.btn_Calcular_Sueldo.Location = new System.Drawing.Point(234, 315);
            this.btn_Calcular_Sueldo.Name = "btn_Calcular_Sueldo";
            this.btn_Calcular_Sueldo.Size = new System.Drawing.Size(276, 61);
            this.btn_Calcular_Sueldo.TabIndex = 0;
            this.btn_Calcular_Sueldo.Text = "Calcular";
            this.btn_Calcular_Sueldo.UseVisualStyleBackColor = true;
            this.btn_Calcular_Sueldo.Click += new System.EventHandler(this.btn_Calcular_Sueldo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sueldo diario";
            // 
            // txt_Sueldo_Diaro
            // 
            this.txt_Sueldo_Diaro.Location = new System.Drawing.Point(296, 94);
            this.txt_Sueldo_Diaro.Name = "txt_Sueldo_Diaro";
            this.txt_Sueldo_Diaro.Size = new System.Drawing.Size(266, 31);
            this.txt_Sueldo_Diaro.TabIndex = 2;
            // 
            // lbl_r
            // 
            this.lbl_r.AutoSize = true;
            this.lbl_r.Location = new System.Drawing.Point(142, 278);
            this.lbl_r.Name = "lbl_r";
            this.lbl_r.Size = new System.Drawing.Size(19, 25);
            this.lbl_r.TabIndex = 3;
            this.lbl_r.Text = "r";
            // 
            // txt_horas_l
            // 
            this.txt_horas_l.Location = new System.Drawing.Point(296, 165);
            this.txt_horas_l.Name = "txt_horas_l";
            this.txt_horas_l.Size = new System.Drawing.Size(266, 31);
            this.txt_horas_l.TabIndex = 4;
            this.txt_horas_l.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horas laborales";
            // 
            // calcular_sueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_horas_l);
            this.Controls.Add(this.lbl_r);
            this.Controls.Add(this.txt_Sueldo_Diaro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calcular_Sueldo);
            this.Name = "calcular_sueldo";
            this.Text = "calcular_sueldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular_Sueldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Sueldo_Diaro;
        private System.Windows.Forms.Label lbl_r;
        private System.Windows.Forms.TextBox txt_horas_l;
        private System.Windows.Forms.Label label2;
    }
}