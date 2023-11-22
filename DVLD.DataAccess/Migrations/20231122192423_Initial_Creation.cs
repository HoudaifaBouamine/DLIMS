using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Creation : Migration
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
                name: "Drivers",
                columns: table => new
                {
                    Driver_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Driver_Id);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Licenses_LicenseClasses_LicenseClass_Id",
                        column: x => x.LicenseClass_Id,
                        principalTable: "LicenseClasses",
                        principalColumn: "LicenseClass_Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_Driver_Id",
                table: "Licenses",
                column: "Driver_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_LicenseClass_Id",
                table: "Licenses",
                column: "LicenseClass_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Nationality_Id",
                table: "Persons",
                column: "Nationality_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationStatuses");

            migrationBuilder.DropTable(
                name: "ApplicationsTestFees");

            migrationBuilder.DropTable(
                name: "ApplicationsTests");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "LicenseClasses");

            migrationBuilder.DropTable(
                name: "Nationalities");
        }
    }
}
