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
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int starpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starpos += 1;
            pb1.Value = starpos;
            if(pb1.Value == 100)
            {
                pb1.Value = 0;
                timer1.Stop();
                frmLogin log = new frmLogin();
                log.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }
    }
}
