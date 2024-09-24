using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcampJovens.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Camper_CamperId",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Camper",
                table: "Camper");

            migrationBuilder.RenameTable(
                name: "Camper",
                newName: "Campers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campers",
                table: "Campers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Campers_CamperId",
                table: "Messages",
                column: "CamperId",
                principalTable: "Campers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Campers_CamperId",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campers",
                table: "Campers");

            migrationBuilder.RenameTable(
                name: "Campers",
                newName: "Camper");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Camper",
                table: "Camper",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Camper_CamperId",
                table: "Messages",
                column: "CamperId",
                principalTable: "Camper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
