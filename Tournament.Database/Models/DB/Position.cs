using System;
using System.Collections.Generic;

namespace Tournament.DAO
{
    public partial class Position : BaseEntity
    {
        public Position()
        {
            Player = new HashSet<Player>();
        }

        public string NamePosition { get; set; }

        public ICollection<Player> Player { get; set; }
    }
}
