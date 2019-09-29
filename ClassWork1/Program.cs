using System;


namespace test1
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Point[] points1 = new Point[3];
            points1[0] = new Point(1, 2);
            points1[1] = new Point(2, 3);
            points1[2] = new Point(4, 5);

            Point[] points2 = new Point[3];
            points2[0] = new Point(1, 2);
            points2[1] = new Point(3, 3);
            points2[2] = new Point(4, 5);

            Point[] points3 = new Point[3];
            points3[0] = new Point(1, 2);
            points3[1] = new Point(2, 4);
            points3[2] = new Point(4, 5);

            Point[] points4 = new Point[3];
            points4[0] = new Point(1, 2);
            points4[1] = new Point(2, 3);
            points4[2] = new Point(4, 5);

            Point[] points5 = new Point[3];
            points5[0] = new Point(1, 2);
            points5[1] = new Point(2, 3);
            points5[2] = new Point(3, 5);

            Triangle[] trngl = new Triangle[5];
            trngl[0] = new Triangle(points1[0], points1[1], points1[2]);
            trngl[1] = new Triangle(points2[0], points2[1], points2[2]);
            trngl[2] = new Triangle(points3[0], points3[1], points3[2]);
            trngl[3] = new Triangle(points4[0], points4[1], points4[2]);
            trngl[4] = new Triangle(points5[0], points5[1], points5[2]);

            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    bool result = trngl[i].Equals(trngl[j]);
                    if(result==true)
                    {
                        Console.WriteLine("{0}={1} ", i+1, j+1);
                    }
                    
                }
            }
            //Console.WriteLine(result);
            foreach (Point point in points1)
            {
                Console.WriteLine(point);
            }

            Console.ReadLine();
        }
        
    }
}
