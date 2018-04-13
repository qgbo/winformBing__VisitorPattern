using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorTest
{
   public class taiMountain: IMountain
    {
        public  void MountainName(Human h)
        {
            Console.WriteLine( h.Country+  h.Name+ "来泰山 旅游"); 
        }
    }
}
