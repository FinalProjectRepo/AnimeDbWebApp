using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeDbWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AnimeNullableChangeAndSynopsis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animes_AnimeTypes_TypeId",
                table: "Animes");

            migrationBuilder.DropColumn(
                name: "Sypnosis",
                table: "Animes");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Animes",
                type: "int",
                nullable: true,
                comment: "Type of anime(tv series, movie, etc.)",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Type of anime(tv series, movie, etc.)");

            migrationBuilder.AlterColumn<int>(
                name: "Season",
                table: "Animes",
                type: "int",
                nullable: true,
                comment: "Yearly anime season that anime aired",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Yearly anime season that anime aired");

            migrationBuilder.AlterColumn<decimal>(
                name: "Score",
                table: "Animes",
                type: "DECIMAL(4,2)",
                nullable: true,
                comment: "Populairty/liked score of anime",
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(4,2)",
                oldComment: "Populairty/liked score of anime");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Animes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Age restriction for anime",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldComment: "Age restriction for anime");

            migrationBuilder.AlterColumn<int>(
                name: "Rank",
                table: "Animes",
                type: "int",
                nullable: true,
                comment: "Anime rank",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Anime rank");

            migrationBuilder.AlterColumn<int>(
                name: "Episodes",
                table: "Animes",
                type: "int",
                nullable: true,
                comment: "Number of episodes",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Number of episodes");

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Animes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                comment: "Duration of episode",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldComment: "Duration of episode");

            migrationBuilder.AlterColumn<string>(
                name: "Background",
                table: "Animes",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Short description",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Short description");

            migrationBuilder.AddColumn<string>(
                name: "Synopsis",
                table: "Animes",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Short description");

            migrationBuilder.AddForeignKey(
                name: "FK_Animes_AnimeTypes_TypeId",
                table: "Animes",
                column: "TypeId",
                principalTable: "AnimeTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animes_AnimeTypes_TypeId",
                table: "Animes");

            migrationBuilder.DropColumn(
                name: "Synopsis",
                table: "Animes");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Animes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Type of anime(tv series, movie, etc.)",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Type of anime(tv series, movie, etc.)");

            migrationBuilder.AlterColumn<int>(
                name: "Season",
                table: "Animes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Yearly anime season that anime aired",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Yearly anime season that anime aired");

            migrationBuilder.AlterColumn<decimal>(
                name: "Score",
                table: "Animes",
                type: "DECIMAL(4,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "Populairty/liked score of anime",
                oldClrType: typeof(decimal),
                oldType: "DECIMAL(4,2)",
                oldNullable: true,
                oldComment: "Populairty/liked score of anime");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Animes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                comment: "Age restriction for anime",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Age restriction for anime");

            migrationBuilder.AlterColumn<int>(
                name: "Rank",
                table: "Animes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Anime rank",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Anime rank");

            migrationBuilder.AlterColumn<int>(
                name: "Episodes",
                table: "Animes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Number of episodes",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldComment: "Number of episodes");

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Animes",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                comment: "Duration of episode",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "Duration of episode");

            migrationBuilder.AlterColumn<string>(
                name: "Background",
                table: "Animes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Short description",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Short description");

            migrationBuilder.AddColumn<string>(
                name: "Sypnosis",
                table: "Animes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Short description");

            migrationBuilder.AddForeignKey(
                name: "FK_Animes_AnimeTypes_TypeId",
                table: "Animes",
                column: "TypeId",
                principalTable: "AnimeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
