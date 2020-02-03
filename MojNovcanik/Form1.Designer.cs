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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtImeP
            // 
            this.txtImeP.Location = new System.Drawing.Point(121, 123);
            this.txtImeP.Name = "txtImeP";
            this.txtImeP.Size = new System.Drawing.Size(100, 20);
            this.txtImeP.TabIndex = 1;
            // 
            // txtSifraP
            // 
            this.txtSifraP.Location = new System.Drawing.Point(121, 178);
            this.txtSifraP.Name = "txtSifraP";
            this.txtSifraP.Size = new System.Drawing.Size(100, 20);
            this.txtSifraP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sifra";
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Location = new System.Drawing.Point(42, 245);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(75, 23);
            this.btnPrijaviSe.TabIndex = 4;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // btnRegistrujSe
            // 
            this.btnRegistrujSe.Location = new System.Drawing.Point(146, 245);
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
            this.lblObavestenja.Location = new System.Drawing.Point(39, 213);
            this.lblObavestenja.Name = "lblObavestenja";
            this.lblObavestenja.Size = new System.Drawing.Size(0, 13);
            this.lblObavestenja.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Moj Novčanik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Popunite potrebne podatke za prijavljivanje";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(304, 307);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

