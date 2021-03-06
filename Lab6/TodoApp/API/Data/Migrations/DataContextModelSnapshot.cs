﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("API.Entities.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDone")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 11, 6, 13, 7, 23, 775, DateTimeKind.Local).AddTicks(9631),
                            Description = "tema ml",
                            IsDone = true
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 11, 6, 13, 7, 23, 780, DateTimeKind.Local).AddTicks(7378),
                            Description = "tema si",
                            IsDone = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 11, 6, 13, 7, 23, 780, DateTimeKind.Local).AddTicks(7673),
                            Description = "tema ai",
                            IsDone = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
