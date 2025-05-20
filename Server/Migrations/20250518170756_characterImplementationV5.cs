using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class characterImplementationV5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Races_Stats_StatsId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_StatsId",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "StatsId",
                table: "Races");

            migrationBuilder.AddColumn<string>(
                name: "NameRu",
                table: "Races",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TypeRu",
                table: "Races",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BaseHP",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stats_CharacterId",
                table: "Stats",
                column: "CharacterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stats_Characters_CharacterId",
                table: "Stats",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stats_Characters_CharacterId",
                table: "Stats");

            migrationBuilder.DropIndex(
                name: "IX_Stats_CharacterId",
                table: "Stats");

            migrationBuilder.DropColumn(
                name: "NameRu",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "TypeRu",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "BaseHP",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "StatsId",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Races_StatsId",
                table: "Races",
                column: "StatsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Stats_StatsId",
                table: "Races",
                column: "StatsId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
