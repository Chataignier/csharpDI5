using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    /// <summary>
    /// Fenêtre qui permet de gérer la configuration de l'URL
    /// </summary>
    public partial class ConfigurationURL : Form
    {
        /// <summary>
        /// Permet de construire l'objet
        /// </summary>
        public ConfigurationURL()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet de charger la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigurationURL_Load(object sender, EventArgs e)
        {
            this.txb_URL.Text = MDIForm.URLServiceWeb; 
        }

        /// <summary>
        /// Permet de gérer la validation de la nouvelle URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Valider_Click(object sender, EventArgs e)
        {
            try
            {

                MercureService Service = new MercureService();
                Service.Url = txb_URL.Text;

                Service.GetClients();

                MDIForm.URLServiceWeb = txb_URL.Text;
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("L'URL n'est pas valide", "attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Permet d'annuler la modification de l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            txb_URL.Text = MDIForm.URLServiceWeb;
        }

        /// <summary>
        /// Permet de réinitialiser la valeur de l'URL par défaut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_parDefault_Click(object sender, EventArgs e)
        {
            MDIForm.URLServiceWeb = "http://localhost:8001/Sources/Mercure.asmx";
            txb_URL.Text = MDIForm.URLServiceWeb;
        }
   
    }
}
