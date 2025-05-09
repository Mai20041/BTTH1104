﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductListApp.Data;

#nullable disable

namespace ProductListApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250411055955_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductListApp.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Laptop cao cấp với màn hình 13 inch, CPU Intel Core i7",
                            ImageUrl = "/images/laptop-dell.jpg",
                            Name = "Laptop Dell XPS 13",
                            Price = 1299.99m,
                            Quantity = 15
                        },
                        new
                        {
                            Id = 2,
                            Description = "Điện thoại thông minh với camera tiên tiến và chip A16",
                            ImageUrl = "/images/iphone15.jpg",
                            Name = "iPhone 15 Pro",
                            Price = 999.99m,
                            Quantity = 25
                        },
                        new
                        {
                            Id = 3,
                            Description = "Điện thoại Android flagship với màn hình AMOLED",
                            ImageUrl = "/images/galaxy-s25.jpg",
                            Name = "Samsung Galaxy S25",
                            Price = 899.99m,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 4,
                            Description = "Tai nghe chống ồn cao cấp với âm thanh HiFi",
                            ImageUrl = "/images/sony-headphones.jpg",
                            Name = "Tai nghe Sony WH-1000XM5",
                            Price = 349.99m,
                            Quantity = 30
                        },
                        new
                        {
                            Id = 5,
                            Description = "Máy tính bảng nhẹ với hiệu suất mạnh mẽ",
                            ImageUrl = "/images/ipad-air.jpg",
                            Name = "iPad Air",
                            Price = 599.99m,
                            Quantity = 18
                        },
                        new
                        {
                            Id = 6,
                            Description = "Máy ảnh mirrorless full-frame chuyên nghiệp",
                            ImageUrl = "/images/canon-r6.jpg",
                            Name = "Máy ảnh Canon EOS R6",
                            Price = 2499.99m,
                            Quantity = 8
                        },
                        new
                        {
                            Id = 7,
                            Description = "Đồng hồ thông minh với tính năng theo dõi sức khỏe",
                            ImageUrl = "/images/apple-watch.jpg",
                            Name = "Đồng hồ thông minh Apple Watch Series 9",
                            Price = 399.99m,
                            Quantity = 22
                        },
                        new
                        {
                            Id = 8,
                            Description = "Loa không dây chống nước với pin dung lượng cao",
                            ImageUrl = "/images/jbl-charge.jpg",
                            Name = "Loa Bluetooth JBL Charge 5",
                            Price = 179.99m,
                            Quantity = 35
                        },
                        new
                        {
                            Id = 9,
                            Description = "Bàn phím gaming với switch GX Blue",
                            ImageUrl = "/images/logitech-keyboard.jpg",
                            Name = "Bàn phím cơ Logitech G Pro",
                            Price = 129.99m,
                            Quantity = 40
                        },
                        new
                        {
                            Id = 10,
                            Description = "Chuột gaming với cảm biến quang học 26K DPI",
                            ImageUrl = "/images/razer-mouse.jpg",
                            Name = "Chuột gaming Razer DeathAdder V3",
                            Price = 69.99m,
                            Quantity = 50
                        },
                        new
                        {
                            Id = 11,
                            Description = "Màn hình gaming QHD 165Hz với G-Sync",
                            ImageUrl = "/images/lg-monitor.jpg",
                            Name = "Màn hình LG UltraGear 27\"",
                            Price = 399.99m,
                            Quantity = 12
                        },
                        new
                        {
                            Id = 12,
                            Description = "Máy chơi game cầm tay với màn hình OLED 7 inch",
                            ImageUrl = "/images/nintendo-switch.jpg",
                            Name = "Nintendo Switch OLED",
                            Price = 349.99m,
                            Quantity = 15
                        },
                        new
                        {
                            Id = 13,
                            Description = "Ổ cứng SSD NVMe với tốc độ đọc/ghi cao",
                            ImageUrl = "/images/samsung-ssd.jpg",
                            Name = "SSD Samsung 970 EVO Plus 1TB",
                            Price = 149.99m,
                            Quantity = 30
                        },
                        new
                        {
                            Id = 14,
                            Description = "Balo chống sốc cho laptop 15.6 inch",
                            ImageUrl = "/images/targus-backpack.jpg",
                            Name = "Balo laptop Targus",
                            Price = 79.99m,
                            Quantity = 25
                        },
                        new
                        {
                            Id = 15,
                            Description = "Máy lọc không khí kết hợp quạt làm mát",
                            ImageUrl = "/images/dyson-purifier.jpg",
                            Name = "Máy lọc không khí Dyson",
                            Price = 499.99m,
                            Quantity = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
