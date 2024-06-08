using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JOBZONE.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Peroid",
                table: "EducationModel",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "EducationModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "EducationModel");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "EducationModel",
                newName: "Peroid");
        }
    }
}
