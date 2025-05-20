using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class characterReworks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stats_Agility",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stats_EnergyMagickLvl",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stats_IceMagickLvl",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stats_Intelligence",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stats_Strength",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stats_Utility",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Stats_WaterMagickLvl",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stats_Agility",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Stats_EnergyMagickLvl",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Stats_IceMagickLvl",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Stats_Intelligence",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Stats_Strength",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Stats_Utility",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Stats_WaterMagickLvl",
                table: "Characters");
        }
    }
}
