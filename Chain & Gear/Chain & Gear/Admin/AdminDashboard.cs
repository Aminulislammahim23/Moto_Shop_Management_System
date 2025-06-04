using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chain___Gear.Admin;
using WFADBG;

namespace Chain___Gear
{
    public partial class AdminDashboard : Form
    {
        private DataAccess Da { get; set; }
        private Home Lf { get; set; }
        public AdminDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public AdminDashboard(string name, Login lf) : this()
        {
            this.showNameLbl.Text += name;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void productUpdateLbl_Click(object sender, EventArgs e)
        {
            ProductUpdate1 uc11 = new ProductUpdate1();


            this.defPnl.Controls.Clear();
            this.defPnl.Controls.Add(uc11);
        }

        private void bookingLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void ManageCustLbl_Click(object sender, EventArgs e)
        {

        }

        private void manageEmpLbl_Click(object sender, EventArgs e)
        {
           ManageEMP uc12 = new ManageEMP();


            this.defPnl.Controls.Clear();
            this.defPnl.Controls.Add(uc12);
        }

        private void adminPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin().Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
