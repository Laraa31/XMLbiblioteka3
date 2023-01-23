namespace XMLZadatak
{
    partial class Pretraga
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
            this.rtbIspis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivKnj = new System.Windows.Forms.TextBox();
            this.txtImeKor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnPretraziKnj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.btnPretraziKor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbIspis
            // 
            this.rtbIspis.Location = new System.Drawing.Point(232, 10);
            this.rtbIspis.Name = "rtbIspis";
            this.rtbIspis.Size = new System.Drawing.Size(526, 525);
            this.rtbIspis.TabIndex = 0;
            this.rtbIspis.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naziv knjige";
            // 
            // txtNazivKnj
            // 
            this.txtNazivKnj.Location = new System.Drawing.Point(28, 34);
            this.txtNazivKnj.Name = "txtNazivKnj";
            this.txtNazivKnj.Size = new System.Drawing.Size(172, 20);
            this.txtNazivKnj.TabIndex = 6;
            // 
            // txtImeKor
            // 
            this.txtImeKor.Location = new System.Drawing.Point(28, 331);
            this.txtImeKor.Name = "txtImeKor";
            this.txtImeKor.Size = new System.Drawing.Size(172, 20);
            this.txtImeKor.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime korisnika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prezime korisnika";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(28, 388);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(172, 20);
            this.txtPrezime.TabIndex = 10;
            // 
            // btnPretraziKnj
            // 
            this.btnPretraziKnj.Location = new System.Drawing.Point(59, 246);
            this.btnPretraziKnj.Name = "btnPretraziKnj";
            this.btnPretraziKnj.Size = new System.Drawing.Size(97, 23);
            this.btnPretraziKnj.TabIndex = 12;
            this.btnPretraziKnj.Text = "Pretraži knjigu";
            this.btnPretraziKnj.UseVisualStyleBackColor = true;
            this.btnPretraziKnj.Click += new System.EventHandler(this.btnPretraziKnj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ISBN knjige";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(28, 203);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(172, 20);
            this.txtISBN.TabIndex = 13;
            this.txtISBN.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "OIB korisnika";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(28, 450);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(172, 20);
            this.txtOIB.TabIndex = 15;
            // 
            // btnPretraziKor
            // 
            this.btnPretraziKor.Location = new System.Drawing.Point(59, 498);
            this.btnPretraziKor.Name = "btnPretraziKor";
            this.btnPretraziKor.Size = new System.Drawing.Size(97, 23);
            this.btnPretraziKor.TabIndex = 18;
            this.btnPretraziKor.Text = "Pretraži korisnika";
            this.btnPretraziKor.UseVisualStyleBackColor = true;
            this.btnPretraziKor.Click += new System.EventHandler(this.btnPretraziKor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(28, 146);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(172, 20);
            this.txtKolicina.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(28, 91);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(172, 20);
            this.txtAutor.TabIndex = 21;
            // 
            // Pretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 558);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.btnPretraziKor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.btnPretraziKnj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImeKor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazivKnj);
            this.Controls.Add(this.rtbIspis);
            this.Name = "Pretraga";
            this.Text = "Pretraga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbIspis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivKnj;
        private System.Windows.Forms.TextBox txtImeKor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnPretraziKnj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Button btnPretraziKor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAutor;
    }
}