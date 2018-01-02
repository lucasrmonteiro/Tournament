using System;
using System.Collections.Generic;

namespace Tournament.Database.Models.DB
{
    public partial class Team
    {
        public Team()
        {
            MatchTeam1Navigation = new HashSet<Match>();
            MatchTeam2Navigation = new HashSet<Match>();
            MatchWinnerNavigation = new HashSet<Match>();
            Player = new HashSet<Player>();
        }

        public long TeamId { get; set; }
        public string Name { get; set; }

        public ICollection<Match> MatchTeam1Navigation { get; set; }
        public ICollection<Match> MatchTeam2Navigation { get; set; }
        public ICollection<Match> MatchWinnerNavigation { get; set; }
        public ICollection<Player> Player { get; set; }
    }
}
