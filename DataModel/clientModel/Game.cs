using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.clientModel
{
    public class Game : BaseModel
    {
        string id;
        /// <summary>
        /// Id  游戏 Id
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        string name;
        /// <summary>
        /// Name  游戏名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string type;
        /// <summary>
        /// Type  游戏/电影
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        string exePath;
        /// <summary>
        /// 程序路径
        /// </summary>
        public string ExePath
        {
            get { return exePath; }
            set { exePath = value; }
        }

        string image;
        /// <summary>
        /// 图片路径
        /// </summary>
        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        string trialTime;
        /// <summary>
        /// 试玩时间    多少秒  
        /// </summary>
        public string TrialTime
        {
            get { return trialTime; }
            set { trialTime = value; }
        }

        GameIntroduction gameIntroduction;
        /// <summary>
        /// 简介
        /// </summary>
        public GameIntroduction GameIntroduction
        {
            get { return gameIntroduction; }
            set { gameIntroduction = value; }
        }

        bool isChecked = false;
        /// <summary>
        /// IsChecked
        /// </summary>
        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                this.NotifyProperty("IsChecked");
            }
        }

        bool hideBottomLine = true;

        public bool HideBottomLine
        {
            get { return hideBottomLine; }
            set { hideBottomLine = value; }
        }
    }
}
