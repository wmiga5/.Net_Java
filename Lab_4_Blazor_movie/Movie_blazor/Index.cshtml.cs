using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Movie_blazor.Components.Movies;
using Movie_blazor.Data;

namespace Movie_blazor
{
    public class IndexModel : PageModel
    {
        private readonly Movie_blazor.Data.ApplicationDbContext _context;

        public IndexModel(Movie_blazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
