using Microsoft.EntityFrameworkCore.Migrations;

namespace Amazon.Api.Migrations
{
    public partial class Initi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Sanphams",
                columns: table => new
                {
                    SanphamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaSP = table.Column<double>(type: "float", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanphams", x => x.SanphamId);
                    table.ForeignKey(
                        name: "FK_Sanphams_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "ColorName" },
                values: new object[,]
                {
                    { 1, "White" },
                    { 2, "Black" },
                    { 3, "Yellow" },
                    { 4, "Green" },
                    { 5, "Blue" }
                });

            migrationBuilder.InsertData(
                table: "Sanphams",
                columns: new[] { "SanphamId", "ColorId", "GiaSP", "PhotoPath", "TenSP" },
                values: new object[,]
                {
                    { 1, 1, 150000.0, "images/sp1.png", "Maý tính" },
                    { 2, 2, 150000.0, "images/sp2.png", "Điện thoại" },
                    { 3, 3, 150000.0, "images/sp3.png", "Maý tính" },
                    { 4, 4, 150000.0, "images/sp4.png", "Maý tính" },
                    { 5, 5, 0.0, "images/sp5.png", "Maý tính" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sanphams_ColorId",
                table: "Sanphams",
                column: "ColorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sanphams");

            migrationBuilder.DropTable(
                name: "Colors");
        }
    }
}
