using System;
using System.Collections.Generic;

namespace Tournament.Database.Models.DB
{
    public partial class Player
    {
        public long PlayerId { get; set; }
        public long? TeamId { get; set; }
        public long? IdPosition { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Genre { get; set; }

        public Position IdPositionNavigation { get; set; }
        public Team Team { get; set; }
    }
}
