namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r199 = 0;
            int r399 = 0;
            int r599 = 0;
            int r799 = 0;
            int r1000 = 0;

            // catch number of rows
            int rows = int.Parse(Console.ReadLine());

            // for each row make a loop
            for (int i = 0; i < rows; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num <= 199) r199++;
                else if (num <= 399) r399++;
                else if (num <= 599) r599++;
                else if (num <= 799) r799++;
                else r1000++;
            }

            // calculate percent
            double p1 = 100.00 * r199 / rows;
            double p2 = 100.00 * r399 / rows;
            double p3 = 100.00 * r599 / rows;
            double p4 = 100.00 * r799 / rows;
            double p5 = 100.00 * r1000 / rows;

            // print results
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}