using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            int[] valeurBillets = {1000, 200, 100, 50, 20, 10, 5, 2, 1};
            int[] valeurCentimes = {50, 20, 10, 5};
            TxBResultat.Lines = Retrait(Int32.Parse(TxBEntiers.Text), Int32.Parse(TxBCentimes.Text), valeurBillets, valeurCentimes, "chf");

        }

        public string[] Retrait(int entier, int centimes, int[] valeurBillets, int[] valeurCentimes, string devise)
        {
            string[] lignes;
            lignes = new string[15];
            int nbBillets = 0, i = 0;
            double memEntier = Convert.ToSingle(entier);
            double memCentimes = Convert.ToSingle(centimes);

            // traitement des entiers           
            foreach(int valeur in valeurBillets)
            {
                nbBillets = Convert.ToInt32(Math.Floor(memEntier / valeur));
                memEntier -= valeur * nbBillets;
                if (nbBillets != 0)
                { 
                    lignes[i] = nbBillets.ToString() + " x " + valeur.ToString() + " " + devise;
                    i++;
                }
                nbBillets = 0;
                
            }
            // traitement des centimes      
            foreach(int valeur in valeurCentimes)
            {
                nbBillets = Convert.ToInt32(Math.Floor(memCentimes / valeur));
                memCentimes -= valeur * nbBillets;
                if (nbBillets != 0)
                { 
                    lignes[i] = nbBillets.ToString() + " x " + valeur.ToString() + " cts de " + devise;
                    i++;
                }
                nbBillets = 0;
                
            }
            return(lignes);
     
        }
    }
   
   
}
