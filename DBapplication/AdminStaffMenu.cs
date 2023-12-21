﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AdminStaffMenu : UserControl
    {
        public AdminStaffMenu()
        {
            InitializeComponent();
            panelStaffdel.Hide();
            panelManager.Hide();
            panelAdAdmin.Hide();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            panelManager.Hide();
            panelAdAdmin.Hide();
            panelStaffdel.Show();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            panelStaffdel.Hide();
            panelAdAdmin.Hide();
            panelManager.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            panelStaffdel.Hide();
            panelManager.Hide();
            panelAdAdmin.Show();
        }

    }
}