using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DataModel
{
    /// <summary>
    /// 模型基类
    /// </summary>
    public class BaseModel : INotifyPropertyChanged
    {
        /// <summary>
        /// 消息通知
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyProperty(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
