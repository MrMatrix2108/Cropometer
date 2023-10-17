using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CropsAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CropName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CropYield = table.Column<int>(type: "int", nullable: true),
                    CropExpenses = table.Column<double>(type: "float", nullable: true),
                    CropIncome = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Crops__3214EC0729AABA17", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crops");
        }
    }
}
