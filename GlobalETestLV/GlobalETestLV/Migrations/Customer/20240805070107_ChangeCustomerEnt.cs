using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlobalETestLV.Migrations.Customer
{
    /// <inheritdoc />
    public partial class ChangeCustomerEnt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimerItemId",
                table: "Customers",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TimerItemId",
                table: "Customers",
                column: "TimerItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TimersItems_TimerItemId",
                table: "Customers",
                column: "TimerItemId",
                principalTable: "TimersItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TimersItems_TimerItemId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TimerItemId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TimerItemId",
                table: "Customers");
        }
    }
}
