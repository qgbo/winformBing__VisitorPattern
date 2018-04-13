using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorTest
{
   public abstract class Human
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public abstract void play(IMountain moutain);
    }
}
