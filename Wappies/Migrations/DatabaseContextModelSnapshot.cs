﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Wappies.Context;

namespace Wappies.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wappies.Models.Administrator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("LastLogin");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("Wappies.Models.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<int>("ReportID");

                    b.HasKey("ID");

                    b.HasIndex("ReportID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Wappies.Models.Report", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Completed");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Updated");

                    b.HasKey("ID");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Wappies.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PhoneNumber");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Wappies.Models.Location", b =>
                {
                    b.HasOne("Wappies.Models.Report", "Report")
                        .WithMany("Locations")
                        .HasForeignKey("ReportID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
