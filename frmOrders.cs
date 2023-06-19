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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            frmdash2 frm = new frmdash2();
            frm.Show();
            Hide();
            this.Close();
        }

        SqlConnection cn = new SqlConnection("Data Source=ABDIRAHMAN\\MSSQLSERVER01;Initial Catalog=ALMADIINA;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //intan anaa gacanta ku qoran
        private void ClearData()
        {
            txtFoodName.Clear();
            txtFoodQuantity.Clear();
            txtCustomerLocation.Clear();
            txtCustomerLocation.Clear();
            txtCustomerPhone.Clear();
            ID = 0;
        }

        //intan anaa gacanta ku qoran

        private void frmOrders_Load(object sender, EventArgs e)
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from [dbo].[orders]", cn);
            da.Fill(dt);

            

            cn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtFoodName.Text != "" && txtFoodQuantity.Text != "" && txtCustomerLocation.Text != "" && txtCustomerPhone.Text != "")
            {
                cmd = new SqlCommand("insert into [dbo].[orders] VALUES(@foodname,@foodquantity,@location,@phone)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@foodname", txtFoodName.Text);
                cmd.Parameters.AddWithValue("@foodquantity", txtFoodQuantity.Text);
                cmd.Parameters.AddWithValue("@location", txtCustomerLocation.Text);
                cmd.Parameters.AddWithValue("@phone", txtCustomerPhone.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Waa La Gudbiyey Dalabkaaga");
                
                ClearData();
            }
            else
            {
                MessageBox.Show("Fadlan Gali Xogta...");
            }
        }
    }
}
