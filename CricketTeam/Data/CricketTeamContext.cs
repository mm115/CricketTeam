using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CricketTeam.Model;

namespace CricketTeam.Data
{
    public class CricketTeamContext : DbContext
    {
        public CricketTeamContext (DbContextOptions<CricketTeamContext> options)
            : base(options)
        {
        }

        public DbSet<CricketTeam.Model.Players> Players { get; set; }

        public DbSet<CricketTeam.Model.Ranking> Ranking { get; set; }

        public DbSet<CricketTeam.Model.Fixtures> Fixtures { get; set; }

        public DbSet<CricketTeam.Model.Events> Events { get; set; }
    }
}
