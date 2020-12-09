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
    public class DeleteModel : PageModel
    {
        private readonly CricketTeam.Data.CricketTeamContext _context;

        public DeleteModel(CricketTeam.Data.CricketTeamContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Fixtures Fixtures { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fixtures = await _context.Fixtures.FirstOrDefaultAsync(m => m.Fixture_Id == id);

            if (Fixtures == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fixtures = await _context.Fixtures.FindAsync(id);

            if (Fixtures != null)
            {
                _context.Fixtures.Remove(Fixtures);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
