using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyShopStoreReport.Migrations
{
    public partial class PerdateProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PerDate",
                table: "Incomes",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PerDate",
                table: "Expenses",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Datetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PerDate",
                table: "Incomes",
                type: "Datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PerDate",
                table: "Expenses",
                type: "Datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }
    }
}
