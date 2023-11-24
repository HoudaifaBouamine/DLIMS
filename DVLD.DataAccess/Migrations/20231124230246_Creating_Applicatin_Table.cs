using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Creating_Applicatin_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_ApplicationsTests_ApplicationTests_Id",
                        column: x => x.ApplicationTests_Id,
                        principalTable: "ApplicationsTests",
                        principalColumn: "ApplicationTests_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_LicenseClasses_LicenseClass_Id",
                        column: x => x.LicenseClass_Id,
                        principalTable: "LicenseClasses",
                        principalColumn: "LicenseClass_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Persons_Person_Id",
                        column: x => x.Person_Id,
                        principalTable: "Persons",
                        principalColumn: "Person_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Service_Service_Id",
                        column: x => x.Service_Id,
                        principalTable: "Service",
                        principalColumn: "Service_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Users_Creator_Id",
                        column: x => x.Creator_Id,
                        principalTable: "Users",
                        principalColumn: "User_Id",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Service");
        }
    }
}
