﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infarstuructre.Migrations
{
    /// <inheritdoc />
    public partial class TBBestSellingProductsHomeContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBBestSellingProductsHomeContents",
                columns: table => new
                {
                    IdBestSellingProductsHomeContent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleOneAr = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    TitleOneEn = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    TitleTwoAr = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    TitleTwoEn = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DataEntry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeEntry = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    CurrentState = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBBestSellingProductsHomeContents", x => x.IdBestSellingProductsHomeContent);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBBestSellingProductsHomeContents");
        }
    }
}
