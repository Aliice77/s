using System;
using System.Collections.Generic;

namespace s
{
    
    class Program
    {
        static void Main(string[] args)
        {

            List<int> ints = new List<int>();
            Console.WriteLine("enrer numbers");
            string a =Console.ReadLine();

            foreach (var item in a)
            {
                ints.Add(Convert.ToInt32(item));
            }
            int ff = 0;
            for (int i = 0; i < ints.Count - 1; i++)
            {
                if ((ints[i]) - (ints[i + 1]) == -2)
                {

                }
                else if ((ints[i]) - (ints[i + 1]) == 2)
                {

                }
                else
                {

                    ff++;
                }
                
            }
            if (ff != 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
            Console.ReadKey();

        }
    }
}
