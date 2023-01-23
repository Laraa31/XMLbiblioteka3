namespace XMLZadatak
{
    partial class UpisKnjiga
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNazivKnj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbAutorKnj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbKolicinaKnj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbISBNKnj = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv";
            // 
            // txtbNazivKnj
            // 
            this.txtbNazivKnj.Location = new System.Drawing.Point(56, 49);
            this.txtbNazivKnj.Name = "txtbNazivKnj";
            this.txtbNazivKnj.Size = new System.Drawing.Size(172, 20);
            this.txtbNazivKnj.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Autor";
            // 
            // txtbAutorKnj
            // 
            this.txtbAutorKnj.Location = new System.Drawing.Point(56, 119);
            this.txtbAutorKnj.Name = "txtbAutorKnj";
            this.txtbAutorKnj.Size = new System.Drawing.Size(172, 20);
            this.txtbAutorKnj.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Količina";
            // 
            // txtbKolicinaKnj
            // 
            this.txtbKolicinaKnj.Location = new System.Drawing.Point(56, 184);
            this.txtbKolicinaKnj.Name = "txtbKolicinaKnj";
            this.txtbKolicinaKnj.Size = new System.Drawing.Size(172, 20);
            this.txtbKolicinaKnj.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ISBN";
            // 
            // txtbISBNKnj
            // 
            this.txtbISBNKnj.Location = new System.Drawing.Point(56, 253);
            this.txtbISBNKnj.Name = "txtbISBNKnj";
            this.txtbISBNKnj.Size = new System.Drawing.Size(172, 20);
            this.txtbISBNKnj.TabIndex = 10;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(102, 304);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 12;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // UpisKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 368);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbISBNKnj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbKolicinaKnj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbAutorKnj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNazivKnj);
            this.Name = "UpisKnjiga";
            this.Text = "UpisKnjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNazivKnj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbAutorKnj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbKolicinaKnj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbISBNKnj;
        private System.Windows.Forms.Button btnUnos;
    }
}