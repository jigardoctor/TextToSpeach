using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Entity.Infrastructure;

namespace Shubhamcreation
{
    public partial class ratelist : MetroFramework.Forms.MetroForm
    {
        public ratelist()
        {
            InitializeComponent();
        }
        void ViewData()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        var da = new SqlDataAdapter(
                            "Select * from [ratelist]", db.ToString());
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        metroGrid1.DataSource = ds.Tables[0];
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        void cleardata()
            {
                design_tx.Clear();
                rate_tx.Clear();
                stiches_tx.Clear();
                color_tx.Clear();
            }

        
       

    }
}
