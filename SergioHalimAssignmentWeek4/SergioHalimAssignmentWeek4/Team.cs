using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergioHalimAssignmentWeek4
{
    internal class Team
    {
        public Team(string teamName, string teamCountry, string teamCity) { 
            this.teamName= teamName;
            this.teamCountry= teamCountry;
            this.teamCity= teamCity;
        }
        public string teamName { get; set; }
        public string teamCountry { get; set; }
        public string teamCity { get; set; }
        public List<Player> playerList { get; set; }
        
    }
}
