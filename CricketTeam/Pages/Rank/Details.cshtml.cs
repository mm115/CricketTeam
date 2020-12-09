using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CricketTeam.Data;
using CricketTeam.Model;

namespace CricketTeam.Pages.Rank
{
    public class DetailsModel : PageModel
    {
        private readonly CricketTeam.Data.CricketTeamContext _context;

        public DetailsModel(CricketTeam.Data.CricketTeamContext context)
        {
            _context = context;
        }

        public Ranking Ranking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ranking = await _context.Ranking.FirstOrDefaultAsync(m => m.Ranking_Id == id);

            if (Ranking == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
