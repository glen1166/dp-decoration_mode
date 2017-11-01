using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationMode
{
    public class SugarFouthGradeSchoolReport : FouthGradeSchoolReport
    {
        private void reportHighScore()
        {
            Console.WriteLine("这次考试语文最高是75，数学是78，自然是80");
        }

        private void reportSort()
        {
            Console.WriteLine("我是排名第38名...");
        }

        public void report()
        {
            this.reportHighScore();
            base.report();
            this.reportSort();
        }
    }
}
