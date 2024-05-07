using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movie_blazor.Components.Movies;

namespace Movie_blazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Movie_blazor.Components.Movies.Movie> Movie { get; set; } = default!;
    }
}
