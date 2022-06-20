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
namespace HR_Managment
{
    public partial class employee : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ABOODY\SQLEXPRESS;Initial Catalog=EMPLOYEESDB;Integrated Security=True");

        public employee()
        {
            InitializeComponent();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (empidtxt.Text == "" || empnametxt.Text == "" || empphonetxt.Text == "" || empaddtxt.Text == "")
            {
                MessageBox.Show("لم يتم ادخال بعض المعلومات");
            }
            else
            {
                try {
                connection.Open();
                    string query ="insert into EmployeesTbl values('" + empidtxt.Text + "','" + empnametxt.Text + "','" + empaddtxt.Text + "','" + comboemppos.SelectedItem.ToString() + "','" + bodemp.Value.Date + "','" + empphonetxt.Text + "','" + combempedu.SelectedItem.ToString() + "','" + comboempgend.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query,connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تمت اضافة معلومات الموظف بنجاح");
                    
                    connection.Close();
                    populate();
                
                } 
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void populate()
        {
            connection.Open();
            string query = "select * from EmployeesTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dst = new DataSet();
            adapter.Fill(dst);
            emplyeegridview.DataSource = dst.Tables[0];   
            connection.Close();
        }
        private void employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            if (empidtxt.Text == "")
            {
                MessageBox.Show("قم بأدخال رمز الموظف");
            }
            else
            {
                try{
                connection.Open();

                    string query = "delete from EmployeesTbl where EmpoId='"+empidtxt.Text+ "';";
                    SqlCommand cmd = new SqlCommand(query,connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم حذف معلومات الموظف بنجاح");
                    connection.Close();
                    populate();

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void emplyeegridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            empidtxt.Text = emplyeegridview.SelectedRows[0].Cells[0].Value.ToString();
            empnametxt.Text= emplyeegridview.SelectedRows[0].Cells[1].Value.ToString();
            empaddtxt.Text = emplyeegridview.SelectedRows[0].Cells[2].Value.ToString();
            comboempgend.SelectedItem=emplyeegridview.SelectedRows[0].Cells[7].Value.ToString();    
            comboemppos.SelectedItem = emplyeegridview.SelectedRows[0].Cells[3].Value.ToString();
            empphonetxt.Text=  emplyeegridview.SelectedRows[0].Cells[5].Value.ToString();
            combempedu.SelectedItem = emplyeegridview.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (empidtxt.Text == "" || empnametxt.Text == "" || empphonetxt.Text == "" || empaddtxt.Text == "")
            {
                MessageBox.Show("لم يتم ادخال بعض المعلومات");
            }
            else
            {
                try
                {
                    connection.Open();

                    string query = "update EmployeesTbl set EmpoName='"+empnametxt.Text+"',EmpoAdd='"+empaddtxt.Text+"',EmpoPos='"+comboemppos.SelectedItem.ToString()+"',EmpoDob='"+bodemp.Value.Date+"',EmpoPhone='"+empphonetxt.Text+"',EmpoEdu='"+combempedu.SelectedItem.ToString()+"',EmpoGend='"+comboempgend.SelectedItem.ToString()+"'where EmpoId='"+empidtxt.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم تعديل معلومات الموظف بنجاح");
                    connection.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            HomePage homep = new HomePage();
            homep .Show();
            this.Hide();
        }

        private void bodemp_onValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
