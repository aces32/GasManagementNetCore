﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonitorGas.GasManagement.Persistence;

namespace MonitorGas.GasManagement.Persistence.Migrations
{
    [DbContext(typeof(MonitorGasDbContext))]
    partial class MonitorGasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MonitorGas.GasManagement.Domain.Entites.Gas", b =>
                {
                    b.Property<Guid>("GasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GasSizeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GasVendorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("GasID");

                    b.HasIndex("GasSizeID");

                    b.ToTable("Gases");

                    b.HasData(
                        new
                        {
                            GasID = new Guid("ee272f8b-6096-4cb6-8625-bb4bb2d89e8b"),
                            Color = "Red",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 1, 24, 22, 30, 53, 552, DateTimeKind.Local).AddTicks(8855),
                            Description = "Red gas added to the company by Abc Ga limited.",
                            GasSizeID = new Guid("089be77d-e198-4832-9eb5-4a041b155506"),
                            GasVendorName = "ABC Gas Limited",
                            ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                            Price = 65
                        },
                        new
                        {
                            GasID = new Guid("7ea5e087-06e7-4bfc-ab17-bb182a42ce3d"),
                            Color = "Yellow",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2021, 11, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(2880),
                            Description = "Yellow gas added to the company by Abc Gas limited.",
                            GasSizeID = new Guid("089be77d-e198-4832-9eb5-4a041b155506"),
                            GasVendorName = "ABC Gas Limited",
                            ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                            Price = 95
                        },
                        new
                        {
                            GasID = new Guid("51d03858-68eb-4887-94a0-2ed111ef954b"),
                            Color = "Blue",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 1, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(2930),
                            Description = "Red gas added to the company by Red Coporate Gas limited.",
                            GasSizeID = new Guid("9110ec52-c457-4924-a7ee-03e497fa865d"),
                            GasVendorName = "Red Coporate Gas Limited",
                            ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                            Price = 25
                        },
                        new
                        {
                            GasID = new Guid("7bc4b468-2c09-44b0-9ddb-32d09aec5b08"),
                            Color = "Green",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2022, 1, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(2959),
                            Description = "Green added to the company by Smart Gas Limited.",
                            GasSizeID = new Guid("1bf57a70-e896-4273-874d-15a38291d73b"),
                            GasVendorName = "Smart Gas Limited",
                            ImageUrl = "https://theoilbloc.com/wp-content/uploads/2020/06/gas-cylinder.jpg",
                            Price = 175
                        });
                });

            modelBuilder.Entity("MonitorGas.GasManagement.Domain.Entites.GasSize", b =>
                {
                    b.Property<Guid>("GasSizeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("SizeInKg")
                        .HasColumnType("float");

                    b.HasKey("GasSizeID");

                    b.ToTable("GasSizes");

                    b.HasData(
                        new
                        {
                            GasSizeID = new Guid("9110ec52-c457-4924-a7ee-03e497fa865d"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SizeInKg = 10.0
                        },
                        new
                        {
                            GasSizeID = new Guid("089be77d-e198-4832-9eb5-4a041b155506"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SizeInKg = 20.0
                        },
                        new
                        {
                            GasSizeID = new Guid("1bf57a70-e896-4273-874d-15a38291d73b"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SizeInKg = 30.0
                        },
                        new
                        {
                            GasSizeID = new Guid("3fe536ae-ada3-4097-b255-aa27f8d65c87"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SizeInKg = 40.0
                        });
                });

            modelBuilder.Entity("MonitorGas.GasManagement.Domain.Entites.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OrderPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderTotal")
                        .HasColumnType("int");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7e94bc5b-71a5-4c8c-bc3b-71bb7976237e"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(4356),
                            OrderTotal = 400,
                            UserID = new Guid("a441eb40-9636-4ee6-be49-a66c5ec1330b")
                        },
                        new
                        {
                            Id = new Guid("86d3a045-b42d-4854-8150-d6a374948b6e"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(5197),
                            OrderTotal = 135,
                            UserID = new Guid("ac3cfaf5-34fd-4e4d-bc04-ad1083ddc340")
                        },
                        new
                        {
                            Id = new Guid("771cca4b-066c-4ac7-b3df-4d12837fe7e0"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(5226),
                            OrderTotal = 85,
                            UserID = new Guid("d97a15fc-0d32-41c6-9ddf-62f0735c4c1c")
                        },
                        new
                        {
                            Id = new Guid("3dcb3ea0-80b1-4781-b5c0-4d85c41e55a6"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(5248),
                            OrderTotal = 245,
                            UserID = new Guid("4ad901be-f447-46dd-bcf7-dbe401afa203")
                        },
                        new
                        {
                            Id = new Guid("e6a2679c-79a3-4ef1-a478-6f4c91b405b6"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(5384),
                            OrderTotal = 142,
                            UserID = new Guid("7aeb2c01-fe8e-4b84-a5ba-330bdf950f5c")
                        },
                        new
                        {
                            Id = new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderPaid = true,
                            OrderPlaced = new DateTime(2021, 7, 24, 22, 30, 53, 554, DateTimeKind.Local).AddTicks(5416),
                            OrderTotal = 40,
                            UserID = new Guid("f5a6a3a0-4227-4973-abb5-a63fbe725923")
                        });
                });

            modelBuilder.Entity("MonitorGas.GasManagement.Domain.Entites.Gas", b =>
                {
                    b.HasOne("MonitorGas.GasManagement.Domain.Entites.GasSize", "GasSize")
                        .WithMany("Gases")
                        .HasForeignKey("GasSizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GasSize");
                });

            modelBuilder.Entity("MonitorGas.GasManagement.Domain.Entites.GasSize", b =>
                {
                    b.Navigation("Gases");
                });
#pragma warning restore 612, 618
        }
    }
}