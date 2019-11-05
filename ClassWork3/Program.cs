using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cell cell1 = new Cell('h', 5);
                Cell cell2 = new Cell('a', 15);
                Cell cell3 = new Cell('m', 2);

            }
            catch (OutRowOrColumBoard ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
