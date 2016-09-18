using System;
using System.Collections.Generic;

namespace AlwaysSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            int n;
            while (a)
            {
                n = int.Parse(Console.ReadLine());
                if(n <= -1) { a = false;}
                var b = GetList(n).ToArray();
                for (int i = 0; i < b.Length; i++)
                    Console.WriteLine("{0}", b[i]);
            }
            Console.ReadLine();
        }

        public static List<string> GetList(int n)
        {
            List<string> list = new List<string>();
            if (n == 0)
            {
                list.Insert(0, "0"); 
                return list;
            }

            list.Insert(list.Count, n.ToString());
            list.Sort();
            return GetList(n - 1);
        }

    }
}
