using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeDbWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedEntitiesAndTypeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier that equals mal_id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Url link to mal site"),
                    Website = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Person website"),
                    PosterUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Person poster url"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Anime title"),
                    GivenName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Anime title in english translated"),
                    FamilyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Anime title in japanese characters"),
                    Birthdate = table.Column<DateTime>(type: "DATETIME2", nullable: false, comment: "Date of birth"),
                    About = table.Column<string>(type: "nvarchar(3999)", maxLength: 3999, nullable: true, comment: "Aditional information about person")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenresForAnimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Genre name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenresForAnimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenresForMangas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Genre name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenresForMangas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Url link to mal site of producer"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "English name of the studio"),
                    JpName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Japanese name of the studio"),
                    ImgUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Anime poster url"),
                    Established = table.Column<DateTime>(type: "DATETIME2", nullable: false, comment: "Date the studio is established"),
                    About = table.Column<string>(type: "nvarchar(3999)", maxLength: 3999, nullable: true, comment: "Information about producer")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Type name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier that equals mal_id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Url link to mal site"),
                    PosterUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Anime poster url"),
                    TrailerUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Anime trailer url"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Anime title"),
                    TitleEnglish = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Anime title in english translated"),
                    TitleJapanese = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Anime title in japanese characters"),
                    Source = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Source for creating the anime"),
                    Episodes = table.Column<int>(type: "int", nullable: false, comment: "Number of episodes"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Airing status"),
                    StartDate = table.Column<DateTime>(type: "DATETIME2", nullable: true, comment: "Airing start date"),
                    EndDate = table.Column<DateTime>(type: "DATETIME2", nullable: true, comment: "Last episode aired date"),
                    Duration = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Duration of episode"),
                    Rating = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Age restriction for anime"),
                    Score = table.Column<decimal>(type: "DECIMAL(4,2)", nullable: false, comment: "Populairty/liked score of anime"),
                    Rank = table.Column<int>(type: "int", nullable: false, comment: "Anime rank"),
                    Sypnosis = table.Column<string>(type: "nvarchar(3999)", maxLength: 3999, nullable: false, comment: "Short description"),
                    Background = table.Column<string>(type: "nvarchar(3999)", maxLength: 3999, nullable: false, comment: "Short description"),
                    Season = table.Column<int>(type: "int", nullable: false, comment: "Yearly anime season that anime aired"),
                    TypeId = table.Column<int>(type: "int", nullable: false, comment: "Type of anime(tv series, movie, etc.)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animes_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mangas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier that equals mal_id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Url link to mal site"),
                    PosterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Manga poster url"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Manga title"),
                    TitleEnglish = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Manga title in english translated"),
                    TitleJapanese = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Manga title in japanese characters"),
                    Chapters = table.Column<int>(type: "int", nullable: false, comment: "Number of chapters"),
                    Volumes = table.Column<int>(type: "int", nullable: false, comment: "Number of volumes, chapters combined in"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Airing status"),
                    StartDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, comment: "Date manga started publishing"),
                    EndDate = table.Column<DateTime>(type: "DATETIME2", nullable: false, comment: "Date manga ended publishing"),
                    Score = table.Column<decimal>(type: "DECIMAL(4,2)", nullable: false, comment: "Manga score"),
                    Rank = table.Column<int>(type: "int", nullable: false, comment: "Manga rank"),
                    Sypnosis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Short description"),
                    Background = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Short description"),
                    TypeId = table.Column<int>(type: "int", nullable: false, comment: "Type of anime(tv series, movie, etc.)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mangas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mangas_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimesGenres",
                columns: table => new
                {
                    AnimeId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of anime"),
                    GenreId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of genre")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimesGenres", x => new { x.AnimeId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_AnimesGenres_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimesGenres_GenresForAnimes_GenreId",
                        column: x => x.GenreId,
                        principalTable: "GenresForAnimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnimesLicensors",
                columns: table => new
                {
                    AnimeId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of anime"),
                    LicensorId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of licensor(producer)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimesLicensors", x => new { x.AnimeId, x.LicensorId });
                    table.ForeignKey(
                        name: "FK_AnimesLicensors_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimesLicensors_Producers_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnimesProducers",
                columns: table => new
                {
                    AnimeId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of anime"),
                    ProducerId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of producer")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimesProducers", x => new { x.AnimeId, x.ProducerId });
                    table.ForeignKey(
                        name: "FK_AnimesProducers_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimesProducers_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnimesRelations",
                columns: table => new
                {
                    AnimeId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of anime"),
                    RelationId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of anime that have relation to animeId"),
                    RelationType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Type of relation that animes have")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimesRelations", x => new { x.AnimeId, x.RelationId });
                    table.ForeignKey(
                        name: "FK_AnimesRelations_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimesRelations_Animes_RelationId",
                        column: x => x.RelationId,
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimesStudios",
                columns: table => new
                {
                    AnimeId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of anime"),
                    StudioId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of studio(producer)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimesStudios", x => new { x.AnimeId, x.StudioId });
                    table.ForeignKey(
                        name: "FK_AnimesStudios_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimesStudios_Producers_StudioId",
                        column: x => x.StudioId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnimesMangas",
                columns: table => new
                {
                    AnimeId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of anime"),
                    MangaId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of anime")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimesMangas", x => new { x.AnimeId, x.MangaId });
                    table.ForeignKey(
                        name: "FK_AnimesMangas_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnimesMangas_Mangas_MangaId",
                        column: x => x.MangaId,
                        principalTable: "Mangas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuthorManga",
                columns: table => new
                {
                    MangaId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of manga"),
                    AuthorId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of author")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorManga", x => new { x.AuthorId, x.MangaId });
                    table.ForeignKey(
                        name: "FK_AuthorManga_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthorManga_Mangas_MangaId",
                        column: x => x.MangaId,
                        principalTable: "Mangas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangasGenres",
                columns: table => new
                {
                    MangaId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of manga"),
                    GenreId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of genre")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangasGenres", x => new { x.MangaId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_MangasGenres_GenresForMangas_GenreId",
                        column: x => x.GenreId,
                        principalTable: "GenresForMangas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangasGenres_Mangas_MangaId",
                        column: x => x.MangaId,
                        principalTable: "Mangas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MangasRelations",
                columns: table => new
                {
                    MangaId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of manga"),
                    RelationId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of manga that have relation to mangaId"),
                    RelationType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Type of relation that mangas have")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangasRelations", x => new { x.MangaId, x.RelationId });
                    table.ForeignKey(
                        name: "FK_MangasRelations_Mangas_MangaId",
                        column: x => x.MangaId,
                        principalTable: "Mangas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangasRelations_Mangas_RelationId",
                        column: x => x.RelationId,
                        principalTable: "Mangas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "CM" },
                    { 2, "Doujinshi" },
                    { 3, "Light Novel" },
                    { 4, "Manga" },
                    { 5, "Manhwa" },
                    { 6, "Movie" },
                    { 7, "Music" },
                    { 8, "Novel" },
                    { 9, "ONA" },
                    { 10, "One-shot" },
                    { 11, "OVA" },
                    { 12, "PV" },
                    { 13, "Special" },
                    { 14, "TV" },
                    { 15, "TV Special" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animes_TypeId",
                table: "Animes",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimesGenres_GenreId",
                table: "AnimesGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimesMangas_MangaId",
                table: "AnimesMangas",
                column: "MangaId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimesProducers_ProducerId",
                table: "AnimesProducers",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimesRelations_RelationId",
                table: "AnimesRelations",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimesStudios_StudioId",
                table: "AnimesStudios",
                column: "StudioId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorManga_MangaId",
                table: "AuthorManga",
                column: "MangaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_TypeId",
                table: "Mangas",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MangasGenres_GenreId",
                table: "MangasGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MangasRelations_RelationId",
                table: "MangasRelations",
                column: "RelationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimesGenres");

            migrationBuilder.DropTable(
                name: "AnimesLicensors");

            migrationBuilder.DropTable(
                name: "AnimesMangas");

            migrationBuilder.DropTable(
                name: "AnimesProducers");

            migrationBuilder.DropTable(
                name: "AnimesRelations");

            migrationBuilder.DropTable(
                name: "AnimesStudios");

            migrationBuilder.DropTable(
                name: "AuthorManga");

            migrationBuilder.DropTable(
                name: "MangasGenres");

            migrationBuilder.DropTable(
                name: "MangasRelations");

            migrationBuilder.DropTable(
                name: "GenresForAnimes");

            migrationBuilder.DropTable(
                name: "Animes");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "GenresForMangas");

            migrationBuilder.DropTable(
                name: "Mangas");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
