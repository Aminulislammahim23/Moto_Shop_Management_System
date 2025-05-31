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
    public partial class Home : Form
    {
        private DataAccess Da { get; set; }
        private Home Lf { get; set; }
        public Home()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }

        public Home(string name, Login lf) : this()
        {
            this.showUserLbl.Text += name;
            
        }

        private void serviceLb_Click(object sender, EventArgs e)
        {
            ServiceUC uc1 = new ServiceUC();
           

            this.defPnl.Controls.Clear();
            this.defPnl.Controls.Add(uc1);
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
