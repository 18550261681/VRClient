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

namespace CommonLib.control.textBoxDefaltValue
{
    /// <summary>
    /// PasswordBoxEx.xaml 的交互逻辑
    /// </summary>
    public partial class PasswordBoxEx : UserControl
    {
        public PasswordBoxEx()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 默认显示的数据
        /// </summary>
        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }

        public static readonly DependencyProperty HintProperty =
            DependencyProperty.Register("Hint", typeof(string), typeof(PasswordBoxEx), new PropertyMetadata(null, new PropertyChangedCallback(OnHintChanged)));

        private static void OnHintChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBoxEx password = d as PasswordBoxEx;
            password.UpdateStates();
        }

        public string HintText
        {
            get { return (string)GetValue(HintTextProperty); }
            set { SetValue(HintTextProperty, value); }
        }

        public static readonly DependencyProperty HintTextProperty =
            DependencyProperty.Register("HintText", typeof(string), typeof(PasswordBoxEx), new PropertyMetadata(null));


        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Password.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(PasswordBoxEx), new PropertyMetadata(null, new PropertyChangedCallback(OnPasswordChanged)));


        public Brush BackgroundColor
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Background.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundColorProperty =
            DependencyProperty.Register("BackgroundColorProperty", typeof(Brush), typeof(PasswordBoxEx), new UIPropertyMetadata(null, new PropertyChangedCallback(BackgroundChanged)));


        private static void BackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBoxEx uc = d as PasswordBoxEx;
            if (e.NewValue == null)
            {
                return;
            }
            uc.Background = e.NewValue as Brush;
        }

        private static void OnPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBoxEx uc = d as PasswordBoxEx;
            uc.UpdateStates();
        }

        private void UpdateStates()
        {
            if (string.IsNullOrWhiteSpace(Password))
            {
                HintText = Hint;
            }
            else
            {
                HintText = "";
            }
        }
    }
}
