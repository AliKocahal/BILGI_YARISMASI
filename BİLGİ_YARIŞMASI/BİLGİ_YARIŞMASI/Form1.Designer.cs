namespace BİLGİ_YARIŞMASI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.lblSoruno = new System.Windows.Forms.Label();
            this.lblDoğru = new System.Windows.Forms.Label();
            this.lblYanlış = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSonraki = new System.Windows.Forms.Button();
            this.ptbDoğru = new System.Windows.Forms.PictureBox();
            this.ptbYanlış = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDoğru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYanlış)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(455, 154);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnA
            // 
            this.BtnA.Location = new System.Drawing.Point(39, 201);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(204, 62);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Location = new System.Drawing.Point(268, 201);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(226, 62);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(39, 292);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(204, 62);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Location = new System.Drawing.Point(268, 292);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(226, 62);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // lblSoruno
            // 
            this.lblSoruno.AutoSize = true;
            this.lblSoruno.Location = new System.Drawing.Point(535, 40);
            this.lblSoruno.Name = "lblSoruno";
            this.lblSoruno.Size = new System.Drawing.Size(93, 29);
            this.lblSoruno.TabIndex = 5;
            this.lblSoruno.Text = "soru no:";
            // 
            // lblDoğru
            // 
            this.lblDoğru.AutoSize = true;
            this.lblDoğru.Location = new System.Drawing.Point(550, 90);
            this.lblDoğru.Name = "lblDoğru";
            this.lblDoğru.Size = new System.Drawing.Size(78, 29);
            this.lblDoğru.TabIndex = 6;
            this.lblDoğru.Text = "doğru:";
            // 
            // lblYanlış
            // 
            this.lblYanlış.AutoSize = true;
            this.lblYanlış.Location = new System.Drawing.Point(550, 138);
            this.lblYanlış.Name = "lblYanlış";
            this.lblYanlış.Size = new System.Drawing.Size(78, 29);
            this.lblYanlış.TabIndex = 7;
            this.lblYanlış.Text = "yanlış:";
            this.lblYanlış.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "0";
            // 
            // BtnSonraki
            // 
            this.BtnSonraki.Location = new System.Drawing.Point(510, 201);
            this.BtnSonraki.Name = "BtnSonraki";
            this.BtnSonraki.Size = new System.Drawing.Size(168, 62);
            this.BtnSonraki.TabIndex = 11;
            this.BtnSonraki.Text = "sonraki \r\n";
            this.BtnSonraki.UseVisualStyleBackColor = true;
            this.BtnSonraki.Click += new System.EventHandler(this.BtnSonraki_Click);
            // 
            // ptbDoğru
            // 
            this.ptbDoğru.Image = ((System.Drawing.Image)(resources.GetObject("ptbDoğru.Image")));
            this.ptbDoğru.Location = new System.Drawing.Point(510, 269);
            this.ptbDoğru.Name = "ptbDoğru";
            this.ptbDoğru.Size = new System.Drawing.Size(81, 85);
            this.ptbDoğru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbDoğru.TabIndex = 12;
            this.ptbDoğru.TabStop = false;
            // 
            // ptbYanlış
            // 
            this.ptbYanlış.Image = ((System.Drawing.Image)(resources.GetObject("ptbYanlış.Image")));
            this.ptbYanlış.Location = new System.Drawing.Point(597, 269);
            this.ptbYanlış.Name = "ptbYanlış";
            this.ptbYanlış.Size = new System.Drawing.Size(81, 85);
            this.ptbYanlış.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbYanlış.TabIndex = 13;
            this.ptbYanlış.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbYanlış);
            this.Controls.Add(this.ptbDoğru);
            this.Controls.Add(this.BtnSonraki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblYanlış);
            this.Controls.Add(this.lblDoğru);
            this.Controls.Add(this.lblSoruno);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbDoğru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYanlış)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label lblSoruno;
        private System.Windows.Forms.Label lblDoğru;
        private System.Windows.Forms.Label lblYanlış;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.PictureBox ptbDoğru;
        private System.Windows.Forms.PictureBox ptbYanlış;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

