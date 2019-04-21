using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserveMode.Observer;

namespace ObserveMode.Subject
{
    /// <summary>
    /// 冒險者協會(ConcreteSubject)
    /// </summary>
    public class Association : Subject
    {
        /// <summary>
        /// 貼出任務公告(發布消息)
        /// </summary>
        /// <param name="questions"></param>
        public override void SendQuestions(string questions)
        {
            foreach (Adventure adventure in adventures)
            {
                adventure.GetQuestions(questions);
            }
        }
    }
}
