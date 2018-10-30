using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanchik;

namespace Abiturientik
{
    class Abiturient : Human
    {
        public string spec;
        public byte classes;

        public Abiturient (string spec, byte classes)
        {
            this.spec = spec;
            this.classes = classes;
        }

        public string Spec
        {
            get { return spec; }
            set { spec = value; }
        }

        public byte Classes
        {
            get { return classes; }
        }


        public void Ekzamen()
        {
            Random rand = new Random();
            int mark = rand.Next(1, 11);
            Console.WriteLine("Студент {0},{1},{2}", Name, Sex, Age);
            Console.WriteLine("Получил {0} за экзамен на специальность {1},после {2} классов",mark,spec,classes);
        }
                                 

    }
}
