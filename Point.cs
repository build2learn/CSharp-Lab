using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lab
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public Point() : this(0, 0, 0)
        {

        }
        
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return "X : " + x + " Y : " + y +" Z : "+ z ; 
        }
        public override bool Equals(object obj   )
        {
            Point pnt = obj as Point;
        
                return pnt.x == this.x && pnt.y == this.y && pnt.z == this.z;
         
        }
    }
}
