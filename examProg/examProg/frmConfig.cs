using System;
using System.Windows.Forms;
using dllExam;

namespace examProg
{
    public partial class frmConfig : Form
    {
        string erreur = "";
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, System.EventArgs e)
        {
            erreur = "";
            try
            {
                Configuration config = new Configuration();
                //Ajout du nom du joueur dans la config
                config.setNomJoueur(txtb_nom.Text);

                //Ajout des valeurs pour les boites
                byte.TryParse(cmb_monsters.SelectedItem?.ToString()  , out config.nbBoxMonster);
                byte.TryParse(cmb_boxAidKit.SelectedItem?.ToString() , out config.nbBoxAidKit);
                byte.TryParse(cmb_boxVide.SelectedItem?.ToString()   , out config.nbBoxEmpty);

                //S'il existe au moins une boite avec un monstre
                if(config.nbBoxMonster == 0)
                {
                    throw new Exception("Boites monstres au moins une");
                }
                //Regarde si le nombre de boites est correct == 5
                byte nbBoxes = config.NbBoxes();
                if(nbBoxes == 5)
                {
                    config.registerLife(txtb_energie.Text);
                    if(CheckRdbChecked())
                    {
                        //Lancement du jeu
                        frmJeu jeu = new frmJeu();
                        jeu.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Choix si pas le temps stp");
                    }
                }
                else
                {
                    if(nbBoxes < 5)
                    {
                        throw new Exception("Pas assez de boites");
                    }
                    else
                    {
                        throw new Exception("Trop de boites");
                    }
                }

            }
            catch(Exception ex)
            {
                erreur += "Erreur Main :\n";
                erreur += ex.Message;
                if (ex.InnerException != null)
                {
                    erreur += "Détails: " + ex.InnerException.Message;
                }
                MessageBox.Show(erreur);
            }
        }

        private bool CheckRdbChecked()
        {
            bool res = false;
            if(rdb_loseOneLife.Checked || rdb_moitieEnergie.Checked)
            {
                res = true;
            }
            return res;
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
