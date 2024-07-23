﻿// <auto-generated />
using System;
using BlazorResortManager1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorResortManager1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240723070235_quick-fix2")]
    partial class quickfix2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorResortManager1.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.camera.Camera", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("camera");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.camera.CameraLiftBinding", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("cameraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("liftId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("cameraId");

                    b.HasIndex("liftId");

                    b.ToTable("cameraLiftBinding");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.camera.CameraResortBinding", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("cameraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("resortId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("cameraId");

                    b.HasIndex("resortId");

                    b.ToTable("cameraResortBinding");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.camera.CameraTrackBinding", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("cameraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("trackId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("cameraId");

                    b.HasIndex("trackId");

                    b.ToTable("cameraTrackBinding");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.forecast.YrNoCityCode", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("cityName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("yrNoCityCode");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.Lift", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("capacityPerSeat")
                        .HasColumnType("int");

                    b.Property<int>("estimatedDurationTimeMinutes")
                        .HasColumnType("int");

                    b.Property<int>("lengthMeters")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("peoplePerHour")
                        .HasColumnType("int");

                    b.Property<Guid>("resortId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("id");

                    b.HasIndex("resortId");

                    b.ToTable("lift");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.LiftParameter", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("liftId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("liftId");

                    b.ToTable("liftParameter");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.Resort", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("webpage")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<Guid?>("yrNoCityCodeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("yrNoCityCodeId");

                    b.ToTable("resort");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.ResortParameter", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("resortId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("resortId");

                    b.ToTable("resortParameter");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.Track", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("difficulty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("illuminated")
                        .HasColumnType("bit");

                    b.Property<int>("inclination")
                        .HasColumnType("int");

                    b.Property<int>("lengthMeters")
                        .HasColumnType("int");

                    b.Property<string>("marking")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<Guid>("resortId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("snowGroomed")
                        .HasColumnType("bit");

                    b.Property<int>("totalHeightMeters")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("resortId");

                    b.ToTable("track");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.TrackParameter", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("trackId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("trackId");

                    b.ToTable("trackParameter");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.status.LiftStatus", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("opened")
                        .HasColumnType("bit");

                    b.Property<Guid>("parentLiftId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("statusSheetId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("parentLiftId");

                    b.HasIndex("statusSheetId");

                    b.ToTable("liftStatus");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.status.ResortStatus", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("opened")
                        .HasColumnType("bit");

                    b.Property<Guid>("parentResortId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("statusSheetId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("parentResortId");

                    b.HasIndex("statusSheetId")
                        .IsUnique();

                    b.ToTable("resortStatus");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.status.StatusSheet", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("productionVersion")
                        .HasColumnType("bit");

                    b.Property<Guid>("resortId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("resortId");

                    b.ToTable("statusSheet");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.status.TrackStatus", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeOnly>("closingTime")
                        .HasColumnType("time");

                    b.Property<bool>("opened")
                        .HasColumnType("bit");

                    b.Property<TimeOnly>("openingTime")
                        .HasColumnType("time");

                    b.Property<Guid>("parentTrackId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("snowCover")
                        .HasColumnType("int");

                    b.Property<Guid>("statusSheetId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("parentTrackId");

                    b.HasIndex("statusSheetId");

                    b.ToTable("trackStatus");
                });

            modelBuilder.Entity("BlazorResortManager1.user.Permit", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("resortId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("resortId");

                    b.HasIndex("userId");

                    b.ToTable("permit");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.camera.CameraLiftBinding", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.camera.Camera", "camera")
                        .WithMany("liftBindings")
                        .HasForeignKey("cameraId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BlazorResortManager1.Data.Models.main.Lift", "lift")
                        .WithMany("cameras")
                        .HasForeignKey("liftId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("camera");

                    b.Navigation("lift");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.camera.CameraResortBinding", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.camera.Camera", "camera")
                        .WithMany("resortBindings")
                        .HasForeignKey("cameraId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BlazorResortManager1.Data.Models.main.Resort", "resort")
                        .WithMany("cameras")
                        .HasForeignKey("resortId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("camera");

                    b.Navigation("resort");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.camera.CameraTrackBinding", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.camera.Camera", "camera")
                        .WithMany("trackBindings")
                        .HasForeignKey("cameraId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BlazorResortManager1.Data.Models.main.Track", "track")
                        .WithMany("cameras")
                        .HasForeignKey("trackId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("camera");

                    b.Navigation("track");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.Lift", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.main.Resort", "resort")
                        .WithMany("lifts")
                        .HasForeignKey("resortId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("resort");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.LiftParameter", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.main.Lift", "lift")
                        .WithMany("parameters")
                        .HasForeignKey("liftId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("lift");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.Resort", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.forecast.YrNoCityCode", "yrNoCityCode")
                        .WithMany("resorts")
                        .HasForeignKey("yrNoCityCodeId");

                    b.Navigation("yrNoCityCode");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.ResortParameter", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.main.Resort", "resort")
                        .WithMany("resortParameters")
                        .HasForeignKey("resortId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("resort");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.Track", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.main.Resort", "resort")
                        .WithMany("tracks")
                        .HasForeignKey("resortId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("resort");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.TrackParameter", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.main.Track", "track")
                        .WithMany("parameters")
                        .HasForeignKey("trackId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("track");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.status.LiftStatus", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.main.Lift", "parentLift")
                        .WithMany("statuses")
                        .HasForeignKey("parentLiftId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BlazorResortManager1.Data.Models.status.StatusSheet", "statusSheet")
                        .WithMany("liftStatuses")
                        .HasForeignKey("statusSheetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("parentLift");

                    b.Navigation("statusSheet");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.status.ResortStatus", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.main.Resort", "parentResort")
                        .WithMany("statuses")
                        .HasForeignKey("parentResortId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BlazorResortManager1.Data.Models.status.StatusSheet", "statusSheet")
                        .WithOne("resortStatus")
                        .HasForeignKey("BlazorResortManager1.Data.Models.status.ResortStatus", "statusSheetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("parentResort");

                    b.Navigation("statusSheet");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.status.StatusSheet", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.main.Resort", "resort")
                        .WithMany("statusSheets")
                        .HasForeignKey("resortId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("resort");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.status.TrackStatus", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.main.Track", "parentTrack")
                        .WithMany("statuses")
                        .HasForeignKey("parentTrackId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BlazorResortManager1.Data.Models.status.StatusSheet", "statusSheet")
                        .WithMany("trackStatuses")
                        .HasForeignKey("statusSheetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("parentTrack");

                    b.Navigation("statusSheet");
                });

            modelBuilder.Entity("BlazorResortManager1.user.Permit", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.Models.main.Resort", "resort")
                        .WithMany("permits")
                        .HasForeignKey("resortId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BlazorResortManager1.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("permits")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("resort");
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
                    b.HasOne("BlazorResortManager1.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.ApplicationUser", null)
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

                    b.HasOne("BlazorResortManager1.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BlazorResortManager1.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorResortManager1.Data.ApplicationUser", b =>
                {
                    b.Navigation("permits");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.camera.Camera", b =>
                {
                    b.Navigation("liftBindings");

                    b.Navigation("resortBindings");

                    b.Navigation("trackBindings");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.forecast.YrNoCityCode", b =>
                {
                    b.Navigation("resorts");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.Lift", b =>
                {
                    b.Navigation("cameras");

                    b.Navigation("parameters");

                    b.Navigation("statuses");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.Resort", b =>
                {
                    b.Navigation("cameras");

                    b.Navigation("lifts");

                    b.Navigation("permits");

                    b.Navigation("resortParameters");

                    b.Navigation("statusSheets");

                    b.Navigation("statuses");

                    b.Navigation("tracks");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.main.Track", b =>
                {
                    b.Navigation("cameras");

                    b.Navigation("parameters");

                    b.Navigation("statuses");
                });

            modelBuilder.Entity("BlazorResortManager1.Data.Models.status.StatusSheet", b =>
                {
                    b.Navigation("liftStatuses");

                    b.Navigation("resortStatus");

                    b.Navigation("trackStatuses");
                });
#pragma warning restore 612, 618
        }
    }
}
