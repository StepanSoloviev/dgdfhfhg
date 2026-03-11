using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apteka.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZakLeks_Leks_lekIDL",
                table: "ZakLeks");

            migrationBuilder.DropForeignKey(
                name: "FK_ZakLeks_Zakazs_zakazIDZ",
                table: "ZakLeks");

            migrationBuilder.RenameColumn(
                name: "zakazIDZ",
                table: "ZakLeks",
                newName: "ZakazIDZ");

            migrationBuilder.RenameColumn(
                name: "lekIDL",
                table: "ZakLeks",
                newName: "LekIDL");

            migrationBuilder.RenameIndex(
                name: "IX_ZakLeks_zakazIDZ",
                table: "ZakLeks",
                newName: "IX_ZakLeks_ZakazIDZ");

            migrationBuilder.RenameIndex(
                name: "IX_ZakLeks_lekIDL",
                table: "ZakLeks",
                newName: "IX_ZakLeks_LekIDL");

            migrationBuilder.AddForeignKey(
                name: "FK_ZakLeks_Leks_LekIDL",
                table: "ZakLeks",
                column: "LekIDL",
                principalTable: "Leks",
                principalColumn: "IDL");

            migrationBuilder.AddForeignKey(
                name: "FK_ZakLeks_Zakazs_ZakazIDZ",
                table: "ZakLeks",
                column: "ZakazIDZ",
                principalTable: "Zakazs",
                principalColumn: "IDZ",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZakLeks_Leks_LekIDL",
                table: "ZakLeks");

            migrationBuilder.DropForeignKey(
                name: "FK_ZakLeks_Zakazs_ZakazIDZ",
                table: "ZakLeks");

            migrationBuilder.RenameColumn(
                name: "ZakazIDZ",
                table: "ZakLeks",
                newName: "zakazIDZ");

            migrationBuilder.RenameColumn(
                name: "LekIDL",
                table: "ZakLeks",
                newName: "lekIDL");

            migrationBuilder.RenameIndex(
                name: "IX_ZakLeks_ZakazIDZ",
                table: "ZakLeks",
                newName: "IX_ZakLeks_zakazIDZ");

            migrationBuilder.RenameIndex(
                name: "IX_ZakLeks_LekIDL",
                table: "ZakLeks",
                newName: "IX_ZakLeks_lekIDL");

            migrationBuilder.AddForeignKey(
                name: "FK_ZakLeks_Leks_lekIDL",
                table: "ZakLeks",
                column: "lekIDL",
                principalTable: "Leks",
                principalColumn: "IDL");

            migrationBuilder.AddForeignKey(
                name: "FK_ZakLeks_Zakazs_zakazIDZ",
                table: "ZakLeks",
                column: "zakazIDZ",
                principalTable: "Zakazs",
                principalColumn: "IDZ",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
