using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeDbWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class MagazinesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Magazines",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Big Comic Original", "https://myanimelist.net/manga/magazine/1/Big_Comic_Original" },
                    { 2, "Young Animal", "https://myanimelist.net/manga/magazine/2/Young_Animal" },
                    { 3, "Big Comic Spirits", "https://myanimelist.net/manga/magazine/3/Big_Comic_Spirits" },
                    { 4, "Afternoon", "https://myanimelist.net/manga/magazine/4/Afternoon" },
                    { 5, "Web Comic Gum", "https://myanimelist.net/manga/magazine/5/Web_Comic_Gum" },
                    { 6, "Young Magazine (Monthly)", "https://myanimelist.net/manga/magazine/6/Young_Magazine_Monthly" },
                    { 8, "Shounen Magazine (Weekly)", "https://myanimelist.net/manga/magazine/8/Shounen_Magazine_Weekly" },
                    { 9, "Ribon Magazine", "https://myanimelist.net/manga/magazine/9/Ribon_Magazine" },
                    { 10, "Young Magazine (Weekly)", "https://myanimelist.net/manga/magazine/10/Young_Magazine_Weekly" },
                    { 11, "LaLa", "https://myanimelist.net/manga/magazine/11/LaLa" },
                    { 13, "Shounen Gangan", "https://myanimelist.net/manga/magazine/13/Shounen_Gangan" },
                    { 14, "Asuka", "https://myanimelist.net/manga/magazine/14/Asuka" },
                    { 15, "Cookie", "https://myanimelist.net/manga/magazine/15/Cookie" },
                    { 16, "Zipper", "https://myanimelist.net/manga/magazine/16/Zipper" },
                    { 17, "Margaret", "https://myanimelist.net/manga/magazine/17/Margaret" },
                    { 18, "Dengeki Comic Gao!", "https://myanimelist.net/manga/magazine/18/Dengeki_Comic_Gao" },
                    { 19, "From Gamers", "https://myanimelist.net/manga/magazine/19/From_Gamers" },
                    { 20, "Nakayoshi", "https://myanimelist.net/manga/magazine/20/Nakayoshi" },
                    { 21, "Hana to Yume", "https://myanimelist.net/manga/magazine/21/Hana_to_Yume" },
                    { 22, "Sho-Comi", "https://myanimelist.net/manga/magazine/22/Sho-Comi" },
                    { 23, "Dengeki Daioh", "https://myanimelist.net/manga/magazine/23/Dengeki_Daioh" },
                    { 24, "Young Gangan", "https://myanimelist.net/manga/magazine/24/Young_Gangan" },
                    { 25, "Ultra Jump", "https://myanimelist.net/manga/magazine/25/Ultra_Jump" },
                    { 26, "Eyes", "https://myanimelist.net/manga/magazine/26/Eyes" },
                    { 27, "Shounen Ace", "https://myanimelist.net/manga/magazine/27/Shounen_Ace" },
                    { 35, "GFantasy", "https://myanimelist.net/manga/magazine/35/GFantasy" },
                    { 40, "Sunday Gene-X", "https://myanimelist.net/manga/magazine/40/Sunday_Gene-X" },
                    { 45, "Wings", "https://myanimelist.net/manga/magazine/45/Wings" },
                    { 47, "Young Champion", "https://myanimelist.net/manga/magazine/47/Young_Champion" },
                    { 48, "Shounen Magazine (Monthly)", "https://myanimelist.net/manga/magazine/48/Shounen_Magazine_Monthly" },
                    { 53, "Bessatsu Margaret", "https://myanimelist.net/manga/magazine/53/Bessatsu_Margaret" },
                    { 55, "Big Comic", "https://myanimelist.net/manga/magazine/55/Big_Comic" },
                    { 57, "Business Jump", "https://myanimelist.net/manga/magazine/57/Business_Jump" },
                    { 58, "Chorus", "https://myanimelist.net/manga/magazine/58/Chorus" },
                    { 59, "Ciao", "https://myanimelist.net/manga/magazine/59/Ciao" },
                    { 68, "Gundam Ace", "https://myanimelist.net/manga/magazine/68/Gundam_Ace" },
                    { 70, "Magazine-Z", "https://myanimelist.net/manga/magazine/70/Magazine-Z" },
                    { 72, "Morning", "https://myanimelist.net/manga/magazine/72/Morning" },
                    { 83, "Shounen Jump (Weekly)", "https://myanimelist.net/manga/magazine/83/Shounen_Jump_Weekly" },
                    { 85, "Super Jump", "https://myanimelist.net/manga/magazine/85/Super_Jump" },
                    { 87, "Young Jump", "https://myanimelist.net/manga/magazine/87/Young_Jump" },
                    { 88, "Young King OURs", "https://myanimelist.net/manga/magazine/88/Young_King_OURs" },
                    { 90, "Young You", "https://myanimelist.net/manga/magazine/90/Young_You" },
                    { 91, "Comic Birz", "https://myanimelist.net/manga/magazine/91/Comic_Birz" },
                    { 92, "Comic Bunch", "https://myanimelist.net/manga/magazine/92/Comic_Bunch" },
                    { 95, "Dessert", "https://myanimelist.net/manga/magazine/95/Dessert" },
                    { 97, "Asuka Fantasy DX", "https://myanimelist.net/manga/magazine/97/Asuka_Fantasy_DX" },
                    { 98, "Dragon Age", "https://myanimelist.net/manga/magazine/98/Dragon_Age" },
                    { 103, "Feel Young", "https://myanimelist.net/manga/magazine/103/Feel_Young" },
                    { 107, "Genzo", "https://myanimelist.net/manga/magazine/107/Genzo" },
                    { 109, "Comic Bonbon", "https://myanimelist.net/manga/magazine/109/Comic_Bonbon" },
                    { 112, "Comp Ace", "https://myanimelist.net/manga/magazine/112/Comp_Ace" },
                    { 113, "Kiss", "https://myanimelist.net/manga/magazine/113/Kiss" },
                    { 114, "Comic Beam", "https://myanimelist.net/manga/magazine/114/Comic_Beam" },
                    { 118, "Young Animal Arashi", "https://myanimelist.net/manga/magazine/118/Young_Animal_Arashi" },
                    { 128, "Magazine Special", "https://myanimelist.net/manga/magazine/128/Magazine_Special" },
                    { 129, "Shounen Jump (Monthly)", "https://myanimelist.net/manga/magazine/129/Shounen_Jump_Monthly" },
                    { 137, "Comic Alive", "https://myanimelist.net/manga/magazine/137/Comic_Alive" },
                    { 140, "Dengeki Bunko Magazine", "https://myanimelist.net/manga/magazine/140/Dengeki_Bunko_Magazine" },
                    { 150, "AlphaPolis", "https://myanimelist.net/manga/magazine/150/AlphaPolis" },
                    { 151, "Asuka Mystery DX", "https://myanimelist.net/manga/magazine/151/Asuka_Mystery_DX" },
                    { 158, "Shounen Captain", "https://myanimelist.net/manga/magazine/158/Shounen_Captain" },
                    { 161, "Jump SQ.", "https://myanimelist.net/manga/magazine/161/Jump_SQ" },
                    { 163, "Dengeki Maoh", "https://myanimelist.net/manga/magazine/163/Dengeki_Maoh" },
                    { 168, "V-Jump", "https://myanimelist.net/manga/magazine/168/V-Jump" },
                    { 171, "Evening", "https://myanimelist.net/manga/magazine/171/Evening" },
                    { 173, "Weekly Playboy", "https://myanimelist.net/manga/magazine/173/Weekly_Playboy" },
                    { 174, "Comic Flapper", "https://myanimelist.net/manga/magazine/174/Comic_Flapper" },
                    { 186, "Champion RED", "https://myanimelist.net/manga/magazine/186/Champion_RED" },
                    { 193, "Comic Cue", "https://myanimelist.net/manga/magazine/193/Comic_Cue" },
                    { 198, "Dengeki G&#039;s magazine", "https://myanimelist.net/manga/magazine/198/Dengeki_Gs_magazine" },
                    { 201, "Kero-kero Ace", "https://myanimelist.net/manga/magazine/201/Kero-kero_Ace" },
                    { 206, "Shounen Champion (Weekly)", "https://myanimelist.net/manga/magazine/206/Shounen_Champion_Weekly" },
                    { 213, "CoroCoro Comic", "https://myanimelist.net/manga/magazine/213/CoroCoro_Comic" },
                    { 229, "Shounen Sunday", "https://myanimelist.net/manga/magazine/229/Shounen_Sunday" },
                    { 249, "Akamaru Jump", "https://myanimelist.net/manga/magazine/249/Akamaru_Jump" },
                    { 264, "Big Comic Superior", "https://myanimelist.net/manga/magazine/264/Big_Comic_Superior" },
                    { 269, "Comic Avarus", "https://myanimelist.net/manga/magazine/269/Comic_Avarus" },
                    { 282, "Shounen Champion (Monthly)", "https://myanimelist.net/manga/magazine/282/Shounen_Champion_Monthly" },
                    { 284, "Shougaku Sannensei ", "https://myanimelist.net/manga/magazine/284/Shougaku_Sannensei_" },
                    { 290, "Tonari no Young Jump", "https://myanimelist.net/manga/magazine/290/Tonari_no_Young_Jump" },
                    { 307, "YOU", "https://myanimelist.net/manga/magazine/307/YOU" },
                    { 312, "Dragon Magazine", "https://myanimelist.net/manga/magazine/312/Dragon_Magazine" },
                    { 316, "good! Afternoon", "https://myanimelist.net/manga/magazine/316/good_Afternoon" },
                    { 329, "The Sneaker", "https://myanimelist.net/manga/magazine/329/The_Sneaker" },
                    { 340, "Comic Gardo", "https://myanimelist.net/manga/magazine/340/Comic_Gardo" },
                    { 343, "Televi Magazine", "https://myanimelist.net/manga/magazine/343/Televi_Magazine" },
                    { 365, "Manga Time Kirara Forward", "https://myanimelist.net/manga/magazine/365/Manga_Time_Kirara_Forward" },
                    { 367, "Kindai Mahjong", "https://myanimelist.net/manga/magazine/367/Kindai_Mahjong" },
                    { 371, "Manga Allman", "https://myanimelist.net/manga/magazine/371/Manga_Allman" },
                    { 403, "Young Ace", "https://myanimelist.net/manga/magazine/403/Young_Ace" },
                    { 411, "Shounen Sunday Super", "https://myanimelist.net/manga/magazine/411/Shounen_Sunday_Super" },
                    { 412, "Gangan Joker", "https://myanimelist.net/manga/magazine/412/Gangan_Joker" },
                    { 419, "Gangan Online", "https://myanimelist.net/manga/magazine/419/Gangan_Online" },
                    { 421, "Sylph", "https://myanimelist.net/manga/magazine/421/Sylph" },
                    { 434, "Champion RED Ichigo", "https://myanimelist.net/manga/magazine/434/Champion_RED_Ichigo" },
                    { 450, "Bessatsu Shounen Magazine", "https://myanimelist.net/manga/magazine/450/Bessatsu_Shounen_Magazine" },
                    { 468, "Bokura", "https://myanimelist.net/manga/magazine/468/Bokura" },
                    { 483, "Shounen King", "https://myanimelist.net/manga/magazine/483/Shounen_King" },
                    { 485, "Oh Super Jump", "https://myanimelist.net/manga/magazine/485/Oh_Super_Jump" },
                    { 492, "Comic Gaia", "https://myanimelist.net/manga/magazine/492/Comic_Gaia" },
                    { 498, "Mephisto", "https://myanimelist.net/manga/magazine/498/Mephisto" },
                    { 499, "ARIA", "https://myanimelist.net/manga/magazine/499/ARIA" },
                    { 506, "Ultra Jump Egg", "https://myanimelist.net/manga/magazine/506/Ultra_Jump_Egg" },
                    { 512, "super Robot Magazine", "https://myanimelist.net/manga/magazine/512/super_Robot_Magazine" },
                    { 522, "Dengeki Hobby Magazine", "https://myanimelist.net/manga/magazine/522/Dengeki_Hobby_Magazine" },
                    { 532, "Famitsu Comic Clear", "https://myanimelist.net/manga/magazine/532/Famitsu_Comic_Clear" },
                    { 548, "Shounen Jump NEXT!", "https://myanimelist.net/manga/magazine/548/Shounen_Jump_NEXT" },
                    { 573, "Comic Gene", "https://myanimelist.net/manga/magazine/573/Comic_Gene" },
                    { 591, "Gessan", "https://myanimelist.net/manga/magazine/591/Gessan" },
                    { 593, "Club Sunday", "https://myanimelist.net/manga/magazine/593/Club_Sunday" },
                    { 653, "Newtype Ace", "https://myanimelist.net/manga/magazine/653/Newtype_Ace" },
                    { 673, "Naver Webtoon", "https://myanimelist.net/manga/magazine/673/Naver_Webtoon" },
                    { 691, "Miracle Jump", "https://myanimelist.net/manga/magazine/691/Miracle_Jump" },
                    { 697, "Saikyou Jump", "https://myanimelist.net/manga/magazine/697/Saikyou_Jump" },
                    { 705, "Big Gangan", "https://myanimelist.net/manga/magazine/705/Big_Gangan" },
                    { 707, "Comic Earth☆Star", "https://myanimelist.net/manga/magazine/707/Comic_Earth%E2%98%86Star" },
                    { 719, "Comic Zenon", "https://myanimelist.net/manga/magazine/719/Comic_Zenon" },
                    { 739, "Age Premium", "https://myanimelist.net/manga/magazine/739/Age_Premium" },
                    { 803, "Niconico Seiga", "https://myanimelist.net/manga/magazine/803/Niconico_Seiga" },
                    { 813, "Bessatsu Shounen Champion", "https://myanimelist.net/manga/magazine/813/Bessatsu_Shounen_Champion" },
                    { 823, "Manga Life Win", "https://myanimelist.net/manga/magazine/823/Manga_Life_Win" },
                    { 831, "Bessatsu CoroCoro Comic", "https://myanimelist.net/manga/magazine/831/Bessatsu_CoroCoro_Comic" },
                    { 847, "Manga Action", "https://myanimelist.net/manga/magazine/847/Manga_Action" },
                    { 881, "Monthly Hero&#039;s", "https://myanimelist.net/manga/magazine/881/Monthly_Heros" },
                    { 916, "Blade Online", "https://myanimelist.net/manga/magazine/916/Blade_Online" },
                    { 918, "Shougaku Ninensei", "https://myanimelist.net/manga/magazine/918/Shougaku_Ninensei" },
                    { 937, "Shounen", "https://myanimelist.net/manga/magazine/937/Shounen" },
                    { 947, "Grand Jump", "https://myanimelist.net/manga/magazine/947/Grand_Jump" },
                    { 953, "Harta", "https://myanimelist.net/manga/magazine/953/Harta" },
                    { 1013, "Jump LIVE", "https://myanimelist.net/manga/magazine/1013/Jump_LIVE" },
                    { 1061, "Manga Box", "https://myanimelist.net/manga/magazine/1061/Manga_Box" },
                    { 1065, "BOX-AiR", "https://myanimelist.net/manga/magazine/1065/BOX-AiR" },
                    { 1089, "Manga Time Kirara☆Magica", "https://myanimelist.net/manga/magazine/1089/Manga_Time_Kirara%E2%98%86Magica" },
                    { 1097, "Yawaraka Spirits", "https://myanimelist.net/manga/magazine/1097/Yawaraka_Spirits" },
                    { 1129, "Fresh Jump", "https://myanimelist.net/manga/magazine/1129/Fresh_Jump" },
                    { 1135, "Suiyoubi no Sirius", "https://myanimelist.net/manga/magazine/1135/Suiyoubi_no_Sirius" },
                    { 1157, "Dengeki G&#039;s Comic", "https://myanimelist.net/manga/magazine/1157/Dengeki_Gs_Comic" },
                    { 1159, "ComicWalker", "https://myanimelist.net/manga/magazine/1159/ComicWalker" },
                    { 1163, "Asahi Shinbun", "https://myanimelist.net/manga/magazine/1163/Asahi_Shinbun" },
                    { 1165, "Tokusatsu Ace", "https://myanimelist.net/manga/magazine/1165/Tokusatsu_Ace" },
                    { 1205, "Animage", "https://myanimelist.net/manga/magazine/1205/Animage" },
                    { 1209, "Shounen Jump+", "https://myanimelist.net/manga/magazine/1209/Shounen_Jump_" },
                    { 1213, "Comic Dengeki Daioh &quot;g&quot;", "https://myanimelist.net/manga/magazine/1213/Comic_Dengeki_Daioh_g" },
                    { 1217, "Comic Garden", "https://myanimelist.net/manga/magazine/1217/Comic_Garden" },
                    { 1235, "Manga Life STORIA", "https://myanimelist.net/manga/magazine/1235/Manga_Life_STORIA" },
                    { 1257, "Cyber Comics", "https://myanimelist.net/manga/magazine/1257/Cyber_Comics" },
                    { 1280, "Comicomi", "https://myanimelist.net/manga/magazine/1280/Comicomi" },
                    { 1287, "SPA!", "https://myanimelist.net/manga/magazine/1287/SPA" },
                    { 1312, "Shounen Magazine Edge", "https://myanimelist.net/manga/magazine/1312/Shounen_Magazine_Edge" },
                    { 1316, "Jump SQ.Crown", "https://myanimelist.net/manga/magazine/1316/Jump_SQCrown" },
                    { 1335, "Magazine pocket", "https://myanimelist.net/manga/magazine/1335/Magazine_pocket" },
                    { 1340, "Young Ace UP", "https://myanimelist.net/manga/magazine/1340/Young_Ace_UP" },
                    { 1346, "The Sneaker Web", "https://myanimelist.net/manga/magazine/1346/The_Sneaker_Web" },
                    { 1361, "MangaONE", "https://myanimelist.net/manga/magazine/1361/MangaONE" },
                    { 1362, "eBigComic4", "https://myanimelist.net/manga/magazine/1362/eBigComic4" },
                    { 1366, "Jump GIGA", "https://myanimelist.net/manga/magazine/1366/Jump_GIGA" },
                    { 1372, "CoroCoro Aniki", "https://myanimelist.net/manga/magazine/1372/CoroCoro_Aniki" },
                    { 1373, "Comic Ride", "https://myanimelist.net/manga/magazine/1373/Comic_Ride" },
                    { 1378, "Comic Fire", "https://myanimelist.net/manga/magazine/1378/Comic_Fire" },
                    { 1390, "Dra-Dra-Dragon Age", "https://myanimelist.net/manga/magazine/1390/Dra-Dra-Dragon_Age" },
                    { 1396, "ShuuPlay News", "https://myanimelist.net/manga/magazine/1396/ShuuPlay_News" },
                    { 1399, "Manga UP!", "https://myanimelist.net/manga/magazine/1399/Manga_UP" },
                    { 1405, "Boukenou", "https://myanimelist.net/manga/magazine/1405/Boukenou" },
                    { 1410, "Sunday Webry", "https://myanimelist.net/manga/magazine/1410/Sunday_Webry" },
                    { 1424, "Monster Comics", "https://myanimelist.net/manga/magazine/1424/Monster_Comics" },
                    { 1439, "KakaoPage", "https://myanimelist.net/manga/magazine/1439/KakaoPage" },
                    { 1456, "Manga Cross", "https://myanimelist.net/manga/magazine/1456/Manga_Cross" },
                    { 1459, "Comic Days", "https://myanimelist.net/manga/magazine/1459/Comic_Days" },
                    { 1460, "Comic Boost", "https://myanimelist.net/manga/magazine/1460/Comic_Boost" },
                    { 1467, "Comic Corona", "https://myanimelist.net/manga/magazine/1467/Comic_Corona" },
                    { 1473, "B&#039;s-LOG Comic", "https://myanimelist.net/manga/magazine/1473/Bs-LOG_Comic" },
                    { 1477, "Jump SQ.Rise", "https://myanimelist.net/manga/magazine/1477/Jump_SQRise" },
                    { 1488, "Comic Tatan", "https://myanimelist.net/manga/magazine/1488/Comic_Tatan" },
                    { 1490, "Lupin Sansei Official Magazine", "https://myanimelist.net/manga/magazine/1490/Lupin_Sansei_Official_Magazine" },
                    { 1495, "MAGKAN", "https://myanimelist.net/manga/magazine/1495/MAGKAN" },
                    { 1514, "Sword Art Online Magazine", "https://myanimelist.net/manga/magazine/1514/Sword_Art_Online_Magazine" },
                    { 1527, "Web DenPlay Comic", "https://myanimelist.net/manga/magazine/1527/Web_DenPlay_Comic" },
                    { 1537, "Shounen Ace Plus", "https://myanimelist.net/manga/magazine/1537/Shounen_Ace_Plus" },
                    { 1540, "LINE Manga", "https://myanimelist.net/manga/magazine/1540/LINE_Manga" },
                    { 1563, "Comic Fuz", "https://myanimelist.net/manga/magazine/1563/Comic_Fuz" },
                    { 1564, "One Piece Magazine", "https://myanimelist.net/manga/magazine/1564/One_Piece_Magazine" },
                    { 1575, "Young Dragon Age", "https://myanimelist.net/manga/magazine/1575/Young_Dragon_Age" },
                    { 1590, "Hero&#039;s", "https://myanimelist.net/manga/magazine/1590/Heros" },
                    { 1617, "Grand Jump Mucha", "https://myanimelist.net/manga/magazine/1617/Grand_Jump_Mucha" },
                    { 1626, "Shounen Action (Weekly)", "https://myanimelist.net/manga/magazine/1626/Shounen_Action_Weekly" },
                    { 1636, "Dengeki Comic Regulus", "https://myanimelist.net/manga/magazine/1636/Dengeki_Comic_Regulus" },
                    { 1657, "Super Action (Monthly)", "https://myanimelist.net/manga/magazine/1657/Super_Action_Monthly" },
                    { 1662, "Young Jump Heroine", "https://myanimelist.net/manga/magazine/1662/Young_Jump_Heroine" },
                    { 1671, "Young Magazine Kaizokuban", "https://myanimelist.net/manga/magazine/1671/Young_Magazine_Kaizokuban" },
                    { 1689, "Alive+", "https://myanimelist.net/manga/magazine/1689/Alive_" },
                    { 1699, "Shounen Book", "https://myanimelist.net/manga/magazine/1699/Shounen_Book" },
                    { 1710, "Comic Bonbon Zoukan", "https://myanimelist.net/manga/magazine/1710/Comic_Bonbon_Zoukan" },
                    { 1786, "e-manga", "https://myanimelist.net/manga/magazine/1786/e-manga" },
                    { 1813, "JoJo Magazine", "https://myanimelist.net/manga/magazine/1813/JoJo_Magazine" },
                    { 1815, "Fairy Tail Magazine (Monthly)", "https://myanimelist.net/manga/magazine/1815/Fairy_Tail_Magazine_Monthly" },
                    { 1852, "Comp Ace Comic Connect", "https://myanimelist.net/manga/magazine/1852/Comp_Ace_Comic_Connect" },
                    { 1866, "Shounen Jump Season Special", "https://myanimelist.net/manga/magazine/1866/Shounen_Jump_Season_Special" },
                    { 1888, "Papillon", "https://myanimelist.net/manga/magazine/1888/Papillon" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: 1888);
        }
    }
}
