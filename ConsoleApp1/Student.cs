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
        int group;
        bool budget;
        Zachetka zach = new Zachetka();

        public Student(int group, bool budget, string spec, byte classes, ) : base(spec, classes)
        {
            this.group = group;
            this.budget = budget;

        }

        public struct Zachetka
        {
            public byte MaxMark;
            public byte MinMark;
            public int semCount;
            public int lesCount;
            public double[,] Otsenki; //массив оценок за предметы
            public double[] Sem //средняя за семестp
            {
                get
                {
                    int n = semCount;
                    int m = lesCount;
                    double[] a = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            a[i] += Otsenki[i, j];
                        }
                        a[i] /= n;
                    }
                    return a;
                }
            }

            public Zachetka(int semCount, int lesCount)
            {
                this.semCount = semCount;
                this.lesCount = lesCount;
                Otsenki = new double[semCount, lesCount];
                Random rand = new Random();
                for (int i = 0; i < semCount; i++)
                {
                    for (int j = 0; j < lesCount; j++)
                    {
                        Otsenki[i, j]=rand.Next(1,11);
                    }
                }
            }

        }




        public int Progul()
        {
            Console.WriteLine("Сколько дней хотите прогулять?");
            int d = Convert.ToInt32(Console.ReadLine());
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

