namespace Mercure
{
    partial class FamilleForm
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
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Identifiant = new System.Windows.Forms.Label();
            this.lbl_Famille = new System.Windows.Forms.Label();
            this.tbx_identifiant = new System.Windows.Forms.TextBox();
            this.tbx_nom = new System.Windows.Forms.TextBox();
            this.lv_Famille = new System.Windows.Forms.ListView();
            this.Identifiant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_annuler
            // 
            this.btn_annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_annuler.Location = new System.Drawing.Point(3, 61);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(131, 25);
            this.btn_annuler.TabIndex = 5;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supprimer.Location = new System.Drawing.Point(3, 32);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(131, 23);
            this.btn_supprimer.TabIndex = 6;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_valider.Location = new System.Drawing.Point(3, 3);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(131, 23);
            this.btn_valider.TabIndex = 7;
            this.btn_valider.Text = "Ajouter";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lbl_Identifiant, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Famille, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbx_identifiant, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_nom, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 89);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lbl_Identifiant
            // 
            this.lbl_Identifiant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Identifiant.AutoSize = true;
            this.lbl_Identifiant.Location = new System.Drawing.Point(14, 15);
            this.lbl_Identifiant.Name = "lbl_Identifiant";
            this.lbl_Identifiant.Size = new System.Drawing.Size(53, 13);
            this.lbl_Identifiant.TabIndex = 0;
            this.lbl_Identifiant.Text = "Identifiant";
            // 
            // lbl_Famille
            // 
            this.lbl_Famille.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Famille.AutoSize = true;
            this.lbl_Famille.Location = new System.Drawing.Point(6, 60);
            this.lbl_Famille.Name = "lbl_Famille";
            this.lbl_Famille.Size = new System.Drawing.Size(61, 13);
            this.lbl_Famille.TabIndex = 1;
            this.lbl_Famille.Text = "Nom famille";
            // 
            // tbx_identifiant
            // 
            this.tbx_identifiant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_identifiant.Location = new System.Drawing.Point(73, 12);
            this.tbx_identifiant.Name = "tbx_identifiant";
            this.tbx_identifiant.Size = new System.Drawing.Size(118, 20);
            this.tbx_identifiant.TabIndex = 2;
            // 
            // tbx_nom
            // 
            this.tbx_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_nom.Location = new System.Drawing.Point(73, 56);
            this.tbx_nom.Name = "tbx_nom";
            this.tbx_nom.Size = new System.Drawing.Size(118, 20);
            this.tbx_nom.TabIndex = 3;
            // 
            // lv_Famille
            // 
            this.lv_Famille.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Identifiant,
            this.Nom});
            this.lv_Famille.FullRowSelect = true;
            this.lv_Famille.GridLines = true;
            this.lv_Famille.Location = new System.Drawing.Point(1, 2);
            this.lv_Famille.Name = "lv_Famille";
            this.lv_Famille.Size = new System.Drawing.Size(343, 240);
            this.lv_Famille.TabIndex = 9;
            this.lv_Famille.UseCompatibleStateImageBehavior = false;
            this.lv_Famille.View = System.Windows.Forms.View.Details;
            this.lv_Famille.Click += new System.EventHandler(this.lv_Famille_Click);
            // 
            // Identifiant
            // 
            this.Identifiant.Text = "Identifiant";
            this.Identifiant.Width = 81;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom famille";
            this.Nom.Width = 234;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_valider, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_supprimer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_annuler, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(203, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(137, 89);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 248);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(343, 95);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // FamilleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 478);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.lv_Famille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FamilleForm";
            this.Text = "Gestion des Familles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FamilleForm_FormClosed);
            this.Load += new System.EventHandler(this.FamilleForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Identifiant;
        private System.Windows.Forms.Label lbl_Famille;
        private System.Windows.Forms.TextBox tbx_identifiant;
        private System.Windows.Forms.TextBox tbx_nom;
        private System.Windows.Forms.ListView lv_Famille;
        private System.Windows.Forms.ColumnHeader Identifiant;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}