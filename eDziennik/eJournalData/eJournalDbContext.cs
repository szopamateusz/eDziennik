using System;
using eJournalData.Models;
using Microsoft.EntityFrameworkCore;

namespace eJournalData
{
    public class eJournalDbContext:DbContext
    {
        public eJournalDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
