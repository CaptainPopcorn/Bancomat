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
        string devise;
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


        public string[] Retrait(int entier, int centimes, int[] valeurBillets, int[] valeurCentimes, string devise)
        {
            string[] lignes;
            lignes = new string[15];
            int nbBillets = 0, i = 0;
            double memEntier = Convert.ToSingle(entier);
            double memCentimes = Convert.ToSingle(centimes);

            // traitement des entiers           
            foreach (int valeur in valeurBillets)
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
            foreach (int valeur in valeurCentimes)
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
            
            TxBResultat.Lines = Retrait(Int32.Parse(TxBEntiers.Text), Int32.Parse(TxBCentimes.Text), valeurBillets, valeurCentimes, "chf");
        }

        private void CbXDevise_TextChanged(object sender, EventArgs e)
        {
            switch (CbXDevise.SelectedIndex) {
                case 0:
                    int[] valeurBillets = { 1000, 200, 100, 50, 20, 10, 5, 2, 1 };
                    int[] valeurCentimes = { 50, 20, 10, 5 };                  
                   break;

               case   1:;
                   break;
                   
               case    2:;
                   break;
        }
            TxBResultat.Lines = Retrait(Int32.Parse(TxBEntiers.Text), Int32.Parse(TxBCentimes.Text), valeurBillets, valeurCentimes, devise);
        }

        private void FrmBancomat_Activated(object sender, EventArgs e)
        {
            devise = CbXDevise.SelectedItem.ToString();
        }

        private void CbXDevise_TabIndexChanged(object sender, EventArgs e)
        {
            devise = CbXDevise.SelectedItem.ToString();
            
        }

       
    }
   
   
}

