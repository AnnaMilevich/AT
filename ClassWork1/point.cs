using System;

namespace test1
{
    public class Point
    {
        public int x;
        public int y;
        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
        public override string ToString()
        {
            return x.ToString() + " " + y.ToString();
                 
        }
        

    }
}
