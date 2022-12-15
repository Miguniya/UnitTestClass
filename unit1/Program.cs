using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit1
{
    public class Program
    {
        public static void Main()
        {

            //int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int n = 0;
            Console.WriteLine("Введите n= ");
            int.TryParse(Console.ReadLine(), out n);
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; n++)
            {
                for (int j = 0; j < n; n++)
                {
                    int.TryParse(Console.ReadLine(), out matrix[i, j]);
                }
            }
            Sedlo sedlo = new Sedlo(matrix);
            var points = sedlo.SedloPoints;
            foreach (var p in points)
            {
                Console.WriteLine(p.ToString());
            }
            //Point p = new Point(3, 4, 5);
            //Console.Write(p.ToString());
            //var t = sedlo.Max('c');
            //for (int i = 0; i < t.GetLength(0); i++)
            //{
            //    Console.Write(t[i] + " ");
            //}
            //Console.ReadLine();
        }
    }
}
