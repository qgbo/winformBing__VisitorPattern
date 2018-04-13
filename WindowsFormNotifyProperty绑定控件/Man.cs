using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormNotifyProperty绑定控件
{
    public class Man : Person
    {

        public event ChangedHandler ChangeName;

        public event ChangedHandler ChangeAge;

        string name = string.Empty;
        public virtual string Name
        {
            get { return name; }
            set
            {
                base.OnChanged(this, value, Name, ChangeName);//执行ChangeName
                name = value;
                OnPropertyChanged("Name");
            }
        }

        int age = 10;
        public virtual int Age
        {
            get { return age; }
            set
            {
                base.OnChanged(this, value, Age, ChangeAge);
                age = value;
                OnPropertyChanged("Age");
            }
        }

    }
}
