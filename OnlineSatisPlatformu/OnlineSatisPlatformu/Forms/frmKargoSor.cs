﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineSatisPlatformu.Forms
{
    public partial class frmKargoSor : Form
    {
        public int kt;
        public string kad;

        public frmKargoSor()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmKargoSor_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            kad = cmbKad.Text;
            kt = cmbKtip.SelectedIndex;
            Close();
        }
    }
}
