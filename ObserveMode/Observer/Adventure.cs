using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveMode.Observer
{
    /// <summary>
    /// 冒險者(observer)
    /// </summary>
    public abstract class Adventure
    {
        protected string name;

        public Adventure(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 冒險者接受任務(OnEventHandler 處理來自Subject的訊息)
        /// </summary>
        /// <param name="questions"></param>
        public abstract void GetQuestions(string questions);
    }
}
