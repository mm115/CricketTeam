using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CricketTeam.Data;
using CricketTeam.Model;

namespace CricketTeam.Pages.Event
{
    public class DetailsModel : PageModel
    {
        private readonly CricketTeam.Data.CricketTeamContext _context;

        public DetailsModel(CricketTeam.Data.CricketTeamContext context)
        {
            _context = context;
        }

        public Events Events { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Events = await _context.Events.FirstOrDefaultAsync(m => m.Event_Id == id);

            if (Events == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
