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
            modelBuilder.Entity<DailyJobs>().HasData(new DailyJobs[]
             {
                        // movies
                        new DailyJobs { Id = 1,Date = new DateTime(2020,5,1), LandingPageId=1, ActiveJobs = 10, CumulativeViews = 99,CumulativeViewsPredicted  = 111},
                        new DailyJobs { Id = 2,Date = new DateTime(2020,5,2), LandingPageId=1, ActiveJobs = 22, CumulativeViews = 99,CumulativeViewsPredicted  = 111},
                        new DailyJobs { Id = 3,Date = new DateTime(2020,5,3), LandingPageId=1, ActiveJobs = 33, CumulativeViews = 99,CumulativeViewsPredicted  = 111},
                        new DailyJobs { Id = 4,Date = new DateTime(2020,5,4), LandingPageId=1, ActiveJobs = 44, CumulativeViews = 99,CumulativeViewsPredicted  = 111},
                        new DailyJobs { Id = 5,Date = new DateTime(2020,5,5), LandingPageId=1, ActiveJobs = 55, CumulativeViews = 99,CumulativeViewsPredicted  = 111},
                        new DailyJobs { Id = 6,Date = new DateTime(2020,5,6), LandingPageId=1, ActiveJobs = 66, CumulativeViews = 99,CumulativeViewsPredicted  = 111},
                        new DailyJobs { Id = 7,Date = new DateTime(2020,5,7), LandingPageId=1, ActiveJobs = 10, CumulativeViews = 99,CumulativeViewsPredicted  = 111},
                        new DailyJobs { Id = 8,Date = new DateTime(2020,5,8), LandingPageId=1, ActiveJobs = 22, CumulativeViews = 99,CumulativeViewsPredicted  = 111},
                        new DailyJobs { Id = 9,Date = new DateTime(2020,5,9), LandingPageId=1, ActiveJobs = null, CumulativeViews = null,CumulativeViewsPredicted  = 111},
                        new DailyJobs { Id = 10,Date = new DateTime(2020,5,10), LandingPageId=1, ActiveJobs = null, CumulativeViews = null,CumulativeViewsPredicted  = 111},
                        new DailyJobs { Id = 11,Date = new DateTime(2020,5,11), LandingPageId=1, ActiveJobs = null, CumulativeViews = null,CumulativeViewsPredicted  = 111},

             });

            base.OnModelCreating(modelBuilder);
        }
    }
}
