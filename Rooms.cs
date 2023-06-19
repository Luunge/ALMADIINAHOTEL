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
    public partial class frmRooms : Form
    {
        public frmRooms()
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

        private void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRooms_Load(object sender, EventArgs e)
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from [dbo].[rooms]", cn);
            da.Fill(dt);

            txtRoomID.Text = dt.Rows[0][0].ToString();
            txtRoomType.Text = dt.Rows[0][1].ToString();
            txtRoomService.Text = dt.Rows[0][2].ToString();
            dgvRooms.DataSource = dt;
            cn.Close();
        }

        //intan anaa gacanta ku qoray
        private void DisplayData()
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from [dbo].[rooms]", cn);
            da.Fill(dt);
            dgvRooms.DataSource = dt;
            cn.Close();
        }

        private void ClearData()
        {
            txtRoomID.Clear();
            txtRoomType.Clear();
            txtRoomService.Clear();

            ID = 0;
        }

        //intan anaa gacanta ku qoran

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtRoomID.Text != "" && txtRoomType.Text != "" && txtRoomService.Text != "")
            {
                cmd = new SqlCommand("insert into [dbo].[rooms] VALUES(@id,@roomtype,@roomservice)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@id", txtRoomID.Text);
                cmd.Parameters.AddWithValue("@roomtype", txtRoomType.Text);
                cmd.Parameters.AddWithValue("@roomservice", txtRoomService.Text);
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

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtRoomID.Text != "" && txtRoomType.Text != "" && txtRoomService.Text != "")
            {
                cmd = new SqlCommand("update [dbo].[rooms] set ROOMTYPE=@roomtype, ROOMSERVICE=@roomservice where ID=@id", cn);
                cn.Open();
                ID = Convert.ToInt32(txtRoomID.Text);
                cmd.Parameters.AddWithValue("@id", txtRoomID.Text);
                cmd.Parameters.AddWithValue("@roomtype", txtRoomType.Text);
                cmd.Parameters.AddWithValue("@roomservice", txtRoomService.Text);
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
    }
}
