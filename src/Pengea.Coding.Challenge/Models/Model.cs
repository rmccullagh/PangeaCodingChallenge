using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Pangea.Coding.Challenge.Models
{
    public class PangeaContext : DbContext
    {
        public PangeaContext(DbContextOptions<PangeaContext> options)
            : base(options)
        { }

        public DbSet<GitHubRepository> Repositories { get; set; }
    }
}
