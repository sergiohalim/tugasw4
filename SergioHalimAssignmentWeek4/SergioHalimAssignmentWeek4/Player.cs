using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergioHalimAssignmentWeek4
{
    internal class Player
    {
        public Player(string playerName, string playerNum, string playerPos) { 
            this.playerName= playerName;
            this.playerNum= playerNum;
            this.playerPos= playerPos;
        }
        public string playerName { get; set; }
        public string playerNum { get; set; }
        public string playerPos { get; set; }
    }
}
