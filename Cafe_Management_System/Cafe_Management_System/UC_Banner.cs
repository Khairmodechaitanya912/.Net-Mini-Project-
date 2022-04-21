﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class UC_Banner : UserControl
    {
        public UC_Banner()
        {
            InitializeComponent();
        }
        int T = 0;
        private void t_Title_Tick(object sender, EventArgs e)
        {
            if (T == 0)
            {
                lbl_Title.Location = new Point(3, 506);
                lbl_Title.ForeColor = Color.AntiqueWhite;
                T++;
            }
            else if (T == 1)
            {
                lbl_Title.Location = new Point(242, 515);
                lbl_Title.ForeColor = Color.MistyRose;
                T++;
            }
            else if (T == 2)
            {
                lbl_Title.Location = new Point(510, 524);
                lbl_Title.ForeColor = Color.DeepSkyBlue;
                T = 0;
            }
        }

        private void UC_Banner_Load(object sender, EventArgs e)
        {
            t_Title.Start(); 
        }
    }
}
