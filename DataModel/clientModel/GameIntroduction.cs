using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.clientModel
{
    public class GameIntroduction : BaseModel
    {
        List<string> imageList;
        /// <summary>
        /// imageList
        /// </summary>
        public List<string> ImageList
        {
            get { return imageList; }
            set { imageList = value; }
        }

        string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        string introduction;
        /// <summary>
        /// Introduction
        /// </summary>
        public string Introduction
        {
            get { return introduction; }
            set { introduction = value; }
        }
    }
}
