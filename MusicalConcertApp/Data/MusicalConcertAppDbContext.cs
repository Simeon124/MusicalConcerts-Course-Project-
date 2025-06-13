using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MusicalConcertAppDbContext : DbContext
    {
        public MusicalConcertAppDbContext()
        {
        }

        public virtual DbSet<Concert> Concerts { get; set; }
        public virtual DbSet<ConcertUsers> ConcertUsers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserConcerts> UserConcerts { get; set; }

        public MusicalConcertAppDbContext(DbContextOptions<MusicalConcertAppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Server=DESKTOP-M71SG0B\\SQLEXPRESS;Database=MusicAppDB;Trusted_Connection=True;  Encrypt=false;");

    }
}
