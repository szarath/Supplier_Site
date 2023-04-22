using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Supplier_Site.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSupplierTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelephoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Code", "Name", "TelephoneNo" },
                values: new object[,]
                {
                    { 1, 234, "Eskom Holdings Limited", "086 0037566" },
                    { 2, 939, "Focus Rooms (Pty) Ltd", "0820776910" },
                    { 3, 34, "GSM Electro", "0128110069" },
                    { 4, 1264, "Jody and Herman Investments CC", "0118864227" },
                    { 5, 5667, "Johan Le Roux Ingenieurswerke", "0233423390" },
                    { 6, 667, "L. J. Ross t/a Petite Cafe'", "0117868101" },
                    { 7, 45, "L.A Auto Center  CC t/a LA Body Works", "0219488412" },
                    { 8, 1351, "LG Tow-In CC", "0828044026" },
                    { 9, 1352, "LM Greyling t/aThe Electric Advertiser", "0119545972" },
                    { 10, 1437, "M.H Cloete Enterprises (Pty) Ltd  t/a  Rola Motors", "0218418300" },
                    { 11, 67, "M.M Hydraulics CC", "011425 6578" },
                    { 12, 1980, "Phulo Human Capital (Pty) Ltd", "0114755934" },
                    { 13, 345, "Picaro 115 CC t/a H2O CT Services", "0216745710" },
                    { 14, 2279, "Safetygrip CC", "0117086660" },
                    { 15, 876, "Safic (Pty) Ltd", "0114064000" },
                    { 16, 2549, "The Financial Planning Institute Of Southern Africa", "0861000374" },
                    { 17, 935, "The Fitment Zone  CC", "0118234181" },
                    { 18, 2693, "Turnweld Engineering CC", "0115468790" },
                    { 19, 6, "Tutuka Motor Holdings Pty Ltd t/a Tutuka Motor Lab", "0117044324" },
                    { 20, 134, "WP Exhaust Brake & Clutch t/a In Focus Fleet Services", "0219055028" },
                    { 21, 3277, "WP Sekuriteit", "0233421732" },
                    { 22, 53, "Brietta Trading (Pty) Ltd", "0115526000" },
                    { 23, 392, "C.N. Braam t/a CNB Electrical Services", "0832835399" },
                    { 24, 625, "Creative Crew (Pty) Ltd", "0120040218" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
