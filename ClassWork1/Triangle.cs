using System;

namespace test1
{
    public class Triangle
    {
        public double a;
        public double b;
        public double c;
    
        public Triangle(Point P1, Point P2, Point P3 )
        {
  
            a = Math.Sqrt((P1.x - P2.x) * (P1.x - P2.x) + (P1.y - P2.y) * (P1.y - P2.y));
            b = Math.Sqrt((P2.x - P3.x) * (P2.x - P3.x) + (P2.y - P3.y) * (P2.y - P3.y));
            c = Math.Sqrt((P3.x - P1.x) * (P3.x - P1.x) + (P3.y - P1.y) * (P3.y - P1.y));
            Console.WriteLine("a={0}; b={1}; c={2}", a, b, c);
            
        }
        public override bool Equals(object tr)
        {
            if (tr is Triangle)
            {
                Triangle side = (Triangle)tr;
                return (side.a == a && side.b == b && side.c == c);
            }
            else return false;

        }


    }
}
