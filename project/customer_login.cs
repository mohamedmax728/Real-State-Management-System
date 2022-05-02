using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Flats
{
    public partial class customer_login : Form
    {
        public customer_login()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            regster re = new regster();
            re.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string us = enter_use.Text;
            string pass = enter_pass.Text;
            string U, P;
            bool Z = false;
            XmlDocument doc = new XmlDocument();
            doc.Load("log_in.xml");
            XmlNodeList list = doc.GetElementsByTagName("customer");
            XmlWriter wr = XmlWriter.Create("log.xml");

            for (int i = 0; i < list.Count; i++)
            {

                XmlNodeList child = list[i].ChildNodes;
                U = child[4].InnerText;
                P = child[5].InnerText;
                if (us == U&&pass==P)
                {
                    Z = true;
                    
                    wr.WriteStartDocument();

                    wr.WriteStartElement("user");




                    wr.WriteStartElement("username");
                    wr.WriteString(us);
                    wr.WriteEndElement();

                    wr.WriteStartElement("password");
                    wr.WriteString(pass);
                    wr.WriteEndElement();
                    wr.WriteEndElement();
                    
                    wr.WriteEndDocument();


                    wr.Close();


                    customer_work cu = new customer_work();
                    cu.Show();
                    this.Hide();
                    break;
                }

            }
            if(Z==false)
            {
                MessageBox.Show("username or password is incorrect!!");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            login_main a = new login_main();
            a.Show();
            this.Hide();
        }
    }
}
