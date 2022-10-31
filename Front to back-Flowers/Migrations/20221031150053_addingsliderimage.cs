using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Front_to_back_Flowers.Migrations
{
    public partial class addingsliderimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgraundImg",
                table: "SliderIndexs");

            migrationBuilder.CreateTable(
                name: "SliderImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SliderPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderImages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SliderImages");

            migrationBuilder.AddColumn<string>(
                name: "BackgraundImg",
                table: "SliderIndexs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
