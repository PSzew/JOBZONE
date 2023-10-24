using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JOBZONE.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Residence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActualJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActaulJobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobExperienceDescripton = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialSkill = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Applied",
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
                    table.PrimaryKey("PK_Applied", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Applied_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "CertificateModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingHost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CertificateModel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "EducationModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proffesion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peroid = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EducationModel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "JobExperienceModel",
                columns: table => new
                {
                    JobExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobFunction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComapnyLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployedSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployedTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Responsibilites = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobExperienceModel", x => x.JobExperienceId);
                    table.ForeignKey(
                        name: "FK_JobExperienceModel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "LanguageModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LanguageModel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "LinksModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinksModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LinksModel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "RecentlyViewedModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferID = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentlyViewedModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RecentlyViewedModel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applied_UserId",
                table: "Applied",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificateModel_UserId",
                table: "CertificateModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationModel_UserId",
                table: "EducationModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobExperienceModel_UserId",
                table: "JobExperienceModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguageModel_UserId",
                table: "LanguageModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LinksModel_UserId",
                table: "LinksModel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RecentlyViewedModel_UserId",
                table: "RecentlyViewedModel",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applied");

            migrationBuilder.DropTable(
                name: "CertificateModel");

            migrationBuilder.DropTable(
                name: "EducationModel");

            migrationBuilder.DropTable(
                name: "JobExperienceModel");

            migrationBuilder.DropTable(
                name: "LanguageModel");

            migrationBuilder.DropTable(
                name: "LinksModel");

            migrationBuilder.DropTable(
                name: "RecentlyViewedModel");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
