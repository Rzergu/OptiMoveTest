using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GlobalETestLV.Migrations.Customer
{
    /// <inheritdoc />
    public partial class AddTimerItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimersFilters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Genders = table.Column<List<string>>(type: "text[]", nullable: false),
                    Cities = table.Column<List<string>>(type: "text[]", nullable: false),
                    DepositFrom = table.Column<int>(type: "integer", nullable: false),
                    DepositTo = table.Column<int>(type: "integer", nullable: false),
                    AgeFrom = table.Column<int>(type: "integer", nullable: false),
                    AgeTo = table.Column<int>(type: "integer", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimersFilters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimersItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    DateStart = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TemplateType = table.Column<int>(type: "integer", nullable: false),
                    FilterId = table.Column<int>(type: "integer", nullable: false),
                    Priority = table.Column<byte>(type: "smallint", nullable: false),
                    isFinished = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimersItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimersItems_TimersFilters_FilterId",
                        column: x => x.FilterId,
                        principalTable: "TimersFilters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimersItems_FilterId",
                table: "TimersItems",
                column: "FilterId");
            migrationBuilder.InsertData(
                table: "TimersFilters",
                columns: new[] { "Id", "Name", "Genders", "Cities", "DepositFrom", "DepositTo", "AgeFrom", "AgeTo", "IsNew" },
                    values: new object[,]
                    {
                                                {1,"All",new string[0], new string[0], 0, int.MaxValue, 0,200, null},
                                                {2,"Males",new string[] {"Male"}, new string[0], 0, int.MaxValue, 0,200, null},
                                                {3,"Females",new string[] {"Female"}, new string[0], 0, int.MaxValue, 0,200, null},
                    });
                    }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimersItems");

            migrationBuilder.DropTable(
                name: "TimersFilters");
        }
    }
}
