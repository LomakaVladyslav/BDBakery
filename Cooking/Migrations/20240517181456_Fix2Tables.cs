using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooking.Migrations
{
    /// <inheritdoc />
    public partial class Fix2Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorReciepts_Authors_AuthorId1",
                table: "AuthorReciepts");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorReciepts_Reciepts_RecieptId1",
                table: "AuthorReciepts");

            migrationBuilder.DropIndex(
                name: "IX_AuthorReciepts_AuthorId1",
                table: "AuthorReciepts");

            migrationBuilder.DropIndex(
                name: "IX_AuthorReciepts_RecieptId1",
                table: "AuthorReciepts");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "AuthorReciepts");

            migrationBuilder.DropColumn(
                name: "RecieptId1",
                table: "AuthorReciepts");

            migrationBuilder.AlterColumn<int>(
                name: "RecieptId",
                table: "AuthorReciepts",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "AuthorReciepts",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuthorReciepts_AuthorId",
                table: "AuthorReciepts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorReciepts_RecieptId",
                table: "AuthorReciepts",
                column: "RecieptId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorReciepts_Authors_AuthorId",
                table: "AuthorReciepts",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorReciepts_Reciepts_RecieptId",
                table: "AuthorReciepts",
                column: "RecieptId",
                principalTable: "Reciepts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorReciepts_Authors_AuthorId",
                table: "AuthorReciepts");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorReciepts_Reciepts_RecieptId",
                table: "AuthorReciepts");

            migrationBuilder.DropIndex(
                name: "IX_AuthorReciepts_AuthorId",
                table: "AuthorReciepts");

            migrationBuilder.DropIndex(
                name: "IX_AuthorReciepts_RecieptId",
                table: "AuthorReciepts");

            migrationBuilder.AlterColumn<string>(
                name: "RecieptId",
                table: "AuthorReciepts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "AuthorReciepts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId1",
                table: "AuthorReciepts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecieptId1",
                table: "AuthorReciepts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuthorReciepts_AuthorId1",
                table: "AuthorReciepts",
                column: "AuthorId1");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorReciepts_RecieptId1",
                table: "AuthorReciepts",
                column: "RecieptId1");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorReciepts_Authors_AuthorId1",
                table: "AuthorReciepts",
                column: "AuthorId1",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorReciepts_Reciepts_RecieptId1",
                table: "AuthorReciepts",
                column: "RecieptId1",
                principalTable: "Reciepts",
                principalColumn: "Id");
        }
    }
}
