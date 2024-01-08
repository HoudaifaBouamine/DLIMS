﻿// <auto-generated />
using System;
using DVLD.DataAccess.EntityFramworkDataLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DVLD.WebAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class dbContextDVLDModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.Application", b =>
                {
                    b.Property<int>("Application_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Application_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Application_Id"));

                    b.Property<int>("ApplicationStatus_Id")
                        .HasColumnType("int")
                        .HasColumnName("ApplicationStatus_Id");

                    b.Property<int>("ApplicationTests_Id")
                        .HasColumnType("int")
                        .HasColumnName("ApplicationTests_Id");

                    b.Property<int>("Creator_Id")
                        .HasColumnType("int")
                        .HasColumnName("Creator_Id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("LicenseClass_Id")
                        .HasColumnType("int")
                        .HasColumnName("LicenseClass_Id");

                    b.Property<decimal>("PayedFees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Person_Id")
                        .HasColumnType("int")
                        .HasColumnName("Person_Id");

                    b.Property<int>("Service_Id")
                        .HasColumnType("int")
                        .HasColumnName("Service_Id");

                    b.HasKey("Application_Id");

                    b.HasIndex("ApplicationStatus_Id");

                    b.HasIndex("ApplicationTests_Id");

                    b.HasIndex("Creator_Id");

                    b.HasIndex("LicenseClass_Id");

                    b.HasIndex("Person_Id");

                    b.HasIndex("Service_Id");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationStatus", b =>
                {
                    b.Property<int>("ApplicationStatus_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ApplicationStatus_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationStatus_Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ApplicationStatus_Id");

                    b.ToTable("ApplicationStatuses");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestFees", b =>
                {
                    b.Property<int>("ApplicationsTestFees_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ApplicationsTestFees_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationsTestFees_Id"));

                    b.Property<decimal>("Fees")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ApplicationsTestFees_Id");

                    b.ToTable("ApplicationsTestFees");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTests", b =>
                {
                    b.Property<int>("ApplicationTests_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ApplicationTests_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationTests_Id"));

                    b.Property<bool>("isStreetTestPassed")
                        .HasColumnType("bit");

                    b.Property<bool>("isVisionTestPassed")
                        .HasColumnType("bit");

                    b.Property<bool>("isWrittenTestPassed")
                        .HasColumnType("bit");

                    b.HasKey("ApplicationTests_Id");

                    b.ToTable("ApplicationsTests");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestsTypes.PracticalTest", b =>
                {
                    b.Property<int>("PracticalTest_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PracticalTest_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PracticalTest_Id"));

                    b.Property<int>("ApplicationTests_Id")
                        .HasColumnType("int")
                        .HasColumnName("ApplicationTests_Id");

                    b.Property<DateTime>("AppointmentTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fees_Id")
                        .HasColumnType("int")
                        .HasColumnName("Fees_Id");

                    b.Property<bool>("IsPassed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RealTestTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PracticalTest_Id");

                    b.HasIndex("ApplicationTests_Id");

                    b.HasIndex("Fees_Id");

                    b.ToTable("PracticalTests");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestsTypes.VisionTest", b =>
                {
                    b.Property<int>("VisionTest_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VisionTest_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisionTest_Id"));

                    b.Property<int>("ApplicationTests_Id")
                        .HasColumnType("int")
                        .HasColumnName("ApplicationTests_Id");

                    b.Property<DateTime>("AppointmentTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fees_Id")
                        .HasColumnType("int")
                        .HasColumnName("Fees_Id");

                    b.Property<bool>("IsPassed")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("RealTestTime")
                        .HasColumnType("datetime2");

                    b.HasKey("VisionTest_Id");

                    b.HasIndex("ApplicationTests_Id");

                    b.HasIndex("Fees_Id");

                    b.ToTable("VisionTests");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestsTypes.WritenTest", b =>
                {
                    b.Property<int>("WritenTest_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("WritenTest_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WritenTest_Id"));

                    b.Property<int>("ApplicationTests_Id")
                        .HasColumnType("int")
                        .HasColumnName("ApplicationTests_Id");

                    b.Property<int>("Fees_Id")
                        .HasColumnType("int")
                        .HasColumnName("Fees_Id");

                    b.Property<bool>("IsPassed")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Mark")
                        .HasColumnType("decimal(3,2)");

                    b.Property<DateTime>("TestTime")
                        .HasColumnType("datetime2");

                    b.HasKey("WritenTest_Id");

                    b.HasIndex("ApplicationTests_Id");

                    b.HasIndex("Fees_Id");

                    b.ToTable("WritenTests");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.Service", b =>
                {
                    b.Property<int>("Service_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Service_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Service_Id"));

                    b.Property<decimal>("ApplicationFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Service_Id");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.License.License", b =>
                {
                    b.Property<int>("License_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("License_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("License_Id"));

                    b.Property<DateTime>("CreatingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreationStatus")
                        .HasColumnType("int");

                    b.Property<int>("Driver_Id")
                        .HasColumnType("int")
                        .HasColumnName("Driver_Id");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsValied")
                        .HasColumnType("bit");

                    b.Property<int>("LicenseClass_Id")
                        .HasColumnType("int")
                        .HasColumnName("LicenseClass_Id");

                    b.HasKey("License_Id");

                    b.HasIndex("Driver_Id");

                    b.HasIndex("LicenseClass_Id");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.License.LicenseClass", b =>
                {
                    b.Property<int>("LicenseClass_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LicenseClass_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LicenseClass_Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MinimumAllowedAge")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("ValiditySpan")
                        .HasColumnType("time");

                    b.HasKey("LicenseClass_Id");

                    b.ToTable("LicenseClasses");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.License.LicenseSuspension", b =>
                {
                    b.Property<int>("LicenseSuspension_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LicenseSuspension_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LicenseSuspension_Id"));

                    b.Property<decimal>("Fees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("License_Id")
                        .HasColumnType("int")
                        .HasColumnName("License_Id");

                    b.Property<string>("SuspensionReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("SuspenstionCancelDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SuspenstionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LicenseSuspension_Id");

                    b.HasIndex("License_Id");

                    b.ToTable("LicenseSuspensions");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.Driver", b =>
                {
                    b.Property<int>("Driver_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Driver_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Driver_Id"));

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Person_Id")
                        .HasColumnType("int")
                        .HasColumnName("Person_Id");

                    b.HasKey("Driver_Id");

                    b.HasIndex("Person_Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.Nationality", b =>
                {
                    b.Property<int>("Nationality_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Nationality_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Nationality_Id"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NationalityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Nationality_Id");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.Person", b =>
                {
                    b.Property<int>("Person_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Person_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Person_Id"));

                    b.Property<string>("AddressLine")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NationalNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Nationality_Id")
                        .HasColumnType("int")
                        .HasColumnName("Nationality_Id");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SecondName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ThirddName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Person_Id");

                    b.HasIndex("Nationality_Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.User", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("User_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Permission")
                        .HasColumnType("int");

                    b.Property<int>("Person_Id")
                        .HasColumnType("int")
                        .HasColumnName("Person_Id");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("User_Id");

                    b.HasIndex("Person_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.Application", b =>
                {
                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationStatus", "ApplicationStatus")
                        .WithMany()
                        .HasForeignKey("ApplicationStatus_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTests", "ApplicationTests")
                        .WithMany()
                        .HasForeignKey("ApplicationTests_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.User", "Creator")
                        .WithMany()
                        .HasForeignKey("Creator_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.License.LicenseClass", "LicenseClass")
                        .WithMany()
                        .HasForeignKey("LicenseClass_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Person_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.Service", "Service")
                        .WithMany()
                        .HasForeignKey("Service_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationStatus");

                    b.Navigation("ApplicationTests");

                    b.Navigation("Creator");

                    b.Navigation("LicenseClass");

                    b.Navigation("Person");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestsTypes.PracticalTest", b =>
                {
                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTests", "ApplicationTests")
                        .WithMany()
                        .HasForeignKey("ApplicationTests_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestFees", "Fees")
                        .WithMany()
                        .HasForeignKey("Fees_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationTests");

                    b.Navigation("Fees");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestsTypes.VisionTest", b =>
                {
                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTests", "ApplicationTests")
                        .WithMany()
                        .HasForeignKey("ApplicationTests_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestFees", "Fees")
                        .WithMany()
                        .HasForeignKey("Fees_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationTests");

                    b.Navigation("Fees");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestsTypes.WritenTest", b =>
                {
                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTests", "ApplicationTests")
                        .WithMany()
                        .HasForeignKey("ApplicationTests_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Applications.ApplicationTestFees", "Fees")
                        .WithMany()
                        .HasForeignKey("Fees_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationTests");

                    b.Navigation("Fees");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.License.License", b =>
                {
                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("Driver_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.License.LicenseClass", "LicenseClass")
                        .WithMany()
                        .HasForeignKey("LicenseClass_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");

                    b.Navigation("LicenseClass");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.License.LicenseSuspension", b =>
                {
                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.License.License", "License")
                        .WithMany()
                        .HasForeignKey("License_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("License");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.Driver", b =>
                {
                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Person_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.Person", b =>
                {
                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("Nationality_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nationality");
                });

            modelBuilder.Entity("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.User", b =>
                {
                    b.HasOne("DVLD.DataAccess.EntityFramworkDataLayer.Entities.Peoples.Person", "Person")
                        .WithMany()
                        .HasForeignKey("Person_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
