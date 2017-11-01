using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationMode
{
    public abstract class Decorator : SchoolReport
    {
        private SchoolReport sr;
        public Decorator(SchoolReport sr)
        {
            this.sr = sr;
        }

        override public void report()
        {
            this.sr.report();
        }

        public override void sign(string name)
        {
            this.sr.sign(name);
        }
    }
}
