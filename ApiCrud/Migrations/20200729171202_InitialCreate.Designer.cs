﻿// <auto-generated />
using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiCrud.Migrations
{
    [DbContext(typeof(CrudDbContext))]
    [Migration("20200729171202_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiCrud.Models.CrudDbContext+Person", b =>
                {
                    b.Property<int>("personId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("personAge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("personName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("personId");

                    b.ToTable("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}