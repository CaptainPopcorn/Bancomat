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
        public static int[] valeurs = new int[20];
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

        public string[] AfficheLicorne(int i, string[] lignes)
        {
            lignes[i] = "            /      ";
            lignes[i + 1] = "          ;=',_   ";
            lignes[i + 2] = "         S\" .--` ";
            lignes[i + 3] = "        sS  \\__   ";
            lignes[i + 4] = "     __.' ( \\-->  ";
            lignes[i + 5] = "  _=/    _./-\\/   ";
            lignes[i + 6] = " ((\\( /-'   -'l   ";
            lignes[i + 7] = "  ) |/ \\         ";
            lignes[i + 8] = "    \\  \\         ";
            lignes[i + 9] = "      `~ `~       ";
            return (lignes);
        }
        public string[] Retrait(int entier, int centimes)
        {
            string[] lignes;
            lignes = new string[50];
            int nbBillets = 0, i = 0;
            double memValeur = entier;
            int lastValeur = 0;
            bool estEntier = true;

            // traitement des entiers           
            foreach (int valeur in FrmBancomat.valeurs)
            {
                if ((valeur > lastValeur) && (lastValeur != 0))
                {
                    estEntier = false;
                    memValeur = centimes;
                }
                if (valeur != 0)
                {
                    nbBillets = Convert.ToInt32(Math.Floor(memValeur / valeur));
                }
                memValeur -= valeur * nbBillets;
                if (nbBillets != 0)
                {
                    lignes[i] = nbBillets.ToString() + " x " + valeur.ToString();
                    if (!estEntier)
                    {
                        lignes[i] += " cts de ";
                    }
                    lignes[i] += FrmBancomat.Devise;
                    i++;
                }
                nbBillets = 0;
                lastValeur = valeur;

            }

            lignes = AfficheLicorne(i, lignes);
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
                    FrmBancomat.valeurs[0] = 1000;
                    FrmBancomat.valeurs[1] = 200;
                    FrmBancomat.valeurs[2] = 100;
                    FrmBancomat.valeurs[3] = 50;
                    FrmBancomat.valeurs[4] = 20;
                    FrmBancomat.valeurs[5] = 10;
                    FrmBancomat.valeurs[6] = 5;
                    FrmBancomat.valeurs[7] = 2;
                    FrmBancomat.valeurs[8] = 1;

                    FrmBancomat.valeurs[9] = 50;
                    FrmBancomat.valeurs[10] = 20;
                    FrmBancomat.valeurs[11] = 10;
                    FrmBancomat.valeurs[12] = 5;
                    FrmBancomat.valeurs[13] = 0;
                    FrmBancomat.valeurs[14] = 0;

                    FrmBancomat.Devise = "CHF";
                    break;

                case 1:
                    FrmBancomat.valeurs[0] = 500;
                    FrmBancomat.valeurs[1] = 200;
                    FrmBancomat.valeurs[2] = 100;
                    FrmBancomat.valeurs[3] = 50;
                    FrmBancomat.valeurs[4] = 20;
                    FrmBancomat.valeurs[5] = 10;
                    FrmBancomat.valeurs[6] = 5;
                    FrmBancomat.valeurs[7] = 2;
                    FrmBancomat.valeurs[8] = 1;

                    FrmBancomat.valeurs[9] = 50;
                    FrmBancomat.valeurs[10] = 20;
                    FrmBancomat.valeurs[11] = 10;
                    FrmBancomat.valeurs[12] = 5;
                    FrmBancomat.valeurs[13] = 2;
                    FrmBancomat.valeurs[14] = 1;

                    FrmBancomat.Devise = "€";
                    break;
                case 2:
                    FrmBancomat.valeurs[0] = 100;
                    FrmBancomat.valeurs[1] = 50;
                    FrmBancomat.valeurs[2] = 20;
                    FrmBancomat.valeurs[3] = 10;
                    FrmBancomat.valeurs[4] = 5;
                    FrmBancomat.valeurs[5] = 2;
                    FrmBancomat.valeurs[6] = 1;


                    FrmBancomat.valeurs[7] = 50;
                    FrmBancomat.valeurs[8] = 25;
                    FrmBancomat.valeurs[9] = 10;
                    FrmBancomat.valeurs[10] = 5;
                    FrmBancomat.valeurs[11] = 1;
                    FrmBancomat.valeurs[12] = 0;
                    FrmBancomat.valeurs[13] = 0;
                    FrmBancomat.valeurs[14] = 0;

                    FrmBancomat.Devise = "$";
                    break;

            }
        }

        private void CbXDevise_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



 
    }   
}