using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCF_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                try
                {
                    host.Open();

                    this.Text = "服务开启！";
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);
                }
            }


            //#region 采用代码方式实现对契约的绑定
            //Uri baseAddress = new Uri("http://127.0.0.1:9999/");
            //using (ServiceHost host = new ServiceHost(typeof(Service1), baseAddress))
            //{
            //    //使用指定的协定、绑定和终结点地址将服务终结点添加到承载服务中
            //    host.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "Service1");

            //    #region Behavior

            //    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            //    behavior.HttpGetEnabled = true;
            //    behavior.HttpGetUrl = new Uri("http://127.0.0.1:9999/CalculatorService/metadata");
            //    host.Description.Behaviors.Add(behavior);
            //    #endregion

            //    host.Opened += delegate
            //    {
            //        Console.WriteLine("CalculaorService已经启动，按任意键终止服务！");
            //    };

            //    host.Open();
            //    Console.Read();
            //}
            //#endregion
        }
    }
}
