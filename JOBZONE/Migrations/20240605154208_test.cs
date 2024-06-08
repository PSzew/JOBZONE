using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JOBZONE.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationModel_AspNetUsers_UserModelId",
                table: "EducationModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationModel",
                table: "EducationModel");

            migrationBuilder.RenameTable(
                name: "EducationModel",
                newName: "Education");

            migrationBuilder.RenameIndex(
                name: "IX_EducationModel_UserModelId",
                table: "Education",
                newName: "IX_Education_UserModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Education",
                table: "Education",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_AspNetUsers_UserModelId",
                table: "Education",
                column: "UserModelId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_AspNetUsers_UserModelId",
                table: "Education");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Education",
                table: "Education");

            migrationBuilder.RenameTable(
                name: "Education",
                newName: "EducationModel");

            migrationBuilder.RenameIndex(
                name: "IX_Education_UserModelId",
                table: "EducationModel",
                newName: "IX_EducationModel_UserModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationModel",
                table: "EducationModel",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationModel_AspNetUsers_UserModelId",
                table: "EducationModel",
                column: "UserModelId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
