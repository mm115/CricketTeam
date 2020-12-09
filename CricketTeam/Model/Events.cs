using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CricketTeam.Model
{
    public class Events
    {
        [Key]
        public int Event_Id { get; set; }// This is the primary key
        public string ICC_WTC { get; set; } // this is the ICC world test championship
        public string IPL { get; set; } // this is the IPL
        public string T20_WC { get; set; } // this is T20 world championship

        //foreign key


        public int Fixture_ID { get; set; }

        public Fixtures Fixture_obj { get; set; }





    }
}
