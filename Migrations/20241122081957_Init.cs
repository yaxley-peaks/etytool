using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EtyTool.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "etymology",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("etymology_pk", x => x.id);
                },
                comment: "List of langs seen before");

            migrationBuilder.CreateTable(
                name: "langs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    code = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false, comment: "ISO 639 SET 1, 2 letter codes")
                },
                constraints: table =>
                {
                    table.PrimaryKey("langs_pk", x => x.id);
                },
                comment: "Languages");

            migrationBuilder.CreateTable(
                name: "words",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "PK")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    word = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "word"),
                    lang = table.Column<int>(type: "integer", nullable: false, comment: "fk from langs, language the word is in"),
                    etymology = table.Column<int>(type: "integer", nullable: false, comment: "Lang whence a word comes from")
                },
                constraints: table =>
                {
                    table.PrimaryKey("word__pk", x => x.id);
                    table.ForeignKey(
                        name: "words_etymology_id_fk",
                        column: x => x.etymology,
                        principalTable: "etymology",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "words_langs_id_fk",
                        column: x => x.lang,
                        principalTable: "langs",
                        principalColumn: "id");
                },
                comment: "associate word with etymology");

            migrationBuilder.CreateIndex(
                name: "etymology_name_uniq",
                table: "etymology",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "langs_code_uniq",
                table: "langs",
                column: "code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_words_etymology",
                table: "words",
                column: "etymology");

            migrationBuilder.CreateIndex(
                name: "IX_words_lang",
                table: "words",
                column: "lang");

            migrationBuilder.CreateIndex(
                name: "word_uniq",
                table: "words",
                column: "word",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "words");

            migrationBuilder.DropTable(
                name: "etymology");

            migrationBuilder.DropTable(
                name: "langs");
        }
    }
}
