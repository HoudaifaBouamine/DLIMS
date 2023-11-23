using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Add_LicenseSuspension_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LicenseSuspensions_License_Id",
                table: "LicenseSuspensions",
                column: "License_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LicenseSuspensions");
        }
    }

}
