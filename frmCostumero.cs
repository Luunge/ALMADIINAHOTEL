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
    public partial class frmCustomero : Form
    {
        public frmCustomero()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=ABDIRAHMAN\\MSSQLSERVER01;Initial Catalog=HAGE_DIGITAL;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;

        //intan anaa gacanta ku qoran

        private void DisplayData()
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from [dbo].[COSTUMER]", cn);
            da.Fill(dt);
            dvgCustomers.DataSource = dt;
            cn.Close();
        }

        private void ClearData()
        {
            txtCostID.Clear();
            txtCostName.Clear();
            txtCostService.Clear();
            textPrice.Clear();

            ID = 0;
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from [dbo].[COSTUMER]", cn);
            da.Fill(dt);

            txtCostID.Text = dt.Rows[0][0].ToString();
            txtCostName.Text = dt.Rows[0][1].ToString();
            txtCostService.Text = dt.Rows[0][2].ToString();
            textPrice.Text = dt.Rows[0][3].ToString();

            dvgCustomers.DataSource = dt;


            cn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            frmdash frm = new frmdash();
            frm.Show();
            this.Hide();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCostID.Text != "" && txtCostName.Text != "" && txtCostService.Text != "" && textPrice.Text != "")
            {
                cmd = new SqlCommand("insert into [dbo].[COSTUMER] VALUES(@COS_ID,@COST_NAME,@COST_SERVICE,@PRICE)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@COS_ID", txtCostID.Text);
                cmd.Parameters.AddWithValue("@COST_NAME", txtCostName.Text);
                cmd.Parameters.AddWithValue("@COST_SERVICE", txtCostService.Text);
                cmd.Parameters.AddWithValue("@PRICE", textPrice.Text);
                
                cn.Close();
                MessageBox.Show("Waa La Save-gareeyey Xogta");

                ClearData();
            }
            else
            {
                MessageBox.Show("Fadlan Gali Xogta...");
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
