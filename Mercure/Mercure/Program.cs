using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Mercure
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] Args)
        {
            if (Args.Length != 1)
            {
                MessageBox.Show("Vous devez fournir un fichier ini en parametre", "attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try 
                {
                    MDIForm.URLServiceWebDefault = IniFile.GetString(Args[0], "ServiceWeb", "url");
                    MDIForm.URLServiceWeb = MDIForm.URLServiceWebDefault;

                    MercureService Service = new MercureService();
                    Service.Url = MDIForm.URLServiceWeb;

                    if (Service.GetClients() == null)
                    {
                        MessageBox.Show("La base de données est inconnue.", "attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else 
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new MDIForm());
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Le fichier fourni n'est pas correct. Il doit contenir la section ServeurWeb et le tag url.", "attention !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
