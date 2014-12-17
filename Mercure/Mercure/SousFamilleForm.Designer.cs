namespace Mercure
{
    partial class SousFamilleForm
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
            this.lv_SousFamille = new System.Windows.Forms.ListView();
            this.Identifiant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomSousFamille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomFamille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Famille = new System.Windows.Forms.Label();
            this.lbl_NomSousFamille = new System.Windows.Forms.Label();
            this.cbx_Famille = new System.Windows.Forms.ComboBox();
            this.lbl_Identifiant = new System.Windows.Forms.Label();
            this.tbx_identifiant = new System.Windows.Forms.TextBox();
            this.tbx_SousFamille = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_SousFamille
            // 
            this.lv_SousFamille.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Identifiant,
            this.NomSousFamille,
            this.NomFamille});
            this.lv_SousFamille.FullRowSelect = true;
            this.lv_SousFamille.GridLines = true;
            this.lv_SousFamille.Location = new System.Drawing.Point(1, 3);
            this.lv_SousFamille.Name = "lv_SousFamille";
            this.lv_SousFamille.Size = new System.Drawing.Size(394, 240);
            this.lv_SousFamille.TabIndex = 10;
            this.lv_SousFamille.UseCompatibleStateImageBehavior = false;
            this.lv_SousFamille.View = System.Windows.Forms.View.Details;
            this.lv_SousFamille.Click += new System.EventHandler(this.lv_SousFamille_Click);
            // 
            // Identifiant
            // 
            this.Identifiant.Text = "Identifiant";
            this.Identifiant.Width = 81;
            // 
            // NomSousFamille
            // 
            this.NomSousFamille.Text = "Nom Sous-Famille";
            this.NomSousFamille.Width = 123;
            // 
            // NomFamille
            // 
            this.NomFamille.Text = "Nom famille";
            this.NomFamille.Width = 119;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(311, 249);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 13;
            this.btn_Valider.Text = "Ajouter";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(311, 278);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 12;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(311, 307);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 11;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Famille, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_NomSousFamille, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbx_Famille, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Identifiant, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_identifiant, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_SousFamille, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 249);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 81);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // lbl_Famille
            // 
            this.lbl_Famille.AutoSize = true;
            this.lbl_Famille.Location = new System.Drawing.Point(3, 52);
            this.lbl_Famille.Name = "lbl_Famille";
            this.lbl_Famille.Size = new System.Drawing.Size(61, 13);
            this.lbl_Famille.TabIndex = 16;
            this.lbl_Famille.Text = "Nom famille";
            // 
            // lbl_NomSousFamille
            // 
            this.lbl_NomSousFamille.AutoSize = true;
            this.lbl_NomSousFamille.Location = new System.Drawing.Point(3, 26);
            this.lbl_NomSousFamille.Name = "lbl_NomSousFamille";
            this.lbl_NomSousFamille.Size = new System.Drawing.Size(91, 13);
            this.lbl_NomSousFamille.TabIndex = 8;
            this.lbl_NomSousFamille.Text = "Nom Sous-Famille";
            // 
            // cbx_Famille
            // 
            this.cbx_Famille.FormattingEnabled = true;
            this.cbx_Famille.Location = new System.Drawing.Point(149, 55);
            this.cbx_Famille.Name = "cbx_Famille";
            this.cbx_Famille.Size = new System.Drawing.Size(141, 21);
            this.cbx_Famille.TabIndex = 7;
            // 
            // lbl_Identifiant
            // 
            this.lbl_Identifiant.AutoSize = true;
            this.lbl_Identifiant.Location = new System.Drawing.Point(3, 0);
            this.lbl_Identifiant.Name = "lbl_Identifiant";
            this.lbl_Identifiant.Size = new System.Drawing.Size(53, 13);
            this.lbl_Identifiant.TabIndex = 0;
            this.lbl_Identifiant.Text = "Identifiant";
            // 
            // tbx_identifiant
            // 
            this.tbx_identifiant.Location = new System.Drawing.Point(149, 3);
            this.tbx_identifiant.Name = "tbx_identifiant";
            this.tbx_identifiant.Size = new System.Drawing.Size(141, 20);
            this.tbx_identifiant.TabIndex = 2;
            // 
            // tbx_SousFamille
            // 
            this.tbx_SousFamille.Location = new System.Drawing.Point(149, 29);
            this.tbx_SousFamille.Name = "tbx_SousFamille";
            this.tbx_SousFamille.Size = new System.Drawing.Size(141, 20);
            this.tbx_SousFamille.TabIndex = 5;
            // 
            // SousFamilleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 340);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.lv_SousFamille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SousFamilleForm";
            this.Text = "Gestion des Sous-Famille";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SousFamilleForm_FormClosed);
            this.Load += new System.EventHandler(this.SousFamilleForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_SousFamille;
        private System.Windows.Forms.ColumnHeader Identifiant;
        private System.Windows.Forms.ColumnHeader NomSousFamille;
        private System.Windows.Forms.ColumnHeader NomFamille;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Identifiant;
        private System.Windows.Forms.TextBox tbx_identifiant;
        private System.Windows.Forms.TextBox tbx_SousFamille;
        private System.Windows.Forms.ComboBox cbx_Famille;
        private System.Windows.Forms.Label lbl_Famille;
        private System.Windows.Forms.Label lbl_NomSousFamille;
    }
}