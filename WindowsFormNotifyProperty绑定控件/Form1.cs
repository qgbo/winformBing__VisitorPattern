using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormNotifyProperty绑定控件
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        
            m = new Man();

            m.ChangeName += m_ChangeName;
            m.ChangeAge += m_ChangeAge;
            DoProperty.Bind(MyBindingTextBox, "Text", BindingMan, "Name");

            textBoxBinding.DataBindings.Add("Text", BindingMan, "Name");//系统的绑定
           // textBoxBinding.DataBindings.Add("Width", m, "Age");
        }
        BindingHuman BindingMan=new BindingHuman();
        Man m;
        void m_ChangeAge(object sender, object v)
        {
            SetText("m.Age " + v.ToString());
        }

        void m_ChangeName(object sender, object v)
        {
            SetText("m.Name " + v.ToString());
        }

        

        public void SetText(string txt)
        {
            textBox1.Text += txt + "\r\n";
        }

        private void btnName_Click(object sender, System.EventArgs e)
        {
            m.Name = textBoxName.Text;
            BindingMan.Name = textBoxName.Text;
        }
        private void btnAge_Click(object sender, System.EventArgs e)
        {
            m.Age = int.Parse(textBoxAge.Text);
        }
    }
}
