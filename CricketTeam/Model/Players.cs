using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CricketTeam.Model
{
    public class Players
    {
        [Key]
        public int Player_Id { get; set; } // This is the primary key

        public string Player_Name { get; set; } // this is the name

        public string Player_Address { get; set; } // this is the address

        public string Player_Mobile { get; set; } // this is mobile number

        public string Player_Email { get; set; } // this is email id

        public string Player_Age { get; set; } // age of the player


    }
}
