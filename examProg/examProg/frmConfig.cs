using System;
using System.Windows.Forms;

namespace examProg
{
    public partial class frmConfig : Form
    {
        string ERREURVALIDATION = "";
        const byte MAXCHARNAME = 15;
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, System.EventArgs e)
        {
            try
            {
                //IsNameEmptyOrMaxed();
                //CountBoxes();
                //CheckEnergie();
                frmJeu jeu = new frmJeu();
                jeu.ShowDialog();

            }
            catch(Exception ex)
            {
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Détails: " + ex.InnerException.Message);
                }
            }
        }

        private bool CheckEnergie()
        {
            bool res = true;
            byte energie = 0;
            try
            {
                byte.TryParse(txtb_energie.Text.Trim(), out energie);
                if(energie < 5 || energie > 40)
                {
                    res = false;
                }
            }
            catch (Exception ex)
            {
                ERREURVALIDATION = "Energie : [5;40]";
                throw new Exception(ERREURVALIDATION, ex);
            }
            return res;
        }

        private byte CountBoxes()
        {
            byte somme = 0;
            try
            {
                somme += NbBox(cmb_monsters);
                somme += NbBox(cmb_boxAidKit);
                somme += NbBox(cmb_boxVide);
            }
            catch(Exception ex)
            {
                throw new Exception("Erreur : compter les boites !", ex);
            }
            return somme;
        }

        private byte NbBox(ComboBox cmb)
        {
            byte boxes = 0;
            try
            {
                if(cmb.SelectedIndex != -1)
                {
                    byte.TryParse(cmb.SelectedItem.ToString(), out boxes);
                }
                else
                {
                    ERREURVALIDATION = "Indice -1 dans " + cmb.Text;
                    throw new Exception(ERREURVALIDATION);
                }
            }
            catch(Exception ex)
            {
                ERREURVALIDATION = "Erreur dans boite : " + cmb;
                throw new Exception(ERREURVALIDATION, ex);
            }
            return boxes;
        }

        private bool IsNameEmptyOrMaxed()
        {
            bool res = false;
            //regarde si le nom est vide en retirant les espaces superflus et si la 
            //longueur du text est inférieure à MAXCHARNAME
            string name = txtb_nom.Text.Trim();
            if (name.Length == 0 || name.Length >= MAXCHARNAME)
            {
                res = true;
            }
            return res;
        }
    }
}
