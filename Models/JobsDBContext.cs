using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandologicReact.Models
{
    public class JobsDBContext : DbContext
    {
        public JobsDBContext(DbContextOptions options)
            :base(options)
        {

        }
        public JobsDBContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=data/jobs.db");
        public DbSet<LandingPage> Pages { get; set; }
        public DbSet<DailyJobs> Jobs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<LandingPage>().HasData(new LandingPage[]
            {
            // movies
            new LandingPage { Id = 1, Name = "xyz", Url = "https://xyz.com/MainPage"},
            new LandingPage { Id = 2, Name = "yyy", Url = "https://yyy.com/MainPage"},
            });
            var rows = new List<DailyJobs>();
            for (int i = 1; i < 25; i++)
            {
                rows.Add(new DailyJobs { Id = i, Date = new DateTime(2020, 5, i), LandingPageId = 1, ActiveJobs = 20+i, CumulativeViews = 40+i*2, CumulativeViewsPredicted = 60 + i * 2 });

            }
            for (int i = 25; i < 30; i++)
            {
                rows.Add(new DailyJobs { Id = i, Date = new DateTime(2020, 5, i), LandingPageId = 1, ActiveJobs = null, CumulativeViews = null, CumulativeViewsPredicted = 60 + i * 2 });

            }

            modelBuilder.Entity<DailyJobs>().HasData(rows);
 
            base.OnModelCreating(modelBuilder);
        }
    }
}
