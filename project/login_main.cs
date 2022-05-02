using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flats
{
    public partial class login_main : Form
    {
        public login_main()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer_login cl = new customer_login();
            cl.Show();
        }
    }
}
