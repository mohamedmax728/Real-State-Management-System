using System;

public class Class1
{
    [XmlRoot("admin")]
	public class admin
	{
        [XmlElement]
        public String name { set; get; }
        [XmlElement]
        public String id { set; get; }

    }
    [XmlRoot("customer")]
    public class Customers
    {
        [XmlElement]
        public String c_id { set; get; }
        [XmlElement]
        public String c_name { set; get; }
        [XmlElement]
        public String address { set; get; }
        [XmlElement]
        public String phoneno { set; get; }

    }
    [XmlRoot("employee")]
    public class employee
    {
        [XmlElement]
        public String e_id { set; get; }
        [XmlElement]
        public int no_ass { set; get; }
        [XmlElement]
        public int rate { set; get; }

    }
    [XmlRoot("flat")]
    public class Flats
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
        public  String flatstatus { get; set; }
        [XmlElement]
        public String c_review { set; get; }
    }
}
