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

namespace CommonLib.control.searchTextBox
{
    /// <summary>
    /// SearchTextBox.xaml 的交互逻辑
    /// </summary>
    public partial class SearchTextBox : TextBox
    {
        public string NormalBorderBrush
        {
            get { return (string)GetValue(NormalBorderBrushProperty); }
            set { SetValue(NormalBorderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NormalBorderBrushProperty =
            DependencyProperty.Register("NormalBorderBrush", typeof(string), typeof(SearchTextBox), new UIPropertyMetadata("White", null));


        public string HoverBorderBrush
        {
            get { return (string)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoverBorderBrushProperty =
            DependencyProperty.Register("HoverBorderBrush", typeof(string), typeof(SearchTextBox), new UIPropertyMetadata("White", null));

        public string DefautValue
        {
            get { return (string)GetValue(DefautValueProperty); }
            set { SetValue(DefautValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DefautValueProperty =
            DependencyProperty.Register("DefautValue", typeof(string), typeof(SearchTextBox), new UIPropertyMetadata(string.Empty, null));

        public string DefaultValueForeground
        {
            get { return (string)GetValue(DefaultValueForegroundProperty); }
            set { SetValue(DefaultValueForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DefaultValueForegroundProperty =
            DependencyProperty.Register("DefaultValueForeground", typeof(string), typeof(SearchTextBox), new UIPropertyMetadata("White", null));

        public ICommand SearchCmd
        {
            get { return (ICommand)GetValue(SearchCmdProperty); }
            set { SetValue(SearchCmdProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackDish.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SearchCmdProperty =
            DependencyProperty.Register("SearchCmd", typeof(ICommand), typeof(SearchTextBox), new UIPropertyMetadata(null));

        public SearchTextBox()
        {
            InitializeComponent();

            this.DataContext = this;
        }
    }
}
