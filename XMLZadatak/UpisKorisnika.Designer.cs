namespace XMLZadatak
{
    partial class UpisKorisnika
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
            this.txtbImeKor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbPrezimeKor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbOIBKor = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbImeKor
            // 
            this.txtbImeKor.Location = new System.Drawing.Point(35, 34);
            this.txtbImeKor.Name = "txtbImeKor";
            this.txtbImeKor.Size = new System.Drawing.Size(172, 20);
            this.txtbImeKor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // txtbPrezimeKor
            // 
            this.txtbPrezimeKor.Location = new System.Drawing.Point(35, 111);
            this.txtbPrezimeKor.Name = "txtbPrezimeKor";
            this.txtbPrezimeKor.Size = new System.Drawing.Size(172, 20);
            this.txtbPrezimeKor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "OIB";
            // 
            // txtbOIBKor
            // 
            this.txtbOIBKor.Location = new System.Drawing.Point(35, 198);
            this.txtbOIBKor.Name = "txtbOIBKor";
            this.txtbOIBKor.Size = new System.Drawing.Size(172, 20);
            this.txtbOIBKor.TabIndex = 4;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(83, 250);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 6;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // UpisKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 301);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbOIBKor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbPrezimeKor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbImeKor);
            this.Name = "UpisKorisnika";
            this.Text = "UpisKorisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbImeKor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbPrezimeKor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbOIBKor;
        private System.Windows.Forms.Button btnUnos;
    }
}