namespace XMLZadatak
{
    partial class VracanjePosudba
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
            this.btnPosudba = new System.Windows.Forms.Button();
            this.btnVracanje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOIBKor = new System.Windows.Forms.TextBox();
            this.txtISBNKnj = new System.Windows.Forms.TextBox();
            this.txtDatPos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDatVrac = new System.Windows.Forms.TextBox();
            this.txtISBNknjV = new System.Windows.Forms.TextBox();
            this.txtOIBKorV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPosudba
            // 
            this.btnPosudba.Location = new System.Drawing.Point(61, 184);
            this.btnPosudba.Name = "btnPosudba";
            this.btnPosudba.Size = new System.Drawing.Size(75, 23);
            this.btnPosudba.TabIndex = 0;
            this.btnPosudba.Text = "Unesi";
            this.btnPosudba.UseVisualStyleBackColor = true;
            this.btnPosudba.Click += new System.EventHandler(this.btnPosudba_Click);
            // 
            // btnVracanje
            // 
            this.btnVracanje.Location = new System.Drawing.Point(312, 184);
            this.btnVracanje.Name = "btnVracanje";
            this.btnVracanje.Size = new System.Drawing.Size(75, 23);
            this.btnVracanje.TabIndex = 1;
            this.btnVracanje.Text = "Unesi";
            this.btnVracanje.UseVisualStyleBackColor = true;
            this.btnVracanje.Click += new System.EventHandler(this.btnVracanje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Posudba";
            // 
            // txtOIBKor
            // 
            this.txtOIBKor.Location = new System.Drawing.Point(91, 59);
            this.txtOIBKor.Name = "txtOIBKor";
            this.txtOIBKor.Size = new System.Drawing.Size(100, 20);
            this.txtOIBKor.TabIndex = 4;
            this.txtOIBKor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtISBNKnj
            // 
            this.txtISBNKnj.Location = new System.Drawing.Point(91, 99);
            this.txtISBNKnj.Name = "txtISBNKnj";
            this.txtISBNKnj.Size = new System.Drawing.Size(100, 20);
            this.txtISBNKnj.TabIndex = 5;
            this.txtISBNKnj.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDatPos
            // 
            this.txtDatPos.Location = new System.Drawing.Point(120, 140);
            this.txtDatPos.Name = "txtDatPos";
            this.txtDatPos.Size = new System.Drawing.Size(100, 20);
            this.txtDatPos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "OIB korisnika:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ISBN knjige:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum posuđivanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(282, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vraćanje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Datum vraćanja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ISBN knjige:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "OIB korisnika:";
            // 
            // txtDatVrac
            // 
            this.txtDatVrac.Location = new System.Drawing.Point(346, 140);
            this.txtDatVrac.Name = "txtDatVrac";
            this.txtDatVrac.Size = new System.Drawing.Size(100, 20);
            this.txtDatVrac.TabIndex = 13;
            // 
            // txtISBNknjV
            // 
            this.txtISBNknjV.Location = new System.Drawing.Point(332, 99);
            this.txtISBNknjV.Name = "txtISBNknjV";
            this.txtISBNknjV.Size = new System.Drawing.Size(100, 20);
            this.txtISBNknjV.TabIndex = 12;
            // 
            // txtOIBKorV
            // 
            this.txtOIBKorV.Location = new System.Drawing.Point(332, 59);
            this.txtOIBKorV.Name = "txtOIBKorV";
            this.txtOIBKorV.Size = new System.Drawing.Size(100, 20);
            this.txtOIBKorV.TabIndex = 11;
            // 
            // VracanjePosudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 234);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDatVrac);
            this.Controls.Add(this.txtISBNknjV);
            this.Controls.Add(this.txtOIBKorV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatPos);
            this.Controls.Add(this.txtISBNKnj);
            this.Controls.Add(this.txtOIBKor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVracanje);
            this.Controls.Add(this.btnPosudba);
            this.Name = "VracanjePosudba";
            this.Text = "VraćanjePosudba";
            this.Load += new System.EventHandler(this.VracanjePosudba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPosudba;
        private System.Windows.Forms.Button btnVracanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOIBKor;
        private System.Windows.Forms.TextBox txtISBNKnj;
        private System.Windows.Forms.TextBox txtDatPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDatVrac;
        private System.Windows.Forms.TextBox txtISBNknjV;
        private System.Windows.Forms.TextBox txtOIBKorV;
    }
}