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
    public partial class MDIForm : Form
    {
        public static ConfigurationURL configurationURL; // new ConfigurationURL();
        public static ArticleForm articleForm;
        public static MarqueForm marqueForm;
        public static FamilleForm familleForm;
        public static SousFamilleForm sousFamilleForm;

        //public event EventHandler Changed;

        public static string URLServiceWeb = "http://localhost:8001/Sources/Mercure.asmx";

        /// <summary>
        /// 
        /// </summary>
        public MDIForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void configurationURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configurationURL = new ConfigurationURL();
            configurationURL.ShowDialog();
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
