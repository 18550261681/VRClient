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
using CommonLib.control.imageButton;
using VRClient.viewModel;

namespace VRClient.view
{
    /// <summary>
    /// winMain.xaml 的交互逻辑
    /// </summary>
    public partial class winMain : Window
    {
        public winMain()
        {
            InitializeComponent();

            this.DataContext = new winMainViewModel();

            //对路由事件的处理
            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.ButtonClickEvent));

            this.MouseDown += new MouseButtonEventHandler(winMain_MouseDown);
        }

        Button btnMax;
        Button btnRestore;

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
            else if (imageName == "btn")
            {

                ImageButton imgbtn = btn as ImageButton;
                if (imgbtn.NormalImage.Contains("max"))
                {
                    imgbtn.NormalImage = "/VRClient;component/img/winMain/btn_restore_normal.png";
                    imgbtn.HoverImage = "/VRClient;component/img/winMain/btn_restore_hover.png";
                    imgbtn.ActiveImage = "/VRClient;component/img/winMain/btn_restore_pressed.png";

                    this.WindowState = WindowState.Maximized;
                }
                else
                {
                    imgbtn.NormalImage = "/VRClient;component/img/winMain/btn_max_normal.png";
                    imgbtn.HoverImage = "/VRClient;component/img/winMain/btn_max_hover.png";
                    imgbtn.ActiveImage = "/VRClient;component/img/winMain/btn_max_pressed.png";

                    this.WindowState = WindowState.Normal;
                }
            }
            else if (imageName == "btnMin")
            {
                this.WindowState = WindowState.Minimized;
            }
        }


        void winMain_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.GetPosition(this).Y < 43 && WindowState == WindowState.Normal)
            {
                this.DragMove();
            }
        }
    }
}
