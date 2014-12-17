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
    /// 
    /// </summary>
    public partial class SousFamilleForm : Form
    {
        private MercureService Service;
        private List<string[]> Familles;

        /// <summary>
        /// 
        /// </summary>
        public SousFamilleForm()
        {
            InitializeComponent();

            Service = new MercureService();
            Service.Url = MDIForm.URLServiceWeb;

            Familles = Service.GetFamilles();
        }


        /// <summary>
        /// 
        /// </summary>
        private void UpdateListView()
        {
            Service.Url = MDIForm.URLServiceWeb;

            lv_SousFamille.Items.Clear();

            foreach (string[] SousFamille in Service.GetSousFamilles())
            {
                string nomFamille = null;

                foreach (string[] Famille in Familles)
                {
                    if (Famille[0].Equals(SousFamille[1]))
                    {
                        nomFamille = Famille[1];
                        break;
                    }
                }

                lv_SousFamille.Items.Add(
                    new ListViewItem(
                        new string[] { SousFamille[0], SousFamille[2], nomFamille}
                        )
                );
            }
        }

        private void SousFamilleForm_Load(object sender, EventArgs e)
        {
            UpdateListView();

            tbx_identifiant.ReadOnly = true;

            foreach (string[] famille in Familles)
            {
                cbx_Famille.Items.Add(famille[1]);
            }
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            Service.Url = MDIForm.URLServiceWeb;

            if (string.IsNullOrEmpty(tbx_SousFamille.Text) ||
               string.IsNullOrEmpty(cbx_Famille.Text)
               )
            {
                MessageBox.Show("Un des champs est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int indexFamille = -1;

                foreach (string[] Famille in Familles)
                {
                    if (Famille[1].Equals(cbx_Famille.Text))
                    {
                        indexFamille = Convert.ToInt32(Famille[0]);
                        break;
                    }
                }

                if (indexFamille == -1)
                {
                    MessageBox.Show("La marque n'existe pas.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (btn_Valider.Text.Equals("Ajouter"))
                {
                    Service.AddSousFamille(indexFamille, tbx_SousFamille.Text);
                    MessageBox.Show("La sous-famille " + tbx_SousFamille.Text + " a été ajoutée.", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateListView();
                }
                else
                {
                    Service.UpdateSousFamille(Convert.ToInt32(tbx_identifiant.Text), indexFamille, tbx_SousFamille.Text);
                    MessageBox.Show("La sous-famille " + tbx_SousFamille.Text + " a été modifiée.", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateListView();
                }
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            btn_Valider.Text = "Ajouter";
            tbx_identifiant.Text = "";
            tbx_SousFamille.Text = "";
            cbx_Famille.Text = "";
        }

        private void lv_SousFamille_Click(object sender, EventArgs e)
        {
            btn_Valider.Text = "Modifier";
            tbx_identifiant.Text = lv_SousFamille.SelectedItems[0].SubItems[0].Text;
            tbx_SousFamille.Text = lv_SousFamille.SelectedItems[0].SubItems[1].Text;
            cbx_Famille.Text = lv_SousFamille.SelectedItems[0].SubItems[2].Text;
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            Service.Url = MDIForm.URLServiceWeb;

            tbx_identifiant.Text = "";
            tbx_SousFamille.Text = "";
            cbx_Famille.Text = "";

            if (lv_SousFamille.SelectedItems.Count > 0)
            {
                var Confirmation = MessageBox.Show("Voulez-vous vraiment suprimer ce(s) ligne(s) ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Confirmation == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lv_SousFamille.SelectedItems)
                    {
                        Service.DeleteSousFamille(Convert.ToInt32(item.SubItems[0].Text));
                        item.Remove();
                    }
                }
            }    
        }

        private void SousFamilleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIForm.sousFamilleForm = null;
        }
       
    }
}
