using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Madiina_Hotel
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=ABDIRAHMAN\\MSSQLSERVER01;Initial Catalog=ALMADIINA;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;

        

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmdash frm = new frmdash();
            frm.Show();
            Hide();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {

            }

            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from [dbo].[employee]", cn);
            da.Fill(dt);

            txtEmID.Text = dt.Rows[0][0].ToString();
            txtEmType.Text = dt.Rows[0][1].ToString();
            txtEmName.Text = dt.Rows[0][2].ToString();
            dgvEmployee.DataSource = dt;
            cn.Close();
        }

        //intan anaa gacanta ku qoray 
        private void DisplayData()
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from [dbo].[employee]", cn);
            da.Fill(dt);
            dgvEmployee.DataSource = dt;
            cn.Close();
        }

        private void ClearData()
        {
            txtEmID.Clear();
            txtEmType.Clear();
            txtEmName.Clear();

            ID = 0;
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditEm_Click(object sender, EventArgs e)
        {
            if (txtEmID.Text != "" && txtEmType.Text != "" && txtEmName.Text != "")
            {
                cmd = new SqlCommand("update [dbo].[employee] set FOODNAME=@foodname, FOODPRICE=@foodprice where ID=@id", cn);
                cn.Open();
                ID = Convert.ToInt32(txtEmID.Text);
                cmd.Parameters.AddWithValue("@id", txtEmID.Text);
                cmd.Parameters.AddWithValue("@foodname", txtEmType.Text);
                cmd.Parameters.AddWithValue("@foodprice", txtEmName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Waa La Badalay....");
                cn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Fadlan Dooro Row-ga aad Badaleyso...");
            }
        }

        private void btnDeleteEm_Click(object sender, EventArgs e)
        {
            if (txtEmID.Text != "")
            {
                cmd = new SqlCommand("delete [dbo].[employee] where ID=@id", cn);
                cn.Open();
                ID = Convert.ToInt32(txtEmID.Text);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Waad Delete-garaysay");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Fadlan Dooro Row-ga aad Delete-gareynayso");
            }
        }

        private void btnSaveEm_Click(object sender, EventArgs e)
        {
            if (txtEmID.Text != "" && txtEmType.Text != "" && txtEmName.Text != "")
            {
                cmd = new SqlCommand("insert into [dbo].[employee] VALUES(@id,@employeetype,@employeename)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@id", txtEmID.Text);
                cmd.Parameters.AddWithValue("@employeetype", txtEmType.Text);
                cmd.Parameters.AddWithValue("@employeename", txtEmName.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Waa La Save-gareeyay");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Fadlan Gali Xogta...");
            }
        }
    }
}
