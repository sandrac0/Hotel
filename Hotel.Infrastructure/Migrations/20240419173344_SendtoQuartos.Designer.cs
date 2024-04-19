﻿// <auto-generated />
using Hotel.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240419173344_SendtoQuartos")]
    partial class SendtoQuartos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hotel.Domain.Entities.Quartos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Quartos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = " Vista para o mar",
                            Floor = 10,
                            Type = "Suite"
                        },
                        new
                        {
                            Id = 2,
                            Description = " Vista para o parque",
                            Floor = 5,
                            Type = "Familia"
                        },
                        new
                        {
                            Id = 3,
                            Description = " Vista para as montanhas",
                            Floor = 2,
                            Type = "Solteiro"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
