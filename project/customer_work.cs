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
    public partial class customer_work : Form
    {
        public customer_work()
        {
            InitializeComponent();
        }

        private void customer_work_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add f = new add();
            f.Show();
        }
    }
}
