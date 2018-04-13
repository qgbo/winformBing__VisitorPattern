using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorTest
{
   public class baiyunMountain: IMountain
    {
        public  void  MountainName(Human h)
        {
            Console.WriteLine(h.Country + h.Name + " 来白云山 旅游");
        }
    }
}
