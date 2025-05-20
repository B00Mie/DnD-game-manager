using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class CharacterRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_SkillGroups_CharacterSkills_GenerallSkillsId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_SkillGroups_CharacterSkills_MagicSkillsId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_SkillGroups_CharacterSkills_WeaponSkillsId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryItems",
                table: "InventoryItems");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CharacterSkills_GenerallSkillsId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CharacterSkills_MagicSkillsId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CharacterSkills_WeaponSkillsId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharacterSkills_GenerallSkillsId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharacterSkills_MagicSkillsId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharacterSkills_SkillPoints",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharacterSkills_WeaponSkillsId",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "CharacterSkills_Id",
                table: "Characters",
                newName: "Stats_Id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CharacterClasses",
                newName: "ClassName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryItems",
                table: "InventoryItems",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CharacterSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    GenerallSkillsId = table.Column<int>(type: "INTEGER", nullable: false),
                    MagicSkillsId = table.Column<int>(type: "INTEGER", nullable: false),
                    WeaponSkillsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkills_SkillGroups_GenerallSkillsId",
                        column: x => x.GenerallSkillsId,
                        principalTable: "SkillGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkills_SkillGroups_MagicSkillsId",
                        column: x => x.MagicSkillsId,
                        principalTable: "SkillGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkills_SkillGroups_WeaponSkillsId",
                        column: x => x.WeaponSkillsId,
                        principalTable: "SkillGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_CharacterId",
                table: "CharacterSkills",
                column: "CharacterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_GenerallSkillsId",
                table: "CharacterSkills",
                column: "GenerallSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_MagicSkillsId",
                table: "CharacterSkills",
                column: "MagicSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_WeaponSkillsId",
                table: "CharacterSkills",
                column: "WeaponSkillsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryItems",
                table: "InventoryItems");

            migrationBuilder.RenameColumn(
                name: "Stats_Id",
                table: "Characters",
                newName: "CharacterSkills_Id");

            migrationBuilder.RenameColumn(
                name: "ClassName",
                table: "CharacterClasses",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "CharacterSkills_GenerallSkillsId",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CharacterSkills_MagicSkillsId",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CharacterSkills_SkillPoints",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CharacterSkills_WeaponSkillsId",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryItems",
                table: "InventoryItems",
                columns: new[] { "Id", "CharacterId" });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stats_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterSkills_GenerallSkillsId",
                table: "Characters",
                column: "CharacterSkills_GenerallSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterSkills_MagicSkillsId",
                table: "Characters",
                column: "CharacterSkills_MagicSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterSkills_WeaponSkillsId",
                table: "Characters",
                column: "CharacterSkills_WeaponSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_CharacterId",
                table: "Stats",
                column: "CharacterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_SkillGroups_CharacterSkills_GenerallSkillsId",
                table: "Characters",
                column: "CharacterSkills_GenerallSkillsId",
                principalTable: "SkillGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_SkillGroups_CharacterSkills_MagicSkillsId",
                table: "Characters",
                column: "CharacterSkills_MagicSkillsId",
                principalTable: "SkillGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_SkillGroups_CharacterSkills_WeaponSkillsId",
                table: "Characters",
                column: "CharacterSkills_WeaponSkillsId",
                principalTable: "SkillGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
