﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test1.Data;

namespace test1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230929184543_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("test1.Model.Etudiant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("firstN")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastN")
                        .HasColumnType("TEXT");

                    b.Property<long>("tel")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Etudiant");
                });
#pragma warning restore 612, 618
        }
    }
}