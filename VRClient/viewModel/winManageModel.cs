using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLib.BaseViewModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using DataModel.clientModel;

namespace VRClient.viewModel
{
    public class winManageModel : BaseViewModel
    {
         #region 变量

         List<Game> m_Games;
       
        #endregion

        #region 构造


        public winManageModel()
        {
            m_Games = new List<Game>();

            for (int i = 0; i < 30; i++)
            {
                Game game = new Game
                {
                    Name = "巧克力与香子兰 " + i.ToString()
                };
                m_Games.Add(game);

                Games = m_Games;
            }
        }

        #endregion


        #region 属性

        /// <summary>
        /// Game列表
        /// </summary>
        public List<Game> Games
        {
            get { return m_Games; }
            set
            {
                m_Games = value;
                this.RaisePropertyChanged("Game");
            }
        }

        #endregion


        #region 命令

       
        /// <summary>
        /// checked
        /// </summary>
        public ICommand SelectCommand
        {
            get
            {
                return new RelayCommand<Game>((game) =>
                {
                    //DoChecked(computer);
                });
            }
        }

        /// <summary>
        /// unchecked
        /// </summary>
        public ICommand UnselectCommand
        {
            get
            {
                return new RelayCommand<Game>((game) =>
                {
                    //DoChecked(computer);
                });
            }
        }

        #endregion


        #region 方法

        
        #endregion
    }
}
