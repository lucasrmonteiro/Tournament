using System;
using System.Collections.Generic;
using System.Text;
using Tournament.DAO.Interface;

namespace Tournament.DAO.Repository
{
    public class TeamRepository : GenericRepository<Team> ,ITeamRepository
    {
        public TeamRepository(DB_Torneio_DEVContext dbContext)
     : base(dbContext)
        {

        }
    }
}
