using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationMode
{
    public class HighScoreDecorator : Decorator
    {
        public HighScoreDecorator(SchoolReport sr) : base(sr)
        {

        }

        private void reportHighScore()
        {
            Console.WriteLine("这次考试语文最高是75，数学是78，自然是80");
        }

        override public void report()
        {
            this.reportHighScore();
            base.report();
        }
    }
}
