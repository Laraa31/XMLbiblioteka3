namespace XMLZadatak
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
            this.upisKorisnika = new System.Windows.Forms.Button();
            this.upisKnjiga = new System.Windows.Forms.Button();
            this.pretraga = new System.Windows.Forms.Button();
            this.vracanjePosudba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upisKorisnika
            // 
            this.upisKorisnika.Location = new System.Drawing.Point(12, 12);
            this.upisKorisnika.Name = "upisKorisnika";
            this.upisKorisnika.Size = new System.Drawing.Size(140, 47);
            this.upisKorisnika.TabIndex = 0;
            this.upisKorisnika.Text = "Upis korisnika";
            this.upisKorisnika.UseVisualStyleBackColor = true;
            this.upisKorisnika.Click += new System.EventHandler(this.upisKorisnika_Click);
            // 
            // upisKnjiga
            // 
            this.upisKnjiga.Location = new System.Drawing.Point(177, 12);
            this.upisKnjiga.Name = "upisKnjiga";
            this.upisKnjiga.Size = new System.Drawing.Size(140, 47);
            this.upisKnjiga.TabIndex = 1;
            this.upisKnjiga.Text = "Upis knjiga";
            this.upisKnjiga.UseVisualStyleBackColor = true;
            this.upisKnjiga.Click += new System.EventHandler(this.upisKnjiga_Click);
            // 
            // pretraga
            // 
            this.pretraga.Location = new System.Drawing.Point(12, 65);
            this.pretraga.Name = "pretraga";
            this.pretraga.Size = new System.Drawing.Size(140, 47);
            this.pretraga.TabIndex = 2;
            this.pretraga.Text = "Pretraga";
            this.pretraga.UseVisualStyleBackColor = true;
            this.pretraga.Click += new System.EventHandler(this.pretraga_Click);
            // 
            // vracanjePosudba
            // 
            this.vracanjePosudba.Location = new System.Drawing.Point(177, 65);
            this.vracanjePosudba.Name = "vracanjePosudba";
            this.vracanjePosudba.Size = new System.Drawing.Size(140, 47);
            this.vracanjePosudba.TabIndex = 3;
            this.vracanjePosudba.Text = "Vraćanje / Posudba";
            this.vracanjePosudba.UseVisualStyleBackColor = true;
            this.vracanjePosudba.Click += new System.EventHandler(this.vracanjePosudba_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 132);
            this.Controls.Add(this.vracanjePosudba);
            this.Controls.Add(this.pretraga);
            this.Controls.Add(this.upisKnjiga);
            this.Controls.Add(this.upisKorisnika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upisKorisnika;
        private System.Windows.Forms.Button upisKnjiga;
        private System.Windows.Forms.Button pretraga;
        private System.Windows.Forms.Button vracanjePosudba;
    }
}

