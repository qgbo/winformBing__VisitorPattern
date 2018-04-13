﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormNotifyProperty绑定控件
{
    public delegate void ChangedHandler(object sender, object v);

    public class Person : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged 成员  

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
         //   PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        /// <summary>  
        /// 属性变换事件  
        /// </summary>  
        /// <param name="sender">源</param>  
        /// <param name="v">变化后的值</param>  
        /// <param name="old">变化前的值</param>  
        /// <param name="hander"></param>  
        protected virtual void OnChanged(object sender, object v, object old, ChangedHandler hander)
        {
            if (!v.Equals(old) && hander != null)
                hander(sender, v);
        }
    }
}
