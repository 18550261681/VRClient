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
using System.ComponentModel;

namespace CommonLib.control.imageButton
{
    /// <summary>
    /// ImageButton.xaml 的交互逻辑
    /// </summary>
    public partial class ImageButton : Button
    {
        public string NormalImage
        {
            get { return (string)GetValue(NormalImageProperty); }
            set { SetValue(NormalImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NormalImageProperty =
            DependencyProperty.Register("NormalImage", typeof(string), typeof(ImageButton), new UIPropertyMetadata(string.Empty, SetNormalImageValueChanged));


        public string HoverImage
        {
            get { return (string)GetValue(HoverImageProperty); }
            set { SetValue(HoverImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverImageProperty =
            DependencyProperty.Register("HoverImage", typeof(string), typeof(ImageButton), new UIPropertyMetadata(string.Empty));


        public string ActiveImage
        {
            get { return (string)GetValue(ActiveImageProperty); }
            set { SetValue(ActiveImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ActiveImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ActiveImageProperty =
            DependencyProperty.Register("ActiveImage", typeof(string), typeof(ImageButton), new UIPropertyMetadata(string.Empty));


        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ActiveImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(ImageButton), new UIPropertyMetadata(string.Empty));

        public ImageButton()
        {
            InitializeComponent();

            this.DataContext = this;
        }


        private static void SetNormalImageValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ImageButton dp = d as ImageButton;
            dp.HoverImage = dp.ActiveImage = e.NewValue as string;
        }
    }

    //public class NullToDefaultConverter : IMultiValueConverter
    //{

    //    public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        if (values[1] == null)
    //        {
    //            return values[0];
    //        }
    //        else
    //        {
    //            return values[1];
    //        }
    //    }

    //    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
    //    {
    //        throw new NotSupportedException();
    //    }
    //}
}
