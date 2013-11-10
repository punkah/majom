using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backgammon
{
    class Field
    {
        private Int32 pieces = 0;
        private PlayerType type;
        public Field();
        public void StepFrom(PlayerType Type);
        public Boolean StepTo(PlayerType Type);
        public Boolean ValidateStepFrom(PlayerType Type);
        public Boolean ValidateStepTo(PlayerType Type);

    }
}
