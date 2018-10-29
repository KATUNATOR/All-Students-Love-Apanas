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
        bool alive;
        double money;
        string name;

        public Human() { alive = true; }
        public Human(byte age, bool sex) : this()
        {
            this.age = age;
            Sex = sex;
        }
        public Human(byte age, bool sex, double money, string name) : this(age, sex)
        {
            this.money = money;
            this.name = name;
        }



        public byte Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Sex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Alive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetFood()
        {
            throw new NotImplementedException();
        }

        public void GetIll()
        {
            throw new NotImplementedException();
        }
    }
}
