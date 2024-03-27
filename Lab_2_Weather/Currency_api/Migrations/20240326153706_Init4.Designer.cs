﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Weather_api;

#nullable disable

namespace Weather_api.Migrations
{
    [DbContext(typeof(Currency_Exchange))]
    [Migration("20240326153706_Init4")]
    partial class Init4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Weather_api.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Exchange")
                        .HasColumnType("REAL");

                    b.Property<string>("Tag")
                        .HasColumnType("TEXT");

                    b.Property<double>("timestamp_number")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Exchange = 4.5f,
                            Tag = "TEST",
                            timestamp_number = 4.5
                        },
                        new
                        {
                            Id = 2,
                            Exchange = 4.5f,
                            Tag = "TEST2",
                            timestamp_number = 4.5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
