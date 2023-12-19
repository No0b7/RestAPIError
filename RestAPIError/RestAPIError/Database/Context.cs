
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Net;
using System;
using System.Collections.Generic;
using RestAPIError.Model;

namespace RestAPIError.Database
{
    public class Context : DbContext
    {
        private readonly IConfiguration _configuration;

        public Context(DbContextOptions<Context> options, IConfiguration configuration)
            : base(options)
        {
            this._configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region NIST

            #region CySeMainFeatures
            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.networkConnected)
            .WithMany()
            .HasForeignKey(x => x.networkConnectedId);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.networkLevel)
            .WithMany()
            .HasForeignKey(x => x.networkLevelId);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.computer)
            .WithMany()
            .HasForeignKey(x => x.computerId);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.localUserInterface)
            .WithMany()
            .HasForeignKey(x => x.localUserInterfaceId);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.remoteUserInterface)
            .WithMany()
            .HasForeignKey(x => x.remoteUserInterfaceId);
             
            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.userAccounts)
            .WithMany()
            .HasForeignKey(x => x.userAccountsId);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.wirelessCommunication)
            .WithMany()
            .HasForeignKey(x => x.wirelessCommunicationId);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.multipleIPConnections)
            .WithMany()
            .HasForeignKey(x => x.multipleIPConnectionsId);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.communicatesAcrossNetworks)
            .WithMany()
            .HasForeignKey(x => x.communicatesAcrossNetworksId);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.logFilesSupported)
            .WithMany()
            .HasForeignKey(x => x.logFilesSupportedId);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.userAccountLockingAccordingToRequirements)
            .WithMany()
            .HasForeignKey(x => x.userAccountLockingAccordingToRequirementsId);


            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.networkConnected)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.networkLevel)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.computer)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.localUserInterface)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.remoteUserInterface)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.userAccounts)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.wirelessCommunication)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.multipleIPConnections)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.communicatesAcrossNetworks)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.logFilesSupported)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CySeMainFeatures>()
            .HasOne(x => x.userAccountLockingAccordingToRequirements)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);



            #endregion CySeMainFeatures

            #endregion



            base.OnModelCreating(modelBuilder);
        }



        #region NIST
        public DbSet<Model.CySeMainFeatures> NIST_CySeMainFeatures { get; set; }
        public DbSet<Model.Option> NIST_Option { get; set; }
        #endregion NIST
    }
}
