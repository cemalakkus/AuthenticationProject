﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using AuthProject.Persistence.Context;

#nullable disable

namespace AuthProject.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AuthProject.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7f964f30-b07c-4755-975d-fc2b0b3bf65f"),
                            Created = new DateTime(2023, 12, 5, 23, 44, 20, 786, DateTimeKind.Local).AddTicks(7036),
                            CreatedBy = "0",
                            LastModifiedBy = "",
                            Name = "Pen",
                            Price = 10m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("dc103cf3-12ab-4a17-99e0-9e888ed0d7fe"),
                            Created = new DateTime(2023, 12, 5, 23, 44, 20, 786, DateTimeKind.Local).AddTicks(7055),
                            CreatedBy = "0",
                            LastModifiedBy = "",
                            Name = "Paper A4",
                            Price = 4m,
                            Quantity = 200
                        },
                        new
                        {
                            Id = new Guid("d384bb8a-e078-491d-bf33-1f58334f5c8f"),
                            Created = new DateTime(2023, 12, 5, 23, 44, 20, 786, DateTimeKind.Local).AddTicks(7074),
                            CreatedBy = "0",
                            LastModifiedBy = "",
                            Name = "Book",
                            Price = 30m,
                            Quantity = 500
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
