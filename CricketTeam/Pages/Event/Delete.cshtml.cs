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
    public class DeleteModel : PageModel
    {
        private readonly CricketTeam.Data.CricketTeamContext _context;

        public DeleteModel(CricketTeam.Data.CricketTeamContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Events = await _context.Events.FindAsync(id);

            if (Events != null)
            {
                _context.Events.Remove(Events);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
