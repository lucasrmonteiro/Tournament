using System;
using System.Collections.Generic;

namespace Tournament.DAO
{
    public partial class Team :BaseEntity
    {
        public Team()
        {
            MatchTeam1Navigation = new HashSet<Match>();
            MatchTeam2Navigation = new HashSet<Match>();
            MatchWinnerNavigation = new HashSet<Match>();
            Player = new HashSet<Player>();
        }

        public string Name { get; set; }

        public ICollection<Match> MatchTeam1Navigation { get; set; }
        public ICollection<Match> MatchTeam2Navigation { get; set; }
        public ICollection<Match> MatchWinnerNavigation { get; set; }
        public ICollection<Player> Player { get; set; }
    }
}
