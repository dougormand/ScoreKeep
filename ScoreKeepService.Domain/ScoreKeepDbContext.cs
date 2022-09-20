using Microsoft.EntityFrameworkCore;
using ScoreKeepService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeepService.Domain
{
    public class ScoreKeepDbContext : DbContext
    {

        private readonly string _connectionString = @"Server=(localdb)\mssqllocaldb;Database=ScoreKeep";

        //public ScoreKeepDbContext(DbContextOptions<ScoreKeepDbContext> options) : base(options) { }


        public ScoreKeepDbContext()
        {
            //var contextOptions = new DbContextOptionsBuilder<ScoreKeepDbContext>()
            //                        .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test")
            //                        .Options;
            
            //using var context = new ScoreKeepDbContext(contextOptions);
        }

        //protected override void onconfiguring(DbContextOptionsBuilder optionsbuilder)
        //{
        //    optionsbuilder.usesqlserver(_connectionString);
        //    //base.onconfiguring(optionsbuilder);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Stat> Stats { get; set; }
    }
}
