using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JOBZONE.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOfferModel_Company_ID",
                table: "JobOfferModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobOfferModel",
                table: "JobOfferModel");

            migrationBuilder.RenameTable(
                name: "JobOfferModel",
                newName: "JobOffer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobOffer",
                table: "JobOffer",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffer_Company_ID",
                table: "JobOffer",
                column: "ID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffer_Company_ID",
                table: "JobOffer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobOffer",
                table: "JobOffer");

            migrationBuilder.RenameTable(
                name: "JobOffer",
                newName: "JobOfferModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobOfferModel",
                table: "JobOfferModel",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOfferModel_Company_ID",
                table: "JobOfferModel",
                column: "ID",
                principalTable: "Company",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
