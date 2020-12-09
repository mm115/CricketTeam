using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CricketTeam.Data;
using CricketTeam.Model;

namespace CricketTeam.Pages.Fixture
{
    public class EditModel : PageModel
    {
        private readonly CricketTeam.Data.CricketTeamContext _context;

        public EditModel(CricketTeam.Data.CricketTeamContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Fixtures).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FixturesExists(Fixtures.Fixture_Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FixturesExists(int id)
        {
            return _context.Fixtures.Any(e => e.Fixture_Id == id);
        }
    }
}
