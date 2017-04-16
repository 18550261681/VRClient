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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommonLib.control.tabButton
{
    /// <summary>
    /// TextButton.xaml 的交互逻辑
    /// </summary>
    public partial class TabButton : Button
    {
        public TabButton()
        {
            InitializeComponent();

            this.DataContext = this;

           //对路由事件的处理
            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.ButtonClickEvent));
        }

        private void ButtonClickEvent(object sender, RoutedEventArgs e)
        {
            Button btn = e.OriginalSource as Button;

            this.Selected = true;

            //Background=new SolidColorBrush((Color)ColorConverter.ConvertFromString(SelectedForeground));   
        }
 
        public string NormalForeground
        {
            get { return (string)GetValue(NormalForegroundProperty); }
            set { SetValue(NormalForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NormalForegroundProperty =
            DependencyProperty.Register("NormalForeground", typeof(string), typeof(TabButton), new UIPropertyMetadata("#A4A9D6"));


        public string HoverForeground
        {
            get { return (string)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverForegroundProperty =
            DependencyProperty.Register("HoverForeground", typeof(string), typeof(TabButton), new UIPropertyMetadata("#FFFFFF"));


        public string SelectedForeground
        {
            get { return (string)GetValue(SelectedForegroundProperty); }
            set { SetValue(SelectedForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.Register("SelectedForeground", typeof(string), typeof(TabButton), new UIPropertyMetadata("Transparent"));


        public string NormalBackground
        {
            get { return (string)GetValue(NormalBackgroundProperty); }
            set { SetValue(NormalBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NormalBackgroundProperty =
            DependencyProperty.Register("NormalBackground", typeof(string), typeof(TabButton), new UIPropertyMetadata("Transparent"));


        public string HoverBackground
        {
            get { return (string)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverBackgroundProperty =
            DependencyProperty.Register("HoverBackground", typeof(string), typeof(TabButton), new UIPropertyMetadata("#Transparent"));


        public string SelectedBackground
        {
            get { return (string)GetValue(SelectedBackgroundProperty); }
            set { SetValue(SelectedBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedBackgroundProperty =
            DependencyProperty.Register("SelectedBackground", typeof(string), typeof(TabButton), new UIPropertyMetadata("#Transparent"));

      
        public bool Selected
        {
            get { return (bool)GetValue(SelectedProperty); }
            set { SetValue(SelectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(bool), typeof(TabButton), new UIPropertyMetadata(false));
    }


    public class BoolToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool selected = bool.Parse(value.ToString());
            if (selected)
            {
                return "#FFFFFF";
            }
            else
            {
                return "#A4A9D6";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
