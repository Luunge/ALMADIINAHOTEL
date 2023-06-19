using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Madiina_Hotel
{
    public partial class frmdash2 : Form
    {
        public frmdash2()
        {
            InitializeComponent();
        }

        private void frmdash2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCustomero frm = new frmCustomero();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOrders frm = new frmOrders();
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
    }
}
