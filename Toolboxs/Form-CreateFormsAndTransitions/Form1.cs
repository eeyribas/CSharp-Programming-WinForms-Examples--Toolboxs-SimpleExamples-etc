﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_CreateFormsAndTransitions
{
    public partial class Form1 : Form
    {
        public static int x;
        Form2 frm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Form2();
                frm.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            x++;
            Form3 form = new Form3();
            form.Show();
        }
    }
}