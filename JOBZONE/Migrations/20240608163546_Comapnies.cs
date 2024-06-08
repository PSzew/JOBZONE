using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JOBZONE.Migrations
{
    public partial class Comapnies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffer_Company_ID",
                table: "JobOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Company_ID",
                table: "Offers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffer_Companies_ID",
                table: "JobOffer",
                column: "ID",
                principalTable: "Companies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Companies_ID",
                table: "Offers",
                column: "ID",
                principalTable: "Companies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffer_Companies_ID",
                table: "JobOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Companies_ID",
                table: "Offers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffer_Company_ID",
                table: "JobOffer",
                column: "ID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Company_ID",
                table: "Offers",
                column: "ID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
