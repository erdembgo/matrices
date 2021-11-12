namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnHazirla = new System.Windows.Forms.Button();
            this.gbMatris1 = new System.Windows.Forms.GroupBox();
            this.gbMatris2 = new System.Windows.Forms.GroupBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.gbMatris3 = new System.Windows.Forms.GroupBox();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnTers1 = new System.Windows.Forms.Button();
            this.btnTers2 = new System.Windows.Forms.Button();
            this.btnDegis12 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKatsayiM1 = new System.Windows.Forms.TextBox();
            this.tbKatsayiM2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYardim = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btndegis1 = new System.Windows.Forms.Button();
            this.btnDegis2 = new System.Windows.Forms.Button();
            this.btnTemizle1 = new System.Windows.Forms.Button();
            this.btnTemizle2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHazirla
            // 
            this.btnHazirla.Location = new System.Drawing.Point(27, 12);
            this.btnHazirla.Name = "btnHazirla";
            this.btnHazirla.Size = new System.Drawing.Size(75, 23);
            this.btnHazirla.TabIndex = 0;
            this.btnHazirla.Text = "Hazırla";
            this.btnHazirla.UseVisualStyleBackColor = true;
            this.btnHazirla.Click += new System.EventHandler(this.btnHazirla_Click);
            // 
            // gbMatris1
            // 
            this.gbMatris1.Location = new System.Drawing.Point(12, 57);
            this.gbMatris1.Name = "gbMatris1";
            this.gbMatris1.Size = new System.Drawing.Size(211, 223);
            this.gbMatris1.TabIndex = 1;
            this.gbMatris1.TabStop = false;
            this.gbMatris1.Text = "Matris1";
            // 
            // gbMatris2
            // 
            this.gbMatris2.Location = new System.Drawing.Point(315, 57);
            this.gbMatris2.Name = "gbMatris2";
            this.gbMatris2.Size = new System.Drawing.Size(223, 223);
            this.gbMatris2.TabIndex = 0;
            this.gbMatris2.TabStop = false;
            this.gbMatris2.Text = "Matris2";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(129, 12);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // gbMatris3
            // 
            this.gbMatris3.Location = new System.Drawing.Point(129, 286);
            this.gbMatris3.Name = "gbMatris3";
            this.gbMatris3.Size = new System.Drawing.Size(223, 223);
            this.gbMatris3.TabIndex = 3;
            this.gbMatris3.TabStop = false;
            this.gbMatris3.Text = "Matris3";
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(336, 12);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(75, 23);
            this.btnCarp.TabIndex = 5;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(229, 12);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 23);
            this.btnCikar.TabIndex = 7;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnTers1
            // 
            this.btnTers1.Location = new System.Drawing.Point(18, 286);
            this.btnTers1.Name = "btnTers1";
            this.btnTers1.Size = new System.Drawing.Size(96, 23);
            this.btnTers1.TabIndex = 8;
            this.btnTers1.Text = "1. Devriği Al";
            this.btnTers1.UseVisualStyleBackColor = true;
            this.btnTers1.Click += new System.EventHandler(this.btnTers1_Click);
            // 
            // btnTers2
            // 
            this.btnTers2.Location = new System.Drawing.Point(369, 286);
            this.btnTers2.Name = "btnTers2";
            this.btnTers2.Size = new System.Drawing.Size(96, 23);
            this.btnTers2.TabIndex = 9;
            this.btnTers2.Text = "2. Devriğini Al";
            this.btnTers2.UseVisualStyleBackColor = true;
            this.btnTers2.Click += new System.EventHandler(this.btnTers2_Click);
            // 
            // btnDegis12
            // 
            this.btnDegis12.Location = new System.Drawing.Point(234, 153);
            this.btnDegis12.Name = "btnDegis12";
            this.btnDegis12.Size = new System.Drawing.Size(75, 23);
            this.btnDegis12.TabIndex = 10;
            this.btnDegis12.Text = "2<=>1";
            this.btnDegis12.UseVisualStyleBackColor = true;
            this.btnDegis12.Click += new System.EventHandler(this.btnDegis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(444, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Katsayı M1:";
            // 
            // tbKatsayiM1
            // 
            this.tbKatsayiM1.Location = new System.Drawing.Point(83, 38);
            this.tbKatsayiM1.Name = "tbKatsayiM1";
            this.tbKatsayiM1.Size = new System.Drawing.Size(50, 20);
            this.tbKatsayiM1.TabIndex = 13;
            this.tbKatsayiM1.Text = "1";
            // 
            // tbKatsayiM2
            // 
            this.tbKatsayiM2.Location = new System.Drawing.Point(380, 38);
            this.tbKatsayiM2.Name = "tbKatsayiM2";
            this.tbKatsayiM2.Size = new System.Drawing.Size(50, 20);
            this.tbKatsayiM2.TabIndex = 15;
            this.tbKatsayiM2.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Katsayı M2:";
            // 
            // btnYardim
            // 
            this.btnYardim.Location = new System.Drawing.Point(382, 478);
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(75, 23);
            this.btnYardim.TabIndex = 16;
            this.btnYardim.Text = "Yardım";
            this.btnYardim.UseVisualStyleBackColor = true;
            this.btnYardim.Click += new System.EventHandler(this.btnYardim_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(463, 478);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 17;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btndegis1
            // 
            this.btndegis1.Location = new System.Drawing.Point(58, 361);
            this.btndegis1.Name = "btndegis1";
            this.btndegis1.Size = new System.Drawing.Size(61, 23);
            this.btndegis1.TabIndex = 18;
            this.btndegis1.Text = "3=>1";
            this.btndegis1.UseVisualStyleBackColor = true;
            this.btndegis1.Click += new System.EventHandler(this.btndegis1_Click);
            // 
            // btnDegis2
            // 
            this.btnDegis2.Location = new System.Drawing.Point(369, 361);
            this.btnDegis2.Name = "btnDegis2";
            this.btnDegis2.Size = new System.Drawing.Size(61, 23);
            this.btnDegis2.TabIndex = 19;
            this.btnDegis2.Text = "3=>2";
            this.btnDegis2.UseVisualStyleBackColor = true;
            this.btnDegis2.Click += new System.EventHandler(this.btnDegis2_Click);
            // 
            // btnTemizle1
            // 
            this.btnTemizle1.Location = new System.Drawing.Point(234, 109);
            this.btnTemizle1.Name = "btnTemizle1";
            this.btnTemizle1.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle1.TabIndex = 20;
            this.btnTemizle1.Text = "<=Temizle1";
            this.btnTemizle1.UseVisualStyleBackColor = true;
            this.btnTemizle1.Click += new System.EventHandler(this.btnTemizle1_Click);
            // 
            // btnTemizle2
            // 
            this.btnTemizle2.Location = new System.Drawing.Point(234, 200);
            this.btnTemizle2.Name = "btnTemizle2";
            this.btnTemizle2.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle2.TabIndex = 21;
            this.btnTemizle2.Text = "Temizle2=>";
            this.btnTemizle2.UseVisualStyleBackColor = true;
            this.btnTemizle2.Click += new System.EventHandler(this.btnTemizle2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 513);
            this.Controls.Add(this.btnTemizle2);
            this.Controls.Add(this.btnTemizle1);
            this.Controls.Add(this.btnDegis2);
            this.Controls.Add(this.btndegis1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYardim);
            this.Controls.Add(this.tbKatsayiM2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKatsayiM1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnDegis12);
            this.Controls.Add(this.btnTers2);
            this.Controls.Add(this.btnTers1);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.gbMatris3);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.gbMatris2);
            this.Controls.Add(this.gbMatris1);
            this.Controls.Add(this.btnHazirla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHazirla;
        private System.Windows.Forms.GroupBox gbMatris1;
        private System.Windows.Forms.GroupBox gbMatris2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.GroupBox gbMatris3;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnTers1;
        private System.Windows.Forms.Button btnTers2;
        private System.Windows.Forms.Button btnDegis12;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKatsayiM1;
        private System.Windows.Forms.TextBox tbKatsayiM2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYardim;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btndegis1;
        private System.Windows.Forms.Button btnDegis2;
        private System.Windows.Forms.Button btnTemizle1;
        private System.Windows.Forms.Button btnTemizle2;
    }
}

