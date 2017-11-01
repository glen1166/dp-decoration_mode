using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationMode
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolReport sr;
            sr = new FouthGradeSchoolReport();
            sr = new HighScoreDecorator(sr);
            sr = new SortDecorator(sr);
            sr.report();
            sr.sign("老三");
        }
    }
}
