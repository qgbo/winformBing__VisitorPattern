using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormNotifyProperty绑定控件
{
    class BindingHuman : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged 成员  
        public event PropertyChangedEventHandler PropertyChanged;

        private string name="";
        public string Name
        {
            get
            { return name; }

            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        #endregion


    }
}
