using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backgammon
{
    class Board
    {
        private Field[] Fields;
        private Field[] finishFields;
        private Field[] hitFields;
        public Board()
        {
            Fields = new Field[24];
            finishFields = new Field[2];
            hitFields = new Field[2];
        }
        public Boolean ValidateSteps(List<Step> ListOfSteps, PlayerType Type);
        public Boolean Step(Step Step, PlayerType Type);
        public Boolean IsFinished(PlayerType Type);

    }
}
