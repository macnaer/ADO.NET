using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Data.Migrations
{
    public partial class Addnewmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ITCompany_ITCompanyId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITCompany",
                table: "ITCompany");

            migrationBuilder.RenameTable(
                name: "ITCompany",
                newName: "ITCompanies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITCompanies",
                table: "ITCompanies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ITCompanies_ITCompanyId",
                table: "Users",
                column: "ITCompanyId",
                principalTable: "ITCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ITCompanies_ITCompanyId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITCompanies",
                table: "ITCompanies");

            migrationBuilder.RenameTable(
                name: "ITCompanies",
                newName: "ITCompany");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITCompany",
                table: "ITCompany",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ITCompany_ITCompanyId",
                table: "Users",
                column: "ITCompanyId",
                principalTable: "ITCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
