using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESite.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "esiteHomes",
                columns: table => new
                {
                    productNmae = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    productID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_esiteHomes", x => x.productNmae);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "esiteHomes");
        }
    }
}
