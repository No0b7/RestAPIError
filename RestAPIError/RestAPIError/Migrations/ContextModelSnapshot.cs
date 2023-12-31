﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestAPIError.Database;

#nullable disable

namespace RestAPIError.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestAPIError.Model.CySeMainFeatures", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("communicatesAcrossNetworksId")
                        .HasColumnType("int");

                    b.Property<int>("computerId")
                        .HasColumnType("int");

                    b.Property<int>("localUserInterfaceId")
                        .HasColumnType("int");

                    b.Property<int>("logFilesSupportedId")
                        .HasColumnType("int");

                    b.Property<int>("multipleIPConnectionsId")
                        .HasColumnType("int");

                    b.Property<int>("networkConnectedId")
                        .HasColumnType("int");

                    b.Property<int>("networkLevelId")
                        .HasColumnType("int");

                    b.Property<int>("remoteUserInterfaceId")
                        .HasColumnType("int");

                    b.Property<int>("userAccountLockingAccordingToRequirementsId")
                        .HasColumnType("int");

                    b.Property<int>("userAccountsId")
                        .HasColumnType("int");

                    b.Property<int>("wirelessCommunicationId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("communicatesAcrossNetworksId");

                    b.HasIndex("computerId");

                    b.HasIndex("localUserInterfaceId");

                    b.HasIndex("logFilesSupportedId");

                    b.HasIndex("multipleIPConnectionsId");

                    b.HasIndex("networkConnectedId");

                    b.HasIndex("networkLevelId");

                    b.HasIndex("remoteUserInterfaceId");

                    b.HasIndex("userAccountLockingAccordingToRequirementsId");

                    b.HasIndex("userAccountsId");

                    b.HasIndex("wirelessCommunicationId");

                    b.ToTable("NIST_CySeMainFeatures");
                });

            modelBuilder.Entity("RestAPIError.Model.Option", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("NIST_Option");
                });

            modelBuilder.Entity("RestAPIError.Model.CySeMainFeatures", b =>
                {
                    b.HasOne("RestAPIError.Model.Option", "communicatesAcrossNetworks")
                        .WithMany()
                        .HasForeignKey("communicatesAcrossNetworksId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAPIError.Model.Option", "computer")
                        .WithMany()
                        .HasForeignKey("computerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAPIError.Model.Option", "localUserInterface")
                        .WithMany()
                        .HasForeignKey("localUserInterfaceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAPIError.Model.Option", "logFilesSupported")
                        .WithMany()
                        .HasForeignKey("logFilesSupportedId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAPIError.Model.Option", "multipleIPConnections")
                        .WithMany()
                        .HasForeignKey("multipleIPConnectionsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAPIError.Model.Option", "networkConnected")
                        .WithMany()
                        .HasForeignKey("networkConnectedId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAPIError.Model.Option", "networkLevel")
                        .WithMany()
                        .HasForeignKey("networkLevelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAPIError.Model.Option", "remoteUserInterface")
                        .WithMany()
                        .HasForeignKey("remoteUserInterfaceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAPIError.Model.Option", "userAccountLockingAccordingToRequirements")
                        .WithMany()
                        .HasForeignKey("userAccountLockingAccordingToRequirementsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAPIError.Model.Option", "userAccounts")
                        .WithMany()
                        .HasForeignKey("userAccountsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RestAPIError.Model.Option", "wirelessCommunication")
                        .WithMany()
                        .HasForeignKey("wirelessCommunicationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("communicatesAcrossNetworks");

                    b.Navigation("computer");

                    b.Navigation("localUserInterface");

                    b.Navigation("logFilesSupported");

                    b.Navigation("multipleIPConnections");

                    b.Navigation("networkConnected");

                    b.Navigation("networkLevel");

                    b.Navigation("remoteUserInterface");

                    b.Navigation("userAccountLockingAccordingToRequirements");

                    b.Navigation("userAccounts");

                    b.Navigation("wirelessCommunication");
                });
#pragma warning restore 612, 618
        }
    }
}
