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
    public partial class Salaries : Form
    {
        public Salaries()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=ABOODY\SQLEXPRESS;Initial Catalog=EMPLOYEESDB;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void empfetcheddata()
        {
            if(empidtxt2.Text == "")
            {
                MessageBox.Show("قم بأدخال رقم الموظف ");
            }
            else
            {
                connection.Open();
                string query = "select * from EmployeesTbl where EmpoId='" + empidtxt2.Text + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    empnametxt2.Text = dr["EmpoName"].ToString();
                    emppostxt2.Text = dr["EmpoAdd"].ToString();
                    // empworkdaystxt.Text = dr["EmpoPos"].ToString();



                }

                connection.Close();
            }
     
        }
        private void Salaries_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            HomePage homeps = new HomePage();
            homeps.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            empfetcheddata();
        }
        int dailybase,total;

        private void SalariesSlip_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("وثيقة راتب الموظف", new Font("Tahoma", 35, FontStyle.Bold), Brushes.DeepSkyBlue, new Point(160, 50));
            e.Graphics.DrawString(empidtxt2.Text + " : رمز الموظف", new Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new Point(20, 200));
            e.Graphics.DrawString("اسم الموظف : " + empnametxt2.Text , new Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new Point(20, 350));
             e.Graphics.DrawString("منصب الموظف : " + emppostxt2.Text , new Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new Point(20, 500));
            e.Graphics.DrawString("عدد ايام عمل الموظف : " + empworkdaystxt.Text, new Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new Point(20, 650));
            e.Graphics.DrawString("الدفع اليومي للموظف : " + dailybase , new Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new Point(20, 800));
            e.Graphics.DrawString("الدفع الاجمالي للموظف : " + total, new Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new Point(20, 950));

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(emppostxt2.Text == "")
            {
                MessageBox.Show("قم بأختيار الموظف");
            }
            else if(empworkdaystxt.Text=="" || Convert.ToInt32(empworkdaystxt.Text) > 28)
            {
                MessageBox.Show("قم بأدخال رقم مقبول لاعداد ايام العمل");
            }
            else
            {
                if(emppostxt2.Text=="مدير قسم")
                {
                    dailybase = 60000;
                }
                else if (emppostxt2.Text == "مبرمج")
                {
                    dailybase = 55000;
                }
                else if (emppostxt2.Text == "محاسب")
                {
                    dailybase = 40000;
                }
                else
                {
                    dailybase = 30000;
                }
                total=dailybase*Convert.ToInt32(empworkdaystxt.Text);
                SalariesSlip.Text=empidtxt2.Text+ "\t" + " : رقم الموظف  " + "\n" + "\n"+"اسم الموظف"+" : "+empnametxt2.Text+"\n"+ "\n" + "عنوان الموظف "+ " : " + emppostxt2.Text+"\n"+ "\n" + " ايام عمل الموظف"+ " : " + empworkdaystxt.Text+"\n"+ "\n" +"الراتب اليومي "+ " : " + dailybase +"\n"+"\n" +"الراتب الأجمالي"+ " : " + total;
            
            }
        }
    }
}
