using System;
using System.Collections.Generic;

namespace Tournament.Database.Models.DB
{
    public partial class Tournament
    {
        public Tournament()
        {
            Match = new HashSet<Match>();
        }

        public long TournamentId { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<Match> Match { get; set; }
    }
}
