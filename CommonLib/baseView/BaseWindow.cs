using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;


namespace CommonLib.baseView
{
    public class BaseWindow:Window
    {
        ResourceDictionary style;

        public BaseWindow()
        {
            style = new ResourceDictionary();
            style.Source = new Uri("/CommonLib;component/baseView/BaseWindowStyle.xaml", UriKind.Relative);
            this.Style = (Style)style["BaseWindowStyle"];

            //对路由事件的处理
            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.ButtonClickEvent));
        }

        /// <summary>
        /// Button鼠标点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClickEvent(object sender, RoutedEventArgs e)
        {
            Button btn = e.OriginalSource as Button;
            if (btn == null)
            {
                return;
            }

            string imageName = btn.Name;
            if (imageName == "btnClose")
            {
                this.Close();
            }
            else if (imageName == "btnMin")
            {
                this.WindowState = WindowState.Minimized;
            }
        }
    }
}
