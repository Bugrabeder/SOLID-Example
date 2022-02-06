
namespace SingleResponsibility
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
            this.hesapAdi = new System.Windows.Forms.TextBox();
            this.tutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toplamPara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paraEkleme = new System.Windows.Forms.Button();
            this.Eurotextbox = new System.Windows.Forms.TextBox();
            this.dolartextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesapAdi
            // 
            this.hesapAdi.Location = new System.Drawing.Point(65, 154);
            this.hesapAdi.Name = "hesapAdi";
            this.hesapAdi.Size = new System.Drawing.Size(125, 27);
            this.hesapAdi.TabIndex = 0;
            // 
            // tutar
            // 
            this.tutar.Location = new System.Drawing.Point(722, 154);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(125, 27);
            this.tutar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(762, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hesap Adı Gİriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(204, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hesaba Para Ekleme Ekranına Hoşgeldiniz";
            // 
            // toplamPara
            // 
            this.toplamPara.Location = new System.Drawing.Point(65, 479);
            this.toplamPara.Name = "toplamPara";
            this.toplamPara.Size = new System.Drawing.Size(125, 27);
            this.toplamPara.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(365, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hesaptaki Aktarılan Para";
            // 
            // paraEkleme
            // 
            this.paraEkleme.BackColor = System.Drawing.SystemColors.Window;
            this.paraEkleme.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paraEkleme.Location = new System.Drawing.Point(399, 202);
            this.paraEkleme.Name = "paraEkleme";
            this.paraEkleme.Size = new System.Drawing.Size(125, 70);
            this.paraEkleme.TabIndex = 7;
            this.paraEkleme.Text = "Para Ekle";
            this.paraEkleme.UseVisualStyleBackColor = false;
            this.paraEkleme.Click += new System.EventHandler(this.paraEkleme_Click);
            // 
            // Eurotextbox
            // 
            this.Eurotextbox.Location = new System.Drawing.Point(399, 479);
            this.Eurotextbox.Name = "Eurotextbox";
            this.Eurotextbox.Size = new System.Drawing.Size(125, 27);
            this.Eurotextbox.TabIndex = 8;
            // 
            // dolartextbox
            // 
            this.dolartextbox.Location = new System.Drawing.Point(722, 479);
            this.dolartextbox.Name = "dolartextbox";
            this.dolartextbox.Size = new System.Drawing.Size(125, 27);
            this.dolartextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(111, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(434, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Euro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(762, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dolar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 581);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dolartextbox);
            this.Controls.Add(this.Eurotextbox);
            this.Controls.Add(this.paraEkleme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toplamPara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.hesapAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hesapAdi;
        private System.Windows.Forms.TextBox tutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toplamPara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button paraEkleme;
        private System.Windows.Forms.TextBox Eurotextbox;
        private System.Windows.Forms.TextBox dolartextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

