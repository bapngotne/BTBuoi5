﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private object img;

        public Form2(string img)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(img);
            Text = img.Substring(img.LastIndexOf('/') + 1);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
