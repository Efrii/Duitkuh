using Microsoft.EntityFrameworkCore.Migrations;

namespace Duitkuh.Migrations
{
    public partial class Duitkuh01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_M_Role",
                columns: table => new
                {
                    Id_Role = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Role", x => x.Id_Role);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_User",
                columns: table => new
                {
                    Id_User = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_User", x => x.Id_User);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_UserRole",
                columns: table => new
                {
                    Id_User = table.Column<int>(nullable: false),
                    Id_Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_UserRole", x => x.Id_User);
                    table.ForeignKey(
                        name: "FK_TB_M_UserRole_TB_M_Role_Id_Role",
                        column: x => x.Id_Role,
                        principalTable: "TB_M_Role",
                        principalColumn: "Id_Role",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_M_UserRole_TB_M_User_Id_User",
                        column: x => x.Id_User,
                        principalTable: "TB_M_User",
                        principalColumn: "Id_User",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_UserRole_Id_Role",
                table: "TB_M_UserRole",
                column: "Id_Role");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_M_UserRole");

            migrationBuilder.DropTable(
                name: "TB_M_Role");

            migrationBuilder.DropTable(
                name: "TB_M_User");
        }
    }
}
