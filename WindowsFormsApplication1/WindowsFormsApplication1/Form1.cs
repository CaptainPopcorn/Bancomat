﻿using System;
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
        public FrmBancomat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEffacer_Click(object sender, EventArgs e)
        {
            CbXDevise.SelectedIndex = 0;
            TxBEntiers.Text = "";
            TxBCentimes.Text = "";
            TxBResultat.Text = "";

        }

        private void CbXDevise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
