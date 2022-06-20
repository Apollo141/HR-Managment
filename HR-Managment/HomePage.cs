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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.Show(); 
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Salaries salaries = new Salaries();
            salaries.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.Show();
            this.Hide();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Login logn = new Login();
            logn.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ViewEmployees viewemp = new ViewEmployees();
            viewemp.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ViewEmployees viewemp = new ViewEmployees();
            viewemp.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Salaries salaries = new Salaries(); 
            salaries.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
