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
    /// Cette classe représente la fenetre permettant de gérer les familles
    /// </summary>
    public partial class FamilleForm : Form
    {
        private MercureService Service;

        /// <summary>
        /// Permet de constuire l'objet
        /// </summary>
        public FamilleForm()
        {
            InitializeComponent();
            Service = new MercureService();
            Service.Url = MDIForm.URLServiceWeb;
        }

        /// <summary>
        /// Permet de charger la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FamilleForm_Load(object sender, EventArgs e)
        {
            UpdateListView();
            tbx_identifiant.ReadOnly = true;
        }

        /// <summary>
        ///  Permet de mettre à jour la liste des familles
        /// </summary>
        private void UpdateListView()
        {
            Service.Url = MDIForm.URLServiceWeb;

            lv_Famille.Items.Clear();

            foreach (string[] Famille in Service.GetFamilles())
            {
                lv_Famille.Items.Add(
                    new ListViewItem(Famille)
                );
            }
        }

        /// <summary>
        /// Permet de récupérer la famille sélectionné par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_Famille_Click(object sender, EventArgs e)
        {
            btn_valider.Text = "Modifier";
            tbx_identifiant.Text = lv_Famille.SelectedItems[0].SubItems[0].Text;
            tbx_nom.Text = lv_Famille.SelectedItems[0].SubItems[1].Text;
        }

        /// <summary>
        /// Permet à l'utilisateur d'annuler l'action courante et de vider les champs du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            btn_valider.Text = "Ajouter";
            tbx_identifiant.Text = "";
            tbx_nom.Text = "";
        }

        /// <summary>
        /// Handler permettant de gérer la suppresion d'une famille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            Service.Url = MDIForm.URLServiceWeb;

            tbx_identifiant.Text = "";
            tbx_nom.Text = "";

            if (lv_Famille.SelectedItems.Count > 0)
            {
                var Confirmation = MessageBox.Show("Voulez-vous vraiment suprimer ce(s) ligne(s) ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Confirmation == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lv_Famille.SelectedItems)
                    {
                        Service.DeleteFamille(Convert.ToInt32(item.SubItems[0].Text));
                        item.Remove();
                    }
                }
            }

            btn_valider.Text = "Ajouter";
        }

        /// <summary>
        /// Permet de valider l'action choisie par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_valider_Click(object sender, EventArgs e)
        {
            Service.Url = MDIForm.URLServiceWeb;

            if (string.IsNullOrEmpty(tbx_nom.Text))
            {
                MessageBox.Show("Le champs est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (btn_valider.Text.Equals("Ajouter"))
                {
                    Service.AddFamille(tbx_nom.Text);
                    MessageBox.Show("La Famille " + tbx_nom.Text + " a été ajoutée.", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateListView();
                    btn_valider.Text = "Ajouter";
                    tbx_identifiant.Text = "";
                    tbx_nom.Text = "";
                }
                else
                {
                    Service.UpdateFamille(Convert.ToInt32(tbx_identifiant.Text), tbx_nom.Text);
                    MessageBox.Show("La Famille " + tbx_nom.Text + " a été modifiée.", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateListView();
                    btn_valider.Text = "Ajouter";
                    tbx_identifiant.Text = "";
                    tbx_nom.Text = "";
                }
            }
        }

        /// <summary>
        /// Permet de mettre l'objet à null lorsque la fenêtre se ferme. Utilisé pour n'avoir qu'une seule fenêtre à chaque fois.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FamilleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIForm.familleForm = null;
        }
    }
}
