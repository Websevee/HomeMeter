﻿// <auto-generated />
using HomeMeter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeMeter.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200319195239_New2")]
    partial class New2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeMeter.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Zip", "Country", "City", "Street", "Number")
                        .IsUnique()
                        .HasFilter("[Country] IS NOT NULL AND [City] IS NOT NULL AND [Street] IS NOT NULL");

                    b.ToTable("House");
                });

            modelBuilder.Entity("HomeMeter.Models.Meter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HouseId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<double>("Readings")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("HouseId")
                        .IsUnique();

                    b.ToTable("Meter");
                });

            modelBuilder.Entity("HomeMeter.Models.Meter", b =>
                {
                    b.HasOne("HomeMeter.Models.House", "House")
                        .WithOne("Meter")
                        .HasForeignKey("HomeMeter.Models.Meter", "HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
