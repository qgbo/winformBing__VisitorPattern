using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormNotifyProperty绑定控件
{
    public class DoProperty
    {
        public static void Bind<T>(Control control, string propertyName, T dataSource, string dataMember)
        {
            var result = GetModelValue(dataMember, dataSource);
            SetModelValue(control, propertyName, result);
        }

        public static string GetModelValue(string FieldName, object obj)
        {
            try
            {
                Type Ts = obj.GetType();
                object o = Ts.GetProperty(FieldName).GetValue(obj, null);
                string Value = Convert.ToString(o);
                if (string.IsNullOrEmpty(Value)) return null;
                return Value;
            }
            catch
            {
                return null;
            }
        }

        /// 
        /// 设置类中的属性值
        /// 
        /// 
        /// 
        /// 
        public static bool SetModelValue( object obj,string FieldName, string Value)
        {
            try
            {
                Type Ts = obj.GetType();
                PropertyInfo p = Ts.GetProperty(FieldName);

                object v = Convert.ChangeType(Value, p.PropertyType);
                p.SetValue(obj, v, null);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
