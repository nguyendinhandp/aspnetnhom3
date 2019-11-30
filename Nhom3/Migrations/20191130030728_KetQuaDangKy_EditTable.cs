using Microsoft.EntityFrameworkCore.Migrations;

namespace Nhom3.Migrations
{
    public partial class KetQuaDangKy_EditTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KetQuaHocTap",
                columns: table => new
                {
                    MaLHP = table.Column<int>(nullable: false),
                    MaMon = table.Column<int>(nullable: false),
                    MaSV = table.Column<int>(nullable: false),
                    DGK = table.Column<double>(nullable: false),
                    DCK = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KetQuaHocTap", x => new { x.MaLHP, x.MaMon, x.MaSV });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KetQuaHocTap");
        }
    }
}
