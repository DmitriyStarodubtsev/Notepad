﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblProductName.Text = string.Format("Product name: {0}", Application.ProductName);
            lblProductVersion.Text = string.Format("Version: {0}", Application.ProductVersion);
            lblCopyright.Text = "Copyright ©  2023 by Pet-Project";
        }
    }
}
