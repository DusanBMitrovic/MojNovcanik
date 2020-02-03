namespace MojNovcanik.Forme
{
    partial class Registracija
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtImeR = new System.Windows.Forms.TextBox();
            this.txtSifraR = new System.Windows.Forms.TextBox();
            this.btnRegistrujSeR = new System.Windows.Forms.Button();
            this.txtMestoR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifra";
            // 
            // txtImeR
            // 
            this.txtImeR.Location = new System.Drawing.Point(140, 117);
            this.txtImeR.Name = "txtImeR";
            this.txtImeR.Size = new System.Drawing.Size(100, 20);
            this.txtImeR.TabIndex = 2;
            // 
            // txtSifraR
            // 
            this.txtSifraR.Location = new System.Drawing.Point(140, 163);
            this.txtSifraR.Name = "txtSifraR";
            this.txtSifraR.Size = new System.Drawing.Size(100, 20);
            this.txtSifraR.TabIndex = 3;
            // 
            // btnRegistrujSeR
            // 
            this.btnRegistrujSeR.Location = new System.Drawing.Point(165, 249);
            this.btnRegistrujSeR.Name = "btnRegistrujSeR";
            this.btnRegistrujSeR.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrujSeR.TabIndex = 4;
            this.btnRegistrujSeR.Text = "Registruj se";
            this.btnRegistrujSeR.UseVisualStyleBackColor = true;
            this.btnRegistrujSeR.Click += new System.EventHandler(this.btnRegistrujSeR_Click);
            // 
            // txtMestoR
            // 
            this.txtMestoR.Location = new System.Drawing.Point(140, 204);
            this.txtMestoR.Name = "txtMestoR";
            this.txtMestoR.Size = new System.Drawing.Size(100, 20);
            this.txtMestoR.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Popunite podatke za registraciju";
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMestoR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistrujSeR);
            this.Controls.Add(this.txtSifraR);
            this.Controls.Add(this.txtImeR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registracija";
            this.Text = "Registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImeR;
        private System.Windows.Forms.TextBox txtSifraR;
        private System.Windows.Forms.Button btnRegistrujSeR;
        private System.Windows.Forms.TextBox txtMestoR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}