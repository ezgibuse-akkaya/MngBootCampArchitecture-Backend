﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20220226113401_ilk")]
    partial class ilk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AdditionalServiceRental", b =>
                {
                    b.Property<int>("AdditionalServicesId")
                        .HasColumnType("integer");

                    b.Property<int>("RentalsId")
                        .HasColumnType("integer");

                    b.HasKey("AdditionalServicesId", "RentalsId");

                    b.HasIndex("RentalsId");

                    b.ToTable("AdditionalServiceRental");
                });

            modelBuilder.Entity("CustomerPromotionCode", b =>
                {
                    b.Property<int>("CustomersId")
                        .HasColumnType("integer");

                    b.Property<int>("PromotionCodesId")
                        .HasColumnType("integer");

                    b.HasKey("CustomersId", "PromotionCodesId");

                    b.HasIndex("PromotionCodesId");

                    b.ToTable("CustomerPromotionCode");
                });

            modelBuilder.Entity("Domain.Entities.AdditionalService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("ServicePoint")
                        .HasColumnType("smallint");

                    b.Property<int>("ServiceType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("AdditionalServices");
                });

            modelBuilder.Entity("Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Brands", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CarState")
                        .HasColumnType("integer")
                        .HasColumnName("CarState");

                    b.Property<int>("CityId")
                        .HasColumnType("integer")
                        .HasColumnName("CityId");

                    b.Property<int>("ColorId")
                        .HasColumnType("integer")
                        .HasColumnName("ColorId");

                    b.Property<int>("FindexScore")
                        .HasColumnType("integer");

                    b.Property<int>("Kilometer")
                        .HasColumnType("integer");

                    b.Property<int>("ModelId")
                        .HasColumnType("integer")
                        .HasColumnName("ModelId");

                    b.Property<int>("ModelYear")
                        .HasColumnType("integer")
                        .HasColumnName("ModelYear");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Plate");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ModelId");

                    b.ToTable("Cars", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CarDamage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarDamages", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Colors", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CreditCardInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CVC")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CVC");

                    b.Property<string>("CardHolder")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CardHolder");

                    b.Property<string>("CreditCardNo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CreditCardNo");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("CustomerId");

                    b.Property<string>("ValidDate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ValidDate");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CreditCardInfos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Fuels", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("InvoiceNo")
                        .HasColumnType("bigint");

                    b.Property<int>("RentalId")
                        .HasColumnType("integer");

                    b.Property<double>("TotalSum")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RentalId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Domain.Entities.Maintenance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("integer")
                        .HasColumnName("CarId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Description");

                    b.Property<DateTime>("MaintenanceDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("MaintenanceDate");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ReturnDate");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Maintenances", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("integer")
                        .HasColumnName("BrandId");

                    b.Property<double>("DailyPrice")
                        .HasColumnType("double precision")
                        .HasColumnName("DailyPrice");

                    b.Property<int>("FuelId")
                        .HasColumnType("integer")
                        .HasColumnName("FuelId");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<int>("TransmissionId")
                        .HasColumnType("integer")
                        .HasColumnName("TransmissionId");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("FuelId");

                    b.HasIndex("TransmissionId");

                    b.ToTable("Models", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("PaymentDate");

                    b.Property<int>("RentalId")
                        .HasColumnType("integer")
                        .HasColumnName("RentalId");

                    b.Property<double>("TotalSum")
                        .HasColumnType("double precision")
                        .HasColumnName("TotalSum");

                    b.HasKey("Id");

                    b.HasIndex("RentalId");

                    b.ToTable("Payments", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.PromotionCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DiscountRate")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ValidityDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("PromotionCodes");
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("integer")
                        .HasColumnName("CarId");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("CustomerId");

                    b.Property<int>("RentCityId")
                        .HasColumnType("integer")
                        .HasColumnName("RentCityId");

                    b.Property<DateTime>("RentDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("RentDate");

                    b.Property<int>("RentedKilometer")
                        .HasColumnType("integer")
                        .HasColumnName("RentedKilometer");

                    b.Property<int>("ReturnCityId")
                        .HasColumnType("integer")
                        .HasColumnName("ReturnCityId");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ReturnDate");

                    b.Property<int?>("ReturnedCityId")
                        .HasColumnType("integer")
                        .HasColumnName("ReturnedCityId");

                    b.Property<DateTime?>("ReturnedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ReturnedDate");

                    b.Property<int>("ReturnedKilometer")
                        .HasColumnType("integer")
                        .HasColumnName("ReturnedKilometer");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RentCityId");

                    b.HasIndex("ReturnCityId");

                    b.HasIndex("ReturnedCityId");

                    b.ToTable("Rentals", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Transmissions", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("PasswordSalt");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean")
                        .HasColumnName("Status");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("integer")
                        .HasColumnName("OperationClaimId");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClaims", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.HasBaseType("Domain.Entities.User");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CorporateCustomer", b =>
                {
                    b.HasBaseType("Domain.Entities.Customer");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CompanyName");

                    b.Property<string>("TaxNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("TaxNumber");

                    b.ToTable("CorporateCustomers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.IndividualCustomer", b =>
                {
                    b.HasBaseType("Domain.Entities.Customer");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("LastName");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("NationalId");

                    b.ToTable("IndividualCustomers", (string)null);
                });

            modelBuilder.Entity("AdditionalServiceRental", b =>
                {
                    b.HasOne("Domain.Entities.AdditionalService", null)
                        .WithMany()
                        .HasForeignKey("AdditionalServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Rental", null)
                        .WithMany()
                        .HasForeignKey("RentalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerPromotionCode", b =>
                {
                    b.HasOne("Domain.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.PromotionCode", null)
                        .WithMany()
                        .HasForeignKey("PromotionCodesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Car", b =>
                {
                    b.HasOne("Domain.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Color", "Color")
                        .WithMany("Cars")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Model", "Model")
                        .WithMany("Cars")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Color");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Domain.Entities.CarDamage", b =>
                {
                    b.HasOne("Domain.Entities.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Domain.Entities.CreditCardInfo", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.Invoice", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Rental", "Rental")
                        .WithMany()
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("Domain.Entities.Maintenance", b =>
                {
                    b.HasOne("Domain.Entities.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Domain.Entities.Model", b =>
                {
                    b.HasOne("Domain.Entities.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Fuel", "Fuel")
                        .WithMany("Models")
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Transmission", "Transmission")
                        .WithMany("Models")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Fuel");

                    b.Navigation("Transmission");
                });

            modelBuilder.Entity("Domain.Entities.Payment", b =>
                {
                    b.HasOne("Domain.Entities.Rental", "Rental")
                        .WithMany()
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("Domain.Entities.Rental", b =>
                {
                    b.HasOne("Domain.Entities.Car", "Car")
                        .WithMany("Rentals")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithMany("Rentals")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.City", "RentCity")
                        .WithMany()
                        .HasForeignKey("RentCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.City", "ReturnCity")
                        .WithMany()
                        .HasForeignKey("ReturnCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.City", "ReturnedCity")
                        .WithMany()
                        .HasForeignKey("ReturnedCityId");

                    b.Navigation("Car");

                    b.Navigation("Customer");

                    b.Navigation("RentCity");

                    b.Navigation("ReturnCity");

                    b.Navigation("ReturnedCity");
                });

            modelBuilder.Entity("Domain.Entities.UserOperationClaim", b =>
                {
                    b.HasOne("Domain.Entities.OperationClaim", "OperationClaim")
                        .WithMany()
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithOne()
                        .HasForeignKey("Domain.Entities.Customer", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.CorporateCustomer", b =>
                {
                    b.HasOne("Domain.Entities.Customer", null)
                        .WithOne()
                        .HasForeignKey("Domain.Entities.CorporateCustomer", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.IndividualCustomer", b =>
                {
                    b.HasOne("Domain.Entities.Customer", null)
                        .WithOne()
                        .HasForeignKey("Domain.Entities.IndividualCustomer", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Brand", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Domain.Entities.Car", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("Domain.Entities.Color", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Domain.Entities.Fuel", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Domain.Entities.Model", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Domain.Entities.Transmission", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Navigation("Rentals");
                });
#pragma warning restore 612, 618
        }
    }
}
