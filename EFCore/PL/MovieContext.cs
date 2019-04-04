﻿using EFCore.PL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
namespace ExercicioEFCoreCodeFirst
{
    public class MovieContext : DbContext
    {
        public static readonly LoggerFactory FabricaLogger = new LoggerFactory(new[] { new
ConsoleLoggerProvider((_, __) => true, true) });
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorMovie> Characters { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            //.UseLoggerFactory(FabricaLogger)
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DBMovieCF;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure composite primary key
            modelBuilder.Entity<ActorMovie>().HasKey(s => new { s.ActorId, s.MovieId });
        }
    }
}