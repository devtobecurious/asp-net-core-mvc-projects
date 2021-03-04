using Microsoft.EntityFrameworkCore.Migrations;

namespace SelfiesAWookie.Core.Infrastructure.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wookie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainWeaponId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wookie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wookie_Weapon_MainWeaponId",
                        column: x => x.MainWeaponId,
                        principalTable: "Weapon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Selfie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selfie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Selfie_Wookie_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Wookie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Selfie_OwnerId",
                table: "Selfie",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Wookie_MainWeaponId",
                table: "Wookie",
                column: "MainWeaponId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Selfie");

            migrationBuilder.DropTable(
                name: "Wookie");

            migrationBuilder.DropTable(
                name: "Weapon");
        }
    }
}
