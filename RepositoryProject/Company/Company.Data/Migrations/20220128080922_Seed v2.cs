using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Data.Migrations
{
    public partial class Seedv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CompanyId", "Name", "Position", "Salary", "Surname" },
                values: new object[] { 1, 1, "Bill", "CEO", 30000, "Gates" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
