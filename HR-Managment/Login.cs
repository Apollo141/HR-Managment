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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usertxt.Text=="" || passtxt.Text == "" )
            {
                MessageBox.Show("قم بادخال الرقم السري او اسم المستخدم");
            }
     // من الممكن مقارنة المعلومات مع قاعدة بيانات خاصة بالادمن ولكن هذا النموذج يعتمد فقط على ادمن واحد فلا حاجة لقاعدة بيانات
            else if(usertxt.Text == "علي محسن" && passtxt.Text == "1997" )
            {
                this.Hide();
                HomePage homePage = new HomePage(); 
                homePage.Show();
              
            }
            else
            {
                MessageBox.Show("اسم المستخدم او الرمز السري خطأ اعد المحاولة");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usertxt.Text = "";
            passtxt.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void passtxt_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
