using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backgammon
{
    class Step
    {
        private Int32 from;
        private Int32 to;

        public Step(Int32 iFrom, Int32 iTo)
        {
            from = iFrom;
            to = iTo;
        }

        public Int32 From { get { return from; } }
        public Int32 To { get { return to; } }
    }
}
//bazzzzzzzzzzzzzzzzzzzzzzzz