using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chain___Gear
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start(); // Start the timer when splash screen loads
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(20); // Increment progress by 20

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop(); // Stop the timer

                // Open main form
                Login login = new Login();
                login.Show();

                this.Hide(); // Hide splash form
            }
        }
    }
}