﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_OpenForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}