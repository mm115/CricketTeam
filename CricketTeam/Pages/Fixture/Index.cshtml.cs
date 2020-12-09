using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CricketTeam.Data;
using CricketTeam.Model;

namespace CricketTeam.Pages.Fixture
{
    public class IndexModel : PageModel
    {
        private readonly CricketTeam.Data.CricketTeamContext _context;

        public IndexModel(CricketTeam.Data.CricketTeamContext context)
        {
            _context = context;
        }

        public IList<Fixtures> Fixtures { get;set; }

        public async Task OnGetAsync()
        {
            Fixtures = await _context.Fixtures.ToListAsync();
        }
    }
}
