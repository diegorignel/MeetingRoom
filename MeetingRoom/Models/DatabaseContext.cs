using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoom.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<MeetingRoom> MeetingRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Room>().HasKey(m => m.Id);
            builder.Entity<MeetingRoom>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
