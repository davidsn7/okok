namespace Gestiune_Cinematograf
{
    partial class FormAfisareProiectiiUtilizator
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
            this.lvProiectii = new System.Windows.Forms.ListView();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.txtCautaTitlu = new System.Windows.Forms.TextBox();
            this.lblRegizor = new System.Windows.Forms.Label();
            this.txtCautaRegizor = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.cmbCategorieSociala = new System.Windows.Forms.ComboBox();
            this.lblPretFinal = new System.Windows.Forms.Label();
            this.btnRezerva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProiectii
            // 
            this.lvProiectii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProiectii.FullRowSelect = true;
            this.lvProiectii.GridLines = true;
            this.lvProiectii.HideSelection = false;
            this.lvProiectii.Location = new System.Drawing.Point(152, 12);
            this.lvProiectii.Name = "lvProiectii";
            this.lvProiectii.Size = new System.Drawing.Size(430, 426);
            this.lvProiectii.TabIndex = 0;
            this.lvProiectii.UseCompatibleStateImageBehavior = false;
            this.lvProiectii.View = System.Windows.Forms.View.Details;
            this.lvProiectii.SelectedIndexChanged += new System.EventHandler(this.lvProiectii_SelectedIndexChanged);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(319, 289);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(81, 13);
            this.lblTitlu.TabIndex = 1;
            this.lblTitlu.Text = "Cauta dupa titlu";
            // 
            // txtCautaTitlu
            // 
            this.txtCautaTitlu.Location = new System.Drawing.Point(309, 305);
            this.txtCautaTitlu.Name = "txtCautaTitlu";
            this.txtCautaTitlu.Size = new System.Drawing.Size(100, 20);
            this.txtCautaTitlu.TabIndex = 2;
            // 
            // lblRegizor
            // 
            this.lblRegizor.AutoSize = true;
            this.lblRegizor.Location = new System.Drawing.Point(176, 289);
            this.lblRegizor.Name = "lblRegizor";
            this.lblRegizor.Size = new System.Drawing.Size(96, 13);
            this.lblRegizor.TabIndex = 3;
            this.lblRegizor.Text = "Cauta dupa regizor";
            // 
            // txtCautaRegizor
            // 
            this.txtCautaRegizor.Location = new System.Drawing.Point(172, 305);
            this.txtCautaRegizor.Name = "txtCautaRegizor";
            this.txtCautaRegizor.Size = new System.Drawing.Size(100, 20);
            this.txtCautaRegizor.TabIndex = 4;
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(448, 302);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 5;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(192, 336);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 6;
            this.lblCategorie.Text = "Categorie";
            // 
            // cmbCategorieSociala
            // 
            this.cmbCategorieSociala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorieSociala.FormattingEnabled = true;
            this.cmbCategorieSociala.Location = new System.Drawing.Point(172, 352);
            this.cmbCategorieSociala.Name = "cmbCategorieSociala";
            this.cmbCategorieSociala.Size = new System.Drawing.Size(121, 21);
            this.cmbCategorieSociala.TabIndex = 7;
            this.cmbCategorieSociala.SelectedIndexChanged += new System.EventHandler(this.cmbCategorieSociala_SelectedIndexChanged);
            // 
            // lblPretFinal
            // 
            this.lblPretFinal.AutoSize = true;
            this.lblPretFinal.Location = new System.Drawing.Point(306, 355);
            this.lblPretFinal.Name = "lblPretFinal";
            this.lblPretFinal.Size = new System.Drawing.Size(54, 13);
            this.lblPretFinal.TabIndex = 8;
            this.lblPretFinal.Text = "Pret Final:";
            // 
            // btnRezerva
            // 
            this.btnRezerva.Location = new System.Drawing.Point(172, 391);
            this.btnRezerva.Name = "btnRezerva";
            this.btnRezerva.Size = new System.Drawing.Size(75, 23);
            this.btnRezerva.TabIndex = 9;
            this.btnRezerva.Text = "Rezerva";
            this.btnRezerva.UseVisualStyleBackColor = true;
            this.btnRezerva.Click += new System.EventHandler(this.btnRezerva_Click);
            // 
            // FormAfisareProiectiiUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRezerva);
            this.Controls.Add(this.lblPretFinal);
            this.Controls.Add(this.cmbCategorieSociala);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtCautaRegizor);
            this.Controls.Add(this.lblRegizor);
            this.Controls.Add(this.txtCautaTitlu);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lvProiectii);
            this.Name = "FormAfisareProiectiiUtilizator";
            this.Text = "FormAfisareProiectiiUtilizator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProiectii;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.TextBox txtCautaTitlu;
        private System.Windows.Forms.Label lblRegizor;
        private System.Windows.Forms.TextBox txtCautaRegizor;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox cmbCategorieSociala;
        private System.Windows.Forms.Label lblPretFinal;
        private System.Windows.Forms.Button btnRezerva;
    }
}