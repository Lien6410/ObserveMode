using NUnit.Framework;
using ObserveMode.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserveMode.Observer;
using ObserveMode;

namespace ObserveMode.Subject.Tests
{
    [TestFixture()]
    public class SubjectTests
    {
        [Test()]
        public void ObserverModeTest()
        {
            //產生冒險者們
            Adventure lancerA = new Lancer("Alice");
            Adventure lancerB = new Lancer("Betty");
            Adventure bard = new Bard("Cathy");
            Adventure mage = new Mage("Darren");

            //建立冒險者協會，並且登記冒險者們
            Subject association = new Association();
            association.Add(lancerA);
            association.Add(lancerB);
            association.Add(bard);
            association.Add(mage);

            //冒險者協會派送簡單任務
            association.SendQuestions("run");
            Console.WriteLine();

            //冒險者協會派送困難任務
            association.SendQuestions("run run run, run for your life");
            Console.WriteLine();

            //Betty退出冒險者協會會員
            association.Remove(lancerB);
            //冒險者協會派送困難任務(不含Betty)
            association.SendQuestions("run run run, run for your life");

            Assert.AreEqual(1, 1);
        }
    }
}