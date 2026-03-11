using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apteka.Migrations
{
    /// <inheritdoc />
    public partial class q4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IDPo",
                table: "Zakazs",
                newName: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Zakazs",
                newName: "IDPo");
        }
    }
}
