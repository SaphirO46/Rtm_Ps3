﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rtm_Ps3
{
    public partial class Form2 : Form
    {
        
        public Form2(string texteRecu)
        {
            InitializeComponent();
            string texteAffiche = texteRecu;
            richTextBox1.Text = texteAffiche;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
