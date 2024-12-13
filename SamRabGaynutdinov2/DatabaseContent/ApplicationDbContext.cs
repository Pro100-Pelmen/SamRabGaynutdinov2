using Microsoft.EntityFrameworkCore;
using SamRabGaynutdinov2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamRabGaynutdinov2.DatabaseContent;

public class ApplicationDbContext : DbContext
{
    public DbSet<TrainingEntity> Trainings { get; set; } = null!;

    public ApplicationDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TrainingEntity>(trainnigsConfiguraion =>
        {
            trainnigsConfiguraion.HasKey(x => x.Id);
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string dbPath = Path.Combine(FileSystem.Current.AppDataDirectory, "TrainingApp.db");
        optionsBuilder.UseSqlite($"Filename={dbPath}");
    }
}
