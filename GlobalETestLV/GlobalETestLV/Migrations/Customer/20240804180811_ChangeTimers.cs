using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GlobalETestLV.Migrations.Customer
{
    /// <inheritdoc />
    public partial class ChangeTimers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateStart",
                table: "TimersItems");

            migrationBuilder.DropColumn(
                name: "isFinished",
                table: "TimersItems");

            migrationBuilder.RenameColumn(
                name: "TemplateType",
                table: "TimersItems",
                newName: "Template");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "TimersItems",
                type: "integer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "Time",
                table: "TimersItems",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "TimersItems");

            migrationBuilder.RenameColumn(
                name: "Template",
                table: "TimersItems",
                newName: "TemplateType");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "TimersItems",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStart",
                table: "TimersItems",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "isFinished",
                table: "TimersItems",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
