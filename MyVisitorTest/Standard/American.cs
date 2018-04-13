using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorTest.Standard
{
    public class American : Human
    {
        public override void play(IVisitor moutain)
        {
            moutain.Visit(this);
        }
    }
}

