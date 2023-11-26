using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVLD.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Creating_Test_Types_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PracticalTests_ApplicationsTests_ApplicationTests_Id",
                        column: x => x.ApplicationTests_Id,
                        principalTable: "ApplicationsTests",
                        principalColumn: "ApplicationTests_Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisionTests_ApplicationsTests_ApplicationTests_Id",
                        column: x => x.ApplicationTests_Id,
                        principalTable: "ApplicationsTests",
                        principalColumn: "ApplicationTests_Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WritenTests_ApplicationsTests_ApplicationTests_Id",
                        column: x => x.ApplicationTests_Id,
                        principalTable: "ApplicationsTests",
                        principalColumn: "ApplicationTests_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PracticalTests_ApplicationTests_Id",
                table: "PracticalTests",
                column: "ApplicationTests_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PracticalTests_Fees_Id",
                table: "PracticalTests",
                column: "Fees_Id");

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
                name: "PracticalTests");

            migrationBuilder.DropTable(
                name: "VisionTests");

            migrationBuilder.DropTable(
                name: "WritenTests");
        }
    }
}
