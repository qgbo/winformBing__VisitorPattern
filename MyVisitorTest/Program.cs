using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVisitorTest
{
    class Program
    {
        /// <summary>
        /// 访问这模式  重写
        /// 有3个景点，taiMountain  laojunMountain  yuntaiMountain
        /// 3个中国游客，2个美国游客，大家组团去旅游
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           { List<Human> people = new List<Human>()
                {
                new Chinese{ Name="张三",Country="中国"},
                new Chinese{ Name="李四",Country="中国"},
                new Chinese{ Name="王五",Country="中国"},

                new American{ Name="Jack",Country="美国"},
                new American{ Name="Bob",Country="美国"}
            };
            
                IMountain mountain = new taiMountain();
                foreach (var item in people)
                {
                    item.play(mountain);
                }
            }
            {
                List<Standard.Human> people = new List<Standard.Human>()
                {
                new Standard.Chinese{ Name="张三",Country="中国"},
                new Standard.Chinese{ Name="李四",Country="中国"},
                new Standard.Chinese{ Name="王五",Country="中国"},

                new Standard.American{ Name="Jack",Country="美国"},
                new Standard.American{ Name="Bob",Country="美国"}
                };

                Standard.IVisitor mountain = new Standard.taiMountain();
                foreach (var item in people)
                {
                    item.play(mountain);
                }
            }



            Console.ReadKey();

        }
    }
}
