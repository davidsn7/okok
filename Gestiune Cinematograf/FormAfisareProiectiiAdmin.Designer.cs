namespace Gestiune_Cinematograf
{
    partial class FormAfisareProiectiiAdmin
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
            this.dgvProiectii = new System.Windows.Forms.DataGridView();
            this.cmbFilme = new System.Windows.Forms.ComboBox();
            this.cmbSali = new System.Windows.Forms.ComboBox();
            this.dtpOraProiectiei = new System.Windows.Forms.DateTimePicker();
            this.cmbZi = new System.Windows.Forms.ComboBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.btnAdaugaProiectie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProiectii)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProiectii
            // 
            this.dgvProiectii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProiectii.Location = new System.Drawing.Point(34, 42);
            this.dgvProiectii.Name = "dgvProiectii";
            this.dgvProiectii.Size = new System.Drawing.Size(240, 150);
            this.dgvProiectii.TabIndex = 0;
            // 
            // cmbFilme
            // 
            this.cmbFilme.FormattingEnabled = true;
            this.cmbFilme.Location = new System.Drawing.Point(153, 218);
            this.cmbFilme.Name = "cmbFilme";
            this.cmbFilme.Size = new System.Drawing.Size(121, 21);
            this.cmbFilme.TabIndex = 1;
            // 
            // cmbSali
            // 
            this.cmbSali.FormattingEnabled = true;
            this.cmbSali.Location = new System.Drawing.Point(153, 257);
            this.cmbSali.Name = "cmbSali";
            this.cmbSali.Size = new System.Drawing.Size(121, 21);
            this.cmbSali.TabIndex = 2;
            // 
            // dtpOraProiectiei
            // 
            this.dtpOraProiectiei.Location = new System.Drawing.Point(404, 24);
            this.dtpOraProiectiei.Name = "dtpOraProiectiei";
            this.dtpOraProiectiei.Size = new System.Drawing.Size(200, 20);
            this.dtpOraProiectiei.TabIndex = 3;
            // 
            // cmbZi
            // 
            this.cmbZi.FormattingEnabled = true;
            this.cmbZi.Location = new System.Drawing.Point(153, 295);
            this.cmbZi.Name = "cmbZi";
            this.cmbZi.Size = new System.Drawing.Size(121, 21);
            this.cmbZi.TabIndex = 4;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(174, 337);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 20);
            this.txtPret.TabIndex = 5;
            // 
            // btnAdaugaProiectie
            // 
            this.btnAdaugaProiectie.Location = new System.Drawing.Point(199, 375);
            this.btnAdaugaProiectie.Name = "btnAdaugaProiectie";
            this.btnAdaugaProiectie.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaProiectie.TabIndex = 6;
            this.btnAdaugaProiectie.Text = "Adauga";
            this.btnAdaugaProiectie.UseVisualStyleBackColor = true;
            this.btnAdaugaProiectie.Click += new System.EventHandler(this.btnAdaugaProiectie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sali";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Zi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pret";
            // 
            // FormAfisareProiectiiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdaugaProiectie);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.cmbZi);
            this.Controls.Add(this.dtpOraProiectiei);
            this.Controls.Add(this.cmbSali);
            this.Controls.Add(this.cmbFilme);
            this.Controls.Add(this.dgvProiectii);
            this.Name = "FormAfisareProiectiiAdmin";
            this.Text = "FormAfisareProiectiiAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProiectii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProiectii;
        private System.Windows.Forms.ComboBox cmbFilme;
        private System.Windows.Forms.ComboBox cmbSali;
        private System.Windows.Forms.DateTimePicker dtpOraProiectiei;
        private System.Windows.Forms.ComboBox cmbZi;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Button btnAdaugaProiectie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}