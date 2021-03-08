using System;

namespace RandomWork
{
    class Program
    {
         static Random r = new Random(123);

        
        public static int Results()
        {
            
            return r.Next(1,101);
        }
        static void Main(string[] args)
        {
            int number = 10;
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += Results();
                //Console.WriteLine(Results());
            }
            Console.WriteLine(sum);
            //Console.WriteLine(Results());
        }
    }
}
