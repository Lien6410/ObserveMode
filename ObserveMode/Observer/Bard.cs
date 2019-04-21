using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveMode.Observer
{
    /// <summary>
    /// 吟遊詩人(ConcreteObserver) - 繼承冒險者
    /// </summary>
    public class Bard : Adventure
    {
        public Bard(string name) : base(name)
        {
            //表示使用 Adventure(string name);這個方法，並且用這邊的name帶入
        }

        /// <summary>
        /// "吟遊詩人"實際接到任務的反應(OnEventHandler 處理來自Subject的訊息)
        /// </summary>
        /// <param name="questions"></param>
        public override void GetQuestions(string questions)
        {
            if (questions.Length > 10)
            {
                Console.WriteLine(name + "：任務太難了，我只會唱歌跳舞，不接不接。");
            }
            else
            {
                Console.WriteLine(name + "：當街頭藝人太難賺了，偶爾也要解任務賺點錢的。");
            }
        }
    }
}
