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
    public partial class ViewEmployees : Form
    {

        public ViewEmployees()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=ABOODY\SQLEXPRESS;Initial Catalog=EMPLOYEESDB;Integrated Security=True");
        public void hideandseek()
        {
            labelempid.Visible = true; 
            labelempname.Visible = true;
            labelempadd.Visible = true;
            labelemppos.Visible = true;
            labelempdob.Visible = true;
            labelempphone.Visible = true;
            labelempedu.Visible = true;
            labelempgend.Visible = true;
        }
private void empfetcheddata()
        {
            connection.Open();
            string query = "select * from EmployeesTbl where EmpoId='" + empsearchtxt.Text + "';";
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);   
            adapter.Fill(dt);   
            foreach (DataRow dr in dt.Rows)
            {
                labelempid.Text = dr["EmpoId"].ToString();
                labelempname.Text = dr["EmpoName"].ToString();
                labelempadd.Text = dr["EmpoAdd"].ToString();
                labelemppos.Text = dr["EmpoPos"].ToString();
                labelempdob.Text = dr["EmpoDob"].ToString();
                labelempphone.Text = dr["EmpoPhone"].ToString();
                labelempedu.Text = dr["EmpoEdu"].ToString();
                labelempgend.Text = dr["EmpoGend"].ToString();
                hideandseek();

            }

            connection.Close(); 
        }
        private void ViewEmployees_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            empfetcheddata();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            HomePage homep = new HomePage();
            homep.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empsearchtxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ملخص معلومات الموظف", new Font("Tahoma", 35, FontStyle.Bold), Brushes.DeepSkyBlue, new Point(160,50));
            e.Graphics.DrawString("اسم الموظف : "+ labelempname.Text + " \t\t" + labelempid.Text+" : رمز الموظف", new Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new Point(20, 250));
            e.Graphics.DrawString("عنوان الموظف : " + labelempadd.Text + "\t\t" + "جنس الموظف : "+ labelempgend.Text , new Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new Point(20, 400));
            e.Graphics.DrawString("منصب الموظف : " + labelemppos.Text + "\t  " + "مواليد الموظف : " + labelempdob.Text, new Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new Point(20, 600));
            e.Graphics.DrawString("رقم الموظف : " + labelempphone.Text + "\t" + "شهادة الموظف : " + labelempedu.Text, new Font("Tahoma", 18, FontStyle.Regular), Brushes.Black, new Point(20, 800));

        }
    }
}
