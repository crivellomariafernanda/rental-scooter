﻿using Microsoft.EntityFrameworkCore;

namespace rental_scooter.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Scooter> Scooters { get; set; } = null!;
        public DbSet<Station> Stations { get; set; } = null!;
        public DbSet<RentalHistoryEntry> RentalHistoryEntries{ get; set; } = null!;

    }
}