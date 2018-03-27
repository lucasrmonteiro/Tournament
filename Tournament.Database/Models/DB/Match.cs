using System;
using System.Collections.Generic;

namespace Tournament.DAO
{
    public partial class Match : BaseEntity
    {
        public long? TournamentId { get; set; }
        public int? RoundNum { get; set; }
        public long? Team1 { get; set; }
        public long? Team2 { get; set; }
        public bool? IsFinal { get; set; }
        public long? Winner { get; set; }

        public Team Team1Navigation { get; set; }
        public Team Team2Navigation { get; set; }
        public Tournament Tournament { get; set; }
        public Team WinnerNavigation { get; set; }
    }
}
