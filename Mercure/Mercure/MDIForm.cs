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
    /// Fenêtre principale de notre programme
    /// </summary>
    public partial class MDIForm : Form
    {
        public static ConfigurationURL configurationURL;
        public static ArticleForm articleForm;
        public static MarqueForm marqueForm;
        public static FamilleForm familleForm;
        public static SousFamilleForm sousFamilleForm;

        public static string URLServiceWeb = "http://localhost:8001/Sources/Mercure.asmx";

        /// <summary>
        /// Contructeur de la classe MDIForm()
        /// </summary>
        public MDIForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet de construire la fenêtre de configuration et de l'afficher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void configurationURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configurationURL = new ConfigurationURL();
            configurationURL.ShowDialog();
        }

        /// <summary>
        /// Permet de construire la fenêtre d'article et de l'afficher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (articleForm == null)
            {
                articleForm = new ArticleForm();
                articleForm.MdiParent = this;
                articleForm.Show();
            }
            else
            {
                articleForm.BringToFront();
            }
        }

        /// <summary>
        /// Permet de construire la fenêtre de marques et de l'afficher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void marqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (marqueForm == null)
            {
                marqueForm = new MarqueForm();
                marqueForm.MdiParent = this;
                marqueForm.Show();
            }
            else
            {
                marqueForm.BringToFront();
            }
        }

        /// <summary>
        /// Permet de construire la fenêtre des familles et de l'afficher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void familleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (familleForm == null)
            {
                familleForm = new FamilleForm();
                familleForm.MdiParent = this;
                familleForm.Show();
            }
            else
            {
                familleForm.BringToFront();
            }
        }

        /// <summary>
        /// Permet de construire la fenêtre des sous-familles et de l'afficher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sousFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sousFamilleForm == null)
            {
                sousFamilleForm = new SousFamilleForm();
                sousFamilleForm.MdiParent = this;
                sousFamilleForm.Show();
            }
            else
            {
                sousFamilleForm.BringToFront();
            }
        }
    }
}
