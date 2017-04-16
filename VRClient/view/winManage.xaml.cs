using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CommonLib.baseView;
using VRClient.viewModel;

namespace VRClient.view
{
    /// <summary>
    /// winSetting.xaml 的交互逻辑
    /// </summary>
    public partial class winManage : BaseWindow
    {
        public winManage()
        {
            InitializeComponent();

            this.MouseDown += new MouseButtonEventHandler(winManage_MouseDown);

            this.DataContext = new winManageModel();

            TabItem s = new TabItem();
            //s.FontStyle
           //s.Background
        }

        void winManage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.GetPosition(this).Y < 30 && WindowState == WindowState.Normal)
            {
                this.DragMove();
            }
        }
    }
}
