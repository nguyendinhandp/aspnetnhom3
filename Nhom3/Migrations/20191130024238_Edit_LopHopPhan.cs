using Microsoft.EntityFrameworkCore.Migrations;

namespace Nhom3.Migrations
{
    public partial class Edit_LopHopPhan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Mon",
                table: "LopHocPhan",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mon",
                table: "LopHocPhan",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
