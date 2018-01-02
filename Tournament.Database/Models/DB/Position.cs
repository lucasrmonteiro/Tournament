using System;
using System.Collections.Generic;

namespace Tournament.Database.Models.DB
{
    public partial class Position
    {
        public Position()
        {
            Player = new HashSet<Player>();
        }

        public long IdPosition { get; set; }
        public string NamePosition { get; set; }

        public ICollection<Player> Player { get; set; }
    }
}
