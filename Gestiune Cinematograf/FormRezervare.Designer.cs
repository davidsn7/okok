namespace Gestiune_Cinematograf
{
    partial class FormRezervare
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
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblOra = new System.Windows.Forms.Label();
            this.lblZi = new System.Windows.Forms.Label();
            this.lblPretFinal = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPreferinte = new System.Windows.Forms.Label();
            this.cmbLoc = new System.Windows.Forms.ComboBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.cbEcran = new System.Windows.Forms.CheckBox();
            this.cbAlee = new System.Windows.Forms.CheckBox();
            this.cbMijloc = new System.Windows.Forms.CheckBox();
            this.cbIzolat = new System.Windows.Forms.CheckBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(68, 30);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(28, 13);
            this.lblFilm.TabIndex = 0;
            this.lblFilm.Text = "Film:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(68, 52);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 13);
            this.lblSala.TabIndex = 1;
            this.lblSala.Text = "Sala:";
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.Location = new System.Drawing.Point(70, 74);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(27, 13);
            this.lblOra.TabIndex = 2;
            this.lblOra.Text = "Ora:";
            // 
            // lblZi
            // 
            this.lblZi.AutoSize = true;
            this.lblZi.Location = new System.Drawing.Point(70, 97);
            this.lblZi.Name = "lblZi";
            this.lblZi.Size = new System.Drawing.Size(31, 13);
            this.lblZi.TabIndex = 3;
            this.lblZi.Text = "Ziua:";
            // 
            // lblPretFinal
            // 
            this.lblPretFinal.AutoSize = true;
            this.lblPretFinal.Location = new System.Drawing.Point(70, 119);
            this.lblPretFinal.Name = "lblPretFinal";
            this.lblPretFinal.Size = new System.Drawing.Size(54, 13);
            this.lblPretFinal.TabIndex = 4;
            this.lblPretFinal.Text = "Pret Final:";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(69, 178);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(28, 13);
            this.lblLoc.TabIndex = 5;
            this.lblLoc.Text = "Loc:";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(69, 204);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(38, 13);
            this.lblNume.TabIndex = 6;
            this.lblNume.Text = "Nume:";
            // 
            // lblPreferinte
            // 
            this.lblPreferinte.AutoSize = true;
            this.lblPreferinte.Location = new System.Drawing.Point(68, 233);
            this.lblPreferinte.Name = "lblPreferinte";
            this.lblPreferinte.Size = new System.Drawing.Size(55, 13);
            this.lblPreferinte.TabIndex = 7;
            this.lblPreferinte.Text = "Preferinte:";
            // 
            // cmbLoc
            // 
            this.cmbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Location = new System.Drawing.Point(103, 170);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(121, 21);
            this.cmbLoc.TabIndex = 8;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(113, 197);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 9;
            // 
            // cbEcran
            // 
            this.cbEcran.AutoSize = true;
            this.cbEcran.Location = new System.Drawing.Point(123, 249);
            this.cbEcran.Name = "cbEcran";
            this.cbEcran.Size = new System.Drawing.Size(111, 17);
            this.cbEcran.TabIndex = 10;
            this.cbEcran.Text = "Aproape de ecran";
            this.cbEcran.UseVisualStyleBackColor = true;
            // 
            // cbAlee
            // 
            this.cbAlee.AutoSize = true;
            this.cbAlee.Location = new System.Drawing.Point(123, 281);
            this.cbAlee.Name = "cbAlee";
            this.cbAlee.Size = new System.Drawing.Size(84, 17);
            this.cbAlee.TabIndex = 11;
            this.cbAlee.Text = "Alee laterala";
            this.cbAlee.UseVisualStyleBackColor = true;
            // 
            // cbMijloc
            // 
            this.cbMijloc.AutoSize = true;
            this.cbMijloc.Location = new System.Drawing.Point(250, 249);
            this.cbMijloc.Name = "cbMijloc";
            this.cbMijloc.Size = new System.Drawing.Size(53, 17);
            this.cbMijloc.TabIndex = 12;
            this.cbMijloc.Text = "Mijloc";
            this.cbMijloc.UseVisualStyleBackColor = true;
            // 
            // cbIzolat
            // 
            this.cbIzolat.AutoSize = true;
            this.cbIzolat.Location = new System.Drawing.Point(250, 281);
            this.cbIzolat.Name = "cbIzolat";
            this.cbIzolat.Size = new System.Drawing.Size(84, 17);
            this.cbIzolat.TabIndex = 13;
            this.cbIzolat.Text = "Scaun izolat";
            this.cbIzolat.UseVisualStyleBackColor = true;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirma.Location = new System.Drawing.Point(162, 333);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(122, 23);
            this.btnConfirma.TabIndex = 14;
            this.btnConfirma.Text = "Confirma rezervare";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // FormRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.cbIzolat);
            this.Controls.Add(this.cbMijloc);
            this.Controls.Add(this.cbAlee);
            this.Controls.Add(this.cbEcran);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.cmbLoc);
            this.Controls.Add(this.lblPreferinte);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.lblPretFinal);
            this.Controls.Add(this.lblZi);
            this.Controls.Add(this.lblOra);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblFilm);
            this.Name = "FormRezervare";
            this.Text = "FormRezervare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.Label lblZi;
        private System.Windows.Forms.Label lblPretFinal;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPreferinte;
        private System.Windows.Forms.ComboBox cmbLoc;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.CheckBox cbEcran;
        private System.Windows.Forms.CheckBox cbAlee;
        private System.Windows.Forms.CheckBox cbMijloc;
        private System.Windows.Forms.CheckBox cbIzolat;
        private System.Windows.Forms.Button btnConfirma;
    }
}