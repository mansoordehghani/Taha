using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions Options) : base(Options)
        {

        }
        public DbSet<SAstatus>Status{get; set;}
    
         protected override void OnModelCreating(ModelBuilder builder)
         {
           builder.Entity<SAstatus>()
           .HasData(
           new SAstatus{Id=1,SADesc="عام"},
           new SAstatus{Id=2,SADesc="سادات"}
            );
         }
    }
}