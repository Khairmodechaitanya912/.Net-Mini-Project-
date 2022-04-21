using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.All_User_Controls
{
    public partial class Remove_Item : UserControl
    {
        public Remove_Item()
        {
            InitializeComponent();
        }

        private void Remove_Item_Load(object sender, EventArgs e)
        {
            lbl_Delete_Lbl.Text = "How To Delete??";
            lbl_Delete_Lbl.ForeColor = Color.Blue;
        }
    }
}
