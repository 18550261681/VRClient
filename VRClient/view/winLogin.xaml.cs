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
using VRClient.viewModel;

namespace VRClient.view
{
    /// <summary>
    /// winLogin.xaml 的交互逻辑
    /// </summary>
    public partial class winLogin : Window
    {
        ResourceDictionary style;

        public winLogin()
        {
            InitializeComponent();

            this.DataContext = new winLoginViewModel();

            this.MouseDown += new MouseButtonEventHandler(winLogin_MouseDown);
        }

        void winLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.GetPosition(this).Y < 20)
            {
                this.DragMove();
            }
        }
    }
}
