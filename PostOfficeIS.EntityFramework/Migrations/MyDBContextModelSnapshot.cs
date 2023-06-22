﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestDB.DB;

#nullable disable

namespace PostOfficeIS.EntityFramework.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PostOfficeIS.Models.CityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities", (string)null);
                });

            modelBuilder.Entity("PostOfficeIS.Models.ClientEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BirthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients", (string)null);
                });

            modelBuilder.Entity("PostOfficeIS.Models.ParcelEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Fragility")
                        .HasColumnType("bit");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Parcels", (string)null);
                });

            modelBuilder.Entity("PostOfficeIS.Models.PositionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions", (string)null);
                });

            modelBuilder.Entity("PostOfficeIS.Models.PostOfficeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PostOffices", (string)null);
                });

            modelBuilder.Entity("PostOfficeIS.Models.TransactionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CheckTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GeterId")
                        .HasColumnType("int");

                    b.Property<int>("ParcelId")
                        .HasColumnType("int");

                    b.Property<int?>("PostManId")
                        .HasColumnType("int");

                    b.Property<string>("SendTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SenderCityId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GeterId");

                    b.HasIndex("ParcelId")
                        .IsUnique();

                    b.HasIndex("PostManId");

                    b.HasIndex("SenderCityId");

                    b.HasIndex("SenderId");

                    b.ToTable("Transactions", (string)null);
                });

            modelBuilder.Entity("PostOfficeIS.Models.WorkerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workers", (string)null);
                });

            modelBuilder.Entity("PostOfficeIS.Models.WorkerProfileEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BirthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("PostOfficeId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("PostOfficeId");

                    b.HasIndex("WorkerId")
                        .IsUnique();

                    b.ToTable("WorkersProfiles", (string)null);
                });

            modelBuilder.Entity("PostOfficeIS.Models.PostOfficeEntity", b =>
                {
                    b.HasOne("PostOfficeIS.Models.CityEntity", "City")
                        .WithMany("PostOffices")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("PostOfficeIS.Models.TransactionEntity", b =>
                {
                    b.HasOne("PostOfficeIS.Models.ClientEntity", "Geter")
                        .WithMany()
                        .HasForeignKey("GeterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PostOfficeIS.Models.ParcelEntity", "Parcel")
                        .WithOne("Transaction")
                        .HasForeignKey("PostOfficeIS.Models.TransactionEntity", "ParcelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PostOfficeIS.Models.WorkerProfileEntity", "PostMan")
                        .WithMany()
                        .HasForeignKey("PostManId");

                    b.HasOne("PostOfficeIS.Models.CityEntity", "SenderCity")
                        .WithMany()
                        .HasForeignKey("SenderCityId");

                    b.HasOne("PostOfficeIS.Models.ClientEntity", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Geter");

                    b.Navigation("Parcel");

                    b.Navigation("PostMan");

                    b.Navigation("Sender");

                    b.Navigation("SenderCity");
                });

            modelBuilder.Entity("PostOfficeIS.Models.WorkerProfileEntity", b =>
                {
                    b.HasOne("PostOfficeIS.Models.PositionEntity", "Position")
                        .WithMany("WorkerProfiles")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PostOfficeIS.Models.PostOfficeEntity", "PostOffice")
                        .WithMany("Workers")
                        .HasForeignKey("PostOfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PostOfficeIS.Models.WorkerEntity", "Worker")
                        .WithOne("WorkerProfile")
                        .HasForeignKey("PostOfficeIS.Models.WorkerProfileEntity", "WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("PostOffice");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("PostOfficeIS.Models.CityEntity", b =>
                {
                    b.Navigation("PostOffices");
                });

            modelBuilder.Entity("PostOfficeIS.Models.ParcelEntity", b =>
                {
                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("PostOfficeIS.Models.PositionEntity", b =>
                {
                    b.Navigation("WorkerProfiles");
                });

            modelBuilder.Entity("PostOfficeIS.Models.PostOfficeEntity", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("PostOfficeIS.Models.WorkerEntity", b =>
                {
                    b.Navigation("WorkerProfile");
                });
#pragma warning restore 612, 618
        }
    }
}