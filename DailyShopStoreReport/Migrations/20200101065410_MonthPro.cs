using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyShopStoreReport.Migrations
{
    public partial class MonthPro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonthId",
                table: "YearlyDataModelViews");

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "YearlyDataModelViews",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "YearlyDataModelViews");

            migrationBuilder.AddColumn<int>(
                name: "MonthId",
                table: "YearlyDataModelViews",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
