using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JOBZONE.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applied");

            migrationBuilder.CreateTable(
                name: "AppliedModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppliedModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AppliedModel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JobOfferModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    Workplace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfContract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalaryMin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryMax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WorkDays = table.Column<int>(type: "int", nullable: false),
                    WorkHours = table.Column<int>(type: "int", nullable: false),
                    OfferColapseTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dueties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Benefits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOfferModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_JobOfferModel_Company_ID",
                        column: x => x.ID,
                        principalTable: "Company",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppliedModel_UserId",
                table: "AppliedModel",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppliedModel");

            migrationBuilder.DropTable(
                name: "JobOfferModel");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.CreateTable(
                name: "Applied",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    OfferID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applied", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Applied_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applied_UserId",
                table: "Applied",
                column: "UserId");
        }
    }
}
