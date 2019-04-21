using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveMode.Observer
{
    /// <summary>
    /// 魔法師(ConcreteObserver) - 繼承冒險者
    /// </summary>
    public class Mage : Adventure
    {
        public Mage(string name) : base(name)
        {
            //表示使用 Adventure(string name);這個方法，並且用這邊的name帶入
        }

        /// <summary>
        /// "魔法師"實際接到任務的反應(OnEventHandler 處理來自Subject的訊息)
        /// </summary>
        /// <param name="questions"></param>
        public override void GetQuestions(string questions)
        {
            if (questions.Length < 10)
            {
                Console.WriteLine(name + "：任務太簡單了，我不想理他。");
            }
            else
            {
                Console.WriteLine(name + "：天靈靈地靈靈，看我大顯神威賺獎金去啦！");
            }
        }
    }
}
