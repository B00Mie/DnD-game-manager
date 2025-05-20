using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class raceSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Races_Id",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "BaseAgility",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseIntelligence",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseStrength",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BaseUtility",
                table: "Races",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "BaseAgility", "BaseIntelligence", "BaseStrength", "BaseUtility", "BaseHP", "Discriminator", "Name", "NameRu", "Type", "TypeRu" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 200, "Race", "Human", "Человек", "CleanBlood", "Чистокровный" },
                    { 2, 1, 1, 2, 3, 350, "Race", "Dwarf", "Гном", "DirtyBlood", "Грязнокровка" },
                    { 3, 1, 1, 5, 3, 300, "Race", "Orc", "Орк", "CleanBlood", "Чистокровный" },
                    { 4, 4, 1, 1, 1, 200, "Race", "Khajiit", "Каджит", "DirtyBlood", "Грязнокровка" },
                    { 5, 1, 2, 3, 1, 325, "Race", "Underwater", "Глубоководный", "CleanBlood", "Чистокровный" },
                    { 6, 3, 3, 2, 2, 250, "Race", "Drow", "Тёмный эльф", "CleanBlood", "Чистокровный" },
                    { 7, 3, 1, 3, 2, 250, "Race", "WoodElf", "Лесной эльф", "CleanBlood", "Чистокровный" },
                    { 8, 2, 3, 2, 2, 250, "Race", "Winged", "Крылатый", "CleanBlood", "Чистокровный" },
                    { 9, 2, 3, 1, 3, 150, "Race", "Goblin", "Гоблин", "DirtyBlood", "Грязнокровка" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Races_RaceId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_RaceId",
                table: "Characters");

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "BaseAgility",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "BaseIntelligence",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "BaseStrength",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "BaseUtility",
                table: "Races");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Races_Id",
                table: "Characters",
                column: "Id",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
