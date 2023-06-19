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
using System.Threading;


namespace Al_Madiina_Hotel
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=ABDIRAHMAN\\MSSQLSERVER01;Initial Catalog=HAGE_DIGITAL;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from [dbo].[USERS]", cn);
            da.Fill(dt);

            cn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //frmAdminDashboard FormDashboard = new frmAdminDashboard();
            //FormDashboard.Show();
            //this.Hide();

            frmdash frmHome = new frmdash();
            cn.Open();
            cmd = new SqlCommand("select count(*) [dbo].[USERS] where USERNAME '" + txtuser.Text + "' and '" + txtuser.Text + "' and PASSWORD = '" + txtpassword.Text + "' and ROLE = '" + comboBox1.Text + "' ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                frmHome.Show();
                this.Hide();
                cn.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }
            cn.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void chShowPassword_CheckedChanged(object sender, EventArgs e)
        { 
            if(chShowPassword.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtuser.Text))
            {
                e.Cancel = true;
                txtuser.Focus();
                errorProvider1.SetError(txtuser, "Please enter your username !");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(txtuser, null);
            }
        }

        private void txtpass_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
