using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Managment
{
    public partial class Progressing : Form
    {
        public Progressing()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
        int clockstart = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            clockstart += 1;
            thecircporgrs.Value=clockstart;
            if (thecircporgrs.Value == 100)
            {
                thecircporgrs.Value = 0;    
                timer1.Stop();
                this.Hide();
                Login logn = new Login();
                logn.Show();
                
            }
        }

        private void Progressing_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
