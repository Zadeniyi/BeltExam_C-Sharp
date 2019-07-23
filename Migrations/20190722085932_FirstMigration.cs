using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ActivityCenter.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "NewActivitys",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    ActDate = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false),
                    Updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewActivitys", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_NewActivitys_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActConnects",
                columns: table => new
                {
                    ActConnectId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ActivityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActConnects", x => x.ActConnectId);
                    table.ForeignKey(
                        name: "FK_ActConnects_NewActivitys_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "NewActivitys",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActConnects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActConnects_ActivityId",
                table: "ActConnects",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActConnects_UserId",
                table: "ActConnects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NewActivitys_UserId",
                table: "NewActivitys",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActConnects");

            migrationBuilder.DropTable(
                name: "NewActivitys");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
