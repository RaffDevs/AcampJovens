using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AcampJovens.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCamperTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentFullName",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "SonFullName",
                table: "Messages",
                newName: "SenderName");

            migrationBuilder.AddColumn<int>(
                name: "CamperId",
                table: "Messages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Camper",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camper", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CamperId",
                table: "Messages",
                column: "CamperId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Camper_CamperId",
                table: "Messages",
                column: "CamperId",
                principalTable: "Camper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Camper_CamperId",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "Camper");

            migrationBuilder.DropIndex(
                name: "IX_Messages_CamperId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CamperId",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "SenderName",
                table: "Messages",
                newName: "SonFullName");

            migrationBuilder.AddColumn<string>(
                name: "ParentFullName",
                table: "Messages",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
