using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GlobalETestLV.Migrations.Customer
{
    /// <inheritdoc />
    public partial class AddQuartz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Age = table.Column<byte>(type: "smallint", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Deposit = table.Column<int>(type: "integer", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });
                migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id","Age","Gender","City","Deposit","IsNew" },
                    values: new object[,]
                    {
                        { 61, 33, "Female", "Phoenix", 93, true },
                        { 4, 95, "Male", "Los Angeles", 49, false },
                        { 9, 89, "Male", "New York", 79, true },
                        { 23, 65, "Male", "Los Angeles", 11, true },
                        { 48, 27, "Male", "Chicago", 62, true },
                        { 98, 88, "Female", "Los Angeles", 3, false },
                        { 16, 68, "Male", "Chicago", 35, true },
                        { 91, 28, "Male", "Los Angeles", 91, false },
                        { 161, 19, "Female", "Phoenix", 24, true },
                        { 11, 76, "Male", "New York", 99, false },
                        { 86, 66, "Male", "Phoenix", 10, true },
                        { 912, 31, "Male", "Chicago", 82, false },
                        { 54, 30, "Male", "Chicago", 59, false },
                        { 92, 64, "Male", "Los Angeles", 74, true },
                        { 1, 71, "Male", "Los Angeles", 64, true },
                        { 44, 90, "Male", "Phoenix", 61, false },
                        { 20, 43, "Female", "Los Angeles", 85, true },
                        { 541, 73, "Female", "Phoenix", 28, true },
                        { 29, 41, "Male", "Chicago", 62, false },
                        { 201, 59, "Female", "Phoenix", 91, true },
                        { 78, 99, "Male", "Chicago", 88, false },
                        { 64, 55, "Male", "Houston", 66, true },
                        { 90, 21, "Female", "New York", 52, false },
                        { 96, 34, "Female", "Phoenix", 7, false },
                        { 14, 70, "Female", "Houston", 68, false },
                        { 6, 39, "Female", "Houston", 73, false },
                        { 38, 57, "Female", "Los Angeles", 99, false },
                        { 39, 54, "Male", "New York", 3, false },
                        { 381, 92, "Male", "New York", 78, false },
                        { 31, 55, "Female", "Chicago", 65, true },
                        { 26, 48, "Female", "Los Angeles", 74, false },
                        { 30, 55, "Female", "Houston", 40, false },
                        { 99, 41, "Male", "Houston", 56, false },
                        { 861, 68, "Female", "Los Angeles", 88, true },
                        { 27, 95, "Female", "Los Angeles", 54, true },
                        { 913, 87, "Male", "Phoenix", 65, false },
                        { 71, 21, "Female", "Chicago", 27, false },
                        { 60, 74, "Male", "Houston", 63, true },
                        { 87, 19, "Male", "Phoenix", 24, true },
                        { 42, 43, "Female", "New York", 70, true }
                    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
