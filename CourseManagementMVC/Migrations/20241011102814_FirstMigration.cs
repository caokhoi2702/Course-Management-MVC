using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseManagementMVC.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhoaHoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoaHoc = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHoc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMonHoc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KhoaHocID = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhoaHoc");

            migrationBuilder.DropTable(
                name: "MonHoc");
        }
    }
}
