namespace Mercure
{
    partial class MarqueForm
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
            this.lv_marque = new System.Windows.Forms.ListView();
            this.Identifiant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Identifiant = new System.Windows.Forms.Label();
            this.lbl_Marque = new System.Windows.Forms.Label();
            this.tbx_identifiant = new System.Windows.Forms.TextBox();
            this.tbx_nom = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_marque
            // 
            this.lv_marque.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Identifiant,
            this.Nom});
            this.lv_marque.FullRowSelect = true;
            this.lv_marque.GridLines = true;
            this.lv_marque.Location = new System.Drawing.Point(3, 3);
            this.lv_marque.Name = "lv_marque";
            this.lv_marque.Size = new System.Drawing.Size(358, 246);
            this.lv_marque.TabIndex = 0;
            this.lv_marque.UseCompatibleStateImageBehavior = false;
            this.lv_marque.View = System.Windows.Forms.View.Details;
            this.lv_marque.SelectedIndexChanged += new System.EventHandler(this.lv_marque_SelectedIndexChanged);
            this.lv_marque.Click += new System.EventHandler(this.lv_marque_Click);
            // 
            // Identifiant
            // 
            this.Identifiant.Text = "Identifiant";
            this.Identifiant.Width = 81;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom marque";
            this.Nom.Width = 253;
            // 
            // lbl_Identifiant
            // 
            this.lbl_Identifiant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Identifiant.AutoSize = true;
            this.lbl_Identifiant.Location = new System.Drawing.Point(14, 14);
            this.lbl_Identifiant.Name = "lbl_Identifiant";
            this.lbl_Identifiant.Size = new System.Drawing.Size(53, 13);
            this.lbl_Identifiant.TabIndex = 0;
            this.lbl_Identifiant.Text = "Identifiant";
            // 
            // lbl_Marque
            // 
            this.lbl_Marque.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Marque.AutoSize = true;
            this.lbl_Marque.Location = new System.Drawing.Point(24, 55);
            this.lbl_Marque.Name = "lbl_Marque";
            this.lbl_Marque.Size = new System.Drawing.Size(43, 13);
            this.lbl_Marque.TabIndex = 1;
            this.lbl_Marque.Text = "Marque";
            // 
            // tbx_identifiant
            // 
            this.tbx_identifiant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbx_identifiant.Location = new System.Drawing.Point(73, 10);
            this.tbx_identifiant.Name = "tbx_identifiant";
            this.tbx_identifiant.Size = new System.Drawing.Size(147, 20);
            this.tbx_identifiant.TabIndex = 2;
            // 
            // tbx_nom
            // 
            this.tbx_nom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbx_nom.Location = new System.Drawing.Point(73, 52);
            this.tbx_nom.Name = "tbx_nom";
            this.tbx_nom.Size = new System.Drawing.Size(147, 20);
            this.tbx_nom.TabIndex = 3;
            // 
            // btn_valider
            // 
            this.btn_valider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_valider.Location = new System.Drawing.Point(3, 3);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(114, 22);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Ajouter";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supprimer.Location = new System.Drawing.Point(3, 31);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(114, 22);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_annuler.Location = new System.Drawing.Point(3, 59);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(114, 23);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.lv_marque);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 351);
            this.panel2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 255);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 91);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tbx_nom, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Marque, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbx_identifiant, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Identifiant, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(226, 83);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btn_valider, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_supprimer, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_annuler, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(235, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(120, 85);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // MarqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 353);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MarqueForm";
            this.Text = "Gestion des Marques";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MarqueForm_FormClosed);
            this.Load += new System.EventHandler(this.MarqueForm_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_marque;
        private System.Windows.Forms.ColumnHeader Identifiant;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.Label lbl_Identifiant;
        private System.Windows.Forms.Label lbl_Marque;
        private System.Windows.Forms.TextBox tbx_identifiant;
        private System.Windows.Forms.TextBox tbx_nom;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}