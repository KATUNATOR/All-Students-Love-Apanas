using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mammalik
{
    interface IMammal
    {
        byte Age { get; set; }
        bool Sex { get; set; }
        bool Alive { get; set; }

        void GetIll();
        void GetFood();
    }
}
