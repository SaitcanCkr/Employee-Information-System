﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _214001004.Models;

namespace _214001004.Migrations
{
    [DbContext(typeof(ApplicationConnectionDb))]
    partial class ApplicationConnectionDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("_214001004.Models.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("KullaniciSifre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("KullaniciYetki")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Kullanici");
                });
#pragma warning restore 612, 618
        }
    }
}