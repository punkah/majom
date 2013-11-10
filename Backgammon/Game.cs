using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backgammon
{
    class Game
    {
        private Board Board = new Board();
        private Player[] Players = new Player[2];
        //validalni: jo iranyba lep? dobasnak megfelelo?
        public Int32 Step(List<Step> ListOfSteps, PlayerType Type, Int32[] Roll);
        public Int32 RunGame();
        public Int32[] Roll();

        static void Main(String[] args)
        {
            Console.Read();
        }
    }
}
//makimajom