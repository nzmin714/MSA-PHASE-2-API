using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BananaPeelrAPI.Models
{
    public class ApplicationDatabase : DbContext
    {
        public ApplicationDatabase(DbContextOptions<ApplicationDatabase> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public object Playlist { get; internal set; }
    }
}
