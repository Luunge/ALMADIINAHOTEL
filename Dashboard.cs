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

namespace Al_Madiina_Hotel
{
    public partial class frmdash : Form
    {
        public frmdash() 
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BRTJJ4B;Initial Catalog=ABDIRAHMAN;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;   

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
   
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCustomero frm = new frmCustomero();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.Close();
            frmRooms frm = new frmRooms();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEmployee frm = new frmEmployee();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            this.Close();
            frmServices frm = new frmServices();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBookingList frm = new frmBookingList();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrderList frm = new frmOrderList();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
            this.Close();
        }
    }
}
