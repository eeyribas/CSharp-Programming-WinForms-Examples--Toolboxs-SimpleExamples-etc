﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertRadix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Nud_ValueChanged(sender, e);
        }

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            int x = (int)Nud1.Value;
            int n = (int)Nud2.Value;
            Lbl1.Text = ConvRadix(x, n);
        }

        string ConvRadix(int x, int n)
        {
            if (x < 0 || x > 1e9)
                return "Number Out of Range";
            if (n < 2 || n > 16)
                return "Radix Out of Range";

            int cont;
            string str = null;
            while (true)
            {
                cont = x % n;
                if (cont < 10) 
                    str = (char)(48 + cont) + str;
                else 
                    str = (char)(55 + cont) + str;
                x = x / n;
                if (x == 0) 
                    break;
            }
            return str;
        }
    }
}