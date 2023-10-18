using System;
using System.Drawing;
using System.Windows.Forms;

namespace examProg
{
    public partial class frmJeu : Form
    {
        const ushort MOVE = 10;
        private frmInfos fenetreInfos = new frmInfos();
        public frmJeu()
        {
            InitializeComponent();
        }

        private void frmJeu_Load(object sender, EventArgs e)
        {

        }

        private void frmJeu_KeyDown(object sender, KeyEventArgs e)
        {
            /*
             * Faire attention aux dimensions de la fenetres
             * - la barre est comprise dans la hauteur
             * - l'ombre est comprise dans la largeur
             */
            short humainX = 0;
            short humainY = 0;

            humainX = (short)pnl_player.Left;
            humainY = (short)pnl_player.Top;

            //MessageBox.Show(e.KeyCode.ToString());

            //Place l'image devant le reste (hierarchie de creation)
            pnl_player.BringToFront();
            //Affiche la fenetre de logs
            fenetreInfos.Show();

            Point loc = pnl_player.Location;
            int w = pnl_player.Width;
            int h = pnl_player.Height;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (loc.X - MOVE >= 0)
                    {
                        //picHumain.Left -= MOVE;
                        loc = new Point(loc.X - MOVE, loc.Y);
                    }
                    break;
                case Keys.Right:
                    if (loc.X + MOVE + w < this.ClientSize.Width)
                    {
                        //picHumain.Left += MOVE;
                        loc = new Point(loc.X + MOVE, loc.Y);
                    }
                    break;
                case Keys.Up:
                    if (loc.Y - MOVE >= 0)
                    {
                        //picHumain.Top -= MOVE;
                        loc = new Point(loc.X, loc.Y - MOVE);
                    }
                    break;
                case Keys.Down:
                    if (loc.Y + MOVE + h < this.ClientSize.Height)
                    {
                        //picHumain.Top += MOVE;
                        loc = new Point(loc.X, loc.Y + MOVE);
                    }
                    break;
                case Keys.Q:
                    StopForm();
                    break;
                default:
                    break;
            }
            pnl_player.Location = loc;

            //Collision avec l'ennemi
            if (pnl_player.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                //Collision detectee
                //pictureBox1.Image = Properties.Resources.def;
                //fenetreInfos = j.Attack(CPU3) + RETURN;
                pnl_player.Left = humainX;
                pnl_player.Top = humainY;

            }
            else
            {
                pictureBox2.Image = Properties.Resources.box;
            }


            if (pnl_player.Bounds.IntersectsWith(pictureBox2.Bounds))
            {

                pnl_player.Left = humainX;
                pnl_player.Top = humainY;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.box;
            }


            if (pnl_player.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pnl_player.Left = humainX;
                pnl_player.Top = humainY;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.box;
            }


            if (pnl_player.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                pnl_player.Left = humainX;
                pnl_player.Top = humainY;
            }
            else
            {
                pictureBox4.Image = Properties.Resources.box;
            }


            if (pnl_player.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                pnl_player.Left = humainX;
                pnl_player.Top = humainY;
            }
            else
            {
                pictureBox5.Image = Properties.Resources.box;
            }
            pnl_player.Left = humainX;
            pnl_player.Top = humainY;

            //fenetreInfos.rafraichirInfos();
        }

        private void StopForm()
        {
            Application.Exit();
            //this.Close();
        }
    }
}
