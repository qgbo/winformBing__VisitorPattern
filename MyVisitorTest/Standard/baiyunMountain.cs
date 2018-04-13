using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorTest.Standard
{
   public class baiyunMountain: IVisitor
    {
        public void Visit(Chinese p)
        {
            Console.WriteLine("中国人 " + p.Name + " 来白云山 旅游");
        }
        public void Visit(American p)
        {
            Console.WriteLine("美国人 " + p.Name + " 来白云山 旅游");
        }
    }
}
