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
    public partial class frmFoods : Form
    {
        public frmFoods()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=ABDIRAHMAN\\MSSQLSERVER01;Initial Catalog=ALMADIINA;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;

        private void frmFoods_Load(object sender, EventArgs e)
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from [dbo].[foods]", cn);
            da.Fill(dt);

            txtID.Text = dt.Rows[0][0].ToString();
            txtFoodName.Text = dt.Rows[0][1].ToString();
            txtFoodPrice.Text = dt.Rows[0][2].ToString();

            dgvFoods.DataSource = dt;
            cn.Close();
        }


        //intan anaa gacanta ku qoray
        private void DisplayData()
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from [dbo].[foods]", cn);
            da.Fill(dt);
            dgvFoods.DataSource = dt;
            cn.Close();
        }

        private void ClearData()
        {
            txtID.Clear();
            txtFoodName.Clear();
            txtFoodPrice.Clear();

            ID = 0;
        }

        //intan anaa gacanta ku qoran
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmdash frm = new frmdash();
            frm.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "" && txtFoodName.Text != "" && txtFoodPrice.Text != "")
            {
                cmd = new SqlCommand("insert into [dbo].[foods] VALUES(@id,@foodname,@foodprice)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@foodname", txtFoodName.Text);
                cmd.Parameters.AddWithValue("@foodprice", txtFoodPrice.Text);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                cmd = new SqlCommand("delete [dbo].[foods] where ID=@id", cn);
                cn.Open();
                ID = Convert.ToInt32(txtID.Text);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtID.Text != "" && txtFoodName.Text != "" && txtFoodPrice.Text != "")
            {
                cmd = new SqlCommand("update [dbo].[foods] set FOODNAME=@foodname, FOODPRICE=@foodprice where ID=@id", cn);
                cn.Open();
                ID= Convert.ToInt32(txtID.Text);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@foodname", txtFoodName.Text);
                cmd.Parameters.AddWithValue("@foodprice", txtFoodPrice.Text);
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

        private void dgvFoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFoodPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
