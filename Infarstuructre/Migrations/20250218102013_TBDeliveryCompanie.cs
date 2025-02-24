using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infarstuructre.Migrations
{
    /// <inheritdoc />
    public partial class TBDeliveryCompanie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBDeliveryCompanies",
                columns: table => new
                {
                    IdDeliveryCompanie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryCompanie = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OnerName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    OnerPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmilCompanie = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    EmilOner = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DeliveryCompanieAddress = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataEntry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeEntry = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    CurrentState = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBDeliveryCompanies", x => x.IdDeliveryCompanie);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBDeliveryCompanies");
        }
    }
}
