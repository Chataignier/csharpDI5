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
    /// Cette classe représente la fenetre permettant de gérer les articles
    /// </summary>
    public partial class ArticleForm : Form
    {
        private MercureService Service;
        private List<string[]> Marques;
        private List<string[]> SousFamilles;
        
        /// <summary>
        /// Permet de constuire l'objet
        /// </summary>
        public ArticleForm()
        {
            InitializeComponent();

            Service = new MercureService();
            Service.Url = MDIForm.URLServiceWeb;

            Marques = Service.GetMarques();
            SousFamilles = Service.GetSousFamilles();
        }

        /// <summary>
        /// Handler permettant de gérer la suppresion d'un article
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Service.Url = MDIForm.URLServiceWeb;

            tbx_Ref.Text = "";
            tbx_Description.Text = "";
            cbx_SousFamille.Text = "";
            cbx_Marque.Text = "";
            tbx_PrixHT.Text = "";
            tbx_Ref.ReadOnly = false;

            if(lv_Article.SelectedItems.Count > 0)
            {
                var Confirmation = MessageBox.Show("Voulez-vous vraiment suprimer ce(s) ligne(s) ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (Confirmation == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lv_Article.SelectedItems)
                    {
                        Service.DeleteArticle(item.SubItems[0].Text);
                        item.Remove();
                    }
                }
            }    
        }

        /// <summary>
        /// Permet de charger la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArticleForm_Load(object sender, EventArgs e)
        {
            UpdateListView();

            foreach (string[] marque in Marques)
            {
                cbx_Marque.Items.Add(marque[1]);
            }

            foreach (string[] sousFamille in SousFamilles)
            {
                cbx_SousFamille.Items.Add(sousFamille[2]);
            }
        }

        /// <summary>
        /// Permet de mettre à jour la liste des articles
        /// </summary>
        private void UpdateListView()
        {
            Service.Url = MDIForm.URLServiceWeb;

            lv_Article.Items.Clear();

            foreach (string[] Article in Service.GetArticles())
            {
                lv_Article.Items.Add(
                    new ListViewItem(
                        new string[] { Article[0], Article[1], Article[5], Article[7], Article[8] }
                        )
                );
            }
        }

        /// <summary>
        /// Permet de récupérer l'article sélectionné par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_Article_Click(object sender, EventArgs e)
        {
            btn_Valider.Text = "Modifier";
            tbx_Ref.ReadOnly = true;
            tbx_Ref.Text = lv_Article.SelectedItems[0].SubItems[0].Text;
            tbx_Description.Text = lv_Article.SelectedItems[0].SubItems[1].Text;
            cbx_SousFamille.Text = lv_Article.SelectedItems[0].SubItems[2].Text;
            cbx_Marque.Text = lv_Article.SelectedItems[0].SubItems[3].Text;
            tbx_PrixHT.Text = lv_Article.SelectedItems[0].SubItems[4].Text;
        }

        /// <summary>
        /// Permet à l'utilisateur d'annuler l'action courante et de vider les champs du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            btn_Valider.Text = "Ajouter";
            tbx_Ref.ReadOnly = false;
            tbx_Ref.Text = "";
            tbx_Description.Text = "";
            cbx_SousFamille.Text = "";
            cbx_Marque.Text = "";
            tbx_PrixHT.Text = "";
            tbx_PrixHT.BackColor = Color.White;
        }

        /// <summary>
        /// Permet de valider l'action choisie par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Valider_Click(object sender, EventArgs e)
        {
            Service.Url = MDIForm.URLServiceWeb;

            float prix;

            if (string.IsNullOrEmpty(tbx_Description.Text) ||
                string.IsNullOrEmpty(tbx_Ref.Text) ||
                string.IsNullOrEmpty(cbx_SousFamille.Text) ||
                string.IsNullOrEmpty(cbx_Marque.Text) ||
                string.IsNullOrEmpty(tbx_PrixHT.Text)
                )
            {
                MessageBox.Show("Un des champs est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!float.TryParse(tbx_PrixHT.Text, out prix))
            {
                MessageBox.Show("Le prix doit etre un nombre", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbx_PrixHT.BackColor = Color.Red;
            }
            else
            {
                int indexMarque = -1;
                int indexSousFamille = -1;

                foreach (string[] marque in Marques)
                {
                    if (marque[1].Equals(cbx_Marque.Text))
                    {
                        indexMarque = Convert.ToInt32(marque[0]);
                        break;
                    }
                }

                foreach (string[] sousFamille in SousFamilles)
                {
                    if (sousFamille[2].Equals(cbx_SousFamille.Text))
                    {
                        indexSousFamille = Convert.ToInt32(sousFamille[0]);
                        break;
                    }
                }

                if (indexMarque == -1)
                {
                    MessageBox.Show("La marque n'existe pas.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (indexSousFamille == -1)
                {
                    MessageBox.Show("La sous-famille n'existe pas.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (btn_Valider.Text.Equals("Ajouter"))
                {
                    Service.AddArticle(tbx_Ref.Text, tbx_Description.Text, indexSousFamille, indexMarque, prix);
                    MessageBox.Show("L'Article " + tbx_Ref.Text + " a été ajouté.", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateListView();
                }
                else
                {
                    Service.UpdateArticle(tbx_Ref.Text, tbx_Description.Text, indexSousFamille, indexMarque, prix);
                    MessageBox.Show("L'Article " + tbx_Ref.Text + " a été modifié.", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateListView();
                }
            }

        }

        /// <summary>
        /// Permet de colorer le champs du prix en fonction de ce que l'utilisateur a tapé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_PrixHT_TextChanged(object sender, EventArgs e)
        {
            float result;
            if (!float.TryParse(tbx_PrixHT.Text, out result))
            {
                tbx_PrixHT.BackColor = Color.MistyRose;
            }
            else
            {
                tbx_PrixHT.BackColor = Color.LightGreen;
            }
        }

        /// <summary>
        /// Permet de mettre l'objet à null lorsque la fenêtre se ferme. Utilisé pour n'avoir qu'une seule fenêtre à chaque fois.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArticleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIForm.articleForm = null;
        }
    }
}
