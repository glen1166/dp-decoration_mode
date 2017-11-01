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
            SchoolReport report = new SugarFouthGradeSchoolReport();
            report.report();
            report.sign("老三");
        }
    }
}
