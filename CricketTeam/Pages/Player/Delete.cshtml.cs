using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CricketTeam.Data;
using CricketTeam.Model;

namespace CricketTeam.Pages.Player
{
    public class DeleteModel : PageModel
    {
        private readonly CricketTeam.Data.CricketTeamContext _context;

        public DeleteModel(CricketTeam.Data.CricketTeamContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Players Players { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Players = await _context.Players.FirstOrDefaultAsync(m => m.Player_Id == id);

            if (Players == null)
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

            Players = await _context.Players.FindAsync(id);

            if (Players != null)
            {
                _context.Players.Remove(Players);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
