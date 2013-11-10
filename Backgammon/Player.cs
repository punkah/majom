using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backgammon
{
    class Player
    {
        private PlayerType type;
        public Player(PlayerType iType)
        {
            type = iType;
        }
        public List<Step> DoStep(Board Board, Int32[] Roll);
    }
}
