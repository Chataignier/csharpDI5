namespace Mercure
{
    partial class ArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticleForm));
            this.lv_Article = new System.Windows.Forms.ListView();
            this.REF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SousFamille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrixHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.cbx_Marque = new System.Windows.Forms.ComboBox();
            this.cbx_SousFamille = new System.Windows.Forms.ComboBox();
            this.tbx_Ref = new System.Windows.Forms.TextBox();
            this.tbx_Description = new System.Windows.Forms.TextBox();
            this.lbl_SousFamille = new System.Windows.Forms.Label();
            this.lbl_Marque = new System.Windows.Forms.Label();
            this.lbl_PrixHT = new System.Windows.Forms.Label();
            this.tbx_PrixHT = new System.Windows.Forms.TextBox();
            this.lbl_Ref = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Article
            // 
            this.lv_Article.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.REF,
            this.Description,
            this.SousFamille,
            this.Marque,
            this.PrixHT});
            this.lv_Article.FullRowSelect = true;
            this.lv_Article.GridLines = true;
            this.lv_Article.Location = new System.Drawing.Point(0, 0);
            this.lv_Article.Name = "lv_Article";
            this.lv_Article.Size = new System.Drawing.Size(667, 326);
            this.lv_Article.TabIndex = 0;
            this.lv_Article.UseCompatibleStateImageBehavior = false;
            this.lv_Article.View = System.Windows.Forms.View.Details;
            this.lv_Article.Click += new System.EventHandler(this.lv_Article_Click);
            // 
            // REF
            // 
            this.REF.Text = "Référence";
            this.REF.Width = 82;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 243;
            // 
            // SousFamille
            // 
            this.SousFamille.Text = "Sous-Famille";
            this.SousFamille.Width = 108;
            // 
            // Marque
            // 
            this.Marque.Text = "Marque";
            this.Marque.Width = 117;
            // 
            // PrixHT
            // 
            this.PrixHT.Text = "PrixHT";
            this.PrixHT.Width = 79;
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Supprimer.Location = new System.Drawing.Point(10, 122);
            this.btn_Supprimer.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(141, 38);
            this.btn_Supprimer.TabIndex = 1;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Valider.Location = new System.Drawing.Point(10, 10);
            this.btn_Valider.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(141, 36);
            this.btn_Valider.TabIndex = 2;
            this.btn_Valider.Text = "Ajouter";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Annuler.Location = new System.Drawing.Point(10, 66);
            this.btn_Annuler.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(141, 36);
            this.btn_Annuler.TabIndex = 3;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // cbx_Marque
            // 
            this.cbx_Marque.FormattingEnabled = true;
            this.cbx_Marque.Location = new System.Drawing.Point(83, 117);
            this.cbx_Marque.Name = "cbx_Marque";
            this.cbx_Marque.Size = new System.Drawing.Size(408, 21);
            this.cbx_Marque.TabIndex = 5;
            // 
            // cbx_SousFamille
            // 
            this.cbx_SousFamille.FormattingEnabled = true;
            this.cbx_SousFamille.Location = new System.Drawing.Point(83, 90);
            this.cbx_SousFamille.Name = "cbx_SousFamille";
            this.cbx_SousFamille.Size = new System.Drawing.Size(408, 21);
            this.cbx_SousFamille.TabIndex = 6;
            // 
            // tbx_Ref
            // 
            this.tbx_Ref.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbx_Ref.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_Ref.Location = new System.Drawing.Point(83, 3);
            this.tbx_Ref.Name = "tbx_Ref";
            this.tbx_Ref.Size = new System.Drawing.Size(408, 20);
            this.tbx_Ref.TabIndex = 1;
            // 
            // tbx_Description
            // 
            this.tbx_Description.Location = new System.Drawing.Point(83, 29);
            this.tbx_Description.Multiline = true;
            this.tbx_Description.Name = "tbx_Description";
            this.tbx_Description.Size = new System.Drawing.Size(408, 55);
            this.tbx_Description.TabIndex = 3;
            // 
            // lbl_SousFamille
            // 
            this.lbl_SousFamille.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_SousFamille.AutoSize = true;
            this.lbl_SousFamille.Location = new System.Drawing.Point(11, 94);
            this.lbl_SousFamille.Name = "lbl_SousFamille";
            this.lbl_SousFamille.Size = new System.Drawing.Size(66, 13);
            this.lbl_SousFamille.TabIndex = 4;
            this.lbl_SousFamille.Text = "Sous-Famille";
            // 
            // lbl_Marque
            // 
            this.lbl_Marque.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Marque.AutoSize = true;
            this.lbl_Marque.Location = new System.Drawing.Point(34, 121);
            this.lbl_Marque.Name = "lbl_Marque";
            this.lbl_Marque.Size = new System.Drawing.Size(43, 13);
            this.lbl_Marque.TabIndex = 5;
            this.lbl_Marque.Text = "Marque";
            // 
            // lbl_PrixHT
            // 
            this.lbl_PrixHT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PrixHT.AutoSize = true;
            this.lbl_PrixHT.Location = new System.Drawing.Point(38, 149);
            this.lbl_PrixHT.Name = "lbl_PrixHT";
            this.lbl_PrixHT.Size = new System.Drawing.Size(39, 13);
            this.lbl_PrixHT.TabIndex = 6;
            this.lbl_PrixHT.Text = "PrixHT";
            // 
            // tbx_PrixHT
            // 
            this.tbx_PrixHT.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_PrixHT.Location = new System.Drawing.Point(83, 144);
            this.tbx_PrixHT.Name = "tbx_PrixHT";
            this.tbx_PrixHT.Size = new System.Drawing.Size(408, 20);
            this.tbx_PrixHT.TabIndex = 9;
            this.tbx_PrixHT.TextChanged += new System.EventHandler(this.tbx_PrixHT_TextChanged);
            // 
            // lbl_Ref
            // 
            this.lbl_Ref.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Ref.AutoSize = true;
            this.lbl_Ref.Location = new System.Drawing.Point(20, 6);
            this.lbl_Ref.Name = "lbl_Ref";
            this.lbl_Ref.Size = new System.Drawing.Size(57, 13);
            this.lbl_Ref.TabIndex = 0;
            this.lbl_Ref.Text = "Référence";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbx_PrixHT, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbx_Marque, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_PrixHT, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Ref, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbx_SousFamille, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbx_Ref, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Marque, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbx_Description, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Description, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_SousFamille, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 170);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lbl_Description
            // 
            this.lbl_Description.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(17, 50);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(60, 13);
            this.lbl_Description.TabIndex = 2;
            this.lbl_Description.Text = "Description";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Valider, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Annuler, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_Supprimer, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(503, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(161, 170);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 333);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(667, 176);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 513);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.lv_Article);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArticleForm";
            this.Text = "Gestion des Articles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArticleForm_FormClosed);
            this.Load += new System.EventHandler(this.ArticleForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Article;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader REF;
        private System.Windows.Forms.ColumnHeader SousFamille;
        private System.Windows.Forms.ColumnHeader Marque;
        private System.Windows.Forms.ColumnHeader PrixHT;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.TextBox tbx_Ref;
        private System.Windows.Forms.TextBox tbx_Description;
        private System.Windows.Forms.Label lbl_SousFamille;
        private System.Windows.Forms.Label lbl_Marque;
        private System.Windows.Forms.Label lbl_PrixHT;
        private System.Windows.Forms.TextBox tbx_PrixHT;
        private System.Windows.Forms.Label lbl_Ref;
        private System.Windows.Forms.ComboBox cbx_Marque;
        private System.Windows.Forms.ComboBox cbx_SousFamille;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    }
}