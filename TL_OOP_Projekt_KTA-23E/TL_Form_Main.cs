﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TL_OOP_Projekt_KTA_23E
{
    public partial class TL_Form_Main : Form
    {
        public TL_Form_Main()
        {
            InitializeComponent();
        }

        private void TL_btn1_Click(object sender, EventArgs e)
        {
            Form F1 = new TL_Form_2024_01_25();
            F1.Visible = true;
            F1.Activate();
            TL_btn1.Enabled = false;
        }
    }
}
