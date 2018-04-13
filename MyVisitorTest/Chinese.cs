using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorTest
{
   public class Chinese:Human
    {
        public override void play(IMountain moutain)
        {
            moutain.MountainName(this);
        }
    }
}
