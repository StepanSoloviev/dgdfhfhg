using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apteka.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZakLeks_Zakazs_IDL",
                table: "ZakLeks");

            migrationBuilder.DropIndex(
                name: "IX_ZakLeks_IDL",
                table: "ZakLeks");

            migrationBuilder.DropColumn(
                name: "IDL",
                table: "ZakLeks");

            migrationBuilder.DropColumn(
                name: "IDAk",
                table: "Leks");

            migrationBuilder.DropColumn(
                name: "IDPr",
                table: "Leks");

            migrationBuilder.DropColumn(
                name: "IDVZ",
                table: "Leks");

            migrationBuilder.RenameColumn(
                name: "IDZ",
                table: "ZakLeks",
                newName: "zakazIDZ");

            migrationBuilder.CreateIndex(
                name: "IX_ZakLeks_zakazIDZ",
                table: "ZakLeks",
                column: "zakazIDZ");

            migrationBuilder.AddForeignKey(
                name: "FK_ZakLeks_Zakazs_zakazIDZ",
                table: "ZakLeks",
                column: "zakazIDZ",
                principalTable: "Zakazs",
                principalColumn: "IDZ",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZakLeks_Zakazs_zakazIDZ",
                table: "ZakLeks");

            migrationBuilder.DropIndex(
                name: "IX_ZakLeks_zakazIDZ",
                table: "ZakLeks");

            migrationBuilder.RenameColumn(
                name: "zakazIDZ",
                table: "ZakLeks",
                newName: "IDZ");

            migrationBuilder.AddColumn<int>(
                name: "IDL",
                table: "ZakLeks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDAk",
                table: "Leks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDPr",
                table: "Leks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDVZ",
                table: "Leks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ZakLeks_IDL",
                table: "ZakLeks",
                column: "IDL");

            migrationBuilder.AddForeignKey(
                name: "FK_ZakLeks_Zakazs_IDL",
                table: "ZakLeks",
                column: "IDL",
                principalTable: "Zakazs",
                principalColumn: "IDZ",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
