﻿// <auto-generated />
using Mango.Services.CouponAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mango.Services.CouponAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mango.Services.CouponAPI.Models.Coupon", b =>
                {
                    b.Property<int>("CouponID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponID"), 1L, 1);

                    b.Property<string>("CouponCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.HasKey("CouponID");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponID = 1,
                            CouponCode = "10OFF",
                            DiscountAmount = 10.0
                        },
                        new
                        {
                            CouponID = 2,
                            CouponCode = "20OFF",
                            DiscountAmount = 20.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
