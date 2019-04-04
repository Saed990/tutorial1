using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tutorial.Models
{
    public class student
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public standard standard { get; set; }
    }

    public class standard
    {
        public int standatdID { get; set; }
        public string standartNAme { get; set; }
    }
}