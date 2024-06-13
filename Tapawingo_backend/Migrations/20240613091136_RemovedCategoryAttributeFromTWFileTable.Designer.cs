﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tapawingo_backend.Data;

#nullable disable

namespace Tapawingo_backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240613091136_RemovedCategoryAttributeFromTWFileTable")]
    partial class RemovedCategoryAttributeFromTWFileTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("ConfirmByUser")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("DestinationType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("HideForUser")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Latitude")
                        .HasColumnType("double");

                    b.Property<double>("Longitude")
                        .HasColumnType("double");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Radius")
                        .HasColumnType("int");

                    b.Property<int>("RoutepartId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoutepartId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Editions");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Locationlog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Latitude")
                        .HasColumnType("double");

                    b.Property<double>("Longitude")
                        .HasColumnType("double");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Locationlogs");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Organisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Organisations");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Routepart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Final")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("RouteId")
                        .HasColumnType("int");

                    b.Property<string>("RouteType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("RoutepartFullscreen")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("RoutepartZoom")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.ToTable("Routeparts");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.TWFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("File")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RoutepartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("RoutepartId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.TWRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EditionId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Online")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("EditionId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.TeamRoutepart", b =>
                {
                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("RoutepartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CompletedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsFinished")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("TeamId", "RoutepartId");

                    b.HasIndex("RoutepartId");

                    b.ToTable("TeamRouteparts");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RefreshTokenExpiry")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Tapawingo_backend.Models.UserEvent", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("UserEvents");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.UserOrganisation", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "OrganisationId");

                    b.HasIndex("OrganisationId");

                    b.ToTable("UserOrganisations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tapawingo_backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Destination", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.Routepart", "Routepart")
                        .WithMany("Destinations")
                        .HasForeignKey("RoutepartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Routepart");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Edition", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.Event", "Event")
                        .WithMany("Editions")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Event", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.Organisation", "Organisation")
                        .WithMany("Events")
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organisation");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Locationlog", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.Team", "Team")
                        .WithMany("Locationlogs")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Routepart", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.TWRoute", "Route")
                        .WithMany("Routeparts")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Route");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.TWFile", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.Routepart", "Routepart")
                        .WithMany("Files")
                        .HasForeignKey("RoutepartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Routepart");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.TWRoute", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.Edition", "Edition")
                        .WithMany("Routes")
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Team", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.Edition", "Edition")
                        .WithMany("Teams")
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.TeamRoutepart", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.Routepart", "Routepart")
                        .WithMany("TeamRouteparts")
                        .HasForeignKey("RoutepartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tapawingo_backend.Models.Team", "Team")
                        .WithMany("TeamRouteparts")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Routepart");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.UserEvent", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.Event", "Event")
                        .WithMany("Users")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tapawingo_backend.Models.User", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.UserOrganisation", b =>
                {
                    b.HasOne("Tapawingo_backend.Models.Organisation", "Organisation")
                        .WithMany("Users")
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tapawingo_backend.Models.User", "User")
                        .WithMany("Organisations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organisation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Edition", b =>
                {
                    b.Navigation("Routes");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Event", b =>
                {
                    b.Navigation("Editions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Organisation", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Routepart", b =>
                {
                    b.Navigation("Destinations");

                    b.Navigation("Files");

                    b.Navigation("TeamRouteparts");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.TWRoute", b =>
                {
                    b.Navigation("Routeparts");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.Team", b =>
                {
                    b.Navigation("Locationlogs");

                    b.Navigation("TeamRouteparts");
                });

            modelBuilder.Entity("Tapawingo_backend.Models.User", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Organisations");
                });
#pragma warning restore 612, 618
        }
    }
}
