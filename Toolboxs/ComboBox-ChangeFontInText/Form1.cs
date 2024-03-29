﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_ChangeFontInText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] fontlar = FontFamily.Families;

            for (int i = 0; i <= fontlar.GetUpperBound(0); i++)
                comboBox1.Items.Add(fontlar[i].Name);
            comboBox1.SelectedIndex = 0;
                                     
            for (int i = 8; i <= 100; i++)
                comboBox2.Items.Add(i);
            comboBox2.SelectedIndex = 0;

            comboBox2.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            comboBox2.TextChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(comboBox1.Text.ToString(), float.Parse(comboBox2.Text), FontStyle.Regular);
        }
    }
}
