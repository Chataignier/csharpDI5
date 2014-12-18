namespace Mercure
{
    partial class FactureForm
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
            this.lv_Facture = new System.Windows.Forms.ListView();
            this.gb_facture = new System.Windows.Forms.GroupBox();
            this.gp_infoFacture = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_reference = new System.Windows.Forms.Label();
            this.tbx_refFacture = new System.Windows.Forms.TextBox();
            this.lbl_createDate = new System.Windows.Forms.Label();
            this.tbx_createDate = new System.Windows.Forms.TextBox();
            this.gb_clientFacture = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_refClient = new System.Windows.Forms.TextBox();
            this.tbx_raisonSocial = new System.Windows.Forms.TextBox();
            this.tbx_nom = new System.Windows.Forms.TextBox();
            this.tbx_prenom = new System.Windows.Forms.TextBox();
            this.tbx_adresse = new System.Windows.Forms.TextBox();
            this.tbx_codePostal = new System.Windows.Forms.TextBox();
            this.tbx_Ville = new System.Windows.Forms.TextBox();
            this.tbx_Pays = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_articles = new System.Windows.Forms.ListView();
            this.btn_AjouterArticle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_prixtotalht = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_prixTotalHT = new System.Windows.Forms.TextBox();
            this.tbx_TVA = new System.Windows.Forms.TextBox();
            this.tbx_PrixTotalTTC = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gb_facture.SuspendLayout();
            this.gp_infoFacture.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_clientFacture.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Facture
            // 
            this.lv_Facture.Location = new System.Drawing.Point(6, 18);
            this.lv_Facture.Name = "lv_Facture";
            this.lv_Facture.Size = new System.Drawing.Size(186, 294);
            this.lv_Facture.TabIndex = 0;
            this.lv_Facture.UseCompatibleStateImageBehavior = false;
            this.lv_Facture.SelectedIndexChanged += new System.EventHandler(this.lv_Facture_SelectedIndexChanged);
            // 
            // gb_facture
            // 
            this.gb_facture.Controls.Add(this.lv_Facture);
            this.gb_facture.Location = new System.Drawing.Point(2, 4);
            this.gb_facture.Name = "gb_facture";
            this.gb_facture.Size = new System.Drawing.Size(198, 318);
            this.gb_facture.TabIndex = 1;
            this.gb_facture.TabStop = false;
            this.gb_facture.Text = "Liste des Factures";
            // 
            // gp_infoFacture
            // 
            this.gp_infoFacture.Controls.Add(this.tableLayoutPanel1);
            this.gp_infoFacture.Location = new System.Drawing.Point(201, 4);
            this.gp_infoFacture.Name = "gp_infoFacture";
            this.gp_infoFacture.Size = new System.Drawing.Size(347, 77);
            this.gp_infoFacture.TabIndex = 2;
            this.gp_infoFacture.TabStop = false;
            this.gp_infoFacture.Text = "Information Facture *";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lbl_reference, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_refFacture, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_createDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbx_createDate, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(335, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_reference
            // 
            this.lbl_reference.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_reference.AutoSize = true;
            this.lbl_reference.Location = new System.Drawing.Point(40, 6);
            this.lbl_reference.Name = "lbl_reference";
            this.lbl_reference.Size = new System.Drawing.Size(57, 13);
            this.lbl_reference.TabIndex = 0;
            this.lbl_reference.Text = "Référence";
            // 
            // tbx_refFacture
            // 
            this.tbx_refFacture.Location = new System.Drawing.Point(103, 3);
            this.tbx_refFacture.Name = "tbx_refFacture";
            this.tbx_refFacture.Size = new System.Drawing.Size(232, 20);
            this.tbx_refFacture.TabIndex = 1;
            // 
            // lbl_createDate
            // 
            this.lbl_createDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_createDate.AutoSize = true;
            this.lbl_createDate.Location = new System.Drawing.Point(11, 32);
            this.lbl_createDate.Name = "lbl_createDate";
            this.lbl_createDate.Size = new System.Drawing.Size(86, 13);
            this.lbl_createDate.TabIndex = 2;
            this.lbl_createDate.Text = "Date de création";
            // 
            // tbx_createDate
            // 
            this.tbx_createDate.Location = new System.Drawing.Point(103, 29);
            this.tbx_createDate.Name = "tbx_createDate";
            this.tbx_createDate.Size = new System.Drawing.Size(232, 20);
            this.tbx_createDate.TabIndex = 3;
            // 
            // gb_clientFacture
            // 
            this.gb_clientFacture.Controls.Add(this.tableLayoutPanel2);
            this.gb_clientFacture.Location = new System.Drawing.Point(201, 87);
            this.gb_clientFacture.Name = "gb_clientFacture";
            this.gb_clientFacture.Size = new System.Drawing.Size(347, 235);
            this.gb_clientFacture.TabIndex = 3;
            this.gb_clientFacture.TabStop = false;
            this.gb_clientFacture.Text = "Information Client";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.tbx_refClient, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbx_raisonSocial, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbx_nom, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbx_prenom, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbx_codePostal, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbx_Ville, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.tbx_Pays, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.tbx_adresse, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 212);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raison Social";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prénom";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Code Postal";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ville";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pays";
            // 
            // tbx_refClient
            // 
            this.tbx_refClient.Location = new System.Drawing.Point(103, 3);
            this.tbx_refClient.Name = "tbx_refClient";
            this.tbx_refClient.Size = new System.Drawing.Size(233, 20);
            this.tbx_refClient.TabIndex = 8;
            // 
            // tbx_raisonSocial
            // 
            this.tbx_raisonSocial.Location = new System.Drawing.Point(103, 29);
            this.tbx_raisonSocial.Name = "tbx_raisonSocial";
            this.tbx_raisonSocial.Size = new System.Drawing.Size(233, 20);
            this.tbx_raisonSocial.TabIndex = 9;
            // 
            // tbx_nom
            // 
            this.tbx_nom.Location = new System.Drawing.Point(103, 55);
            this.tbx_nom.Name = "tbx_nom";
            this.tbx_nom.Size = new System.Drawing.Size(233, 20);
            this.tbx_nom.TabIndex = 10;
            // 
            // tbx_prenom
            // 
            this.tbx_prenom.Location = new System.Drawing.Point(103, 81);
            this.tbx_prenom.Name = "tbx_prenom";
            this.tbx_prenom.Size = new System.Drawing.Size(233, 20);
            this.tbx_prenom.TabIndex = 11;
            // 
            // tbx_adresse
            // 
            this.tbx_adresse.Location = new System.Drawing.Point(103, 107);
            this.tbx_adresse.Name = "tbx_adresse";
            this.tbx_adresse.Size = new System.Drawing.Size(233, 20);
            this.tbx_adresse.TabIndex = 12;
            // 
            // tbx_codePostal
            // 
            this.tbx_codePostal.Location = new System.Drawing.Point(103, 133);
            this.tbx_codePostal.Name = "tbx_codePostal";
            this.tbx_codePostal.Size = new System.Drawing.Size(233, 20);
            this.tbx_codePostal.TabIndex = 13;
            // 
            // tbx_Ville
            // 
            this.tbx_Ville.Location = new System.Drawing.Point(103, 159);
            this.tbx_Ville.Name = "tbx_Ville";
            this.tbx_Ville.Size = new System.Drawing.Size(233, 20);
            this.tbx_Ville.TabIndex = 14;
            // 
            // tbx_Pays
            // 
            this.tbx_Pays.Location = new System.Drawing.Point(103, 185);
            this.tbx_Pays.Name = "tbx_Pays";
            this.tbx_Pays.Size = new System.Drawing.Size(233, 20);
            this.tbx_Pays.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_AjouterArticle);
            this.groupBox1.Controls.Add(this.lv_articles);
            this.groupBox1.Location = new System.Drawing.Point(2, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Articles";
            // 
            // lv_articles
            // 
            this.lv_articles.Location = new System.Drawing.Point(11, 20);
            this.lv_articles.Name = "lv_articles";
            this.lv_articles.Size = new System.Drawing.Size(374, 124);
            this.lv_articles.TabIndex = 0;
            this.lv_articles.UseCompatibleStateImageBehavior = false;
            // 
            // btn_AjouterArticle
            // 
            this.btn_AjouterArticle.Location = new System.Drawing.Point(405, 20);
            this.btn_AjouterArticle.Name = "btn_AjouterArticle";
            this.btn_AjouterArticle.Size = new System.Drawing.Size(99, 23);
            this.btn_AjouterArticle.TabIndex = 1;
            this.btn_AjouterArticle.Text = "Ajouter Article";
            this.btn_AjouterArticle.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modifier Quantité";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(405, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Supprimer Article";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(555, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 475);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_prixtotalht, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbx_prixTotalHT, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbx_TVA, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbx_PrixTotalTTC, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 229);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(188, 83);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lbl_prixtotalht
            // 
            this.lbl_prixtotalht.AutoSize = true;
            this.lbl_prixtotalht.Location = new System.Drawing.Point(3, 0);
            this.lbl_prixtotalht.Name = "lbl_prixtotalht";
            this.lbl_prixtotalht.Size = new System.Drawing.Size(69, 13);
            this.lbl_prixtotalht.TabIndex = 0;
            this.lbl_prixtotalht.Text = "Prix Total HT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "TVA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Prix Total TTC";
            // 
            // tbx_prixTotalHT
            // 
            this.tbx_prixTotalHT.Location = new System.Drawing.Point(97, 3);
            this.tbx_prixTotalHT.Name = "tbx_prixTotalHT";
            this.tbx_prixTotalHT.Size = new System.Drawing.Size(88, 20);
            this.tbx_prixTotalHT.TabIndex = 3;
            // 
            // tbx_TVA
            // 
            this.tbx_TVA.Location = new System.Drawing.Point(97, 29);
            this.tbx_TVA.Name = "tbx_TVA";
            this.tbx_TVA.Size = new System.Drawing.Size(88, 20);
            this.tbx_TVA.TabIndex = 4;
            // 
            // tbx_PrixTotalTTC
            // 
            this.tbx_PrixTotalTTC.Location = new System.Drawing.Point(97, 55);
            this.tbx_PrixTotalTTC.Name = "tbx_PrixTotalTTC";
            this.tbx_PrixTotalTTC.Size = new System.Drawing.Size(88, 20);
            this.tbx_PrixTotalTTC.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Ajouter Facture";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Supprimer Facture";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FactureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_clientFacture);
            this.Controls.Add(this.gp_infoFacture);
            this.Controls.Add(this.gb_facture);
            this.Name = "FactureForm";
            this.Text = "Gestion des factures";
            this.Load += new System.EventHandler(this.FactureForm_Load);
            this.gb_facture.ResumeLayout(false);
            this.gp_infoFacture.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_clientFacture.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Facture;
        private System.Windows.Forms.GroupBox gb_facture;
        private System.Windows.Forms.GroupBox gp_infoFacture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_reference;
        private System.Windows.Forms.TextBox tbx_refFacture;
        private System.Windows.Forms.Label lbl_createDate;
        private System.Windows.Forms.TextBox tbx_createDate;
        private System.Windows.Forms.GroupBox gb_clientFacture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_refClient;
        private System.Windows.Forms.TextBox tbx_raisonSocial;
        private System.Windows.Forms.TextBox tbx_nom;
        private System.Windows.Forms.TextBox tbx_prenom;
        private System.Windows.Forms.TextBox tbx_adresse;
        private System.Windows.Forms.TextBox tbx_codePostal;
        private System.Windows.Forms.TextBox tbx_Ville;
        private System.Windows.Forms.TextBox tbx_Pays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_AjouterArticle;
        private System.Windows.Forms.ListView lv_articles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_prixtotalht;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_prixTotalHT;
        private System.Windows.Forms.TextBox tbx_TVA;
        private System.Windows.Forms.TextBox tbx_PrixTotalTTC;
    }
}