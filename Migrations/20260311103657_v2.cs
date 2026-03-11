using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apteka.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leks_Leks_LekIDL",
                table: "Leks");

            migrationBuilder.DropIndex(
                name: "IX_Leks_LekIDL",
                table: "Leks");

            migrationBuilder.DropColumn(
                name: "LekIDL",
                table: "Leks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LekIDL",
                table: "Leks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leks_LekIDL",
                table: "Leks",
                column: "LekIDL");

            migrationBuilder.AddForeignKey(
                name: "FK_Leks_Leks_LekIDL",
                table: "Leks",
                column: "LekIDL",
                principalTable: "Leks",
                principalColumn: "IDL");
        }
    }
}
