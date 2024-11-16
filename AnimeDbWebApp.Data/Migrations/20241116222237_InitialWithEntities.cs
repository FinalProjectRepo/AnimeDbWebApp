using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimeDbWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialWithEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Type name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                    Birthdate = table.Column<DateTime>(type: "DATETIME2", nullable: true, comment: "Date of birth"),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Aditional information about person")
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
                name: "Magazines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier that equals mal_id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Url link to mal site"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Anime title")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MangaTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Type name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangaTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Url link to mal site of producer"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "English name of the studio"),
                    JpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Japanese name of the studio"),
                    ImgUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Anime poster url"),
                    Established = table.Column<DateTime>(type: "DATETIME2", nullable: true, comment: "Date the studio is established"),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Information about producer")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Type name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mangas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier that equals mal_id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Url link to mal site"),
                    PosterUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Manga poster url"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, comment: "Manga title"),
                    TitleEnglish = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Manga title in english translated"),
                    TitleJapanese = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Manga title in japanese characters"),
                    Chapters = table.Column<int>(type: "int", nullable: true, comment: "Number of chapters"),
                    Volumes = table.Column<int>(type: "int", nullable: true, comment: "Number of volumes, chapters combined in"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Airing status"),
                    StartDate = table.Column<DateTime>(type: "DATETIME2", nullable: true, comment: "Date manga started publishing"),
                    EndDate = table.Column<DateTime>(type: "DATETIME2", nullable: true, comment: "Date manga ended publishing"),
                    Score = table.Column<decimal>(type: "DECIMAL(4,2)", nullable: true, comment: "Manga score"),
                    Rank = table.Column<int>(type: "int", nullable: true, comment: "Manga rank"),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Short description"),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Short pre-story"),
                    TypeId = table.Column<int>(type: "int", nullable: true, comment: "Type of manga(manga, light novel, etc.)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mangas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mangas_MangaTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "MangaTypes",
                        principalColumn: "Id");
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
                    Episodes = table.Column<int>(type: "int", nullable: true, comment: "Number of episodes"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Airing status"),
                    StartDate = table.Column<DateTime>(type: "DATETIME2", nullable: true, comment: "Airing start date"),
                    EndDate = table.Column<DateTime>(type: "DATETIME2", nullable: true, comment: "Last episode aired date"),
                    Duration = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Duration of episode"),
                    Rating = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Age restriction for anime"),
                    Score = table.Column<decimal>(type: "DECIMAL(4,2)", nullable: true, comment: "Populairty/liked score of anime"),
                    Rank = table.Column<int>(type: "int", nullable: true, comment: "Anime rank"),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Short description"),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Short description"),
                    Season = table.Column<int>(type: "int", nullable: true, comment: "Yearly anime season that anime aired"),
                    SourceId = table.Column<int>(type: "int", nullable: false, comment: "Source for creating the anime"),
                    TypeId = table.Column<int>(type: "int", nullable: true, comment: "Type of anime(tv series, movie, etc.)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animes_AnimeTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AnimeTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Animes_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MangasAuthors",
                columns: table => new
                {
                    MangaId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of manga"),
                    AuthorId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of author")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangasAuthors", x => new { x.AuthorId, x.MangaId });
                    table.ForeignKey(
                        name: "FK_MangasAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangasAuthors_Mangas_MangaId",
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
                name: "MangasMagazines",
                columns: table => new
                {
                    MangaId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of manga"),
                    MagazineId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of magazine")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MangasMagazines", x => new { x.MangaId, x.MagazineId });
                    table.ForeignKey(
                        name: "FK_MangasMagazines_Magazines_MagazineId",
                        column: x => x.MagazineId,
                        principalTable: "Magazines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MangasMagazines_Mangas_MangaId",
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

            migrationBuilder.CreateTable(
                name: "UsersMangas",
                columns: table => new
                {
                    MangaId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of manga"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "User unique identifier"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Watching status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersMangas", x => new { x.MangaId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UsersMangas_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersMangas_Mangas_MangaId",
                        column: x => x.MangaId,
                        principalTable: "Mangas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_AnimesLicensors_Producers_LicensorId",
                        column: x => x.LicensorId,
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
                name: "UsersAnimes",
                columns: table => new
                {
                    AnimeId = table.Column<int>(type: "int", nullable: false, comment: "Unique identifier of anime"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "User unique identifier"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Watching status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersAnimes", x => new { x.AnimeId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UsersAnimes_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersAnimes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animes_SourceId",
                table: "Animes",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Animes_TypeId",
                table: "Animes",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimesGenres_GenreId",
                table: "AnimesGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimesLicensors_LicensorId",
                table: "AnimesLicensors",
                column: "LicensorId");

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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Mangas_TypeId",
                table: "Mangas",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MangasAuthors_MangaId",
                table: "MangasAuthors",
                column: "MangaId");

            migrationBuilder.CreateIndex(
                name: "IX_MangasGenres_GenreId",
                table: "MangasGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MangasMagazines_MagazineId",
                table: "MangasMagazines",
                column: "MagazineId");

            migrationBuilder.CreateIndex(
                name: "IX_MangasRelations_RelationId",
                table: "MangasRelations",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersAnimes_UserId",
                table: "UsersAnimes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersMangas_UserId",
                table: "UsersMangas",
                column: "UserId");
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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MangasAuthors");

            migrationBuilder.DropTable(
                name: "MangasGenres");

            migrationBuilder.DropTable(
                name: "MangasMagazines");

            migrationBuilder.DropTable(
                name: "MangasRelations");

            migrationBuilder.DropTable(
                name: "UsersAnimes");

            migrationBuilder.DropTable(
                name: "UsersMangas");

            migrationBuilder.DropTable(
                name: "GenresForAnimes");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "GenresForMangas");

            migrationBuilder.DropTable(
                name: "Magazines");

            migrationBuilder.DropTable(
                name: "Animes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Mangas");

            migrationBuilder.DropTable(
                name: "AnimeTypes");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "MangaTypes");
        }
    }
}
