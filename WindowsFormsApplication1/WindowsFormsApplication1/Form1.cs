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
    public partial class FrmBancomat : Form
    {
        public static int[] valeurBillets = new int[15];
        public static int[] valeurCentimes = new int[15];
        public static string Devise;
        public FrmBancomat()
        {
            InitializeComponent();
        }

        // Accept only number
        private void TxBEntiers_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (!char.IsControl(e.KeyChar) 
          && !char.IsDigit(e.KeyChar))
          {
            e.Handled = true;
          }
        }


        private void BtnEffacer_Click(object sender, EventArgs e)
        {
            //test
            CbXDevise.SelectedIndex = 0;
            TxBEntiers.Text = "";
            TxBCentimes.Text = "";
            TxBResultat.Text = "";

        }


        public string[] Retrait(int entier, int centimes)
        {
            string[] lignes;
            lignes = new string[15];
            int nbBillets = 0, i = 0;
            double memEntier = Convert.ToSingle(entier);
            double memCentimes = Convert.ToSingle(centimes);

            // traitement des entiers           
            foreach (int valeur in FrmBancomat.valeurBillets)
            {
                if (valeur != 0)
                {
                    nbBillets = Convert.ToInt32(Math.Floor(memEntier / valeur));
                }
                memEntier -= valeur * nbBillets;
                if (nbBillets != 0)
                {
                    lignes[i] = nbBillets.ToString() + " x " + valeur.ToString() + " " + FrmBancomat.Devise;
                    i++;
                }
                nbBillets = 0;

            }
            // traitement des centimes      
            foreach (int valeur in FrmBancomat.valeurCentimes)
            {
                if (valeur != 0)
                   nbBillets = Convert.ToInt32(Math.Floor(memCentimes / valeur));
                memCentimes -= valeur * nbBillets;
                if (nbBillets != 0)
                {
                    lignes[i] = nbBillets.ToString() + " x " + valeur.ToString() + " cts de " + FrmBancomat.Devise;
                    i++;
                }
                nbBillets = 0;

            }
            return (lignes);

        }

        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAPropos myForm = new FormAPropos();
            myForm.Show();
        }

        private void aideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAide myForm = new FormAide();
            myForm.Show();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
           
            if (TxBEntiers.Text == "")
            {
                TxBEntiers.Text = "0";
            }
            if (TxBCentimes.Text == "")
            {
                TxBCentimes.Text = "0";
            }
            
            TxBResultat.Lines = Retrait(Int32.Parse(TxBEntiers.Text), Int32.Parse(TxBCentimes.Text));
        }


        private void FrmBancomat_Activated(object sender, EventArgs e)
        {
            FrmBancomat.Devise = CbXDevise.SelectedItem.ToString();
            switch (CbXDevise.SelectedIndex)
            {
                case 0:
                    FrmBancomat.valeurBillets[0] = 1000;
                    FrmBancomat.valeurBillets[1] = 200;
                    FrmBancomat.valeurBillets[2] = 100;
                    FrmBancomat.valeurBillets[3] = 50;
                    FrmBancomat.valeurBillets[4] = 20;
                    FrmBancomat.valeurBillets[5] = 10;
                    FrmBancomat.valeurBillets[6] = 5;
                    FrmBancomat.valeurBillets[7] = 2;
                    FrmBancomat.valeurBillets[8] = 1;

                    FrmBancomat.valeurCentimes[0] = 50;
                    FrmBancomat.valeurCentimes[1] = 20;
                    FrmBancomat.valeurCentimes[2] = 10;
                    FrmBancomat.valeurCentimes[3] = 5;

                    FrmBancomat.Devise = "CHF";
                    break;

                case 1:
                    FrmBancomat.valeurBillets[0] = 500;
                    FrmBancomat.valeurBillets[1] = 200;
                    FrmBancomat.valeurBillets[2] = 100;
                    FrmBancomat.valeurBillets[3] = 50;
                    FrmBancomat.valeurBillets[4] = 20;
                    FrmBancomat.valeurBillets[5] = 10;
                    FrmBancomat.valeurBillets[6] = 5;
                    FrmBancomat.valeurBillets[7] = 2;
                    FrmBancomat.valeurBillets[8] = 1;

                    FrmBancomat.valeurCentimes[0] = 50;
                    FrmBancomat.valeurCentimes[1] = 20;
                    FrmBancomat.valeurCentimes[2] = 10;
                    FrmBancomat.valeurCentimes[3] = 5;
                    FrmBancomat.valeurCentimes[4] = 2;
                    FrmBancomat.valeurCentimes[5] = 1;

                    FrmBancomat.Devise = "€";
                    break;
                case 2:
                    FrmBancomat.valeurBillets[0] = 100;
                    FrmBancomat.valeurBillets[1] = 50;
                    FrmBancomat.valeurBillets[2] = 20;
                    FrmBancomat.valeurBillets[3] = 10;
                    FrmBancomat.valeurBillets[4] = 5;
                    FrmBancomat.valeurBillets[5] = 2;
                    FrmBancomat.valeurBillets[6] = 1;


                    FrmBancomat.valeurCentimes[0] = 50;
                    FrmBancomat.valeurCentimes[1] = 25;
                    FrmBancomat.valeurCentimes[2] = 10;
                    FrmBancomat.valeurCentimes[3] = 5;
                    FrmBancomat.valeurCentimes[4] = 1;

                    FrmBancomat.Devise = "$";
                    break;

            }
        }

        private void CbXDevise_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmBancomat.Devise = CbXDevise.SelectedItem.ToString();
            switch (CbXDevise.SelectedIndex)
            {
                case 0:
                    FrmBancomat.valeurBillets[0] = 1000;
                    FrmBancomat.valeurBillets[1] = 200;
                    FrmBancomat.valeurBillets[2] = 100;
                    FrmBancomat.valeurBillets[3] = 50;
                    FrmBancomat.valeurBillets[4] = 20;
                    FrmBancomat.valeurBillets[5] = 10;
                    FrmBancomat.valeurBillets[6] = 5;
                    FrmBancomat.valeurBillets[7] = 2;
                    FrmBancomat.valeurBillets[8] = 1;

                    FrmBancomat.valeurCentimes[0] = 50;
                    FrmBancomat.valeurCentimes[1] = 20;
                    FrmBancomat.valeurCentimes[2] = 10;
                    FrmBancomat.valeurCentimes[3] = 5;

                    FrmBancomat.Devise = "CHF";
                    break;

                case 1:
                    FrmBancomat.valeurBillets[0] = 500;
                    FrmBancomat.valeurBillets[1] = 200;
                    FrmBancomat.valeurBillets[2] = 100;
                    FrmBancomat.valeurBillets[3] = 50;
                    FrmBancomat.valeurBillets[4] = 20;
                    FrmBancomat.valeurBillets[5] = 10;
                    FrmBancomat.valeurBillets[6] = 5;
                    FrmBancomat.valeurBillets[7] = 2;
                    FrmBancomat.valeurBillets[8] = 1;

                    FrmBancomat.valeurCentimes[0] = 50;
                    FrmBancomat.valeurCentimes[1] = 20;
                    FrmBancomat.valeurCentimes[2] = 10;
                    FrmBancomat.valeurCentimes[3] = 5;
                    FrmBancomat.valeurCentimes[4] = 2;
                    FrmBancomat.valeurCentimes[5] = 1;

                    FrmBancomat.Devise = "€";
                    break;
                case 2:
                    FrmBancomat.valeurBillets[0] = 100;
                    FrmBancomat.valeurBillets[1] = 50;
                    FrmBancomat.valeurBillets[2] = 20;
                    FrmBancomat.valeurBillets[3] = 10;
                    FrmBancomat.valeurBillets[4] = 5;
                    FrmBancomat.valeurBillets[5] = 2;
                    FrmBancomat.valeurBillets[6] = 1;


                    FrmBancomat.valeurCentimes[0] = 50;
                    FrmBancomat.valeurCentimes[1] = 25;
                    FrmBancomat.valeurCentimes[2] = 10;
                    FrmBancomat.valeurCentimes[3] = 5;
                    FrmBancomat.valeurCentimes[4] = 1;

                    FrmBancomat.Devise = "$";
                    break;

            }
        }





 
    }   
}