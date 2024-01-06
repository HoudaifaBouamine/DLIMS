using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationStatuses",
                columns: table => new
                {
                    ApplicationStatus_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatuses", x => x.ApplicationStatus_Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationsTestFees",
                columns: table => new
                {
                    ApplicationsTestFees_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fees = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationsTestFees", x => x.ApplicationsTestFees_Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationsTests",
                columns: table => new
                {
                    ApplicationTests_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isVisionTestPassed = table.Column<bool>(type: "bit", nullable: false),
                    isWrittenTestPassed = table.Column<bool>(type: "bit", nullable: false),
                    isStreetTestPassed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationsTests", x => x.ApplicationTests_Id);
                });

            migrationBuilder.CreateTable(
                name: "LicenseClasses",
                columns: table => new
                {
                    LicenseClass_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimumAllowedAge = table.Column<int>(type: "int", nullable: false),
                    ValiditySpan = table.Column<TimeSpan>(type: "time", nullable: false),
                    Fees = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseClasses", x => x.LicenseClass_Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Nationality_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Nationality_Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Service_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ApplicationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Service_Id);
                });

            migrationBuilder.CreateTable(
                name: "PracticalTests",
                columns: table => new
                {
                    PracticalTest_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationTests_Id = table.Column<int>(type: "int", nullable: false),
                    Fees_Id = table.Column<int>(type: "int", nullable: false),
                    AppointmentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RealTestTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPassed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticalTests", x => x.PracticalTest_Id);
                    table.ForeignKey(
                        name: "FK_PracticalTests_ApplicationsTestFees_Fees_Id",
                        column: x => x.Fees_Id,
                        principalTable: "ApplicationsTestFees",
                        principalColumn: "ApplicationsTestFees_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PracticalTests_ApplicationsTests_ApplicationTests_Id",
                        column: x => x.ApplicationTests_Id,
                        principalTable: "ApplicationsTests",
                        principalColumn: "ApplicationTests_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VisionTests",
                columns: table => new
                {
                    VisionTest_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationTests_Id = table.Column<int>(type: "int", nullable: false),
                    Fees_Id = table.Column<int>(type: "int", nullable: false),
                    AppointmentTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RealTestTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPassed = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisionTests", x => x.VisionTest_Id);
                    table.ForeignKey(
                        name: "FK_VisionTests_ApplicationsTestFees_Fees_Id",
                        column: x => x.Fees_Id,
                        principalTable: "ApplicationsTestFees",
                        principalColumn: "ApplicationsTestFees_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VisionTests_ApplicationsTests_ApplicationTests_Id",
                        column: x => x.ApplicationTests_Id,
                        principalTable: "ApplicationsTests",
                        principalColumn: "ApplicationTests_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WritenTests",
                columns: table => new
                {
                    WritenTest_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationTests_Id = table.Column<int>(type: "int", nullable: false),
                    Fees_Id = table.Column<int>(type: "int", nullable: false),
                    TestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPassed = table.Column<bool>(type: "bit", nullable: false),
                    Mark = table.Column<decimal>(type: "decimal(3,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WritenTests", x => x.WritenTest_Id);
                    table.ForeignKey(
                        name: "FK_WritenTests_ApplicationsTestFees_Fees_Id",
                        column: x => x.Fees_Id,
                        principalTable: "ApplicationsTestFees",
                        principalColumn: "ApplicationsTestFees_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WritenTests_ApplicationsTests_ApplicationTests_Id",
                        column: x => x.ApplicationTests_Id,
                        principalTable: "ApplicationsTests",
                        principalColumn: "ApplicationTests_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Person_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nationality_Id = table.Column<int>(type: "int", nullable: false),
                    NationalNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ThirddName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Person_Id);
                    table.ForeignKey(
                        name: "FK_Persons_Nationalities_Nationality_Id",
                        column: x => x.Nationality_Id,
                        principalTable: "Nationalities",
                        principalColumn: "Nationality_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Driver_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_Id = table.Column<int>(type: "int", nullable: false),
                    HashedPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Driver_Id);
                    table.ForeignKey(
                        name: "FK_Drivers_Persons_Person_Id",
                        column: x => x.Person_Id,
                        principalTable: "Persons",
                        principalColumn: "Person_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_Id = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    Permission = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_Id);
                    table.ForeignKey(
                        name: "FK_Users_Persons_Person_Id",
                        column: x => x.Person_Id,
                        principalTable: "Persons",
                        principalColumn: "Person_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    License_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Driver_Id = table.Column<int>(type: "int", nullable: false),
                    LicenseClass_Id = table.Column<int>(type: "int", nullable: false),
                    CreatingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsValied = table.Column<bool>(type: "bit", nullable: false),
                    CreationStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.License_Id);
                    table.ForeignKey(
                        name: "FK_Licenses_Drivers_Driver_Id",
                        column: x => x.Driver_Id,
                        principalTable: "Drivers",
                        principalColumn: "Driver_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Licenses_LicenseClasses_LicenseClass_Id",
                        column: x => x.LicenseClass_Id,
                        principalTable: "LicenseClasses",
                        principalColumn: "LicenseClass_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Application_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Service_Id = table.Column<int>(type: "int", nullable: false),
                    Person_Id = table.Column<int>(type: "int", nullable: false),
                    ApplicationStatus_Id = table.Column<int>(type: "int", nullable: false),
                    Creator_Id = table.Column<int>(type: "int", nullable: false),
                    LicenseClass_Id = table.Column<int>(type: "int", nullable: false),
                    ApplicationTests_Id = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayedFees = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Application_Id);
                    table.ForeignKey(
                        name: "FK_Applications_ApplicationStatuses_ApplicationStatus_Id",
                        column: x => x.ApplicationStatus_Id,
                        principalTable: "ApplicationStatuses",
                        principalColumn: "ApplicationStatus_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_ApplicationsTests_ApplicationTests_Id",
                        column: x => x.ApplicationTests_Id,
                        principalTable: "ApplicationsTests",
                        principalColumn: "ApplicationTests_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_LicenseClasses_LicenseClass_Id",
                        column: x => x.LicenseClass_Id,
                        principalTable: "LicenseClasses",
                        principalColumn: "LicenseClass_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_Persons_Person_Id",
                        column: x => x.Person_Id,
                        principalTable: "Persons",
                        principalColumn: "Person_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_Service_Service_Id",
                        column: x => x.Service_Id,
                        principalTable: "Service",
                        principalColumn: "Service_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Applications_Users_Creator_Id",
                        column: x => x.Creator_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LicenseSuspensions",
                columns: table => new
                {
                    LicenseSuspension_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    License_Id = table.Column<int>(type: "int", nullable: false),
                    Fees = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SuspensionReason = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    SuspenstionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuspenstionCancelDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseSuspensions", x => x.LicenseSuspension_Id);
                    table.ForeignKey(
                        name: "FK_LicenseSuspensions_Licenses_License_Id",
                        column: x => x.License_Id,
                        principalTable: "Licenses",
                        principalColumn: "License_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ApplicationStatus_Id",
                table: "Applications",
                column: "ApplicationStatus_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ApplicationTests_Id",
                table: "Applications",
                column: "ApplicationTests_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_Creator_Id",
                table: "Applications",
                column: "Creator_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_LicenseClass_Id",
                table: "Applications",
                column: "LicenseClass_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_Person_Id",
                table: "Applications",
                column: "Person_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_Service_Id",
                table: "Applications",
                column: "Service_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_Person_Id",
                table: "Drivers",
                column: "Person_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_Driver_Id",
                table: "Licenses",
                column: "Driver_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_LicenseClass_Id",
                table: "Licenses",
                column: "LicenseClass_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LicenseSuspensions_License_Id",
                table: "LicenseSuspensions",
                column: "License_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Nationality_Id",
                table: "Persons",
                column: "Nationality_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalTests_ApplicationTests_Id",
                table: "PracticalTests",
                column: "ApplicationTests_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalTests_Fees_Id",
                table: "PracticalTests",
                column: "Fees_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Person_Id",
                table: "Users",
                column: "Person_Id");

            migrationBuilder.CreateIndex(
                name: "IX_VisionTests_ApplicationTests_Id",
                table: "VisionTests",
                column: "ApplicationTests_Id");

            migrationBuilder.CreateIndex(
                name: "IX_VisionTests_Fees_Id",
                table: "VisionTests",
                column: "Fees_Id");

            migrationBuilder.CreateIndex(
                name: "IX_WritenTests_ApplicationTests_Id",
                table: "WritenTests",
                column: "ApplicationTests_Id");

            migrationBuilder.CreateIndex(
                name: "IX_WritenTests_Fees_Id",
                table: "WritenTests",
                column: "Fees_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "LicenseSuspensions");

            migrationBuilder.DropTable(
                name: "PracticalTests");

            migrationBuilder.DropTable(
                name: "VisionTests");

            migrationBuilder.DropTable(
                name: "WritenTests");

            migrationBuilder.DropTable(
                name: "ApplicationStatuses");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "ApplicationsTestFees");

            migrationBuilder.DropTable(
                name: "ApplicationsTests");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "LicenseClasses");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Nationalities");
        }
    }
}
