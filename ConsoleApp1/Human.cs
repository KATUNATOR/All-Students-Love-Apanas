using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mammalik;

namespace Humanchik
{
    abstract class Human : IMammal
    {
        byte age;
        bool sex;
        bool alive = true;
        double money;
        string name;

        public Human(byte age, bool sex, double money, string name)
        {
            this.age = age;
            this.sex = sex;
            this.money = money;
            this.name = name;
        }

        public byte Age 
        { 
            get { return age; }
            set { if (value > age) age = value; }
        }

        public bool Sex 
        {
            get { return sex; }
            set 
            {
                Console.Write("Введите максимальное значение типа long: ");
                string answear = Console.ReadLine();
                if (answear.Equals("2147483647"))
                {
                    Console.WriteLine(@"Поздравляем, теперь Вы {0} пола!", (value) ? ("Женского") : ("Мужского"));
                    sex = value;
                }
                else
                {
                    Console.WriteLine("Прости, в следующий раз...");
                }                 
            }
        }

        public bool Alive
        {
            get { return alive; }
        }


        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        public string Name
        {
            get { return name; }
        }

        bool IMammal.Alive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetFood()
        {
            for (int i = 0; i < new Random().Next(1,10); i++)
            {
                Console.WriteLine("Хрум-хрум...");
            }
        }

        public void GetIll()
        {
            Console.WriteLine("БРРРР1!1!! ЗАКРОЙТЕ ФОРТОЧКУ!!1! МНЕ ДУЕТ!!11!1!");
        }

        public abstract void GetMoney();
    }
}
