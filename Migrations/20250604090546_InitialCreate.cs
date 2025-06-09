using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TranNhua.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OpTuong",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    noidung = table.Column<string>(type: "text", nullable: false),
                    chitietsanpham = table.Column<string>(type: "text", nullable: false),
                    thongso = table.Column<string>(type: "text", nullable: false),
                    soluong = table.Column<decimal>(type: "numeric", nullable: false),
                    dongia = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpTuong", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TranNhua",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    noidung = table.Column<string>(type: "text", nullable: false),
                    chitietsanpham = table.Column<string>(type: "text", nullable: false),
                    thongso = table.Column<string>(type: "text", nullable: false),
                    soluong = table.Column<decimal>(type: "numeric", nullable: false),
                    dongia = table.Column<decimal>(type: "numeric", nullable: false),
                    tranxop5 = table.Column<decimal>(type: "numeric", nullable: false),
                    tranxop8 = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranNhua", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TranTha",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    noidung = table.Column<string>(type: "text", nullable: false),
                    chitietsanpham = table.Column<string>(type: "text", nullable: false),
                    thongso = table.Column<string>(type: "text", nullable: false),
                    soluong = table.Column<decimal>(type: "numeric", nullable: false),
                    dongia = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranTha", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "VachNgan",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    noidung = table.Column<string>(type: "text", nullable: false),
                    chitietsanpham = table.Column<string>(type: "text", nullable: false),
                    thongso = table.Column<string>(type: "text", nullable: false),
                    soluong = table.Column<decimal>(type: "numeric", nullable: false),
                    vach1 = table.Column<decimal>(type: "numeric", nullable: false),
                    vach2 = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VachNgan", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpTuong");

            migrationBuilder.DropTable(
                name: "TranNhua");

            migrationBuilder.DropTable(
                name: "TranTha");

            migrationBuilder.DropTable(
                name: "VachNgan");
        }
    }
}
