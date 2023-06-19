using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Madiina_Hotel
{
    public partial class frmBookingList : Form
    {
        public frmBookingList()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=ABDIRAHMAN\\MSSQLSERVER01;Initial Catalog=ALMADIINA;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmdash frm = new frmdash();
            frm.Show();
            Hide();
        }

        private void frmBookingList_Load(object sender, EventArgs e)
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from [dbo].[booking]", cn);
            da.Fill(dt);

            dtvBooking.DataSource = dt;
            cn.Close();
        }
    }
}
