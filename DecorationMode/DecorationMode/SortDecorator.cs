using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationMode
{
    public class SortDecorator : Decorator
    {
        public SortDecorator(SchoolReport sr) : base(sr)
        {

        }

        private void reportSort()
        {
            Console.WriteLine("我是排名第38名...");
        }

        override public void report()
        {
            base.report();
            this.reportSort();
        }
    }
}
