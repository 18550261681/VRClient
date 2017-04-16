using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows;

namespace CommonLib.control.textBoxDefaltValue
{
    public class NormalTextEx : TextBox
    {
        public NormalTextEx()
        {
            this.TextChanged += new TextChangedEventHandler(NormalTextEx_TextChanged);
        }

        void NormalTextEx_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length <= 0)
            {
                showDefaltVlaue();
            }
            else
            {
                clearDefaltVlaue();
            }
        }

        private Brush brushColor;

        public Brush BrushColor
        {
            get { return brushColor; }
            set 
            { 
                brushColor = value;
                showDefaltVlaue();
            }
        }

        private string defaltValue;

        /// <summary>
        /// 当没有数据的默认值
        /// </summary>
        public string DefaltValue
        {
            get { return defaltValue; }
            set
            {
                defaltValue = value;

                showDefaltVlaue();
            }
        }

        /// <summary>
        /// 当没有数据时候显示默认数据
        /// </summary>
        private void showDefaltVlaue()
        {
            if (string.IsNullOrEmpty(DefaltValue))
            {
                return;
            }

            VisualBrush vBrush = new VisualBrush();
            vBrush.TileMode = TileMode.None;
            vBrush.Stretch = Stretch.None;
            vBrush.Opacity = 1;
            vBrush.AlignmentX = AlignmentX.Left;
            TextBox tempT = new TextBox();
            tempT.Background = Brushes.Transparent;
            tempT.BorderThickness = new Thickness(0);
            tempT.Foreground = BrushColor;
            tempT.Text = DefaltValue;
            vBrush.Visual = tempT;
            this.Background = vBrush;
        }


        /// <summary>
        /// 输入数据时候显示默认提示信息
        /// </summary>
        private void clearDefaltVlaue()
        {
            VisualBrush vBrush = new VisualBrush();
            this.Background = vBrush;
        }

    }
}
