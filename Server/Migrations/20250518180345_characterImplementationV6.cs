using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class characterImplementationV6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Races_Stats_BasicStatsId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_BasicStatsId",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "BasicStatsId",
                table: "Races");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BasicStatsId",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Races_BasicStatsId",
                table: "Races",
                column: "BasicStatsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Stats_BasicStatsId",
                table: "Races",
                column: "BasicStatsId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
