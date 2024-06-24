using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cooking.Migrations
{
    /// <inheritdoc />
    public partial class Photos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhotoUrlId",
                table: "Reciepts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhotosId",
                table: "Reciepts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reciepts_PhotosId",
                table: "Reciepts",
                column: "PhotosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reciepts_Photos_PhotosId",
                table: "Reciepts",
                column: "PhotosId",
                principalTable: "Photos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reciepts_Photos_PhotosId",
                table: "Reciepts");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Reciepts_PhotosId",
                table: "Reciepts");

            migrationBuilder.DropColumn(
                name: "PhotoUrlId",
                table: "Reciepts");

            migrationBuilder.DropColumn(
                name: "PhotosId",
                table: "Reciepts");
        }
    }
}
