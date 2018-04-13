using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            Test context = new Test();
          
            while (true)
            {
                // Test context = new Test())
                //{ 
                Console.WriteLine("############################################################");
                    tb_user userNew = null;
                    context.Database.Log += c => Console.WriteLine(c);
                    userNew = new tb_user()
                    {
                        username = "ttt",
                        gh = "100",
                        pwd = "pp"

                    };
                    if (userNew.Exist())
                        Console.WriteLine("用户已存在");
                    context.tb_user.Add(userNew);
                    context.SaveChanges();//

                    //userNew.Name = "安德鲁";
                    //context.SaveChanges();

                    context.tb_user.Remove(userNew);
                    context.SaveChanges();

                    var list1 = context.tb_user.Where(u => u.userid > 5).AsNoTracking();
                    Console.WriteLine("*****************list1*****************");
                    var list2 = context.tb_user.Where(u => u.userid > 5).ToList();
                    Console.WriteLine("******************list2****************");
                    var list3 = context.tb_user.Where(u => u.userid > 5).ToList();
                    Console.WriteLine("******************list3****************");
                    var list4 = context.tb_user.Where(u => u.userid > 5).ToList();
                    Console.WriteLine("*****************list4*****************");

               



                Console.WriteLine("***************************************");

              ConsoleKeyInfo k=  Console.ReadKey();
                if (k.Key == ConsoleKey.Enter)
                    break;
              }
            }
        }
    
}
