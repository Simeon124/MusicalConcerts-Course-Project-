using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class initCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Performers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcertStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserConcertsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConcertUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConcertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConcertUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConcertUsers_Concerts_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcertUsersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_ConcertUsers_ConcertUsersId",
                        column: x => x.ConcertUsersId,
                        principalTable: "ConcertUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserConcerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserConcerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserConcerts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_UserConcertsId",
                table: "Concerts",
                column: "UserConcertsId");

            migrationBuilder.CreateIndex(
                name: "IX_ConcertUsers_ConcertId",
                table: "ConcertUsers",
                column: "ConcertId");

            migrationBuilder.CreateIndex(
                name: "IX_UserConcerts_UserId",
                table: "UserConcerts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ConcertUsersId",
                table: "Users",
                column: "ConcertUsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Concerts_UserConcerts_UserConcertsId",
                table: "Concerts",
                column: "UserConcertsId",
                principalTable: "UserConcerts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concerts_UserConcerts_UserConcertsId",
                table: "Concerts");

            migrationBuilder.DropTable(
                name: "UserConcerts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ConcertUsers");

            migrationBuilder.DropTable(
                name: "Concerts");
        }
    }
}
