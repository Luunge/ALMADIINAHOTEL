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
    public partial class frmOrderList : Form
    {
        public frmOrderList()
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

        private void frmOrderList_Load(object sender, EventArgs e)
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from [dbo].[orders]", cn);
            da.Fill(dt);

            dtvOrderList.DataSource = dt;
            cn.Close();
        }
    }
}
