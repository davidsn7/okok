namespace Gestiune_Cinematograf
{
    partial class FormMeniuPrincipal
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
            this.btnAlegeAdmin = new System.Windows.Forms.Button();
            this.btnAlegeUtilizator = new System.Windows.Forms.Button();
            this.btnFilme = new System.Windows.Forms.Button();
            this.btnSali = new System.Windows.Forms.Button();
            this.btnProiectii = new System.Windows.Forms.Button();
            this.btnRezervari = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlegeAdmin
            // 
            this.btnAlegeAdmin.Location = new System.Drawing.Point(59, 258);
            this.btnAlegeAdmin.Name = "btnAlegeAdmin";
            this.btnAlegeAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAlegeAdmin.TabIndex = 0;
            this.btnAlegeAdmin.Text = "Administrator";
            this.btnAlegeAdmin.UseVisualStyleBackColor = true;
            this.btnAlegeAdmin.Click += new System.EventHandler(this.btnAlegeAdmin_Click);
            // 
            // btnAlegeUtilizator
            // 
            this.btnAlegeUtilizator.Location = new System.Drawing.Point(179, 258);
            this.btnAlegeUtilizator.Name = "btnAlegeUtilizator";
            this.btnAlegeUtilizator.Size = new System.Drawing.Size(75, 23);
            this.btnAlegeUtilizator.TabIndex = 1;
            this.btnAlegeUtilizator.Text = "Utilizator";
            this.btnAlegeUtilizator.UseVisualStyleBackColor = true;
            this.btnAlegeUtilizator.Click += new System.EventHandler(this.btnAlegeUtilizator_Click);
            // 
            // btnFilme
            // 
            this.btnFilme.Location = new System.Drawing.Point(5, 323);
            this.btnFilme.Name = "btnFilme";
            this.btnFilme.Size = new System.Drawing.Size(109, 23);
            this.btnFilme.TabIndex = 2;
            this.btnFilme.Text = "Gestionare Filme";
            this.btnFilme.UseVisualStyleBackColor = true;
            this.btnFilme.Visible = false;
            // 
            // btnSali
            // 
            this.btnSali.Location = new System.Drawing.Point(5, 352);
            this.btnSali.Name = "btnSali";
            this.btnSali.Size = new System.Drawing.Size(109, 23);
            this.btnSali.TabIndex = 3;
            this.btnSali.Text = "Gestionare Sali";
            this.btnSali.UseVisualStyleBackColor = true;
            this.btnSali.Visible = false;
            // 
            // btnProiectii
            // 
            this.btnProiectii.Location = new System.Drawing.Point(5, 381);
            this.btnProiectii.Name = "btnProiectii";
            this.btnProiectii.Size = new System.Drawing.Size(109, 23);
            this.btnProiectii.TabIndex = 4;
            this.btnProiectii.Text = "Gestionare Proiectii";
            this.btnProiectii.UseVisualStyleBackColor = true;
            this.btnProiectii.Visible = false;
            // 
            // btnRezervari
            // 
            this.btnRezervari.Location = new System.Drawing.Point(5, 410);
            this.btnRezervari.Name = "btnRezervari";
            this.btnRezervari.Size = new System.Drawing.Size(129, 23);
            this.btnRezervari.TabIndex = 5;
            this.btnRezervari.Text = "Gestionare Rezervari";
            this.btnRezervari.UseVisualStyleBackColor = true;
            this.btnRezervari.Visible = false;
            // 
            // btnIesire
            // 
            this.btnIesire.Location = new System.Drawing.Point(236, 430);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(75, 23);
            this.btnIesire.TabIndex = 6;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            // 
            // FormMeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 465);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnRezervari);
            this.Controls.Add(this.btnProiectii);
            this.Controls.Add(this.btnSali);
            this.Controls.Add(this.btnFilme);
            this.Controls.Add(this.btnAlegeUtilizator);
            this.Controls.Add(this.btnAlegeAdmin);
            this.Name = "FormMeniuPrincipal";
            this.Text = "FormMeniuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlegeAdmin;
        private System.Windows.Forms.Button btnAlegeUtilizator;
        private System.Windows.Forms.Button btnFilme;
        private System.Windows.Forms.Button btnSali;
        private System.Windows.Forms.Button btnProiectii;
        private System.Windows.Forms.Button btnRezervari;
        private System.Windows.Forms.Button btnIesire;
    }
}