using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserveMode.Observer
{
    /// <summary>
    /// 槍兵(ConcreteObserver) - 繼承冒險者(Observer)
    /// </summary>
    public class Lancer : Adventure
    {
        public Lancer(string name) : base(name)
        {
            //表示使用 Adventure(string name);這個方法，並且用這邊的name帶入
        }

        /// <summary>
        /// "槍兵"實際接到任務的反應(OnEventHandler 處理來自Subject的訊息)
        /// </summary>
        /// <param name="questions"></param>
        public override void GetQuestions(string questions)
        {
            Console.WriteLine(name + "：任務來就接，沒在怕的。");
        }
    }
}
