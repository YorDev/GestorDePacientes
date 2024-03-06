using GestorDePacientes.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDePacientes.Infrastructure.Persistence.Contexts
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {
        }

        public DbSet<Core.Domain.Entities.User> Users { get; set; }
        public DbSet<Core.Domain.Entities.Doctor> Doctors { get; set; }
        public DbSet<Core.Domain.Entities.Patient> Patients { get; set; }
        public DbSet<Core.Domain.Entities.Test> tests { get; set; }
        public DbSet<Core.Domain.Entities.Date> Dates { get; set; }
        public DbSet<Core.Domain.Entities.Result> Results { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tables
            //User
            modelBuilder.Entity<Core.Domain.Entities.User>().ToTable("User");
            //Doctor
            modelBuilder.Entity<Core.Domain.Entities.Doctor>().ToTable("Doctor");
            //Patient
            modelBuilder.Entity<Core.Domain.Entities.Patient>().ToTable("Patient");
            //Test
            modelBuilder.Entity<Core.Domain.Entities.Test>().ToTable("Test");
            //Date
            modelBuilder.Entity<Core.Domain.Entities.Date>().ToTable("Date");
            //Result
            modelBuilder.Entity<Core.Domain.Entities.Result>().ToTable("Result");
            #endregion

            #region primaryKeys
            //User
            modelBuilder.Entity<Core.Domain.Entities.User>().HasKey(u => u.Id);
            //Doctor
            modelBuilder.Entity<Core.Domain.Entities.Doctor>().HasKey(d => d.Id);
            //Patient
            modelBuilder.Entity<Core.Domain.Entities.Patient>().HasKey(p => p.Id);
            //Test
            modelBuilder.Entity<Core.Domain.Entities.Test>().HasKey(t => t.Id);
            //Date
            modelBuilder.Entity<Core.Domain.Entities.Date>().HasKey(d => d.Id);
            //Result
            modelBuilder.Entity<Core.Domain.Entities.Result>().HasKey(r => r.Id);
            #endregion

            #region Relationships
            #endregion
        }
    }
}
