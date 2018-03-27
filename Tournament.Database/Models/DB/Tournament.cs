using System;
using System.Collections.Generic;

namespace Tournament.DAO
{
    public partial class Tournament :BaseEntity
    {
        public Tournament()
        {
            Match = new HashSet<Match>();
        }

        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<Match> Match { get; set; }
    }
}
