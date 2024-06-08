using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JOBZONE.Migrations
{
    public partial class certificates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CertificateModel_AspNetUsers_UserModelId",
                table: "CertificateModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CertificateModel",
                table: "CertificateModel");

            migrationBuilder.RenameTable(
                name: "CertificateModel",
                newName: "Certificates");

            migrationBuilder.RenameIndex(
                name: "IX_CertificateModel_UserModelId",
                table: "Certificates",
                newName: "IX_Certificates_UserModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Certificates_AspNetUsers_UserModelId",
                table: "Certificates",
                column: "UserModelId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Certificates_AspNetUsers_UserModelId",
                table: "Certificates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Certificates",
                table: "Certificates");

            migrationBuilder.RenameTable(
                name: "Certificates",
                newName: "CertificateModel");

            migrationBuilder.RenameIndex(
                name: "IX_Certificates_UserModelId",
                table: "CertificateModel",
                newName: "IX_CertificateModel_UserModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CertificateModel",
                table: "CertificateModel",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CertificateModel_AspNetUsers_UserModelId",
                table: "CertificateModel",
                column: "UserModelId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
