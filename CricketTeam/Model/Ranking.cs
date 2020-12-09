using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CricketTeam.Model
{
    public class Ranking
    {
        [Key]
        public int Ranking_Id { get; set; } // This is the primary key
        public string Player_Name { get; set; } // each player name
        public string Test { get; set; } // this is test ranking
        public string ODI { get; set; } // this is ODI ranking
        public string T20 { get; set; } // this is T20 ranking

        // Foreign Key



        public int Player_ID { get; set; }

        public Players Player_obj { get; set; }

    }
}
