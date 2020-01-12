namespace MojNovcanik
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtImeP = new System.Windows.Forms.TextBox();
            this.txtSifraP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.btnRegistrujSe = new System.Windows.Forms.Button();
            this.lblObavestenja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtImeP
            // 
            this.txtImeP.Location = new System.Drawing.Point(121, 76);
            this.txtImeP.Name = "txtImeP";
            this.txtImeP.Size = new System.Drawing.Size(100, 20);
            this.txtImeP.TabIndex = 1;
            // 
            // txtSifraP
            // 
            this.txtSifraP.Location = new System.Drawing.Point(121, 131);
            this.txtSifraP.Name = "txtSifraP";
            this.txtSifraP.Size = new System.Drawing.Size(100, 20);
            this.txtSifraP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sifra";
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Location = new System.Drawing.Point(350, 76);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(75, 23);
            this.btnPrijaviSe.TabIndex = 4;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // btnRegistrujSe
            // 
            this.btnRegistrujSe.Location = new System.Drawing.Point(350, 133);
            this.btnRegistrujSe.Name = "btnRegistrujSe";
            this.btnRegistrujSe.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrujSe.TabIndex = 5;
            this.btnRegistrujSe.Text = "Registruj se";
            this.btnRegistrujSe.UseVisualStyleBackColor = true;
            this.btnRegistrujSe.Click += new System.EventHandler(this.btnRegistrujSe_Click);
            // 
            // lblObavestenja
            // 
            this.lblObavestenja.AutoSize = true;
            this.lblObavestenja.Location = new System.Drawing.Point(185, 227);
            this.lblObavestenja.Name = "lblObavestenja";
            this.lblObavestenja.Size = new System.Drawing.Size(0, 13);
            this.lblObavestenja.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(747, 307);
            this.Controls.Add(this.lblObavestenja);
            this.Controls.Add(this.btnRegistrujSe);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifraP);
            this.Controls.Add(this.txtImeP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImeP;
        private System.Windows.Forms.TextBox txtSifraP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Button btnRegistrujSe;
        private System.Windows.Forms.Label lblObavestenja;
    }
}

