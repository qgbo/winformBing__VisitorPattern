using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorTest.Standard
{
   public interface IVisitor
    {
        void Visit(Chinese p);
        void Visit(American p);
    }
}
