using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFADBG;

namespace Chain___Gear
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"D:\Git Projects\Moto_Shop_Management_System\Chain & Gear\Chain & Gear\image\1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where ID= '" + this.uidTxtbox.Text + "' and Password = '" + this.passTxtbox.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);


            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Welcome");
                var name = ds.Tables[0].Rows[0][1].ToString().ToUpper();   //anony type
                if (ds.Tables[0].Rows[0][3].ToString() == "admin")
                {
                    this.Hide();
                    new AdminDashboard(name, this).Show();
                }
                else if (ds.Tables[0].Rows[0][3].ToString() == "user")
                {
                    this.Hide();
                    new Home(name, this).Show();
                }

            }
            else
            {
                MessageBox.Show("Invalid User!!!");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }


        private void clearAll()
        {
            this.uidTxtbox.Clear();
            this.passTxtbox.Clear();
        }


        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }

        private void aboutLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
