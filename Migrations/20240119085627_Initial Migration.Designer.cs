﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using expense_tracker.DbContexts;

#nullable disable

namespace expense_tracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240119085627_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("expense_tracker.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("expense_tracker.Models.Transaction", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TransactionId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("expense_tracker.Models.Transaction", b =>
                {
                    b.HasOne("expense_tracker.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
