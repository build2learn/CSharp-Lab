using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lab
{
    class Empolyee:Person
    {
        public int NID { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return "Name: " + this.Name + " Age: " + this.Age + " ID: " + this.NID + " Salary: " + this.Salary;
        }
    }
}
