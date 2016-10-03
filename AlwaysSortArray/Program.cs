using System;

namespace AlwaysSortArray
{
    class Program
    {
        /// <summary>
        /// Алгоритм сортировки (вставками).
        /// Ввод чисела (n > -1), каждый новый поступивший элемент размещается в подходящее место среди ранее упорядоченных элементов.
        /// </summary>
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
