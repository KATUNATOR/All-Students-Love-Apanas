using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abiturientik;

namespace Studentik
{
    class Student : Abiturient
    {
        public int group;
        public bool budget;

        struct Zachetka
        {
            public byte MaxMark;
            public byte MinMark;
            public double Sem; //средняя за семестр
            public double[,] Otsenki //массив оценок за предметы
            {
                get
                {
                    double[,] a = new double[n,m];
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


            public Zachetka(double AverMark, byte MaxMark, byte MinMark, double Sem, double[,] Otsenki)
            {

                this.MaxMark = MaxMark;
                this.MinMark = MinMark;
                this.Sem = Sem;
            }

        }




        public int Progul()
        {
            Console.WriteLine("Сколько дней хотите прогулять?");
            int d = Convert.ToInt64(Console.ReadLine());
            return d;
        }

        public void Otvet()
        {
            Console.WriteLine("Ваша оценка:");
            Random rand = new Random();
            int mark = rand.Next(0, 10);
        }


    }
}

