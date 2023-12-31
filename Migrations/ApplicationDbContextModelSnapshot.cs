﻿// <auto-generated />
using System;
using ExpenseTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExpenseTracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExpenseTracker.Models.Data.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ExpenseTracker.Models.Data.Transaction", b =>
                {
                    b.Property<string>("TransactionId")
                        .HasColumnType("varchar(36)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("varchar(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("ExpenseTracker.Models.Data.Transaction", b =>
                {
                    b.HasOne("ExpenseTracker.Models.Data.Category", "Category")
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
