using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooking.Migrations
{
    /// <inheritdoc />
    public partial class Fix1Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reciepts_Countries_CountryId",
                table: "Reciepts");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Reciepts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reciepts_Countries_CountryId",
                table: "Reciepts",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reciepts_Countries_CountryId",
                table: "Reciepts");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Reciepts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reciepts_Countries_CountryId",
                table: "Reciepts",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
