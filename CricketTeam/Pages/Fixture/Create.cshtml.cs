using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CricketTeam.Data;
using CricketTeam.Model;

namespace CricketTeam.Pages.Fixture
{
    public class CreateModel : PageModel
    {
        private readonly CricketTeam.Data.CricketTeamContext _context;

        public CreateModel(CricketTeam.Data.CricketTeamContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Fixtures Fixtures { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Fixtures.Add(Fixtures);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
