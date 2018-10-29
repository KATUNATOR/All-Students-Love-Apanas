using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentik
{
    class Student 
    {
        public double AverMark;
        public byte MaxMark;
        public byte MinMark;
        public double[] Averages
        {
            get
            {
                double[] a = new double[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        a[i] += marks[i, j];
                    }
                    a[i] /= n;
                }
                return a;
            }
        }
        public double[,] Sem; //семестр/предметы


        public Zachetka(double AverMark, byte MaxMark, byte MinMark, double[,] Sem)
        {
            this.AverMark = AverMark;
            this.MaxMark = MaxMark;
            this.MinMark = MinMark;
            this.Sem = Sem;
        }



        public void Zapoln()
        {
            int[,] mas = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mas[i, j] = rand.Next(0, 100);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
}
