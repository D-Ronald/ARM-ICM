﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braço
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    label1.Left += -10;
                    break;

                case Keys.W:
                    label1.Top += -10;
                    break;

                case Keys.S:
                    label1.Top +=10;
                    break;

                case Keys.D:
                    label1.Left += 10;
                    break;

            }
        }

    }
}
