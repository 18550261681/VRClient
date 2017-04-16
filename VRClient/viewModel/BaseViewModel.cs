using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using System.Windows.Input;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Messaging;
using System.Diagnostics;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace CommonLib.BaseViewModel
{
    public class BaseViewModel : ViewModelBase
    {
        public const string Message_Notice = "Notice";

        //消息通知事件
        public delegate void NoticeEventHandler(object sender);
        public event NoticeEventHandler NoticeEvent;

        public BaseViewModel()
        {
            //注册服务器消息通知
            Messenger.Default.Register<object>(this, Message_Notice, new Action<object>((noticeInfo) =>
            {
                if (NoticeEvent != null)
                {
                    NoticeEvent(noticeInfo);
                }
            }));
        }

        /// <summary>
        /// 只能输入数字的限制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PreviewKeyDownEvent(object sender, KeyEventArgs e)
        {
            TextBox text = sender as TextBox;
            if ((e.Key > Key.D9 && e.Key < Key.NumPad0) || e.Key > Key.NumPad9 && e.Key != Key.Enter || e.Key == Key.Space || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
            {
                e.Handled = true;
            }
        }


        /// <summary>
        /// 只能输入数字的限制 (默认2位小数点)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ValidateNumberInput(object sender, KeyEventArgs e)
        {
            TextBox text = sender as TextBox;

            if ((e.Key == Key.Decimal || e.Key == Key.OemPeriod) && text.Text.Contains('.') == false && !string.IsNullOrEmpty(text.Text))
            {
                //e.Handled = false;
                return;
            }

            if ((e.Key > Key.D9 && e.Key < Key.NumPad0) || e.Key > Key.NumPad9 && e.Key != Key.Enter || e.Key == Key.Space || e.KeyboardDevice.Modifiers == ModifierKeys.Shift || 
                ((!string.IsNullOrEmpty(text.Text) && text.Text.Contains(".") && (text.Text.Substring(text.Text.IndexOf(".")+1,text.Text.Length-text.Text.IndexOf(".")-1).Length==2)) && e.Key!=Key.Back))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 只能输入数字的限制 (1位小数点)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ValidateNumberInput1(object sender, KeyEventArgs e)
        {
            TextBox text = sender as TextBox;

            if ((e.Key == Key.Decimal || e.Key == Key.OemPeriod) && text.Text.Contains('.') == false && !string.IsNullOrEmpty(text.Text))
            {
                //e.Handled = false;
                return;
            }

            if ((e.Key > Key.D9 && e.Key < Key.NumPad0) || e.Key > Key.NumPad9 && e.Key != Key.Enter || e.Key == Key.Space || e.KeyboardDevice.Modifiers == ModifierKeys.Shift ||
                ((!string.IsNullOrEmpty(text.Text) && text.Text.Contains(".") && (text.Text.Substring(text.Text.IndexOf(".") + 1, text.Text.Length - text.Text.IndexOf(".") - 1).Length == 1)) && e.Key != Key.Back))
            {
                e.Handled = true;
            }
        }
       
        /// <summary>
        /// 重启程序
        /// </summary>
        public void RestartApplication() 
        {
            string path = string.Format("{0}{1}", AppDomain.CurrentDomain.BaseDirectory, "CashierClient.exe");
            Process.Start(path);
            Environment.Exit(0);
        }

        /// <summary>
        /// TextBox清除
        /// </summary>·
        public ICommand ClearTextCommand
        {
            get
            {
                return new RelayCommand<object>((obj) =>
                {
                    TextBox t = obj as TextBox;
                    t.Text = "";
                });
            }
        }
    }
}
