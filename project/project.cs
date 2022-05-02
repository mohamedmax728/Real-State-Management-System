using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Flats
{
    class Flats
    {

        [XmlElement]
        public String f_id { set; get; }
        [XmlElement]
        public String c_id { set; get; }
        [XmlElement]
        public String e_id { set; get; }
        [XmlElement]
        public String flatdesc { set; get; }
        [XmlElement]
        public int price { set; get; }
        [XmlElement]
        public String flatlocation { set; get; }
        [XmlElement]
        public String flatstatus { get; set; }
        [XmlElement]
        public String c_review { set; get; }

        public Flats()
        {
            
        }
    }
    class Admin {
        [XmlElement]
        public String name { set; get; }
        [XmlElement]
        public String id { set; get; }
        Admin(string i,string n) {
            this.id = i;
            this.name = n;

        }

    }
    class Customers
    {
        [XmlElement]
        public String c_id { set; get; }
        [XmlElement]
        public String c_name { set; get; }
        [XmlElement]
        public String address { set; get; }
        [XmlElement]
        public String phoneno { set; get; }




        Customers(string customer_id, string customer_name, string Address ,string phone_num)
        {
            this.c_id = customer_id;
            this.c_name = customer_name;
            this.address = Address;
            this.phoneno = phone_num;

        }

        public Customers()
        {
        }
    }
    class Employee
     {
        [XmlElement]
        public String e_id { set; get; }
        [XmlElement]
        public int no_ass { set; get; }
        [XmlElement]
        public int rate { set; get; }
        Employee(string Emp_id,int No_ass_flat,int Rate)
        {
            this.e_id = Emp_id;
            this.no_ass = No_ass_flat;
            this.rate = Rate;
        }

    }
}
