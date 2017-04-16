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
using CommonLib.control.imageButton;
using System.ComponentModel;

namespace CommonLib.control.listImageControl
{
    /// <summary>
    /// LlistImageControl.xaml 的交互逻辑
    /// </summary>
    public partial class ListImageControl : UserControl,INotifyPropertyChanged
    {
        List<string> displayListImage;
        public List<string> DisplayListImage
        {
            get { return displayListImage; }
            set 
            { 
                displayListImage=value;

                NotifyProperty("DisplayListImage");
            }
        }

        int pageCount = 1;
        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        int pageIndex = 1;
        public int PageIndex
        {
            get { return pageIndex; }
            set
            {
                if (value == 0)
                {
                    value = 1;
                }
                if (value > PageCount)
                {
                    value = PageCount;
                }

                pageIndex = value;
                DisplayListImage = GetPageImageList(pageIndex, ImageList);
                this.listBoxImage.SelectedIndex = 0;
            }
        }

        public string SelectedImage
        {
            get { return (string)GetValue(SelectedImageProperty); }
            set { SetValue(SelectedImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedImageProperty =
            DependencyProperty.Register("SelectedImage", typeof(string), typeof(ListImageControl), new UIPropertyMetadata(string.Empty, null));



        public List<string> ImageList
        {
            get { return (List<string>)GetValue(ImageListProperty); }
            set { SetValue(ImageListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NormalImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageListProperty =
            DependencyProperty.Register("ImageList", typeof(List<string>), typeof(ListImageControl), new UIPropertyMetadata(null, ListImageChanged));


        private static void ListImageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ListImageControl dp = d as ListImageControl;
            List<string> list = e.NewValue as List<string>;
            dp.ImageList = list;

            if (list == null || list.Count == 0)
            {
                dp.DisplayListImage = null;
            }
            else
            {
                int pagecount=1;
                pagecount= (int)(list.Count/4);
                if(list.Count % 4 >0)
                {
                    pagecount++;
                }
                dp.PageCount = pagecount;

                dp.PageIndex = 1;
            }
        }


        public List<string> GetPageImageList(int p_PageIndex, List<string> p_ImageList)
        {
            List<string> list = new List<string>();
            int index = 1;

            for (int i = (p_PageIndex-1)*4; i < ImageList.Count; i++)
            {
                list.Add(ImageList[i]);

                if (index == 4)
                {
                    break;
                }

                index++;
            }

            return list;
        }

        public ICommand SelectImageCmd
        {
            get { return (ICommand)GetValue(SelectImageCmdProperty); }
            set { SetValue(SelectImageCmdProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackDish.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectImageCmdProperty =
            DependencyProperty.Register("SelectImageCmd", typeof(ICommand), typeof(ListImageControl), new UIPropertyMetadata(null));

        public ListImageControl()
        {
            InitializeComponent();

            this.DataContext = this;


            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.ButtonClickEvent));
        }

        private void ButtonClickEvent(object sender, RoutedEventArgs e)
        {
            ImageButton btn = e.OriginalSource as ImageButton;
   
             if (btn == null)
            {
                return;
            }

            string imageName = btn.Name;
            if (imageName == "btnPrePage")
            {
                PageIndex--;
            }
            else if (imageName == "btnNextPage")
            {

                PageIndex++;
            }
        }

        /// <summary>
        /// 消息通知
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyProperty(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
