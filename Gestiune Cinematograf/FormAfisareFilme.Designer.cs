namespace Gestiune_Cinematograf
{
    partial class FormAfisareFilme
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
            this.lblCauta = new System.Windows.Forms.Label();
            this.txtCauta = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.pnlAdaugare = new System.Windows.Forms.Panel();
            this.lblEroareDescriere = new System.Windows.Forms.Label();
            this.lblEroareGen = new System.Windows.Forms.Label();
            this.lblEroareDurata = new System.Windows.Forms.Label();
            this.lblEroareRegizor = new System.Windows.Forms.Label();
            this.lblEroareTitlu = new System.Windows.Forms.Label();
            this.rb3D = new System.Windows.Forms.RadioButton();
            this.rb2D = new System.Windows.Forms.RadioButton();
            this.lblOptiuni = new System.Windows.Forms.Label();
            this.clbOptiuni = new System.Windows.Forms.CheckedListBox();
            this.btnAdauga1 = new System.Windows.Forms.Button();
            this.cmbLimba = new System.Windows.Forms.ComboBox();
            this.lblLimba = new System.Windows.Forms.Label();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.lblGen = new System.Windows.Forms.Label();
            this.txtDurata = new System.Windows.Forms.TextBox();
            this.lblDurata = new System.Windows.Forms.Label();
            this.txtRegizor = new System.Windows.Forms.TextBox();
            this.lblRegizor = new System.Windows.Forms.Label();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnModificaFilm = new System.Windows.Forms.Button();
            this.dgvFilme = new System.Windows.Forms.DataGridView();
            this.pnlAdaugare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCauta
            // 
            this.lblCauta.AutoSize = true;
            this.lblCauta.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCauta.Location = new System.Drawing.Point(26, 217);
            this.lblCauta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCauta.Name = "lblCauta";
            this.lblCauta.Size = new System.Drawing.Size(116, 16);
            this.lblCauta.TabIndex = 1;
            this.lblCauta.Text = "Cauta dupa regizor:";
            // 
            // txtCauta
            // 
            this.txtCauta.Location = new System.Drawing.Point(143, 217);
            this.txtCauta.Margin = new System.Windows.Forms.Padding(2);
            this.txtCauta.Name = "txtCauta";
            this.txtCauta.Size = new System.Drawing.Size(52, 20);
            this.txtCauta.TabIndex = 2;
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(30, 240);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(47, 22);
            this.btnCauta.TabIndex = 3;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(30, 292);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 22);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(30, 267);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(52, 22);
            this.btnAdauga.TabIndex = 5;
            this.btnAdauga.Text = "Adauga film";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // pnlAdaugare
            // 
            this.pnlAdaugare.Controls.Add(this.lblEroareDescriere);
            this.pnlAdaugare.Controls.Add(this.lblEroareGen);
            this.pnlAdaugare.Controls.Add(this.lblEroareDurata);
            this.pnlAdaugare.Controls.Add(this.lblEroareRegizor);
            this.pnlAdaugare.Controls.Add(this.lblEroareTitlu);
            this.pnlAdaugare.Controls.Add(this.rb3D);
            this.pnlAdaugare.Controls.Add(this.rb2D);
            this.pnlAdaugare.Controls.Add(this.lblOptiuni);
            this.pnlAdaugare.Controls.Add(this.clbOptiuni);
            this.pnlAdaugare.Controls.Add(this.btnAdauga1);
            this.pnlAdaugare.Controls.Add(this.cmbLimba);
            this.pnlAdaugare.Controls.Add(this.lblLimba);
            this.pnlAdaugare.Controls.Add(this.txtDescriere);
            this.pnlAdaugare.Controls.Add(this.lblDescriere);
            this.pnlAdaugare.Controls.Add(this.txtGen);
            this.pnlAdaugare.Controls.Add(this.lblGen);
            this.pnlAdaugare.Controls.Add(this.txtDurata);
            this.pnlAdaugare.Controls.Add(this.lblDurata);
            this.pnlAdaugare.Controls.Add(this.txtRegizor);
            this.pnlAdaugare.Controls.Add(this.lblRegizor);
            this.pnlAdaugare.Controls.Add(this.txtTitlu);
            this.pnlAdaugare.Controls.Add(this.lblTitlu);
            this.pnlAdaugare.Location = new System.Drawing.Point(339, 17);
            this.pnlAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAdaugare.Name = "pnlAdaugare";
            this.pnlAdaugare.Size = new System.Drawing.Size(366, 331);
            this.pnlAdaugare.TabIndex = 6;
            this.pnlAdaugare.Visible = false;
            // 
            // lblEroareDescriere
            // 
            this.lblEroareDescriere.ForeColor = System.Drawing.Color.Red;
            this.lblEroareDescriere.Location = new System.Drawing.Point(176, 217);
            this.lblEroareDescriere.Name = "lblEroareDescriere";
            this.lblEroareDescriere.Size = new System.Drawing.Size(187, 20);
            this.lblEroareDescriere.TabIndex = 21;
            this.lblEroareDescriere.Visible = false;
            // 
            // lblEroareGen
            // 
            this.lblEroareGen.ForeColor = System.Drawing.Color.Red;
            this.lblEroareGen.Location = new System.Drawing.Point(176, 169);
            this.lblEroareGen.Name = "lblEroareGen";
            this.lblEroareGen.Size = new System.Drawing.Size(187, 20);
            this.lblEroareGen.TabIndex = 20;
            this.lblEroareGen.Visible = false;
            // 
            // lblEroareDurata
            // 
            this.lblEroareDurata.ForeColor = System.Drawing.Color.Red;
            this.lblEroareDurata.Location = new System.Drawing.Point(176, 124);
            this.lblEroareDurata.Name = "lblEroareDurata";
            this.lblEroareDurata.Size = new System.Drawing.Size(187, 20);
            this.lblEroareDurata.TabIndex = 19;
            this.lblEroareDurata.Visible = false;
            // 
            // lblEroareRegizor
            // 
            this.lblEroareRegizor.ForeColor = System.Drawing.Color.Red;
            this.lblEroareRegizor.Location = new System.Drawing.Point(176, 76);
            this.lblEroareRegizor.Name = "lblEroareRegizor";
            this.lblEroareRegizor.Size = new System.Drawing.Size(187, 20);
            this.lblEroareRegizor.TabIndex = 18;
            this.lblEroareRegizor.Visible = false;
            // 
            // lblEroareTitlu
            // 
            this.lblEroareTitlu.ForeColor = System.Drawing.Color.Red;
            this.lblEroareTitlu.Location = new System.Drawing.Point(176, 29);
            this.lblEroareTitlu.Name = "lblEroareTitlu";
            this.lblEroareTitlu.Size = new System.Drawing.Size(137, 29);
            this.lblEroareTitlu.TabIndex = 17;
            this.lblEroareTitlu.Visible = false;
            // 
            // rb3D
            // 
            this.rb3D.AutoSize = true;
            this.rb3D.Location = new System.Drawing.Point(2, 309);
            this.rb3D.Margin = new System.Windows.Forms.Padding(2);
            this.rb3D.Name = "rb3D";
            this.rb3D.Size = new System.Drawing.Size(39, 17);
            this.rb3D.TabIndex = 16;
            this.rb3D.TabStop = true;
            this.rb3D.Text = "3D";
            this.rb3D.UseVisualStyleBackColor = true;
            // 
            // rb2D
            // 
            this.rb2D.AutoSize = true;
            this.rb2D.Location = new System.Drawing.Point(2, 293);
            this.rb2D.Margin = new System.Windows.Forms.Padding(2);
            this.rb2D.Name = "rb2D";
            this.rb2D.Size = new System.Drawing.Size(39, 17);
            this.rb2D.TabIndex = 15;
            this.rb2D.TabStop = true;
            this.rb2D.Text = "2D";
            this.rb2D.UseVisualStyleBackColor = true;
            // 
            // lblOptiuni
            // 
            this.lblOptiuni.AutoSize = true;
            this.lblOptiuni.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOptiuni.Location = new System.Drawing.Point(184, 251);
            this.lblOptiuni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOptiuni.Name = "lblOptiuni";
            this.lblOptiuni.Size = new System.Drawing.Size(48, 16);
            this.lblOptiuni.TabIndex = 14;
            this.lblOptiuni.Text = "Optiuni";
            // 
            // clbOptiuni
            // 
            this.clbOptiuni.FormattingEnabled = true;
            this.clbOptiuni.Location = new System.Drawing.Point(176, 268);
            this.clbOptiuni.Margin = new System.Windows.Forms.Padding(2);
            this.clbOptiuni.Name = "clbOptiuni";
            this.clbOptiuni.Size = new System.Drawing.Size(137, 34);
            this.clbOptiuni.TabIndex = 13;
            // 
            // btnAdauga1
            // 
            this.btnAdauga1.Location = new System.Drawing.Point(99, 286);
            this.btnAdauga1.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdauga1.Name = "btnAdauga1";
            this.btnAdauga1.Size = new System.Drawing.Size(52, 22);
            this.btnAdauga1.TabIndex = 12;
            this.btnAdauga1.Text = "Adauga";
            this.btnAdauga1.UseVisualStyleBackColor = true;
            this.btnAdauga1.Click += new System.EventHandler(this.btnAdauga1_Click);
            // 
            // cmbLimba
            // 
            this.cmbLimba.FormattingEnabled = true;
            this.cmbLimba.Location = new System.Drawing.Point(2, 268);
            this.cmbLimba.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLimba.Name = "cmbLimba";
            this.cmbLimba.Size = new System.Drawing.Size(62, 21);
            this.cmbLimba.TabIndex = 11;
            // 
            // lblLimba
            // 
            this.lblLimba.AutoSize = true;
            this.lblLimba.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLimba.Location = new System.Drawing.Point(10, 251);
            this.lblLimba.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLimba.Name = "lblLimba";
            this.lblLimba.Size = new System.Drawing.Size(42, 16);
            this.lblLimba.TabIndex = 10;
            this.lblLimba.Text = "Limba";
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(99, 217);
            this.txtDescriere.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(52, 20);
            this.txtDescriere.TabIndex = 9;
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescriere.Location = new System.Drawing.Point(96, 194);
            this.lblDescriere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(61, 16);
            this.lblDescriere.TabIndex = 8;
            this.lblDescriere.Text = "Descriere";
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(99, 169);
            this.txtGen.Margin = new System.Windows.Forms.Padding(2);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(52, 20);
            this.txtGen.TabIndex = 7;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGen.Location = new System.Drawing.Point(110, 148);
            this.lblGen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(30, 16);
            this.lblGen.TabIndex = 6;
            this.lblGen.Text = "Gen";
            // 
            // txtDurata
            // 
            this.txtDurata.Location = new System.Drawing.Point(99, 124);
            this.txtDurata.Margin = new System.Windows.Forms.Padding(2);
            this.txtDurata.Name = "txtDurata";
            this.txtDurata.Size = new System.Drawing.Size(52, 20);
            this.txtDurata.TabIndex = 5;
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDurata.Location = new System.Drawing.Point(105, 101);
            this.lblDurata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(45, 16);
            this.lblDurata.TabIndex = 4;
            this.lblDurata.Text = "Durata";
            // 
            // txtRegizor
            // 
            this.txtRegizor.Location = new System.Drawing.Point(99, 76);
            this.txtRegizor.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegizor.Name = "txtRegizor";
            this.txtRegizor.Size = new System.Drawing.Size(52, 20);
            this.txtRegizor.TabIndex = 3;
            // 
            // lblRegizor
            // 
            this.lblRegizor.AutoSize = true;
            this.lblRegizor.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRegizor.Location = new System.Drawing.Point(100, 54);
            this.lblRegizor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegizor.Name = "lblRegizor";
            this.lblRegizor.Size = new System.Drawing.Size(50, 16);
            this.lblRegizor.TabIndex = 2;
            this.lblRegizor.Text = "Regizor";
            // 
            // txtTitlu
            // 
            this.txtTitlu.Location = new System.Drawing.Point(99, 29);
            this.txtTitlu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(52, 20);
            this.txtTitlu.TabIndex = 1;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlu.Location = new System.Drawing.Point(107, 11);
            this.lblTitlu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(33, 16);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Titlu";
            // 
            // btnModificaFilm
            // 
            this.btnModificaFilm.Location = new System.Drawing.Point(220, 210);
            this.btnModificaFilm.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificaFilm.Name = "btnModificaFilm";
            this.btnModificaFilm.Size = new System.Drawing.Size(64, 27);
            this.btnModificaFilm.TabIndex = 7;
            this.btnModificaFilm.Text = "Modifica film";
            this.btnModificaFilm.UseVisualStyleBackColor = true;
            this.btnModificaFilm.Click += new System.EventHandler(this.btnModificaFilm_Click);
            // 
            // dgvFilme
            // 
            this.dgvFilme.AllowUserToAddRows = false;
            this.dgvFilme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilme.Location = new System.Drawing.Point(30, 46);
            this.dgvFilme.Name = "dgvFilme";
            this.dgvFilme.ReadOnly = true;
            this.dgvFilme.RowHeadersVisible = false;
            this.dgvFilme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilme.Size = new System.Drawing.Size(286, 150);
            this.dgvFilme.TabIndex = 8;
            this.dgvFilme.SelectionChanged += new System.EventHandler(this.dgvFilme_SelectionChanged);
            // 
            // FormAfisareFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 528);
            this.Controls.Add(this.dgvFilme);
            this.Controls.Add(this.btnModificaFilm);
            this.Controls.Add(this.pnlAdaugare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtCauta);
            this.Controls.Add(this.lblCauta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAfisareFilme";
            this.Text = "FormAfisareFilme";
            this.pnlAdaugare.ResumeLayout(false);
            this.pnlAdaugare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCauta;
        private System.Windows.Forms.TextBox txtCauta;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Panel pnlAdaugare;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.TextBox txtDurata;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.TextBox txtRegizor;
        private System.Windows.Forms.Label lblRegizor;
        private System.Windows.Forms.Button btnAdauga1;
        private System.Windows.Forms.ComboBox cmbLimba;
        private System.Windows.Forms.Label lblLimba;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label lblOptiuni;
        private System.Windows.Forms.CheckedListBox clbOptiuni;
        private System.Windows.Forms.RadioButton rb3D;
        private System.Windows.Forms.RadioButton rb2D;
        private System.Windows.Forms.Button btnModificaFilm;
        private System.Windows.Forms.Label lblEroareDescriere;
        private System.Windows.Forms.Label lblEroareGen;
        private System.Windows.Forms.Label lblEroareDurata;
        private System.Windows.Forms.Label lblEroareRegizor;
        private System.Windows.Forms.Label lblEroareTitlu;
        private System.Windows.Forms.DataGridView dgvFilme;
    }
}