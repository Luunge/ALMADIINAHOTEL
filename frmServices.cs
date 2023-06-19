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
    public partial class frmServices : Form
    {
        public frmServices()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=ABDIRAHMAN\\MSSQLSERVER01;Initial Catalog=ALMADIINA;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;


        private void frmServices_Load(object sender, EventArgs e)
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from [dbo].[servicess]", cn);
            da.Fill(dt);

            txtSerID.Text = dt.Rows[0][0].ToString();
            txtSerType.Text = dt.Rows[0][1].ToString();

            dgvServices.DataSource = dt;
            cn.Close();

        }

        //intan anaa gacanta ku qoray
        private void DisplayData()
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from [dbo].[servicess]", cn);
            da.Fill(dt);
            dgvServices.DataSource = dt;
            cn.Close();
        }

        private void ClearData()
        {
            txtSerID.Clear();
            txtSerType.Clear();
          
            ID = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtSerID.Text != "" && txtSerType.Text != "")
            {
                cmd = new SqlCommand("update [dbo].[servicess] set SERVICETYPE=@servicetype where ID=@id", cn);
                cn.Open();
                ID = Convert.ToInt32(txtSerID.Text);
                cmd.Parameters.AddWithValue("@id", txtSerID.Text);
                cmd.Parameters.AddWithValue("@servicetype", txtSerType.Text);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmdash frm = new frmdash();
            frm.Show();
            Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSerID.Text != "")
            {
                cmd = new SqlCommand("delete [dbo].[servicess] where ID=@id", cn);
                cn.Open();
                ID = Convert.ToInt32(txtSerID.Text);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSerID.Text != "" && txtSerType.Text != "")
            {
                cmd = new SqlCommand("insert into [dbo].[servicess] VALUES(@id,@servicetype)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@id", txtSerID.Text);
                cmd.Parameters.AddWithValue("@servicetype", txtSerType.Text);
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

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
