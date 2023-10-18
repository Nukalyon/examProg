using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dllExam
{
    public class Configuration
    {
        const byte MAXCHARNAME = 15;
        private string nomJoueur = "";
        public byte nbBoxMonster = 0;
        public byte nbBoxAidKit = 0;
        public byte nbBoxEmpty = 0;
        private byte hp = 0;
        string error = "";

        public enum NoBoxUsed
        {
            halfLife,
            loseOneLife
        }

        public string getNomJoueur()
        {
            return nomJoueur;
        }

        public void setNomJoueur(string name)
        {
            try
            {
                //regarde si le nom est vide en retirant les espaces superflus et si la 
                //longueur du text est inférieure à MAXCHARNAME
                if (name.Length != 0 && name.Length <= MAXCHARNAME)
                {
                    this.nomJoueur = name;
                }
                else
                {
                    if(name.Length == 0)
                    {
                        error += "Nom vide";
                    }
                    else
                    {
                        error += "Nom trop long";
                    }
                    throw new Exception(error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void registerLife(string s)
        {
            byte energie = 0;
            try
            {
                byte.TryParse(s.Trim(), out energie);
                if (energie < 5 || energie > 40)
                {
                    throw new Exception("Vie : [5;40]");
                }
                else
                {
                    this.hp = energie;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public byte NbBoxes()
        {
            byte somme = 0;
            somme += nbBoxMonster;
            somme += nbBoxAidKit;
            somme += nbBoxEmpty;
            return somme;
        }
    }

    public class Joueur
    {
        const byte MAXCHARNAME = 15;
        private string name = "";
        private byte hp = 0;
        private byte nbLife = 3;
        private int pointage = 0;

        public Joueur()
        {
            this.name = "Bob";
            this.hp = 25;
        }
        public Joueur(string s)
        {
            this.name = s;
            this.hp = 25;
        }
        public Joueur(string s, byte hp)
        {
            this.name = s;
            this.hp = hp;
        }

        private void AddPoints(int nb)
        {
            if (nb < 0)
            {
                nb = 0;
            }
            else
            {
                this.pointage += nb;
            }
        }

        private bool Attacked()
        {
            bool isAlive = true;
            Random rand = new Random();
            byte degat = (byte)rand.Next(5,10);
            if(this.hp - degat < 0)
            {
                this.hp = 0;
                isAlive= false;
            }
            else
            {
                this.hp -= degat;
            }
            return isAlive;
        }

        public string getNomJoueur()
        {
            return name;
        }

        public void setNomJoueur(string name)
        {
            try
            {
                //regarde si le nom est vide en retirant les espaces superflus et si la 
                //longueur du text est inférieure à MAXCHARNAME
                if (name.Length == 0 || name.Length >= MAXCHARNAME)
                {
                    this.name = name;
                }
                else
                {
                    throw new Exception("Erreur nom joueur !");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public class Informations
    {
        const string RETURN = "\r\n";
        private byte timeLeft = 10;
        private int pointage = 0;
        private byte ronde = 1;
        private string events;

        private void AddInformations(string s)
        {
            events += s + RETURN;
        }
    }
}
