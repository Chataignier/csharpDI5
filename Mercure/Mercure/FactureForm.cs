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
    public partial class FactureForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private MercureService Service;
        private List<string[]> Factures;
        private List<string[]> Articles;

        /// <summary>
        /// 
        /// </summary>
        public FactureForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_Facture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FactureForm_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        /// <summary>
        /// Permet de mettre à jour la liste des factures
        /// </summary>
        private void UpdateListView()
        {
            Service.Url = MDIForm.URLServiceWeb;

            lv_Facture.Items.Clear();

            foreach (string[] Facture in Service.GetFactures())
            {
                lv_Facture.Items.Add(
                    new ListViewItem(
                        new string[] { Facture[0], Facture[9] }
                        )
                );
            }
        }
    }
}
