using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shubhamcreation
{
    public partial class dashboardfrm : MetroFramework.Forms.MetroForm
    {
        public dashboardfrm()
        {
            InitializeComponent();
        }

        private void dashboardfrm_Load(object sender, EventArgs e)
        {

        }

        private void ttosp_bt_Click(object sender, EventArgs e)
        {
            using (ttosp frm = new ttosp())
            {
                frm.ShowDialog();
            }
        }

        private void ratelist_bt_Click(object sender, EventArgs e)
        {
            using (ratelist frm = new ratelist())
            {
                frm.ShowDialog();
            }
        }
    }
}
