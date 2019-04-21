using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserveMode.Observer;

namespace ObserveMode.Subject
{
    /// <summary>
    /// 被觀察者介面
    /// </summary>
    public abstract class Subject
    {
        //觀察者清單
        protected List<Adventure> adventures = new List<Adventure>();

        /// <summary>
        /// 觀察者想被通知(提供註冊機制)
        /// </summary>
        /// <param name="observer"></param>
        public void Add(Adventure observer)
        {
            adventures.Add(observer);
        }

        /// <summary>
        /// 觀察者不想接到通知(取消註冊機制)
        /// </summary>
        /// <param name="observer"></param>
        public void Remove(Adventure observer)
        {
            adventures.Remove(observer);
        }

        /// <summary>
        /// 貼出任務公告(發布消息)
        /// </summary>
        /// <param name="questions"></param>
        public abstract void SendQuestions(string questions);
    }
}
