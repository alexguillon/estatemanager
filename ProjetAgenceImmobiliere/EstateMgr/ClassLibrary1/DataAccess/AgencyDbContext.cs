﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstateMgrCore.DataAccess
{
    public class AgencyDbContext : DbContext
    {

        #region Singleton

        private static AgencyDbContext _context = null;
        public async static Task<AgencyDbContext> GetCurrent()
        {
            if (_context == null)
            {
                _context = new AgencyDbContext
                    (
                        Path.Combine
                        (
                            System.AppDomain.CurrentDomain.BaseDirectory,
                            "agency.db"
                        )
                    );
                await _context.Database.MigrateAsync();
            }
            return _context;
        }

        #endregion

        public string DatabasePath { get; }

        public DbSet<Models.Estate> Estates { get; set; }

        private AgencyDbContext(string databasePath)
        {
            DatabasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Estate>().HasOne(e => e.Referent)
                                                .WithMany(p => p.Estates);
        }
    }
}