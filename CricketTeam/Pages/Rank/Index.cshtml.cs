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
    public class IndexModel : PageModel
    {
        private readonly CricketTeam.Data.CricketTeamContext _context;

        public IndexModel(CricketTeam.Data.CricketTeamContext context)
        {
            _context = context;
        }

        public IList<Ranking> Ranking { get;set; }

        public async Task OnGetAsync()
        {
            Ranking = await _context.Ranking.ToListAsync();
        }
    }
}
