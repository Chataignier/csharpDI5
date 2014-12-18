namespace Mercure
{
    partial class ConfigurationURL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationURL));
            this.txb_URL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_parDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_URL
            // 
            resources.ApplyResources(this.txb_URL, "txb_URL");
            this.txb_URL.Name = "txb_URL";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btn_Valider
            // 
            resources.ApplyResources(this.btn_Valider, "btn_Valider");
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Annuler
            // 
            resources.ApplyResources(this.btn_Annuler, "btn_Annuler");
            this.btn_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_parDefault
            // 
            resources.ApplyResources(this.btn_parDefault, "btn_parDefault");
            this.btn_parDefault.Name = "btn_parDefault";
            this.btn_parDefault.UseVisualStyleBackColor = true;
            this.btn_parDefault.Click += new System.EventHandler(this.btn_parDefault_Click);
            // 
            // ConfigurationURL
            // 
            this.AcceptButton = this.btn_Valider;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Annuler;
            this.Controls.Add(this.btn_parDefault);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_URL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ConfigurationURL";
            this.Load += new System.EventHandler(this.ConfigurationURL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_URL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_parDefault;
    }
}