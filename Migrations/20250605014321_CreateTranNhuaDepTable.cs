using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TranNhua.Migrations
{
    /// <inheritdoc />
    public partial class CreateTranNhuaDepTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TranNhua");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VachNgan",
                table: "VachNgan");

            migrationBuilder.DropColumn(
                name: "chitietsanpham",
                table: "VachNgan");

            migrationBuilder.DropColumn(
                name: "soluong",
                table: "VachNgan");

            migrationBuilder.DropColumn(
                name: "vach1",
                table: "VachNgan");

            migrationBuilder.DropColumn(
                name: "vach2",
                table: "VachNgan");

            migrationBuilder.DropColumn(
                name: "chitietsanpham",
                table: "TranTha");

            migrationBuilder.DropColumn(
                name: "dongia",
                table: "TranTha");

            migrationBuilder.DropColumn(
                name: "soluong",
                table: "TranTha");

            migrationBuilder.DropColumn(
                name: "chitietsanpham",
                table: "OpTuong");

            migrationBuilder.DropColumn(
                name: "dongia",
                table: "OpTuong");

            migrationBuilder.DropColumn(
                name: "soluong",
                table: "OpTuong");

            migrationBuilder.RenameTable(
                name: "VachNgan",
                newName: "Vachngan");

            migrationBuilder.RenameColumn(
                name: "thongso",
                table: "Vachngan",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "noidung",
                table: "Vachngan",
                newName: "images");

            migrationBuilder.RenameColumn(
                name: "thongso",
                table: "TranTha",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "noidung",
                table: "TranTha",
                newName: "images");

            migrationBuilder.RenameColumn(
                name: "thongso",
                table: "OpTuong",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "noidung",
                table: "OpTuong",
                newName: "images");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vachngan",
                table: "Vachngan",
                column: "id");

            migrationBuilder.CreateTable(
                name: "TranNhuaDep",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    images = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranNhuaDep", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TranNhuaDep");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vachngan",
                table: "Vachngan");

            migrationBuilder.RenameTable(
                name: "Vachngan",
                newName: "VachNgan");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "VachNgan",
                newName: "thongso");

            migrationBuilder.RenameColumn(
                name: "images",
                table: "VachNgan",
                newName: "noidung");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "TranTha",
                newName: "thongso");

            migrationBuilder.RenameColumn(
                name: "images",
                table: "TranTha",
                newName: "noidung");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "OpTuong",
                newName: "thongso");

            migrationBuilder.RenameColumn(
                name: "images",
                table: "OpTuong",
                newName: "noidung");

            migrationBuilder.AddColumn<string>(
                name: "chitietsanpham",
                table: "VachNgan",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "soluong",
                table: "VachNgan",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "vach1",
                table: "VachNgan",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "vach2",
                table: "VachNgan",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "chitietsanpham",
                table: "TranTha",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "dongia",
                table: "TranTha",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "soluong",
                table: "TranTha",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "chitietsanpham",
                table: "OpTuong",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "dongia",
                table: "OpTuong",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "soluong",
                table: "OpTuong",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VachNgan",
                table: "VachNgan",
                column: "id");

            migrationBuilder.CreateTable(
                name: "TranNhua",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    chitietsanpham = table.Column<string>(type: "text", nullable: false),
                    dongia = table.Column<decimal>(type: "numeric", nullable: false),
                    noidung = table.Column<string>(type: "text", nullable: false),
                    soluong = table.Column<decimal>(type: "numeric", nullable: false),
                    thongso = table.Column<string>(type: "text", nullable: false),
                    tranxop5 = table.Column<decimal>(type: "numeric", nullable: false),
                    tranxop8 = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranNhua", x => x.id);
                });
        }
    }
}
