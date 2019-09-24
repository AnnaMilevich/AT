using System;

namespace HM1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int sizeStr, maxCount, count;
            maxCount = 0;

            Console.WriteLine("Enter the word: ");
            str = Console.ReadLine();
            
            sizeStr = str.Length;

            for (int i = 0; i < sizeStr; i++)
            {
                count = 1;
                for (int j = i + 1; j < sizeStr; j++)
                {
                    if (str[i] == str[j])
                    {
                        count += 1;
                    }
                }
                if (count >= maxCount)
                {
                    maxCount = count;
                }
            }
            Console.WriteLine(maxCount);
            

        }
    }
}

