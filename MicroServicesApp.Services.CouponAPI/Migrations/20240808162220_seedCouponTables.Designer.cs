﻿// <auto-generated />
using MicroServicesApp.Services.CouponAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MicroServicesApp.Services.CouponAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240808162220_seedCouponTables")]
    partial class seedCouponTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MicroServicesApp.Services.CouponAPI.Models.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponId"));

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<int>("MinAmount")
                        .HasColumnType("int");

                    b.HasKey("CouponId");

                    b.ToTable("Coupones");

                    b.HasData(
                        new
                        {
                            CouponId = 1,
                            CouponCode = "10TY",
                            DiscountAmount = 3.0,
                            MinAmount = 10
                        },
                        new
                        {
                            CouponId = 2,
                            CouponCode = "20TY",
                            DiscountAmount = 5.0,
                            MinAmount = 15
                        },
                        new
                        {
                            CouponId = 3,
                            CouponCode = "30TY",
                            DiscountAmount = 15.0,
                            MinAmount = 30
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
