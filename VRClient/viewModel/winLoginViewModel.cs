using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLib.BaseViewModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using VRClient.view;

namespace VRClient.viewModel
{
    public class winLoginViewModel : BaseViewModel
    {
        #region 变量
        王海1111111111111111111111
            个人人人人人人人人12
       
        #endregion

        #region 构造


        public winLoginViewModel()
        {
           
        }

        #endregion


        #region 属性

        string m_UserId;
        /// <summary>
        ///  UserId
        /// </summary>
        public string UserId
        {
            get { return m_UserId; }
            set
            {
                m_UserId = value;

                this.RaisePropertyChanged("UserId");
            }
        }


        string m_Password;
        /// <summary>
        /// Password
        /// </summary>
        public string Password
        {
            get { return m_Password; }
            set
            {
                m_Password = value;
                this.RaisePropertyChanged("Password");
            }
        }
        #endregion


        #region 命令

        public ICommand OKCmd
        {
            get
            {
                return new RelayCommand<Window>((window) =>
                {

                    winMain win = new winMain();
                    win.Show();

                    window.Close();
                });
            }
        }

        public ICommand CloseCmd
        {
            get
            {
                return new RelayCommand<Window>((window) =>
                {
                    window.Close();
                });
            }
        }

        #endregion


        #region 方法

        
        #endregion
    }
}
