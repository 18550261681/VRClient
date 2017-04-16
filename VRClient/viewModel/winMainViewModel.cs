using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLib.BaseViewModel;
using CommonLib.control.tabButton;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using DataModel.clientModel;
using VRClient.view;

namespace VRClient.viewModel
{
    public class winMainViewModel : BaseViewModel
    {
        #region 变量

       
        #endregion

        #region 构造


        public winMainViewModel()
        {

            m_Games = new List<Game>();

            for (int i = 0; i < 20; i++)
            {
                Game game = new Game
                {
                    Id = i.ToString("000"),
                    Name = "游戏" + i.ToString("000"),
                    Image = "/VRClient;component/img/winMain/img.png",

                };

                game.GameIntroduction = new GameIntroduction();
                game.GameIntroduction.ImageList = new List<string>();
                game.GameIntroduction.ImageList.Add("/VRClient;component/img/winMain/game1.png");
                game.GameIntroduction.ImageList.Add("/VRClient;component/img/winMain/game2.png");
                game.GameIntroduction.ImageList.Add("/VRClient;component/img/winMain/game3.png");
                game.GameIntroduction.ImageList.Add("/VRClient;component/img/winMain/game4.png");
                game.GameIntroduction.ImageList.Add("/VRClient;component/img/winMain/game5.png");
                game.GameIntroduction.ImageList.Add("/VRClient;component/img/winMain/game6.png");
                game.GameIntroduction.ImageList.Add("/VRClient;component/img/winMain/game7.png");
                game.GameIntroduction.ImageList.Add("/VRClient;component/img/winMain/game8.png");
                game.GameIntroduction.ImageList.Add("/VRClient;component/img/winMain/game9.png");
                game.GameIntroduction.Title = "不祥之刃";
                game.GameIntroduction.Introduction="不祥之刃-卡特琳娜是诺克萨斯的一名杰出的女刺客，诺克萨斯将军的女儿，也是魔蛇之拥-卡西奥佩娅的姐姐。卡特琳娜常活跃在中单AP的位置上，是优秀的法系输出者和团战收割者。";

                m_Games.Add(game);
            }

            Games = m_Games;
        }

        #endregion


        #region 属性

        List<Game> m_Games;
        /// <summary>
        /// 界面 ListView 显示的Games
        /// </summary>
        public List<Game> Games
        {
            get { return m_Games; }
            set
            {
                m_Games = value;
                this.RaisePropertyChanged("Games");
            }
        }


        string m_SelectedGameIntroductionImage;
        /// <summary>
        /// 选中 简介的Image
        /// </summary>
        public string SelectedGameIntroductionImage
        {
            get { return m_SelectedGameIntroductionImage; }
            set 
            {
                m_SelectedGameIntroductionImage = value;
                this.RaisePropertyChanged("SelectedGameIntroductionImage");
            }
        }


        bool m_ShowGameList = true;
        /// <summary>
        /// 显示游戏列表
        /// </summary>
        public bool ShowGameList
        {
            get { return m_ShowGameList; }
            set
            {
                m_ShowGameList = value;
                this.RaisePropertyChanged("ShowGameList");

                if (m_ShowGameList)
                {
                    ShowGameIntroduction = false;
                }
            }
        }


        bool m_ShowGameIntroduction = false;
        /// <summary>
        /// 显示游戏简介
        /// </summary>
        public bool ShowGameIntroduction
        {
            get { return m_ShowGameIntroduction; }
            set
            {
                m_ShowGameIntroduction = value;
                this.RaisePropertyChanged("ShowGameIntroduction");

                if (m_ShowGameIntroduction)
                {
                    ShowGameList = false;
                }
            }
        }


        Game m_SelectedGame;
        /// <summary>
        /// 选中的 Game
        /// </summary>
        public Game SelectedGame
        {
            get { return m_SelectedGame; }
            set
            {
                m_SelectedGame = value;
                this.RaisePropertyChanged("SelectedGame");
            }
        }

        #endregion


        #region 命令


        /// <summary>
        /// 显示设置界面
        /// </summary>
        public ICommand ShowManageCmd
        {
            get
            {
                return new RelayCommand(() =>
                {
                    winManage winManage = new winManage();
                    winManage.Show();
                });
            }
        }


        TabButton oldTabButton;
        /// <summary>
        /// 设置TabButton Selected
        /// </summary>
        public ICommand TabButtonMouseDownCmd
        {
            get
            {
                return new RelayCommand<TabButton>((btn) =>
                {
                    if (oldTabButton != null)
                    {
                        oldTabButton.Selected = false;
                    }

                    btn.Selected = true;
                    oldTabButton = btn;
                });
            }
        }

        /// <summary>
        /// 查看游戏简介
        /// </summary>
        public ICommand ViewGameIntroductionCmd
        {
            get
            {
                return new RelayCommand<Game>((game) =>
                {
                    ShowGameIntroduction = true;

                    SelectedGame = game;
                });
            }
        }

        /// <summary>
        /// 返回游戏列表
        /// </summary>
        public ICommand BackToGameListCmd
        {
            get
            {
                return new RelayCommand(()=>
                {
                    ShowGameList = true;
                });
            }
        }
    
        #endregion


        #region 方法

        
        #endregion
    }
}
