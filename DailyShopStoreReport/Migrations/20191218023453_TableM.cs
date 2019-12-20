using Microsoft.EntityFrameworkCore.Migrations;

namespace DailyShopStoreReport.Migrations
{
    public partial class TableM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityRoleId",
                table: "Incomes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityRoleId",
                table: "Expenses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_IdentityRoleId",
                table: "Incomes",
                column: "IdentityRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_IdentityRoleId",
                table: "Expenses",
                column: "IdentityRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_AspNetRoles_IdentityRoleId",
                table: "Expenses",
                column: "IdentityRoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_AspNetRoles_IdentityRoleId",
                table: "Incomes",
                column: "IdentityRoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_AspNetRoles_IdentityRoleId",
                table: "Expenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_AspNetRoles_IdentityRoleId",
                table: "Incomes");

            migrationBuilder.DropIndex(
                name: "IX_Incomes_IdentityRoleId",
                table: "Incomes");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_IdentityRoleId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "IdentityRoleId",
                table: "Incomes");

            migrationBuilder.DropColumn(
                name: "IdentityRoleId",
                table: "Expenses");
        }
    }
}
