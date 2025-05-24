namespace Gestiune_Cinematograf
{
    partial class FormAfisareSali
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
            this.lvSali = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCapacitate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipSala = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clbDotari = new System.Windows.Forms.CheckedListBox();
            this.btnAdaugaSala = new System.Windows.Forms.Button();
            this.dgvSali = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSali)).BeginInit();
            this.SuspendLayout();
            // 
            // lvSali
            // 
            this.lvSali.FullRowSelect = true;
            this.lvSali.HideSelection = false;
            this.lvSali.Location = new System.Drawing.Point(97, 30);
            this.lvSali.Name = "lvSali";
            this.lvSali.Size = new System.Drawing.Size(368, 542);
            this.lvSali.TabIndex = 0;
            this.lvSali.UseCompatibleStateImageBehavior = false;
            this.lvSali.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Denumire";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(97, 247);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(100, 20);
            this.txtDenumire.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capacitate";
            // 
            // txtCapacitate
            // 
            this.txtCapacitate.Location = new System.Drawing.Point(97, 304);
            this.txtCapacitate.Name = "txtCapacitate";
            this.txtCapacitate.Size = new System.Drawing.Size(100, 20);
            this.txtCapacitate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip sala";
            // 
            // cmbTipSala
            // 
            this.cmbTipSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipSala.FormattingEnabled = true;
            this.cmbTipSala.Location = new System.Drawing.Point(97, 362);
            this.cmbTipSala.Name = "cmbTipSala";
            this.cmbTipSala.Size = new System.Drawing.Size(121, 21);
            this.cmbTipSala.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dotari";
            // 
            // clbDotari
            // 
            this.clbDotari.FormattingEnabled = true;
            this.clbDotari.Location = new System.Drawing.Point(98, 416);
            this.clbDotari.Name = "clbDotari";
            this.clbDotari.Size = new System.Drawing.Size(120, 94);
            this.clbDotari.TabIndex = 8;
            // 
            // btnAdaugaSala
            // 
            this.btnAdaugaSala.Location = new System.Drawing.Point(99, 516);
            this.btnAdaugaSala.Name = "btnAdaugaSala";
            this.btnAdaugaSala.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaSala.TabIndex = 9;
            this.btnAdaugaSala.Text = "Adauga sala";
            this.btnAdaugaSala.UseVisualStyleBackColor = true;
            this.btnAdaugaSala.Click += new System.EventHandler(this.btnAdaugaSala_Click);
            // 
            // dgvSali
            // 
            this.dgvSali.AllowUserToAddRows = false;
            this.dgvSali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSali.Location = new System.Drawing.Point(138, 55);
            this.dgvSali.Name = "dgvSali";
            this.dgvSali.ReadOnly = true;
            this.dgvSali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSali.Size = new System.Drawing.Size(290, 154);
            this.dgvSali.TabIndex = 10;
            // 
            // FormAfisareSali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 609);
            this.Controls.Add(this.dgvSali);
            this.Controls.Add(this.btnAdaugaSala);
            this.Controls.Add(this.clbDotari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipSala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCapacitate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSali);
            this.Name = "FormAfisareSali";
            this.Text = "FormAfisareSali";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCapacitate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipSala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbDotari;
        private System.Windows.Forms.Button btnAdaugaSala;
        private System.Windows.Forms.DataGridView dgvSali;
    }
}