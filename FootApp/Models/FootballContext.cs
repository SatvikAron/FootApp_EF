using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootApp.Models
{
     public class FootballContext :DbContext
    {
        public DbSet<Arena> Arenas{ get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
