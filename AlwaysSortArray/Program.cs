using System;

namespace AlwaysSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            SortArray sort = new SortArray();

            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n <= -1)
                {
                    break;
                }

                sort.Add(n);
            }

            Console.WriteLine(string.Join(" ", sort.List));
            Console.ReadLine();
        }
    }
}
