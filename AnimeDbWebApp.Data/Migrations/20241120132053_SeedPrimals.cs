using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeDbWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPrimals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AnimeTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "TV" },
                    { 2, "Movie" },
                    { 3, "OVA" },
                    { 4, "Special" },
                    { 5, "TV Special" },
                    { 6, "ONA" },
                    { 7, "Music" },
                    { 8, "CM" },
                    { 9, "PV" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("38ac6343-c319-40fc-a62b-fd4c5948f1c6"), 0, "51c071cd-e4d1-4217-af12-54881813934d", "shefcheto@users.com", true, false, null, "SHEFCHETO@USERS.COM", "SHEFCHETO", "AQAAAAIAAYagAAAAEBXBWbiIcNJ3mn3f/chNvQYcYbDYXHtAPlP/ccChWi0qlRTjoaoC8IbcyWUdMeSDig==", "+111111111111", true, "CH6VK6AKNJKXFYULEYFXPC62JR7UTMC1", false, "Shefcheto" },
                    { new Guid("44cc80e4-84e1-437a-b943-90730089868a"), 0, "295a0bbd-e5b8-48c3-9947-f378c0a14fc3", "animemaniac@users.com", true, false, null, "ANIMEMANIAC@USERS.COM", "ANIMEMANIAC", "AQAAAAIAAYagAAAAEBXBWbiIcNJ3mn3f/chNvQYcYbDYXHtAPlP/ccChWi0qlRTjoaoC8IbcyWUdMeSDig==", "+222222222222", true, "CH6VK6AKNJKXFYULEYFXPC62JR7UTMC2", false, "AnimeManiac" },
                    { new Guid("f1b58bac-8ebe-4db5-a9ed-656326479f62"), 0, "5ae88d28-aedc-4175-9dcf-c100898e93d7", "casual@users.com", true, false, null, "CASUAL@USERS.COM", "CASUAL", "AQAAAAIAAYagAAAAEBXBWbiIcNJ3mn3f/chNvQYcYbDYXHtAPlP/ccChWi0qlRTjoaoC8IbcyWUdMeSDig==", "+333333333333", true, "CH6VK6AKNJKXFYULEYFXPC62JR7UTMC3", false, "Casual" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "About", "Birthdate", "FamilyName", "GivenName", "Name", "PosterUrl", "Url", "Website" },
                values: new object[,]
                {
                    { 1867, "Naoki Urasawa's career as a manga artist spans more than twenty years and has firmly established him as one of the true manga masters of Japan. Born in Tokyo in 1960, Urasawa debuted with BETA! in 1983 and hasn't stopped his impressive output since. Well-versed in a variety of genres, Urasawa's oeuvre encompasses a multitude of different subjects, such as a romantic comedy (Yawara! A Fashionable Judo Girl), a suspenseful human drama about a former mercenary (Pineapple ARMY; story by Kazuya Kudo), a captivating psychological suspense story (Monster), a sci-fi adventure manga (20th Century Boys), and a modern reinterpretation of the work of the God of Manga, Osamu Tezuka (Pluto: Urasawa x Tezuka; co-authored with Takashi Nagasaki, supervised by Macoto Tezka, and with the cooperation of Tezuka Productions). Many of his books have spawned popular animated and live-action TV programs and films, and 2008 saw the theatrical release of the first of three live-action Japanese films based on 20th Century Boys.\n\nNo stranger to accolades and awards, Urasawa is a three-time recipient of the prestigious Shogakukan Manga Award, a two-time recipient of the Osamu Tezuka Cultural Prize, and has received the Kodansha Manga Award. Similarly, Monster has been nominated twice for the Eisner Award in America. Urasawa has also become involved in the world of academia, and in 2008 accepted a guest teaching post at Nagoya Zokei University, where he teaches courses in, of course, manga.\n\nTwitter: @urasawa_naoki\nYouTube: @-urasawachannel-5463", new DateTime(1960, 1, 1, 16, 0, 0, 0, DateTimeKind.Local), "浦沢", "直樹", "Naoki Urasawa", "https://cdn.myanimelist.net/images/voiceactors/1/73152.jpg", "https://myanimelist.net/people/1867/Naoki_Urasawa", null },
                    { 1868, "Date of Death: May 6, 2021\n\nKentarou Miura was born in Chiba City, Chiba Prefecture, Japan in 1966. He was left-handed. In 1976, at the early age of 10, Miura made his first manga, titled Miuranger, that was published for his classmates in a school publication; the manga ended up spanning 40 volumes. In 1977, Miura created his second manga titled Ken e No Michi (The Way to the Sword), using Indian ink for the first time. When he was in middle school in 1979, Miura's drawing techniques improved greatly as he started using professional drawing techniques. His first doujinshi was published, with the help of friends, in a magazine in 1982. That same year, Miura enrolled in an artistic curriculum in high school, where he and his classmates started publishing their works in school booklets, as well as having his first doujinshi published in a fan-produced magazine. In 1985, Miura applied for the entrance examination of an art college in Nihon University. He submitted Futanabi for examination and was granted admission. This project was later nominated for the Best New Author work in Weekly Shounen Magazine. Another Miura manga titled Noa was published in Weekly Shounen Magazine the very same year. Due to a disagreement with one of the editors, the manga was stalled and eventually dropped altogether. This is approximately when Miura's career hit a slump.\n\nIn 1988, Miura bounced back with a 48-page manga known as Berserk Prototype, as an introduction to the current Berserk fantasy world. It went on to win Miura a prize from the Comi Manga School. In 1989, after receiving a doctorate degree, Kentarou started a project titled Ourou (King of Wolves), based on a script by Buronson, the writer of Hokuto no Ken. It was published in Monthly Animal House magazine in issues 5 and 7 of that year.\n\nIn 1990, a sequel was made to Ourou titled Ourouden that was published as a prequel to the original in Young Animal magazine. In the same year, the 6th issue of Monthly Animal House, the first volume of the solo project Berserk was released with a relatively limited success. Miura again collaborated with Buronson on a manga titled Japan that was published in Young Animal from the 1st issue to the 8th of 1992, and was later released as a stand-alone tankoubon. Miura's fame grew after Berserk was serialized in Young Animal in 1992 with the release of \"The Golden Age\" story arc, and the huge success of his masterpiece made of him one of the most prominent contemporary mangaka. At this time, Miura dedicated himself solely to work on Berserk. He indicated, however, that he intended to publish more manga in the future.\n\nIn 1997, Miura supervised the production of 25 anime episodes of Berserk that aired in the same year on NTV. Various art books and supplemental materials by Miura based on Berserk were also released. In 1999, Miura made minor contributions to the Dreamcast video game Sword of the Berserk: Guts' Rage. 2004 saw the release of yet another video game adaptation titled Berserk Millennium Falcon Arc: Chapter of the Record of the Holy Demon War.\n\nThe Berserk manga has also spawned a whole host of merchandise, both official and fan-made, ranging from statues and action figures to key rings, video games, and a trading card game. In 2002, Kentarou Miura received second place in the Osamu Tezuka Culture Award of Excellence for Berserk.\n\nMiura provided the designs for the Vocaloid Kamui Gakupo, whose voice is taken from the Japanese singer and actor, Gackt.\n\nKentarou Miura died on May 6, 2021 due to an acute aortic dissection at 54 years old.", new DateTime(1966, 7, 10, 17, 0, 0, 0, DateTimeKind.Local), "三浦", "建太郎", "Kentarou Miura", "https://cdn.myanimelist.net/images/voiceactors/2/64279.jpg", "https://myanimelist.net/people/1868/Kentarou_Miura", null },
                    { 1869, "Hitoshi Ashinano is a Japanese manga artist. He is most noted for Yokohama Kaidashi Kiko, for which he won Afternoon magazine's Four Seasons Award for debut works and the 2007 Seiun Award for Best Science Fiction Manga. Another notable work is Position.\n\nHe has also been known to create doujinshi under the name \"suke\". Prior to his debut, Ashinano worked as an assistant to manga artist Kousuke Fujishima.\n\nHis work also usually has a rather laid-back, nostalgic feel with undertones of mystery; there are frequent stretches with little or no dialogue.", new DateTime(1963, 4, 24, 17, 0, 0, 0, DateTimeKind.Local), "芦奈野", "ひとし", "Hitoshi Ashinano", "https://cdn.myanimelist.net/images/voiceactors/2/2375.jpg", "https://myanimelist.net/people/1869/Hitoshi_Ashinano", null },
                    { 1874, "Blood type: A\nHometown: Tokachi, Hokkaido, Japan\n\nArakawa's career started with a one-shot titled STRAY DOG, but she is best known for creating Hagane no Renkinjutsushi, which she's received the Shogakukan Manga Award, the Tezuka Osamu Cultural Award (New Artist Prize) and the Shinsei Prize. Before creating Hagane no Renkinjutsushi she was Etou Hiroyuki's assistant writer for Mahoujin Guruguru.\n\nShe's a friend of Shakugan no Shana's author Takahashi Yashichirou, and also Segami Akira.\n\nShe gave birth to a son in 2007.\n\nAiya Kyu was an assistant of hers. Inariya Fusanosuke was possibly another assistant of her who became a BL mangaka in 2002.\n\nHer self-portrait is usually that of a bespectacled cow, as she was born and raised on a dairy farm in Hokkaido with three older sisters and a younger brother. She worked as a farmer for 8 years before moving to Tokyo.", new DateTime(1973, 5, 7, 17, 0, 0, 0, DateTimeKind.Local), "荒川", "弘", "Hiromu Arakawa", "https://cdn.myanimelist.net/images/voiceactors/2/37555.jpg", "https://myanimelist.net/people/1874/Hiromu_Arakawa", null },
                    { 1876, "Blood type: O\nZodiac: Capricorn\n\nJyoji Morikawa is nicknamed and called (most of the times) George.\n\nTwitter: @WANPOWANWAN", new DateTime(1966, 1, 16, 16, 0, 0, 0, DateTimeKind.Local), "森川", "ジョージ", "George Morikawa", "https://cdn.myanimelist.net/images/voiceactors/2/21583.jpg", "https://myanimelist.net/people/1876/George_Morikawa", null },
                    { 1877, "They are an all-female Japanese mangaka group that was formed in the mid-1980s. It consists of leader Nanase Ohkawa, and three artists whose roles shift for each series: Mokona, Tsubaki Nekoi, and Satsuki Igarashi. Almost 100 million Clamp tankōbon copies have been sold worldwide as of October 2007.\n\nBeginning as an eleven-member dōjinshi circle in the mid-1980s, they began creating original work in 1987. By the time they debuted with RG Veda in 1989, the group was reduced to seven members. In 1993, three more members left, leaving the four members who are currently still part of the group. In 2006, the members decided to change their names; Ohkawa later changed her name back from Ageha Ohkawa to Nanase Ohkawa, while the other three members retained their new names. \n\n(Source: Wikipedia)\n\nTwitter: @CLAMP_news", null, null, null, "CLAMP", "https://cdn.myanimelist.net/images/voiceactors/3/54683.jpg", "https://myanimelist.net/people/1877/CLAMP", "http://clamp-net.com/" },
                    { 1878, "Blood type: A\nHeight: 5 ft\nBirth place: Ichinomiya, Aichi Prefecture\nCurrent residence: Tokyo, Japan\n\nArina participated in Shinshi Doumei Cross drama CDs as Yoshitaka Ichinomiya and Postman.\n\nTwitter: @arinacchi\nBlog: http://ameblo.jp/arina-tanemura", new DateTime(1978, 3, 11, 16, 0, 0, 0, DateTimeKind.Local), "種村", "有菜", "Arina Tanemura", "https://cdn.myanimelist.net/images/voiceactors/1/26249.jpg", "https://myanimelist.net/people/1878/Arina_Tanemura", "http://tanemuraarina.com/" },
                    { 1879, "Masashi Kishimoto is a Japanese manga artist, well known for creating the manga series Naruto. His younger twin brother, Seishi Kishimoto, is also a manga artist and creator of the manga series 666 Satan and Blazer Drive.", new DateTime(1974, 11, 7, 16, 0, 0, 0, DateTimeKind.Local), "岸本", "斉史", "Masashi Kishimoto", "https://cdn.myanimelist.net/images/voiceactors/2/42365.jpg", "https://myanimelist.net/people/1879/Masashi_Kishimoto", null },
                    { 1880, "He was born in Hiroshima, Japan. His real name is Noriaki Kubo (久保 宣章).\n\nTwitter: @tite_official", new DateTime(1977, 6, 25, 17, 0, 0, 0, DateTimeKind.Local), "久保", "帯人", "Tite Kubo", "https://cdn.myanimelist.net/images/voiceactors/1/73410.jpg", "https://myanimelist.net/people/1880/Tite_Kubo", null },
                    { 1881, "Hometown: Kumamoto, Japan\nBlood type: A\nFavourite Animal: Big gentle dogs\nFavourite Mangaka: Akira Toriyama\nFavourite Music: '70s soul music\nFavourite Real-Life Pirate: Edward Teach (Blackbeard)\nFavourite Video Game: Puyo Puyo\n\n- Eiichiro Oda was formerly Nobuhiro Watsuki's assistant alongside Hiroyuki Takei. He was also Shinobu Kaitani's assistant.\n- Eiichiro Oda is married to Chiaki Inaba, who had played Nami during Jump Festa One Piece stage performances.\n- In a recent Japanese fan poll, Eiichiro Oda is currently ranked the 48th Most Popular Character in One Piece, despite the fact that he has never included himself in any issue of the manga (excluding SBS).\n- He voiced the character \"Odacchi\" in a soccer-themed short that aired with the 3rd One Piece Movie. \"Odacchi\" is Oda's nickname, and he played soccer when he was younger.\n- Oda is a fan of rapper Eminem, filmmaker Quentin Tarantino and Tim Burton.\n- Oda's 3 favorite movies are Seven Samurai, The Nightmare Before Christmas, and Young Guns.\n- According to Oda in an interview for US Shonen Jump, his favorite villain in One Piece is Buggy the Clown (he joked that he literally threw him together).", new DateTime(1974, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), "尾田", "栄一郎", "Eiichiro Oda", "https://cdn.myanimelist.net/images/voiceactors/2/74096.jpg", "https://myanimelist.net/people/1881/Eiichiro_Oda", null },
                    { 1882, "Blood type: O\nHometown: Nagano, Nagano Prefecture, Japan\n\nTwitter: @hiro_mashima\nYouTube: mashimaCh", new DateTime(1977, 5, 2, 17, 0, 0, 0, DateTimeKind.Local), "真島", "ヒロ", "Hiro Mashima", "https://cdn.myanimelist.net/images/voiceactors/1/53830.jpg", "https://myanimelist.net/people/1882/Hiro_Mashima", null },
                    { 1883, "Birth place: Nagoya, Japan\nCurrent residence: Tokyo, Japan\nBlood type: B\nDoujin circle: LEVEL-X\n\nKen Akamatsu is a Japanese mangaka. He is married to his wife \"Kanon\" Akamatsu, who was previously a singer/idol.\n\nIn his teenage years, Akamatsu failed the entrance exam to Tokyo University, and applied for Film Study instead (it is speculated that this is where he got the idea for Love Hina). Eventually, he became famous as an illustrator featured in Comiket. He used the pen name Awa Mizuno. Akamatsu, still in college, then proceeded to win the Weekly Shonen Magazine award twice. His A Kid's Game for One Summer was awarded the coveted 50th Shonen Magazine Newcomer's Award soon after he graduated.\n\nAfter a big hit with A.I. Love You, he finally made a grand success with his new manga Love Hina, which received the Kodansha Manga Award for shounen in 2001. Akamatsu had added elements of his own life experiences to the story, and this was said to have induced a unique feeling to the manga especially for Western readers, whose lack of familiarity with Japanese culture for the most part added to the effect.\n\nTwitter: @KenAkamatsu\nTumblr: @kenakamatsu\nFacebook: @Akamatsu.Ken\nBlog: http://d.hatena.ne.jp/KenAkamatsu/", new DateTime(1968, 7, 4, 17, 0, 0, 0, DateTimeKind.Local), "赤松", "健", "Ken Akamatsu", "https://cdn.myanimelist.net/images/voiceactors/3/40149.jpg", "https://myanimelist.net/people/1883/Ken_Akamatsu", "http://www.ailove.net/" },
                    { 1884, null, new DateTime(1970, 4, 25, 17, 0, 0, 0, DateTimeKind.Local), "小花", "美穂", "Miho Obana", "https://cdn.myanimelist.net/images/voiceactors/3/1821.jpg", "https://myanimelist.net/people/1884/Miho_Obana", "http://www.m-obana.com" },
                    { 1885, "Sign: Cancer\nBlood Type: B\nBirth Place: Kanagawa, Japan", new DateTime(1970, 7, 8, 17, 0, 0, 0, DateTimeKind.Local), "津田", "雅美", "Masami Tsuda", "https://cdn.myanimelist.net/images/voiceactors/2/4192.jpg", "https://myanimelist.net/people/1885/Masami_Tsuda", null },
                    { 1886, "Birthplace: Tokyo\nBlood type: O\n\nGraduated from Tokyo Metropolitan Musashi Senior High School and Waseda University School of Economics &amp; Political Science.\n\nReceived the 2003 Kodansha Manga Award for Shounen (Kunimitsu no Matsuri).\n\nPennames:\n- Agi Tadashi (亜樹 直) - shared with his sister\n- Andou Yuuma (安童 夕馬)\n- Aoki Yuuya (青樹 佑夜)\n- Arimori Jyoji (有森 丈時)\n- Igano Hiroaki (伊賀 大晃)\n- Kibayashi\n- Ryuumon Ryou (龍門諒)\n- S.K.\n- Seimaru Amagi (天樹 征丸)\n\nTwitter: @agitadashi", new DateTime(1962, 7, 21, 17, 0, 0, 0, DateTimeKind.Local), "樹林", "伸", "Shin Kibayashi", "https://cdn.myanimelist.net/images/voiceactors/2/12207.jpg", "https://myanimelist.net/people/1886/Shin_Kibayashi", "http://d.hatena.ne.jp/seiama/" },
                    { 1887, "Japanese manga artist best known for drawing the series GetBackers.\n\nPrior to his work on GetBackers, Ayamine was an assistant under Tooru Fujisawa and worked on Shounan Junaigumi!, Bad Company and GTO.\n\nBecause of the break-neck speed of publication for GetBackers, Ayamine was known to have fallen ill during the manga's serialization as frequently one tankoubon is published every two months; the longest interval for publication was four months, between volumes 15 and 16.\n\nAyamine was suffering from a heavy depression and he couldn't complete the manuscript of Oniwaka to Ushiwaka. Due to this, Holy Talker and Oniwaka to Ushiwaka have been on hiatus since 2010. He still draws casually, but now focuses solely on writing new works, such as Majestic Prince.\n\nTakao Aoyagi, Atsushi Ookubo, Yuuji Terajima, Yuki Okada, Shouki Yonebayashi, Hikaru Nikaidou, Hiroshi Shimotsuura, Jolly Mamma and Yuuji Ninomiya were his assistants on GetBackers.\n\nFun fact: In Ahiru no Sora chapter 9, Takeshi Hinata once forgot to draw the stripes on a jersey, and he already sent the manuscript to Weekly Shonen Magazine editorial office. Ayamine who was there at the office drew it for Hinata.\n\nTwitter: @rand_usatan\nPixiv: #2367236", new DateTime(1974, 2, 16, 16, 0, 0, 0, DateTimeKind.Local), "綾峰", "欄人", "Rando Ayamine", "https://cdn.myanimelist.net/images/voiceactors/3/4087.jpg", "https://myanimelist.net/people/1887/Rando_Ayamine", "http://d.hatena.ne.jp/sijimi217/" },
                    { 1888, "Born in Niigata, Niigata Prefecture, Japan.\n\nOnce used the pseudonym Hijikata Shigeru.\n\nHis assistants included Hoshino, Katsura and Murata, Yusuke.", new DateTime(1969, 2, 10, 16, 0, 0, 0, DateTimeKind.Local), "小畑", "健", "Takeshi Obata", "https://cdn.myanimelist.net/images/voiceactors/2/39958.jpg", "https://myanimelist.net/people/1888/Takeshi_Obata", null },
                    { 1889, "Born in Aichi Prefecture", null, "堀田", "由美", "Yumi Hotta", "https://cdn.myanimelist.net/images/voiceactors/3/9129.jpg", "https://myanimelist.net/people/1889/Yumi_Hotta", null },
                    { 1890, "Zodiac: Gemini\nBirthplace: Tokyo, Japan\nHometown: Nagaoka, Niigata, Japan\nEnjoys: playing video games, reading other manga, watching television\nFavorite American comic book: X-Men\nFavorite Anime: Neon Genesis Evangelion\n\nHe once worked as an assistant for his favorite author, Takeshi Obata, and is influenced by Marvel comics such as the X-Men and Spider-Man. In February of 2018 he was found to be in possession of child pornography, and was fined ¥200,000.\n\n(Source: Wikipedia)", new DateTime(1970, 5, 25, 17, 0, 0, 0, DateTimeKind.Local), "和月", "伸宏", "Nobuhiro Watsuki", "https://cdn.myanimelist.net/images/voiceactors/1/48271.jpg", "https://myanimelist.net/people/1890/Nobuhiro_Watsuki", null },
                    { 1891, "Hometown: Niigata, Niigata, Japan\nBlood type: A+'\nZodiac: Libra\n\nRumiko Takahashi is one of the wealthiest women in Japan. The manga she creates (and its anime adaptations) are very popular in the United States and Europe where they have been released as both manga and anime in English translation. Her works are relatively famous worldwide, and many of her series were some of the forerunners of early English language manga to be released in the nineties. Takahashi is also the best selling female comics artist in history; well over 100 million copies of her various works have been sold.\n\nThough she was said to occasionally doodle in the margins of her papers while attending Niigata Chuuou High School, Takahashi's interest in manga did not come until later. During her college years, she enrolled in Gekiga Sonjuku, a manga school founded by Kazuo Koike, mangaka of Crying Freeman and Lone Wolf and Cub. Under his guidance Rumiko Takahashi began to publish her first doujinshi creations in 1975, such as Bye-Bye Road and Star of Futile Dust. Kozue Koike often urged his students to create well-thought out, interesting characters, and this influence would greatly impact Rumiko Takahashi's works throughout her career.\n\nCareer and major works:\n\nTakahashi's professional career began in 1978. Her first published story was Those Selfish Aliens, a comedic science fiction story. During the same year, she published Time Warp Trouble, Shake Your Buddha, and the Golden Gods of Poverty in Shounen Sunday, which would remain the home to most of her major works for the next twenty years. Later that year, Rumiko attempted her first full-length series, Urusei Yatsura. Though it had a rocky start due to publishing difficulties, Urusei Yatsura would become one of the most beloved anime and manga comedies in Japan.\n\nIn 1980, Rumiko Takahashi found her niche and began to publish with regularity. At this time she started her second major series, Maison Ikkoku, in Big Comic Spirits. Written for an older audience, Maison Ikkoku is often considered to be one of the all-time best romance manga. Takahashi managed to work on Maison Ikkoku on and off simultaneously with Urusei Yatsura. She concluded both series in 1987, with Urusei Yatsura ending at 34 volumes, and Maison Ikkoku being 15.\n\nDuring the 1980s, Takahashi became a prolific writer of short story manga, which is surprising considering the massive lengths of most of her works. Her stories The Laughing Target, Maris the Chojo, and Fire Tripper all were adapted into original video animations (OVAs). In 1984, after the end of Urusei Yatsura and Maison Ikkoku, Takahashi took a different approach to storytelling and began the dark, macabre Mermaid Saga. This series of short segments was published sporadically until 1994, with the final story being Mermaid's Mask. Many fans contend that this work remains unfinished by Takahashi, since the final story does not end on a conclusive note.\n\nAnother short work left untouched is One-Pound Gospel, which, like Mermaid Saga, was published erratically. The last story to be drawn was published in 2001, however just recently she wrote one final chapter concluding the series\n\nLater in 1987, Takahashi began her third major series, Ranma ½. Following the late 80s and early 90s trend of shounen martial arts manga, Ranma ½ features a gender-bending twist. The series continued for nearly a decade until 1996, when it ended at 38 volumes. Ranma ½ is one of Rumiko Takahashi's most popular series with the Western world.\n\nDuring the later half of the 1990s, Rumiko Takahashi continued with short stories and her installments of Mermaid Saga and One-Pound Gospel until beginning her fourth major work, InuYasha. While Ranma ½, Urusei Yatsura, and Maison Ikkoku all were heavily seated in the romantic comedy genre, InuYasha was more akin to her dark Mermaid Saga. The series became her most eclectic work, featuring action, romance, horror, fantasy, (folklore-based) historical fiction, and comedy.\n\n(Source: MU)\n\nTwitter: @rumicworld1010", new DateTime(1957, 10, 9, 17, 0, 0, 0, DateTimeKind.Local), "高橋", "留美子", "Rumiko Takahashi", "https://cdn.myanimelist.net/images/voiceactors/3/82443.jpg", "https://myanimelist.net/people/1891/Rumiko_Takahashi", null },
                    { 1892, "Hometown: Shiga Prefecture, Japan\nBlood type: O\n\nInstagram: https://www.instagram.com/katsura_5600/", new DateTime(1980, 4, 20, 17, 0, 0, 0, DateTimeKind.Local), "星野", "桂", "Katsura Hoshino", "https://cdn.myanimelist.net/images/voiceactors/2/51152.jpg", "https://myanimelist.net/people/1892/Katsura_Hoshino", null },
                    { 1893, "Birth place: Yamagata Prefecture, Japan\nBlood type: A\nFavorite food: rice with curry\nHobbies: bowling, horror films, occult television programs, video games\n\nYoshihiro Togashi is a Japanese manga artist. He is most notable for having created Yuu Yuu Hakusho, for which he received the Shogakukan Manga Award in 1994, and Hunter x Hunter. According to Shonen Jump, Togashi received the Tezuka Award, the most influential new comic artist award in Japan.\n\nTogashi is married to Naoko Takeuchi, the creator of Sailor Moon.\n\nTwitter: @Un4v5s8bgsVk9Xp", new DateTime(1966, 4, 26, 17, 0, 0, 0, DateTimeKind.Local), "冨樫", "義博", "Yoshihiro Togashi", "https://cdn.myanimelist.net/images/voiceactors/2/73638.jpg", "https://myanimelist.net/people/1893/Yoshihiro_Togashi", null },
                    { 1898, "Real name: Koharuno, Kokoro\nBirth place: Tokio\nBlood type: A\n\nIn April 2008, Koge-Donbo changed her pen-name by adding an asterisk (*) at the end. She is now known as Koge-Donbo*.\n\nTwitter: @koge_dobo\npixiv: #106417", new DateTime(1976, 2, 26, 16, 0, 0, 0, DateTimeKind.Local), null, "こげどんぼ*", "Koge-Donbo*", "https://cdn.myanimelist.net/images/voiceactors/3/62725.jpg", "https://myanimelist.net/people/1898/Koge-Donbo", null },
                    { 1900, "Birth place: Kochi, Japan\n\nKentaro Yabuki is a Japanese manga artist. His mentor was Takeshi Obata, the illustrator of Death Note, Hikaru no Go and Bakuman.\n\nYabuki is best known for his series Black Cat which ran from 2000 to 2004 in Weekly Shounen Jump and later adapted into an anime. Upon its ending, Yabuki expressed desire to make a sequel from the series, or make its characters reappear in another work. Since 2004, he has only been working as illustrator to works written by other authors. Most notably on the series To Love-Ru alongside his former assistant Saki Hasemi.\n\nTwitter: @yabuki_info", new DateTime(1980, 2, 3, 16, 0, 0, 0, DateTimeKind.Local), "矢吹", "健太朗", "Kentarou Yabuki", "https://cdn.myanimelist.net/images/voiceactors/1/58809.jpg", "https://myanimelist.net/people/1900/Kentarou_Yabuki", null },
                    { 1901, "Toriyama died from acute subdural hematoma on March 1, 2024, at the age of 68.\n\nBirthplace: Kiyosu, Aichi Prefecture, Japan\nChildren: 1 son and 1 daughter\n\nHe debuted in 1979 with the story Wonder Island, published in Weekly Shounen Jump, and first gained popularity for the anime and manga series Dr. Slump, originally serialized weekly in Shounen Jump from 1980 to 1984. In 1982, he won the Shogakukan Manga Award for Dr. Slump for best shounen/shoujo manga series of the year.\n\nAkira Toriyama's clean line and design sense led to jobs designing characters for the phenomenally popular Dragon Quest series of role-playing games (formerly called Dragon Warrior in North America) since 1986, as well as its second anime adaptation Dragon Warrior: Legend of the Hero Abel which started in December 1989 on Fuji TV. Several Dragon Quest monsters designed by Toriyama make cameo appearances during the preliminaries of the 22nd World Martial Arts Tournament in Dragon Ball.\n\nExhibitions of works by Toriyama (Akira Toriyama Exhibition) ad locations in major cities in Japan, and collected more than 400,000 visitors in three years. Toriyama was also the character designer for the Super Famicom, PlayStation, and Nintendo DS RPG Chrono Trigger (1994, 1999, and 2008), the fighting games Tobal No. 1 (1996) and its sequel Tobal 2 (1997) for the PlayStation, as well as the Mistwalker Xbox 360 exclusive RPG Blue Dragon (2006) and its anime adaptation (2008).\n\nFavourites:\nAnimated Movie: 101 Dalmations\nCharacter of his own: Piccolo\nDragon ball movie: Bardock, The Father of Goku\nMovies: Jackie Chan Movies, Star Wars Episode IV: A New Hope\n\nToriyama's studio is called \"Bird Studio,\" which is a play on his name, \"tori\" meaning \"bird.\"", new DateTime(1955, 4, 4, 17, 0, 0, 0, DateTimeKind.Local), "鳥山", "明", "Akira Toriyama", "https://cdn.myanimelist.net/images/voiceactors/3/40043.jpg", "https://myanimelist.net/people/1901/Akira_Toriyama", null },
                    { 1902, "Birthplace: Tokyo, Japan\n\nTwitter: @reach_ina\n\nHe won the 7th \"Story King\" section in Weekly Shonen Jump No.51 2001. His previous works include Any number of times on the 13th of June, Square Freeze and LOVE LOVE Santa, which were published in Big Comic Spirits.", new DateTime(1976, 6, 19, 17, 0, 0, 0, DateTimeKind.Local), "稲垣", "理一郎", "Riichiro Inagaki", "https://cdn.myanimelist.net/images/voiceactors/3/5938.jpg", "https://myanimelist.net/people/1902/Riichiro_Inagaki", null },
                    { 1903, "Yusuke Murata was once an assistant of Obata Takeshi.\n\nMurata had a number of one-shots published in Weekly Shonen Jump, which won awards, namely Partner and Samui Hanashi, garnering the 122th Hop*Step award and the Second Prize in the 51th Akatsuka Award respectively.\n\nTwitter: @NEBU_KURO", new DateTime(1978, 7, 3, 17, 0, 0, 0, DateTimeKind.Local), "村田", "雄介", "Yusuke Murata", "https://cdn.myanimelist.net/images/voiceactors/3/5939.jpg", "https://myanimelist.net/people/1903/Yusuke_Murata", null },
                    { 1904, "Hideaki Sorachi (空知英秋, Sorachi Hideaki?, born May 25, 1979) is a Japanese manga artist best known for his work Gintama.\n\nAccording to his reply to a manga reader (Gintama Volume 11), he was quite interested in manga during childhood days. However at grade 4 in school he showed his work to his father who promptly laughed at it, after which Sorachi temporarily abandoned his aims of being a manga artist. After graduation, he could not find a job, thus he turned to drawing manga (which he had already learned in university). He was able to gain some recognition through his first work Dandylion and subsequently progressed in his career (the comic is shown in the first volume of Gintama, with a foreword by Hideaki stating that it was his first work).\n\nIn 2003, Sorachi's editor attempted to coax him to create a new series due to a new television program on the Shinsengumi airing on Japanese TV the next year. Yet Sorachi's original idea was to ride on the coattails of the Harry Potter franchise with a series about a school for demon dispellers. After several arguments and an attempt to write the Shinsengumi series, Sorachi gave up, took what he had of the script and twisted it to become the pseudo-historical science fiction series Gintama. (stated in Gintama Volume 1)\n\nHideaki Sorachi holds a degree in commercial advertising (again, stated in volume 11).\n\n(Source: Wikipedia)", new DateTime(1979, 5, 24, 17, 0, 0, 0, DateTimeKind.Local), "空知", "英秋", "Hideaki Sorachi", "https://cdn.myanimelist.net/images/voiceactors/1/44890.jpg", "https://myanimelist.net/people/1904/Hideaki_Sorachi", null },
                    { 1905, "Gender: Female\nBlood Type: A\nBirth Place: Shizuoka, Japan\n\nTwitter: @m_momokuri", new DateTime(1971, 8, 29, 17, 0, 0, 0, DateTimeKind.Local), "河下", "水希", "Mizuki Kawashita", "https://cdn.myanimelist.net/images/voiceactors/2/9355.jpg", "https://myanimelist.net/people/1905/Mizuki_Kawashita", null },
                    { 1907, "Hometown: Aichi, Japan\n\nAmano began in 1998 with a job at Weekly Young Magazine. She also held a job at Shueisha Publishing Co, Ltd.\n\nIn 2002, Amano participated in a contest for aspiring mangaka and was one of the lucky winners, with her comic Monkey Business published in Young Magazine.\n\nIn 2004, she finally found success with the humourous and classy manga Katekyo Hitman Reborn!. Amano had some crazy ideas to entertain readers with. She came up with weird characters to add spice to the humour, a story written especially to be unique, and fast-paced action.\n\nColleagues:\nKen Osamu Sakaki\nKAITO\nMain pine of indigo\nKobayashi\nKasuga truth\n\nTwitter: @amano_akira_", new DateTime(1973, 6, 21, 17, 0, 0, 0, DateTimeKind.Local), "天野", "明", "Akira Amano", "https://cdn.myanimelist.net/images/voiceactors/1/40148.jpg", "https://myanimelist.net/people/1907/Akira_Amano", null },
                    { 1909, "Height: 180 cm\nBlood Type: O\nZodiac Sign: Cancer\nBirthplace: Osaka, Japan\nHandedness: Right\nFavorite Foods: sashimi &amp; sushi, sake, crab, oranges\nHobbies: Going to the gym, taking care of his health, playing Mario Party 3", new DateTime(1970, 6, 25, 17, 0, 0, 0, DateTimeKind.Local), "許斐", "剛", "Takeshi Konomi", "https://cdn.myanimelist.net/images/voiceactors/1/15989.jpg", "https://myanimelist.net/people/1909/Takeshi_Konomi", null },
                    { 1910, "Birthplace: Yomogita, Aomori Prefecture, Japan\n\nTwitter: @takeimokei", new DateTime(1972, 5, 14, 17, 0, 0, 0, DateTimeKind.Local), "武井", "宏之", "Hiroyuki Takei", "https://cdn.myanimelist.net/images/voiceactors/2/44333.jpg", "https://myanimelist.net/people/1910/Hiroyuki_Takei", null },
                    { 1925, "After studying Japanese art at Aichi Art College, he started his career as a professional comic writer/artist when \"Steel Queen\" was published in Weekly Shonen Jump Extra in 1975. In the same year, he received the Tezuka Award as the best young comic creator for his \"Morning Faraway\" and quickly established himself as the most promising writer/artist in \"hard\" science-fiction comics.", new DateTime(1954, 1, 28, 16, 0, 0, 0, DateTimeKind.Local), "星野", "之宣", "Yukinobu Hoshino", "https://cdn.myanimelist.net/images/voiceactors/1/10995.jpg", "https://myanimelist.net/people/1925/Yukinobu_Hoshino", null },
                    { 1932, "Real name: Oogure, Ito (大暮 維人)\nBirth place: Hyuga, Miyazaki, Japan\nZodiac: Pisces\nBlood Type: AB\n\nOh! Great is a pun on his name.\n\nTwitter: @ohgreatofficial", new DateTime(1972, 2, 21, 16, 0, 0, 0, DateTimeKind.Local), "大暮", "維人", "Oh! Great", "https://cdn.myanimelist.net/images/voiceactors/1/2663.jpg", "https://myanimelist.net/people/1932/Oh_Great", null },
                    { 1938, "Died: February 9, 1989 (aged 60)\nBirth place: Toyonaka, Osaka Prefecture, Japan\n\nTezuka was a Japanese manga artist, cartoonist, animator, and film producer. His prolific output, pioneering techniques, and innovative redefinitions of genres earned him such titles as \"the father of manga,\" \"the godfather of manga\" and \"the god of manga.\" Additionally, he is often considered the Japanese equivalent to Walt Disney, who served as a major inspiration during Tezuka's formative years.\n\nTezuka began what was known as the manga revolution in Japan with his New Treasure Island published in 1947. His legendary output would spawn some of the most influential, successful, and well-received manga series including Tetsuwan Atom, Jungle Taitei, Black Jack, and Hi no Tori, all of which won several awards.\n\nTezuka died of stomach cancer in 1989. His death had an immediate impact on the Japanese public and other cartoonists. A museum was constructed in Takarazuka dedicated to his memory and life works, and Tezuka received many posthumous awards. Several animations were in production at the time of his death along with the final chapters of Hi no Tori, which were never released.\n\n(Source: Wikipedia)", new DateTime(1928, 11, 2, 16, 0, 0, 0, DateTimeKind.Local), "手塚", "治虫", "Osamu Tezuka", "https://cdn.myanimelist.net/images/voiceactors/2/42193.jpg", "https://myanimelist.net/people/1938/Osamu_Tezuka", "http://tezukaosamu.net/" },
                    { 1944, "Kouga Yun (real name: Yamada Risa, 山田理沙, née Kimura) is a Japanese mangaka, born on July 9, 1965 in Shinagawa-ku, Tokyo, Japan. Her blood type is B, and she is married to fellow mangaka Tatsuneko. She is a graduate of Mita Senior High School, Tokyo. She currently lives in Setagaya-ku, Tokyo, and also has a daughter.\n\nShe began her career as a doujinshi artist creating doujinshi for works such as Saint Seiya, Captain Tsubasa and Maouden.\n\nShe debuted in a commercial magazine with the original work Metal Heart (serialised in Kobunsha's Comic VAL from November 1986). After her debut, she continued to contribute on numerous doujin works. However, the later disbanding of a doujin circle, Yajou Teikoku, she had founded with Maki Chikura, led to her taking numerous breaks from her commercial works. Due to this, there were incomplete works penned by her during this period.\n\nDuring her years in middle school, she had been a fan of Masami Kurumada's manga series Ring ni Kakero, Fuuma no Kojirou, Saint Seiya and B't X (serialised in Weekly Shounen Jump), sending Kurumada numerous fan letters asking to meet him, after which Kurumada finally agreed, inviting her to his workplace.\n\nWhen asked about her penname in an interview in the September 2006 issue of Puff, she responded that she had originally thought of making it Kouga Jun, but subsequently changed it to Kouga Yun.\n\nAmong her noted works is Loveless, which has been serialised in Monthly Comic Zero Sum since 2002 and is ongoing, as well as her work Tenshichou (天使庁). She has also worked as an illustrator on the noted literary magazine Faust.\n\nIn 2007, she contributed the character designs to the Sunrise anime series, Mobile Suit Gundam 00.\n\n(Source: AniDB)\n\nTwitter: @yunk99\nBlog: http://yunkouga.jugem.jp/", new DateTime(1965, 7, 8, 17, 0, 0, 0, DateTimeKind.Local), "高河", "ゆん", "Yun Kouga", "https://cdn.myanimelist.net/images/voiceactors/1/32355.jpg", "https://myanimelist.net/people/1944/Yun_Kouga", "http://yunk.jp/" },
                    { 1952, "twitter @ bunjuro", new DateTime(1964, 5, 14, 17, 0, 0, 0, DateTimeKind.Local), "中山", "文十郎", "Bunjuro Nakayama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/1952/Bunjuro_Nakayama", null },
                    { 1954, "Was an apprentice to Kazunori Ito.\n\nTwitter: @miu_kawasaki", new DateTime(1982, 1, 20, 16, 0, 0, 0, DateTimeKind.Local), "川崎", "美羽", "Miu Kawasaki", "https://cdn.myanimelist.net/images/voiceactors/2/17783.jpg", "https://myanimelist.net/people/1954/Miu_Kawasaki", null },
                    { 1955, "Birth place: Ibaraki Prefecture, Japan", new DateTime(1973, 3, 3, 16, 0, 0, 0, DateTimeKind.Local), "浜崎", "達也", "Tatsuya Hamazaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/1955/Tatsuya_Hamazaki", null },
                    { 1968, "Mikimoto (real name is Haruhiko Satou) is a comic book artist, illustrator, anime character designer. Mostly active during the 1980s, during that decade he rose to promience and is considered one of the top character designers of his time. He was born on August 28, 1959 in Tokyo, Japan. He graduated from Keio University. He became animator of Artland while attending school, and took charge of the Model sheet of Choujikuu Yousai Macross.", new DateTime(1959, 8, 27, 17, 0, 0, 0, DateTimeKind.Local), "美樹本", "晴彦", "Haruhiko Mikimoto", "https://cdn.myanimelist.net/images/voiceactors/3/39541.jpg", "https://myanimelist.net/people/1968/Haruhiko_Mikimoto", "http://www.mikimotoharuhiko.com/" },
                    { 1993, "Blood Type: O\nBirth Place: Yamagata Shinjo, Japan\nZodiac Sign: Pisces\nTwitter: @Abe_Yutaka\n\nNote: 1979 - 2nd Pupil Rookie Comics Award honorable mention.", null, "阿部", "ゆたか", "Yutaka Abe", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/1993/Yutaka_Abe", "http://www3.to/abe79" },
                    { 1995, "Abeno Chaco is a female Japanese illustrator and manga artist. She publishes doujinshi with the circle \"Kappa Kurieito\" (カッパくりえいと) and \"HAKKA PINK.\" She is also involved in the artwork of adult games.\n\nTwitter: @abenochaco", null, "阿倍野", "ちゃこ", "Chaco Abeno", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/1995/Chaco_Abeno", "http://www.lifox.co.jp/abeno_chaco/index.html" },
                    { 1999, "Hometown: Tsukishima, Chuo, Tokyo, Japan \nBlood type: A\n\nIn his school days, Kurumada Masami was deeply impressed by Motomiya Hiroshi's Otoko Ippiki Gaki Daishou, and that's what inspired him to become a mangaka. He submitted his first work to Weekly Shounen Jump when he was in the 3rd year of high school. The submission was rejected, however when he went to the company hoping to get an explanation, he got to know Inoue Koo and became his assistant. Later, at the age of 20, he officialy debuted with his manga Sukeban Arashi.", new DateTime(1953, 12, 5, 16, 0, 0, 0, DateTimeKind.Local), "車田", "正美", "Masami Kurumada", "https://cdn.myanimelist.net/images/voiceactors/1/4987.jpg", "https://myanimelist.net/people/1999/Masami_Kurumada", "http://kurumadapro.com/" },
                    { 2009, "Shinichirou Watanabe is a Japanese anime filmmaker, screenwriter, and producer. He is known for directing the popular anime series Cowboy Bebop and Samurai Champloo.\n\nWatanabe is noted for blending together multiple genres in his anime. For example, in Cowboy Bebop, classic cowboy western mixes with 1940s/1950s New York City film noir, Jazz music and Hong Kong action movies, all while being set in space. In his later work, Samurai Champloo, Watanabe mixes the cultures of Okinawa, hip-hop, modern-day Japan, and samurai.", new DateTime(1965, 5, 23, 17, 0, 0, 0, DateTimeKind.Local), "渡辺", "信一郎", "Shinichirou Watanabe", "https://cdn.myanimelist.net/images/voiceactors/3/48770.jpg", "https://myanimelist.net/people/2009/Shinichirou_Watanabe", null },
                    { 2011, "Male\nSagittarius\nReal name: Shuji Sato (佐藤 修司)\nBorn: Kutchan, Abuta District, Hokkaido, Japan\nCurrent residence: Tokyo, Japan\n\nTwitter: @masyuuki", new DateTime(1957, 12, 18, 16, 0, 0, 0, DateTimeKind.Local), "ゆうき", "まさみ", "Masami Yuuki", "https://cdn.myanimelist.net/images/voiceactors/2/3259.jpg", "https://myanimelist.net/people/2011/Masami_Yuuki", "http://www.yuukimasami.com/" },
                    { 2015, null, null, "山口", "優", "Yuu Yamaguchi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2015/Yuu_Yamaguchi", null },
                    { 2025, "Female", new DateTime(1956, 4, 6, 17, 0, 0, 0, DateTimeKind.Local), "夢野", "一子", "Kazuko Yumeno", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2025/Kazuko_Yumeno", null },
                    { 2034, "Birth place: Yokohama, Kanagawa, Japan\nBlood type: B\nGender: male\n\nBefore writing his own manga he started out as an assistant to Shin Morimura. He debuted in 2000 with Planetes, which was adapted to a 26-episode anime. He is currently working on Vinland Saga which began serialization in Weekly Shounen Magazine, and later on continued serialization in Afternoon. He has won the 2009 Japan Media Arts Festival Grand Prize for Vinland Saga\n\nTwitter: @makotoyukimura", new DateTime(1976, 5, 7, 17, 0, 0, 0, DateTimeKind.Local), "幸村", "誠", "Makoto Yukimura", "https://cdn.myanimelist.net/images/voiceactors/2/80324.jpg", "https://myanimelist.net/people/2034/Makoto_Yukimura", null },
                    { 2042, "Yudetamago is the pen name of the Japanese mangaka duo consisting of story writer Takashi Shimada and artist Yoshinori Nakai. They are best known for the popular manga Kinnikuman, Ultimate Muscle (Kinnikuman Nisei), and Tatakae!! Ramenman. \n\nShimada Takashi (嶋田 隆司)\nStory Writer\nHometown: Nishiyodogawa-ku, Osaka\nBirthdate: October 28, 1960\nRecognizable feature: droopy eyes\n\nA graduate of Hatushiba High School (Higashi, Sakai, Osaka), up until 1984 he went by the name Takashi Kaneyama (金山 隆司, Kaneyama Takashi). He frequently attends movie premieres, events, and interviews by himself and has the more exposure of the duo. These appearances have led to his being jokingly referred to as \"The Non-Working Half of Yude\". He claims to have been a naughty child in his younger days and that his favorite show was a TV Drama called Playgirl. He loved to read and draw manga, and before he met Nakai he would often draw Kinnikuman on notebook paper.\n\nNakai Yoshinori (中井 義則)\nArtist\nHometown: Nishinari-ku, Osaka\nBirthdate: January 11, 1961\nRecognizable feature: glasses\n\nA graduate of Hatushiba High School, up until 1984 he went by the name Yoshinori Iwamoto (岩元 義則, Iwamoto Yoshinori). He has stated that he likes to stay home by himself and that his favorite actress is Mariko Kawana. Before he started school, he was an avid baseball player and fan and dreamed of one day becoming a Pro Baseball player. He liked to draw but has said that he didn't really read manga until he met Shimada.\n\n(Source: Wikipedia)", null, "ゆでたまご", null, "Yudetamago", "https://cdn.myanimelist.net/images/voiceactors/1/43116.jpg", "https://myanimelist.net/people/2042/Yudetamago", "http://www.yudetamago.jp" },
                    { 2052, null, new DateTime(1971, 12, 1, 16, 0, 0, 0, DateTimeKind.Local), "吉崎", "観音", "Mine Yoshizaki", "https://cdn.myanimelist.net/images/voiceactors/3/16231.jpg", "https://myanimelist.net/people/2052/Mine_Yoshizaki", "http://mnet.nicomi.com/" },
                    { 2054, "Gender: Male\nHometown: Miyazaki, Japan \n\nTwitter: @yoshi_akihito\n\nYouTube:\nhttps://www.youtube.com/@akihitoyoshitomi3758/featured", null, "吉富", "昭仁", "Akihito Yoshitomi", "https://cdn.myanimelist.net/images/voiceactors/2/1997.jpg", "https://myanimelist.net/people/2054/Akihito_Yoshitomi", "http://garigarieatman.la.coocan.jp/" },
                    { 2077, "Birthplace: Osaka, Japan\n\nTwitter: @H_tamakoshi", null, "玉越", "博幸", "Hiroyuki Tamakoshi", "https://cdn.myanimelist.net/images/voiceactors/3/9231.jpg", "https://myanimelist.net/people/2077/Hiroyuki_Tamakoshi", "http://tamakoshi.jugem.jp" },
                    { 2079, null, null, null, null, "Masanori Yoshida", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2079/Masanori_Yoshida", null },
                    { 2111, "Birthplace: Tokyo\nHobby: Collecting teacups\n\nTsugumi Ohba is a fictional writer credited with writing the manga Death Note. His/Her real identity (and gender) is a closely guarded secret. Some fans believe that Tsugumi Ohba is just a pen-name for Hiroshi Gamou.\n\nDay and night, develops manga plots while holding knees on a chair (reminiscent of one of the main characters in Death Note, L.) (Source: The VIZ English graphic novel's profile)", new DateTime(1962, 8, 16, 17, 0, 0, 0, DateTimeKind.Local), "大場", "つぐみ", "Tsugumi Ohba", "https://cdn.myanimelist.net/images/voiceactors/2/2137.jpg", "https://myanimelist.net/people/2111/Tsugumi_Ohba", null },
                    { 2135, "Birth place: Chiba Prefecture\n\nTwitter: @jin_kobayashi_", new DateTime(1977, 5, 24, 17, 0, 0, 0, DateTimeKind.Local), "小林", "尽", "Jin Kobayashi", "https://cdn.myanimelist.net/images/voiceactors/1/30245.jpg", "https://myanimelist.net/people/2135/Jin_Kobayashi", null },
                    { 2139, "Twitter: @akasaka_aka\npixiv: #3127667", new DateTime(1988, 8, 28, 17, 0, 0, 0, DateTimeKind.Local), "赤坂", "アカ", "Aka Akasaka", "https://cdn.myanimelist.net/images/voiceactors/2/71040.jpg", "https://myanimelist.net/people/2139/Aka_Akasaka", null },
                    { 2141, "Died: August 2, 2008 (aged 72)\n\nFujio Akatsuka was a pioneer Japanese artist of comical manga known as the Gag Manga King.\n\nHe started his career as a shoujo artist, but in 1958, his Nama-chan became a hit, so he became a specialist in comedy manga. He won the Shogakukan Manga Award in 1964 for Osomatsu-kun and the Bungeishunjuu Manga Award in 1971 for Tensai Bakabon.\n\n(Source: Wikipedia)", new DateTime(1935, 9, 13, 17, 0, 0, 0, DateTimeKind.Local), "赤塚", "不二夫", "Fujio Akatsuka", "https://cdn.myanimelist.net/images/voiceactors/1/42211.jpg", "https://myanimelist.net/people/2141/Fujio_Akatsuka", null },
                    { 2155, null, new DateTime(1952, 12, 10, 16, 0, 0, 0, DateTimeKind.Local), "秋本", "治", "Osamu Akimoto", "https://cdn.myanimelist.net/images/voiceactors/3/55843.jpg", "https://myanimelist.net/people/2155/Osamu_Akimoto", null },
                    { 2168, "Twitter: @childmannetwork", null, "秋田", "禎信", "Yoshinobu Akita", "https://cdn.myanimelist.net/images/voiceactors/2/68330.jpg", "https://myanimelist.net/people/2168/Yoshinobu_Akita", null },
                    { 2180, "Gender: Female\n\nTwitter: @akizuki072", null, "あきづき", "りょう", "Ryou Akizuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2180/Ryou_Akizuki", null },
                    { 2196, null, null, "南天", "佑", "Yutaka Nanten", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2196/Yutaka_Nanten", null },
                    { 2197, "Hajime Yatate is a pseudonym for the collective contributions of the Sunrise animation staff. \n\n(Source: Wikipedia)", null, "矢立", "肇", "Hajime Yatate", "https://cdn.myanimelist.net/images/voiceactors/3/42631.jpg", "https://myanimelist.net/people/2197/Hajime_Yatate", null },
                    { 2198, null, null, null, null, "Cain Kuga", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2198/Cain_Kuga", null },
                    { 2204, "Kaiji Kawaguchi is a leading artist of seinen-manga, born in Hiroshima. He is best known for the manga series Eagle, a political thriller about a Japanese American running for president, that ran in Big Comic of the Shogakukan publishing house between 1998 and 2001. Kawaguchi has been active in the manga field since the mid-1980s, and has published titles like Hard &amp; Loose, The Silent Service (1989-1996), Medusa (1990), Seizon Life (2000) and Zipang (2001).", new DateTime(1948, 7, 26, 17, 0, 0, 0, DateTimeKind.Local), "川口", "開治", "Kaiji Kawaguchi", "https://cdn.myanimelist.net/images/voiceactors/1/59166.jpg", "https://myanimelist.net/people/2204/Kaiji_Kawaguchi", null },
                    { 2213, null, null, "近藤", "和久", "Kazuhisa Kondo", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2213/Kazuhisa_Kondo", null },
                    { 2220, null, new DateTime(1947, 12, 8, 16, 0, 0, 0, DateTimeKind.Local), "安彦", "良和", "Yoshikazu Yasuhiko", "https://cdn.myanimelist.net/images/voiceactors/2/43120.jpg", "https://myanimelist.net/people/2220/Yoshikazu_Yasuhiko", null },
                    { 2229, "Born in Gifu Prefecture in 1977, Tow Ubukata was exposed to a blending of cultures from early childhood until the age of fourteen, having lived in Singapore and Nepal because of his father's work. In 1996, while in college, Ubukata won the first Sneaker Taisho Gold Prize for his light novel Kuroi Kisetsu (Black Season) and thus debuted as a writer. In 2003, he won the Nihon SF Taisho Award for Mardock Scramble, originally published as a three-volume series. He is involved in a wide range of projects including anime production for Fafner, video game production, and original content writing for comics such as Le Chevalier D'Eon. His other works include the Bye-Bye Earth and Spiegel novel series. In 2009, he published his first historical novel, Tenchi Meisatsu, focusing on a mathematician of the Edo period.", new DateTime(1977, 2, 13, 16, 0, 0, 0, DateTimeKind.Local), "冲方", "丁", "Tow Ubukata", "https://cdn.myanimelist.net/images/voiceactors/3/41511.jpg", "https://myanimelist.net/people/2229/Tow_Ubukata", "http://www.kh.rim.or.jp/~tow/" },
                    { 2233, "His birth name, Michitaka (通隆) Kikuchi (菊池), is used for anime roles, but Kia Asamiya for manga publications.", new DateTime(1963, 1, 27, 16, 0, 0, 0, DateTimeKind.Local), "麻宮", "騎亜", "Kia Asamiya", "https://cdn.myanimelist.net/images/voiceactors/1/3790.jpg", "https://myanimelist.net/people/2233/Kia_Asamiya", "http://www.tron.co.jp/" },
                    { 2249, "Picture and brief note by Matt Thorn:\nMatt's Shoujo Manga Photo Album : \nTAKAGUCHI Satosumi, creator of such popular shôjo manga as Hana no Asuka-gumi!, at her studio in Jan. '96. I tagged along with her then-editor from Kadokawa, SHIMAOKA Sakae, and representatives from Columbia Edutainment, who were visiting her to discuss the upcoming CD dramatizations of two of her recent works. Takaguchi is the single most organized and responsible shôjo manga artist I have ever met. And to think she used to be a juvenille delinquent! ^o^ \nhttp://www.matt-thorn.com/shoujo_manga/photo_album/index.php", new DateTime(1957, 9, 29, 17, 0, 0, 0, DateTimeKind.Local), "高口", "里純", "Satosumi Takaguchi", "https://cdn.myanimelist.net/images/voiceactors/2/7179.jpg", "https://myanimelist.net/people/2249/Satosumi_Takaguchi", "http://www.takaguchi.net/menu.html" },
                    { 2256, "Twitter: @fujimatakuya", null, "藤真", "拓哉", "Takuya Fujima", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2256/Takuya_Fujima", "http://fujima-blog.cocolog-nifty.com/" },
                    { 2308, "Twitter: @yamayama800", new DateTime(1964, 7, 28, 17, 0, 0, 0, DateTimeKind.Local), "山口", "宏", "Hiroshi Yamaguchi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2308/Hiroshi_Yamaguchi", null },
                    { 2312, "Blood Type: B\n\nTwitter: @tooyamatsuri\npixiv: #19293760\n\nMade her debut in September 2003 in the monthly manga magazine Nakayoshi with \"Tenshi no Tamago\" (Angel's Egg, no relation to the anime movie of the same name). Gokkun! Pūcho is considered her best representative work. Tokyopop has licensed it under the title Pixie Pop. All of her works are published by Kodansha, and they are enjoyed mainly by preteen and teen girls. \n\nFavorite manga:\n- Sayonara Zetsubou Sensei\n- Katteni Kaizou\n\n(Source: MU)", new DateTime(1981, 5, 22, 17, 0, 0, 0, DateTimeKind.Local), "遠山", "えま", "Ema Tooyama", "https://cdn.myanimelist.net/images/voiceactors/3/39101.jpg", "https://myanimelist.net/people/2312/Ema_Tooyama", "http://emaema.sakura.ne.jp/" },
                    { 2330, null, null, "千葉", "智宏", "Tomohiro Chiba", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2330/Tomohiro_Chiba", null },
                    { 2331, null, new DateTime(1961, 4, 3, 17, 0, 0, 0, DateTimeKind.Local), "ときた", "洸一", "Kouichi Tokita", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2331/Kouichi_Tokita", "http://tokita.blog.so-net.ne.jp/" },
                    { 2337, "Birth place:  Odawara, Kanagawa Prefecture, Japan\n\nYoshiyuki Tomino is a Japanese anime director, screenwriter, songwriter and novelist best known for creating the Gundam anime franchise.\n\nTomino joined Osamu Tezuka's company, Mushi Productions, on March 2, 1964, where he was originally a part of the production department and worked as a production assistant. Soon after, Tomino began drawing storyboards and writing screenplays for Astro Boy. He made his directorial debut with 1972's Triton of the Sea.\n\nTomino later became one of the most important members of the anime studio Sunrise (now Bandai Namco Filmworks), going on to direct numerous anime through the 1970s, 1980s and 1990s. Tomino is best known for his transformation of the \"Super Robot\" mecha anime genre into the \"Real Robot\" genre with 1979's Mobile Suit Gundam.\n\nTomino is known for using numerous pseudonyms for miscellaneous staffing roles that he performs in his works, including Minami Asa and Minoru Yokitani, which are used to credit himself for screenplays and storyboards he creates, and Rin Iogi, which he uses to credit himself for theme song lyrics he writes.\n\nIn 2021, Tomino received the Person of Cultural Merit title, which is an official Japanese recognition and honour which is awarded annually to select people who have made outstanding cultural contributions.\n\n(Source: Wikipedia)", new DateTime(1941, 11, 4, 16, 0, 0, 0, DateTimeKind.Local), "富野", "由悠季", "Yoshiyuki Tomino", "https://cdn.myanimelist.net/images/voiceactors/2/42075.jpg", "https://myanimelist.net/people/2337/Yoshiyuki_Tomino", null },
                    { 2338, null, null, "岩瀬", "昌嗣", "Masatsugu Iwase", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2338/Masatsugu_Iwase", null },
                    { 2339, "Twitter: @masatonatsumoto", new DateTime(1950, 2, 8, 16, 0, 0, 0, DateTimeKind.Local), "夏元", "雅人", "Natsumoto Masato", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2339/Natsumoto_Masato", null },
                    { 2340, "Worked as an assistant for Kyoko Okazaki\n\nAnno Moyoko was born March 26, 1971 in Suginami, Tokyo, Japan. She is a manga artist and fashion writer, with numerous books published in both categories. Her manga and books have attained considerable popularity among young women in Japan. Though she primarily writes manga of the josei genre, her most popular series, Sugar Sugar Rune, (serialized in Nakayoshi) is targeted primary at school-aged girls. In a recent Oricon poll, she was voted the number eight most popular manga artist among females and thirteen in the general category. Her manga Happy Mania was made into a television series in 1998, followed by Hataraki Man in October 2007. Sakuran was made into a movie in 2006. Moyoko is married to famous anime director Anno Hideaki.\n\n(Source: AniDB)\n\nTwitter: @anno_moyoco", new DateTime(1971, 3, 25, 16, 0, 0, 0, DateTimeKind.Local), "安野", "モヨコ", "Moyoco Anno", "https://cdn.myanimelist.net/images/voiceactors/3/42198.jpg", "https://myanimelist.net/people/2340/Moyoco_Anno", "https://annomoyoco.com" },
                    { 2348, "Twitter: @idumirei\npixiv: #2917188", null, "依澄", "れい", "Rei Idumi", "https://cdn.myanimelist.net/images/voiceactors/1/27619.jpg", "https://myanimelist.net/people/2348/Rei_Idumi", "http://www.idumirei.com/" },
                    { 2357, "Shigeno Shuuichi is a Japanese manga author famous for the anime and manga Initial D. Shigeno has also created Bari Bari Densetsu, Dopkan, and Tunnel Nuketara Sky Blue all prior to the manga that would make him famous in 1995. In 1985, he received the Kodansha Manga Award for shounen for Bari Bari Densetsu.\n\nHe owns a 1980s Toyota Sprinter Trueno with a panda white color scheme, like his manga's main character Takumi. He also owns a Steel Blue Mica-colored 1999 WRX Type STi Version 5 with a STi sports bumper (a part from the STi sport catalogue made to look like the 22B STi bumper but fits non-wide body Imprezas) just like the main character's father, Bunta. One of his notable students is Morikawa George, creator of Hajime no Ippo.\n\n(Source: Wikipedia)", new DateTime(1958, 3, 7, 16, 0, 0, 0, DateTimeKind.Local), "しげの", "秀一", "Shuuichi Shigeno", "https://cdn.myanimelist.net/images/voiceactors/1/50257.jpg", "https://myanimelist.net/people/2357/Shuuichi_Shigeno", null },
                    { 2367, "Hometown: Kanagawa, Japan", new DateTime(1965, 8, 19, 17, 0, 0, 0, DateTimeKind.Local), "金成", "陽三郎", "Youzaburou Kanari", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2367/Youzaburou_Kanari", null },
                    { 2368, "Birth name: Fumiko Satou (佐藤 文子)\nHometown: Saitama, Japan\nBlood type: O\n\nSatou Fumiya debuted in 1991. She mostly does art for manga. She is also known as a member of the religious movement Happy Science.", new DateTime(1965, 12, 21, 16, 0, 0, 0, DateTimeKind.Local), "さとう", "ふみや", "Fumiya Satou", "https://cdn.myanimelist.net/images/voiceactors/1/40125.jpg", "https://myanimelist.net/people/2368/Fumiya_Satou", "http://satofzik.exblog.jp/" },
                    { 2373, "Twitter: @sigsawa", null, "時雨沢", "恵一", "Keiichi Sigsawa", "https://cdn.myanimelist.net/images/voiceactors/2/49333.jpg", "https://myanimelist.net/people/2373/Keiichi_Sigsawa", null },
                    { 2374, "Twitter: @kuroboshi", null, "黒星", "紅白", "Kouhaku Kuroboshi", "https://cdn.myanimelist.net/images/voiceactors/2/33455.jpg", "https://myanimelist.net/people/2374/Kouhaku_Kuroboshi", "http://kuroboshi.blog34.fc2.com/" },
                    { 2377, "Real name: Hitoshi Iwaki (岩城均）\nGender: Male\nHometown: Tokyo", new DateTime(1960, 7, 27, 17, 0, 0, 0, DateTimeKind.Local), "岩明", "均", "Hitoshi Iwaaki", "https://cdn.myanimelist.net/images/voiceactors/3/49435.jpg", "https://myanimelist.net/people/2377/Hitoshi_Iwaaki", null },
                    { 2385, "Real name: Kazuhiko Katou (加藤 一彦)\nDate of death: April 11, 2019", new DateTime(1937, 5, 25, 17, 0, 0, 0, DateTimeKind.Local), "モンキー・パンチ", null, "Monkey Punch", "https://cdn.myanimelist.net/images/voiceactors/2/49827.jpg", "https://myanimelist.net/people/2385/Monkey_Punch", "http://www.monkeypunch.com/" },
                    { 2395, "Birthplace: Saitama Prefecture, Japan", new DateTime(1969, 5, 24, 17, 0, 0, 0, DateTimeKind.Local), "二ノ宮", "知子", "Tomoko Ninomiya", "https://cdn.myanimelist.net/images/voiceactors/3/7670.jpg", "https://myanimelist.net/people/2395/Tomoko_Ninomiya", "http://tomokoninomiya.cocolog-nifty.com/" },
                    { 2400, "Birth place: Japan, Chiba, Sanbu District\n\nWas assistant of Asaki Masashi and Kobayashi Jin.\n\nTwitter: @naoakinari", null, "奈央", "晃徳", "Akinari Nao", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2400/Akinari_Nao", null },
                    { 2405, "Seo Kouji is a Japanese manga creator from Shobara, Hiroshima, Japan. He has stated in an interview that he was a member of his high school's track and field team and that he loves to watch baseball both emphasized in his hit manga Suzuka.\n\nHe debuted in 1996 with the one-shot \"Half &amp; Half\" in Fresh magazine. His two hits, Suzuka and Cross Over, both mixed the genres of sports with high school romance. Suzuka focused on track and field while Cross Over used basketball. It is also interesting to note that the main love interest of the male protagonists of several of his works are extremely similar in appearance, namely in Half and Half, Cross Over, Suzuka, and Kimi No Iru Machi.\n\nSeo was an assistant to Oushima Tsukasa, and studied under Fujio Fujiko and Soda Masahito.\n\nIn 2009 Seo designed the High School Girl Kimchi for Hokubi Construction food company.\n\nTwitter: @seokouji", new DateTime(1974, 7, 25, 17, 0, 0, 0, DateTimeKind.Local), "瀬尾", "公治", "Kouji Seo", "https://cdn.myanimelist.net/images/voiceactors/2/20121.jpg", "https://myanimelist.net/people/2405/Kouji_Seo", "http://www.kyowakoku.jp/dandei/" },
                    { 2408, null, null, "せがわ", "まさき", "Masaki Segawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2408/Masaki_Segawa", "http://homepage1.nifty.com/segawa-page/" },
                    { 2410, "Birthplace: Gifu Prefecture, Japan\n\nHe was inspired from a young age by his older sister's drawing and Kazuo Umezu's comics and thus took an interest in drawing horror comics himself.\n\nTwitter: @junjiitofficial", new DateTime(1963, 7, 30, 17, 0, 0, 0, DateTimeKind.Local), "伊藤", "潤二", "Junji Itou", "https://cdn.myanimelist.net/images/voiceactors/3/81585.jpg", "https://myanimelist.net/people/2410/Junji_Itou", null },
                    { 2415, null, null, "木村", "暢", "Noboru Kimura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2415/Noboru_Kimura", null },
                    { 2464, null, new DateTime(1979, 2, 23, 16, 0, 0, 0, DateTimeKind.Local), "ゴツボ", "マサル", "Masaru Gotsubo", "https://cdn.myanimelist.net/images/voiceactors/3/74107.jpg", "https://myanimelist.net/people/2464/Masaru_Gotsubo", null },
                    { 2472, "Twitter: @torimusi", null, "戸田", "泰成", "Yasunari Toda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2472/Yasunari_Toda", null },
                    { 2478, "Died: January 28, 1998 (aged 60)\n\nShoutarou Ishinomori was an influential figure in manga, anime, and tokusatsu who created several immensely popular long-running series such as Cyborg 009, what would go on to become the Super Sentai series and the Kamen Rider Series. He was twice awarded by the Shogakukan Manga Award, in 1968 for Sabu to Ichi Torimono Hikae and in 1988 for Hotel and Manga Nihon Keizai Nyumon. He was born and named Shoutarou Onodera (小野寺 章太郎) in Tome, Miyagi, and was also known as Shoutarou Ishimori (石森 章太郎) before 1986, when he changed his family name to Ishinomori with \"ノ\".\n\nCyborg 009, created in 1963, became the first superpowered hero team created in Japan. That same year, Kazumasa Hirai and Jiro Kuwata created Japan's first cyborg superhero, 8 Man (which predated Kamen Rider by eight years). The success of the tokusatsu superhero TV series Kamen Rider, produced by Toei Company Ltd. in 1971, led to the birth of the \"Transforming\" (henshin) superhero (human-sized superheroes who transform by doing a pose, and use martial arts to fight henchmen and the weekly monster), and resulted in many sequel shows to this day. Ishinomori then created many similar superhero dramas, which were once again all produced by Toei or in Sarutobi Ecchan's case Toei Animation, including Android Kikaider , Henshin Ninja Arashi, Inazuman, Robotto Keiji, Secret Task Force Goranger (the first Super Sentai series), Kaiketsu Zubat, Akumaizer 3, Sarutobi Ecchan, the Toei Fushigi Comedy Series and countless others. He even created popular children's shows such as Hoshi no Ko Chobin (Chobin, Child of the Stars, 1974, a co-production with Studio Zero which was a major success on Italian television), and Ganbare!! Robokon.\n\nIshinomori's art is quite reminiscent of that of his mentor, Osamu Tezuka. The true story of his first meeting with Tezuka was illustrated in a short four-page tale drawn up as supplementary material for the 1970s Astro Boy manga reprints. Around 1955, Ishinomori submitted work to a contest seeking new talent in the magazine, Manga Shonen. Tezuka was impressed by his drawings and asked Ishinomori to help him with Astro Boy. In the American release, this story can be seen in Volume 15, along with Ishinomori's earliest work on the \"Electro\" story arc.\n\nIshinomori also illustrated a comic adaptation of the Super NES video game The Legend of Zelda: A Link to the Past, which was produced for the American publication Nintendo Power. The comic consisted of 12 chapters, which were serialized from January 1992 (Volume 32) to December 1992 (Volume 43). The comic was republished as a graphic novel collection in 1993.\n\nIshinomori died of heart failure on January 28, 1998, just 3 days after his 60th birthday. His final work was the tokusatsu superhero TV series, Voicelugger, televised a year later. Two years later, the Kamen Rider Series would be revived with Kamen Rider Kuuga. All of the series made in the Heisei period credit Ishinomori as the creator. The Ishinomori Manga Museum named in his honor opened in Ishinomaki, Miyagi in 2001.[2] Special trains in the Senseki Line were commissioned featuring his artwork generally leading to the museum.\n\nHis work posthumously awarded him the Guinness World Record for most comics published by one author, totaling over 128,000 pages.\n\n(Source: Wikipedia)", new DateTime(1938, 1, 24, 16, 0, 0, 0, DateTimeKind.Local), "石ノ森", "章太郎", "Shoutarou Ishinomori", "https://cdn.myanimelist.net/images/voiceactors/3/73162.jpg", "https://myanimelist.net/people/2478/Shoutarou_Ishinomori", null },
                    { 2479, "Birth Place: Ikeda, Hokkaido, Japan \nBlood Type: B\n\nGrowing up influenced by Osamu Tezuka and Shotaro Ishinomori. A big fan of Kamen Rider since he was a child, he criticized Tatsuya Egawa’s comicalize of “Kamen Rider The First” as a low quality product. Was an assistant to Mitsuru Adachi and Kaoru Shintani. Masayuki Fujihara, Tetsuo Yamashita, Naoki Mizutani, Michiaki Watanabe and Eisaku Kubonouchi were once his assistants. Classmates with Masamune Shirow, Hideaki Anno and Takami Akai at Osaka University of Arts. Kentaro Yano was his senior while Aki Katsu and Meimu were his juniors. Friends with Masami Yuuki, Kazuhiro Fujita, Bang Ippongi, Moo. Nenbei and Yumiko Igarashi.\n\n(Source: Baka-Updates)", new DateTime(1961, 4, 25, 17, 0, 0, 0, DateTimeKind.Local), "島本", "和彦", "Kazuhiko Shimamoto", "https://cdn.myanimelist.net/images/voiceactors/3/4269.jpg", "https://myanimelist.net/people/2479/Kazuhiko_Shimamoto", null },
                    { 2486, null, new DateTime(1965, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), "ヒロモト", "森一", "Shinichi Hiromoto", "https://cdn.myanimelist.net/images/voiceactors/3/4521.jpg", "https://myanimelist.net/people/2486/Shinichi_Hiromoto", "http://www.manga-force.com" },
                    { 2493, "Birth place: Osaka\nBlood type: 0\nZodiac: Aries\n\nIkumi was born on March 27 and is from the Osaka Prefecture. She often wears cat ears to her book signings, and interesting costumes. Mia's first manga story The Sleeping Beauty of Strawberry Forest was written when she was just 18 years old (manga updates).\n\nDate of Death: March 7, 2022.", new DateTime(1979, 3, 26, 16, 0, 0, 0, DateTimeKind.Local), "征海", "未亜", "Mia Ikumi", "https://cdn.myanimelist.net/images/voiceactors/1/2914.jpg", "https://myanimelist.net/people/2493/Mia_Ikumi", null },
                    { 2494, "Birth Place: Fukuoka, Japan\nHe passed away due to venous thrombosis on July 15, 2004.\nTrinity Blood Rage Against the Moons vol.6 and Reborn on the Mars vol.7 were left incomplete.", new DateTime(1969, 10, 24, 17, 0, 0, 0, DateTimeKind.Local), "吉田", "直", "Yoshida Sunao", "https://cdn.myanimelist.net/images/voiceactors/3/16967.jpg", "https://myanimelist.net/people/2494/Yoshida_Sunao", null },
                    { 2496, null, null, "九条", "キヨ", "Kiyo Kyuujou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2496/Kiyo_Kyuujou", null },
                    { 2522, "Female\nZodiac: Pisces\nBlood type: A\nBirth place: Hokkaido, Japan\nHobby: Interior Redecorating\n\nKazune Kawahara made her manga debut at age 18 with Kare no Ichiban Sukina Hito (His Most Favorite Person). Also, while thinking of her manga, she often spaces out and brings grocery baskets home. Adores her nieces. (Source: MU)", new DateTime(1972, 3, 10, 16, 0, 0, 0, DateTimeKind.Local), "河原", "和音", "Kazune Kawahara", "https://cdn.myanimelist.net/images/voiceactors/1/40085.jpg", "https://myanimelist.net/people/2522/Kazune_Kawahara", null },
                    { 2527, "Birth Date: June 15, 1966\nBirth Place: Nagaoka, Niigata Prefecture, Japan\nZodiac: Gemini\n\nMember of UROBOROS dj circle.\nHusband of the mangaka Ramiya Ryou (蘭宮涼).\nHe's primarily an hentai artist, but his laters works, Heaven's Prison and Seraphic Feather, are seinen manga with sci-fi elements.", new DateTime(1966, 6, 14, 17, 0, 0, 0, DateTimeKind.Local), "うたたね", "ひろゆき", "Hiroyuki Utatane", "https://cdn.myanimelist.net/images/voiceactors/3/2621.jpg", "https://myanimelist.net/people/2527/Hiroyuki_Utatane", null },
                    { 2545, "Birth place: Miyagi, Sendai, Japan\nBlood type: A\nGender: Female\n\n- Hobby: Napping and watching movies.\n- Debuted with 'Get Goal!!' (Appeared in 15/2002 Sho-Comi issue).\n- Got her big break with Miki &amp; Sagara series that started with 'Get Love!! ~Field no Oujisama~' which became a masterpiece.\n\nTwitter: @ikeyamada_go", null, "池山田", "剛", "Go Ikeyamada", "https://cdn.myanimelist.net/images/voiceactors/1/31973.jpg", "https://myanimelist.net/people/2545/Go_Ikeyamada", "http://ikeyamada-go.at.webry.info/" },
                    { 2564, "Akira Himekawa is the pen name of a duo of female comic book artists. The artists have worked together since 1991 and have chosen to not reveal their real names.\n\nTwitter: @akirahimekawa", null, "姫川", "明", "Akira Himekawa", "https://cdn.myanimelist.net/images/voiceactors/2/54217.jpg", "https://myanimelist.net/people/2564/Akira_Himekawa", null },
                    { 2580, "Male\nZodiac: Aquarius\nBirth place: Saitama Prefecture, Japan\n\nHis father took the characters 昭宇 for his name from the phrase \"昭和は宇宙の時代だ\", which means \"Showa is the Space Age\". His brother is a part of the duo known as Nakahara Yuu.\n\nTwitter: @softmachine1966", new DateTime(1966, 2, 6, 16, 0, 0, 0, DateTimeKind.Local), "田島", "昭宇", "Shouu Tajima", "https://cdn.myanimelist.net/images/voiceactors/3/2883.jpg", "https://myanimelist.net/people/2580/Shouu_Tajima", null },
                    { 2587, "Birth place: Osaka Prefecture, Japan\n\nTwitter: @ohtagakiyasuo", null, "太田垣", "康男", "Yasuo Ootagaki", "https://cdn.myanimelist.net/images/voiceactors/2/42301.jpg", "https://myanimelist.net/people/2587/Yasuo_Ootagaki", null },
                    { 2593, null, null, "林", "ふみの", "Fumino Hayashi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2593/Fumino_Hayashi", null },
                    { 2595, "Birth place: Tsuchiura, Japan\n\nTwitter: @takamisakiryou", new DateTime(1963, 8, 13, 17, 0, 0, 0, DateTimeKind.Local), "鷹岬", "諒", "Ryou Takamisaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2595/Ryou_Takamisaki", null },
                    { 2609, "Hometown: Higashinada, Kobe, Hyogo, Japan\nBlood type: A", new DateTime(1961, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), "士郎", "正宗", "Masamune Shirow", "https://cdn.myanimelist.net/images/voiceactors/2/24581.jpg", "https://myanimelist.net/people/2609/Masamune_Shirow", "http://www.shirowledge.com/index_enu.html" },
                    { 2611, "Real name: 山本昌幸\n\nTwitter: @himepiyo\nInstagram: @isestu0", new DateTime(1968, 1, 27, 16, 0, 0, 0, DateTimeKind.Local), "山本", "マサユキ", "Masayuki Yamamoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2611/Masayuki_Yamamoto", "https://j36.base.ec" },
                    { 2619, "Birth place: Sendai, Miyagi Prefecture, Japan\nHeight: 169.5 cm\nWeight: 61 kg\nBlood type: B\n\nHirohiko Araki left school before graduation from Miyagi University of Education.\n\nHe received the 20th Tezuka Award for his debut work. .Busou Poker under the name Toshiyuki Araki.\n\nAlso in 2009, Hirohiko Araki was one of five artists selected by the Musée du Louvre to create original works set at the famous museum. His piece Rohan at the Louvre starred JoJo's Rohan Kishibe and was shown at the exhibit titled Le Louvre invite la bande dessinée (\"The Louvre Invites Comic-Strip Art\"), which was created to show the diversity of comics, from January 19 to April 13. Rohan at the Louvre was highly praised. The following year, Rohan at the Louvre was published in France and ran in Japan's Ultra Jump. It was released in the US by NBM Publishing in February 2012.\n\nFrom September 17 to October 6, 2011, the Gucci store in Shinjuku hosted the Gucci x Hirohiko Araki x Spur \"Rohan Kishibe Goes to Gucci\" Exhibition, a collaboration between the luxury Italian clothing brand, JoJo's creator and the fashion magazine Spur. The exhibit celebrated the 90th anniversary of Gucci and featured a life-size figure of Rohan Kishibe, as well as numerous illustrations by Araki; including actual pieces of the brand's own 2011-2012 fall/winter collection and his own original fashion designs. For Spur, Araki drew Kishibe Rohan meets Gucci., a full-color one-shot featuring Rohan Kishibe that ran in its October 2011 issue. Spur once again ran a JoJo spinoff by Araki, Jolyne, Fly High with Gucci starring Jolyne Cujoh from Part 6, in their February 2013 issue.\n\nOn Dececember 5, 2013 award-winning works in the animation, manga, art, and entertainment categories at the 17th Japan Media Arts Festival were announced. In the manga category, Hirohiko Araki's “JoJolion,” the eighth part in his work JoJo's Bizarre Adventure which has picked up worldwide acclaim, won the Grand Prize\n\nOn November 30, 2016, Araki won the 45th Annual Best Dresser Awards in Tokyo in the Academic and Cultural Arts\" division. When questioned about his youthful appearance, Araki said that he washes his face every morning with Tokyo's tap water.\n\n(Source: Wikipedia)\n\nTwitter: @araki_jojo", new DateTime(1960, 6, 6, 17, 0, 0, 0, DateTimeKind.Local), "荒木", "飛呂彦", "Hirohiko Araki", "https://cdn.myanimelist.net/images/voiceactors/3/42598.jpg", "https://myanimelist.net/people/2619/Hirohiko_Araki", "http://www.araki-jojo.com/" },
                    { 2623, "Hometown: Kitakyushu, Japan\nBlood type: O\n\nHe studied technical design while still at Kyushu Sangyo University, where he began to draw manga.\n\n\nTsukasa Hojo is also Takehiko Inoue's mentor (knowed as mangaka of Slam Dunk) and longtime friend of Fist of the North Star creator Tetsuo Hara. Hojo did the character design of Reina, who was introduced in the 2006 movie Hokuto no Ken: Raō Den - Jun'ai no Shō.", new DateTime(1959, 3, 4, 16, 0, 0, 0, DateTimeKind.Local), "北条", "司", "Tsukasa Hojo", "https://cdn.myanimelist.net/images/voiceactors/3/43543.jpg", "https://myanimelist.net/people/2623/Tsukasa_Hojo", "http://www.hojo-tsukasa.com/" },
                    { 2650, "Twitter: @summereye", new DateTime(1975, 8, 22, 17, 0, 0, 0, DateTimeKind.Local), "夏目", "義徳", "Yoshinori Natsume", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2650/Yoshinori_Natsume", "http://summereye.html.xdomain.jp/" },
                    { 2660, "Birth name: 藤田和宏\nBirth place: Asahikawa, Hokkaido, Japan\nBlood type: A\n\nKazuhiro Fujita is a Japanese manga artist. He graduated from Nihon University. He made his professional manga debut in Weekly Shōnen Sunday in 1989. He is most famous for the manga Ushio &amp; Tora, for which he won Shogakukan Manga Award for shōnen in 1992 and the Seiun Award in 1997, and the long-running Karakuri Circus.\n\nTwitter: @Ufujitakazuhiro", new DateTime(1964, 5, 23, 17, 0, 0, 0, DateTimeKind.Local), "藤田", "和日郎", "Kazuhiro Fujita", "https://cdn.myanimelist.net/images/voiceactors/1/8584.jpg", "https://myanimelist.net/people/2660/Kazuhiro_Fujita", null },
                    { 2665, "Doujin circle: Aneko no Techou\n\nTwitter: @koumekeito\npixiv: #520553", null, "小梅", "けいと", "Keito Koume", "https://cdn.myanimelist.net/images/voiceactors/1/13707.jpg", "https://myanimelist.net/people/2665/Keito_Koume", "http://www7.plala.or.jp/koumekeito/" },
                    { 2666, null, null, "田畑", "由秋", "Yoshiaki Tabata", "https://cdn.myanimelist.net/images/voiceactors/3/82655.jpg", "https://myanimelist.net/people/2666/Yoshiaki_Tabata", "http://cmj.cocolog-nifty.com/blog" },
                    { 2681, "Gender: Male\nBorn in Shiga, Japan.\n\nHe drew the covers of the Japanese edition of the Twilight series and considers himself as a fan of the series.", new DateTime(1976, 12, 7, 16, 0, 0, 0, DateTimeKind.Local), "ゴツボ", "リュウジ", "Ryuuji Gotsubo", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2681/Ryuuji_Gotsubo", "http://www.52bros.co.jp/" },
                    { 2708, "Birth place: Tokyo, Japan", new DateTime(1971, 3, 14, 16, 0, 0, 0, DateTimeKind.Local), "岡田", "芽武", "Megumu Okada", "https://cdn.myanimelist.net/images/voiceactors/2/32111.jpg", "https://myanimelist.net/people/2708/Megumu_Okada", null },
                    { 2709, "Male\nBirthplace: Japan\nZodiac: Gemini\nBlood type: O\nDoujin circle: UB\n\nA guy who chooses to only play female characters in games. Since he is called Okama (cross-dresser) after all.\n\nTwitter: @okamarble", new DateTime(1974, 5, 24, 17, 0, 0, 0, DateTimeKind.Local), "okama", null, "okama", "https://cdn.myanimelist.net/images/voiceactors/1/3030.jpg", "https://myanimelist.net/people/2709/okama", "http://okama.nicomi.com/" },
                    { 2710, "Twitter: @okamotokazuhiro", new DateTime(1971, 5, 23, 17, 0, 0, 0, DateTimeKind.Local), "岡本", "一広", "Kazuhiro Okamoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2710/Kazuhiro_Okamoto", "https://akesime.exblog.jp/" },
                    { 2713, "Twitter: @Takeshi_Okano", new DateTime(1967, 5, 8, 17, 0, 0, 0, DateTimeKind.Local), "岡野", "剛", "Takeshi Okano", "https://cdn.myanimelist.net/images/voiceactors/1/59818.jpg", "https://myanimelist.net/people/2713/Takeshi_Okano", null },
                    { 2731, "Twitter: @junji_ohno", new DateTime(1973, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), "大野", "純二", "Junji Oono", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2731/Junji_Oono", null },
                    { 2752, null, null, "佐倉", "ケンイチ", "Kenichi Sakura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2752/Kenichi_Sakura", null },
                    { 2765, "Birthplace: Fukuoka, Japan.\n\nOtsuichi won the Sixth Jump Short Fiction/Nonfiction Prize when he was seventeen with his debut story Summer, Fireworks, and My Corpse. Now recognized as one of the most talented young fantasy/horror writers in Japan, his other English-language works include the short story collection Calling You, the Honkaku Mystery Award-winning novel Goth, and the collection ZOO.\n\n(Source: Haikasoru)", new DateTime(1978, 10, 20, 17, 0, 0, 0, DateTimeKind.Local), "乙一", null, "Otsuichi", "https://cdn.myanimelist.net/images/voiceactors/3/53673.jpg", "https://myanimelist.net/people/2765/Otsuichi", null },
                    { 2785, "Zodiac sign: Taurus\n\nHiroyuki is a male Japanese manga creator from Nerima, Tokyo, Japan. He is notable for the creation of the four-panel comic strip manga Doujin Work which is the first of his works to be adapted into an anime. Hiroyuki is well-known for the creation of many doujinshi based on the Type-Moon visual novels Tsukihime and Fate/stay night.\n\nHis older sister, Kouji Megumi, is also a manga artist.\n\nTwitter: @burumakun", new DateTime(1982, 4, 22, 17, 0, 0, 0, DateTimeKind.Local), "ヒロユキ", null, "Hiroyuki", "https://cdn.myanimelist.net/images/voiceactors/3/3485.jpg", "https://myanimelist.net/people/2785/Hiroyuki", "http://seijunha.com" },
                    { 2794, "Hometown: Nagoya, Aichi, Japan\nBlood type: O\n\nTwitter: @mizuto_v", null, "水都", "あくあ", "Aqua Mizuto", "https://cdn.myanimelist.net/images/voiceactors/2/20563.jpg", "https://myanimelist.net/people/2794/Aqua_Mizuto", "http://aquaizan.com/" },
                    { 2804, "Real Name: Aoyama Yoshimasa (青山 剛昌)\nBlood type: B\nBirthplace: Hokuei, Tottori Prefecture, Japan\nFavorite food: Curry Rice", new DateTime(1963, 6, 20, 17, 0, 0, 0, DateTimeKind.Local), "青山", "剛昌", "Gosho Aoyama", "https://cdn.myanimelist.net/images/voiceactors/3/13527.jpg", "https://myanimelist.net/people/2804/Gosho_Aoyama", null },
                    { 2805, "Born in Tokyo \nHis blood type is O\n\nTwitter: @hassystudio", new DateTime(1967, 6, 1, 17, 0, 0, 0, DateTimeKind.Local), "橋口", "たかし", "Takashi Hashiguchi", "https://cdn.myanimelist.net/images/voiceactors/2/2115.jpg", "https://myanimelist.net/people/2805/Takashi_Hashiguchi", null },
                    { 2844, "Doujin circles: Gebokudou (下僕堂), DIGITAL ACCEL WORKS (デジタルアクセルワークス)\n\nEarly in his career, Shouji Sato was the former assistant of mangaka Rikdo Koshi.", null, "佐藤", "ショウジ", "Shouji Satou", "https://cdn.myanimelist.net/images/voiceactors/1/30803.jpg", "https://myanimelist.net/people/2844/Shouji_Satou", "http://www.ghost-d.com/ssss/" },
                    { 2866, "Birth place: Kanagawa Prefecture, Japan\n\nTwitter: @co2age", null, "駒都", "えーじ", "E-ji Komatsu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2866/E-ji_Komatsu", "http://www.maroon.dti.ne.jp/co2a/" },
                    { 2872, "Birthplace: Nagoya, Aichi Prefecture, Japan\nZodiac sign: Taurus\nBlood type: A\nGender: Female\n\nHer manga debut was in 2001 with Magical☆Project. Her favorite beverages are coffee and tea, and she likes drawing.\n\nTwitter: @0518chitose", null, "八神", "千歳", "Chitose Yagami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2872/Chitose_Yagami", "http://chitose5.fc2web.com/" },
                    { 2891, "Chica Umino (Japanese: 羽海野 チカ, Hepburn: Umino Chika) is the pen name of an anonymous Japanese manga artist, designer and illustrator.\nUmino is noted for being the author and creator of the Honey and Clover series, for which she received the Kodansha Manga Award in 2003, and which has been adapted into an anime series, produced by J.C.Staff.\n\nHer pen name comes from her favorite location Umi no Chikaku no Youenchi (海の近くの遊園地, lit. an amusement park by the sea), which is also the title of her doujinshi works prior to her debut. She likes Harry Potter and anime by Hayao Miyazaki. She calls herself an otaku.[citation needed] Western children's books like Anne of Green Gables (for which she drew the cover artwork in a republished version in 2011) she read as a child had a notable influence on her work, especially how she chooses to portray unusual family constellations.\n\nIn 2000, Umino's most notable work, Honey and Clover, began serialization in Shueisha's manga magazine, CUTiEcomic. The series' first fourteen chapters were published in CUTiEcomic; serialization was later moved to Young YOU. With the demise of Young YOU in 2005, the series moved to the magazine Chorus, where it continued its run until the series ended in July 2006 with 64 chapters. Umino received the 27th Kodansha Manga Award for Honey and Clover in 2003, which was adapted into an anime series produced by J.C. Staff.\n\nUmino's most recent work is March Comes in Like a Lion (3月のライオン, Sangatsu no Raion) lit. \"Lion in March\" or \"March's Lion\", which began serialization in Hakusensha's seinen manga magazine, Young Animal. In 2009, she provided the character designs for original anime series, Eden of the East, by director Kenji Kamiyama.\n\nUmino has also illustrated \"Tobira wo Akete\" and the Glass Heart series, including \"Boukensha-tachi\", \"Netsu no Shiro\" and \"Love Way.\"\n\nTwitter: @CHICAUMINO", null, "羽海野", "チカ", "Chica Umino", "https://cdn.myanimelist.net/images/voiceactors/1/7433.jpg", "https://myanimelist.net/people/2891/Chica_Umino", "http://www13.plala.or.jp/umino/" },
                    { 2904, null, new DateTime(1962, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), "あさり", "よしとお", "Yoshitoo Asari", "https://cdn.myanimelist.net/images/voiceactors/3/5313.jpg", "https://myanimelist.net/people/2904/Yoshitoo_Asari", null },
                    { 2906, null, new DateTime(1975, 6, 17, 17, 0, 0, 0, DateTimeKind.Local), "江尻", "立真", "Tatsuma Eijiri", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2906/Tatsuma_Eijiri", null },
                    { 2907, "Birth place: Wakyama prefecture, Japan\n\nHe died of pancreatic cancer at 84 on September 24, 2021.", new DateTime(1936, 11, 2, 16, 0, 0, 0, DateTimeKind.Local), "斎藤", "隆夫", "Takao Saitou", "https://cdn.myanimelist.net/images/voiceactors/3/41231.jpg", "https://myanimelist.net/people/2907/Takao_Saitou", "http://www.saito-pro.co.jp/" },
                    { 2910, null, null, "黒田", "硫黄", "Iou Kuroda", "https://cdn.myanimelist.net/images/voiceactors/3/4682.jpg", "https://myanimelist.net/people/2910/Iou_Kuroda", "http://kurodaiou.blog57.fc2.com/" },
                    { 2912, "Ikeda made her debut in 1967 with \"Bara-Yashiki no Shoujo\" (The girl from the rose mansion) in Shoujo Friend when she still was a philosophy student. She was the first to pick up a historic theme in her highly acclaimed \"Versailles no Bara\" and did other impressive historical works. \n\nIt's rumored she had an affair with a politician and Ikeda disappeared from the manga-scene around the mid-80's. However she returned at the end of 1998 again with \"Orpheus no Mado Gaiden\".\n\nIn 2008 Ikeda received France's Ordre national de la Légion d'honneur.", new DateTime(1947, 12, 17, 16, 0, 0, 0, DateTimeKind.Local), "池田", "理代子", "Riyoko Ikeda", "https://cdn.myanimelist.net/images/voiceactors/3/50109.jpg", "https://myanimelist.net/people/2912/Riyoko_Ikeda", "http://www.ikeda-riyoko-pro.com/" },
                    { 2917, "Twitter: @jirosuzuki", null, "鈴木", "次郎", "Jirou Suzuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2917/Jirou_Suzuki", "http://ameblo.jp/jirosuzuki/" },
                    { 2921, "Twitter: @marimotomimori", null, "みもり", null, "Mimori", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2921/Mimori", "http://tukumokami.web.fc2.com/" },
                    { 2933, "Birth place: Chiba Prefecture, Japan\nGender: male", new DateTime(1968, 12, 11, 16, 0, 0, 0, DateTimeKind.Local), "上遠野", "浩平", "Kouhei Kadono", "https://cdn.myanimelist.net/images/voiceactors/3/69957.jpg", "https://myanimelist.net/people/2933/Kouhei_Kadono", null },
                    { 2936, null, new DateTime(1964, 8, 16, 17, 0, 0, 0, DateTimeKind.Local), "神崎", "将臣", "Masaomi Kanzaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2936/Masaomi_Kanzaki", null },
                    { 2940, "Twitter: @ogata_kouji\nOld HP: http://www.page.sannet.ne.jp/bonoto/", new DateTime(1970, 12, 23, 16, 0, 0, 0, DateTimeKind.Local), "緒方", "剛志", "Kouji Ogata", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2940/Kouji_Ogata", "http://ogatakouji.minibird.jp/Public/" },
                    { 2941, null, new DateTime(1954, 12, 23, 16, 0, 0, 0, DateTimeKind.Local), "伊藤", "和典", "Kazunori Ito", "https://cdn.myanimelist.net/images/voiceactors/1/50517.jpg", "https://myanimelist.net/people/2941/Kazunori_Ito", "https://twitter.com/Ito_Kazunori" },
                    { 2948, "Ryohgo Narita is a Japanese light novelist. He won the Gold Prize in the 9th Dengeki Novel Prize for Baccano!, which was made into a TV anime in 2007.\n\nHe studied satellite image analysis from the Computer Science department for university in Narita.\n\nTwitter: @ryohgo_narita", new DateTime(1980, 5, 29, 17, 0, 0, 0, DateTimeKind.Local), "成田", "良悟", "Ryohgo Narita", "https://cdn.myanimelist.net/images/voiceactors/2/73711.jpg", "https://myanimelist.net/people/2948/Ryohgo_Narita", "http://www2.tba.t-com.ne.jp/taoru/resistance/" },
                    { 2949, "Male\nBlood type: B\nHometown: Aki-ku, Hiroshima City, Hiroshima Prefecture\nCurrent address: Chiyoda-ku, Tokyo\n\nWorked for Games Gurafikka company until 2003. Since 2004 working as a freelance illustrator.\n\nTwitter: @enonami\npixiv: #15820", new DateTime(1972, 1, 4, 16, 0, 0, 0, DateTimeKind.Local), "エナミ", "カツミ", "Katsumi Enami", "https://cdn.myanimelist.net/images/voiceactors/1/8676.jpg", "https://myanimelist.net/people/2949/Katsumi_Enami", "http://www.k4.dion.ne.jp/~enami/index.html" },
                    { 2950, null, null, "吟遊", "詩人", "Shijin Ginyuu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2950/Shijin_Ginyuu", null },
                    { 2954, "Pennames:\nSagawa Ryuu (瑳川竜)\nSano Rokurou (佐野ロクロウ)", new DateTime(1964, 10, 2, 17, 0, 0, 0, DateTimeKind.Local), "三条", "陸", "Riku Sanjou", "https://cdn.myanimelist.net/images/voiceactors/2/41870.jpg", "https://myanimelist.net/people/2954/Riku_Sanjou", null },
                    { 2955, null, new DateTime(1964, 3, 13, 16, 0, 0, 0, DateTimeKind.Local), "稲田", "浩司", "Koji Inada", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2955/Koji_Inada", null },
                    { 2979, "Male\n\nTwitter: @k2batto\npixiv: #5017800", null, "綱島", "志朗", "Shirou Tsunashima", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2979/Shirou_Tsunashima", "https://www.k2batto.com/" },
                    { 2985, null, null, "竹村", "雪秀", "Sessyu Takemura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/2985/Sessyu_Takemura", null },
                    { 2992, "Blood type: O\nBirth place: Wajima, Ishikawa Prefecture, Japan\n\nGo Nagai is a Japanese manga artist and a prolific author of science fiction, fantasy, horror, and erotica. He made his professional debut in 1967 with Meakashi Polikichi, but is best known for creating Cutie Honey, Devilman, and Mazinger Z.\n\nHe also pioneered the ecchi genre with Harenchi Gakuen. He is credited with creating the Super Robot genre and for designing the first mecha robots piloted by a user from within a cockpit with Mazinger Z.\n\nIn 2005, he became a Character Design professor at the Osaka University of Arts. Since 2009, he is a member of Tezuka Osamu Cultural Prize's nominating committee.\n\n(Source: Wikipedia)", new DateTime(1945, 9, 5, 17, 0, 0, 0, DateTimeKind.Local), "永井", "豪", "Go Nagai", "https://cdn.myanimelist.net/images/voiceactors/2/42171.jpg", "https://myanimelist.net/people/2992/Go_Nagai", "http://www.dynamicproduction.co.jp/" },
                    { 2994, "He used to be an assistant for Gintama.", new DateTime(1974, 1, 8, 16, 0, 0, 0, DateTimeKind.Local), "篠原", "健太", "Kenta Shinohara", "https://cdn.myanimelist.net/images/voiceactors/2/58922.jpg", "https://myanimelist.net/people/2994/Kenta_Shinohara", null },
                    { 3000, "Kaishaku consists of artists Hitoshi Ota and Terumasa Shichinohe. The name comes from Kaishakunin (介錯人), an appointed second person whose duty is to decapitate one who commits seppuku (ritual suicide by disembowelment).", null, null, "介錯", "Kaishaku", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3000/Kaishaku", "http://www.toshima.ne.jp/~kaishaku/" },
                    { 3003, "Birth place: Kumamoto Prefecture, Japan.", null, "後池田", "真也", "Shinya Goikeda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3003/Shinya_Goikeda", null },
                    { 3014, "Birthplace: Toyohashi, Aichi, Japan\nZodiac: Pisces\nBlood Type: B\nHeight: 1'79\n\nSawai admitted to be very bad singing karaoke. Yuusei Matsui was his assistant.", new DateTime(1977, 3, 13, 16, 0, 0, 0, DateTimeKind.Local), "澤井", "啓夫", "Yoshio Sawai", "https://cdn.myanimelist.net/images/voiceactors/1/62830.jpg", "https://myanimelist.net/people/3014/Yoshio_Sawai", null },
                    { 3020, "Birth place: Daisen, Akita Prefecture\nDate of death: April 17, 2019\n\nA prolific Japanese manga writer, novelist, and entrepreneur. Early in Koike's career, he studied under Golgo 13's creator Takao Saito and served as a writer on the series. Koike, along with artist Goseki Kojima, made the manga Kozure Okami (Lone Wolf and Cub), and Koike also contributed to the scripts for the 1970s film adaptations of the series, which starred famous Japanese actor Tomisaburo Wakayama. Koike and Kojima became known as the \"Golden Duo\" because of the success of Kozure Okami. Another series written by Koike, Crying Freeman, which was illustrated by Ryoichi Ikegami, was adapted into a 1995 live-action film by French director Christophe Gans. Kazuo Koike started the Gekika Sonjuku, a college course meant to teach people how to be mangaka. In addition to his more violent, action-oriented manga, Koike, an avid golfer, has also written golf manga.\n\n(Source: Wikipedia)\n\nTwitter: @koikekazuo\nFacebook: @kazuo.koike.9674", new DateTime(1936, 5, 7, 17, 0, 0, 0, DateTimeKind.Local), "小池", "一夫", "Kazuo Koike", "https://cdn.myanimelist.net/images/voiceactors/1/41460.jpg", "https://myanimelist.net/people/3020/Kazuo_Koike", "http://lineblog.me/koikekazuo/" },
                    { 3034, "Birth place: Nagoya\nBlood type: A\n\nEgawa has a degree in applied mathematics, obtained at the university of Aichi. He has also taught mathematics in a college for five months.", new DateTime(1961, 3, 7, 16, 0, 0, 0, DateTimeKind.Local), "江川", "達也", "Tatsuya Egawa", "https://cdn.myanimelist.net/images/voiceactors/3/54433.jpg", "https://myanimelist.net/people/3034/Tatsuya_Egawa", "http://homepage3.nifty.com/egawa-tatuya/" },
                    { 3046, "Twitter: @taro_chiaki", null, "千明", "太郎", "Tarou Chiaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3046/Tarou_Chiaki", "http://prelude.moo.jp/" },
                    { 3050, "Blood type: O\nHometown: Osaka\nCurrent residence: Kyoto", null, "皇", "なつき", "Natsuki Sumeragi", "https://cdn.myanimelist.net/images/voiceactors/3/5955.jpg", "https://myanimelist.net/people/3050/Natsuki_Sumeragi", "http://www.roy.hi-ho.ne.jp/nasuga/" },
                    { 3071, null, null, "隅沢", "克之", "Katsuyuki Sumisawa", "https://cdn.myanimelist.net/images/voiceactors/1/71847.jpg", "https://myanimelist.net/people/3071/Katsuyuki_Sumisawa", null },
                    { 3072, "Doujin circle: Studio J (スタジオJ)\nBlood type: A\nLocation: Osaka Prefecture\nLikes: Traveling, Watching Videos\nHates: Strong, Bitter Things", null, "かんべ", "あきら", "Akira Kanbe", "https://cdn.myanimelist.net/images/voiceactors/1/2281.jpg", "https://myanimelist.net/people/3072/Akira_Kanbe", "http://stj.sub.jp/index.htm" },
                    { 3073, null, null, "あさぎ", "桜", "Sakura Asagi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3073/Sakura_Asagi", null },
                    { 3074, null, new DateTime(1968, 3, 5, 16, 0, 0, 0, DateTimeKind.Local), "面出", "明美", "Akemi Omode", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3074/Akemi_Omode", null },
                    { 3081, "Twitter: @mjk_tw", null, "マジコ！", null, "Majiko!", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3081/Majiko", "http://0909.gonna.jp/" },
                    { 3084, "Male", null, "衣谷", "遊", "Yuu Kinutani", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3084/Yuu_Kinutani", null },
                    { 3098, "Twitter: @nightow\n\nYasuhiro Nightow is a Japanese manga artist. His major work Trigun was adapted into an anime series and film. He also designed the characters for the video game and anime series Gungrave, and has been working on the manga Blood Blockade Battlefront (Kekkai Sensen) since 2009.\n\nHe studied social science and then majored in media studies at Housei University. While there, he drew manga as a hobby, and made some dojinshi. After graduation, he worked Sekisui House where he sold apartments. After three and a half years, he quit his job to draw full-time. His first one-shot manga was based on the popular video game franchise Samurai Spirits. He had also developed a story titled Call XXXX which was published in Super Jump magazine.", new DateTime(1967, 4, 7, 17, 0, 0, 0, DateTimeKind.Local), "内藤", "泰弘", "Yasuhiro Nightow", "https://cdn.myanimelist.net/images/voiceactors/3/16725.jpg", "https://myanimelist.net/people/3098/Yasuhiro_Nightow", null },
                    { 3118, "Blood type: B\nBirth place: Fukuoka Prefecture, Japan\nDied: March 31, 2015 (aged 31)\n\nHer debut was a work titled Calling, which she made when she was only fifteen. She choose not to go to high school so that she could draw manga. Fujiwara was a large fan of RPGs such as Final Fantasy, which showed in her works.\n\nTwitter: @cocoafujiwara", new DateTime(1983, 4, 27, 17, 0, 0, 0, DateTimeKind.Local), "藤原", "ここあ", "Cocoa Fujiwara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3118/Cocoa_Fujiwara", "http://ameblo.jp/cocoafujiwara/" },
                    { 3132, "Twitter: @naganomamoru", new DateTime(1960, 1, 20, 16, 0, 0, 0, DateTimeKind.Local), "永野", "護", "Mamoru Nagano", "https://cdn.myanimelist.net/images/voiceactors/3/73149.jpg", "https://myanimelist.net/people/3132/Mamoru_Nagano", null },
                    { 3152, "Birthplace: Saitama, Japan\n\nHe was an assistant of Yoshio Sawai, the mangaka of Bobobo-bo Bo-bobo (Shirota Masakage made a cameo appearance in Shinsetsu Bobobo-bo Bo-bobo).\n\nHis favourite manga series include Bobobo-bo Bo-bobo, JoJo no Kimyou na Bouken, and Kinnikuman.", new DateTime(1981, 1, 30, 16, 0, 0, 0, DateTimeKind.Local), "松井", "優征", "Yuusei Matsui", "https://cdn.myanimelist.net/images/voiceactors/3/28093.jpg", "https://myanimelist.net/people/3152/Yuusei_Matsui", null },
                    { 3158, "Yoshiyuki Sadamoto is a Japanese character designer, mangaka, and one of the founding members of the Gainax anime studio.\n\nHe is also the character designer for the .hack// games and the package designer for the .hack//GU games.\n\nTwitter: @y_sadamoto", new DateTime(1962, 1, 28, 16, 0, 0, 0, DateTimeKind.Local), "貞本", "義行", "Yoshiyuki Sadamoto", "https://cdn.myanimelist.net/images/voiceactors/2/73913.jpg", "https://myanimelist.net/people/3158/Yoshiyuki_Sadamoto", null },
                    { 3161, "Birth place: Sawara (now Katori), Chiba, Japan", new DateTime(1961, 4, 24, 17, 0, 0, 0, DateTimeKind.Local), "長谷川", "裕一", "Yuuichi Hasegawa", "https://cdn.myanimelist.net/images/voiceactors/1/74317.jpg", "https://myanimelist.net/people/3161/Yuuichi_Hasegawa", "http://studio-himitsukichi.cocolog-nifty.com/" },
                    { 3179, "Birth place: Kagoshima, Japan\nZodiac: Sagittarius\n\nTwitter: @chizuna_n", null, "中嶋", "ちずな", "Chizuna Nakajima", "https://cdn.myanimelist.net/images/voiceactors/2/10009.jpg", "https://myanimelist.net/people/3179/Chizuna_Nakajima", "http://guranitto.zombie.jp/index.html" },
                    { 3184, "Twitter: @uedas10", null, "上田", "信舟", "Shinshu Ueda", "https://cdn.myanimelist.net/images/voiceactors/1/43809.jpg", "https://myanimelist.net/people/3184/Shinshu_Ueda", "http://ueda-s.main.jp/uso/" },
                    { 3212, null, null, null, null, "Hiroshi Yasuda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3212/Hiroshi_Yasuda", null },
                    { 3213, "Birth place: Tochigi, Japan\nBlood type: A\n\nWas the assistant of Hidenori Hara.\nTsubasa Fukuchi (only 2 days) was an assistant.\n\nTwitter: @shinobu_inokuma", null, "猪熊", "しのぶ", "Shinobu Inokuma", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3213/Shinobu_Inokuma", "http://saladplanning.pro.tok2.com/" },
                    { 3249, "Birth place: Mie, Japan\nDoujin circle: AWA Studio (アドバンテージウェットアフロスタジオ)\n\nYasuda began drawing when he was 19 years old, after being inspired by Range Murata's pictures. As an illustrator he usually works with novels, providing the cover art and illustrations. He also makes logo designs for companies and games.\n\nHe also worked on Range Murata's Robot, where he did the chapters: Ebony &amp; Ivory (Volumes 1 and 2) and Minus R (Volume 4); despite having different names they are part of the same storyline.\n\nTwitter: @suzupin\nTumblr: suzupin\npixiv: #12535", null, "ヤスダ", "スズヒト", "Suzuhito Yasuda", "https://cdn.myanimelist.net/images/voiceactors/1/34641.jpg", "https://myanimelist.net/people/3249/Suzuhito_Yasuda", "http://www.suzuhito.com/" },
                    { 3251, null, new DateTime(1977, 2, 7, 16, 0, 0, 0, DateTimeKind.Local), "鈴木", "央", "Nakaba Suzuki", "https://cdn.myanimelist.net/images/voiceactors/3/39163.jpg", "https://myanimelist.net/people/3251/Nakaba_Suzuki", "http://blog.livedoor.jp/suzukinakaba/" },
                    { 3263, null, null, "あらき", "かなお", "Kanao Araki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3263/Kanao_Araki", "http://www.arakim.com/kana/" },
                    { 3267, "Birth place: Haboro, Tomamae District, Japan\nBlood type: AB", new DateTime(1975, 10, 22, 17, 0, 0, 0, DateTimeKind.Local), "椎名", "軽穂", "Karuho Shiina", "https://cdn.myanimelist.net/images/voiceactors/3/8949.jpg", "https://myanimelist.net/people/3267/Karuho_Shiina", null },
                    { 3328, "Twitter: @k_z_ki", new DateTime(1959, 8, 18, 17, 0, 0, 0, DateTimeKind.Local), "中島", "かずき", "Kazuki Nakashima", "https://cdn.myanimelist.net/images/voiceactors/1/54278.jpg", "https://myanimelist.net/people/3328/Kazuki_Nakashima", null },
                    { 3344, "Twitter: @DEGITA_ROUGE", new DateTime(1970, 3, 20, 16, 0, 0, 0, DateTimeKind.Local), "木村", "明広", "Akihiro Kimura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3344/Akihiro_Kimura", "http://www.vermillionmode.x0.com/" },
                    { 3494, null, new DateTime(1974, 5, 24, 17, 0, 0, 0, DateTimeKind.Local), "うすた", "京介", "Kyousuke Usuta", "https://cdn.myanimelist.net/images/voiceactors/2/10017.jpg", "https://myanimelist.net/people/3494/Kyousuke_Usuta", "http://homepage2.nifty.com/usuta/" },
                    { 3506, null, null, null, null, "Yutaka Akatsu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3506/Yutaka_Akatsu", null },
                    { 3507, null, null, null, null, "Chitose Ooshima", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3507/Chitose_Ooshima", null },
                    { 3537, "Birth Place: Korea\nCurrent residence: Tokyo, Japan\n\nBiography:\nIntended to be a manga artist from his childhood days, majored in physics in college as preparation to draw science fiction works, and also in order to learn the technology of performance imaging, he went on to graduate school to major image technology.\n\nDebuted in 1993, while still enrolled, in a manga magazine with shoujo manga.\n\nIn 2004, he has stepped into the world of Japanese manga. His \"Ultimate Space Emperor Caesar\", serialized monthly in \"Comic Gum\", was his first tankoboun in Japan. Currently he is serializing \"Sun-Ken Rock\" in \"Young King\". \nIn 2006, he released two complete science fiction works; \"Hotel\" and \"Present\" in the magazine \"Morning\", and plans to begin his first weekly serial from 2008.\n\nHis hobbies are cameras and cuisine.", new DateTime(1973, 1, 28, 16, 0, 0, 0, DateTimeKind.Local), "武直", "朴", "Boichi", "https://cdn.myanimelist.net/images/voiceactors/2/38055.jpg", "https://myanimelist.net/people/3537/Boichi", "https://boichi.com/" },
                    { 3543, "Birth place: Ibaraki prefecture\nBlood type: B\n\nEndou was previously an assistant to Tatsuki Fujimoto.\n\nTwitter: @_tatsuyaendo_", new DateTime(1980, 7, 22, 17, 0, 0, 0, DateTimeKind.Local), "遠藤", "達哉", "Tatsuya Endou", "https://cdn.myanimelist.net/images/voiceactors/1/58944.jpg", "https://myanimelist.net/people/3543/Tatsuya_Endou", null },
                    { 3565, "Twitter: @kabotya4\npixiv: #8203", null, "かぼちゃ", null, "Kabocha", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3565/Kabocha", "http://kabotya4.client.jp/" },
                    { 3571, "Twitter: @toh_azuma\npixiv: #8720713", null, "サイキ", "ケイタ", "Keita Saiki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3571/Keita_Saiki", null },
                    { 3633, "Pixiv: #333829", null, "渡", "真仁", "Masahito Watari", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3633/Masahito_Watari", null },
                    { 3640, "Gender: Male\nZodiac: Cancer\nBirth place: Osaka, Japan", new DateTime(1963, 7, 14, 17, 0, 0, 0, DateTimeKind.Local), "たけざき", "トニー", "Tony Takezaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3640/Tony_Takezaki", null },
                    { 3653, "Twitter: @_yuka_f\nInstagram: @yuka.f_330", null, "藤原", "ゆか", "Yuka Fujiwara", "https://cdn.myanimelist.net/images/voiceactors/2/22341.jpg", "https://myanimelist.net/people/3653/Yuka_Fujiwara", null },
                    { 3659, "Twitter: @shuka_matta", null, "松田", "朱夏", "Shuka Matsuda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3659/Shuka_Matsuda", "http://miaows-world.cocolog-nifty.com/umegaean/" },
                    { 3668, "Birth place: Setagaya, Tokyo, Japan\nCurrent residence: Yamato, Kanagawa Prefecture, Japan\n\nTakekuma Kentarou is a professor at the Kyoto Seika University, department of manga. He is also a part-time lecturer at the Tama Art University.\n\nTwitter: @kentaro666\nFacebook: @kentaro.takekuma\nOld blog: http://takekuma.cocolog-nifty.com/blog/index.html", new DateTime(1960, 8, 28, 17, 0, 0, 0, DateTimeKind.Local), "竹熊", "健太郎", "Kentarou Takekuma", "https://cdn.myanimelist.net/images/voiceactors/2/44140.jpg", "https://myanimelist.net/people/3668/Kentarou_Takekuma", "http://takekuma.jp/" },
                    { 3683, "Twitter: @o_takahashi", null, "高橋", "脩", "Osamu Takahashi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3683/Osamu_Takahashi", null },
                    { 3687, "est em is also sometimes referred to as Esuto Emu.\n\nZodiac: Aries\nBlood Type: A\n\nReal Name: Maki Satoh\n\nHer nom du plume has also been spelled as Est Em by Deux Press and her real name is Maki Satoh. The author's preferred romanization of her penname is not capitalized (est em) and is derived from 'esu to emu' (S and M).\n\nShe debuted with three yaoi collections after being scouted in art school. She was a student of Rachel Thorn, who provided translations for some of the English licenses of her work. Her work has been praised as having unusual maturity and depth, both for yaoi and for manga in general. \n\nHer works tend to have a strong common theme connecting the stories in each of her collections. Seduce Me After the Show centers on the artistic worlds of dance, art and music, while Red Blinds the Foolish contains five short stories that are either set in Spain or have Spanish characters.\n\nAnother common trait is that her stories tend to depict sets of strong dichotomies between contrasting themes, ideals, cultures, artistic styles, and personalities that are all embedded in the intense and passionate relationships between her characters and in her artwork, which is distinctive as it makes use of simple lines and negative space.\n\nDoujinshi Circle: Zangyou Teate (残業手当)\n\n(Source: MU, Wikipedia)\n\nTwitter: @estem_info", null, "えすと", "えむ", "est em", "https://cdn.myanimelist.net/images/voiceactors/2/28491.jpg", "https://myanimelist.net/people/3687/est_em", "http://est-em.blogspot.com/" },
                    { 3691, "Birth place: Ishinomaki, Miyagi, Japan\nBlood type: A\nGender: female\n\nTwitter: @teshi_kuro413", new DateTime(1978, 4, 12, 17, 0, 0, 0, DateTimeKind.Local), "手代木", "史織", "Shiori Teshirogi", "https://cdn.myanimelist.net/images/voiceactors/2/11485.jpg", "https://myanimelist.net/people/3691/Shiori_Teshirogi", "https://da-daism.tumblr.com" },
                    { 3695, "Gender: Female\nZodiac: Sagittarius \nBirth Place: Fukuoka Prefecture, Japan \nBlood Type: B\n\nTwitter: @hiyokosweet", null, "鈴木", "ジュリエッタ", "Julietta Suzuki", "https://cdn.myanimelist.net/images/voiceactors/3/69498.jpg", "https://myanimelist.net/people/3695/Julietta_Suzuki", "http://suzuju.jugem.jp/" },
                    { 3703, "Blood type: A\n\nTwitter: @YoshikawaMiki\n\nMiki Yoshikawa made her pro manga debut in 2003 with Glory Days, a one-shot in Kodansha’s Magazine Special. After a stint as an assistant for Hiro Mashima (Fairy Tail), she published another one-shot, Yankee-kun to Megane-chan, in Shonen Magazine Wonder in 2005. Yoshikawa’s best known work, Yamada-kun and the Seven Witches, started serialization in 2012 and has since sold more than 3 million copies.\n\n(Source: Anime Expo 2015)\n\nIn 2015, Yoshikawa attended Anime Expo as a guest. \n\nAt Anime Expo 2015, Yoshikawa said that she was inspired by the Dragon Ball manga, and would try to copy some of Toriyama's panels and manuscripts. She credits Hiro Mashima for \"teaching her everything I know\" while she was assisting on Fairy Tail.", new DateTime(1982, 10, 1, 17, 0, 0, 0, DateTimeKind.Local), "吉河", "美希", "Miki Yoshikawa", "https://cdn.myanimelist.net/images/voiceactors/3/22107.jpg", "https://myanimelist.net/people/3703/Miki_Yoshikawa", null },
                    { 3710, null, new DateTime(1961, 7, 23, 17, 0, 0, 0, DateTimeKind.Local), "今川", "泰宏", "Yasuhiro Imagawa", "https://cdn.myanimelist.net/images/voiceactors/3/49364.jpg", "https://myanimelist.net/people/3710/Yasuhiro_Imagawa", null },
                    { 3724, "Doujin circle: 8th Gods\nBlood type: O\nHometown: Hiroshima, Hiroshima Prefecture, Japan\nCurrent residence: Tokorozawa, Saitama Prefecture, Japan\n\nTwitter: @yagamike\nBlog: http://8thgods.cocolog-nifty.com/", new DateTime(1966, 5, 30, 17, 0, 0, 0, DateTimeKind.Local), "八神", "健", "Ken Yagami", "https://cdn.myanimelist.net/images/voiceactors/1/45926.jpg", "https://myanimelist.net/people/3724/Ken_Yagami", "http://8th-gods.la.coocan.jp/" },
                    { 3738, null, new DateTime(1970, 9, 4, 17, 0, 0, 0, DateTimeKind.Local), "丸川", "トモヒロ", "Tomohiro Marukawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3738/Tomohiro_Marukawa", null },
                    { 3753, "Twitter: @aimoto1222\n\nWas an assistant of Amano Akira", new DateTime(1987, 12, 21, 16, 0, 0, 0, DateTimeKind.Local), "藍本", "松", "Shou Aimoto", "https://cdn.myanimelist.net/images/voiceactors/1/71683.jpg", "https://myanimelist.net/people/3753/Shou_Aimoto", null },
                    { 3768, "Female\nBirth place: Warabi, Saitama Prefecture, Japan\nCurrent residence: Yokohama, Japan \nBlood type: O \n\n\nShe writes BL manga and yaoi doujinshi under the pen-name Rock Yanao. Yana is her real first name, but Toboso is not her real surname. In reality, \"Yana\" and \"Toboso\" are both different ways to pronounce \"kururu\" (枢), which means \"to pivot/turn.\"\n\nToboso often likes to bring up her dislike for being mistakenly called \"Yana Hitsugi\" by her fans, as the kanji for Hitsugi means \"coffin\" (柩) but looks similar in appearance for the kanji for \"toboso.\"\n\nHer assistants include Satorigi Akiyo, Hazuki Wakana and her editor is Kuma Takeshi, a former mangaka. She is friends with manga artist, Fujiwara Cocoa.\n\nYana Toboso draws herself as a devil with a black body and horns, a round white head, and a pointed tail. She has never showed a real picture of herself, so her actual appearance is unknown.\n\nBefore Volume 4, Toboso's devil had hair. Though, she later states that she had a bald spot the size of a ¥10 coin.\n\nBlog: http://yanatoboso.tuna.be/\nTwitter: @toboso_official", new DateTime(1984, 1, 23, 16, 0, 0, 0, DateTimeKind.Local), "枢", "やな", "Yana Toboso", "https://cdn.myanimelist.net/images/voiceactors/1/7161.jpg", "https://myanimelist.net/people/3768/Yana_Toboso", "http://www.yanatoboso.com" },
                    { 3776, "Real name is unknown.\n\nShiina Takashi is a Japanese manga artist who writes primarily for the weekly Shogakukan manga publication Weekly Shounen Sunday. When he started at the company in 1989, he began with an anthology of various shorts and one-shots collectively known as Shiina Department Store. Eventually one of these one-shots, about a beautiful, money grubbing female exorcist and her lecherous companion, would become the basis of his most well know work: Ghost Sweeper Mikami: Gokuraku Daisakusen!! (more well known by its shorter name: Ghost Sweeper Mikami, or GS Mikami) Running from 1991 through 1999, it became well known and popular work in Sunday, even leading to an anime of the series from 1993 through 1994 by Toei Animation as well as a Shogakukan Manga Award for shounen in 1993. Even as he had success with Mikami, Shiina continued to create various one-shot stories on the side of his main series.\n\nAfter the end of GS Mikami, Shiina tried to create new series for the manga anthology, such as Ichiban-yu no Kanata and Mister Japan. He also created new series and shorts on the side, including GS Holmes: Gokuraku Daisakusen!! (an alternate take on Sherlock Holmes co-starring the robotic Maria from GS Mikami) In 2003, Shiina introduced another of his many ideas in Shounen Sunday in short form: Zettai Karen Children, about three young girls with great psychic powers and terrifying ambitions. Finding some success with it in short form, the mangaka introduced it as a weekly series in 2005, where it continues to run at this time.\n\nBlog: http://cnanews.asablo.jp/blog/\n\nPictured with voice actress Ootake Miyu.\n\n(Source: AniDB)\n\nTwitter: @Takashi_Shiina", new DateTime(1965, 6, 23, 17, 0, 0, 0, DateTimeKind.Local), "椎名", "高志", "Takashi Shiina", "https://cdn.myanimelist.net/images/voiceactors/2/26051.jpg", "https://myanimelist.net/people/3776/Takashi_Shiina", "http://www.ne.jp/asahi/cna100/store/" },
                    { 3878, "Twitter: @misyouko\npixiv: #1845573", null, "石見", "翔子", "Shouko Iwami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3878/Shouko_Iwami", "http://www013.upp.so-net.ne.jp/anzendaiichi/" },
                    { 3884, "Blood type: A\nBirth place: Hokkaido, Japan", null, "飯坂", "友佳子", "Yukako Iisaka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3884/Yukako_Iisaka", null },
                    { 3907, null, null, "児玉", "樹", "Miki Kodama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3907/Miki_Kodama", null },
                    { 3927, null, new DateTime(1960, 7, 27, 17, 0, 0, 0, DateTimeKind.Local), "高橋", "陽一", "Yoichi Takahashi", "https://cdn.myanimelist.net/images/voiceactors/1/40316.jpg", "https://myanimelist.net/people/3927/Yoichi_Takahashi", null },
                    { 3929, null, null, "まだら", "さい", "Sai Madara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3929/Sai_Madara", "http://www.madara.jp/" },
                    { 3930, "Twitter: @yamamurahajimeA", new DateTime(1968, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "やまむら", "はじめ", "Hajime Yamamura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3930/Hajime_Yamamura", null },
                    { 3931, null, null, "いわさき", "まさかず", "Masakazu Iwasaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3931/Masakazu_Iwasaki", null },
                    { 3932, "Lives in Machida-shi, Tōkyō-to.\nGraduated from the College of Laws at Nihon University.", new DateTime(1983, 1, 1, 16, 0, 0, 0, DateTimeKind.Local), "松林", "悟", "Satoru Matsubayashi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3932/Satoru_Matsubayashi", "http://www7a.biglobe.ne.jp/~yaneuratv/" },
                    { 3943, null, null, "曽我", "篤士", "Atsushi Soga", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/3943/Atsushi_Soga", null },
                    { 4017, "Died: January 21, 1987\nReal name: Asaki Takamori\nBirth place: Kitakyushu, Japan", new DateTime(1936, 9, 3, 17, 0, 0, 0, DateTimeKind.Local), "梶原", "一騎", "Ikki Kajiwara", "https://cdn.myanimelist.net/images/voiceactors/1/64289.jpg", "https://myanimelist.net/people/4017/Ikki_Kajiwara", null },
                    { 4027, "Birth place: Kawasaki, Kanagawa Prefecture, Japan\n\nOoi Masakazu is married to Ootsuki Yuuko. His father-in-law is Yoshizawa Yasumi. All three of them are manga artists.\n\nTwitter: @ooimasakazu", new DateTime(1975, 3, 3, 16, 0, 0, 0, DateTimeKind.Local), "大井", "昌和", "Masakazu Ooi", "https://cdn.myanimelist.net/images/voiceactors/2/45857.jpg", "https://myanimelist.net/people/4027/Masakazu_Ooi", "http://d.hatena.ne.jp/ooimasakazu/" },
                    { 4098, "Twitter: @hideki6809", new DateTime(1969, 9, 15, 17, 0, 0, 0, DateTimeKind.Local), "大和田", "秀樹", "Hideki Oowada", "https://cdn.myanimelist.net/images/voiceactors/1/5616.jpg", "https://myanimelist.net/people/4098/Hideki_Oowada", "http://www.kugibat.com/index1.html" },
                    { 4110, "Male\nReal name: 唐沢直樹\nBlood type: B\nBirth place: Sapporo, Hokkaido, Japan\nCurrent residence: Nakano, Tokyo, Japan\n\nHe is married to Karasawa Yoshiko, a freelance writer.\n\nTwitter: @nawokikarasawa", new DateTime(1961, 10, 20, 17, 0, 0, 0, DateTimeKind.Local), "唐沢", "なをき", "Nawoki Karasawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4110/Nawoki_Karasawa", "http://www.nawosan.com/" },
                    { 4113, null, null, "井上", "真", "Makoto Inoue", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4113/Makoto_Inoue", null },
                    { 4142, "Born in Tokyo\nBlood type: B\n\nTwitter: @sakisaka10\nInstagram: @sakisaka10", new DateTime(1975, 6, 7, 17, 0, 0, 0, DateTimeKind.Local), "咲坂", "伊緒", "Io Sakisaka", "https://cdn.myanimelist.net/images/voiceactors/1/33421.jpg", "https://myanimelist.net/people/4142/Io_Sakisaka", null },
                    { 4169, "Twitter: @fukamimakoto", new DateTime(1977, 8, 4, 17, 0, 0, 0, DateTimeKind.Local), "深見", "真", "Makoto Fukami", "https://cdn.myanimelist.net/images/voiceactors/3/49100.jpg", "https://myanimelist.net/people/4169/Makoto_Fukami", "http://fmkkoe.blog27.fc2.com/" },
                    { 4197, "Twitter: @ume_boc\npixiv: #41560", null, "南高", "春告", "Harutsugu Nadaka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4197/Harutsugu_Nadaka", "http://lazylazy974.blog116.fc2.com/" },
                    { 4224, "Twitter: @twitydk", null, "納都", "花丸", "Hanamaru Nanto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4224/Hanamaru_Nanto", "http://tydk.sakura.ne.jp/" },
                    { 4237, "Hometown: Dazaifu, Fukuoka, Japan \nBlood type: B", new DateTime(1970, 11, 15, 16, 0, 0, 0, DateTimeKind.Local), "六道", "神士", "Koushi Rikudou", "https://cdn.myanimelist.net/images/voiceactors/2/5546.jpg", "https://myanimelist.net/people/4237/Koushi_Rikudou", "http://www7b.biglobe.ne.jp/~rikudoukan/" },
                    { 4285, "Twitter: @dempaantenna", null, "永野", "のりこ", "Noriko Nagano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4285/Noriko_Nagano", "http://naganoare.wordpress.com/" },
                    { 4340, "Female\nBirthplace: Ishikawa prefecture, Japan\nBlood type: A", null, null, "アルコ", "Aruko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4340/Aruko", null },
                    { 4366, null, null, null, null, "Kaoru Shizuka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4366/Kaoru_Shizuka", null },
                    { 4435, "Twitter: @terra_da_k\n\nBirth Place: Tamano, Okayama, Japan", new DateTime(1963, 12, 6, 16, 0, 0, 0, DateTimeKind.Local), "寺田", "克也", "Katsuya Terada", "https://cdn.myanimelist.net/images/voiceactors/2/43256.jpg", "https://myanimelist.net/people/4435/Katsuya_Terada", "http://cacazan.com/" },
                    { 4452, "Twitter: @kinusa", null, "霜月", "絹鯊", "Kinusa Shimotsuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4452/Kinusa_Shimotsuki", "http://hazekan.main.jp/" },
                    { 4463, null, new DateTime(1960, 6, 16, 17, 0, 0, 0, DateTimeKind.Local), "伊藤", "伸平", "Shinpei Ito", "https://cdn.myanimelist.net/images/voiceactors/2/5469.jpg", "https://myanimelist.net/people/4463/Shinpei_Ito", "http://www.hyperdolls.com" },
                    { 4472, "Twitter: @emoto__nao", null, "絵本", "奈央", "Nao Emoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4472/Nao_Emoto", null },
                    { 4484, null, null, "眠", "民", "Min Min", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4484/Min_Min", "http://ming2.web.fc2.com/" },
                    { 4500, "Birthplace: Suita, Osaka, Japan\n\nHiroshi Shiibashi graduated in Osaka University of Arts under the Visual Concept Planning Department, wherein he attended Kazuo Koike's seminar.\n\nHe was previously an assistant to Hirohiko Araki.\n\nTwitter: @ukiyoecho", new DateTime(1980, 6, 5, 17, 0, 0, 0, DateTimeKind.Local), "椎橋", "寛", "Hiroshi Shiibashi", "https://cdn.myanimelist.net/images/voiceactors/2/32565.jpg", "https://myanimelist.net/people/4500/Hiroshi_Shiibashi", null },
                    { 4502, "Birth place: Sumida, Tokyo, Japan", new DateTime(1968, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), "福井", "晴敏", "Harutoshi Fukui", "https://cdn.myanimelist.net/images/voiceactors/3/46299.jpg", "https://myanimelist.net/people/4502/Harutoshi_Fukui", "http://www.fukuiharutoshi.jp/" },
                    { 4522, "He was born in Sakai, Osaka, Japan.", new DateTime(1974, 7, 28, 17, 0, 0, 0, DateTimeKind.Local), "石川", "雅之", "Masayuki Ishikawa", "https://cdn.myanimelist.net/images/voiceactors/2/6240.jpg", "https://myanimelist.net/people/4522/Masayuki_Ishikawa", "http://homepage2.nifty.com/mmmasayuki/" },
                    { 4526, null, new DateTime(1947, 6, 25, 17, 0, 0, 0, DateTimeKind.Local), "尾瀬", "あきら", "Akira Oze", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4526/Akira_Oze", null },
                    { 4529, "Ikemoto was previously an assistant of Masashi Kishimoto for over a decade with Naruto.", new DateTime(1977, 1, 12, 16, 0, 0, 0, DateTimeKind.Local), "池本", "幹雄", "Mikio Ikemoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4529/Mikio_Ikemoto", null },
                    { 4556, null, null, "春風邪", "三太", "Santa Harukaze", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4556/Santa_Harukaze", null },
                    { 4587, "Twitter: @hideakifujii", null, "藤異", "秀明", "Hideaki Fujii", "https://cdn.myanimelist.net/images/voiceactors/3/60692.jpg", "https://myanimelist.net/people/4587/Hideaki_Fujii", null },
                    { 4589, "Doujin circle: SUTAHIRO BOX\n\nTwitter: @stuhiro", null, "すたひろ", null, "stuhiro", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4589/stuhiro", "http://d.hatena.ne.jp/stu-hiro/" },
                    { 4608, "Male\nBlood type: A\nCurrent residence: Saitama Prefecture, Japan\n\nHis pen name comes from Sakamoto Ryouma, a famous samurai and politician who often used the alias Saitani Umetarou to hide from his enemies.\n\nTwitter: @saitaniume\npixiv: #620361", new DateTime(1972, 7, 13, 17, 0, 0, 0, DateTimeKind.Local), "才谷", "ウメタロウ", "Umetarou Saitani", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4608/Umetarou_Saitani", "http://saitaniume.blog.fc2.com/" },
                    { 4661, "Twitter: @mayamaya36", null, "珠月", "まや", "Maya Mizuki", "https://cdn.myanimelist.net/images/voiceactors/3/35035.jpg", "https://myanimelist.net/people/4661/Maya_Mizuki", "http://www.mayamaya.info/" },
                    { 4719, null, null, "陽菜", "コトリ", "Kotori Hina", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4719/Kotori_Hina", "http://www.ne.jp/asahi/heart/color/home/top.html" },
                    { 4766, "Favourite manga:\n- Jojo's Bizarre Adventure\n- Battle Angel Alita\n- Death Note\n- One Piece\n- Yotsubato!\n- Nausicaä of the Valley of the Wind", new DateTime(1986, 3, 27, 16, 0, 0, 0, DateTimeKind.Local), "古味", "直志", "Naoshi Komi", "https://cdn.myanimelist.net/images/voiceactors/2/2020.jpg", "https://myanimelist.net/people/4766/Naoshi_Komi", null },
                    { 4801, null, null, "川崎", "ヒロユキ", "Hiroyuki Kawasaki", "https://cdn.myanimelist.net/images/voiceactors/3/43691.jpg", "https://myanimelist.net/people/4801/Hiroyuki_Kawasaki", null },
                    { 4809, "Twitter: @systemheaven", null, "タカムラ", "マサヤ", "Masaya Takamura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4809/Masaya_Takamura", null },
                    { 4853, null, null, "日下部", "匡俊", "Masatoshi Kusakabe", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4853/Masatoshi_Kusakabe", null },
                    { 4882, "Male\n\nTwitter: @ayaki_generatio\npixiv: #8611", null, null, "彩樹", "Ayaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4882/Ayaki", "http://ayakigarigari.blog89.fc2.com/" },
                    { 4888, "Twitter: @pyonpyon6", new DateTime(1982, 6, 15, 17, 0, 0, 0, DateTimeKind.Local), "新井", "隆広", "Takahiro Arai", "https://cdn.myanimelist.net/images/voiceactors/3/7396.jpg", "https://myanimelist.net/people/4888/Takahiro_Arai", null },
                    { 4931, "Twitter: @saruink", null, "橋野", "サル", "Saru Hashino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4931/Saru_Hashino", null },
                    { 4994, null, null, "大森", "倖三", "Kouzou Oomori", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/4994/Kouzou_Oomori", null },
                    { 5006, "Twitter: @konchikidon", null, "こんちき", null, "Konchiki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/5006/Konchiki", "http://konchiki.blog68.fc2.com/" },
                    { 5015, "Twitter: @linco", null, "linco", null, "linco", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/5015/linco", "http://linco.jp" },
                    { 5024, null, null, "橘", "あゆん", "Ayun Tachibana", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/5024/Ayun_Tachibana", null },
                    { 5059, "Blood type: B\n\nAtsushi Ookubo is a Japanese manga artist known for Soul Eater and Fire Force. Ookubo started his career working as an assistant under Rando Ayamine, on the manga series GetBackers. He also created artwork for the video game TCG Lord of Vermilion and also did some character designs in Bravely Default and Bravely Second: End Layer.\n\nHe has a brother named Akira Ookubo who is also a mangaka and worked as an artist for the Samurai Eight series.\n\nAfter finishing Fire Force, he self-proclaimed Kei Urana as his successor.\n\nTwitter: @Atsushi_Ohkubo", new DateTime(1979, 9, 19, 17, 0, 0, 0, DateTimeKind.Local), "大久保", "篤", "Atsushi Ookubo", "https://cdn.myanimelist.net/images/voiceactors/3/57019.jpg", "https://myanimelist.net/people/5059/Atsushi_Ookubo", null },
                    { 5082, "Hometown: Komatsushima, Tokushima, Japan \nAlso known as Ikunigoma Kinako (イクニゴマ キナコ).\n\nChronology:\n- (1986) Becomes an employee of Toei Douga\n- (1996) After leaving Toei Douga he establishes the creator group \"Be-Papas\" which he supervises\n- (1997-11) Wins \"Best Television Series Award\" and the \"Kobe Award\" at Animation Kobe '97 for Revolutionary Girl Utena\n- (1999-10) First Be-Papas Disbands\n- (2001) Moves to the United States\n\nFavorites:\n- A fan of Steven Spielberg's \"Duel\"\n- Firm pillows\n- Likes to swim\n- Not a fan of the Rocky Horror Picture Show.\n\nHobbies:\n- Collecting pictures of him with his beloved cat\n\nNon-anime staff credits:\n- Assistant Director for \"Fuuhaa\" (TV)\n- Co-writer for \"Schell Bullet\" (novel)\n- Story for \"The World of S &amp; M\" and \"Nokemono to Hanayome\" (manga)\n- Supervisor of Dramatization for \"Shoujo Kakumei Utena\" (musical)\n\nTwitter: @ikuni_noise", new DateTime(1964, 12, 20, 16, 0, 0, 0, DateTimeKind.Local), "幾原", "邦彦", "Kunihiko Ikuhara", "https://cdn.myanimelist.net/images/voiceactors/3/50849.jpg", "https://myanimelist.net/people/5082/Kunihiko_Ikuhara", null },
                    { 5158, null, new DateTime(1965, 1, 6, 16, 0, 0, 0, DateTimeKind.Local), "神坂", "一", "Hajime Kanzaka", "https://cdn.myanimelist.net/images/voiceactors/3/22680.jpg", "https://myanimelist.net/people/5158/Hajime_Kanzaka", null },
                    { 5163, "Hometown: Kagoshima  Prefecture, Japan\nReal name: Yamazaki Shouzou (山崎 昌三)\n\nHe is a screenwriter for anime and tokusatsu shows and a graduate of LaSalle High School and Nikkatsu Visual Arts Academy.\n\nAlso known as (谷本 敬次)\n\n(Source: Wikipedia, AniDB)", new DateTime(1955, 2, 25, 16, 0, 0, 0, DateTimeKind.Local), "武上", "純希", "Junki Takegami", "https://cdn.myanimelist.net/images/voiceactors/2/71889.jpg", "https://myanimelist.net/people/5163/Junki_Takegami", null },
                    { 5199, "Writes yuri works under Takano Saku penname.\n\nTwitter: @takano_wf\npixiv: #2675148", null, "吉岡", "榊", "Sakaki Yoshioka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/5199/Sakaki_Yoshioka", "http://unmoral.sakura.ne.jp/waterfall.html" },
                    { 5210, "Circle: AKANENONE\n\nTwitter: @imusanjyo\npixiv: #309513", null, "仏さんじょ", null, "Imusanjo", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/5210/Imusanjo", "http://imu3.net/index.html" },
                    { 5241, "Tatsuo Yoshida a self-taught artist growing up in post-war Japan would become a legendary figure in the anime industry when he founded Tatsunoko Productions Company with his brother Kenji.   His career was cut tragically short when he died of Liver Cancer on September 5, 1977.", new DateTime(1933, 3, 5, 16, 0, 0, 0, DateTimeKind.Local), "吉田", "竜夫", "Tatsuo Yoshida", "https://cdn.myanimelist.net/images/voiceactors/3/7235.jpg", "https://myanimelist.net/people/5241/Tatsuo_Yoshida", null },
                    { 5254, "Nisio Isin, frequently written as NisiOisiN to emphasize that his pen name is a palindrome, is a Japanese novelist and manga writer. He attended and left Ritsumeikan University without graduating. In 2002, he debuted with the novel Kubikiri Cycle, which earned him the 23rd Mephisto Award at twenty years of age.\n\nHe currently works with Kodansha on Pandora, the Kodansha Box magazine, and Faust, a literary magazine containing the works of other young authors who similarly take influence from light novels and otaku culture. He was also publishing a twelve volume series over twelve months for the Kodansha Box line; Ryusui Seiryoin was matching this output, and the Kodansha Box website stated that this is the first time in the world two authors have done twelve volume monthly novel series simultaneously from the same publisher.\n\nIn February, 2008, his novel Death Note Another Note: The Los Angeles BB Murder Cases was released in English by Viz Media. Del Rey Manga has already released the first volume in his Zaregoto series. His Bakemonogatari and Katanagatari novels have been adapted into anime.\n\n(Source: Wikipedia)", null, "西尾", "維新", "ISIN NISIO", "https://cdn.myanimelist.net/images/voiceactors/2/43583.jpg", "https://myanimelist.net/people/5254/ISIN_NISIO", "http://ni.siois.in/" },
                    { 5264, "Twitter: @r_tkt", null, "高遠", "るい", "Rui Takatou", "https://cdn.myanimelist.net/images/voiceactors/2/47787.jpg", "https://myanimelist.net/people/5264/Rui_Takatou", null },
                    { 5345, "Hometown: Ōta, Tokyo\n\nIn 1979, he made his debut with Crusher Joe while he was a student at Keio University. Around the same time, he joined the Studio Nue (スタジオぬえ) as an animator. He has had stories published in the manga anthology series Petit Apple Pie.\nHosono is the author of Gallery Fake and Tarō as well, for which two he won Shogakukan Manga Award for general manga in 1996.", new DateTime(1959, 12, 1, 16, 0, 0, 0, DateTimeKind.Local), "細野", "不二彦", "Fujihiko Hosono", "https://cdn.myanimelist.net/images/voiceactors/1/6807.jpg", "https://myanimelist.net/people/5345/Fujihiko_Hosono", null },
                    { 5348, "Birth place: Chichibu, Saitama Prefecture, Japan\n\nKenji Kamiyama has worked regularly with the anime studio and production enterprise, Production I.G, such as his work on Jin-Roh, Patlabor, Blood: The Last Vampire, and for whom he has directed the Ghost in the Shell: Stand Alone Complex anime television series, which was followed on into a second season, Ghost in the Shell: S.A.C. 2nd GIG and a TV movie, Ghost in the Shell: Stand Alone Complex - Solid State Society.\n\nAfter working as a background artist for productions such as Akira and Kiki's Delivery Service, he joined Team Oshii at Production I.G, contributing the screenplay of Blood: The Last Vampire, and working as animation director for Jin-Roh. In 2002 he made his directorial debut with MiniPato, followed by Ghost in the Shell: Stand Alone Complex and Ghost in the Shell: S.A.C. 2nd GIG. In 2007, after almost 6 years of work on the Stand Alone Complex world, he directed the TV series Guardian of the Sacred Spirit and Eden of the East.\n\nTwitter: @kixyuubann", new DateTime(1966, 3, 19, 16, 0, 0, 0, DateTimeKind.Local), "神山", "健治", "Kenji Kamiyama", "https://cdn.myanimelist.net/images/voiceactors/1/42647.jpg", "https://myanimelist.net/people/5348/Kenji_Kamiyama", null },
                    { 5370, null, null, "茶月", "みきこ", "Mikiko Satsuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/5370/Mikiko_Satsuki", null },
                    { 5374, "Ken Ishikawa died on November 15, 2006. He was a Japanese manga artist and renowned as the co-creator, with Go Nagai, of the Getter Robo anime series, as well as four of their subsequent manga continuations.\n\nHe collapsed at a dinner banquet, after a day of golf, and was rushed to the hospital where he was pronounced dead according to his mentor, Go Nagai.", new DateTime(1948, 6, 27, 17, 0, 0, 0, DateTimeKind.Local), "石川", "賢", "Ken Ishikawa", "https://cdn.myanimelist.net/images/voiceactors/1/63194.jpg", "https://myanimelist.net/people/5374/Ken_Ishikawa", null },
                    { 5392, "Born in Tottori, Japan.", new DateTime(1963, 3, 13, 16, 0, 0, 0, DateTimeKind.Local), "前田", "真宏", "Mahiro Maeda", "https://cdn.myanimelist.net/images/voiceactors/2/43464.jpg", "https://myanimelist.net/people/5392/Mahiro_Maeda", null },
                    { 5417, "Born in Okinawa, Japan.\n\nMitsutoshi made his debut in 1996 in Weekly Shounen Jump and received a Akatsuka Award for best new humorous manga cartoonist writer for his series Seikimatsu Leader den Takeshi!(1997–2002, 24 volumes), for which he also won the 2001 Shogakukan Manga Award for children's manga.\n\nIn 2002, Mitsutoshi was arrested and convicted of violating child prostitution laws, including paying a 16-year-old girl ¥80,000 to have sex. As a result of the arrest, Seikimatsu Leader Den Takeshi! was cancelled by Weekly Shounen Jump, but the sentence was suspended after 2 days and he was free to go.\n\nIn 2004, Mitsutoshi returned to manga with a sports/comedy manga, Ring, which continued for 3 volumes (24 chapters) in Super Jump magazine.\n\nMitsutoshi's next series was Toriko, which was serialized in Weekly Shounen Jump from 2008 to 2016. It was nominated for the 2nd Manga Taisho Award in 2009 but did not win.\n\n(Source: Wikipedia)", new DateTime(1975, 8, 18, 17, 0, 0, 0, DateTimeKind.Local), "島袋", "光年", "Mitsutoshi Shimabukuro", "https://cdn.myanimelist.net/images/voiceactors/1/50316.jpg", "https://myanimelist.net/people/5417/Mitsutoshi_Shimabukuro", "http://sj.shueisha.co.jp/contents/simabuu/" },
                    { 5423, "Birth place: Ibaraki Prefecture, Japan\n\nJunichi Fujisaku is an anime director, scriptwriter, game designer and novelist. \n\nHe joined Production I.G as Game Production Department Chief Director, but soon became one of Team Oshii's core members. With Kamiyama Kenji, he participated to the creation of the theatrical feature Blood: The Last Vampire (2000). The girl in sailor suit fighting monsters with a Japanese sword was in fact Fujisaku's idea. For the Blood franchise he also directed the game version and wrote the novelization. He later gave his valuable contribution to the expansion of the Ghost in the Shell world, writing the scripts for many episodes of the Stand Alone Complex series, producing and directing the game version for PS2, and writing three related novels. \n\nIn 2005 he debuted as TV series director with Blood+. Latest credits include the mobile manga XX and TV series Real Drive and Erin, the Beast Player as story supervisor. \n\n(Source: AniDB)", new DateTime(1967, 8, 5, 17, 0, 0, 0, DateTimeKind.Local), "藤咲", "淳一", "Junichi Fujisaku", "https://cdn.myanimelist.net/images/voiceactors/2/43159.jpg", "https://myanimelist.net/people/5423/Junichi_Fujisaku", null },
                    { 5478, null, null, "櫻井", "圭記", "Yoshiki Sakurai", "https://cdn.myanimelist.net/images/voiceactors/1/40670.jpg", "https://myanimelist.net/people/5478/Yoshiki_Sakurai", null },
                    { 5480, "Twitter: @picnic2kashmir", null, "kashmir", null, "kashmir", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/5480/kashmir", "http://picnic.to/~kashmir/" },
                    { 5505, "Doujin circle: OTAUT-R\n\nTwitter: @sumeragihamao\npixiv: #674959", null, "皇", "ハマオ", "Hamao Sumeragi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/5505/Hamao_Sumeragi", null },
                    { 5559, "Takada Akemi is a Japanese artist and illustrator. She is a popular anime character designer who attended Tama Art University, and then worked for Tatsunoko Pro following her graduation. She is currently a freelance illustrator with her own studio, though she is also a member of the creative group Headgear. She also has her own designer jewelry store called Diakosmos.", new DateTime(1955, 3, 30, 16, 0, 0, 0, DateTimeKind.Local), "高田", "明美", "Akemi Takada", "https://cdn.myanimelist.net/images/voiceactors/1/32791.jpg", "https://myanimelist.net/people/5559/Akemi_Takada", "http://www.takada-akemi.net" },
                    { 5587, "Birth place: Kirikiri, Ootsuchi, Kamihei, Iwate Prefecture, Japan\nCurrent residence: Hasuda, Saitama Prefecture, Japan\n\nIn 1991 Koshita Tetsuhiro won the 37th Shougakukan Manga Award in the children category for his series Honou no Toukyuuji Dodge Danpei.", new DateTime(1965, 3, 7, 16, 0, 0, 0, DateTimeKind.Local), "こした", "てつひろ", "Tetsuhiro Koshita", "https://cdn.myanimelist.net/images/voiceactors/1/56432.jpg", "https://myanimelist.net/people/5587/Tetsuhiro_Koshita", null },
                    { 5596, "Female", null, "勝木", "光", "Hikaru Katsuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/5596/Hikaru_Katsuki", null },
                    { 5643, null, null, "カサハラ", "テツロー", "Tetsuroh Kasahara", "https://cdn.myanimelist.net/images/voiceactors/1/67499.jpg", "https://myanimelist.net/people/5643/Tetsuroh_Kasahara", null },
                    { 5676, null, null, "カザマ", "アヤミ", "Ayami Kazama", "https://cdn.myanimelist.net/images/voiceactors/2/60626.jpg", "https://myanimelist.net/people/5676/Ayami_Kazama", "http://zama.lomo.jp/" },
                    { 5702, null, null, "岩本", "佳浩", "Yoshihiro Iwamoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/5702/Yoshihiro_Iwamoto", null },
                    { 5715, "Twitter: @morishima_akiko", new DateTime(1973, 3, 19, 16, 0, 0, 0, DateTimeKind.Local), "森島", "明子", "Akiko Morishima", "https://cdn.myanimelist.net/images/voiceactors/1/3948.jpg", "https://myanimelist.net/people/5715/Akiko_Morishima", "http://akicocotte.blog45.fc2.com/" },
                    { 5724, "Doujin circles: Pokopii (ぽこぴー), Pokopii &amp; T's (ぽこぴ～あんどてぃ～ず)\n\nA Japanese animator, character designer, and animation director currently living in Tokyo, Japan. He often goes by the pseudonym Poyoyon Rock. He is also a member of the doujinshi circle Pokopii.\n\n(Source: Wikipedia)\n\nTwitter: @punipoyo\npixiv: #16584138", new DateTime(1969, 7, 12, 17, 0, 0, 0, DateTimeKind.Local), "渡辺", "明夫", "Akio Watanabe", "https://cdn.myanimelist.net/images/voiceactors/2/36285.jpg", "https://myanimelist.net/people/5724/Akio_Watanabe", null },
                    { 5779, "Twitter: @jyumonji_ao", null, "十文字", "青", "Ao Jyumonji", "https://cdn.myanimelist.net/images/voiceactors/3/67254.jpg", "https://myanimelist.net/people/5779/Ao_Jyumonji", "http://brainx.blog36.fc2.com/" },
                    { 5945, "Twitter: @yamadakotaro\n\nBirth place: Nagano prefecture\nBlood type: A", new DateTime(1980, 3, 14, 16, 0, 0, 0, DateTimeKind.Local), "山田", "孝太郎", "Koutarou Yamada", "https://cdn.myanimelist.net/images/voiceactors/1/70257.jpg", "https://myanimelist.net/people/5945/Koutarou_Yamada", "http://www.yamadakotaro.com/" },
                    { 6076, "Hometown: Gosen, Niigata, Japan", new DateTime(1966, 2, 1, 16, 0, 0, 0, DateTimeKind.Local), "鶴巻", "和哉", "Kazuya Tsurumaki", "https://cdn.myanimelist.net/images/voiceactors/1/43490.jpg", "https://myanimelist.net/people/6076/Kazuya_Tsurumaki", null },
                    { 6077, "Blood type: O\nBirth place: Yokohama, Kanagawa Prefecture, Japan", new DateTime(1959, 3, 7, 16, 0, 0, 0, DateTimeKind.Local), "関島", "眞頼", "Mayori Sekijima", "https://cdn.myanimelist.net/images/voiceactors/3/66431.jpg", "https://myanimelist.net/people/6077/Mayori_Sekijima", null },
                    { 6151, "Studio composed of Kenji Mitsuyoshi and Koichi Ishikawa.\n\nTwitter: @nabeatama", null, "Ark Performance", null, "Ark Performance", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6151/Ark_Performance", "http://blog.goo.ne.jp/ark-performance" },
                    { 6203, "Doujin circle: Honey Dipped (Honey Dipped)\n\nTwitter: @angelfrench", new DateTime(1972, 5, 8, 17, 0, 0, 0, DateTimeKind.Local), "若木", "民喜", "Tamiki Wakaki", "https://cdn.myanimelist.net/images/voiceactors/3/19825.jpg", "https://myanimelist.net/people/6203/Tamiki_Wakaki", "http://blog.wakakitamiki.coolblog.jp/" },
                    { 6321, null, null, "堀田", "きいち", "Kiichi Hotta", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6321/Kiichi_Hotta", null },
                    { 6328, "twitter: @thoresiva", null, "柴本", "Thores", "Thores Shibamoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6328/Thores_Shibamoto", "http://blog.goo.ne.jp/thores/" },
                    { 6381, "He was an assistant of  Osamu Akimoto.\n\nHideaki Togashi (Younger brother of Yoshihiro Togashi), Koji Inada and Naoko Takeuchi were once his assistants.", new DateTime(1961, 3, 9, 16, 0, 0, 0, DateTimeKind.Local), "うすね", "正俊", "Masatoshi Usune", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6381/Masatoshi_Usune", null },
                    { 6386, "Twitter: @nekogaeru\npixiv: #112311", new DateTime(1980, 2, 19, 16, 0, 0, 0, DateTimeKind.Local), "水上", "悟志", "Satoshi Mizukami", "https://cdn.myanimelist.net/images/voiceactors/3/10306.jpg", "https://myanimelist.net/people/6386/Satoshi_Mizukami", "http://nanbeinekogaeru.blog61.fc2.com/" },
                    { 6417, "Okawara was the first in the industry to be specifically credited as a mechanical designer. \nHe's the designer of numerous Real Robots and Super Robots.", new DateTime(1947, 12, 25, 16, 0, 0, 0, DateTimeKind.Local), "大河原", "邦男", "Kunio Ookawara", "https://cdn.myanimelist.net/images/voiceactors/3/43123.jpg", "https://myanimelist.net/people/6417/Kunio_Ookawara", null },
                    { 6443, null, null, "松田", "未来", "Miki Matsuda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6443/Miki_Matsuda", "http://www.mantovajin.net/" },
                    { 6490, "Born: Noboru Aikawa\nHometown: Tokyo, Japan", null, "會川", "昇", "Shou Aikawa", "https://cdn.myanimelist.net/images/voiceactors/1/40965.jpg", "https://myanimelist.net/people/6490/Shou_Aikawa", null },
                    { 6503, "Birthplace: Hyogo, Japan\n\nTwitter: @asayanen", null, "あさだ", "みほ", "Miho Asada", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6503/Miho_Asada", null },
                    { 6565, "Male\nBirth Place: Hamamatsu city, Japan\nZodiac Sign: Sagittarius", new DateTime(1977, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), "施川", "ユウキ", "Yuuki Shikawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6565/Yuuki_Shikawa", "http://www.geocities.co.jp/Bookend-Yasunari/6596/index.html" },
                    { 6578, "Twitter: @sakamotokenken\npixiv: #7330191", null, "坂本", "憲司郎", "Kenshirou Sakamoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6578/Kenshirou_Sakamoto", null },
                    { 6604, "An artist employed by Nippon Ichi whose art has been featured in video games such as Disgaea, Phantom Brave, and Makai Kingdom. His art style has been described as \"crazy and bizarre\" and features everything from cute pre-teen demons, to freaky pigs in royal clothing. His signature character, Pleinair, has appeared in Disgaea and Phantom Brave.\n\nAlong with his work for Nippon Ichi, Harada has published several doujinshi under the name of Haradaya. These include his kipple series and a Pleinair Handbook, which consist of short stories interspersed with various illustrations and fanart.\n\nDoujin circle: Haradaya (原田屋)\nAlternative names: Harada Yuuichi, Haradaya\n\nTwitter: @HARATAKE\npixiv: #6425", null, "原田", "たけひと", "Takehito Harada", "https://cdn.myanimelist.net/images/voiceactors/2/46148.jpg", "https://myanimelist.net/people/6604/Takehito_Harada", "http://www4.ocn.ne.jp/~u1h/" },
                    { 6606, "Miyama Noboru, age 51, passed away on December 2, 2007. He was an assistant to Ikezawa Satoshi before making his debut in Weekly Shonen Jump in 1981. \n\nHis titles included Mephisto, Pikaichi, Reira, \"Top Spin\", and \"Moeru Aki\". Yamada Takatoshi was his assistant.", new DateTime(1956, 1, 6, 16, 0, 0, 0, DateTimeKind.Local), "三山", "のぼる", "Noboru Miyama", "https://cdn.myanimelist.net/images/voiceactors/3/13747.jpg", "https://myanimelist.net/people/6606/Noboru_Miyama", null },
                    { 6632, null, null, "清水", "栄一", "Eiichi Shimizu", "https://cdn.myanimelist.net/images/voiceactors/3/57160.jpg", "https://myanimelist.net/people/6632/Eiichi_Shimizu", null },
                    { 6642, "Female\n\nTwitter: @marikati\npixiv: #28073", null, "谷村", "まりか", "Marika Tanimura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6642/Marika_Tanimura", null },
                    { 6659, "Birth place: Fukushima, Japan\n\nTwitter: @hima_kaz", new DateTime(1985, 5, 7, 17, 0, 0, 0, DateTimeKind.Local), "日丸屋", "秀和", "Hidekaz Himaruya", "https://cdn.myanimelist.net/images/voiceactors/1/27043.jpg", "https://myanimelist.net/people/6659/Hidekaz_Himaruya", "http://www.geocities.jp/himaruya/t.html" },
                    { 6666, null, null, null, null, "Yutaka Tani", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6666/Yutaka_Tani", null },
                    { 6749, "Twitter: @murakami44", new DateTime(1981, 9, 3, 17, 0, 0, 0, DateTimeKind.Local), "村上", "よしゆき", "Yoshiyuki Murakami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6749/Yoshiyuki_Murakami", null },
                    { 6773, "Twitter: @RyuMoto", new DateTime(1981, 2, 15, 16, 0, 0, 0, DateTimeKind.Local), "濱元", "隆輔", "Ryuusuke Hamamoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6773/Ryuusuke_Hamamoto", "http://www.ryusukeworks.com/" },
                    { 6795, null, new DateTime(1973, 9, 6, 17, 0, 0, 0, DateTimeKind.Local), "灰村", "キヨタカ", "Kiyotaka Haimura", "https://cdn.myanimelist.net/images/voiceactors/2/57584.jpg", "https://myanimelist.net/people/6795/Kiyotaka_Haimura", "http://r-s.sakura.ne.jp/" },
                    { 6854, null, new DateTime(1982, 6, 8, 17, 0, 0, 0, DateTimeKind.Local), "藤巻", "忠俊", "Tadatoshi Fujimaki", "https://cdn.myanimelist.net/images/voiceactors/1/23987.jpg", "https://myanimelist.net/people/6854/Tadatoshi_Fujimaki", null },
                    { 6858, "Twitter: @makaidaibouken4", null, "佐藤", "夕子", "Yuuko Satou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6858/Yuuko_Satou", null },
                    { 6903, null, new DateTime(1956, 10, 23, 17, 0, 0, 0, DateTimeKind.Local), "ときた", "ひろこ", "Hiroko Tokita", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6903/Hiroko_Tokita", null },
                    { 6929, null, null, "上江洲", "誠", "Makoto Uezu", "https://cdn.myanimelist.net/images/voiceactors/2/35995.jpg", "https://myanimelist.net/people/6929/Makoto_Uezu", "http://uezu.soregashi.com/" },
                    { 6943, null, null, "岩佐", "まもる", "Mamoru Iwasa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/6943/Mamoru_Iwasa", null },
                    { 7034, "Takayama Katsuhiko is a screenwriter. He is a member of the Writers Guild of Japan.\n\n(Source: AniDB)\n\nTwitter:https://twitter.com/Ka2hikoTakayama\nFacebook:https://www.facebook.com/KatsuhikoTakayama00/", null, "高山", "カツヒコ", "Katsuhiko Takayama", "https://cdn.myanimelist.net/images/voiceactors/1/8181.jpg", "https://myanimelist.net/people/7034/Katsuhiko_Takayama", "http://have-you-afternoon.tea-nifty.com/" },
                    { 7124, "Twitter: @masumi22\npixiv: #175886", null, "双葉", "ますみ", "Masumi Futaba", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/7124/Masumi_Futaba", null },
                    { 7189, "Birth place: Yakumo, Hokkaido, Japan\nGender: male", null, "余湖", "裕輝", "Yuuki Yugo", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/7189/Yuuki_Yugo", null },
                    { 7360, "Zodiac:  Scorpio\nBlood Type: A\n\nTwitter: @tsukiyaman", null, "月山", "可也", "Kaya Tsukiyama", "https://cdn.myanimelist.net/images/voiceactors/3/4315.jpg", "https://myanimelist.net/people/7360/Kaya_Tsukiyama", "http://www16.ocn.ne.jp/~kaya/" },
                    { 7375, "Birth place: Gifu Prefecture, Japan\n\nRyuuhei Tamura was previously an assistant under Toshiaki Iwashiro, who contributed illustrations in the first volume of Beelzebub as part of a collaboration project.", new DateTime(1980, 4, 18, 17, 0, 0, 0, DateTimeKind.Local), "田村", "隆平", "Ryuuhei Tamura", "https://cdn.myanimelist.net/images/voiceactors/2/12745.jpg", "https://myanimelist.net/people/7375/Ryuuhei_Tamura", null },
                    { 7394, "Doujin circle: Shinjugai\n\nTwitter: @shinjugai\npixiv: #256946\n\nTakeda Hiromitsu is a doujinishi artist (Mainly does NTR), and is a Mangaka.", null, "武田", "弘光", "Hiromitsu Takeda", "https://cdn.myanimelist.net/images/voiceactors/1/42806.jpg", "https://myanimelist.net/people/7394/Hiromitsu_Takeda", "http://pearlshell.blog56.fc2.com/" },
                    { 7447, "Twitter: @taishi_tsutsui\n\nYoutube: Taishi Tsutsui's drawing channel", new DateTime(1982, 10, 7, 17, 0, 0, 0, DateTimeKind.Local), "筒井", "大志", "Taishi Tsutsui", "https://cdn.myanimelist.net/images/voiceactors/2/58941.jpg", "https://myanimelist.net/people/7447/Taishi_Tsutsui", null },
                    { 7567, "Hometown: Hotoyoshi, Kumamoto Prefecture, Japan\n\nTwitter: @videobird\n\nTori Miki (とり・みき), also known as Micky Bird or Mickey Bird, is a Japanese manga artist, character designer, essayist, and screenplay writer born 23 February 1958 in Hotoyoshi, Kumamoto Prefecture, Japan. Tori has won multiple awards for his work, including two Seiun Awards (in 1994 for \"Dai-Hon'ya,\" and in 1998 for SF Taisho) and one Bungeishunjuu Manga Award (in 1995 for \"Tooku e Ikitai\"). His pen name was created by mixing up the pronunciation of the kanji making up his real name. He worked as a writer on \"WXIII: Patlabor the Movie 3.\"\n\nTori attended Meiji University, majoring in English literature, though he left his studies before receiving a degree. He was a member of the rakugo research club during his time there, and attended at the same time as owarai, tarento, and senpai Masayuki Watanabe.\n\nHe made his professional debut in 1979 afer winning an honorable mention for his story \"My Alien\" (ぼくの宇宙人 Boku no Uchuujin) at the 12th Shounen Champion Rookie Manga Awards, after which he became known mainly for his gag manga such as \"Kuru Kuru Kurin\" and \"Tooku e Ikitai,\" as well as manga featuring science fiction elements. For many years, his manga appeared in the television guide \"TV Bros.\"\n\n(Source: Wikipedia)", new DateTime(1958, 2, 22, 16, 0, 0, 0, DateTimeKind.Local), "とり", "みき", "Miki Tori", "https://cdn.myanimelist.net/images/voiceactors/2/71127.jpg", "https://myanimelist.net/people/7567/Miki_Tori", "https://www.torimiki.com" },
                    { 7605, "Birthplace: Kurashiki, Okayama Prefecture, Japan\n\nTwitter: @h_auri", null, "平尾", "アウリ", "Auri Hirao", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/7605/Auri_Hirao", "http://auri.jugem.jp/" },
                    { 7613, "Shingo Araki is a Japanese animation artist and character designer. He developed an interest for drawing at age five. He graduated in Aichi Prefecture. In 1955, at age eighteen, he debuted as a cartoonist in the \"Machi\" magazine. He then joined Mushi Production as animator in 1965 and later founded Studio Jaguar in 1966. In 1970, he debuted as animation director in the Mushi TV Series \"Joe of Tomorrow\", and later worked on the anime adaptations of several of Go Nagai's manga, including Devilman (1972), Cutie Honey (1973), and UFO Robo Grendizer (1975), serving as a character designer on the latter two.\n\nHe usually collaborates with animation director Michi Himeno, who he met in 1973. They formed Araki Production in 1975. He worked as animation director in 1978's \"Goodbye Battleship Yamato: Warriors of Love\". He, with Himeno, has been celebrated for their success. The Araki-Himeno duet collaborated on TV series and animated films such as \"Saint Seiya\" (1986-89), \"Saint Seiya Overture\" from 2004.\n\nSome of his successes are Majokko Megu-chan (1974), Lupin III (1977), Mugen Kido SSX (Captain Harlock, 1978), Versailles no Bara (Lady Oscar, 1979), Hana no Ko Lunlun (Angel, 1979), Mahou Shoujo Lalabelle (1980), Uchû Densetsu Ulysses 31 (Ulises 31, produced 1980, released 1981), and the versions for OVA of Fuma no Kojirô (1991). International accreditation came with Saint Seiya (Knights of the Zodiac, 1986), for his dynamic drawing style along with the elegant drawings styles of Michi. This Dynamic Duel, as they are known, have been instrumental in the success of the series.\n\nWorking for Toei Animation and Tokyo Movie Shinshia, Araki was also an animator on several American productions which outsourced animation work to Japan, including Mighty Orbots (1984, key animation), The Adventures of the American Rabbit (1986) and G.I. Joe: The Movie (1987).\n\nPassed away on December 1st 2011 due to acute heart failure. He was 72 years old.", new DateTime(1938, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), "荒木", "伸吾", "Shingo Araki", "https://cdn.myanimelist.net/images/voiceactors/2/15847.jpg", "https://myanimelist.net/people/7613/Shingo_Araki", null },
                    { 7622, "Twitter 1: @mikumo\nTwitter 2: @mikumo_alias", null, "三雲", "岳斗", "Gakuto Mikumo", "https://cdn.myanimelist.net/images/voiceactors/2/46948.jpg", "https://myanimelist.net/people/7622/Gakuto_Mikumo", null },
                    { 7629, "Twitter: @cmk_k", null, "久織", "ちまき", "Chimaki Kuori", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/7629/Chimaki_Kuori", "http://www.haikara-gajo.com" },
                    { 7634, null, new DateTime(1978, 4, 26, 17, 0, 0, 0, DateTimeKind.Local), "下口", "智裕", "Tomohiro Shimoguchi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/7634/Tomohiro_Shimoguchi", null },
                    { 7650, "Male (at the time of debut because of gender identity disorder it was female)\n\nTwitter: @_71416", new DateTime(1984, 5, 17, 17, 0, 0, 0, DateTimeKind.Local), "成瀬", "芳貴", "Yoshiki Naruse", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/7650/Yoshiki_Naruse", "http://shinichirou71.com/" },
                    { 7651, null, null, "みずき", "たつ", "Tatsu Mizuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/7651/Tatsu_Mizuki", null },
                    { 7653, null, null, "tenkla", null, "tenkla", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/7653/tenkla", null },
                    { 7706, null, new DateTime(1980, 5, 25, 17, 0, 0, 0, DateTimeKind.Local), "牛木", "義隆", "Yoshitaka Ushiki", "https://cdn.myanimelist.net/images/voiceactors/1/31617.jpg", "https://myanimelist.net/people/7706/Yoshitaka_Ushiki", "http://homepage2.nifty.com/onenightstand/" },
                    { 7721, null, new DateTime(1963, 8, 10, 17, 0, 0, 0, DateTimeKind.Local), "吉田", "戦車", "Sensha Yoshida", "https://cdn.myanimelist.net/images/voiceactors/2/58469.jpg", "https://myanimelist.net/people/7721/Sensha_Yoshida", null },
                    { 7726, "Twitter: @nylon100per\npixiv: #4468938", null, "ナイロン", null, "Nylon", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/7726/Nylon", "http://www008.upp.so-net.ne.jp/nylon100/" },
                    { 7729, "Futoshi Nishiya was a key animator, character designer, and chief animation director at Kyoto Animation. He died in 2019 at the age of 37 in an arson attack at the company's No. 1 Studio building.", null, "西屋", "太志", "Futoshi Nishiya", "https://cdn.myanimelist.net/images/voiceactors/3/25823.jpg", "https://myanimelist.net/people/7729/Futoshi_Nishiya", null },
                    { 7880, "Birth place: Nagoya\n\nTsuji Masaki is a Japanese scenario writer of TV series (including many anime works) and films as well as mystery fiction novels.\n\nTsuji was most active in the business from the 1960s through the 1980s, and worked as a script writer on many popular anime TV series for Mushi Production, Toei Animation, and Tokyo Movie Shinsha.\n\nAmong the many popular series and films on which Tsuji worked as a scenarist include the anime adaptations of Osamu Tezuka's Astro Boy, Jungle Taitei, Ribbon no Kishi, and Unico, Go Nagai's Devilman, Cutie Honey, and Dororon Enma-kun, and Yumiko Oshima's Wata no Kuni Hoshi. Tsuji was also the screenwriter of Arrow Emblem Grand Prix no Taka.\n\nOn September 24, 2008, Tsuji won a Special Award in the 13th Animation Kobe for his writing work.\n\n(Source: Wikipedia)\n\nTwitter: @mtsujiji", new DateTime(1932, 3, 22, 16, 0, 0, 0, DateTimeKind.Local), "辻", "真先", "Masaki Tsuji", "https://cdn.myanimelist.net/images/voiceactors/3/52380.jpg", "https://myanimelist.net/people/7880/Masaki_Tsuji", "http://2323.la.coocan.jp/" },
                    { 7937, null, new DateTime(1962, 5, 21, 17, 0, 0, 0, DateTimeKind.Local), "中鶴", "勝祥", "Katsuyoshi Nakatsuru", "https://cdn.myanimelist.net/images/voiceactors/3/64954.jpg", "https://myanimelist.net/people/7937/Katsuyoshi_Nakatsuru", null },
                    { 7973, null, null, "忍", null, "Shinobi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/7973/Shinobi", "http://www.geocities.jp/makidontstop2/" },
                    { 7998, "Yoshinari You graduated from Tokyo Designer Gakuin College and joined Madhouse in 1992. He left in the same year and joined Gainax, where he worked until 2011 when he joined Imaishi and other ex-Gainax employees to form Studio Trigger.\n\nHe is the younger brother of Yoshinari, Kou.", new DateTime(1971, 5, 5, 17, 0, 0, 0, DateTimeKind.Local), "吉成", "曜", "You Yoshinari", "https://cdn.myanimelist.net/images/voiceactors/1/43488.jpg", "https://myanimelist.net/people/7998/You_Yoshinari", null },
                    { 8052, "Birth place: Tokyo, Japan\nGender: female\n\nTwitter: @katohhhhhh", new DateTime(1980, 7, 19, 17, 0, 0, 0, DateTimeKind.Local), "加藤", "和恵", "Kazue Katou", "https://cdn.myanimelist.net/images/voiceactors/3/48100.jpg", "https://myanimelist.net/people/8052/Kazue_Katou", "http://katoukikaku.jugem.jp/" },
                    { 8161, "Twitter: @simada108", null, "しまだ", null, "Shimada", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8161/Shimada", null },
                    { 8208, null, null, "多田乃", "伸明", "Nobuaki Tadano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8208/Nobuaki_Tadano", null },
                    { 8260, "Birth place: Iwate prefecture, Japan\nHobbies: eating and drinking\nFavorite series: One Piece by Eiichiro Oda and Tekkonkinkreet by Taiyō Matsumoto.\nFavorite volleyball players: Shigeru Aoyama and Yuta Yoneyama.\n\nFurudate was a former volleyball player during Junior High School, gaining the position of middle blocker. Furudate lived in the Iwate Prefecture until graduation and moved to Miyagi Prefecture after.", new DateTime(1983, 3, 6, 16, 0, 0, 0, DateTimeKind.Local), "古舘", "春一", "Haruichi Furudate", "https://cdn.myanimelist.net/images/voiceactors/3/48941.jpg", "https://myanimelist.net/people/8260/Haruichi_Furudate", null },
                    { 8262, "Female\n\nTwitter: @kara2kmr", null, "唐々", "煙", "Kemuri Karakara", "https://cdn.myanimelist.net/images/voiceactors/2/41375.jpg", "https://myanimelist.net/people/8262/Kemuri_Karakara", "http://karakaranikki.jugem.jp/" },
                    { 8295, "Twitter: @reki09", null, "九我山", "レキ", "Reki Kugayama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8295/Reki_Kugayama", "http://www.takaneko.com/" },
                    { 8313, "Twitter: @TaiOkada", null, "岡田", "鯛", "Tai Okada", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8313/Tai_Okada", null },
                    { 8321, "Doujin Circle: Golden Pe Done", null, null, "枡狐/蛙空", "Masugitsune/Kawazu-ku", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8321/Masugitsune_Kawazu-ku", "http://goldenpedone1.web.fc2.com/" },
                    { 8346, "Doujin circle: Fukafuka\n\nTwitter: @fkfk_oftn\npixiv: #5591395", null, "関谷", "あさみ", "Asami Sekiya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8346/Asami_Sekiya", "http://saikidou55.blog.fc2.com/" },
                    { 8420, "Twitter: @daioki", new DateTime(1984, 2, 5, 16, 0, 0, 0, DateTimeKind.Local), "大沖", null, "Daioki", "https://cdn.myanimelist.net/images/voiceactors/2/39275.jpg", "https://myanimelist.net/people/8420/Daioki", "http://dioxin.sakura.ne.jp/" },
                    { 8559, "Male\nDoujin circle: Shinohara Juukou Eigyoubu\n\nTwitter: @maupon\npixiv: #8213", null, "榛名", "まお", "Mao Haruna", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8559/Mao_Haruna", "http://www.max.hi-ho.ne.jp/mao_h/" },
                    { 8576, "Doujin circle: Armored Ginkakuji (アーマードギンカクジ)\nCurrent residence: Tachikawa, Tokyo, Japan\n\nConsists of two members:\n- Maybe (born 1984) - artist\n- Rinrin (born 1983) - writer\n\nTwitter: @klotishue, @risotimo", null, "めいびい", null, "Maybe", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8576/Maybe", "http://www.asukyo.net/" },
                    { 8594, "Hometown: Tainan City, Taiwan\n\nFlickr: https://www.flickr.com/photos/vofan/\npixiv: #51536", new DateTime(1980, 6, 12, 17, 0, 0, 0, DateTimeKind.Local), "VOFAN", null, "VOFAN", "https://cdn.myanimelist.net/images/voiceactors/3/58438.jpg", "https://myanimelist.net/people/8594/VOFAN", "http://www.wretch.cc/blog/vofan" },
                    { 8611, null, new DateTime(1941, 1, 27, 16, 0, 0, 0, DateTimeKind.Local), "川崎", "のぼる", "Noboru Kawasaki", "https://cdn.myanimelist.net/images/voiceactors/1/32575.jpg", "https://myanimelist.net/people/8611/Noboru_Kawasaki", null },
                    { 8690, null, null, "守姫", "武士", "Takeshi Moriki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8690/Takeshi_Moriki", null },
                    { 8719, "Zodiac : Aries", null, "久世", "みずき", "Kuze Mizuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8719/Kuze_Mizuki", null },
                    { 8738, null, new DateTime(1968, 11, 26, 16, 0, 0, 0, DateTimeKind.Local), "西本", "英雄", "Hideo Nishimoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8738/Hideo_Nishimoto", null },
                    { 8749, "Twitter: @igaran", null, "五十嵐", "藍", "Ran Igarashi", "https://cdn.myanimelist.net/images/voiceactors/3/65091.jpg", "https://myanimelist.net/people/8749/Ran_Igarashi", "http://www.n-plus.jp/iga/" },
                    { 8836, null, null, "子安", "秀明", "Hideaki Koyasu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8836/Hideaki_Koyasu", null },
                    { 8908, null, null, "前田", "理想", "Risou Maeda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8908/Risou_Maeda", null },
                    { 8910, "Twitter: @Tamon_Ohta\npixiv: #1338403", null, "太田", "多門", "Tamon Ota", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/8910/Tamon_Ota", null },
                    { 9000, "Twitter: @msl666\npixiv: #613901", null, "カネコ", "マサル", "Masaru Kaneko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9000/Masaru_Kaneko", null },
                    { 9030, "Birthplace: Iruma, Japan\nBlood type: A\n\nHe is married to Mirin Furukawa from Dempagumi.inc. \n\nTwitter: @shu1aso", new DateTime(1985, 12, 25, 16, 0, 0, 0, DateTimeKind.Local), "麻生", "周一", "Shuuichi Asou", "https://cdn.myanimelist.net/images/voiceactors/2/47150.jpg", "https://myanimelist.net/people/9030/Shuuichi_Asou", null },
                    { 9057, "Doujin Circle: Lv.X (Lv.X闘, Lv.X+)\nBirthplace: Ehime Prefecture, Japan\nCurrent Residence: Tokyo, Japan\n\nYuzuki N' debuted in Megastore magazine with Strange Date one-shot.\n\nTwitter: @yuzukin_\npixiv: #691882", new DateTime(1983, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "柚木N'", null, "Yuzuki N'", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9057/Yuzuki_N", "http://yuzukin.jp/" },
                    { 9064, "Twitter: @unotsuka", null, "卯花", "つかさ", "Tsukasa Unohana", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9064/Tsukasa_Unohana", "http://unotsuka.hacca.jp/" },
                    { 9067, "Worked as Yana Toboso's assistant.", null, "茶鳥木", "明代", "Akiyo Satorigi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9067/Akiyo_Satorigi", null },
                    { 9143, "He is a film and anime director. He is the son of Tezuka Osamu.\n\nHe owns part of Tezuka Productions.\n\n(Source: AniDB)", new DateTime(1961, 8, 10, 17, 0, 0, 0, DateTimeKind.Local), null, null, "Makoto Tezuka", "https://cdn.myanimelist.net/images/voiceactors/1/52381.jpg", "https://myanimelist.net/people/9143/Makoto_Tezuka", null },
                    { 9177, "Twitter: @ringo_inuS\n\nHe was previously an assistant under Toshiaki Iwashiro.", new DateTime(1982, 5, 1, 17, 0, 0, 0, DateTimeKind.Local), "松本", "直也", "Naoya Matsumoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9177/Naoya_Matsumoto", null },
                    { 9198, null, null, "麻生", "我等", "Gatou Asou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9198/Gatou_Asou", null },
                    { 9348, null, null, "長田", "馨", "Kaoru Osada", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9348/Kaoru_Osada", null },
                    { 9496, "A group collaboration consisting of director Akiyuki Shinbou, writer Gen Urobuchi, the original character designer Ume Aoki, and the producer Atsuhiro Iwakami.", null, null, null, "Magica Quartet", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9496/Magica_Quartet", null },
                    { 9515, "Twitter: @kuso64\npixiv: #6174\nTumblr: @minamoonfuta5", null, "みなづき", "ふたご", "Futago Minazuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9515/Futago_Minazuki", null },
                    { 9542, null, new DateTime(1979, 6, 4, 17, 0, 0, 0, DateTimeKind.Local), "蒔島", "梓", "Azusa Mashima", "https://cdn.myanimelist.net/images/voiceactors/3/20519.jpg", "https://myanimelist.net/people/9542/Azusa_Mashima", null },
                    { 9563, null, null, "高木", "かな子", "Kanako Takagi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9563/Kanako_Takagi", null },
                    { 9602, "Twitter: @higasarosso", null, "赤井", "ヒガサ", "Higasa Akai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9602/Higasa_Akai", "http://rossohigasaakai.blog103.fc2.com/" },
                    { 9604, null, null, "津島", "直人", "Naoto Tsushima", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9604/Naoto_Tsushima", null },
                    { 9616, "Blood type: A\nHobby: Singing\nPet: Cat\n\nDebuted in Ribon Original with Ichigo Omelets in 2000 (June Issue).\n\nTwitter: @hankao42", new DateTime(1985, 4, 1, 16, 0, 0, 0, DateTimeKind.Local), "半澤", "香織", "Kaori Hanzawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9616/Kaori_Hanzawa", null },
                    { 9655, "Twitter: @lovely_pig328\npixiv: #35504719", new DateTime(1985, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "桜井", "のりお", "Norio Sakurai", "https://cdn.myanimelist.net/images/voiceactors/2/61249.jpg", "https://myanimelist.net/people/9655/Norio_Sakurai", "http://blog.livedoor.jp/ageodai2/" },
                    { 9672, null, null, "小川", "雅史", "Masashi Ogawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9672/Masashi_Ogawa", null },
                    { 9685, "Twitter: @Sanriyoko\nBlog: @sanriyoko\npixiv: #7367088", new DateTime(1970, 3, 13, 16, 0, 0, 0, DateTimeKind.Local), "さんり", "ようこ", "Youko Sanri", "https://cdn.myanimelist.net/images/voiceactors/1/9326.jpg", "https://myanimelist.net/people/9685/Youko_Sanri", null },
                    { 9737, "Twitter: @odamari000", null, "小田", "すずか", "Suzuka Oda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9737/Suzuka_Oda", "http://amatou.vis.ne.jp/" },
                    { 9744, null, null, null, null, "Nakahara Rei", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9744/Nakahara_Rei", null },
                    { 9834, "Birth place: Aichi Prefecture, Japan\n\nKouhei Horikoshi is a graduate of Nagoya University of Arts. He was previously an assistant to Yasuki Tanaka.\n\nTwitter: @horikoshiko", new DateTime(1986, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), "堀越", "耕平", "Kouhei Horikoshi", "https://cdn.myanimelist.net/images/voiceactors/2/19467.jpg", "https://myanimelist.net/people/9834/Kouhei_Horikoshi", null },
                    { 9848, "Female\nBirthplace: Nagasaki, Japan\nZodiac: Gemini\n\nTwitter: @go_barakamon", null, "ヨシノ", "サツキ", "Satsuki Yoshino", "https://cdn.myanimelist.net/images/voiceactors/3/43769.jpg", "https://myanimelist.net/people/9848/Satsuki_Yoshino", null },
                    { 9963, "Japanese novelist from Fukui Prefecture. He is known for being the winner of the 19th Mephisto Prize for Smoke, Soil, and Sacrifices, and the 16th Yukio Mishima Award for Asura Girl.\n\nHis 2008 work Disco Wednesdayyy is widely praised as a masterpiece representative of Japanese mystery and considered to be the Fifth Great Mystery.\n\nHe also wrote and illustrated for the Faust magazine, alongside other writers such as Nisio Isin, Yuuya Satou and Kouhei Kadono.\n\nTwitter: @tsuiyotsuitaro", null, "舞城", "王太郎", "Outarou Maijou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/9963/Outarou_Maijou", "http://www.realcoffee.jp/" },
                    { 10052, null, null, "田口", "央斗", "Auto Taguchi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10052/Auto_Taguchi", null },
                    { 10153, "Twitter: @takemura4hey", new DateTime(1980, 7, 17, 17, 0, 0, 0, DateTimeKind.Local), "竹村", "洋平", "Youhei Takemura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10153/Youhei_Takemura", null },
                    { 10269, null, new DateTime(1963, 12, 2, 16, 0, 0, 0, DateTimeKind.Local), "カトキ", "ハジメ", "Hajime Katoki", "https://cdn.myanimelist.net/images/voiceactors/1/42632.jpg", "https://myanimelist.net/people/10269/Hajime_Katoki", null },
                    { 10308, "Gen Urobuchi is a Japanese novelist, visual novel writer and anime screenwriter. He is best known for writing the highly acclaimed and commercially successful anime series Madoka Magica, which earned him the Tokyo Anime Award for Best Scriptwriter. Some other of his popular works include the 2003 visual novel Saya no Uta, the 2012 anime Psycho-Pass, the light novel and anime Fate/Zero, and the 2013–2014 tokusatsu show Kamen Rider Gaim. He currently works at Nitroplus and Nitro+chiral. \n\nNicknamed Urobutcher by his fans, Urobuchi's works often contain dark and nihilistic themes, tragic plot twists, and heavy usage of gore. Anime written by Urobuchi that have won the Newtype Anime Award have been Puella Magi Madoka Magica in 2011, Fate/Zero in 2012 and Psycho-Pass: The Movie in 2015. \n\nHe wrote scenarios for several visual novels created by Nitroplus:\nPhantom of Inferno (2000)\nKyuuketsu Senki Vjedogonia (2001)\nKikokugai: The Cyber Slayer (2002).\nSaya no Uta (2003)\nZoku Satsuriku no Django ~Jigoku no Shoukinkubi~ (2007)\n\n(Source: Wikipedia)\n\nTwitter: @Butch_Gen", new DateTime(1972, 12, 19, 16, 0, 0, 0, DateTimeKind.Local), "虚淵", "玄", "Gen Urobuchi", "https://cdn.myanimelist.net/images/voiceactors/3/45871.jpg", "https://myanimelist.net/people/10308/Gen_Urobuchi", null },
                    { 10310, null, null, "竹山", "祐右", "Yuusuke Takeyama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10310/Yuusuke_Takeyama", null },
                    { 10320, null, null, "西川", "秀明", "Hideaki Nishikawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10320/Hideaki_Nishikawa", null },
                    { 10350, "Twitter: @fukudashin1", null, "福田", "晋一", "Shinichi Fukuda", "https://cdn.myanimelist.net/images/voiceactors/3/71695.jpg", "https://myanimelist.net/people/10350/Shinichi_Fukuda", null },
                    { 10351, "He is of the domestic type. He respects Araki Hirohiko of JoJo's Bizarre Adventure. Also, he has a sister.", new DateTime(1983, 1, 25, 16, 0, 0, 0, DateTimeKind.Local), "高橋", "一郎", "Ichirou Takahashi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10351/Ichirou_Takahashi", null },
                    { 10353, null, null, "藤川", "祐華", "Yuka Fujikawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10353/Yuka_Fujikawa", null },
                    { 10426, "Matsuse was the Grand Prize winner of Monthly Shonen Sunday's first new artist competition.\n\nTwitter: @daichi0101\npixiv: #45571", new DateTime(1985, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), "マツセ", "ダイチ", "Daichi Matsuse", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10426/Daichi_Matsuse", null },
                    { 10512, "Yasuda worked at Capcom from 1985-2003 supplying concept and promotional art under the pen name \"Akiman\" (あきまん).\n\nTwitter: @akiman7", new DateTime(1964, 7, 20, 17, 0, 0, 0, DateTimeKind.Local), "安田", "朗", "Akira Yasuda", "https://cdn.myanimelist.net/images/voiceactors/2/43161.jpg", "https://myanimelist.net/people/10512/Akira_Yasuda", "http://blog.livedoor.jp/akiman7/" },
                    { 10523, "Doujin circles: Gorugo Moon, Hotateya\nTwitter: @hotateya", null, "ほたて", "ジェームス", "James Hotate", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10523/James_Hotate", "http://www31.ocn.ne.jp/~hotateya/" },
                    { 10687, "Also known as: BAR-PEACHPIT (hentai works)\n\nTwitter: @barkakeru", null, "KAKERU", null, "KAKERU", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10687/KAKERU", "http://barpeachpit.blog86.fc2.com/" },
                    { 10695, "Momoyama Hinase won the 5th Monthly Shonen Gangan Manga Encouragement Award with Shi no Butou (死の舞踏) under the name Aiga in 2002, and the 2nd Square Enix Manga Encouragement Award with Will in 2003. In 2004, had the one-shot Gaishi no Jouken (鎧師の条件) published in a special edition of Gangan Powered, in 2006 the one-shot Komachiwa (コマちわ) published in March edition of Monthly Gangan Wing and switched to using the Momoyama penname. Was the artist for a one-shot adaption of Emeth: Ningyoutsukai no Shima (emeth ～人形遣いの島～) for Gangan Wing after the original novel won a Square Enix prize.\n\nTwitter: @momokibidanngo\npixiv: #1547680", null, "桃山", "ひなせ", "Hinase Momoyama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10695/Hinase_Momoyama", null },
                    { 10742, "Younger brother of Yukiko Horiguchi.\n\nTwitter: @BUNBUN922\n\nNote: It's been confirmed that BUNBUN is the same person as abec.", new DateTime(1985, 9, 21, 17, 0, 0, 0, DateTimeKind.Local), "BUNBUN", null, "BUNBUN", "https://cdn.myanimelist.net/images/voiceactors/3/57211.jpg", "https://myanimelist.net/people/10742/BUNBUN", "https://sss.applibot.co.jp/member/bunbun.html" },
                    { 10809, "Female\n\nTwitter: @tonmi_n\npixiv: #204111", null, "成原", "とんみ", "Tonmi Narihara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10809/Tonmi_Narihara", "http://jikihai.blog.fc2.com/" },
                    { 10812, "Japanese female manga author.\n\nTwitter: @cherry_arai", null, "荒井", "チェリー", "Cherry Arai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10812/Cherry_Arai", "http://cherry-c.sblo.jp/" },
                    { 10817, null, new DateTime(1970, 6, 1, 17, 0, 0, 0, DateTimeKind.Local), "吉野", "弘幸", "Hiroyuki Yoshino", "https://cdn.myanimelist.net/images/voiceactors/3/17961.jpg", "https://myanimelist.net/people/10817/Hiroyuki_Yoshino", null },
                    { 10850, "Twitter: @Yujirororo", null, "小山", "ゆうじろう", "Yuujirou Koyama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10850/Yuujirou_Koyama", null },
                    { 10875, "Take was born on December 21st, 1983, and she lives in Tokyo, Japan. She began drawing when she was around 3 or 4 years old. She did not like studying very much, but was always praised for drawing. She felt that it would be nice to draw pictures that were needed by someone, so they frequently drew pictures for their friends, family, and schoolteachers. In her elementary graduation statement, they wrote \"I will get a job related to painting in the future\". \n\nWhen Take was around 15 or 16 years old, she discovered bulletin boards online, and participated in oekaki boards. At 17, her work was discovered by an editor at Kodansha, and Take made her professional debut illustrating the first light novel of Niso Isin's Zaregoto series.\n\nShe predominantly illustrates using Adobe Illustrator, but sometimes uses Adobe Photoshop and Paint Tool SAI. She is a fan of and influenced by the works of Osamu Tezuka, Studio Ghibli, Tatsunoko Production and Akiman. \n\nTwitter: @_take_oekaki", new DateTime(1983, 12, 20, 16, 0, 0, 0, DateTimeKind.Local), "竹", null, "Take", "https://cdn.myanimelist.net/images/voiceactors/2/62525.jpg", "https://myanimelist.net/people/10875/Take", "http://sai-zen-sen.jp/special/takegarou/" },
                    { 10900, "Twitter: @TAGRO", null, null, "TAGRO", "TAGRO", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10900/TAGRO", "http://www11.plala.or.jp/TAGRO/" },
                    { 10907, "Male\nCurrent residence: Saitama, Japan\nDoujin circle: Jenoa Cake\n\nTwitter: @TaKaYa_Ki\npixiv: #11937", new DateTime(1980, 1, 5, 16, 0, 0, 0, DateTimeKind.Local), "たかやKi", null, "TakayaKi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10907/TakayaKi", "http://members.jcom.home.ne.jp/rear-wheel-drive/" },
                    { 10915, "Hometown: Chiba, Japan", null, "長谷見", "沙貴", "Saki Hasemi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/10915/Saki_Hasemi", null },
                    { 10951, "Birth place: Oogaki, Gifu Prefecture, Japan\n\nYoshitoki Ooima is a young mangaka. She worked with the author Tow Ubukata as designer for the manga Mardock Scramble.\n\nOoima's mother knows sign language, and she helped her with the manga Koe no Katachi, which is about a deaf girl. Ooima's elder sister also assists her sometimes.", new DateTime(1989, 3, 14, 16, 0, 0, 0, DateTimeKind.Local), "大今", "良時", "Yoshitoki Ooima", "https://cdn.myanimelist.net/images/voiceactors/3/30393.jpg", "https://myanimelist.net/people/10951/Yoshitoki_Ooima", null },
                    { 11001, "Twitter: @bluedoor30q\npixiv: #14729721", null, "青戸", "成", "Jou Aoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11001/Jou_Aoto", "http://bluedoor.makibisi.net/" },
                    { 11023, "Birthplace: Kyoto, Japan\n\nTwitter: @karasuma2828", null, "烏丸", "匡", "Tasuku Karasuma", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11023/Tasuku_Karasuma", "http://www.karasumatasuku.jp/fuyu/top.html" },
                    { 11068, "Twitter: @inotomo2009", null, "井上", "智徳", "Tomonori Inoue", "https://cdn.myanimelist.net/images/voiceactors/1/28623.jpg", "https://myanimelist.net/people/11068/Tomonori_Inoue", null },
                    { 11085, "Doujin circle: Hikakuteki Simple na Panty (比較的シンプルなパンティ)\n\nTwitter: @Syunsaeki\npixiv: #88701", new DateTime(1985, 11, 10, 16, 0, 0, 0, DateTimeKind.Local), "佐伯", "俊", "Shun Saeki", "https://cdn.myanimelist.net/images/voiceactors/1/69945.jpg", "https://myanimelist.net/people/11085/Shun_Saeki", "http://hika-pan.sakura.ne.jp/" },
                    { 11089, "Female\nBlood type: O\n\nTwitter: @nekobyou", null, "猫猫", "猫", "Neko Nekobyou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11089/Neko_Nekobyou", "http://park7.wakwak.com/~neko3/0/" },
                    { 11112, null, null, "しぐま", "太朗", "Tarou Shiguma", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11112/Tarou_Shiguma", null },
                    { 11123, "Tsuru sometimes works under the pen name Yasuaki Kurotsu (黒津安明). The kanji that make up this pen name is a mix of the characters for Akira Kurosawa and Yasujirō Ozu.", null, "都留", "稔幸", "Toshiyuki Tsuru", "https://cdn.myanimelist.net/images/voiceactors/1/81620.jpg", "https://myanimelist.net/people/11123/Toshiyuki_Tsuru", null },
                    { 11163, null, null, "あわ箱", null, "Awabako", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11163/Awabako", null },
                    { 11232, null, null, "武田", "みか", "Mika Takeda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11232/Mika_Takeda", "http://www2.ocn.ne.jp/~silph/" },
                    { 11257, "Twitter: @koike_sadaji\nOld website: http://silverrockets.chips.jp/", null, "小池", "定路", "Sadaji Koike", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11257/Sadaji_Koike", "https://sadajiokiba.blog.fc2.com/" },
                    { 11272, null, null, "河田", "雄志", "Yushi Kawata", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11272/Yushi_Kawata", null },
                    { 11273, "Twitter: @yukit0o0", null, null, "行徒", "Yukito", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11273/Yukito", "http://www.geocities.jp/yukito_hakusyoku/" },
                    { 11294, null, null, "木谷", "椎", "Shii Kiya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11294/Shii_Kiya", null },
                    { 11323, "Blood type: A\nPlace of birth: Hokkaido, Japan", null, "るい", "たまち", "Tamachi Rui", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11323/Tamachi_Rui", null },
                    { 11339, "Twitter: @silver_ammo", null, "天羽", "銀", "Gin Amou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11339/Gin_Amou", null },
                    { 11371, "Twitter: @purapa", null, "ぷらぱ", null, "Purapa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11371/Purapa", "http://haruka.saiin.net/~peachyrafi/" },
                    { 11423, "He founded the adult game brand Minato Soft in 2006.", null, "タカヒロ", null, "Takahiro", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11423/Takahiro", "http://www.takahiro.ms/index.htm" },
                    { 11439, null, new DateTime(1985, 4, 4, 16, 0, 0, 0, DateTimeKind.Local), null, "地獄のミサワ", "Jigoku no Misawa", "https://cdn.myanimelist.net/images/voiceactors/1/12380.jpg", "https://myanimelist.net/people/11439/Jigoku_no_Misawa", "http://jigokuno.com/" },
                    { 11466, "Birth place: Takasaki, Gunma Prefecture, Japan\nCurrent residence: Nerima, Tokyo, Japan\nHobby: Cycling\nDoujin circle: WordGear\n\nKawahara Reki graduated from the Aoyama Gakuin University.\n\nTwitter: @kunori", new DateTime(1974, 8, 16, 17, 0, 0, 0, DateTimeKind.Local), "川原", "礫", "Reki Kawahara", "https://cdn.myanimelist.net/images/voiceactors/2/53841.jpg", "https://myanimelist.net/people/11466/Reki_Kawahara", "http://wordgear.sblo.jp/" },
                    { 11470, "Hometown: Shizuoka, Shizuoka, Japan", new DateTime(1972, 2, 5, 16, 0, 0, 0, DateTimeKind.Local), "阿部", "潤", "Jun Abe", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11470/Jun_Abe", null },
                    { 11512, "Male\nHometown: Okinawa Prefecture, Japan\nCurrent residence: Tokyo, Japan\n\nTwitter: @teriterio_\npixiv: #7017\nBlog: http://homihomio.blog13.fc2.com/", null, "てり", "てりお", "Terio Teri", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11512/Terio_Teri", "http://terio.sakura.ne.jp/" },
                    { 11619, "Birth place: Tokyo, Japan\nCurrent residence: Tokyo, Japan\n\nTwitter: @yabu_ten", new DateTime(1969, 8, 18, 17, 0, 0, 0, DateTimeKind.Local), "やぶの", "てんや", "Tenya Yabuno", "https://cdn.myanimelist.net/images/voiceactors/2/27605.jpg", "https://myanimelist.net/people/11619/Tenya_Yabuno", null },
                    { 11687, "Birthplace: Tokyo\nPen name as scriptwriter: Fuyunori Gobu", new DateTime(1942, 3, 30, 16, 0, 0, 0, DateTimeKind.Local), "鈴木", "良武", "Yoshitake Suzuki", "https://cdn.myanimelist.net/images/voiceactors/1/26599.jpg", "https://myanimelist.net/people/11687/Yoshitake_Suzuki", null },
                    { 11709, null, new DateTime(1969, 10, 24, 17, 0, 0, 0, DateTimeKind.Local), "井上", "行広", "Yukihiro Inoue", "https://cdn.myanimelist.net/images/voiceactors/2/14155.jpg", "https://myanimelist.net/people/11709/Yukihiro_Inoue", "http://www.geocities.jp/yukihiro6717/" },
                    { 11775, "Kitazume Hiroyuki is an animator and mangaka. Sometime in 1982-1984, he founded Pack with former Bevore employees, and later in 1987 Atelier Giga. After the production failure and commercial failure of  \"Relic Armor Legaciam\", both studios would be dissolved shortly later, after amassing a massive debt from the project. Shortly after, he would join Anime International Company (AIC) to pay off his debts. And as of 2004, he had left AIC and went freelance. He now frequently works on projects by Sunrise.", new DateTime(1961, 7, 23, 17, 0, 0, 0, DateTimeKind.Local), "北爪", "宏幸", "Hiroyuki Kitazume", "https://cdn.myanimelist.net/images/voiceactors/2/10939.jpg", "https://myanimelist.net/people/11775/Hiroyuki_Kitazume", null },
                    { 11831, "Twitter: @hayasemasato", null, "早瀬", "マサト", "Masato Hayase", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11831/Masato_Hayase", null },
                    { 11856, null, null, "天杉", "貴志", "Takashi Tensugi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11856/Takashi_Tensugi", "http://www007.upp.so-net.ne.jp/nekonoji/" },
                    { 11857, null, null, "平松", "正樹", "Masaki Hiramatsu", "https://cdn.myanimelist.net/images/voiceactors/1/71482.jpg", "https://myanimelist.net/people/11857/Masaki_Hiramatsu", "http://hirama2.web.fc2.com/" },
                    { 11939, "Twitter: @kizuku187", new DateTime(1979, 5, 25, 17, 0, 0, 0, DateTimeKind.Local), "渡邉", "築", "Kizuku Watanabe", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11939/Kizuku_Watanabe", null },
                    { 11962, "Male\n\nTwitter: @ruarua201\npixiv: #29544125", new DateTime(1984, 7, 30, 17, 0, 0, 0, DateTimeKind.Local), "今井", "ユウ", "Yuu Imai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/11962/Yuu_Imai", null },
                    { 12006, "Birthplace: Fukuoka Prefecture, Japan\nDoujin circle: MUGENKIDOU A\n\nThe penname \"Tomose Shunsaku\" is an anagram of a friend's real name.\n\nTwitter: @tomose_shunsaku", null, "トモセ", "シュンサク", "Shunsaku Tomose", "https://cdn.myanimelist.net/images/voiceactors/3/45179.jpg", "https://myanimelist.net/people/12006/Shunsaku_Tomose", "http://mugenkidou.sakura.ne.jp/" },
                    { 12032, "Birth Place: Kanagawa Prefecture\nZodiac: Sagittarius\n\nTwitter: @mochi2929", new DateTime(1983, 11, 28, 16, 0, 0, 0, DateTimeKind.Local), "もち", null, "Mochi", "https://cdn.myanimelist.net/images/voiceactors/1/70282.jpg", "https://myanimelist.net/people/12032/Mochi", "http://mochicome.com" },
                    { 12050, "Birthplace: Taku, Saga Prefecture\n\nMachiko Hasegawa was one of the first female manga artists. She started her own comic strip, Sazae-san, in 1946. It reached national circulation via the Asahi Shimbun in 1949, and ran daily until Hasegawa decided to retire in February 1974. \n\nHer comic strip was turned into a dramatic radio series in 1955 and a weekly animated series in 1969, which is still running as of 2021.\n\nShe received People's Honor Award in 1992.\n\nShe died of heart failure at the age of 72 on May 27, 1992.", new DateTime(1920, 1, 29, 16, 0, 0, 0, DateTimeKind.Local), "長谷川", "町子", "Machiko Hasegawa", "https://cdn.myanimelist.net/images/voiceactors/2/40807.jpg", "https://myanimelist.net/people/12050/Machiko_Hasegawa", "http://www.hasegawamachiko.jp/" },
                    { 12084, "Male\nBlood type: O\n\nBlog: sheepboxx\n\nTwitter: @sheepbox\npixiv: #73451", null, "羊箱", null, "Hitsujibako", "https://cdn.myanimelist.net/images/voiceactors/3/11427.jpg", "https://myanimelist.net/people/12084/Hitsujibako", "http://www.geocities.jp/hitujibako/" },
                    { 12131, "Blood type: B\n\nTwitter: @shizumukun", null, "渡辺", "静", "Shizumu Watanabe", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/12131/Shizumu_Watanabe", "http://stoicismxxx.blog103.fc2.com/" },
                    { 12153, null, null, "森田", "崇", "Takashi Morita", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/12153/Takashi_Morita", null },
                    { 12250, null, null, "入江", "謙三", "Kenzou Irie", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/12250/Kenzou_Irie", null },
                    { 12253, "Twitter: @sakaki27\npixiv: #160024", null, "榊", null, "Sakaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/12253/Sakaki", "http://www10.big.or.jp/~no27/" },
                    { 12338, "Ishibumi is born and raised in the Chiba Prefecture of Japan. He is a big fan of Pokémon and has collected every form of Gundam merchandise, which he writes about in his blog.\n\nTwitter: @ishibumi_ddd", null, "石踏", "一榮", "Ichiei Ishibumi", "https://cdn.myanimelist.net/images/voiceactors/2/30721.jpg", "https://myanimelist.net/people/12338/Ichiei_Ishibumi", "http://ishibumi.exblog.jp/" },
                    { 12368, null, null, null, null, "Satoshi Yuri", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/12368/Satoshi_Yuri", null },
                    { 12410, "Hiroshi Osaka is a noted Japanese animator, character designer, and illustrator whose early career included working with founding members of Production I.G and who became the co-founder of BONES.\n\nOsaka died from cancer on September 24, 2007. He was 44 years old.", new DateTime(1963, 6, 19, 17, 0, 0, 0, DateTimeKind.Local), "逢坂", "浩司", "Hiroshi Osaka", "https://cdn.myanimelist.net/images/voiceactors/2/12090.jpg", "https://myanimelist.net/people/12410/Hiroshi_Osaka", null },
                    { 12411, null, null, "川崎", "博嗣", "Hirotsugu Kawasaki", "https://cdn.myanimelist.net/images/voiceactors/3/12104.jpg", "https://myanimelist.net/people/12411/Hirotsugu_Kawasaki", null },
                    { 12433, "Twitter: @hanokage\npixiv: #49138", null, null, "ハノカゲ", "Hanokage", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/12433/Hanokage", "http://hano.pepper.jp/" },
                    { 12482, "Doujin circles: Hougakuya (方角屋), Moonsault Express (ムーンサルトエクスプレス)\n\nTwitter: @namboku\npixiv: #34059", null, "南北", null, "Nanboku", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/12482/Nanboku", "http://namboku.sakura.ne.jp/index.html" },
                    { 12513, "Twitter: @hayasi_okazu", null, "林", "雄一", "Yuuichi Hayashi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/12513/Yuuichi_Hayashi", null },
                    { 12529, "Scriptwriter.  Graduate of Hosei University. Married to scriptwriter Rika Nakase.", null, "十川", "誠志", "Masashi Sogo", "https://cdn.myanimelist.net/images/voiceactors/1/15297.jpg", "https://myanimelist.net/people/12529/Masashi_Sogo", null },
                    { 12592, null, new DateTime(1980, 7, 18, 17, 0, 0, 0, DateTimeKind.Local), "松原", "真琴", "Makoto Matsubara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/12592/Makoto_Matsubara", "http://matsubara.main.jp/" },
                    { 12623, "Twitter: @techiru\npixiv: #48532", new DateTime(1982, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "コバヤシ", "テツヤ", "Tetsuya Kobayashi", "https://cdn.myanimelist.net/images/voiceactors/1/12576.jpg", "https://myanimelist.net/people/12623/Tetsuya_Kobayashi", "http://www17.plala.or.jp/jabro2/" },
                    { 12672, "Birth place: Toyama Prefecture, Japan\n\nHe is a character designer, illustrator and animator. Worked in several Gainax productions, such as Gunbuster, Nadia, Evangelion and Otaku no Video. Was the character design for Gankutsuou and Oh! My Goddess.\n\nHe now works for Studio Khara, being the animation director of the Rebuild movies.\n\nTwitter: @HideMatsubara", new DateTime(1965, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), "松原", "秀典", "Hidenori Matsubara", "https://cdn.myanimelist.net/images/voiceactors/2/46091.jpg", "https://myanimelist.net/people/12672/Hidenori_Matsubara", null },
                    { 12773, null, null, null, null, "Naho Ooishi", "https://cdn.myanimelist.net/images/voiceactors/2/13191.jpg", "https://myanimelist.net/people/12773/Naho_Ooishi", null },
                    { 12837, "Female\n\nTwitter: @sakano_a\npixiv: #2855038", null, "坂野", "杏梨", "Anri Sakano", "https://cdn.myanimelist.net/images/voiceactors/2/24935.jpg", "https://myanimelist.net/people/12837/Anri_Sakano", "http://kota456.blog85.fc2.com/" },
                    { 12959, "Twitter: @Wakatuki_Hikaru", null, "わかつき", "ひかる", "Hikaru Wakatsuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/12959/Hikaru_Wakatsuki", "http://plaza.rakuten.co.jp/wakatukihikaru/" },
                    { 13031, "Gender: female\n\nTwitter: @shinasoga", null, "ソガ", "シイナ", "Shina Soga", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13031/Shina_Soga", "http://pos2006.blog117.fc2.com/" },
                    { 13087, "Twitter: @yamachitaisei", null, "矢町", "大成", "Taisei Yamachi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13087/Taisei_Yamachi", "http://blog.livedoor.jp/yamachitaisei/" },
                    { 13095, "Twitter: @imigimuru", null, "いみぎ", "むる", "Muru Imigi", "https://cdn.myanimelist.net/images/voiceactors/2/54447.jpg", "https://myanimelist.net/people/13095/Muru_Imigi", "http://www.geocities.jp/ayac2006/" },
                    { 13131, "Twitter: @riko0202", null, "梱枝", "りこ", "Riko Korie", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13131/Riko_Korie", "http://nekomimi.ws/~non-girl/" },
                    { 13137, "Twitter: @yoasami", null, "浅見", "よう", "You Asami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13137/You_Asami", "http://asmy.jpn.org/" },
                    { 13139, "Shiomiya Iruka is a professional illustrator who also releases independant doujinshi. He is best known for illustrating the covers of the two Senhime (Battle Princess) light novels, and also for contributing endcard artwork of Senjougahara Hitagi for Bakemonogatari anime.\n\nTwitter: @shio_mid", new DateTime(1983, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "シオミヤ", "イルカ", "Iruka Shiomiya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13139/Iruka_Shiomiya", "http://www.geocities.jp/shiomid" },
                    { 13163, "Kenji Taira (平建史, Taira Kenji) is a Japanese mangaka and Masashi Kishimoto's assistant.", null, "平", "健史", "Kenji Taira", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13163/Kenji_Taira", null },
                    { 13173, "Birth place: Mie Prefecture, Japan\n\nMengo Yokoyari dropped out of high school to become a mangaka assistant. She had wanted to become a manga artist since she was little.\n\nYokoyari made her debut in 2009 with Maken☆H Zemi!, which was published in Magazine WOoooo! and later collected as part of the Mokkai Shiyo? compilation.\n\nAfter contributing regularly to the magazine, she was invited by a Futabasha editor to draw a series for one its magazines. It would materialize as Haruwaka, Yokoyari's first serialization work.\n\nMengo announced on Twitter on November 25, 2019 that she had married an unknown man.\n\nTwitter: @yorimen\npixiv: #75189\nInstagram: @yorip", new DateTime(1988, 2, 26, 16, 0, 0, 0, DateTimeKind.Local), "横槍", "メンゴ", "Mengo Yokoyari", "https://cdn.myanimelist.net/images/voiceactors/3/43792.jpg", "https://myanimelist.net/people/13173/Mengo_Yokoyari", "http://yorimen.tumblr.com/" },
                    { 13251, "Twitter: @shint424", null, "藤本", "新太", "Shinta Fujimoto", "https://cdn.myanimelist.net/images/voiceactors/2/46252.jpg", "https://myanimelist.net/people/13251/Shinta_Fujimoto", null },
                    { 13289, "Twitter: @kawakamimasaki_\npixiv: #5773248", null, "川上", "真樹", "Masaki Kawakami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13289/Masaki_Kawakami", "http://kawakamimasaki.wixsite.com/kawakami-masaki" },
                    { 13369, null, null, "檜垣", "亮", "Ryou Higaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13369/Ryou_Higaki", null },
                    { 13371, "Female\n\nTwitter: @uta_isaki\npixiv: #12866", null, "伊咲", "ウタ", "Uta Isaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13371/Uta_Isaki", "http://teax.xxxxxxxx.jp/" },
                    { 13427, "Female\n\nTwitter: @akikonishi", null, "湖西", "晶", "Aki Konishi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13427/Aki_Konishi", "http://mizuumiya.blog108.fc2.com/" },
                    { 13477, null, null, "ざら", null, "Zara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13477/Zara", null },
                    { 13521, "Mangaka duo:\n* Makiro (マキロ) - Story\n* Nachiyan (なちやん) - Art\nTwitter: @morisita_suu", null, "森下", "suu", "Suu Morishita", "https://cdn.myanimelist.net/images/voiceactors/3/45177.jpg", "https://myanimelist.net/people/13521/Suu_Morishita", null },
                    { 13523, "Female\nBirthplace: Osaka, Japan\nZodiacs: Leo\nBlood type: B\nTwitter: @ag0NAOE\nInstagram: @ag0naoe", new DateTime(1992, 8, 21, 17, 0, 0, 0, DateTimeKind.Local), null, null, "NAOE", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13523/NAOE", null },
                    { 13689, "Doujin circle: RE:skey\n\nTwitter: @kinokokko\npixiv: #18758794", null, "木乃", "ひのき", "Hinoki Kino", "https://cdn.myanimelist.net/images/voiceactors/2/35383.jpg", "https://myanimelist.net/people/13689/Hinoki_Kino", null },
                    { 13691, "Twitter: @tomy_ogswr", null, "小笠原", "智史", "Tomofumi Ogasawara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13691/Tomofumi_Ogasawara", null },
                    { 13731, null, new DateTime(1976, 2, 19, 16, 0, 0, 0, DateTimeKind.Local), "鈴城", "芹", "Seri Suzushiro", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13731/Seri_Suzushiro", "http://seri.kalin.to/d-b-c/d-b-c.htm" },
                    { 13783, "Twitter: @watarai\npixiv: #6086", null, "渡会", "けいじ", "Keiji Watarai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13783/Keiji_Watarai", null },
                    { 13799, "Yuu Okazaki (岡崎 優) is a Japanese mangaka and a former member of Dynamic Production. His real name is Yoshihiro Okada (岡田 義弘), which he has used in some publications. His blood type is O. He was born on August 28, 1951 in Mie Prefecture, Japan. After finishing high school, he joined Dynamic Production and while working as Go Nagai's assistant, he debuted with Hello! Love for the Gakken Nakani Course magazine. His most representative work is the manga version of the anime Mobile Suit Gundam published from 1979-05 to 1980-02 by Akita Shoten in the magazine Boken Oh. He has also worked in some manga versions of Cutie Honey and UFO Robot Grendizer.\n\nIn the 1990s, after working in Josei manga, he took a break from manga publications which is still in effect.\n\n(Source: Wikipedia)", new DateTime(1951, 8, 27, 17, 0, 0, 0, DateTimeKind.Local), "岡崎", "優", "Yuu Okazaki", "https://cdn.myanimelist.net/images/voiceactors/1/77423.jpg", "https://myanimelist.net/people/13799/Yuu_Okazaki", null },
                    { 13805, "Twitter: @abara\npixiv: #15063", null, "肋", "兵器", "Heiki Abara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13805/Heiki_Abara", "http://kinokoisu.horemitakotoka.com/" },
                    { 13811, "Born April 14th in the Chiba Prefecture, Japan.\n\nAlso romanized as Izuco Fujiya.\n\nTwitter: calorieover", null, "藤屋", "いずこ", "Izuko Fujiya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13811/Izuko_Fujiya", null },
                    { 13833, "Twitter: @sansyokuamido\npixiv: #226272\n\nDoujin Circle: Reijin Kissa", null, "三色", "網戸。", "Amido. Sanshoku", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/13833/Amido_Sanshoku", "http://otomekibun.blog71.fc2.com/" },
                    { 14013, null, new DateTime(1978, 4, 10, 17, 0, 0, 0, DateTimeKind.Local), "鴨志田", "一", "Hajime Kamoshida", "https://cdn.myanimelist.net/images/voiceactors/1/80825.jpg", "https://myanimelist.net/people/14013/Hajime_Kamoshida", null },
                    { 14153, "Doujin circle: Picotama. (ぴこたま。)", null, "ヒロイチ", null, "Hiroichi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/14153/Hiroichi", "http://picotama.com/" },
                    { 14233, "Twitter: @koikenokuto", null, "小池", "ノクト", "Nokuto Koike", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/14233/Nokuto_Koike", null },
                    { 14271, "Birthplace: Tokyo\nGraduated from Waseda University.", null, "伊神", "貴世", "Takayo Ikami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/14271/Takayo_Ikami", null },
                    { 14297, "Twitter: @mmu_yoshikiti", null, "みしま", "ひろじ", "Hiroji Mishima", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/14297/Hiroji_Mishima", null },
                    { 14339, "Tomioka Atsuhiro was born November 25, 1967 in Japan. He is a professional screenwriter for anime, drama and theater and is a member of the Writers Guild of Japan.", new DateTime(1967, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), "冨岡", "淳広", "Atsuhiro Tomioka", "https://cdn.myanimelist.net/images/voiceactors/3/14747.jpg", "https://myanimelist.net/people/14339/Atsuhiro_Tomioka", null },
                    { 14347, null, null, "汐田", "晴人", "Haruto Shiota", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/14347/Haruto_Shiota", null },
                    { 14361, "Twitter: @nihonjipen", null, "池野", "雅博", "Masahiro Ikeno", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/14361/Masahiro_Ikeno", "http://nihonjipen.blogspot.com/" },
                    { 14717, null, new DateTime(1955, 9, 26, 17, 0, 0, 0, DateTimeKind.Local), "今野", "敏", "Bin Konno", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/14717/Bin_Konno", "http://www.age.ne.jp/x/b-konno/" },
                    { 14799, "Twitter: @miyama0", null, "みやま零", null, "Miyama-Zero", "https://cdn.myanimelist.net/images/voiceactors/2/46241.jpg", "https://myanimelist.net/people/14799/Miyama-Zero", "http://miyama0.dragon.gr.jp/" },
                    { 15063, "Birth place: Fukuoka Prefecture, Japan\n\nYuuki Tabata was previously an assistant under Toshiaki Iwashiro &amp; Ryuuhei Tamura", new DateTime(1984, 7, 29, 17, 0, 0, 0, DateTimeKind.Local), "田畠", "裕基", "Yuuki Tabata", "https://cdn.myanimelist.net/images/voiceactors/1/58942.jpg", "https://myanimelist.net/people/15063/Yuuki_Tabata", null },
                    { 15169, "Pen name: Momoko Sakura\nReal name: Miki Miura (三浦 美紀)\nHometown: Shimizu, Shizuoka Prefecture, Japan\nBlood type: A\n\nPassed away on August 15, 2018, due to breast cancer.", new DateTime(1965, 5, 7, 17, 0, 0, 0, DateTimeKind.Local), "さくら", "ももこ", "Momoko Sakura", "https://cdn.myanimelist.net/images/voiceactors/3/53410.jpg", "https://myanimelist.net/people/15169/Momoko_Sakura", "https://sakuraproduction.jp/" },
                    { 15227, null, null, "城崎", "火也", "Kaya Kizaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/15227/Kaya_Kizaki", null },
                    { 15279, "Twitter: @atu_osushi", new DateTime(1981, 12, 18, 16, 0, 0, 0, DateTimeKind.Local), "大場", "敦", "Atsushi Ooba", "https://cdn.myanimelist.net/images/voiceactors/2/16447.jpg", "https://myanimelist.net/people/15279/Atsushi_Ooba", null },
                    { 15293, null, null, "阿部", "暁子", "Akiko Abe", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/15293/Akiko_Abe", null },
                    { 15333, "Twitter: @sazanek", null, "細音", "啓", "Kei Sazane", "https://cdn.myanimelist.net/images/voiceactors/1/67255.jpg", "https://myanimelist.net/people/15333/Kei_Sazane", null },
                    { 15419, "Twitter: @torukei\npixiv: #191481", null, "戸流", "ケイ", "Kei Toru", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/15419/Kei_Toru", null },
                    { 15487, "Female\n\nTwitter: @gan0kyu\npixiv: #349014", null, "藍屋", "球", "Kyu Aiya", "https://cdn.myanimelist.net/images/voiceactors/2/81022.jpg", "https://myanimelist.net/people/15487/Kyu_Aiya", "http://aiyah.seesaa.net/" },
                    { 15505, null, null, "上栖", "綴人", "Tetsuto Uesu", "https://cdn.myanimelist.net/images/voiceactors/3/69222.jpg", "https://myanimelist.net/people/15505/Tetsuto_Uesu", null },
                    { 15517, null, new DateTime(1948, 3, 15, 16, 0, 0, 0, DateTimeKind.Local), "桜多", "吾作", "Gosaku Outa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/15517/Gosaku_Outa", null },
                    { 15523, "Twitter: @shimaso", null, "志摩", "時緒", "Tokio Shima", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/15523/Tokio_Shima", "http://shima.hacca.jp/" },
                    { 15591, null, null, "きたうみ", "つな", "Tsuna Kitaumi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/15591/Tsuna_Kitaumi", null },
                    { 15613, null, null, "佐島", "勤", "Tsutomu Satou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/15613/Tsutomu_Satou", "https://tsutomusato.jp/" },
                    { 15753, "Male\nBirthplace: Fukuoka Prefecture, Japan\n\nTwitter: @sotonami\nInstagram: @ishida_____sui", new DateTime(1986, 12, 27, 16, 0, 0, 0, DateTimeKind.Local), "石田", "スイ", "Sui Ishida", "https://cdn.myanimelist.net/images/voiceactors/3/37277.jpg", "https://myanimelist.net/people/15753/Sui_Ishida", null },
                    { 15763, "Male\nHometown: Osaka, Japan\n\nAssociated name: 高山憲弼 (same reading)\n\nTwitter: @sukisukimoricha\npixiv: #58119", null, "高山", "としのり", "Toshinori Takayama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/15763/Toshinori_Takayama", null },
                    { 15803, "Twitter: @honobu_yonezawa", null, "米澤", "穂信", "Honobu Yonezawa", "https://cdn.myanimelist.net/images/voiceactors/1/17627.jpg", "https://myanimelist.net/people/15803/Honobu_Yonezawa", null },
                    { 15991, null, null, "レツ", null, "Retsu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/15991/Retsu", null },
                    { 16255, "Twitter: @llo", null, "るろお", null, "LLO", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/16255/LLO", "http://homepage2.nifty.com/BWG/" },
                    { 16265, "Twitter: @yonedakazusa\npixiv: #770176", null, "米田", "和佐", "Kazusa Yoneda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/16265/Kazusa_Yoneda", "http://yonedakazusa.blog137.fc2.com/" },
                    { 16363, "Twitter: @oxfrog", null, "丸山", "トモヲ", "Tomoo Maruyama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/16363/Tomoo_Maruyama", "http://oxox.gozaru.jp/" },
                    { 16435, "Twitter: @hanabana_h04\npixiv: #225672", null, "華々", "つぼみ", "Tsubomi Hanabana", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/16435/Tsubomi_Hanabana", "http://atelier10colors.blog.fc2.com/" },
                    { 16485, "His older brother is Hiroyuki Takei.", null, "武井", "宏文", "Hirofumi Takei", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/16485/Hirofumi_Takei", null },
                    { 16529, "Twitter: @okayado1215\npixiv: #267014", new DateTime(1982, 12, 14, 16, 0, 0, 0, DateTimeKind.Local), "乾", "武丸", "Takemaru Inui", "https://cdn.myanimelist.net/images/voiceactors/3/44870.jpg", "https://myanimelist.net/people/16529/Takemaru_Inui", null },
                    { 16569, "Twitter: @hanaosutarou\npixiv: #28599", null, "華尾", "ス太郎", "Sutarou Hanao", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/16569/Sutarou_Hanao", "http://dangomusisyoutengai.blog28.fc2.com/" },
                    { 16573, "Twitter: @saitoro193", null, "サイトウ", "ケンジ", "Kenji Saitou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/16573/Kenji_Saitou", null },
                    { 16667, null, null, "虚秋", "左菱", "Sabishi Uroaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/16667/Sabishi_Uroaki", null },
                    { 16805, "Twitter: @IsII0512", null, "IsII", null, "IsII", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/16805/IsII", "http://totalchaos.blog26.fc2.com/" },
                    { 16859, "Birth place: Aichi Prefecture, Japan\nDoujin circle: Bisai'd\n\nTwitter: @chiruwo3\npixiv: #17774", new DateTime(1976, 9, 27, 17, 0, 0, 0, DateTimeKind.Local), "風華", "チルヲ", "Chiruwo Kazahana", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/16859/Chiruwo_Kazahana", "http://chiruwo.net" },
                    { 16993, "Twitter: @ONE_rakugaki", new DateTime(1986, 10, 28, 16, 0, 0, 0, DateTimeKind.Local), "ONE", null, "ONE", "https://cdn.myanimelist.net/images/voiceactors/1/66748.jpg", "https://myanimelist.net/people/16993/ONE", "http://galaxyheavyblow.web.fc2.com/" },
                    { 17031, "Twitter: @botekote", null, "菅原", "健二", "Kenji Sugawara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17031/Kenji_Sugawara", "http://botekote.blog.shinobi.jp/" },
                    { 17061, "Female\nTwitter: @ryota1302\npixiv: #330977\nYoutube Channel", null, "柚木", "涼太", "Ryouta Yuzuki", "https://cdn.myanimelist.net/images/voiceactors/1/61507.jpg", "https://myanimelist.net/people/17061/Ryouta_Yuzuki", "http://www.geocities.jp/kasanegirider/gyarando4/main.html" },
                    { 17271, "Doujin circle: Zenra Restaurant (全裸レストラン)\n\nTwitter: @heriyama\npixiv: #4733", null, "縁山", null, "Heriyama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17271/Heriyama", "http://restaurant001.blog.fc2.com/" },
                    { 17289, "Twitter: @rohgun_kyoh", null, "ROHGUN", null, "ROHGUN", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17289/ROHGUN", "http://www.ksky.ne.jp/~tsuchiya/" },
                    { 17335, "Doujin circle: Yaya Hinata-ya\n\nTwitter: @yayahinata\npixiv: #8925", null, "稍", "日向", "Hinata Yaya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17335/Hinata_Yaya", "http://yayahinata.exblog.jp/" },
                    { 17519, "Twitter: @kinknki", null, "季野", "このき", "Konoki Kino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17519/Konoki_Kino", "https://konokino.tumblr.com/" },
                    { 17555, "Twitter: @fukuhara_renji", null, "福原", "蓮士", "Renji Fukuhara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17555/Renji_Fukuhara", null },
                    { 17575, null, null, "YUI", null, "YUI", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17575/YUI", null },
                    { 17601, null, new DateTime(1990, 1, 13, 16, 0, 0, 0, DateTimeKind.Local), "石田", "可奈", "Kana Ishida", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17601/Kana_Ishida", null },
                    { 17647, "Male\n\nTwitter: @yuichi_hiiragi\n\npixiv: #2056601", null, "柊", "裕一", "Yuuichi Hiiragi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17647/Yuuichi_Hiiragi", "http://yuichihiiragi.blog135.fc2.com/" },
                    { 17651, "Twitter: @k_marudashi", null, "大石", "浩二", "Kouji Ooishi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17651/Kouji_Ooishi", null },
                    { 17769, "Twitter: @whogets\npixiv: #32669", null, "楓月", "誠", "Makoto Fuugetsu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17769/Makoto_Fuugetsu", "http://whogets.blog56.fc2.com/" },
                    { 17827, null, null, "宮永", "龍", "Ryu Miyanaga", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17827/Ryu_Miyanaga", null },
                    { 17857, "Previously worked as an assistant under Tsuyoshi Yasuda on the manga serial Over Drive.", null, "佐藤", "友生", "Yuuki Satou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17857/Yuuki_Satou", null },
                    { 17871, "Twitter: @edomondohonda3", null, "いたち", null, "Itachi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17871/Itachi", "https://3dt-itati.tumblr.com/" },
                    { 17885, "Twitter: @toyo_sao", null, "とよた", "瑣織", "Saori Toyota", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17885/Saori_Toyota", null },
                    { 17891, null, null, "中村", "貯子", "Tamako Nakamura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17891/Tamako_Nakamura", null },
                    { 17893, "Associated Names: Dangan Densetsu, Dangan Densetsu Laser\n\nTwitter: @TomoHirokawa\npixiv: #830274", null, "緋呂河", "とも", "Tomo Hirokawa", "https://cdn.myanimelist.net/images/voiceactors/1/20521.jpg", "https://myanimelist.net/people/17893/Tomo_Hirokawa", "http://www.sol.dti.ne.jp/~taketom/" },
                    { 17923, "Twitter: @nakasone_haiji, @kimurata_kuma\npixiv: #16527273", null, "中曽根", "ハイジ", "Haiji Nakasone", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17923/Haiji_Nakasone", null },
                    { 17933, "Doujin circle: Himitsu Kessha Shinseiki Doumei (秘密結社新世紀同盟)\nCurrent residence: Sapporo, Hokkaido, Japan\n\nTwitter: @drilljiru", null, "ドリル", "汁", "Jill Drill", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17933/Jill_Drill", "http://drilljiru.blog25.fc2.com/" },
                    { 17945, "Doujin circle: Moritto Samurai\n\nTwitter: @morimisaki\npixiv: #5631", null, "森", "みさき", "Misaki Mori", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/17945/Misaki_Mori", null },
                    { 18099, "Twitter: @amamiyoshikazu", null, "天望", "良一", "Yoshikazu Amami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18099/Yoshikazu_Amami", "http://amamiyoshikazu.seesaa.net/" },
                    { 18115, "Brith place: Miyagi prefecture, Japan\n\nTwitter: @toraya_takamasa", null, "虎哉", "孝征", "Takayuki Kosai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18115/Takayuki_Kosai", null },
                    { 18169, "Twitter: @refeia\npixiv: #4437", null, "refeia", null, "refeia", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18169/refeia", "http://q-orbit.jp/" },
                    { 18193, null, null, "南十", "字星", "Juusei Minami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18193/Juusei_Minami", null },
                    { 18215, null, null, "衣笠", "彰梧", "Shougo Kinugasa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18215/Shougo_Kinugasa", null },
                    { 18223, null, null, "今井", "哲也", "Tetsuya Imai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18223/Tetsuya_Imai", null },
                    { 18237, "Eguchi Hisashi is a Japanese manga artist. \n\nHe made his professional manga debut with Susume!! Pirates in the manga anthology Weekly Shonen Jump in 1977. Other notable works include Stop! Hibari-kun and, more recently, the gag series Charamono. Eguchi is married to Japanese idol Mizutani Mari (水谷麻里) in 1990.\n\n(Source: AniDB)\n\nTwitter: @Eguchinn", new DateTime(1956, 3, 28, 16, 0, 0, 0, DateTimeKind.Local), "江口", "寿史", "Hisashi Eguchi", "https://cdn.myanimelist.net/images/voiceactors/2/27751.jpg", "https://myanimelist.net/people/18237/Hisashi_Eguchi", null },
                    { 18249, "Birth place: Rishiri Island, Hokkaido, Japan\n\nJin, also known as Shizen no Teki-P (自然の敵P), is a sound producer, composer, and arranger from Japan.\n\nJin was influenced by his keyboardist uncle and started learning keyboard at the age of 6. He has also been influenced by bands such as THE BACK HORN and composers such as Satoru Kosaki.\n\nHe is a relatively new producer, having only been active since early 2011, but is quickly becoming well known. On September 30, 2011, Jin submitted the song \"Kagerou Days\" (カゲロウデイズ) to Nico Nico Douga. The song quickly gained popularity and has since been viewed more than 3,000,000 times.\n\nTwitter: @jin_jin_suruyo", new DateTime(1990, 10, 19, 17, 0, 0, 0, DateTimeKind.Local), "じん", null, "Jin", "https://cdn.myanimelist.net/images/voiceactors/1/25701.jpg", "https://myanimelist.net/people/18249/Jin", "http://jinjinsuruyo.blog.fc2.com/" },
                    { 18255, "Twitter: @moritakisetsu", new DateTime(1984, 4, 9, 17, 0, 0, 0, DateTimeKind.Local), "森田", "季節", "Kisetsu Morita", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18255/Kisetsu_Morita", "http://moritarail.blog108.fc2.com/" },
                    { 18277, null, null, "東山", "彰良", "Akira Higashiyama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18277/Akira_Higashiyama", null },
                    { 18351, "Male\n\nTwitter: @nagian\npixiv: #79280", null, "凪庵", null, "Nagian", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18351/Nagian", "http://yoroz.jp/" },
                    { 18357, "Himeno Michi is a Japanese animation artist and character designer. Her most famous work is on the TV series Saint Seiya.\n\nIn 1973 she began her collaboration with Araki Shingo working on Cutie Honey and went on to work at Toei Animation before forming Araki Productions with him in 1974. Together they have worked on many successful films and series. Typically, she works on the female characters while he works on the male.\n\nSome of her most remarkable successes are Lupin III (1977), Berusaiyu no Bara (The Rose of Versailles, 1979), Hana no Ko Lunlun (The Flower Child Lunlun, 1979), Ulysses 31 (produced 1980, released 1981), Muugen Kidou SSX (Arcadia of My Youth: Endless Orbit SSX, 1982), and the OVA versions of Fuuma no Kojirou (1991).\n\nInternational accreditation came with Saint Seiya (Knights of the Zodiac, 1986), for her elegant drawing style along with Araki's dynamic drawing style.\n\n(Source: AniDB)", null, "姫野", "美智", "Michi Himeno", "https://cdn.myanimelist.net/images/voiceactors/3/30543.jpg", "https://myanimelist.net/people/18357/Michi_Himeno", null },
                    { 18409, "Twitter: @92eda92", null, null, "九二枝", "Kunieda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18409/Kunieda", "http://kunieda.hungry.jp/" },
                    { 18411, null, null, "森", "夕", "Yu Mori", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18411/Yu_Mori", null },
                    { 18435, "Twitter: @oikawatoru", null, "及川", "徹", "Tooru Oikawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18435/Tooru_Oikawa", null },
                    { 18553, null, null, "ぽん酢", null, "ponz", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18553/ponz", "http://ponz.info/" },
                    { 18569, "Blood type: O\nBirth place: Nara Prefecture, Japan\n\nTwitter: @fumifumiko23235", new DateTime(1982, 8, 17, 17, 0, 0, 0, DateTimeKind.Local), "ふみ", "ふみこ", "Fumiko Fumi", "https://cdn.myanimelist.net/images/voiceactors/3/60464.jpg", "https://myanimelist.net/people/18569/Fumiko_Fumi", null },
                    { 18629, "Twitter: @RYUKNIGHT\npixiv: #54035\nFacebook: #100004917136473", null, "内藤", "隆", "Ryuu Naitou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18629/Ryuu_Naitou", "http://ryunaitou.jp/" },
                    { 18635, null, null, "矢島", "綾", "Aya Yajima", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18635/Aya_Yajima", null },
                    { 18681, "twitter @ mikahoney", null, "織衣", "美歌", "Mika Orie", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18681/Mika_Orie", null },
                    { 18693, "Twitter: @yooochika", null, "東條", "チカ", "Chika Toujou", "https://cdn.myanimelist.net/images/voiceactors/2/63230.jpg", "https://myanimelist.net/people/18693/Chika_Toujou", null },
                    { 18697, null, null, "井上", "大助", "Daisuke Inoue", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18697/Daisuke_Inoue", null },
                    { 18699, null, null, "守屋", "直樹", "Naoki Moriya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18699/Naoki_Moriya", null },
                    { 18705, null, null, "神野", "淳一", "Junichi Kamino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18705/Junichi_Kamino", null },
                    { 18707, "Twitter: @hiyon_k", null, "葛木", "ヒヨン", "Hiyon Katsuragi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18707/Hiyon_Katsuragi", null },
                    { 18709, "Male\nBlood type: A\n\nTwitter: @t_bau\npixiv: #95710", new DateTime(1979, 1, 17, 16, 0, 0, 0, DateTimeKind.Local), null, "ばう", "Bau", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18709/Bau", "http://nyuusankin8.symphonic-net.com/" },
                    { 18713, null, null, "中西", "寛", "Hiroshi Nakanishi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18713/Hiroshi_Nakanishi", null },
                    { 18715, null, null, "冬凪", "れく", "Reku Fuyunagi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18715/Reku_Fuyunagi", null },
                    { 18731, "twitter @ hau98540\n\nBirth place: Kanagawa prefecture, Japan\nFormer pen-name: 水元 昭嗣 [Mizumoto Akitsugu]", new DateTime(1973, 8, 11, 17, 0, 0, 0, DateTimeKind.Local), "水元", "あきつぐ", "Akitsugu Mizumoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18731/Akitsugu_Mizumoto", "http://ameblo.jp/hau98540/" },
                    { 18745, "Twitter: @tnsk\npixiv: #74093", new DateTime(1984, 6, 14, 17, 0, 0, 0, DateTimeKind.Local), "TNSK", null, "TNSK", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18745/TNSK", "http://tnsksp.blog.shinobi.jp" },
                    { 18757, "Twitter: @yadoya\npixiv: #68410", null, "宿屋", "続", "Tsuzuku Yadoya", "https://cdn.myanimelist.net/images/voiceactors/3/34785.jpg", "https://myanimelist.net/people/18757/Tsuzuku_Yadoya", null },
                    { 18791, null, new DateTime(1952, 2, 25, 16, 0, 0, 0, DateTimeKind.Local), "池原", "しげと", "Shigeto Ikehara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18791/Shigeto_Ikehara", null },
                    { 18801, "Twitter: @sui_sui_sei", null, "平林", "佐和子", "Sawako Hirabayashi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18801/Sawako_Hirabayashi", null },
                    { 18817, "pixiv: #770137", null, "みじんこうか", null, "Mijinkouka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18817/Mijinkouka", null },
                    { 18821, "Doujin Circle: BlueMage", null, "あおい", "まなぶ", "Manabu Aoi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/18821/Manabu_Aoi", "http://aoi.neko.ne.jp/" },
                    { 19049, null, new DateTime(1987, 12, 8, 16, 0, 0, 0, DateTimeKind.Local), "金城", "宗幸", "Muneyuki Kaneshiro", "https://cdn.myanimelist.net/images/voiceactors/3/65444.jpg", "https://myanimelist.net/people/19049/Muneyuki_Kaneshiro", null },
                    { 19051, null, null, "芝野", "郷太", "Kyouta Shibano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19051/Kyouta_Shibano", null },
                    { 19053, "Twitter: @DEART_Akeji\nInstagram: @deart_akeji\nYoutube: 藤村緋二", null, "藤村", "緋二", "Akeji Fujimura", "https://cdn.myanimelist.net/images/voiceactors/3/70082.jpg", "https://myanimelist.net/people/19053/Akeji_Fujimura", "https://deart.vip" },
                    { 19189, "Twitter: @kichijyouterae", null, "吉祥", "寺笑", "Terae Kichijou", "https://cdn.myanimelist.net/images/voiceactors/2/64568.jpg", "https://myanimelist.net/people/19189/Terae_Kichijou", "http://kitijyouterae.blog.shinobi.jp/" },
                    { 19197, "Twitter: @mishima_kurone", null, "三嶋", "くろね", "Kurone Mishima", "https://cdn.myanimelist.net/images/voiceactors/3/49010.jpg", "https://myanimelist.net/people/19197/Kurone_Mishima", "http://shiropro.com/" },
                    { 19271, "Twitter: @aokihayato", null, "青木", "ハヤト", "Hayato Aoki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19271/Hayato_Aoki", "http://aonoki.zouri.jp/" },
                    { 19277, "Twitter: @mamujin\npixiv: #10674", null, "山根", "真人", "Masato Yamane", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19277/Masato_Yamane", "http://yuki.cutegirl.jp/" },
                    { 19349, null, null, "真楠", null, "Max", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19349/Max", "http://hakoniwagakuen.web.fc2.com/home.html" },
                    { 19431, "Toyotarou has drawn Dragon Ball ever since he was young, always drawing it after breakfast.\n\nToyotarou was initially a doujinshi artist working under the name Toyble, and notable for creating a Dragon Ball AF manga in the 2000s. He was hired by Shueisha in 2012 when he requested being the one to draw Dragon Ball Super and debuted his career as an official manga artist under the name Toyotaru. He created the manga adaptation for the Dragon Ball Z anime 2015 film, Dragon Ball Z: Resurrection ‘F’, titled Dragon Ball Z: Resurrection ‘F’ - Special One Shot. Toyotaru drew two pages of Dragon Ball Super as demonstration, and Toriyama chose him as his successor.\n\nToyotarou is also the official artist of the manga version of Dragon Ball Super. As of the Universe Survival Saga Toyotarou has also become a character designer for Dragon Ball Super, creating designs either by himself or by working together with Toriyama. He also drew Dragon Ball Xenoverse 2 The Manga. \n\n(Source: Dragon Ball Wikia)", null, "とよたろう", null, "Toyotarou", "https://cdn.myanimelist.net/images/voiceactors/2/47037.jpg", "https://myanimelist.net/people/19431/Toyotarou", null },
                    { 19443, "Twitter: @SugaAtsushi", null, "須河", "篤志", "Atsushi Suga", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19443/Atsushi_Suga", "http://sawamonera.blog106.fc2.com/" },
                    { 19497, "She's the wife of mangaka Nobuhiro Watsuki.\n\nTwitter: @kaworu963", new DateTime(1969, 1, 25, 16, 0, 0, 0, DateTimeKind.Local), "黒碕", "薫", "Kaoru Kurosaki", "https://cdn.myanimelist.net/images/voiceactors/1/52630.jpg", "https://myanimelist.net/people/19497/Kaoru_Kurosaki", "http://ameblo.jp/kaworu-kurosaki/" },
                    { 19501, "Twitter: @th274", null, "葉月", "翼", "Tsubasa Hazuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19501/Tsubasa_Hazuki", "http://tubasa.moo.jp/" },
                    { 19507, "Twitter: @afro_2021", null, "あfろ", null, "Afro", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19507/Afro", null },
                    { 19523, "Twitter: @yusukeshiba\npixiv: #4197", null, "シバ", "ユウスケ", "Yuusuke Shiba", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19523/Yuusuke_Shiba", "http://polyzm.mods.jp/" },
                    { 19551, null, null, "三好", "輝", "Hikaru Miyoshi", "https://cdn.myanimelist.net/images/voiceactors/1/69130.jpg", "https://myanimelist.net/people/19551/Hikaru_Miyoshi", "http://03-h.main.jp/" },
                    { 19649, null, null, "桐野", "壱", "Hajime Kirino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19649/Hajime_Kirino", null },
                    { 19695, "Twitter: @yoshino_sr", null, "吉乃", "そら", "Sora Yoshino", "https://cdn.myanimelist.net/images/voiceactors/1/22369.jpg", "https://myanimelist.net/people/19695/Sora_Yoshino", null },
                    { 19699, "Doujin circle: Momo no Kazume\n\nTwitter: @nanamomorio\npixiv: #48434", null, "七桃", "りお", "Rio Nanamomo", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19699/Rio_Nanamomo", null },
                    { 19719, "He is at present, employed by nitro+.\n\nTwitter: @nino_haji", null, "一", "肇", "Hajime Ninomae", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19719/Hajime_Ninomae", null },
                    { 19721, null, null, "蕗野", "冬", "Tou Fukino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19721/Tou_Fukino", null },
                    { 19755, null, null, "空木", "あんぐ", "Angu Utsurogi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19755/Angu_Utsurogi", null },
                    { 19791, "Twitter: @tsukudayuto", new DateTime(1986, 3, 12, 16, 0, 0, 0, DateTimeKind.Local), "附田", "祐斗", "Yuuto Tsukuda", "https://cdn.myanimelist.net/images/voiceactors/1/38951.jpg", "https://myanimelist.net/people/19791/Yuuto_Tsukuda", null },
                    { 19864, "Twitter: @ao000", null, "あおぎり", null, "Aogiri", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/19864/Aogiri", "http://ctog.web.fc2.com/" },
                    { 19926, "Born in Fukushima Prefecture, Japan.\nCurrently resides in Tokyo.", new DateTime(1959, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), "佐藤", "元", "Gen Satou", "https://cdn.myanimelist.net/images/voiceactors/3/22415.jpg", "https://myanimelist.net/people/19926/Gen_Satou", "http://riorio.chu.jp/" },
                    { 20150, "Twitter: @moriairi\npixiv: #4503245", null, "森", "あいり", "Airi Mori", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/20150/Airi_Mori", "http://mori.skr.jp/" },
                    { 20152, "Twitter: @_kamaboko_", null, "かまぼこ", "RED", "Red Kamaboko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/20152/Red_Kamaboko", "http://glamro.x.fc2.com/" },
                    { 20176, "Twitter: @_saburouta", null, "サブロウタ", null, "Saburouta", "https://cdn.myanimelist.net/images/voiceactors/3/43867.jpg", "https://myanimelist.net/people/20176/Saburouta", null },
                    { 20182, null, null, "鷹見", "一幸", "Kazuyuki Takami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/20182/Kazuyuki_Takami", null },
                    { 20186, "Twitter: @hagure_KeG\npixiv: #210847", null, "KeG", null, "KeG", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/20186/KeG", "http://www009.upp.so-net.ne.jp/keg/" },
                    { 20611, "Doujin circle: Hyaluron (ひあるろん)\n\nTwitter: @chamasuke", null, "茶麻", null, "Chama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/20611/Chama", "http://chama.chottu.net/index.html" },
                    { 20649, "Twitter: @yasabata\npixiv: #212577", new DateTime(1979, 6, 1, 17, 0, 0, 0, DateTimeKind.Local), "竹林", "月", "Getsu Takebayashi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/20649/Getsu_Takebayashi", "http://www1.odn.ne.jp/~cer89860/" },
                    { 20727, "Twitter: @arg15ayn", null, "あららぎ", "あゆね", "Ayune Araragi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/20727/Ayune_Araragi", "http://arrgayn.6.ql.bz/" },
                    { 20777, null, null, "沙雪", null, "Sayuki", "https://cdn.myanimelist.net/images/voiceactors/1/49739.jpg", "https://myanimelist.net/people/20777/Sayuki", null },
                    { 20863, "Doujin circle: TABLET\n\nTwitter: @ginta_tablet\npixiv: #714108", null, "ぎん太", null, "Ginta", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/20863/Ginta", null },
                    { 20893, null, null, "浅井", "信悟", "Shingo Asai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/20893/Shingo_Asai", null },
                    { 21095, "Twitter: @odcham\npixiv: #6728357", null, "オオハ", "マイコ", "Maiko Ooha", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/21095/Maiko_Ooha", "http://odcmanga2.blog.fc2.com/" },
                    { 21131, null, null, "吉村", "工", "Takumi Yoshimura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/21131/Takumi_Yoshimura", null },
                    { 21273, "Birthplace: Aichi Prefecture, Japan\n\nShe was the illustrator for the Pokémon Special manga until volume 9. She stopped drawing for the series due to an illness which left her hand weak and unable to draw, leading Satoshi Yamamoto to take over her position from volume 10 onward.\n\nTwitter: @matobook2016", null, null, "真斗", "Mato", "https://cdn.myanimelist.net/images/voiceactors/1/64627.jpg", "https://myanimelist.net/people/21273/Mato", "http://www1.odn.ne.jp/ginta/mato/" },
                    { 21323, "Tomoyo Kamoi is part of the 11th group of students to enter Kyoto Animation animator training course and went on to work for the company upon graduation. Now a freelancer, often working with other animators who have left KyoAni.", null, "鴨居", "知世", "Tomoyo Kamoi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/21323/Tomoyo_Kamoi", null },
                    { 21509, "Doujin Circle: Mushaburu\n\nTwitter: @musyasabu\npixiv: #2526989", null, "武者", "サブ", "Sabu Musha", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/21509/Sabu_Musha", "http://mushaburu.blog.fc2.com/" },
                    { 21681, "Twitter: @tsuyoshi_wtnb", null, "渡辺", "つよし", "Tsuyoshi Watanabe", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/21681/Tsuyoshi_Watanabe", null },
                    { 21731, null, null, "大山", "タクミ", "Takumi Ooyama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/21731/Takumi_Ooyama", null },
                    { 21763, "Twitter: @kazumi_hoshi", null, "星", "和弥", "Kazumi Hoshi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/21763/Kazumi_Hoshi", null },
                    { 21791, "Twitter: @T_nagomu", null, "鳥居", "なごむ", "Nagomu Torii", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/21791/Nagomu_Torii", "http://novel21.web.fc2.com" },
                    { 21829, null, null, "松浦", "まさふみ", "Masafumi Matsuura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/21829/Masafumi_Matsuura", "http://ameblo.jp/matsuurama/" },
                    { 21995, null, null, "大崎", "知仁", "Tomohito Oosaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/21995/Tomohito_Oosaki", null },
                    { 22125, "Doujin circle: PANDANIKU (with Namaniku ATK)\n\nTwitter: @panda_ookuma", null, "大熊", "猫介", "Nekosuke Ookuma", "https://cdn.myanimelist.net/images/voiceactors/1/68091.jpg", "https://myanimelist.net/people/22125/Nekosuke_Ookuma", "http://www.nitroplus.co.jp/staff/blog/author_22/" },
                    { 22165, "Twitter: @omoiomoutori\npixiv: #9877157", null, "深山", "フギン", "Fugin Miyama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22165/Fugin_Miyama", "http://miyama-h.tumblr.com/" },
                    { 22167, "Twitter: @nesuseijin", null, "中村", "充志", "Atsushi Nakamura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22167/Atsushi_Nakamura", null },
                    { 22171, "Gender: Female", null, "九井", "諒子", "Ryouko Kui", "https://cdn.myanimelist.net/images/voiceactors/3/70580.jpg", "https://myanimelist.net/people/22171/Ryouko_Kui", "http://nisiryu.blogspot.com/" },
                    { 22191, null, null, "柊", "たくみ", "Takumi Hiiragiboshi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22191/Takumi_Hiiragiboshi", null },
                    { 22207, null, null, "浅葉", "ゆう", "Yuu Asaba", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22207/Yuu_Asaba", null },
                    { 22227, "Doujin circle: WIREFRAME\n\nTwitter: @yuukihagure\npixiv: #10920", null, "憂姫", "はぐれ", "Hagure Yuuki", "https://cdn.myanimelist.net/images/voiceactors/1/25613.jpg", "https://myanimelist.net/people/22227/Hagure_Yuuki", "http://wireframe.sakura.ne.jp/" },
                    { 22231, "Twitter: @misaki_cradle\n\nBirth place: Hokkaido", null, "深崎", "暮人", "Kurehito Misaki", "https://cdn.myanimelist.net/images/voiceactors/1/27571.jpg", "https://myanimelist.net/people/22231/Kurehito_Misaki", "http://cradle.cc/" },
                    { 22235, "Current residence: Yamaguchi prefecture\n\nTwitter: @neet61\npixiv: #44860\nTwitch: neet61", new DateTime(1990, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "にぃと", null, "Neet", "https://cdn.myanimelist.net/images/voiceactors/3/74736.jpg", "https://myanimelist.net/people/22235/Neet", "https://www.neet61.net/" },
                    { 22237, "Birth place: Nagoya, Aichi-ken, Japan\nBlood type: AB\n\nHe is the original scenario writer for the visual novel of White Album 2.\n\nTwitter: @F_Maruto_staff", null, "丸戸", "史明", "Fumiaki Maruto", "https://cdn.myanimelist.net/images/voiceactors/3/42107.jpg", "https://myanimelist.net/people/22237/Fumiaki_Maruto", null },
                    { 22261, "Twitter: @Andrias_jap", null, "久", "正人", "Masato Hisa", "https://cdn.myanimelist.net/images/voiceactors/2/27143.jpg", "https://myanimelist.net/people/22261/Masato_Hisa", "http://oviraptor.blog103.fc2.com/" },
                    { 22323, "A mangaka duo consisting of writer and designer Nori (のり) and artist Hisshi (ひっし), who were former assistants of Saitou Pro, the manga studio of Takao Saitou.\n\nDoujin circle: Mayoibashi (まよいばし)\n\nTwitter: @somatoma\npixiv: #422553\nFanbox: @somato", null, "ソウマトウ", null, "Soumatou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22323/Soumatou", "http://so-ma-to.com/" },
                    { 22431, "Birth place: Hirakata, Osaka, Japan\n\nTwitter: @keiichisennsei", new DateTime(1962, 4, 3, 17, 0, 0, 0, DateTimeKind.Local), "田中", "圭一", "Keiichi Tanaka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22431/Keiichi_Tanaka", null },
                    { 22471, "Doujin circle: Ponpon-O (ぽんぽんお)\n\npixiv: #131958", null, "マウンテンプクイチ", null, "Mountain Pukuichi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22471/Mountain_Pukuichi", "http://ponpondao.blog10.fc2.com" },
                    { 22495, "Twitter: @kreona\npixiv: #1212304", null, "海月", "れおな", "Reona Umitsuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22495/Reona_Umitsuki", "http://reonaya.web.fc2.com/" },
                    { 22575, "Koyama Takao is a screenwriter and novelist. Born in in Akishima, Tokyo.\n\nAfter graduating from Waseda University he joined Tatsunoko Production on March of 1972, but left the company on August of 1975 and became a freelance. He actived as 小山 高男 (Koyama Takao) until 1987.\n\n(Source: AniDB)", new DateTime(1948, 4, 20, 17, 0, 0, 0, DateTimeKind.Local), "小山", "高生", "Takao Koyama", "https://cdn.myanimelist.net/images/voiceactors/1/25971.jpg", "https://myanimelist.net/people/22575/Takao_Koyama", null },
                    { 22603, "Twitter: @naruti06\nPixiv: #115570", new DateTime(1978, 6, 14, 17, 0, 0, 0, DateTimeKind.Local), "成瀬", "ちさと", "Chisato Naruse", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22603/Chisato_Naruse", "http://www.tanpopoya.com/" },
                    { 22605, "Twitter: @Morihashi", new DateTime(1979, 3, 1, 16, 0, 0, 0, DateTimeKind.Local), "森橋", "ビンゴ", "Bingo Morihashi", "https://cdn.myanimelist.net/images/voiceactors/3/48720.jpg", "https://myanimelist.net/people/22605/Bingo_Morihashi", "http://menthol-baby.ameblo.jp" },
                    { 22631, "Twitter: @_chida_\nTumblr: @cdeight\nOld blog: http://zrhc.blog136.fc2.com/", null, "千田", "衛人", "Eight Chida", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22631/Eight_Chida", null },
                    { 22681, "Doujin circle: Gutsutoma (ぐつとま)\n\nTwitter: @tt_tachi\npixiv: #1148816", null, null, "タチ", "Tachi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22681/Tachi", "http://tachi.anime-life.com" },
                    { 22695, null, null, "宮", "昌太朗", "Shoutarou Miya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22695/Shoutarou_Miya", null },
                    { 22697, null, null, "大塚", "ギチ", "Gichi Ootsuka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22697/Gichi_Ootsuka", null },
                    { 22709, "Twitter: @Strangestone\npixiv: #1119201", null, "比村", "奇石", "Kiseki Himura", "https://cdn.myanimelist.net/images/voiceactors/2/62934.jpg", "https://myanimelist.net/people/22709/Kiseki_Himura", "http://www10.plala.or.jp/strangestone" },
                    { 22733, "Twitter: @mina_naya", null, "水鳥", "なや", "Naya Minadori", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22733/Naya_Minadori", "http://banakure.silk.to/" },
                    { 22737, "Twitter: @m_ztm\npixiv: #350637", null, "ミズタマ", null, "Mizutama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22737/Mizutama", "http://tinam1zu.blog35.fc2.com/" },
                    { 22865, "Twitter: @mizunomoto", null, "みずの", "もと", "Moto Mizuno", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22865/Moto_Mizuno", null },
                    { 22889, "pixiv: #10295437", new DateTime(1977, 5, 28, 17, 0, 0, 0, DateTimeKind.Local), "大", "亜門", "Amon Dai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/22889/Amon_Dai", "http://daiamon.main.jp/" },
                    { 23109, "Twitter: @c_l_o_b_a\npixiv: #438470", null, "くろば・U", null, "cloba.U", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/23109/clobaU", "http://zenpo-huchui.com/" },
                    { 23155, "Twitter: @4wdTM1L6xIQVsEf", new DateTime(1975, 3, 12, 16, 0, 0, 0, DateTimeKind.Local), "真野", "勝成", "Katsunari Mano", "https://cdn.myanimelist.net/images/voiceactors/2/66650.jpg", "https://myanimelist.net/people/23155/Katsunari_Mano", null },
                    { 23279, "Twitter: @kumichooooo", null, "くみちょう", null, "Kumichou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/23279/Kumichou", "http://kumichoudayo.blog.fc2.com/" },
                    { 23289, null, null, "村上", "としや", "Toshiya Murakami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/23289/Toshiya_Murakami", null },
                    { 23349, null, null, "黒銀", null, "Kurogin", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/23349/Kurogin", "http://darksilver23.fc2web.com/" },
                    { 23443, "Twitter: @tukasa0815", null, "ツカサ", null, "Tsukasa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/23443/Tsukasa", null },
                    { 23473, "Birth place: Kurume, Fukuoka prefecture, Japan", null, "矢野", "隆", "Takashi Yano", "https://cdn.myanimelist.net/images/voiceactors/3/26535.jpg", "https://myanimelist.net/people/23473/Takashi_Yano", null },
                    { 23505, null, null, "佐野", "愛莉", "Airi Sano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/23505/Airi_Sano", null },
                    { 23621, "Twitter: @tuge_neko\npixiv: #43359", null, "tugeneko", null, "tugeneko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/23621/tugeneko", null },
                    { 23699, "Male\nBlood type: B\n\nTwitter: @atsuon38\npixiv: #198074", null, "内山", "敦司", "Atsushi Uchiyama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/23699/Atsushi_Uchiyama", "http://e0005.blog41.fc2.com/" },
                    { 23771, "Yuuji Kaku was previously an assistant to Tatsuki Fujimoto. Kaku also worked as an editor at Akita Shoten. \n\nTwitter: @ug_kaku", null, "賀来", "ゆうじ", "Yuuji Kaku", "https://cdn.myanimelist.net/images/voiceactors/1/66256.jpg", "https://myanimelist.net/people/23771/Yuuji_Kaku", null },
                    { 23829, null, null, "山田", "鐘人", "Kanehito Yamada", "https://cdn.myanimelist.net/images/voiceactors/2/77991.jpg", "https://myanimelist.net/people/23829/Kanehito_Yamada", null },
                    { 23955, null, null, "羽仁倉", "雲", "Un Hanikura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/23955/Un_Hanikura", null },
                    { 24067, null, null, "おおじ", "こうじ", "Kouji Ooji", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/24067/Kouji_Ooji", null },
                    { 24201, "Twitter: @shakkosan", null, "あわむら", "赤光", "Akamitsu Awamura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/24201/Akamitsu_Awamura", "http://awamura.blog88.fc2.com/" },
                    { 24221, "Muchimuchi Puririn was his handle name when he first posted Overlord on the website. Subsequently, he changed his pseudonym to Kugane Maruyama when Overlord got published; he didn't want readers to cast strange eyes when purchasing Overlord since Muchimuchi Puririn means \"blubbery fatty.\"\n\nHis short story Dawn has been adapted in Kagetsu Tohya which is Type-Moon's sequel to their earlier doujin visual novel game, Tsukihime, released in August 2001.\n\nEven Nasu Kinoko, the writer of Fate/stay night, praised his work but Maruyama gave up the dream of becoming a writer because he felt the difference in talent between Nasu and himself.\n\nHe is a big fan of the Dungeon and Dragons game. One of the reason he started writing again was all of his DnD buddies were too busy to play with him.\n\nTwitter: @maruyama_kugane", null, "丸山", "くがね", "Kugane Maruyama", "https://cdn.myanimelist.net/images/voiceactors/1/59170.jpg", "https://myanimelist.net/people/24221/Kugane_Maruyama", null },
                    { 24291, null, null, "山上", "正月", "Masatsuki Yamakami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/24291/Masatsuki_Yamakami", null },
                    { 24327, null, null, "井藤", "ななみ", "Nanami Itou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/24327/Nanami_Itou", null },
                    { 24365, "Twitter: @tamori_tadadi\npixiv: #3885265", null, "たもり", "ただぢ", "Tadadi Tamori", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/24365/Tadadi_Tamori", "http://tamoritadadi.blogspot.com/" },
                    { 24371, "Twitter: @koyuki_now", null, "こゆき", null, "Koyuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/24371/Koyuki", null },
                    { 24379, "Twitter: @kafkaasagiri", new DateTime(1984, 3, 16, 16, 0, 0, 0, DateTimeKind.Local), "朝霧", "カフカ", "Kafka Asagiri", "https://cdn.myanimelist.net/images/voiceactors/1/59553.jpg", "https://myanimelist.net/people/24379/Kafka_Asagiri", null },
                    { 24385, null, null, "遠藤", "明範", "Akinori Endo", "https://cdn.myanimelist.net/images/voiceactors/2/71882.jpg", "https://myanimelist.net/people/24385/Akinori_Endo", null },
                    { 24471, "Twitter: @fujinoomori", null, "大森", "藤ノ", "Fujino Omori", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/24471/Fujino_Omori", null },
                    { 24493, null, null, "rin", null, "rin", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/24493/rin", null },
                    { 24539, "Female\nBirth place: Hyougo prefecture, Japan\nBlood type: A", null, "西村", "キヌ", "Kinu Nishimura", "https://cdn.myanimelist.net/images/voiceactors/1/40804.jpg", "https://myanimelist.net/people/24539/Kinu_Nishimura", null },
                    { 24569, "Twitter: @akafujipiyokoo1", null, "あかまる", null, "Akamaru", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/24569/Akamaru", null },
                    { 24891, null, null, "ムラ", "黒江", "Kuroe Mura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/24891/Kuroe_Mura", null },
                    { 24923, "Doujin circle: Nilitsuhaihan\n\nTwitter: @ann_nh\npixiv: #25594", null, "ニリツ", null, "Nilitsu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/24923/Nilitsu", "http://nilitsu.com" },
                    { 25009, "Blood type: A\n\nTwitter: @nanashirogorou\npixiv: #3404678", null, "弐尉", "マルコ", "Marco Nii", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25009/Marco_Nii", null },
                    { 25091, "Twitter: @miyakokasiwa\n\nDoujin Circle: Spunk!", null, "かしわ", "よしお", "Miyako Kashiwa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25091/Miyako_Kashiwa", "http://miyakokasiwa.sblo.jp/" },
                    { 25135, "Doujin circle: Neko no Onsen\n\nTwitter: @nyanya_\npixiv: #195891", null, "nyanya", null, "nyanya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25135/nyanya", "http://nyanyaling.exblog.jp/" },
                    { 25221, "Blog: http://blog.livedoor.jp/kotohanokotonoha/\nTwitter: @oshirase_gan\npixiv: #1294530", null, "GAN", null, "GAN", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25221/GAN", "http://www.aa.alpha-net.ne.jp/hakumura/" },
                    { 25239, "Twitter: @atminoru", null, "佐々木", "ミノル", "Minoru Sasaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25239/Minoru_Sasaki", null },
                    { 25251, "Doujin circle: Igaiga (イガイガ)\n\nTwitter: @yugaiga\npixiv: #577341", null, "高内", "優向", "Yuuga Takauchi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25251/Yuuga_Takauchi", "http://iga2.web.fc2.com/" },
                    { 25281, null, null, "中目黒", "さくら", "Sakura Nakameguro", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25281/Sakura_Nakameguro", null },
                    { 25391, "Doujin circle: Gyokuro Meshi (玉露飯)\n\npixiv: #269664", null, "方密", null, "Houmitsu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25391/Houmitsu", "http://www.houmitsu.net/blog/" },
                    { 25491, "Twitter: @sow_LIBRA11", null, "SOW", null, "SOW", "https://cdn.myanimelist.net/images/voiceactors/1/49473.jpg", "https://myanimelist.net/people/25491/SOW", null },
                    { 25685, null, null, "錦", "ソクラ", "Sokura Nishiki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25685/Sokura_Nishiki", null },
                    { 25883, null, null, "こにし", "ひろし", "Hiroshi Konishi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25883/Hiroshi_Konishi", null },
                    { 25887, "Twitter: @y_nagii\npixiv: #183703", null, "夕薙", null, "Yuunagi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25887/Yuunagi", "http://sth.kuchinawa.com" },
                    { 25969, "Twitter: @NaMelanza", null, "日向", "夏", "Natsu Hyuuga", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25969/Natsu_Hyuuga", null },
                    { 25997, "Blood type: O\nBirth place: Kanuma, Tochigi Prefecture, Japan", new DateTime(1961, 3, 21, 16, 0, 0, 0, DateTimeKind.Local), "大貫", "健一", "Kenichi Oonuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/25997/Kenichi_Oonuki", "http://www.ekakiyahonpo.com/" },
                    { 26031, "Female\nCurrent residence: Hokkaido, Japan\n\nTwitter: @000hacchi\npixiv: #3918766", null, "八条", "新", "Arata Hachijou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/26031/Arata_Hachijou", null },
                    { 26099, "Twitter: @sotok", null, "そと", null, "Soto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/26099/Soto", null },
                    { 26171, "Twitter: @mizusawasyo", null, "水沢", "翔", "Sho Mizusawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/26171/Sho_Mizusawa", null },
                    { 26179, "Twitter: @8kaichi", null, "ウダ", "ノゾミ", "Nozomi Uda", "https://cdn.myanimelist.net/images/voiceactors/2/55700.jpg", "https://myanimelist.net/people/26179/Nozomi_Uda", null },
                    { 26291, "Twitter: @kinnikutarou\npixiv: #11683", null, "筋肉☆太郎", null, "Kinniku☆Tarou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/26291/Kinniku☆Tarou", null },
                    { 26303, "Twitter: @akatsukioffici3", null, "暁", "なつめ", "Natsume Akatsuki", "https://cdn.myanimelist.net/images/voiceactors/2/62171.jpg", "https://myanimelist.net/people/26303/Natsume_Akatsuki", "http://natsumeakatsuki.blog.fc2.com/index.php" },
                    { 26407, null, null, "後藤", "みどり", "Midori Gotou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/26407/Midori_Gotou", null },
                    { 26679, "Twitter: @wakipedia", null, "依河", "和希", "Waki Ikawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/26679/Waki_Ikawa", "http://audume.com/" },
                    { 26799, "Twitter: @h_sakura\n\nHikaru was formerly an in-house writer for the eroge company Liar-soft.", null, "桜井", "光", "Hikaru Sakurai", "https://cdn.myanimelist.net/images/voiceactors/3/29003.jpg", "https://myanimelist.net/people/26799/Hikaru_Sakurai", "http://sakuraihikaru.com/" },
                    { 26893, null, null, null, "ぜん", "Zen", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/26893/Zen", null },
                    { 27011, null, null, "渡瀬", "草一郎", "Souichirou Watase", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/27011/Souichirou_Watase", null },
                    { 27093, "Male\nBlood type: AB\nBirthplace: Saitama prefecture, Japan\n\nTwitter: @odamasa", null, "おだ", "まさる", "Masaru Oda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/27093/Masaru_Oda", "http://oda.soregashi.com/" },
                    { 27167, "Twitter: @kayou_bi", null, "火曜", null, "Kayou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/27167/Kayou", null },
                    { 27209, "Twitter: @nekono_siri", null, "乃花", "タツ", "Tatsu Nohana", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/27209/Tatsu_Nohana", "http://heyaneko2.blog32.fc2.com/" },
                    { 27235, "Twitter: @yanagitamazo", null, "八薙", "玉造", "Tamazo Yanagi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/27235/Tamazo_Yanagi", null },
                    { 27517, "pixiv: #604755\nTwitter: @kamabokoita", null, "キナコ", null, "Kinako", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/27517/Kinako", "http://marubotan.jimdo.com/" },
                    { 27561, null, null, "長谷川", "智広", "Tomohiro Hasegawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/27561/Tomohiro_Hasegawa", null },
                    { 27721, "Doujin circle: SOLOIST\n\nTwitter: @rivleaf\npixiv: #64821", null, "Riv", null, "Riv", "https://cdn.myanimelist.net/images/voiceactors/2/71674.jpg", "https://myanimelist.net/people/27721/Riv", "http://www.soloist.tw/" },
                    { 27741, "Twitter: @higejam3\npixiv: #167652", null, "ヒゲ", null, "Hige", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/27741/Hige", "http://gumumee.blog21.fc2.com/" },
                    { 27935, "He helped writing scenario for several visual novels created mostly by Liar-soft.\n\nTwitter: @J_Myougaya", null, "木村", "航", "Kou Kimura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/27935/Kou_Kimura", null },
                    { 28017, null, null, "関西", "リョウジ", "Ryouji Kansai", "https://cdn.myanimelist.net/images/voiceactors/2/45876.jpg", "https://myanimelist.net/people/28017/Ryouji_Kansai", null },
                    { 28223, "Doujin circle: Kikurage-ya (きくらげ屋)\n\nTwitter: @kikuragenet\npixiv: #2323358", null, "きくらげ", null, "Kikurage", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/28223/Kikurage", "http://kikuragenet.matrix.jp/" },
                    { 28371, "Associated name: ASTROGUY II\nCircle: Mushi Musume Aikoukai (蟲娘愛好会)\n\nTwitter: @astro_guy2", null, "仲村", "ユキトシ", "Yukitoshi Nakamura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/28371/Yukitoshi_Nakamura", "http://www5f.biglobe.ne.jp/~astro/" },
                    { 28403, null, null, "田中", "創", "Hajime Tanaka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/28403/Hajime_Tanaka", null },
                    { 28661, "Twitter: @okushou", new DateTime(1992, 4, 8, 17, 0, 0, 0, DateTimeKind.Local), "オクショウ", null, "Okushou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/28661/Okushou", "http://www.okushou.com/" },
                    { 28771, "Twitter: @Stand_River_T", null, "今ノ夜", "きよし", "Kiyoshi Konoya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/28771/Kiyoshi_Konoya", "http://www.geocities.jp/bluewind_sr/" },
                    { 28883, "Twitter: @kamonari\npixiv: #77039", null, "鴨鳴", "アヒル", "Ahiru Kamonari", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/28883/Ahiru_Kamonari", "http://www4.kcn.ne.jp/~yomogi/" },
                    { 28977, "Twitter: @h_tamura\npixiv: #21592", null, "田村", "ヒロ", "Hiro Tamura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/28977/Hiro_Tamura", "http://star198.gozaru.jp/" },
                    { 29133, null, null, "小野寺", "丈", "Jou Onodera", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29133/Jou_Onodera", null },
                    { 29149, "Twitter: @akka_1172", null, "akka", null, "akka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29149/akka", "https://akka-works.tumblr.com/" },
                    { 29289, "Aohachi Yoshinobu is an animator and animation director.", null, "青鉢", "芳信", "Yoshinobu Aohachi", "https://cdn.myanimelist.net/images/voiceactors/1/76965.jpg", "https://myanimelist.net/people/29289/Yoshinobu_Aohachi", null },
                    { 29309, "Doujin circle: xoxomelon\n\nTwitter: @xoxomelon\npixiv: #1358951", null, "ぺけ", null, "Peke", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29309/Peke", "http://xoxomelon.moo.jp/" },
                    { 29371, "Birth place: Miyakojima, Okinawa Prefecture, Japan\n\nRyou Nakama is a fan of gag manga, such as Gag Manga Biyori, Seikimatsu Leader Den Takeshi!, and Tottemo! Luckyman. He attended Okinawa Prefectural University of Arts but dropped out in 2012 in order to become a mangaka.\n\nHe is a childhood friend of mangaka Cota Tomimura from elementary school.\n\nTwitter: @nkm_ryo", new DateTime(1990, 8, 28, 17, 0, 0, 0, DateTimeKind.Local), "仲間", "りょう", "Ryou Nakama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29371/Ryou_Nakama", null },
                    { 29403, null, null, "アネコ", "ユサギ", "Yusagi Aneko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29403/Yusagi_Aneko", null },
                    { 29405, "Twitter: @Minami_Seira\npixiv: #1016432", null, "弥南", "せいら", "Seira Minami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29405/Seira_Minami", "http://members3.jcom.home.ne.jp/liberation-zone/" },
                    { 29455, "Doujin circle: Bronco Hitoritabi (ブロンコ一人旅)\n\nTwitter: @keyaki0202\npixiv: #557089", null, "内々", "けやき", "Keyaki Uchiuchi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29455/Keyaki_Uchiuchi", "http://park11.wakwak.com/~uma/" },
                    { 29487, "Associated names: Hagiwara Lazy, 麗憂魅\n\nTwitter: @hgwr_lzy", null, "萩原", "玲二", "Reiji Hagiwara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29487/Reiji_Hagiwara", "http://blog.goo.ne.jp/hagiwaral" },
                    { 29509, "Twitter: @Hiroki_PLT\npixiv: #4678420", null, "緒原", "博綺", "Hiroki Ohara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29509/Hiroki_Ohara", "http://p-l-t-works.blogspot.jp/" },
                    { 29539, null, null, null, "むねきち", "Munekichi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29539/Munekichi", "http://www.k3.dion.ne.jp/~ulm0/" },
                    { 29559, null, null, "ひなた", "しょう", "Shou Hinata", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29559/Shou_Hinata", null },
                    { 29603, "Twitter: @fumihirokiso", null, "木曽", "フミヒロ", "Fumihiro Kiso", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/29603/Fumihiro_Kiso", "https://flog0919.blog.fc2.com/" },
                    { 29745, "Twitter: @wannyanpu_ppp\npixiv: #4048471", null, null, "わんにゃんぷー", "Wannyanpu", "https://cdn.myanimelist.net/images/voiceactors/1/40581.jpg", "https://myanimelist.net/people/29745/Wannyanpu", null },
                    { 30507, null, null, "中北", "晃二", "Kouji Nakakita", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30507/Kouji_Nakakita", null },
                    { 30543, "Male\n\nTwitter: @kanihamiso\npixiv: #53993", null, null, "かにかま", "Kanikama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30543/Kanikama", "http://kanimisoya.lolipop.jp/" },
                    { 30661, "Doujin circle: Happa\n\nTwitter: @oomiya\npixiv: #2741", null, "大宮", "宮美", "Miyami Oomiya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30661/Miyami_Oomiya", "http://happa.moo.jp/" },
                    { 30673, "Twitter: @grandnauts", null, "広瀬", "まどか", "Madoka Hirose", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30673/Madoka_Hirose", "http://grand-nauts.jp/" },
                    { 30675, "Twitter: @Magote_rihujin\nSyosetu: @288399", new DateTime(1985, 4, 2, 16, 0, 0, 0, DateTimeKind.Local), "理不尽な孫の手", null, "Rifujin na Magonote", "https://cdn.myanimelist.net/images/voiceactors/3/61694.jpg", "https://myanimelist.net/people/30675/Rifujin_na_Magonote", null },
                    { 30677, "Twitter: @akatoris\nTwitter (deleted):@siro_sirota\npixiv: #1785711", null, "シロタカ", null, "Sirotaka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30677/Sirotaka", "http://sirotaka720.blog.fc2.com/" },
                    { 30779, null, null, null, "ようこ", "Youko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30779/Youko", null },
                    { 30811, "Twitter: @mikawaghost", null, "三河", "ごーすと", "Ghost Mikawa", "https://cdn.myanimelist.net/images/voiceactors/1/68940.jpg", "https://myanimelist.net/people/30811/Ghost_Mikawa", null },
                    { 30849, "Twitter: @kotoraex\npixiv: #10257580", null, "木野", "コトラ", "Kotora Kino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30849/Kotora_Kino", null },
                    { 30983, "Twitter: @trbc_knj", null, "鶴淵", "けんじ", "Kenji Tsurubuchi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30983/Kenji_Tsurubuchi", null },
                    { 30985, "Twitter: @tozanago", null, "都桜", "和", "Nagomi Tozakura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30985/Nagomi_Tozakura", "http://thw.jp/index.html" },
                    { 30987, "Twitter: @adoventyara\npixiv: #6379", null, "あどべんちゃら", null, "Advenchara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30987/Advenchara", "http://www15.plala.or.jp/adoventyara/" },
                    { 30989, "pixiv: #1605947", null, "鴻巣", "覚", "Satori Kounosu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30989/Satori_Kounosu", "http://tomegu.blog43.fc2.com/" },
                    { 30995, "Twitter: @hitsuji_haco\npixiv: #1163637", null, "日辻", "ハコ", "Hako Hitsuji", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/30995/Hako_Hitsuji", "http://hitsuji-no1-shibori.com/" },
                    { 31063, "Blood type: AB\nCurrent residence: Ibaraki Prefecture, Japan\n\nKagamitsuki is the leader of the production circle AChaDe-8th.\n\nTwitter: @nyogetsu, nyokatsu\npixiv: #11159\nBlog: http://nyolog.blog20.fc2.com/", new DateTime(1988, 3, 20, 16, 0, 0, 0, DateTimeKind.Local), "カガミツキ", null, "Kagamitsuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/31063/Kagamitsuki", "http://mmoon.soragoto.net/" },
                    { 31087, "Twitter: @manganoyagi", null, "矢樹", "貴", "Takashi Yagi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/31087/Takashi_Yagi", null },
                    { 31159, null, null, "汐村", "友", "Yu Shiomura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/31159/Yu_Shiomura", null },
                    { 31211, null, new DateTime(1983, 5, 9, 17, 0, 0, 0, DateTimeKind.Local), "高羽", "彩", "Aya Takaha", "https://cdn.myanimelist.net/images/voiceactors/2/74981.jpg", "https://myanimelist.net/people/31211/Aya_Takaha", null },
                    { 31245, null, null, null, "ちょぼらうにょぽみ", "Choboraunyopomi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/31245/Choboraunyopomi", "http://ameblo.jp/chobonyopo/" },
                    { 31467, "Male\n\nTwitter: @nanaroku76\npixiv: #7463", null, "七六", null, "Nanaroku", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/31467/Nanaroku", "http://fortress76.com" },
                    { 31685, null, null, "花鶏", "ハルノ", "Haruno Atori", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/31685/Haruno_Atori", null },
                    { 31719, "Twitter: @huusen_uri\npixiv: #76370\ntumblr: @huusenuri", null, "チョモラン", null, "Chomoran", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/31719/Chomoran", null },
                    { 31893, null, null, "水鏡", "ひより", "Hiyori Mikagami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/31893/Hiyori_Mikagami", null },
                    { 31895, "Twitter: @HisakaToru", null, "氷坂", "透", "Tooru Hisaka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/31895/Tooru_Hisaka", null },
                    { 31927, "Twitter: @yanase_t", new DateTime(1974, 1, 20, 16, 0, 0, 0, DateTimeKind.Local), "柳瀬", "敬之", "Takayuki Yanase", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/31927/Takayuki_Yanase", "http://www.yanase.works/" },
                    { 31965, "Twitter: @goto_sora", null, "轟斗", "ソラ", "Sora Gouto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/31965/Sora_Gouto", null },
                    { 32095, "Doujin circle: ranicaronica\n\nTwitter: @aosorayuri24\npixiv: #444732", null, "れい亜", null, "Reia", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32095/Reia", "http://ranicaronica.net/" },
                    { 32119, null, null, "uku", null, "uku", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32119/uku", null },
                    { 32185, "Twitter: @azsawa00\npixiv: #478617", null, "アズマ", "サワヨシ", "Sawayoshi Azuma", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32185/Sawayoshi_Azuma", null },
                    { 32265, null, null, "星", "希代子", "Kiyoko Hoshi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32265/Kiyoko_Hoshi", null },
                    { 32463, null, null, "間中", "葦", "Yoshi Manaka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32463/Yoshi_Manaka", null },
                    { 32649, "Twitter/𝕏: @nezumiironyanko", new DateTime(1987, 3, 10, 16, 0, 0, 0, DateTimeKind.Local), "長月", "達平", "Tappei Nagatsuki", "https://cdn.myanimelist.net/images/voiceactors/1/44951.jpg", "https://myanimelist.net/people/32649/Tappei_Nagatsuki", null },
                    { 32651, "Twitter: @otsuka_shin", null, "大塚", "真一郎", "Shinichirou Ootsuka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32651/Shinichirou_Ootsuka", null },
                    { 32699, "Twitter: @Shin_Towada", null, "十和田", "シン", "Shin Towada", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32699/Shin_Towada", null },
                    { 32759, null, null, "杉本", "ゆう", "Yuu Sugimoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32759/Yuu_Sugimoto", null },
                    { 32813, "Twitter: @hatopopoko", null, null, "ハトポポコ", "Hatopopoko", "https://cdn.myanimelist.net/images/voiceactors/3/59229.jpg", "https://myanimelist.net/people/32813/Hatopopoko", null },
                    { 32817, "Twitter: @trygatto", null, "斎", "夏生", "Natsuo Sai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32817/Natsuo_Sai", null },
                    { 32913, null, null, null, "BOKU", "BOKU", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32913/BOKU", null },
                    { 32915, "Twitter: @naguwan", null, "渡辺", "留衣", "Rui Watanabe", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32915/Rui_Watanabe", null },
                    { 32917, null, null, "白土", "悠介", "Yuusuke Shirato", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/32917/Yuusuke_Shirato", null },
                    { 33011, null, null, null, null, "TEAM MOON", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/33011/TEAM_MOON", null },
                    { 33059, "Twitter: @uonuma_yu", null, "うおぬま", "ゆう", "Yuu Uonuma", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/33059/Yuu_Uonuma", null },
                    { 33097, null, null, "球木", "拾壱", "Juuichi Tamaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/33097/Juuichi_Tamaki", null },
                    { 33167, "Yamashita Ikuto is a Japanese male mangaka and designer. He was born in the Gifu Prefecture, Japan and is a graduate of the Nagoya University Of Arts.\n\nHis representative work in manga is Dark Whisper (serialised in Dengeki Daioh). In the field of anime, he is the mecha designer in the Neon Genesis Evangelion series and Sentou Yousei Yukikaze. The designs for Yukikaze were originally drawn as recreation as well as Sentou Yousei Shoujo Tasukete! Mave-chan.\n\nBesides Evangelion, he has also done mecha designs for other Gainax works including Gunbuster and Nadia: The Secret of Blue Water and was also the mechanical designer for Blue Submarine 6.\n\n(Source: AniDB)", null, "山下", "いくと", "Ikuto Yamashita", "https://cdn.myanimelist.net/images/voiceactors/1/44559.jpg", "https://myanimelist.net/people/33167/Ikuto_Yamashita", "http://twitter.com/ikuto_yamashita" },
                    { 33219, null, null, "あらた", "まい", "Mai Arata", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/33219/Mai_Arata", "http://marie.saiin.net/~s-e-e/" },
                    { 33535, "Pinakes is an Indonesian illustrator residing in Singapore.\n\nTwitter: @PinaxPinakes\npixiv: #1629467", null, "ピナケス", null, "Pinakes", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/33535/Pinakes", "http://pinakes.wordpress.com/" },
                    { 33771, "Twitter: @hatori_niwatori\npixiv: #15480\n\n\nYoutube: #つるさきゆう", new DateTime(1987, 12, 10, 16, 0, 0, 0, DateTimeKind.Local), "津留崎", "優", "Yuu Tsurusaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/33771/Yuu_Tsurusaki", "http://niwatori.anime-festa.com/" },
                    { 33833, "Twitter: @nomnii", new DateTime(1987, 3, 1, 16, 0, 0, 0, DateTimeKind.Local), "ノ村", "優介", "Yuusuke Nomura", "https://cdn.myanimelist.net/images/voiceactors/2/65445.jpg", "https://myanimelist.net/people/33833/Yuusuke_Nomura", null },
                    { 33843, "Twitter: @theekick", null, "小菊路", "よう", "You Kokikuji", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/33843/You_Kokikuji", null },
                    { 34167, "pixiv: #33872\nTwitter: @lyot3rd", null, null, "リヨ", "Riyo", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/34167/Riyo", null },
                    { 34229, null, new DateTime(1960, 7, 17, 17, 0, 0, 0, DateTimeKind.Local), "高寺", "彰彦", "Akihiko Takadera", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/34229/Akihiko_Takadera", null },
                    { 34287, "Female\n\nTwitter: @yukaty\npixiv: #52470", null, "浪咲", "ゆか", "Yuka Namisaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/34287/Yuka_Namisaki", "http://18sbunny.yukaty.com/" },
                    { 34631, "Twitter: @kasumim224", null, "森野", "カスミ", "Kasumi Morino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/34631/Kasumi_Morino", null },
                    { 34715, "Twitter: @soubin\npixiv: #991436", null, null, null, "so-bin", "https://cdn.myanimelist.net/images/voiceactors/1/47159.jpg", "https://myanimelist.net/people/34715/so-bin", "http://so-bin.tumblr.com" },
                    { 34719, "Twitter: @shijimistrike", null, "伊原", "大貴", "Daiki Ihara", "https://cdn.myanimelist.net/images/voiceactors/3/82494.jpg", "https://myanimelist.net/people/34719/Daiki_Ihara", null },
                    { 34747, "Twitter: @TsubaTako\npixiv: #1773916", null, "野崎", "つばた", "Tsubata Nozaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/34747/Tsubata_Nozaki", "http://tsubatako.jimdo.com/" },
                    { 34803, "Hometown: Sapporo, Hokkaido, Japan\nCurrent Residence: Osaka, Japan\n\nTwitter: @EnJoeToh", new DateTime(1972, 9, 14, 17, 0, 0, 0, DateTimeKind.Local), "円城", "塔", "Toh EnJoe", "https://cdn.myanimelist.net/images/voiceactors/2/36189.jpg", "https://myanimelist.net/people/34803/Toh_EnJoe", "http://self-reference.engine.sub.jp/" },
                    { 34965, "Twitter: @My0K0\npixiv: #502346", null, "梅津", "葉子", "Youko Umezu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/34965/Youko_Umezu", null },
                    { 35011, null, null, "篠崎", "芳", "Kaoru Shinozaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/35011/Kaoru_Shinozaki", null },
                    { 35017, null, null, "浅野", "直之", "Naoyuki Asano", "https://cdn.myanimelist.net/images/voiceactors/2/39240.jpg", "https://myanimelist.net/people/35017/Naoyuki_Asano", null },
                    { 35063, "Taiwanese Illustrator based in Tokyo/Taipei.\nHe can speak Chinese, Japanese and English.\n\nTwitter: @HitenKei\nInstagram: @hitenkei\nTumblr: @hitenkei\npixiv: #490219", null, "Hiten", null, "Hiten", "https://cdn.myanimelist.net/images/voiceactors/1/64310.jpg", "https://myanimelist.net/people/35063/Hiten", "http://www.hitenkei.net" },
                    { 35135, null, null, "下川", "香苗", "Kanae Shimokawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/35135/Kanae_Shimokawa", null },
                    { 35569, "Masato Ichishiki is a Japanese manga artist who is best known for his work on the SD Gundam series\n\nTwitter: @1shikiworks", new DateTime(1971, 12, 10, 16, 0, 0, 0, DateTimeKind.Local), "一式", "まさと", "Masato Ichishiki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/35569/Masato_Ichishiki", "http://1shikiworks.web.fc2.com/" },
                    { 35701, "Twitter: @akira_houjoh", null, "北条", "晶", "Akira Houjou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/35701/Akira_Houjou", "http://cutiekids.club/" },
                    { 35715, null, null, "経塚", "丸雄", "Maruo Kyouzuka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/35715/Maruo_Kyouzuka", null },
                    { 35955, null, null, "佐竹", "清順", "Kiyokazu Satake", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/35955/Kiyokazu_Satake", null },
                    { 35997, "Twitter: @barabarawhite", null, "北國", "ばらっど", "Ballad Kitakuni", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/35997/Ballad_Kitakuni", null },
                    { 36257, "Twitter: @umiko35\npixiv: #337971", null, "U35", null, "U35", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36257/U35", "http://amaon.blog.fc2.com/" },
                    { 36299, "Doujin circle: Pe:booota.\n\nTwitter: @booota\npixiv: #652196", null, "ぶーた", null, "booota", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36299/booota", null },
                    { 36303, "Doujin circle: Mosu-ya\n\nTwitter: @yasumo01\npixiv: #871153", null, "やすも", null, "Yasumo", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36303/Yasumo", null },
                    { 36415, "Doujin circle: Kotojikan (琴慈館)\n\nTwitter: @cotoji_69\npixiv: #267712", null, "琴慈", null, "Cotoji", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36415/Cotoji", "http://cotoji69.blog.fc2.com/" },
                    { 36599, null, null, "藤孝", "剛志", "Tsuyoshi Fujitaka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36599/Tsuyoshi_Fujitaka", null },
                    { 36661, null, null, "庄司", "卓", "Takashi Shouji", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36661/Takashi_Shouji", null },
                    { 36686, "Not to be confused with Natsumi Inoue.\n\nTwitter: @natsumi19900325", new DateTime(1990, 3, 24, 16, 0, 0, 0, DateTimeKind.Local), "井上", "菜摘", "Natsumi Inoue", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36686/Natsumi_Inoue", null },
                    { 36692, null, null, null, null, "M", "https://cdn.myanimelist.net/images/voiceactors/2/56946.jpg", "https://myanimelist.net/people/36692/M", null },
                    { 36700, null, null, "藤沢", "カミヤ", "Kamiya Fujisawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36700/Kamiya_Fujisawa", null },
                    { 36715, "Female\nSign: Leo\nBlood type: A type\nBirthplace: Saitama Prefecture\nThe debut work: Haratte Tsubaki-chan\nHobbies: Eating gummy candy\n\nTwitter: @masako_shitara", null, "シタラ", "マサコ", "Masako Shitara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36715/Masako_Shitara", "http://sitapan.blog.shinobi.jp/" },
                    { 36733, "Twitter: @sakomisaki\npixiv: #5910161", null, "迫", "ミサキ", "Misaki Sako", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36733/Misaki_Sako", "http://sakomisaki.blog.fc2.com/" },
                    { 36857, "Twitter: @yam_cha", null, "やむ茶", null, "Yamucha", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36857/Yamucha", "http://cocololi.xxxxxxxx.jp/" },
                    { 36869, "Twitter: @saekiyou", null, "佐伯", "庸介", "Yousuke Saeki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/36869/Yousuke_Saeki", null },
                    { 37002, "Twitter: @touco_shino", null, "しの", "とうこ", "Touko Shino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37002/Touko_Shino", "http://shinote.sblo.jp/" },
                    { 37114, "Doujin circle: Air x Gravity (えあ×ぐら)\n\nTwitter: @bidi02\npixiv: #140508", new DateTime(1989, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), null, "びび", "Bibi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37114/Bibi", "http://bibi02.web.fc2.com/" },
                    { 37135, null, null, "安藤", "英", "Ei Andou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37135/Ei_Andou", null },
                    { 37300, null, null, "竹内", "清人", "Kiyoto Takeuchi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37300/Kiyoto_Takeuchi", null },
                    { 37316, "Twitter: @omiomi_kekyu\npixiv: #65611\nnote: @omiomi_kekyu", null, "おみおみ", null, "OmiOmi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37316/OmiOmi", "http://omiomiomiomiomi.blogspot.jp/" },
                    { 37335, "Twitter: @zomcho", null, null, "ぞんちょ", "Zomcho", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37335/Zomcho", null },
                    { 37430, "Kuwata Jirou, alternatively 桑田二郎, born April 17, 1935 in Suita, Osaka is a Japanese mangaka.\n\nA gifted artist, Kuwata started out as a manga artist at the young age of 13, when he created The Strange Star Cluster (怪奇星団) in 1948. His turning point came in 1957, when he created Phantom Detective (まぼろし探偵) (which was adapted into a tokusatsu TV series in 1959). Since then, Kuwata devoted himself to creating science fiction/superhero adventures. His most famous was 8 Man, which he co-created with writer Kazumasa Hirai.\n\nUnfortunately, in 1965, when he was to finish the final issue of 8 Man, he was arrested for possessing a handgun (he had contemplated suicide). With Kuwata in jail, co-creator Hirai got other manga artists to finish the final issue, but wasn't satisfied with it. It was published in a manga magazine, but has never before been reprinted.\n\nNevertheless, Kuwata, released from prison shortly thereafter, continued his manga work well into the 1970s, but also ran into depression and alcoholism. In 1977, he had an epiphany and converted to Buddhism. He has since done beautiful art books about the life of Buddha. He also occasionally got back into manga work, and in 1992, he agreed to do his own version of the final issue of 8 Man, upon being asked by co-creator/friend Kazumasa Hirai. \n\n(Source: AniDB)\n\nDate of death:July 2, 2020", new DateTime(1935, 4, 16, 17, 0, 0, 0, DateTimeKind.Local), "桑田", "二郎", "Jirou Kuwata", "https://cdn.myanimelist.net/images/voiceactors/1/39565.jpg", "https://myanimelist.net/people/37430/Jirou_Kuwata", null },
                    { 37509, "Twitter: @u_kodachi", new DateTime(1979, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "小太刀", "右京", "Ukyou Kodachi", "https://cdn.myanimelist.net/images/voiceactors/1/44254.jpg", "https://myanimelist.net/people/37509/Ukyou_Kodachi", null },
                    { 37521, "Male\n\nTwitter: @nakenashi\npixiv: #49544", null, "Tea", null, "Tea", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37521/Tea", "http://nakenashi.net/wp/" },
                    { 37563, "Nakamura Koujirou is a scriptwriter.\n\nTwitter: @nakamura_hihin", null, "中村", "浩二郎", "Koujirou Nakamura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37563/Koujirou_Nakamura", null },
                    { 37564, null, null, "上石", "神威", "Kamoi Kamiishi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37564/Kamoi_Kamiishi", null },
                    { 37633, "Male\n\nTwitter: @kenogino_", null, "荻野", "ケン", "Ken Ogino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37633/Ken_Ogino", null },
                    { 37758, "Twitter: @sowkami", null, "神代", "創", "Sou Kamishiro", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37758/Sou_Kamishiro", "http://homepage1.nifty.com/sow/" },
                    { 37790, "Doujin circle: Koruriya\n\nTwitter: @ko_ru_ri\npixiv: #197506", null, "こるり", null, "Koruri", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37790/Koruri", "http://koruriya.com/" },
                    { 37791, "Doujin circle: Happy Yellow Rabbit (HappyYellowRabbit)\n\nTwitter: @aoiyukiko\npixiv: #603733\nInstagram: @aoiyukiko\nYoutube", null, "雪子", null, "Yukiko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37791/Yukiko", "https://yukicocco.com" },
                    { 37794, null, null, null, "はるか", "Haruka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37794/Haruka", null },
                    { 37817, null, null, "真藤", "順丈", "Junjou Shindou", "https://cdn.myanimelist.net/images/voiceactors/3/80548.jpg", "https://myanimelist.net/people/37817/Junjou_Shindou", null },
                    { 37823, "Ochi Kazuhiro is an animator, character designer and director. He was born February 19, 1962 in Gifu, Japan. Ochi joined very early an animation studio, showing his talent he already debuted as animator at the age of 16, which was unheard before. He was formerly working at Studio No.1.\n\n(Source: AniDB)", new DateTime(1962, 2, 18, 16, 0, 0, 0, DateTimeKind.Local), "越智", "一裕", "Kazuhiro Ochi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37823/Kazuhiro_Ochi", null },
                    { 37834, null, null, "関根", "アユミ", "Ayumi Sekine", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37834/Ayumi_Sekine", null },
                    { 37840, null, null, "白米", "良", "Ryou Shirakome", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37840/Ryou_Shirakome", null },
                    { 37841, "Twitter: @okanoyu01", null, "丘野", "優", "Yuu Okano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37841/Yuu_Okano", null },
                    { 37843, "Twitter: @otoufu_material", null, "オトウフ", null, "otoufu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37843/otoufu", "http://otoufu.xrea.jp" },
                    { 37853, "Twitter: @neichiru\npixiv: #77203", null, "篠月", "しのぶ", "Shinobu Shinotsuki", "https://cdn.myanimelist.net/images/voiceactors/3/61948.jpg", "https://myanimelist.net/people/37853/Shinobu_Shinotsuki", "https://dnanetworks.tumblr.com/" },
                    { 37854, "Twitter: @sonzaix", null, null, "カルロ・ゼン", "Carlo Zen", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37854/Carlo_Zen", null },
                    { 37880, "Twitter: @Kuma_ataro", null, "久麻", "當郎", "Atarou Kuma", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/37880/Atarou_Kuma", null },
                    { 37902, "Twitter: @momoco_haru\npixiv: #1113943", null, "ももこ", null, "Momoco", "https://cdn.myanimelist.net/images/voiceactors/2/71760.jpg", "https://myanimelist.net/people/37902/Momoco", null },
                    { 38131, null, null, "青田", "めい", "Mei Aota", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38131/Mei_Aota", null },
                    { 38132, "Twitter: @misachu_project", null, "みさちゅう/Nash", null, "Misachuu/Nash", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38132/Misachuu_Nash", "http://misachu.net/" },
                    { 38145, null, null, "湊", "青樹", "Seijuu Minato", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38145/Seijuu_Minato", null },
                    { 38202, "Male\n\nTwitter: @t_suuei\npixiv: #49776826", null, "高木", "秀栄", "Shuuei Takagi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38202/Shuuei_Takagi", null },
                    { 38206, "Birth place: Shimizu, Shizuoka Prefecture, Japan", null, "初野", "晴", "Sei Hatsuno", "https://cdn.myanimelist.net/images/voiceactors/2/43855.jpg", "https://myanimelist.net/people/38206/Sei_Hatsuno", null },
                    { 38222, "Twitter: @AzumikeiWr", null, "あずみ", "圭", "Kei Azumi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38222/Kei_Azumi", null },
                    { 38271, "Twitter: @minozy_k", null, "倉田", "三ノ路", "Minoji Kurata", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38271/Minoji_Kurata", null },
                    { 38278, "Twitter: @mtmtmtak32\npixiv: #215287", null, "松本", "光顕", "Mitsuaki Matsumoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38278/Mitsuaki_Matsumoto", "https://ma32020.wixsite.com/transparnaut" },
                    { 38364, "Twitter: @rokuno3", null, "陸野", "二二夫", "Nijio Rokuno", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38364/Nijio_Rokuno", "http://36rokubunno.blog6.fc2.com/" },
                    { 38443, null, null, "不二", "涼介", "Ryousuke Fuji", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38443/Ryousuke_Fuji", null },
                    { 38445, "Twitter: @hasemi_r\npixiv: #1212521", null, "長谷見", "亮", "Ryou Hasemi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38445/Ryou_Hasemi", null },
                    { 38459, "Doujin circle: IRAKUSA\n\nTwitter: @couzone\npixiv: #88277", null, "さきしま", "えのき", "Enoki Sakishima", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38459/Enoki_Sakishima", "http://couz.sub.jp/" },
                    { 38481, null, null, "あすか", "正太", "Shouta Asuka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38481/Shouta_Asuka", null },
                    { 38573, null, null, "冬部", "万博", "Mahi Fuyube", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38573/Mahi_Fuyube", null },
                    { 38574, null, null, "井上", "かーく", "Ka-ku Inoue", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38574/Ka-ku_Inoue", "http://www.inoueka-ku.com/" },
                    { 38575, "Twitter: @tachitute1024", null, "たちつ", "てつこ", "Tetsuko Tachitsu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38575/Tetsuko_Tachitsu", "http://tachitutekko.blog.fc2.com/" },
                    { 38598, "Twitter: @Tsukiyo_rui", null, "月夜", "涙", "Rui Tsukiyo", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38598/Rui_Tsukiyo", null },
                    { 38610, null, null, "佐野", "敏治", "Toshiharu Sano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38610/Toshiharu_Sano", null },
                    { 38777, null, null, "泉", "昌之", "Masayuki Izumi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38777/Masayuki_Izumi", null },
                    { 38981, "Twitter: @makino00\npixiv: #650869", null, "牧乃", null, "Makino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38981/Makino", "http://caelum0.web.fc2.com/" },
                    { 38982, "Doujin circle: Dontsugel\n\nTwitter: @nmaaaaa\npixiv: #644229", null, "紅緒", null, "Benio", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/38982/Benio", "http://www.dontsugel.com/" },
                    { 39207, null, null, "北山", "結莉", "Yuri Kitayama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39207/Yuri_Kitayama", null },
                    { 39224, "Twitter: @ryuseinokazu", null, "礒部", "一真", "Kazuma Isobe", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39224/Kazuma_Isobe", null },
                    { 39266, null, null, "ジジ＆ピンチ", null, "Jiji & Pinch", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39266/Jiji___Pinch", null },
                    { 39275, null, null, "安東", "汐", "Ushio Andou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39275/Ushio_Andou", null },
                    { 39300, "Female\n\nTwitter: @72smk\npixiv: #34555", null, "七都", "サマコ", "Samako Natsu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39300/Samako_Natsu", "http://mirabeau.chu.jp/" },
                    { 39385, "Female\n\nTwitter: @jimmy_madomagi\npixiv: #5768971", null, null, null, "jimmy", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39385/jimmy", null },
                    { 39496, null, null, "坂元", "千笑", "Chiemi Sakamoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39496/Chiemi_Sakamoto", null },
                    { 39499, null, null, "早川", "ナオヤ", "Naoya Hayakawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39499/Naoya_Hayakawa", null },
                    { 39511, "Doujin circle: PurpleCroudHill\n\nTwitter: @purplecroudhill\npixiv: #9170322", null, "村下", "玖臓", "Q-Zou Murashita", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39511/Q-Zou_Murashita", "http://purplecroudhill.tumblr.com/" },
                    { 39599, "Twitter: @yatosaking\npixiv: #75132", null, "やとさき", "はる", "Haru Yatosaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39599/Haru_Yatosaki", "http://yatosaki.sokowonantoka.com/" },
                    { 39706, "Twitter: @ktsuki_novel", null, "槻影", null, "Tsukikage", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39706/Tsukikage", "http://siroirokuroiro.blog120.fc2.com/" },
                    { 39719, "Twitter: @hata_ryousuke", null, "羽田", "遼亮", "Ryousuke Hata", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39719/Ryousuke_Hata", null },
                    { 39752, "Twitter: @hbyoshiko\npixiv: #1329262", null, "ハードボイルドよし子", null, "Hardboiled Yoshiko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39752/Hardboiled_Yoshiko", "http://hakkoukimuti.blog.fc2.com/" },
                    { 39760, null, null, "粗製SODA", null, "Sosei Soda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39760/Sosei_Soda", null },
                    { 39884, "Twitter: @urotanc\npixiv: #273771", null, "ウロ", null, "Uro", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39884/Uro", null },
                    { 39921, "Twitter: @tsunaminozazen\npixiv: #15369", null, "ツナミノ", "ユウ", "Yuu Tsunamino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39921/Yuu_Tsunamino", null },
                    { 39940, null, null, "砂山", "蔵澄", "Kurasumi Sunayama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/39940/Kurasumi_Sunayama", null },
                    { 40025, "Twitter: @kafun\npixiv: #97627", null, "かふん", null, "Kafun", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/40025/Kafun", "http://hanakonakafun.blog.fc2.com/" },
                    { 40141, null, new DateTime(1990, 6, 28, 17, 0, 0, 0, DateTimeKind.Local), "小野", "大空", "Masataka Ono", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/40141/Masataka_Ono", null },
                    { 40179, null, null, "松井", "亜弥", "Aya Matsui", "https://cdn.myanimelist.net/images/voiceactors/2/56068.jpg", "https://myanimelist.net/people/40179/Aya_Matsui", null },
                    { 40217, null, new DateTime(1963, 7, 23, 17, 0, 0, 0, DateTimeKind.Local), "Moo.念平", null, "Moo.Nenpei", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/40217/MooNenpei", null },
                    { 40218, "Twitter: @yuyu_d\npixiv: #68864", null, "一乃", "ゆゆ", "Yuyu Ichino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/40218/Yuyu_Ichino", null },
                    { 40306, "Doujin circle: Kurumaya (車ヤ)\n\nTwitter: @Romancing_RoGa\npixiv: #12531292", null, "RoGa", null, "RoGa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/40306/RoGa", "http://www7a.biglobe.ne.jp/~megaplus/flame.htm" },
                    { 40314, "Twitter: @yuu_mitsuru", null, "三津留", "ゆう", "Yuu Mitsuru", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/40314/Yuu_Mitsuru", "http://ameblo.jp/yuumitsuru/" },
                    { 40398, "They portray themself as a crocodile wearing glasses.", new DateTime(1989, 5, 4, 17, 0, 0, 0, DateTimeKind.Local), "吾峠", "呼世晴", "Koyoharu Gotouge", "https://cdn.myanimelist.net/images/voiceactors/3/57359.jpg", "https://myanimelist.net/people/40398/Koyoharu_Gotouge", null },
                    { 40550, "Twitter: @koxHhDrnIZIMYJZ", null, "くろかた", null, "Kurokata", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/40550/Kurokata", null },
                    { 40594, "Birthplace: Fukuoka, Japan\n\nTwitter: @touku43", null, "若松", "卓宏", "Takahiro Wakamatsu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/40594/Takahiro_Wakamatsu", null },
                    { 40818, "Not to be mistaken with another Kouji Miura (三浦 浩児) who is a scriptwriter.\n\nTwitter: @amzk0303", new DateTime(1995, 3, 27, 16, 0, 0, 0, DateTimeKind.Local), "三浦", "糀", "Kouji Miura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/40818/Kouji_Miura", null },
                    { 41133, null, null, "誉司", "アンリ", "Anri Yoshi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41133/Anri_Yoshi", null },
                    { 41158, "Former Assistants:Yuuji Kaku\nTatsuya Endou\nYukinobu Tatsu\nOto Tooda\nTooru Kuramori\nTwitter: @nagayama_koharu", new DateTime(1992, 10, 9, 17, 0, 0, 0, DateTimeKind.Local), "藤本", "タツキ", "Tatsuki Fujimoto", "https://cdn.myanimelist.net/images/voiceactors/2/61876.jpg", "https://myanimelist.net/people/41158/Tatsuki_Fujimoto", null },
                    { 41189, "Doujin circle: Nankano Koubou\n\nTwitter: @lalalalack\npixiv: #83739", new DateTime(1987, 9, 17, 17, 0, 0, 0, DateTimeKind.Local), "lack", null, "lack", "https://cdn.myanimelist.net/images/voiceactors/3/55960.jpg", "https://myanimelist.net/people/41189/lack", "http://nankano.shisyou.com/" },
                    { 41198, "Twitter: @flyco_\npixiv: #1024922", null, "フライ", null, "Fly", "https://cdn.myanimelist.net/images/voiceactors/1/62874.jpg", "https://myanimelist.net/people/41198/Fly", null },
                    { 41240, null, null, "寺馬", "ヒロスケ", "Hirosuke Terama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41240/Hirosuke_Terama", null },
                    { 41241, null, null, "団伍", null, "Dango", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41241/Dango", null },
                    { 41275, "Twitter: @oshioshio_info\npixiv: #4733565", null, "おしおしお", null, "Oshioshio", "https://cdn.myanimelist.net/images/voiceactors/2/71762.jpg", "https://myanimelist.net/people/41275/Oshioshio", null },
                    { 41278, "Twitter: @bkub_comic\npixiv: #9948", new DateTime(1986, 10, 2, 17, 0, 0, 0, DateTimeKind.Local), "大川", "ぶくぶ", "bkub Ookawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41278/bkub_Ookawa", "http://bkub.webcrow.jp/" },
                    { 41453, "Twitter: @uenotei\nTwitter: @meguruueno\npixiv: #661650", null, "植野", "メグル", "Meguru Ueno", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41453/Meguru_Ueno", null },
                    { 41537, "Twitter: @Qkureta\npixiv: #481726", null, "クレタ", null, "Kureta", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41537/Kureta", null },
                    { 41590, "Twitter: @jihanki_hakkon", null, "昼熊", null, "Hiru Kuma", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41590/Hiru_Kuma", null },
                    { 41596, "Twitter: @nek0m1nt\npixiv: #1698462", null, "ねこみんと", null, "Nekomint", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41596/Nekomint", "http://nekomint22310.blog119.fc2.com/" },
                    { 41662, null, null, "棚架", "ユウ", "Yuu Tanaka", "https://cdn.myanimelist.net/images/voiceactors/2/66389.jpg", "https://myanimelist.net/people/41662/Yuu_Tanaka", null },
                    { 41727, "Twitter: @kanaineco\npixiv: #2535833", null, "かない", "ねこ", "Neco Kanai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41727/Neco_Kanai", "http://kanaineco.info/" },
                    { 41770, "Twitter: @ichiiro_hako\npixiv: #11877871", null, "一色", "箱", "Hako Ichiiro", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41770/Hako_Ichiiro", "http://hako-ichiiro.tumblr.com/" },
                    { 41789, "Twitter: @nama3v3\npixiv: #6532827", null, "なま", null, "Nama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41789/Nama", "http://nm.dlb.moo.jp/" },
                    { 41803, "Twitter: @atsuwo521\npixiv: #1177592", null, "上田", "敦夫", "Atsuo Ueda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41803/Atsuo_Ueda", null },
                    { 41813, "Twitter: @beshinobesi", new DateTime(1994, 3, 22, 16, 0, 0, 0, DateTimeKind.Local), "平野", "稜二", "Ryouji Hirano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41813/Ryouji_Hirano", null },
                    { 41916, "Twitter: @onnkakhr\npixiv: #981911", null, "小野中", "彰大", "Akihiro Ononaka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/41916/Akihiro_Ononaka", null },
                    { 42031, "pixiv: #245406\nTwitter: @shoma_keito", null, "ショウマ", "ケイト", "Keito Shouma", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/42031/Keito_Shouma", null },
                    { 42068, null, null, null, null, "KUMA", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/42068/KUMA", null },
                    { 42145, "Twitter: @TZpoppin_phl95\npixiv: #16347608", null, "東西", null, "Touzai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/42145/Touzai", null },
                    { 42170, "Twitter: @rhombicriver", null, "菱川", "さかく", "Sakaku Hishikawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/42170/Sakaku_Hishikawa", null },
                    { 42337, "Twitter: @nekonabebobobo\npixiv: #4065575", null, "猫鍋", "蒼", "Ao Nekonabe", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/42337/Ao_Nekonabe", null },
                    { 42420, "Twitter: @yaku_yuki", null, "屋久", "ユウキ", "Yuuki Yaku", "https://cdn.myanimelist.net/images/voiceactors/3/56569.jpg", "https://myanimelist.net/people/42420/Yuuki_Yaku", null },
                    { 43150, "Twitter: @n_aonagi\npixiv: #411628", null, "蒼和", "伸", "Nobu Aonagi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/43150/Nobu_Aonagi", "https://n-aonagi.tumblr.com/" },
                    { 43163, "Twitter: @3Fe2O2Fe3O4", null, "小西", "明日翔", "Asuka Konishi", "https://cdn.myanimelist.net/images/voiceactors/3/67369.jpg", "https://myanimelist.net/people/43163/Asuka_Konishi", null },
                    { 43212, "Twitter: @ninjamatch\npixiv: #157342", null, "match", null, "match", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/43212/match", "http://20ttwenty.tumblr.com/" },
                    { 43216, null, null, "権平", "ひつじ", "Hitsuji Gondaira", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/43216/Hitsuji_Gondaira", null },
                    { 43264, "Announced marriage on September 24, 2023.\n\nTwitter: @itaparu99\n\nParu began painting in kindergarten, and started drawing manga in the second grade. She attended  Musashino Art University, where she studied  filmmaking.\n\nHer early influences comes from Disney movies and the artists Nicolas de Crécy and Egon Schiele.\n\nShe is the daughter of manga artist Keisuke Itagaki.", new DateTime(1993, 9, 8, 17, 0, 0, 0, DateTimeKind.Local), "板垣", "巴留", "Paru Itagaki", "https://cdn.myanimelist.net/images/voiceactors/3/57557.jpg", "https://myanimelist.net/people/43264/Paru_Itagaki", "http://tentenparuparu.tumblr.com/" },
                    { 43285, "Twitter: @tuchihilight5", null, "土日", "月", "Light Tuchihi", "https://cdn.myanimelist.net/images/voiceactors/2/68090.jpg", "https://myanimelist.net/people/43285/Light_Tuchihi", null },
                    { 43396, "Twitter: @nikumatsu\npixiv: #94737", null, "黒毛", "和牛", "Wagyuu Kuroge", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/43396/Wagyuu_Kuroge", null },
                    { 43397, "pixiv: #4486129", null, "あきの", "しゅう", "Shuu Akino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/43397/Shuu_Akino", null },
                    { 43522, null, null, "野田", "宏", "Hiroshi Noda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/43522/Hiroshi_Noda", null },
                    { 43690, "Twitter: @fibonaccin", null, "左藤", "圭右", "Keisuke Satou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/43690/Keisuke_Satou", null },
                    { 43726, "Doujin circle: Akita Morgue (秋田モルグ)\n\npixiv: #7570", null, "器械", null, "Kikai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/43726/Kikai", null },
                    { 43727, "Twitter: @fuyunokei", null, "冬野", "ケイ", "Kei Fuyuno", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/43727/Kei_Fuyuno", null },
                    { 44119, "Date of death: December 1, 2011", new DateTime(1949, 1, 15, 16, 0, 0, 0, DateTimeKind.Local), "内山", "まもる", "Mamoru Uchiyama", "https://cdn.myanimelist.net/images/voiceactors/2/76443.jpg", "https://myanimelist.net/people/44119/Mamoru_Uchiyama", null },
                    { 44353, "Twitter: @sonoda_yuri\npixiv: #1438051", null, "園田", "ゆり", "Yuri Sonoda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/44353/Yuri_Sonoda", null },
                    { 44412, "Male\n\nTwitter: @tekken_tou\npixiv: #7312", null, "てっけんとう", null, "Tekkentou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/44412/Tekkentou", "http://hatopo.sblo.jp/" },
                    { 44442, "Twitter: @kemonmon, @h_kawamoto", null, "河本", "けもん", "Kemon Kawamoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/44442/Kemon_Kawamoto", null },
                    { 44457, "Twitter: @54110yu", null, "斉藤", "ゆう", "Yuu Saitou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/44457/Yuu_Saitou", null },
                    { 44501, "Twitter: @dragongarowlee\npixiv: #3539925", null, "ドラゴン画廊・リー", null, "Dragon Garow Lee", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/44501/Dragon_Garow_Lee", null },
                    { 44615, "Twitter: @yamadasekijin\npixiv: #1075043", null, "山田", "石人", "Sekijin Yamada", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/44615/Sekijin_Yamada", null },
                    { 44623, "Twitter: @aogiri_makoto\npixiv: #7070921", null, "青桐", "良", "Makoto Aogiri", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/44623/Makoto_Aogiri", "http://blue-blue-bee.jugem.jp/" },
                    { 44689, "Twitter: @gyunyuburo\npixiv: #456555", null, "碓井", "ツカサ", "Tsukasa Usui", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/44689/Tsukasa_Usui", null },
                    { 44835, "Twitter: @kenhi7000", null, "肥田野", "健太郎", "Kentarou Hidano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/44835/Kentarou_Hidano", null },
                    { 44895, null, null, "佐竹", "幸典", "Kousuke Satake", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/44895/Kousuke_Satake", null },
                    { 44910, "Twitter: @16suzume\npixiv: #890482", null, "染宮", "すずめ", "Suzume Somemiya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/44910/Suzume_Somemiya", "http://spst256.wix.com/torinity" },
                    { 45171, null, null, "アナジロ", null, "Anajiro", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/45171/Anajiro", null },
                    { 45437, "Twitter: @neco_person\npixiv: #777703", null, "neco", null, "neco", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/45437/neco", null },
                    { 45451, "Twitter: @goto6h", null, "後藤", "リウ", "Riu Gotou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/45451/Riu_Gotou", null },
                    { 45507, "Twitter: @nekokurage_\npixiv: #567687", null, "ねこクラゲ", null, "Nekokurage", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/45507/Nekokurage", null },
                    { 45593, "Doujin circle: squareHEAD\n\nTwitter: @asa_kusa_99\npixiv: #13302141, #24572739", null, "浅草", "九十九", "Tsukumo Asakusa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/45593/Tsukumo_Asakusa", "https://yomowasa.wixsite.com/squarehead" },
                    { 45713, "Twitter: @akino_keikaku", null, "秋野", "キサラ", "Kisara Akino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/45713/Kisara_Akino", "http://akinokeikaku.blog.fc2.com/" },
                    { 46082, "Twitter: @kisakichiaki", null, "木崎", "ちあき", "Chiaki Kisaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46082/Chiaki_Kisaki", "http://kisakichiaki.blog.fc2.com/" },
                    { 46132, null, null, "坂上", "秋成", "Shuusei Sakagami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46132/Shuusei_Sakagami", null },
                    { 46196, null, null, "長岡", "千秋", "Chiaki Nagaoka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46196/Chiaki_Nagaoka", null },
                    { 46230, null, null, "風", "忍", "Shinobu Kaze", "https://cdn.myanimelist.net/images/voiceactors/1/66738.jpg", "https://myanimelist.net/people/46230/Shinobu_Kaze", null },
                    { 46244, "Doujin circle: Brio\n\nTwitter: @puyocha_brio\npixiv: #25004", null, "ぷよちゃ", null, "Puyocha", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46244/Puyocha", "http://yo-brio.cc/" },
                    { 46444, "Twitter: @ablbex\npixiv: #5047407", null, "サカガキ", null, "Sakagaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46444/Sakagaki", null },
                    { 46458, "Twitter: @ahrico, @info_yasuda", null, "あり子", null, "Ariko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46458/Ariko", "http://fareastblade.wixsite.com/y-gallery" },
                    { 46641, "Twitter: @k_i10oo\nTumblr: https://zot-gloomy.tumblr.com/", null, "伊藤", "亰", "Kei Itou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46641/Kei_Itou", null },
                    { 46700, "Twitter: @mariyasu_ame\npixiv: #7721469", null, "安井", "万里絵", "Marie Yasui", "https://cdn.myanimelist.net/images/voiceactors/1/67623.jpg", "https://myanimelist.net/people/46700/Marie_Yasui", "http://amagoyasairuiu.web.fc2.com/" },
                    { 46792, null, new DateTime(1953, 4, 27, 17, 0, 0, 0, DateTimeKind.Local), "佐藤", "シュガー", "Sugar Satou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46792/Sugar_Satou", null },
                    { 46835, "Doujin circle: TKMC\n\nTwitter: @jyaian3399\npixiv: #134919", null, "じゃいあん", null, "Jaian", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46835/Jaian", null },
                    { 46888, "Twitter: @ikada_kai\npixiv: #21326958", null, "伊科田", "海", "Kai Ikada", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46888/Kai_Ikada", null },
                    { 46945, null, null, "小坂", "泰之", "Yasuyuki Kosaka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46945/Yasuyuki_Kosaka", null },
                    { 46982, "Twitter: @yosh_bana", null, "吉田", "ばな", "Bana Yoshida", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/46982/Bana_Yoshida", null },
                    { 47072, "Twitter: @akirasanba", null, "相模", "映", "Akira Sagami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47072/Akira_Sagami", null },
                    { 47150, "Twitter: @pomujoynet1\npixiv: #2302136", null, "ぽむ", null, "Pomu", "https://cdn.myanimelist.net/images/voiceactors/3/64246.jpg", "https://myanimelist.net/people/47150/Pomu", "https://pom-official.jp/" },
                    { 47160, "pixiv: #1089211", null, "横溝", "大輔", "Daisuke Yokomizo", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47160/Daisuke_Yokomizo", "http://web.archive.org/web/20150218041246/www.zombiedogs.net/" },
                    { 47205, "Twitter: @tamuhime", null, "田村", "ゆうき", "Yuki Tamura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47205/Yuki_Tamura", null },
                    { 47228, "Doujin circle: Nazunaya Honpo (薺屋本舗)\n\nTwitter: @miku7zu7\npixiv: #2405344", null, "7zu7", null, "7zu7", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47228/7zu7", "http://na2naya.blog.fc2.com/" },
                    { 47268, "Female\n\nTwitter: @matsuki0001025\npixiv: #4334553\nTumblr: @matsuki-tou", null, "マツキ", "トウ", "Tou Matsuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47268/Tou_Matsuki", null },
                    { 47275, null, null, "花小路", "ゆみ", "Yumi Hanakouji", "https://cdn.myanimelist.net/images/voiceactors/2/56939.jpg", "https://myanimelist.net/people/47275/Yumi_Hanakouji", "https://hanakomugi.sakura.ne.jp/" },
                    { 47297, "Doujin circle: Kaijou Noumu\n\nTwitter: @tu_neo\npixiv: #11179326", null, "常石", "ツネオ", "Tsuneo Tsuneishi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47297/Tsuneo_Tsuneishi", "http://tuneo3.tumblr.com/" },
                    { 47372, "Twitter: @sanchecheco", null, "三宮", "宏太", "Kouta Sannomiya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47372/Kouta_Sannomiya", null },
                    { 47379, "Twitter: @fnt_shinpei\npixiv: #19955899", new DateTime(1989, 4, 10, 17, 0, 0, 0, DateTimeKind.Local), "船津", "紳平", "Shinpei Funatsu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47379/Shinpei_Funatsu", null },
                    { 47494, "Twitter: @amphibianplane", null, "鰤尾", "みちる", "Michiru Burio", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47494/Michiru_Burio", null },
                    { 47572, "Twitter: @hinottam\npixiv: #226142", null, "日野", "行望", "Ikumi Hino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47572/Ikumi_Hino", null },
                    { 47691, "Twitter: @takada_fsan", null, "タカダ", "フミ子", "Fumiko Takada", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47691/Fumiko_Takada", null },
                    { 47848, "Takahiro Ozawa is one-half of the mangaka duo UME.", null, "小沢", "高広", "Takahiro Ozawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/47848/Takahiro_Ozawa", null },
                    { 47924, "Birth Place: Iwate Prefecture, Japan\nZodiac: Pisces\n\nTwitter/𝕏:\n@jujutsuAkutami", new DateTime(1992, 2, 25, 16, 0, 0, 0, DateTimeKind.Local), "芥見", "下々", "Gege Akutami", "https://cdn.myanimelist.net/images/voiceactors/3/77961.jpg", "https://myanimelist.net/people/47924/Gege_Akutami", null },
                    { 48092, null, new DateTime(1965, 8, 13, 17, 0, 0, 0, DateTimeKind.Local), "岡田", "あーみん", "Aamin Okada", "https://cdn.myanimelist.net/images/voiceactors/2/52883.jpg", "https://myanimelist.net/people/48092/Aamin_Okada", null },
                    { 48119, "pixiv: #31818046", null, "かんば", "まゆこ", "Mayuko Kanba", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/48119/Mayuko_Kanba", null },
                    { 48133, "Twitter: @kwkm27c\npixiv: #84035", null, "KWKM", null, "KWKM", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/48133/KWKM", "http://kwkmkwkm.blog.fc2.com/" },
                    { 48165, "Doujin circle: moon sally\n\nTwitter: @arikanrobo\npixiv: #2183479", null, "ありかん", null, "Arikan", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/48165/Arikan", null },
                    { 48195, "Twitter: @bekkourico\npixiv: #1107939", null, "べっこう", "リコ", "Riko Bekkou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/48195/Riko_Bekkou", "http://pignonkurun.blog.fc2.com/" },
                    { 48250, "Twitter: @sabudeath", null, "宮島", "京平", "Kyouhei Miyajima", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/48250/Kyouhei_Miyajima", null },
                    { 48641, "Twitter: @k_shigenobu", null, "重信", "康", "Kou Shigenobu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/48641/Kou_Shigenobu", null },
                    { 48846, "Twitter: @anneko_anko\npixiv: #1472823", null, "あんねこ", null, "Anneko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/48846/Anneko", "http://cha-gyu.tumblr.com/" },
                    { 48851, "Female\n\nTwitter: @oimoto\npixiv: #7154", null, "おいもと", "じろう", "Jirou Oimoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/48851/Jirou_Oimoto", null },
                    { 48856, null, new DateTime(1981, 2, 22, 16, 0, 0, 0, DateTimeKind.Local), "大塚", "隆史", "Takashi Ootsuka", "https://cdn.myanimelist.net/images/voiceactors/3/56732.jpg", "https://myanimelist.net/people/48856/Takashi_Ootsuka", null },
                    { 48970, "Twitter: @kyouichi_16\npixiv: #10687", null, "京一", null, "Kyouichi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/48970/Kyouichi", "http://sputnik.boy.jp/" },
                    { 49044, "Twitter: @ekakibit\npixiv: #19075", null, "えかきびと", null, "Ekakibit", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49044/Ekakibit", "https://www.ekakibit.com/" },
                    { 49101, "Twitter: @garakutayan\npixiv: #127799", null, "言寺", "あまね", "Amane Kotodera", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49101/Amane_Kotodera", null },
                    { 49103, null, null, "帆上", "夏希", "Natsuki Hokami", "https://cdn.myanimelist.net/images/voiceactors/1/55914.jpg", "https://myanimelist.net/people/49103/Natsuki_Hokami", null },
                    { 49111, "Twitter: @fujino114\npixiv: #12284281", null, "富士", "フジノ", "Fujino Fuji", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49111/Fujino_Fuji", null },
                    { 49152, null, null, "逢沢", "大介", "Daisuke Aizawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49152/Daisuke_Aizawa", null },
                    { 49173, "Matsuura was previously an assistant to Shiro Usazaki.\n\nTwitter: @matsukenmanga", null, "松浦", "健人", "Kento Matsuura", "https://cdn.myanimelist.net/images/voiceactors/3/56278.jpg", "https://myanimelist.net/people/49173/Kento_Matsuura", null },
                    { 49316, null, null, "土城", "温美", "Harumi Doki", "https://cdn.myanimelist.net/images/voiceactors/2/56550.jpg", "https://myanimelist.net/people/49316/Harumi_Doki", null },
                    { 49502, "Twitter: @a110ami\npixiv: #30082144", null, "じゅうあみ", null, "Juuami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49502/Juuami", "http://goshogosho.blog.shinobi.jp/" },
                    { 49504, "Twitter: @fukuma333\npixiv: #2681983", null, "東", "ふゆ", "Fuyu Azuma", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49504/Fuyu_Azuma", null },
                    { 49538, "Male\nDoujin circle: Chachabatake.\n\nTwitter: @ataruarata\npixiv: #2463004", null, "神地", "あたる", "Ataru Kamichi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49538/Ataru_Kamichi", "https://chachabatake.tumblr.com/" },
                    { 49588, "Doujin circle: Uro no Fukurou.\n\nTwitter: @hagane_redoak\npixiv: #1617408", null, "赤樫", null, "Akagashi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49588/Akagashi", "https://redoak83.tumblr.com/" },
                    { 49592, "Following Miura's death in 2021, Studio Gaga became the artists for Berserk from chapter 365 onward following the manga's nine month hiatus.\n\n(Source: Berserk Wiki)", null, "スタジオ我画", null, "Studio Gaga", "https://cdn.myanimelist.net/images/voiceactors/1/70000.jpg", "https://myanimelist.net/people/49592/Studio_Gaga", null },
                    { 49645, "Twitter: @as_sakki; @wanpakudana", null, "明日香", "さつき", "Satsuki Asuka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49645/Satsuki_Asuka", null },
                    { 49667, null, null, "추공", null, "Chugong", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49667/Chugong", null },
                    { 49668, "Jang Sung-rak passed away on July 23, 2022 due to a brain hemorrhage caused by chronic illnesses.", null, "장", "성락", "Sung-rak Jang", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49668/Sung-rak_Jang", null },
                    { 49731, "Twitter: @hayasejyun\npixiv: #24807578", null, "早瀬", "ジュン", "Jun Hayase", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49731/Jun_Hayase", null },
                    { 49768, "Gender: Male\n\nTwitter: @takuma06ishii\npixiv: #1062914", null, "石井", "たくま", "Takuma Ishii", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49768/Takuma_Ishii", null },
                    { 49771, "Twitter: @naka29maru", null, "なかまる", null, "Nakamaru", "https://cdn.myanimelist.net/images/voiceactors/3/57206.jpg", "https://myanimelist.net/people/49771/Nakamaru", null },
                    { 49794, null, null, "橋本", "悠", "Yuu Hashimoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49794/Yuu_Hashimoto", null },
                    { 49797, "Twitter: @mahcdai\npixiv: #2195061", null, "マッハダイ", null, "Mahcdai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49797/Mahcdai", null },
                    { 49798, null, null, "宮田", "由佳", "Yuka Miyata", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49798/Yuka_Miyata", null },
                    { 49881, "Twitter: @yo_240", null, "西尾", "洋一", "Youichi Nishio", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49881/Youichi_Nishio", null },
                    { 49882, "Twitter: @zappon11", null, "ざっぽん", null, "Zappon", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49882/Zappon", null },
                    { 49897, "Twitter: @ryoshigami", new DateTime(1989, 2, 17, 16, 0, 0, 0, DateTimeKind.Local), "吉上", "亮", "Ryou Yoshigami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49897/Ryou_Yoshigami", null },
                    { 49934, "Real name: Jong-hui Lee (이 종휘)", null, "SIU", null, "SIU", "https://cdn.myanimelist.net/images/voiceactors/2/57497.jpg", "https://myanimelist.net/people/49934/SIU", "http://blog.naver.com/inutero3334" },
                    { 49943, "Twitter: @hatipisuotome", null, "八美☆わん", null, "Hachipisuwan", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49943/Hachipisuwan", "https://wanhatimi.wixsite.com/hatihikinoowan" },
                    { 49959, null, null, "五示", "正司", "Shouji Goji", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/49959/Shouji_Goji", null },
                    { 50160, "Twitter: @imanoyukiplus", null, "今野", "ユウキ", "Yuuki Imano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/50160/Yuuki_Imano", null },
                    { 50208, "Twitter: @triplepeach\npixiv: #2606857", null, "La-na", null, "La-na", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/50208/La-na", null },
                    { 50306, null, null, "戸塚", "慶文", "Yoshifumi Tozuka", "https://cdn.myanimelist.net/images/voiceactors/1/62509.jpg", "https://myanimelist.net/people/50306/Yoshifumi_Tozuka", null },
                    { 50327, "Twitter: @uyoshi19\npixiv: #60074", null, "鵜吉", "しょう", "Shou Uyoshi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/50327/Shou_Uyoshi", "http://mihamanonacchan.blog122.fc2.com/" },
                    { 50382, "Twitter: @almostdead2012\npixiv: #22967220", null, "殆ど死んでいる", null, "Hotondo Shindeiru", "https://cdn.myanimelist.net/images/voiceactors/3/59251.jpg", "https://myanimelist.net/people/50382/Hotondo_Shindeiru", "http://www.almostdeadbydawn.com/" },
                    { 50439, null, null, "甲本", "一", "Hajime Koumoto", "https://cdn.myanimelist.net/images/voiceactors/2/66845.jpg", "https://myanimelist.net/people/50439/Hajime_Koumoto", null },
                    { 50484, "Female\nDoujin circle: Shohousen (しょほうせん)\n\nTwitter: @_yurubafa_\npixiv: #13662289", null, "ばふぁこ", null, "Bafako", "https://cdn.myanimelist.net/images/voiceactors/1/58224.jpg", "https://myanimelist.net/people/50484/Bafako", null },
                    { 50576, "Twitter: @roboco_hizanapa", null, "宮崎", "周平", "Shuuhei Miyazaki", "https://cdn.myanimelist.net/images/voiceactors/2/82591.jpg", "https://myanimelist.net/people/50576/Shuuhei_Miyazaki", null },
                    { 50587, null, null, "後藤", "冬吾", "Tougo Gotou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/50587/Tougo_Gotou", null },
                    { 50623, "Twitter: @nabe4k", null, "鍋敷", null, "Nabeshiki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/50623/Nabeshiki", null },
                    { 50675, "Doujin circle: ZOOYA!\n\nTwitter: @hinako_zooya\npixiv: #5964199\n\nA duo comprised of Ueyama You and Koide Nao.", null, "いのうえ", "ひなこ", "Hinako Inoue", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/50675/Hinako_Inoue", "http://zooya.xii.jp/" },
                    { 50851, "Male\nDoujin circle: Macaroni Size (マカロニサイズ)\n\nTwitter: @gratinbird\npixiv: #543660", null, "グラタン鳥", null, "Gratin-dori", "https://cdn.myanimelist.net/images/voiceactors/1/58540.jpg", "https://myanimelist.net/people/50851/Gratin-dori", "http://gratinbird.blog96.fc2.com/" },
                    { 50922, null, null, "高透", "レイコ", "Reiko Takatou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/50922/Reiko_Takatou", null },
                    { 50996, "Twitter: @tenacitysaho\npixiv: #22056651", new DateTime(1993, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), "手名町", "紗帆", "Saho Tanamachi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/50996/Saho_Tanamachi", null },
                    { 51072, "Male\n\nTwitter: @Yositakakka\npixiv: #3768063", null, "ながやま", "由貴", "Yoshitaka Nagayama", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51072/Yoshitaka_Nagayama", null },
                    { 51098, null, null, "七夕", "さとり", "Satori Tanabata", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51098/Satori_Tanabata", null },
                    { 51099, "Female\n\nTwitter: @nocomi_mi, @itonoco\npixiv: #717070", null, "のこみ", null, "Nokomi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51099/Nokomi", null },
                    { 51146, "Male\nDoujin circle: Fusuma Kissa (ふすま喫茶)\n\nTwitter: @s_hanabi\npixiv: #64345", null, "水中花火", null, "Suichuu Hanabi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51146/Suichuu_Hanabi", "http://fsm-cafe.jugem.jp/" },
                    { 51216, "Twitter: @abetsukasa", new DateTime(1995, 3, 9, 16, 0, 0, 0, DateTimeKind.Local), "アベ", "ツカサ", "Tsukasa Abe", "https://cdn.myanimelist.net/images/voiceactors/1/65587.jpg", "https://myanimelist.net/people/51216/Tsukasa_Abe", null },
                    { 51264, null, null, "うしだ", "ゆうじ", "Yuuji Ushida", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51264/Yuuji_Ushida", null },
                    { 51303, null, null, "沖", "一", "Hajime Oki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51303/Hajime_Oki", null },
                    { 51304, null, null, "暁葉", "悠", "Yuu Akiba", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51304/Yuu_Akiba", null },
                    { 51494, "Female\nDoujin circle: park\n\nTwitter: @kannnco9, @kanco_info\npixiv: #3540496", null, "kanco", null, "kanco", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51494/kanco", "http://wanderingpark.web.fc2.com/" },
                    { 51496, null, null, "上木", "敬", "Kei Kamiki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51496/Kei_Kamiki", null },
                    { 51645, "Blood Type: A\n\nTwitter: @shiroi_hakuto\npixiv: #78826", null, "しろい", "はくと", "Hakuto Shiroi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51645/Hakuto_Shiroi", "http://www.lab-star.net/" },
                    { 51657, "Twitter: @yoshimotoyuki1", null, "吉本", "祐樹", "Yuuki Yoshimoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51657/Yuuki_Yoshimoto", null },
                    { 51720, "Twitter: @ej3lHqlQqk3WIsr", null, "岸馬", "きらく", "Kiraku Kishima", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51720/Kiraku_Kishima", null },
                    { 51756, "Twitter: @hebino_rai", null, "蛇野", "らい", "Rai Hebino", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51756/Rai_Hebino", "https://hebino.wixsite.com/agartha" },
                    { 51880, "Twitter: @koujisouhei", null, "小路", "壮平", "Souhei Kouji", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51880/Souhei_Kouji", null },
                    { 51985, null, null, "かかず", "かず", "Kazu Kakazu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/51985/Kazu_Kakazu", null },
                    { 52026, "Twitter: @hsakari_", null, "保志", "あかり", "Akari Hoshi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52026/Akari_Hoshi", null },
                    { 52028, "Twitter: @___r__a__n", null, "大木戸", "いずみ", "Izumi Ookido", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52028/Izumi_Ookido", null },
                    { 52099, "Twitter: @akazato\npixiv: #193199", null, "赤野", "天道", "Amamichi Akano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52099/Amamichi_Akano", null },
                    { 52126, "Twitter: @DENTAN_san", null, "しょたん", null, "Shotan", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52126/Shotan", null },
                    { 52160, "Twitter: @miraizinA", null, "未来人A", null, "Miraijin A", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52160/Miraijin_A", null },
                    { 52174, "Twitter: @papa0123\npixiv: #303833", null, "PAPA", null, "PAPA", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52174/PAPA", null },
                    { 52294, "Twitter: @bosh_jp060", null, "硬梨菜", null, "Katarina", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52294/Katarina", null },
                    { 52385, "Twitter: @klklkawe", null, "村上", "メイシ", "Meishi Murakami", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52385/Meishi_Murakami", null },
                    { 52401, "Female\nDoujin circle: CO2@\n\nTwitter: @co2_0301\npixiv: #1735301", null, "Bcoca", null, "Bcoca", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52401/Bcoca", "https://bcocaco2.tumblr.com/" },
                    { 52653, null, null, "ほのぼのる500", null, "Honobonoru500", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52653/Honobonoru500", null },
                    { 52661, "Twitter: @honyondeneru\npixiv: #6857236", null, "野際", "かえで", "Kaede Nogiwa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52661/Kaede_Nogiwa", "http://hoshimi.sblo.jp" },
                    { 52663, "Doujin circle: Triple Luck (Triple Luck)\n\nTwitter: @miyoshi0w0\npixiv: #149115", null, "三吉", "汐美", "Shiomi Miyoshi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52663/Shiomi_Miyoshi", null },
                    { 52708, "Twitter: @petapeto\npixiv: #1200569", null, "瀬田U", null, "Seta U", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/52708/Seta_U", null },
                    { 52773, null, new DateTime(1993, 7, 5, 17, 0, 0, 0, DateTimeKind.Local), "鈴木", "祐斗", "Yuuto Suzuki", "https://cdn.myanimelist.net/images/voiceactors/3/63308.jpg", "https://myanimelist.net/people/52773/Yuuto_Suzuki", null },
                    { 53122, "Twitter: @aoi_00008\npixiv: #27355285", null, "青井", "聖", "Toshi Aoi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/53122/Toshi_Aoi", null },
                    { 53287, "Twitter: @ameame_honey", null, "雨川", "透子", "Touko Amekawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/53287/Touko_Amekawa", null },
                    { 53332, "Twitter: @mugikoyd1", null, "麦子", null, "Mugiko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/53332/Mugiko", null },
                    { 53460, "Twitter: @yachi_chi_chi", null, "やち", null, "Yachi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/53460/Yachi", null },
                    { 53461, null, null, "丸", "伝次郎", "Denjirou Maru", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/53461/Denjirou_Maru", null },
                    { 53495, "Male\n\nTwitter: @minori_sisiza\npixiv: #1669544", null, "ツカハラ", "ミノリ", "Minori Tsukahara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/53495/Minori_Tsukahara", null },
                    { 53653, "Male\n\nTwitter: @chyko7080\npixiv: #21101", null, "チーコ", null, "Chiiko", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/53653/Chiiko", null },
                    { 53666, "Twitter: @mamm_tagawa", null, "太川", "善之", "Yoshiyuki Tagawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/53666/Yoshiyuki_Tagawa", null },
                    { 53691, null, null, "音木", "ひろし", "Hiroshi Otogi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/53691/Hiroshi_Otogi", null },
                    { 53716, "Twitter: @SUN91651696", null, "燦々", "SUN", "Sun Sun Sun", "https://cdn.myanimelist.net/images/voiceactors/3/62800.jpg", "https://myanimelist.net/people/53716/Sun_Sun_Sun", null },
                    { 53970, "Twitter: @tokochi29", null, "おおはし", null, "Oohashi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/53970/Oohashi", null },
                    { 53974, "Female\n\nTwitter: @kwgc_c\npixiv: #4340895", null, "カワグチ", null, "Kawaguchi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/53974/Kawaguchi", null },
                    { 54004, "He was previously an assistant of Fujimoto Tatsuki on Fire Punch and Chainsaw Man and Yuuji Kaku on Jigokuraku.\n\nTwitter: @TatuYukinobu", null, "龍", "幸伸", "Yukinobu Tatsu", "https://cdn.myanimelist.net/images/voiceactors/2/65368.jpg", "https://myanimelist.net/people/54004/Yukinobu_Tatsu", null },
                    { 54053, "Twitter: @tamago_423", null, "tamago", null, "tamago", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/54053/tamago", "http://www.yotsumi423.com/" },
                    { 54091, "Twitter: @mugetsu_illust\npixiv: #430037", null, "霧月", null, "Mugetsu", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/54091/Mugetsu", null },
                    { 54184, "Doujin circle: Kedama Gyuunyuu\n\nTwitter: @kedamaa\npixiv: #16731", null, "玉之", "けだま", "Kedama Tamano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/54184/Kedama_Tamano", null },
                    { 54512, null, null, "竹田", "羽角", "Hazumi Takeda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/54512/Hazumi_Takeda", null },
                    { 54645, "Twitter: @aya_sirosaki", null, "城咲", "綾", "Aya Shirosaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/54645/Aya_Shirosaki", "https://fusa.sakura.ne.jp/" },
                    { 54697, "Twitter: @uotouoto", null, "魚豊", null, "Uoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/54697/Uoto", null },
                    { 54822, "Twitter: @hatimokumei", null, "八目", "迷", "Mei Hachimoku", "https://cdn.myanimelist.net/images/voiceactors/1/76999.jpg", "https://myanimelist.net/people/54822/Mei_Hachimoku", null },
                    { 54860, "Twitter: @ymkmono\npixiv: #404813", null, "奏", "ユミカ", "Yumika Kanade", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/54860/Yumika_Kanade", null },
                    { 54967, "Twitter: @amamori_takibi", null, "雨森", "たきび", "Takibi Amamori", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/54967/Takibi_Amamori", null },
                    { 54998, null, null, "紫", "大悟", "Daigo Murasaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/54998/Daigo_Murasaki", null },
                    { 55102, "Twitter: @amane218", null, "飛口", "芽衣", "Mei Higuchi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/55102/Mei_Higuchi", null },
                    { 55132, null, null, "KRSG", null, "KRSG", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/55132/KRSG", null },
                    { 55206, "Twitter: @sigyototo_1010, @yutoto_1010", null, "ゆとと", null, "Yutoto", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/55206/Yutoto", null },
                    { 55224, "Twitter: @BTtamako\npixiv: #15779523", null, "豚", "たま子", "Tamako Buta", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/55224/Tamako_Buta", null },
                    { 55291, "Male\n\nTwitter: @fakkuma\npixiv: #40187", null, "ふぁっ熊", null, "Fakkuma", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/55291/Fakkuma", null },
                    { 55459, "Twitter: @appleappleeee\npixiv: #16489158", null, "カネツキ", "マサト", "Masato Kanetsuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/55459/Masato_Kanetsuki", null },
                    { 55529, "Twitter: @Jun_Esaka", null, "江坂", "純", "Jun Esaka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/55529/Jun_Esaka", null },
                    { 55530, "Twitter: @ssdraw", null, "諏訪", "さやか", "Sayaka Suwa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/55530/Sayaka_Suwa", null },
                    { 55732, "Twitter: @tokoroten0109\npixiv: #9886834", null, "樹深", null, "Kimi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/55732/Kimi", null },
                    { 56017, "Twitter: @kirisaki_3\npixiv: #4677314", null, "霧崎", "秀征", "Shuusei Kirisaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/56017/Shuusei_Kirisaki", "http://kirisaki3.web.fc2.com" },
                    { 56152, "Twitter: @xia_hml\npixiv: @xiwa\nTumblr: @紗々音シア (Xia Sasane)", null, "紗々音", "シア", "Shia Sasane", "https://cdn.myanimelist.net/images/voiceactors/1/71281.jpg", "https://myanimelist.net/people/56152/Shia_Sasane", null },
                    { 56183, null, null, "脂小路", "蝉麿", "Semimaro Aburakouji", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/56183/Semimaro_Aburakouji", null },
                    { 56226, "Real name: Hiruta Yukimitsu (蛭田幸充)\nFrom Iwaki, Fukushima Prefecture", new DateTime(1947, 4, 23, 17, 0, 0, 0, DateTimeKind.Local), "蛭田", "充", "Mitsuru Hiruta", "https://cdn.myanimelist.net/images/voiceactors/1/66802.jpg", "https://myanimelist.net/people/56226/Mitsuru_Hiruta", null },
                    { 56389, "Twitter: @AkaShiroKiiro_", null, "赤城", "紀伊呂", "Kiiro Akashiro", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/56389/Kiiro_Akashiro", null },
                    { 56741, "Twitter: @hayhironau", null, "宇城", "はやひろ", "Hayahiro Ushiro", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/56741/Hayahiro_Ushiro", "https://hayahiro823.hatenadiary.org/" },
                    { 57013, "Twitter: @takeya6974\npixiv: #4268627", null, "日崖", "タケ", "Take Higake", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/57013/Take_Higake", null },
                    { 57058, "Twitter: @fukuharamasaya", null, "フクハラ", "マサヤ", "Masaya Fukuhara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/57058/Masaya_Fukuhara", null },
                    { 57952, "Twitter: @tkswk", null, "高瀬", "若弥", "Wakaya Takase", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/57952/Wakaya_Takase", null },
                    { 58144, null, new DateTime(1976, 4, 24, 17, 0, 0, 0, DateTimeKind.Local), "石原", "まこちん", "Makochin Ishihara", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/58144/Makochin_Ishihara", null },
                    { 58414, null, null, "다울", null, "Daul", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/58414/Daul", null },
                    { 58619, "Male\n\nTwitter: @zundacroquette\npixiv: #2050644", null, "ずんだ", "コロッケ", "Croquette Zunda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/58619/Croquette_Zunda", null },
                    { 60477, "Twitter: @OekakiTapioka\npixiv: #20249961\nInstagram: @oekakitapioka_", null, "たぴおか", null, "Tapioka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/60477/Tapioka", null },
                    { 60478, "Twitter: @kazumi_y1226", null, "山口", "和海", "Kazumi Yamaguchi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/60478/Kazumi_Yamaguchi", null },
                    { 61353, "Twitter: @momotachibana28", new DateTime(1984, 2, 27, 16, 0, 0, 0, DateTimeKind.Local), "橘", "もも", "Momo Tachibana", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/61353/Momo_Tachibana", null },
                    { 61354, "Female\n\nTwitter: @ekureea\npixiv: #299299\nInstagram: @uekuraeku", null, "上倉", "エク", "Eku Uekura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/61354/Eku_Uekura", "http://uekuraeku.com/" },
                    { 61409, null, null, "加登屋", "みつる", "Mitsuru Kadoya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/61409/Mitsuru_Kadoya", null },
                    { 61555, null, null, "木村", "慎吾", "Shingo Kimura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/61555/Shingo_Kimura", null },
                    { 61653, "Twitter: @ibastrange", null, "維羽", "裕介", "Yuusuke Iba", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/61653/Yuusuke_Iba", null },
                    { 61726, "Female\n\nTwitter: @inkdaisuki\npixiv: #22592663", null, "蚊っさん", null, "Kassan", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/61726/Kassan", null },
                    { 61728, "Male\n\nTwitter: @0827jona\npixiv: #79724101", null, "城奈", null, "Jouna", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/61728/Jouna", null },
                    { 61753, null, null, "安田", "達矢", "Tatsuya Yasuda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/61753/Tatsuya_Yasuda", null },
                    { 62196, null, null, "大脇", "千尋", "Chihiro Oowaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/62196/Chihiro_Oowaki", null },
                    { 62513, "Twitter: @keiji_ando_w", null, "安藤", "敬而", "Keiji Andou", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/62513/Keiji_Andou", null },
                    { 62688, "Twitter: @kakage0904, @gogogorirarara\nYouTube: @kakage_truth\n\nKakage  is an independent male Japanese VTuber and illustrator. He is best known for his coloring technique inspired by the Granblue Fantasy franchise, as a hololive fan, and recently, as the character designer of Takane Lui. \n\n(Source: Virtual YouTuber Wiki)", null, "かかげ", null, "Kakage", "https://cdn.myanimelist.net/images/voiceactors/1/71755.jpg", "https://myanimelist.net/people/62688/Kakage", null },
                    { 62741, "Twitter: @momomo_egi", null, "もえぎ", "桃", "Momo Moegi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/62741/Momo_Moegi", null },
                    { 62963, "Japanese novelist, science fiction investigator and planetarium screenwriter.\n\nTwitter: @7u7a_takashima", null, "高島", "雄哉", "Yuuya Takashima", "https://cdn.myanimelist.net/images/voiceactors/3/73097.jpg", "https://myanimelist.net/people/62963/Yuuya_Takashima", null },
                    { 63820, null, null, "DISCIPLES", null, "Disciples", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/63820/Disciples", null },
                    { 65405, "Twitter: @tunakansuda", null, "須田", "綱鑑", "Tsunakan Suda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/65405/Tsunakan_Suda", null },
                    { 67066, null, null, "はの", "まきみ", "Makimi Hano", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/67066/Makimi_Hano", null },
                    { 67668, "Twitter: @MitsuruYoshioka", null, "吉岡", "みつる", "Mitsuru Yoshioka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/67668/Mitsuru_Yoshioka", null },
                    { 67703, null, null, "桜井", "寛", "Yutaka Sakurai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/67703/Yutaka_Sakurai", null },
                    { 68369, "Twitter: @teradakenichi", null, "寺田", "ケンイチ", "Kenichi Terada", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/68369/Kenichi_Terada", null },
                    { 69085, "Twitter: @kaorumorishita\npixiv: #10916", null, "森下", "薫", "Kaoru Morishita", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/69085/Kaoru_Morishita", null },
                    { 69420, "Twitter: @omecha_aozr", null, "藤岡", "建機", "Kenki Fujioka", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/69420/Kenki_Fujioka", "http://www.ceres.dti.ne.jp/~omecha/" },
                    { 69552, "Twitter: @SO1___50", null, "五十嵐", "惣一", "Souichi Igarashi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/69552/Souichi_Igarashi", null },
                    { 69553, "Twitter: @D19980912", null, "三浦", "蓮", "Ren Miura", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/69553/Ren_Miura", null },
                    { 70353, null, null, "香月", "照葉", "Teriha Katsuki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/70353/Teriha_Katsuki", null },
                    { 71149, null, null, "饅頭屋", "餡子", "Anko Manjuuya", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/71149/Anko_Manjuuya", null },
                    { 71361, "Twitter: @enmr39\npixiv: #9829659", null, "榎丸", "さく", "Saku Enomaru", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/71361/Saku_Enomaru", null },
                    { 71563, "Twitter: @m6t2k1\npixiv: #371166\nInstagram: @m6t2k1", new DateTime(1988, 6, 5, 17, 0, 0, 0, DateTimeKind.Local), "東大路", "ムツキ", "Mutsuki Higashiouji", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/71563/Mutsuki_Higashiouji", "https://m6t2k1.localinfo.jp/" },
                    { 71627, null, new DateTime(1965, 3, 2, 16, 0, 0, 0, DateTimeKind.Local), "池田", "恵", "Kei Ikeda", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/71627/Kei_Ikeda", null },
                    { 73731, "Twitter: @kananren", null, "華南", "恋", "Len Kanan", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/73731/Len_Kanan", null },
                    { 76140, "Twitter: @ookawatetsu", null, "大川", "哲", "Tetsu Ookawa", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/76140/Tetsu_Ookawa", null },
                    { 76549, "Twitter: @misaki_renka", null, "岬", "れんか", "Renka Misaki", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/76549/Renka_Misaki", null },
                    { 76585, null, null, "wagi", null, "wagi", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/76585/wagi", null },
                    { 76909, "Twitter: @8keyin8686", null, "8KEY", null, "8KEY", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/76909/8KEY", null },
                    { 77248, "Artist for Redice Studio.", null, "JIN", null, "Jin", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/77248/Jin", null },
                    { 77660, null, null, "カサイ", "ユージ", "Yuuji Kasai", "https://cdn.myanimelist.net/img/sp/icon/apple-touch-icon-256.png", "https://myanimelist.net/people/77660/Yuuji_Kasai", null }
                });

            migrationBuilder.InsertData(
                table: "GenresForAnimes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Adventure" },
                    { 3, "Racing" },
                    { 4, "Comedy" },
                    { 5, "Avant Garde" },
                    { 6, "Mythology" },
                    { 7, "Mystery" },
                    { 8, "Drama" },
                    { 9, "Ecchi" },
                    { 10, "Fantasy" },
                    { 11, "Strategy Game" },
                    { 12, "Hentai" },
                    { 13, "Historical" },
                    { 14, "Horror" },
                    { 15, "Kids" },
                    { 17, "Martial Arts" },
                    { 18, "Mecha" },
                    { 19, "Music" },
                    { 20, "Parody" },
                    { 21, "Samurai" },
                    { 22, "Romance" },
                    { 23, "School" },
                    { 24, "Sci-Fi" },
                    { 25, "Shoujo" },
                    { 26, "Girls Love" },
                    { 27, "Shounen" },
                    { 28, "Boys Love" },
                    { 29, "Space" },
                    { 30, "Sports" },
                    { 31, "Super Power" },
                    { 32, "Vampire" },
                    { 35, "Harem" },
                    { 36, "Slice of Life" },
                    { 37, "Supernatural" },
                    { 38, "Military" },
                    { 39, "Detective" },
                    { 40, "Psychological" },
                    { 41, "Suspense" },
                    { 42, "Seinen" },
                    { 43, "Josei" },
                    { 46, "Award Winning" },
                    { 47, "Gourmet" },
                    { 48, "Workplace" },
                    { 49, "Erotica" },
                    { 50, "Adult Cast" },
                    { 51, "Anthropomorphic" },
                    { 52, "CGDCT" },
                    { 53, "Childcare" },
                    { 54, "Combat Sports" },
                    { 55, "Delinquents" },
                    { 56, "Educational" },
                    { 57, "Gag Humor" },
                    { 58, "Gore" },
                    { 59, "High Stakes Game" },
                    { 60, "Idols (Female)" },
                    { 61, "Idols (Male)" },
                    { 62, "Isekai" },
                    { 63, "Iyashikei" },
                    { 64, "Love Polygon" },
                    { 65, "Magical Sex Shift" },
                    { 66, "Mahou Shoujo" },
                    { 67, "Medical" },
                    { 68, "Organized Crime" },
                    { 69, "Otaku Culture" },
                    { 70, "Performing Arts" },
                    { 71, "Pets" },
                    { 72, "Reincarnation" },
                    { 73, "Reverse Harem" },
                    { 74, "Love Status Quo" },
                    { 75, "Showbiz" },
                    { 76, "Survival" },
                    { 77, "Team Sports" },
                    { 78, "Time Travel" },
                    { 79, "Video Game" },
                    { 80, "Visual Arts" },
                    { 81, "Crossdressing" },
                    { 82, "Urban Fantasy" },
                    { 83, "Villainess" }
                });

            migrationBuilder.InsertData(
                table: "GenresForMangas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Adventure" },
                    { 3, "Racing" },
                    { 4, "Comedy" },
                    { 5, "Avant Garde" },
                    { 6, "Mythology" },
                    { 7, "Mystery" },
                    { 8, "Drama" },
                    { 9, "Ecchi" },
                    { 10, "Fantasy" },
                    { 11, "Strategy Game" },
                    { 12, "Hentai" },
                    { 13, "Historical" },
                    { 14, "Horror" },
                    { 15, "Kids" },
                    { 17, "Martial Arts" },
                    { 18, "Mecha" },
                    { 19, "Music" },
                    { 20, "Parody" },
                    { 21, "Samurai" },
                    { 22, "Romance" },
                    { 23, "School" },
                    { 24, "Sci-Fi" },
                    { 25, "Shoujo" },
                    { 26, "Girls Love" },
                    { 27, "Shounen" },
                    { 28, "Boys Love" },
                    { 29, "Space" },
                    { 30, "Sports" },
                    { 31, "Super Power" },
                    { 32, "Vampire" },
                    { 35, "Harem" },
                    { 36, "Slice of Life" },
                    { 37, "Supernatural" },
                    { 38, "Military" },
                    { 39, "Detective" },
                    { 40, "Psychological" },
                    { 41, "Seinen" },
                    { 42, "Josei" },
                    { 44, "Crossdressing" },
                    { 45, "Suspense" },
                    { 46, "Award Winning" },
                    { 47, "Gourmet" },
                    { 48, "Workplace" },
                    { 49, "Erotica" },
                    { 50, "Adult Cast" },
                    { 51, "Anthropomorphic" },
                    { 52, "CGDCT" },
                    { 53, "Childcare" },
                    { 54, "Combat Sports" },
                    { 55, "Delinquents" },
                    { 56, "Educational" },
                    { 57, "Gag Humor" },
                    { 58, "Gore" },
                    { 59, "High Stakes Game" },
                    { 60, "Idols (Female)" },
                    { 61, "Idols (Male)" },
                    { 62, "Isekai" },
                    { 63, "Iyashikei" },
                    { 64, "Love Polygon" },
                    { 65, "Magical Sex Shift" },
                    { 66, "Mahou Shoujo" },
                    { 67, "Medical" },
                    { 68, "Memoir" },
                    { 69, "Organized Crime" },
                    { 70, "Otaku Culture" },
                    { 71, "Performing Arts" },
                    { 72, "Pets" },
                    { 73, "Reincarnation" },
                    { 74, "Reverse Harem" },
                    { 75, "Love Status Quo" },
                    { 76, "Showbiz" },
                    { 77, "Survival" },
                    { 78, "Team Sports" },
                    { 79, "Time Travel" },
                    { 80, "Video Game" },
                    { 81, "Villainess" },
                    { 82, "Visual Arts" },
                    { 83, "Urban Fantasy" }
                });

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

            migrationBuilder.InsertData(
                table: "MangaTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Manga" },
                    { 2, "Light Novel" },
                    { 3, "One-shot" },
                    { 4, "Manhwa" },
                    { 5, "Novel" },
                    { 6, "Doujinshi" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "About", "Established", "ImgUrl", "JpName", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Pierrot ぴえろ (Pierrot Co., Ltd.) is a Japanese animation studio established in May 1979 by former employees of both Tatsunoko Production and Mushi Production. Its headquarters are located in Mitaka, Tokyo. Pierrot is renowned for several worldwide popular anime series, such as Naruto, Bleach, Yu Yu Hakusho, Black Clover, Boruto: Naruto Next Generations, Tokyo Ghoul, and Great Teacher Onizuka.", new DateTime(1979, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/a0524dfa-5a6d-40a7-8a1e-233e3822acb5_600x600_i?s=48123c150ab3365033f471461a50acc6", "ぴえろ", "Pierrot", "https://myanimelist.net/anime/producer/1/Pierrot" },
                    { 2, "Kyoto Animation (Kyoto Animation Co., Ltd.) (often abbreviated KyoAni) is a Japanese animation studio based in Uji, Kyoto Prefecture. Youko Hatta (born Youko Sugiyama), who had previously studied under Osamu Tezuka as an artist at Mushi Production, founded the company with her husband, Hideaki Hatta, in 1981. Kyoto Animation spent its early years doing finishing work for other companies' productions, but opened its own drawing department in 1986, the year following its establishment as a limited company. \n\nBy the mid-90s, the company had developed a strong reputation in the industry, as well as ties to studios such as Gonzo, Shin-Ei Animation, and Sunrise. Kyoto Animation released its first full in-house production—the first Munto OVA—in March 2003, and its first television anime, Full Metal Panic? Fumoffu, in the summer of the same year. \n\nThe company gained worldwide attention on July 18, 2019 when an arson attack destroyed its original studio (known as Studio 1) in Fushimi, claiming the lives of 36 people.", new DateTime(1985, 7, 11, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b066ff17-81d3-40db-b1f2-2927de70c0e3_600x600_i?s=edb149cf051e2d7984975063a1b3b3a7", "京都アニメーション", "Kyoto Animation", "https://myanimelist.net/anime/producer/2/Kyoto_Animation" },
                    { 3, "Gonzo is a Japanese anime studio. In 2002, a merger of Gonzo and Digimation took place, creating the new company Gonzo Digimation. In 2004, the company was renamed back to Gonzo.\n\nIn June 2006, the company signed a long-term output deal with the anime television network, Animax, which resulted in Animax broadcasting all of Gonzo's anime titles across all of its networks around the world, including Japan, Asia, the Indian subcontinent, Latin America and since November 2007 on Southern Africa's DSTV satellite network. In 2008, they decided to stream some of their airing anime on video sites such as YouTube, Crunchyroll, and BOST.\n\nThe studio had a financial problem in their closing account in 2008-2009 term and stated its deficit was estimated over 30 million dollars. As a result, Gonzo was absorbed into its parent company, GDH, and had its management and facilities restructured. On 2009-04-01, the merger was completed, and GDH was renamed as Gonzo.\n\n(Source: Wikipedia)", new DateTime(2000, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8d25fb54-5111-4174-9bee-46298c25adbd_600x600_i?s=1adca46b4f789fd450089b1912573235", "ゴンゾ", "Gonzo", "https://myanimelist.net/anime/producer/3/Gonzo" },
                    { 4, "Bones (Bones Inc.) is a Japanese animation studio based in Suginami, Tokyo. The studio was founded by previous Sunrise producer Masahiko Minami and animators Hiroshi Ousaka and Toshihiro Kawamoto in 1998. Following Sunrise's production model, Bones' founders divided the company into five smaller studios, Studio A-E. \n\nStudio Bones has put out a variety of television and film since its debut project of Hiwou War Chronicles in 2000, including popular anime such as Ouran Koukou Host Club (Ouran High School Host Club), Hagane no Renkinjutsushi: Fullmetal Alchemist (Fullmetal Alchemist: Brotherhood), Boku no Hero Academia (My Hero Academia), and Bungou Stray Dogs", new DateTime(1998, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/969047f0-a8ec-475e-ad0d-6e0d5cd8e17f_600x600_i?s=4145bdb95a29f3fe1447baa8045a7420", "ボンズ", "Bones", "https://myanimelist.net/anime/producer/4/Bones" },
                    { 5, null, new DateTime(1997, 6, 4, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3c2828f1-29bc-4688-9f54-cdb423d3c2c8_600x600_i?s=8d8b84eaf7ba0b22c5f3c8521825c424", "ビィートレイン", "Bee Train", "https://myanimelist.net/anime/producer/5/Bee_Train" },
                    { 6, "Gainax was a Japanese anime studio famous for productions such as The Wings of Honneamise, Nadia: The Secret of Blue Water, Neon Genesis Evangelion, FLCL and Tengen Toppa Gurren Lagann which have gone on to critical acclaim and commercial success, as well as for their association with award-winning anime director and studio co-founder Hideaki Anno.\n\nThe company declared bankruptcy in 2024.\n\n(Source: Wikipedia)", new DateTime(1984, 12, 23, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7bba2118-127e-47a3-855f-0b284689f3da_600x600_i?s=c62c0bef4c82c81b750746955a423f64", "ガイナックス", "Gainax", "https://myanimelist.net/anime/producer/6/Gainax" },
                    { 7, "J.C.Staff (J.C.STAFF Co., Ltd.) is a Japanese animation studio based in Musashino, Tokyo, and a member of The Association of Japanese Animations. Former Tatsunoko Production producer Tomoyuki Miyata founded the studio in January 1986, which specialized in Original Video Animation (OVA) in its early years. J.C.Staff made the move to television with the release of Metal Fighter Miku in the summer of 1994. It has since independently produced or contributed to over 200 animated works.", new DateTime(1986, 1, 17, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/076ec06c-a090-41b5-971e-2fc2ae446f5e_600x600_i?s=5872ea7d2c75469d2d296574a5c8c1fb", "ジェー・シー・スタッフ", "J.C.Staff", "https://myanimelist.net/anime/producer/7/JCStaff" },
                    { 8, null, new DateTime(2010, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8ff6ea00-3e10-436d-b22f-1c2773a9a335_600x600_i?s=61182d7c7bdf74299dc97a0282aee50a", "アートランド", "Artland", "https://myanimelist.net/anime/producer/8/Artland" },
                    { 10, null, new DateTime(1987, 12, 14, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/5b86997d-226e-4870-ae60-e353a78178a0_600x600_i?s=0db04e298454b4278acfb8a2c60c7001", "プロダクション・アイジー", "Production I.G", "https://myanimelist.net/anime/producer/10/Production_IG" },
                    { 11, "Madhouse (MADHOUSE Inc.) is a Japanese animation studio based in Nakano City, Tokyo. Ex-Mushi Production animators—including Masao Maruyama, Osamu Dezaki, Rintarou, and Yoshiaki Kawajiri—are often credited with founding the company in 1972, though Rintarou would not join the studio until 1982. Madhouse primarily did contract work for other studios until the 1990s, when it achieved success independently. Television adaptations of Trigun and Clamp's Cardcaptor Sakura in 1998 were hits domestically and later aired overseas, and the same year director Satoshi Kon's Perfect Blue was released as his first of four critically-acclaimed films with the company. \n\nMadhouse remained successful throughout the 2000s and 2010s, adding director Mamoru Hosoda to its roster and releasing numerous popular television anime, including adaptations of Hajime no Ippo, Death Note, and One Punch Man. Maruyama stepped down from his role as president and left the company in June 2011 to start studio MAPPA.", new DateTime(1972, 10, 16, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e68488ab-f0a0-411f-850a-18fb3e21b96c_600x600_i?s=21618c9c3183ffded748d303a253b637", "マッドハウス", "Madhouse", "https://myanimelist.net/anime/producer/11/Madhouse" },
                    { 13, null, new DateTime(1999, 12, 23, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/a76805ab-8fc9-4d54-972f-9f045f323310_600x600_i?s=de6d912bd687dd08b2466ff84be070cc", "スタジオよんどしい", "Studio 4°C", "https://myanimelist.net/anime/producer/13/Studio_4%C2%B0C" },
                    { 14, null, new DateTime(1976, 10, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/6a9279a7-1aeb-4a2b-bceb-4e7f24fae7b1_600x600_i?s=3550689bfb655805cd6d4d3b3987cc91", "サンライズ", "Sunrise", "https://myanimelist.net/anime/producer/14/Sunrise" },
                    { 15, null, new DateTime(1984, 2, 9, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/89d1d95f-e902-452c-9875-ac246672244f_600x600_i?s=b16cb6ae4cb07072877eb46ee6e98c75", "ソニー・ピクチャーズ・エンタテインメント", "Sony Pictures Entertainment", "https://myanimelist.net/anime/producer/15/Sony_Pictures_Entertainment" },
                    { 16, null, new DateTime(1964, 4, 11, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7487f6bd-13a9-4fc0-b54e-78991671c0ec_600x600_i?s=0a18e73a513430cb5d1b4768aa12ee25", "テレビ東京", "TV Tokyo", "https://myanimelist.net/anime/producer/16/TV_Tokyo" },
                    { 17, "Aniplex is a diversified entertainment company operating worldwide with focus on the planning and production of anime video and music content, its distribution in theaters and broadcast syndication as well as their respective physical and digital products, development of related game apps and merchandise such as figurines and apparel, stage production of musicals and live events, and operating the digital store \"Aniplex Online\" which provides hand-picked items for sale.\nAniplex' fully-owned subsidiaries include the anime production A-1 Pictures, mobile game app developer Quatro A, and Aniplex of America which leads the animation business outside of Japan.\n\n(Source: Official Website)", new DateTime(1995, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ba2241ea-7f83-45b6-9360-1f1d4de0d65a_600x600_i?s=369f1423117062ab3c7f4c7a90b2005a", "アニプレックス", "Aniplex", "https://myanimelist.net/anime/producer/17/Aniplex" },
                    { 18, "Toei Animation (Toei Animation Co., Ltd.) is a Japanese animation studio owned by the Toei Company. Since its founding in 1948, Toei has created a large number of TV series, and films, many of which are popular worldwide. One of them is One Piece. Hayao Miyazaki, Isao Takahata, and Yoichi Kotabe have all worked with the company in the past. Toei is a shareholder in the Japanese anime satellite television network, Animax, along with other well-known anime studios and production companies such as Sunrise, TMS Entertainment and Nihon Ad Systems Inc.\n\nUntil 1998, Toei Animation was known as Toei Doga (東映動画 Tōei Dōga) (although even then the company's official English name was indeed \"Toei Animation Co. Ltd.\"), with \"dōga\" being the original Japanese word. for \"Animation\" which was widely used until the 1970s. Their mascot is the cat Pero.\n\nToei Animation produced the anime versions of many of Go Nagai's works during the 1970s, including Devilman, Cutey Honey, Dororon Enma-kun, and Majokko Tickle (all in association with Nagai's Dynamic Productions).\n\nIn addition to producing anime for domestic consumption in Japan, Toei Animation also provides animation works for many American-made television series, such as Muppet Babies and Many Little Pony. Many of these productions, such as Transformers and G.I. Joe was contracted to them through Sunbow Productions.", new DateTime(1948, 1, 22, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/33d49515-685a-4133-8ad3-41b09197e88d_600x600_i?s=cd6405cb06051286ce2bfbd4ce645443", "東映アニメーション", "Toei Animation", "https://myanimelist.net/anime/producer/18/Toei_Animation" },
                    { 21, "Studio Ghibli (Studio Ghibli, Inc.) is a Japanese animation studio based in Koganei, Tokyo. It is best known for its range of animated feature films, and has also produced several short subjects, television commercials, and two television films. Its mascot and most recognizable symbol is a character named Totoro, a giant spirit inspired by raccoon dogs (Tanuki) and cats from the 1988 anime film My Neighbor Totoro. Among the studio's highest-grossing films are Spirited Away (2001), Howl's Moving Castle (2004) and Ponyo (2008). The studio was founded on June 15, 1985, by the directors Hayao Miyazaki and Isao Takahata and producer Toshio Suzuki, after acquiring Topcraft's assets.", new DateTime(1985, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e6d02dfe-71e9-49d2-bef1-68e585c2605e_600x600_i?s=f8bba4a0f7ae97f80c95e463c7529bd6", "スタジオジブリ", "Studio Ghibli", "https://myanimelist.net/anime/producer/21/Studio_Ghibli" },
                    { 22, null, new DateTime(1975, 6, 2, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/63f3da75-f7bf-4185-9d85-46f21e13b778_600x600_i?s=2fdd87fd0ce5b01e975812a92c5e3a03", "日本アニメーション", "Nippon Animation", "https://myanimelist.net/anime/producer/22/Nippon_Animation" },
                    { 23, null, new DateTime(1983, 8, 22, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/47ae4ab6-b267-4648-8444-5a11c4a5d6c3_600x600_i?s=55b0cc0efe992f8c884af1189c38c1f7", "バンダイビジュアル", "Bandai Visual", "https://myanimelist.net/anime/producer/23/Bandai_Visual" },
                    { 24, null, new DateTime(1983, 10, 11, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/1dbe686e-9724-4b3b-92b9-f1a7dd7dcc49_600x600_i?s=595bdbc32413fd9f6f3c9340218e2379", "スタジオ・ファンタジア", "Studio Fantasia", "https://myanimelist.net/anime/producer/24/Studio_Fantasia" },
                    { 25, null, null, "https://cdn.myanimelist.net/s/common/company_logos/6c00db8a-9839-4024-b992-eb85dbd9ff2c_600x600_i?s=d8bac62ba6441cef3422d177abd4fa3d", null, "Milky Animation Label", "https://myanimelist.net/anime/producer/25/Milky_Animation_Label" },
                    { 27, null, new DateTime(1995, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/71f3fb20-a083-4fa3-9657-36877d608afe_600x600_i?s=d20a9ab4a24d962aac5e06f134faaabd", "ジーベック", "Xebec", "https://myanimelist.net/anime/producer/27/Xebec" },
                    { 28, "OLM (OLM, Inc.), formerly known as Oriental Light &amp; Magic (Oriental Light &amp; Magic, Inc.) prior to June of 1994, is a Japanese animation and production studio based in Setagaya, Tokyo, Japan. Former Gallop and OB Planning employees led by Toshiaki Okuno, Shuukichi Kanda, Shouji Oota, Kunihiko Yuyama, Naohito Takahashi, Yuriko Chiba, Nobuyuki Wasaki, Tsukasa Koitabashi, and Takaya Mizutani established OLM as Oriental Light &amp; Magic (Oriental Light &amp; Magic, Inc.) on October 3, 1990. Since its establishment, OLM now has various subsidiaries — OLM Digital, Inc. (April, 1997); OLM MUSIC, Inc. (June, 2012); OLM Ventures Inc. (June, 2017); OLM Asia SDN BHD (December, 2017); Viracocha Inc. (March, 1997); and Sprite Entertainment, Inc. (May, 2002) — which encompasses the OLM Group. Since April 2016, OLM has been a majority-owned subsidiary of IMAGICA Group.\n\nAs of 2023, the studio is divided into six-production teams: OLM TEAM INOUE, comprised of former employees from TEAM WASAKI led by Takashi Inoue; OLM TEAM KATO, comprised of former employees from TEAM OTA, TEAM IGUCHI, TEAM IWASA, and TEAM KAMEI led by Hiroyuki Kato; OLM TEAM YOSHIOKA, comprised of former employees from TEAM IWASA and TEAM WASAKI led by Daisuke Yoshioka; OLM TEAM MASUDA, led by former MAPPA producer Katsudo Masuda; OLM TEAM ABE, led by former SynergySP producer Isamu Abe; and OLM TEAM MIIKE, a division of OLM Digital which produces live-action works under the direction of Takashi Miike led by Misako Saka.", new DateTime(1994, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4b41f888-3ec1-478e-aadd-882b78b4e3af_600x600_i?s=f2cd42bd452b467ee5deed362ca179d6", "オー・エル・エム", "OLM", "https://myanimelist.net/anime/producer/28/OLM" },
                    { 29, null, new DateTime(1981, 1, 23, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0bb4138f-371b-4159-af4a-3521d34b5cde_600x600_i?s=ae1a3a45fea67990d223d80d6287cefe", "バップ", "VAP", "https://myanimelist.net/anime/producer/29/VAP" },
                    { 30, null, new DateTime(1978, 10, 3, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0e24f6c3-409f-4048-aec0-e3d19db52b01_600x600_i?s=a21878874c2a55e2a0d6162d26c74f0b", "亜細亜堂", "Ajia-do", "https://myanimelist.net/anime/producer/30/Ajia-do" },
                    { 31, "Geneon Universal Entertainment Japan was a Japanese music, anime and home entertainment production and distribution enterprise. It was born as the result of the merger between Geneon Entertainment and Universal Pictures Japan. On 09.12.2013, Geneon Universal Entertainment Japan was renamed to NBCUniversal Entertainment Japan and with this the Geneon brand came to an end.", new DateTime(2009, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e22dd980-926c-41fb-a786-0f450f6d8a54_600x600_i?s=e05fb0c433ff89078c257abd18f3ebb3", "ジェネオン・ユニバーサル・エンターテイメントジャパン", "Geneon Universal Entertainment", "https://myanimelist.net/anime/producer/31/Geneon_Universal_Entertainment" },
                    { 33, null, new DateTime(1984, 12, 24, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/5d55aeba-f595-433a-b547-1288406942ce_600x600_i?s=38ee9f66ce06574add08ace2d6b71538", "WOWOW", "WOWOW", "https://myanimelist.net/anime/producer/33/WOWOW" },
                    { 35, "Seven Arcs (Seven Arcs Co., Ltd.) is a Japanese animation studio based in Musashino, Tokyo, Japan. Seven Arcs Co., Ltd. was established in October 2019 through the merger of Arcturus, Seven Arcs, and Seven Arcs Pictures (Seven Arcs Group) — with Seven Arcs Pictures as the surviving company. Since 2018, the studio has been a wholly-owned subsidiary of TBS Holdings.\n\nThe former Seven Arcs Co., Ltd. was established on May 31, 2002, as a subsidiary of Arcturus, which itself was founded by former Pierrot director — Osamu Kamimura — in April 2000. In April 2012, Seven Arcs Pictures Co., Ltd. was established through an incorporation-type company split from Seven Arcs’ animation production business. Since then, the companies tied to Arcturus — Seven Arcs and Seven Arcs Pictures — comprised the Seven Arcs Group until October 2019.", new DateTime(2019, 10, 6, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0a38dffe-383c-4802-9751-c1577f464ffd_600x600_i?s=bfdc06db95cea2b5036bb6fcc7f815b8", "セブンアークス", "Seven Arcs", "https://myanimelist.net/anime/producer/35/Seven_Arcs" },
                    { 36, "Gallop is a Japanese animation studio founded on December 13, 1978 as Studio Gallop Co,. Ltd. (Japanese: 有限会社スタジオぎゃろっぷ, Yūgengaisha Sutajio Gyaroppu).\n\nOn February 27, 2001, the company name was changed to its current name.\n\nStarting in 1998 with the anime Ojarumaru, the studio used digital ink and paint for the first time.\n\nGallop is known for animating the Yu-Gi-Oh Duel Monsters anime series, its sequels and many more.", new DateTime(1978, 12, 12, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/30b11a46-a29a-49a2-b900-636b4483cb6d_600x600_i?s=9947ca82ddef6ce6101595d3456a2151", "ぎゃろっぷ", "Gallop", "https://myanimelist.net/anime/producer/36/Gallop" },
                    { 37, null, new DateTime(1975, 3, 13, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/77ec0b0b-f27d-4c2a-9952-ebfa895638e1_600x600_i?s=7b5fafdf451ebd4fdb5ddee23c118634", "スタジオディーン", "Studio Deen", "https://myanimelist.net/anime/producer/37/Studio_Deen" },
                    { 38, null, new DateTime(1996, 11, 17, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7ea66047-7ad4-419d-ad7b-62d276d3389d_600x600_i?s=3cfb6bad840b346e5a6923bcbaed34f2", "アームス", "Arms", "https://myanimelist.net/anime/producer/38/Arms" },
                    { 41, null, new DateTime(1995, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b4ec2f63-5dac-41d1-b47c-01353a2f4e3f_600x600_i?s=55b129ea0909459234e82bae5eedb537", "サテライト", "Satelight", "https://myanimelist.net/anime/producer/41/Satelight" },
                    { 42, null, new DateTime(2004, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "GDH", "GDH", "https://myanimelist.net/anime/producer/42/GDH" },
                    { 43, "ufotable is a Japanese animation studio based in Suginami, Tokyo. Hikaru Kondou—a former production assistant at Tokyo Movie Shinsha (now TMS Entertainment) and Telecom Animation Film and producer at Step Eizou—founded the studio in October 2000. The company's name originates from a UFO-shaped table Kondou came across as he was devising the studio's vision. He subsequently acquired the table and named the studio after it. \n\nAt the time of establishment, the studio primarily produced adaptations of novel, manga, and original projects by ASCII Media Works (now Kadokawa), most of which featured wacky comedy and eccentric developments. Following the release of the Kara no Kyoukai (The Garden of Sinners) film series, ufotable came into the spotlight. \n\nContrary to popular belief, the quality of ufotable shows is due to their unusual degree of production independence, in-house talent, and exceptional organization, rather than having vastly higher budgets than other animation studios. \n\nAs of February 2023, the company employs about 240 full-time staff between its Suginami and Tokushima studios, the latter of which was established in April 2009.", new DateTime(2000, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/03171393-4a85-451d-a025-4a3f05d1aede_600x600_i?s=48ebfd25c277dd148d41f88568f60aa6", "ユーフォーテーブル", "ufotable", "https://myanimelist.net/anime/producer/43/ufotable" },
                    { 44, "Shaft (stylized as SHAFT) is a Japanese animation studio headquartered in Suginami, Tokyo, and founded in 1975. Since 2004, the studio's productions have been broadly influenced by director Akiyuki Shinbo, whose visual style and avant-garde cinematography are featured in works including Hidamari Sketch, Sayonara Zetsubou-Sensei, the Monogatari series, Puella Magi Madoka Magica, Nisekoi, and March Comes In Like a Lion.\n\n(Source: Wikipedia)", new DateTime(1975, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/6abfb420-5815-4a62-b978-cbbf9b868fa0_600x600_i?s=5fe7fdaf8e4e09c14c58d7ac6fc29f80", "シャフト", "Shaft", "https://myanimelist.net/anime/producer/44/Shaft" },
                    { 47, null, new DateTime(2006, 5, 16, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e737925d-e804-4a86-ae92-1391eea27c3d_600x600_i?s=2dd5b5a1c33b540b3b9ce017c8c5ba5b", "カラー", "Khara", "https://myanimelist.net/anime/producer/47/Khara" },
                    { 50, "KSS Inc (Japanese: 株式会社ケイエスエス, Hepburn: Kabushiki-gaisha Kei Esu Esu) was a Japanese company that provided anime studio services including production, music, subtitles and translation. \n\nFrom 1993 to 2001, it also developed and published video games.\n\nKSS also created the adult brand Pink Pineapple.\n\nThe company was known for producing Wedding Peach, Comic Party, Ogre Slayer and many more.\n\nIn 2004, KSS went bankrupt and sold its assets to Softgarage.\n\n(Source: Wikipedia)", null, "https://cdn.myanimelist.net/s/common/company_logos/97f360e5-7ec8-4732-86d9-e23273813487_600x600_i?s=49ed414d50f32800d7ea21a78d7c77b0", "ケイエスエス", "KSS", "https://myanimelist.net/anime/producer/50/KSS" },
                    { 51, null, new DateTime(2007, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/eb98e15d-2ad5-4c37-b7ca-afc241b85cc1_600x600_i?s=2b9b09199020eed864457482f358a32b", "ディオメディア", "Diomedéa", "https://myanimelist.net/anime/producer/51/Diomed%C3%A9a" },
                    { 52, null, new DateTime(1988, 4, 10, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8015d24d-34b7-4f3b-9a0c-95d0ad1ae2db_600x600_i?s=c21e5164f1cc528630eb05f0faf30697", "エイベックス", "Avex Entertainment", "https://myanimelist.net/anime/producer/52/Avex_Entertainment" },
                    { 53, null, null, "https://cdn.myanimelist.net/s/common/company_logos/a6c8b6b2-0d89-4c77-a123-dfac19a2615c_600x600_i?s=48c2ce757636e6d7433b439b062a0f93", "電通", "Dentsu", "https://myanimelist.net/anime/producer/53/Dentsu" },
                    { 55, null, new DateTime(1957, 10, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/fcc49782-b409-47ce-a590-12045c3128f4_600x600_i?s=2a80bcc5064b6984d79383150789b319", "テレビ朝日", "TV Asahi", "https://myanimelist.net/anime/producer/55/TV_Asahi" },
                    { 56, "A-1 Pictures (A-1 Pictures Inc.) is a Japanese animation studio in Suginami, Tokyo. Founded by former Sunrise producer Mikihiro Iwata in 2005, it was established as a subsidary of Aniplex. The studio was meant to oversee Aniplex's family-oriented series before it evolved into producing various independent anime projects. \n\nA-1 Pictures has since released popular television anime such as Fairy Tail, Sword Art Online, Nanatsu no Taizai (The Seven Deadly Sins), and Kaguya-sama wa Kokurasetai: Tensai-tachi no Renai Zunousen (Kaguya-Sama: Love is War).", new DateTime(2005, 5, 8, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4713c58b-833f-4c92-bf4a-0e2f7af8a461_600x600_i?s=925a453653da58d385adb82b5d423a69", "A-1 Pictures", "A-1 Pictures", "https://myanimelist.net/anime/producer/56/A-1_Pictures" },
                    { 58, null, new DateTime(2008, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4cd5cb93-3d5d-4588-842f-d5b958e477f8_600x600_i?s=38facdfb072b1a425953e3ad77161e67", "スクウェア・エニックス", "Square Enix", "https://myanimelist.net/anime/producer/58/Square_Enix" },
                    { 60, null, new DateTime(1998, 7, 5, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/10619a5a-b806-4069-a62c-e74be5c6bdff_600x600_i?s=21a09a7adc0b15bda331f578a354f6b6", "アクタス", "Actas", "https://myanimelist.net/anime/producer/60/Actas" },
                    { 61, null, new DateTime(2002, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/a4777f3c-cf95-45cd-a588-1a06f7768b37_600x600_i?s=adabe8d70897c8a6f634afcf9d3eb5e9", "フロンティアワークス", "Frontier Works", "https://myanimelist.net/anime/producer/61/Frontier_Works" },
                    { 62, "Shogakukan-Shueisha Productions (Shogakukan-Shueisha Prouductions Co., Ltd.) (abbreviated as ShoPro) is a subsidiary of Shogakukan, Shueisha, and Hakuensha based in Chiyoda, Tokyo, Japan. Since its establishment as Shogakukan Productions (Shogakukan Productions, Co., Ltd.) in June of 1967 to license and merchandise IPs held by its initial parent Shogakukan, Shogakukan-Shueisha Productions has since grown to as of 2023 operate three-core business segments; the media division, educational development division, and business development division.\n\nIn June 2008, Shogakukan Productions became the current Shogakukan-Shueisha Productions (Shogakukan-Shueisha Productions Co., Ltd.) when Shogakukan’s affiliate, Shueisha, became an investor in the company; for the purpose of being able flexibly deal with the overseas marketplace and to streamline operations. In the following year, Hakusensha, a subsidiary of Shueisha, invested in Shogakukan-Shueisha Productions.", new DateTime(1967, 6, 25, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/c1f831db-f7a7-48ca-b12f-f60e383cab61_600x600_i?s=48c3b3df19cefb710d68f707128778fc", "小学館集英社プロダクション", "Shogakukan-Shueisha Productions", "https://myanimelist.net/anime/producer/62/Shogakukan-Shueisha_Productions" },
                    { 64, null, new DateTime(1965, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3d58ee82-52da-4281-9ea2-cbfe5eaa2a18_600x600_i?s=b14b31057e48c0337341275044eac96f", "創通", "Sotsu", "https://myanimelist.net/anime/producer/64/Sotsu" },
                    { 65, null, new DateTime(1946, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/06a8ff2a-5e73-47db-8be7-9d6972f99be1_600x600_i?s=1a44b470c42ee79eefa57f0eec838f8d", "東京ムービー新社", "Tokyo Movie Shinsha", "https://myanimelist.net/anime/producer/65/Tokyo_Movie_Shinsha" },
                    { 67, null, new DateTime(1981, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "オービー企画", "OB Planning", "https://myanimelist.net/anime/producer/67/OB_Planning" },
                    { 68, null, null, "https://cdn.myanimelist.net/s/common/company_logos/c14136ca-e945-4c12-a79a-ac4e30420d38_600x600_i?s=2c84547eabf1d269668799c297ed838e", "虫プロダクション", "Mushi Production", "https://myanimelist.net/anime/producer/68/Mushi_Production" },
                    { 70, null, new DateTime(2003, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/28e2ca8e-58ad-44fe-9e39-e9c4d99c593b_600x600_i?s=17867fcb16de7723a51acf41576311f0", "ノーマッド", "Nomad", "https://myanimelist.net/anime/producer/70/Nomad" },
                    { 72, null, null, "https://cdn.myanimelist.net/s/common/company_logos/b31bf75a-2606-44ae-8314-839bf448a41f_600x600_i?s=c40c24f243bdc8b0936684c932bfde34", "アートミック", "Artmic", "https://myanimelist.net/anime/producer/72/Artmic" },
                    { 73, "TMS Entertainment Co., Ltd. formerly known as Kyokuichi is a Japanese animation studio owned by Sega Corporation.\n\nTMS is one of the oldest and most renowned animation studios in Japan, known for its numerous anime franchises such as Detective Conan, Lupin the Third, and Anpanman.\n\nTMS Entertainment is the animation business company of the Sega Group and a well-established animation studio with its origins in Tokyo Movie. Originally established in 1946 as a textile manufacturer, the company entered animation when they merged with animation studio Tokyo Movie Shinsha to start an animation production business, known as the Kyokuichi Tokyo Movie division or TMS-Kyokuichi.\n\n(Source: Wikipedia)", new DateTime(1946, 10, 21, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/be6fb172-8033-4f5c-a904-4ad4de90dbdd_600x600_i?s=9cf1899ebb8c743af6c1c54678909b9b", "株式会社トムス・エンタテインメント", "TMS Entertainment", "https://myanimelist.net/anime/producer/73/TMS_Entertainment" },
                    { 76, null, new DateTime(1958, 2, 12, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/070340e3-06da-46ef-bd83-862617537ad7_600x600_i?s=4d32a7e96b3d9224061f442e8e62fbe3", "讀賣テレビ放送", "Yomiuri Telecasting", "https://myanimelist.net/anime/producer/76/Yomiuri_Telecasting" },
                    { 77, "A.P.P.P. (Another Push Pin Planning Company) was founded by Nomura Kazufumi in 1984. A.P.P.P. was involved in the planning and production of a wide variety of animation for television, motion picture, computer software, TV commercials and direct-to-video markets. A.P.P.P. was also involved in publishing music tapes, CDs, and books for the Japanese market.\n\nOn June 10, 2021, Nomura passed away, and since A.P.P.P.'s staff had shrunk significantly by that point, no one offered to take over the position of CEO. Thus, Nomura's familiars liquidated the company's assets and the company was dissolved on July 31 of that same year.", new DateTime(1984, 6, 21, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4395f580-a3b1-43cc-a9a4-2732f4d2ec2f_600x600_i?s=a9b65c520e7587ef57ed2de11cebb842", "アナザープッシュピン・プランニング", "APPP", "https://myanimelist.net/anime/producer/77/APPP" },
                    { 78, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "ピクチャーマジック", "Picture Magic", "https://myanimelist.net/anime/producer/78/Picture_Magic" },
                    { 79, null, new DateTime(1997, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/22bb5e73-47f2-4dab-9ba4-595d946f6ed4_600x600_i?s=b5526d6fa55a8bd8f425a6d984150596", "ジェンコ", "Genco", "https://myanimelist.net/anime/producer/79/Genco" },
                    { 80, null, new DateTime(1967, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/502e200a-a6a8-4976-a8ae-2879bc195bd4_600x600_i?s=f338ff1c905bc26ecb75f6bf123b4ad8", "トランス・アーツ", "Trans Arts", "https://myanimelist.net/anime/producer/80/Trans_Arts" },
                    { 82, "On 2011-10-01, Marvelous Entertainment merged with AQ Interactive and Liveware, thus became Marvelous AQL.", new DateTime(1997, 6, 24, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/a9216925-a4a4-4daf-8956-2ff676c6ed3c_600x600_i?s=48e393f5ed77eb03b57643dc28289c77", "マーベラスエンターテイメント", "Marvelous Entertainment", "https://myanimelist.net/anime/producer/82/Marvelous_Entertainment" },
                    { 84, null, new DateTime(2000, 4, 2, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0a8beeae-21bb-4039-9bfb-caf8919c5372_600x600_i?s=54aae909f2ef8ca4943d640c73e60cea", "スタジオリッカ", "Studio Rikka", "https://myanimelist.net/anime/producer/84/Studio_Rikka" },
                    { 86, "Group TAC Co., Ltd. was a Japanese animation and computer graphics studio located in Shibuya, Tokyo, and founded in 1968 from former Mushi Pro staff. They worked on movies, videos, TV shows, and commercials, and contributed to all stages of the process, including planning, production, sound effects, and so on. The company was headed by Atsumi Tashiro until his death in July 2010.\n\n(Source: Wikipedia)", new DateTime(1998, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7351fe94-49ae-4574-80ac-69b13d0ff956_600x600_i?s=663db8a85a5857d9b2b5d96e938b14e9", "グループ・タック", "Group TAC", "https://myanimelist.net/anime/producer/86/Group_TAC" },
                    { 92, null, null, "https://cdn.myanimelist.net/s/common/company_logos/35b02940-51e9-4f57-aceb-0001963603cf_600x600_i?s=54a0c901834087e82fbf1ea4b0f909b8", "スターチャイルドレコード", "Starchild Records", "https://myanimelist.net/anime/producer/92/Starchild_Records" },
                    { 94, null, new DateTime(1975, 5, 18, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/21fb8c8b-f416-454f-b7bc-90e57f9d7074_600x600_i?s=c8816aa069a296f292d07d2d3a4b16b7", "テレコム・アニメーションフィルム", "Telecom Animation Film", "https://myanimelist.net/anime/producer/94/Telecom_Animation_Film" },
                    { 95, "Doga Kobo (Doga Kobo, inc.) is a Japanese animation studio based in Nerima, Tokyo, Japan. Hideo Furusawa, who participated in the establishment of Toei Animation and NICHIDO SHIN PRO, and Megumu Ishiguro incorporated Doga Kobo, inc. as a limited company in July 1973 and reorganized it into a joint-stock company on July 11, 2006. In the same month, the studio became a majority-owned subsidiary of TYO — alongside its then-other animation subsidiaries Hal Film Maker and Yumeta Company — until its exit from the TYO Group via Ryo Ishiguro’s MBO of TYO’s shares in April 2009. In April 2020, Doga Kobo Animation Department Co., Ltd. was established via an incorporation-type company split from Doga Kobo’s animation department to improve the treatment of its animators.\n\nSince the studio’s entry into animation production with Myself; Yourself in 2007, its notable works include Yuru Yuri (2011), Monthly Girls’ Nozaki Kun (2014), Plastic Memories (2015), New Game (2016), and Oshi No Ko (2023).", new DateTime(1973, 7, 10, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e820af66-29b6-48c2-bfba-43e9bd5d8c27_600x600_i?s=367d70746c45aaa5c1bb7295aeb46820", "動画工房", "Doga Kobo", "https://myanimelist.net/anime/producer/95/Doga_Kobo" },
                    { 96, "Yumeta Company (YUMETA CO., LTD.) is a Japanese animation studio based in Kiyose, Tokyo, Japan. Former Tama Production animator — Satoshi Yamaguchi — founded Yumeta Company as Shizuoka Animation Co., Ltd. on March 5, 1986. Following its establishment in October 1990, the studio changed its name to YUMETA CO., LTD. and became a subsidiary of TYO in January 2005 — alongside its other animation subsidiaries Hal Film Maker and later Doga Kobo. In July 2009, Yumeta Company absorbed Hal Film Maker to form TYO Animations Inc. Satoshi Yamaguchi and Katsunori Haruta — the representative directors at Yumeta Company and Hal Film Maker — were appointed as the representative directors of the new company. In December 2017, Memory Tech Holdings' Graphinica acquired the studio from TYO as a subsidiary and reverted its name to Yumeta Company.\n\nUntil the brand’s initial retirement in 2010, its notable works included Animation Runner Kuromi (2001), La corda d'oro: primo passo (2006), and Miracle Train: Welcome to the Oedo Line (2009). Since the reintroduction of the brand in 2018, it has produced My Sweet Tyrant (2018), Digimon Adventure: Last Evolution Kizuna (2020), Muv Luv Alternative (2021), and Tokyo Mew Mew New (2022).", new DateTime(1990, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/35f4c53e-67d8-498c-877d-44f6e02cad7c_600x600_i?s=4c63441ffe089540d70147644479a355", "ゆめ太カンパニー", "Yumeta Company", "https://myanimelist.net/anime/producer/96/Yumeta_Company" },
                    { 97, null, new DateTime(1992, 8, 16, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9d803694-abb1-4756-b945-e8f241fe8b71_600x600_i?s=81099456238866b65344e53a1828e4db", "ADVフィルム", "ADV Films", "https://myanimelist.net/anime/producer/97/ADV_Films" },
                    { 99, null, new DateTime(1982, 3, 23, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8faff4ba-7a13-4419-8f9a-3e5981f87135_600x600_i?s=a5901579ec071b071b33fece5e9ebaa8", "キティフィルム", "Kitty Films", "https://myanimelist.net/anime/producer/99/Kitty_Films" },
                    { 101, null, new DateTime(1979, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3d832a92-b77d-47c9-aeb6-6df25664caa5_600x600_i?s=408f4c3e510616863c0f77a4a3628df8", "スタジオ雲雀", "Studio Hibari", "https://myanimelist.net/anime/producer/101/Studio_Hibari" },
                    { 102, null, new DateTime(1994, 5, 8, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/487e1ac6-f3d2-41fe-8a02-6b8c1a735587_600x600_i?s=7d16c8191f6b4196d39ff2d814ff4a28", "ファニメーション", "Funimation", "https://myanimelist.net/anime/producer/102/Funimation" },
                    { 103, null, new DateTime(1962, 10, 18, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9ab38042-78ae-46c4-a22d-2a00274d0a48_600x600_i?s=8b45e8f2b5d2f8677545a14f06189c7f", "タツノコプロ", "Tatsunoko Production", "https://myanimelist.net/anime/producer/103/Tatsunoko_Production" },
                    { 104, null, new DateTime(1999, 11, 25, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/26de13e5-d60e-4efa-848f-c3e94fb79386_600x600_i?s=a3e0e1a0ca495e06e1cef82e9e3d7c9e", "ランティス", "Lantis", "https://myanimelist.net/anime/producer/104/Lantis" },
                    { 108, null, new DateTime(2013, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/51c9fbcd-5ae4-457e-8413-1c4599b6f2a6_600x600_i?s=5638f82053eef64e6401b58e378b4cd9", "メディアファクトリー", "Media Factory", "https://myanimelist.net/anime/producer/108/Media_Factory" },
                    { 109, null, null, "https://cdn.myanimelist.net/s/common/company_logos/2c45b753-d7d1-4fe2-b504-fe1c499387ca_600x600_i?s=8c829e9337587d6ab3581f75cb136fcf", "松竹", "Shochiku", "https://myanimelist.net/anime/producer/109/Shochiku" },
                    { 110, null, new DateTime(1986, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/40846f04-26b7-471b-aa5b-f4bf9873e994_600x600_i?s=1575c4e7c65a6de7ec0177c3b1a949e5", "トライアングルスタッフ", "Triangle Staff", "https://myanimelist.net/anime/producer/110/Triangle_Staff" },
                    { 111, null, new DateTime(1950, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/45085bb9-cc6c-47bc-a989-c1c4be31fd73_600x600_i?s=bf41ba333dcbbd276b83ac3fad899ccf", "日本放送協会", "NHK", "https://myanimelist.net/anime/producer/111/NHK" },
                    { 112, null, new DateTime(1996, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f5e7317b-f19c-4975-be95-8a357e31d4f0_600x600_i?s=853a023c1c8b1eccd73c11ff77475d3a", "ブレインズ・ベース", "Brain's Base", "https://myanimelist.net/anime/producer/112/Brains_Base" },
                    { 113, null, new DateTime(1954, 4, 1, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/dd51f756-fcae-47d2-a1ec-07e4a1fa1a02_600x600_i?s=d31cc7c3e9e473d43cd9d8b43d84064b", "角川書店", "Kadokawa Shoten", "https://myanimelist.net/anime/producer/113/Kadokawa_Shoten" },
                    { 118, "SynergySP (SynergySP Co., Ltd.) is a Japanese animation studio which primarily produces animation content for children based in Kogenai, Tokyo, Japan. Former Studio Junio employees led by Minoru Okazaki, Minoru Maeda, and Hiroshi Wagatsuma established Synergy Japan (Synergy Japan Co., Ltd.) in September 1998. In 2005, Shogakukan-Shueisha Productions made the studio into an affiliate and renamed the studio to SynergySP (SynergySP Co., Ltd.). As a result, a joint-management system was formed with Shogakukan-Shueisha Productions and Shogakukan-Shueisha Productions' Toshihiro Nakazawa and Naohiko Furuichi were appointed to the company's board. In 2009, the studio relocated to its current headquarters in Kogenai. In 2011, Toshihiro Nakazawa and Yuriko Nanao succeeded Minoru Okazaki as the studio's representative director. In December 2013, the studio's photography department was transferred to the then-newly established HORNETS (founded by former SynergySP employees). In 2014, the studio became independent from Shogakukan-Shueisha Productions and Nakazawa resigned from his position at the studio. In 2017, the studio became a subsidiary of Shin-Ei Animation. \n\nSince the studio's establishment, it focused on sub-contracting and gross-contracting work from other studios; mainly gross-contracts from Nippon Animation/Nippon Animedia (e.g., Bakuten Shoot Beyblade 2002, Bakuten Shoot Beyblade G Revolution). In 2003, the studio produced its first prime contract work Mermaid Melody Pichi Pichi Pitch (co-production with Actas). After becoming SynergySP in 2005, its focus changed to primarily focusing on contract work from Shogakukan-Shueisha Productions until 2014. The studio is notable for producing works for TV Tokyo's Sunday 10:00 a.m. animation block from 2005-2010 (MÄR, Hayate no Gotoku!, Zettai Karen Children, and Cross Game); with other notable works including: Metal Fight Beyblade: Baku - Metal Fight Beyblade Zero-G (2010-2013), Cross Fight B-Daman - Cross Fight B-Daman eS (2011-2013), and Major S4-S6 (2008-2010).", new DateTime(1998, 9, 23, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/658e634e-161b-4e0d-8e7a-10a364a8ab96_600x600_i?s=6fa71613caa656f38096016171c5cc91", "シナジーSP", "SynergySP", "https://myanimelist.net/anime/producer/118/SynergySP" },
                    { 119, null, new DateTime(1986, 7, 1, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3f6c2da6-4426-47d3-a005-03d67d4d75e7_600x600_i?s=0abbe4e063b60613b00067c04fb66069", "ビズメディア", "VIZ Media", "https://myanimelist.net/anime/producer/119/VIZ_Media" },
                    { 120, null, new DateTime(1999, 1, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b2219a25-f5c6-4b96-94a4-5ea3f145bb41_600x600_i?s=7ba69458628d7d4a9e219930e063b66d", "ティー・エヌ・ケー", "TNK", "https://myanimelist.net/anime/producer/120/TNK" },
                    { 122, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Tokyo Kids", "https://myanimelist.net/anime/producer/122/Tokyo_Kids" },
                    { 123, null, new DateTime(1972, 4, 24, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/a9020d6e-ea20-4c97-8802-2bd415ea6246_600x600_i?s=0225ba4f187fcaef745dc628fb2dd7e9", "ビクターエンタテインメント", "Victor Entertainment", "https://myanimelist.net/anime/producer/123/Victor_Entertainment" },
                    { 126, null, new DateTime(1986, 1, 20, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/aaa566d9-8a79-432c-a8e2-6ed761f9b9f7_600x600_i?s=50cf9332130c9dc1964e19a55d7a7914", "スタジオコメット", "Studio Comet", "https://myanimelist.net/anime/producer/126/Studio_Comet" },
                    { 127, null, new DateTime(1946, 7, 10, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/389bfdcd-82e4-4d3f-b543-9ef242c69fc2_600x600_i?s=156d2141ae8bd0ac678ce8a8b1818a82", "読売広告社", "Yomiko Advertising", "https://myanimelist.net/anime/producer/127/Yomiko_Advertising" },
                    { 134, null, new DateTime(1963, 1, 15, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7f53a537-01cc-4ee4-a992-efaf84d134a0_600x600_i?s=4dd418de248d49ba3a283cde822b76e8", "ホリプロ", "HoriPro", "https://myanimelist.net/anime/producer/134/HoriPro" },
                    { 135, null, new DateTime(1978, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/80f59e7b-fa30-4db7-857d-fe34e6cb2fbd_600x600_i?s=0053d6b423f3c697e05d2f28de27c110", "テレビ東京メディアネット", "MediaNet", "https://myanimelist.net/anime/producer/135/MediaNet" },
                    { 139, null, new DateTime(1975, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4d668feb-0d60-42a4-8ad4-1e639b4b12ff_600x600_i?s=80a263f9b2083f57565cec18246142c8", "日本アドシステムズ", "Nihon Ad Systems", "https://myanimelist.net/anime/producer/139/Nihon_Ad_Systems" },
                    { 140, null, new DateTime(1998, 5, 19, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/de563aad-ecca-4fb9-83a3-2c718db51e2e_600x600_i?s=39850643a8f3630450992f33c73164ee", "アニマックス", "Animax", "https://myanimelist.net/anime/producer/140/Animax" },
                    { 141, null, new DateTime(1972, 11, 6, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ff1dcf61-b570-4622-8779-4b2e85d461ce_600x600_i?s=eeb40aea3261e4aee8a6aa477bb28511", "東映ビデオ", "Toei Video", "https://myanimelist.net/anime/producer/141/Toei_Video" },
                    { 142, null, new DateTime(1956, 3, 18, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/2bbd8c99-861e-4b3d-b5dc-b04510327bbb_600x600_i?s=b754cf40036f8dfa627c45b882a9934d", "アサツー ディ・ケイ", "Asatsu DK", "https://myanimelist.net/anime/producer/142/Asatsu_DK" },
                    { 143, null, new DateTime(2016, 7, 27, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/cbb986ac-d41b-4854-9db2-c4376cbc3e3d_600x600_i?s=cd71d1eb5504a1f91fd75c96f89f1f0d", "毎日放送", "Mainichi Broadcasting System", "https://myanimelist.net/anime/producer/143/Mainichi_Broadcasting_System" },
                    { 144, null, new DateTime(1966, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/07e31170-5608-4a4b-a5c8-6285812f84e2_600x600_i?s=046963c927c007831bce5039195c7680", "ポニーキャニオン", "Pony Canyon", "https://myanimelist.net/anime/producer/144/Pony_Canyon" },
                    { 145, null, new DateTime(2000, 3, 20, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/302aafdc-b145-4c31-a234-732e12d02c19_600x600_i?s=ba7cccca35650443f5d4566af024de82", "TBSテレビ", "TBS", "https://myanimelist.net/anime/producer/145/TBS" },
                    { 146, null, new DateTime(2013, 5, 9, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/73fc88d9-b83e-48f7-a403-60e4dab66a99_600x600_i?s=6fceb27e9d11dd334ea03691b7eee4be", "CBCテレビ", "CBC Television", "https://myanimelist.net/anime/producer/146/CBC_Television" },
                    { 147, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "スカパー・ウェルシンク", "SKY Perfect Well Think", "https://myanimelist.net/anime/producer/147/SKY_Perfect_Well_Think" },
                    { 148, null, new DateTime(1973, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7bf9724c-abe8-44b7-8471-82298560680d_600x600_i?s=695c37bb7b56cb27405701f2e0cadb58", "白泉社", "Hakusensha", "https://myanimelist.net/anime/producer/148/Hakusensha" },
                    { 149, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "SME Visual Works", "https://myanimelist.net/anime/producer/149/SME_Visual_Works" },
                    { 150, null, new DateTime(1980, 8, 9, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9ce92974-2e94-41fc-9d12-8db87a8b2420_600x600_i?s=5590f70e95e686360754c4226f7912bd", "サンリオ", "Sanrio", "https://myanimelist.net/anime/producer/150/Sanrio" },
                    { 153, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "SoftX", "https://myanimelist.net/anime/producer/153/SoftX" },
                    { 155, null, new DateTime(1987, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/1c135281-268f-404c-89d5-b9870a01681f_600x600_i?s=259f6a4d2e22f8418b5bb7c4ad2da6ed", "アニメイト", "animate Film", "https://myanimelist.net/anime/producer/155/animate_Film" },
                    { 156, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Polygram Japan", "https://myanimelist.net/anime/producer/156/Polygram_Japan" },
                    { 157, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "BMG Japan", "https://myanimelist.net/anime/producer/157/BMG_Japan" },
                    { 158, null, new DateTime(1993, 4, 11, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "キッズステーション", "Kids Station", "https://myanimelist.net/anime/producer/158/Kids_Station" },
                    { 159, null, new DateTime(1909, 10, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/735b3323-6275-4965-ba9b-00330ec794c3_600x600_i?s=e528b4d09764261d9832c67951aa8029", "講談社", "Kodansha", "https://myanimelist.net/anime/producer/159/Kodansha" },
                    { 160, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Rondo Robe", "https://myanimelist.net/anime/producer/160/Rondo_Robe" },
                    { 163, null, new DateTime(2003, 10, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8e0262aa-2185-4463-a36d-ec662e56b1ab_600x600_i?s=4737487622007bb89c320b540e974cd4", "アスリード", "asread.", "https://myanimelist.net/anime/producer/163/asread" },
                    { 164, null, new DateTime(1988, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4f699159-772c-4985-9079-6ae9c96afe42_600x600_i?s=78829cb52db7df8fc3138ffc137fcc48", "ディーライツ", "d-rights", "https://myanimelist.net/anime/producer/164/d-rights" },
                    { 165, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Marubeni", "https://myanimelist.net/anime/producer/165/Marubeni" },
                    { 166, null, new DateTime(1983, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/82a7359a-12e4-4643-813f-0c2117115f22_600x600_i?s=febd90a1022c9b46ad9ef3978c56ddb5", "ムービック", "Movic", "https://myanimelist.net/anime/producer/166/Movic" },
                    { 167, null, new DateTime(1960, 6, 2, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b2c1b777-774b-40d5-8c50-83b158be0afd_600x600_i?s=448fb6ab20e1fb6984f91f088900b9bd", "セガ", "Sega", "https://myanimelist.net/anime/producer/167/Sega" },
                    { 168, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Shelty", "https://myanimelist.net/anime/producer/168/Shelty" },
                    { 169, null, new DateTime(1959, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/75adb170-a4a3-4840-88e1-daafe845027c_600x600_i?s=5a432f7425e1d19e188623c1b3bc8618", "フジテレビジョン", "Fuji TV", "https://myanimelist.net/anime/producer/169/Fuji_TV" },
                    { 170, null, null, "https://cdn.myanimelist.net/s/common/company_logos/b96a3d4f-6e75-478a-9457-9c53048d18fb_600x600_i?s=c8db90758ad3ecdddccb526e89fd4785", "IMAGICA Lab.", "Imagica", "https://myanimelist.net/anime/producer/170/Imagica" },
                    { 178, null, new DateTime(2000, 12, 12, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "トリロジー・フューチャースタジオ", "Trilogy Future Studio", "https://myanimelist.net/anime/producer/178/Trilogy_Future_Studio" },
                    { 179, null, new DateTime(2000, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/728b7c78-b269-4434-95bb-f2eea1ae3f32_600x600_i?s=f9a9210557a054a5c584c9cf4d216014", "エー・シー・ジー・ティー", "A.C.G.T.", "https://myanimelist.net/anime/producer/179/ACGT" },
                    { 182, null, null, "https://cdn.myanimelist.net/s/common/company_logos/edcded5e-e1eb-457e-b489-810cac8f916b_600x600_i?s=f0dcad5c68014dc67ddd1d3dac122566", "Age", "Age", "https://myanimelist.net/anime/producer/182/Age" },
                    { 183, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "エイジェント21", "Agent 21", "https://myanimelist.net/anime/producer/183/Agent_21" },
                    { 191, null, new DateTime(1969, 3, 9, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ab7cde2c-0f10-41ac-9a06-52daccd9b220_600x600_i?s=c4d74730bf88fc8fc6718b914173b083", "エイケン", "Eiken", "https://myanimelist.net/anime/producer/191/Eiken" },
                    { 196, "Established by Toshihiko Sato and other artists on December 20, 1975 as Ashi Productions. It changed its name from Ashi Productions to Production Reed Co., Ltd. on November 1, 2007. On February 12, 2019, the company changed its name back to Ashi Productions.", new DateTime(2007, 10, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/cb259e98-cbb9-446e-9b98-196c93dc4d5c_600x600_i?s=994d1f90b51af1e34c3d39e393837de1", "プロダクション リード", "Production Reed", "https://myanimelist.net/anime/producer/196/Production_Reed" },
                    { 200, null, new DateTime(1968, 1, 22, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/56f69115-1e62-4860-b2d5-52b64ee1a637_600x600_i?s=8b8f8c2e00233950cb7b99fbaff04a4b", "手塚プロダクション", "Tezuka Productions", "https://myanimelist.net/anime/producer/200/Tezuka_Productions" },
                    { 204, null, null, "https://cdn.myanimelist.net/s/common/company_logos/b5ac04b3-3a71-4ee2-81ad-6e88e0bd4023_600x600_i?s=8ee839475fa46f8e86024e3b72314c69", "パイオニア エル・ディー・シー", "Pioneer LDC", "https://myanimelist.net/anime/producer/204/Pioneer_LDC" },
                    { 207, null, new DateTime(1972, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/877399fc-3555-4ac2-aac3-c68fcc2645c4_600x600_i?s=4d6d8f7fe48add6a1eee0a2924986275", "マジックバス", "Magic Bus", "https://myanimelist.net/anime/producer/207/Magic_Bus" },
                    { 210, null, new DateTime(1986, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e7963c82-4b82-4d34-b42f-020b8a93af13_600x600_i?s=50be9bbdb5dca58b5936d7beb4caf6bc", "スタジオちゅーりっぷ", "Studio Tulip", "https://myanimelist.net/anime/producer/210/Studio_Tulip" },
                    { 211, null, null, "https://cdn.myanimelist.net/s/common/company_logos/63eea96f-a4be-4229-8b30-8edc64b3f09a_600x600_i?s=3a7971f82e6ff2495de2134f6641140c", "楽音舎", "Rakuonsha", "https://myanimelist.net/anime/producer/211/Rakuonsha" },
                    { 213, null, new DateTime(1984, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4b4abbb0-0da3-46a7-8c46-a8b1283ee214_600x600_i?s=489656da8f67a87382973881b3c156d7", "ハーフ エイチ・ピー スタジオ", "Half H.P Studio", "https://myanimelist.net/anime/producer/213/Half_HP_Studio" },
                    { 217, null, null, "https://cdn.myanimelist.net/s/common/company_logos/7d34c233-327c-4e2d-8d0c-2ca26bd306da_600x600_i?s=4e89f2d74869072ae9250b38063543ee", "のぞみエンターテイメント", "Nozomi Entertainment", "https://myanimelist.net/anime/producer/217/Nozomi_Entertainment" },
                    { 218, null, new DateTime(1998, 1, 22, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/c2458b6a-a856-4dcb-87a8-2dd80d3751fb_600x600_i?s=20212ec370a91316e4338b2661f17011", "ゼクシズ", "Zexcs", "https://myanimelist.net/anime/producer/218/Zexcs" },
                    { 224, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Toshiba EMI", "https://myanimelist.net/anime/producer/224/Toshiba_EMI" },
                    { 229, null, new DateTime(2004, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b0ad506b-a784-4b9b-b48f-3dc3c95a4b00_600x600_i?s=87005760a47acaf7ef6f0e0f5a837482", "アンサー・スタジオ", "The Answer Studio", "https://myanimelist.net/anime/producer/229/The_Answer_Studio" },
                    { 230, null, new DateTime(1950, 7, 4, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8382d884-4a98-46f8-8101-3e949ad579a1_600x600_i?s=cbd2eb685e50588a14af4031c9eacc43", "バンダイ", "Bandai", "https://myanimelist.net/anime/producer/230/Bandai" },
                    { 233, null, null, "https://cdn.myanimelist.net/s/common/company_logos/60b17784-57ec-497c-80d0-1b3778b167ab_600x600_i?s=226b1850e3b9efea2fb948083a3af787", null, "Bandai Entertainment", "https://myanimelist.net/anime/producer/233/Bandai_Entertainment" },
                    { 234, null, new DateTime(1970, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e62f4add-3b84-4b89-b736-d84926d473d6_600x600_i?s=d76b341bffb32f71758f64951389b25a", "オープロダクション", "Oh! Production", "https://myanimelist.net/anime/producer/234/Oh_Production" },
                    { 236, null, null, "https://cdn.myanimelist.net/s/common/company_logos/014a59c1-d532-48ee-9b7d-5d9522ab9669_600x600_i?s=3e3c6ea2e03256eb4bace72c1c9558cf", null, "YTV", "https://myanimelist.net/anime/producer/236/YTV" },
                    { 238, null, new DateTime(2000, 6, 25, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/178dbf98-8923-4bd6-a3a5-b0654a88fc3a_600x600_i?s=37fbe7d8d6aafd769b7760388f1b22de", "エー・ティー・エックス", "AT-X", "https://myanimelist.net/anime/producer/238/AT-X" },
                    { 242, null, new DateTime(1975, 12, 23, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ee71a430-8345-422e-bf00-46240b75759f_600x600_i?s=2265fcfa328b991995c16a2e8a5dedd3", "葦プロダクション", "Ashi Productions", "https://myanimelist.net/anime/producer/242/Ashi_Productions" },
                    { 245, null, new DateTime(1932, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/90c3f77f-d3ec-4313-b5a0-418edfe927f1_600x600_i?s=1776a0ce7b4bee63092a807d89559e07", "東宝", "TOHO", "https://myanimelist.net/anime/producer/245/TOHO" },
                    { 247, null, new DateTime(1976, 9, 8, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b197b47f-10f6-4310-a99b-d11e51663d62_600x600_i?s=4644cee8a9e58e62cfed72140410dd69", "シンエイ動画", "Shin-Ei Animation", "https://myanimelist.net/anime/producer/247/Shin-Ei_Animation" },
                    { 249, null, new DateTime(1986, 6, 2, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/bee29e9e-c1ce-43bd-85d9-a7932cf4a70b_600x600_i?s=f377bf8c41d8fc41ea2786355cbcff5a", "ロボット", "Robot Communications", "https://myanimelist.net/anime/producer/249/Robot_Communications" },
                    { 250, null, new DateTime(1997, 5, 4, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/27f4b4ce-5fe4-4792-b024-1609d94dd188_600x600_i?s=4fe363a06674e92c735c881445ad1501", "Media Blasters", "Media Blasters", "https://myanimelist.net/anime/producer/250/Media_Blasters" },
                    { 252, null, new DateTime(1970, 4, 27, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/911bc3fc-b6f7-41ee-8807-9a67fa83ed2c_600x600_i?s=2c50cdeb426cdd2ece1932e6c82c4423", "4キッズエンタテインメント", "4Kids Entertainment", "https://myanimelist.net/anime/producer/252/4Kids_Entertainment" },
                    { 255, null, null, "https://cdn.myanimelist.net/s/common/company_logos/edac4091-18b1-404b-8f33-bc1d4cc2e257_600x600_i?s=026c47271e62c9f21db4fe367c4a63cf", "Imagi", "Imagi", "https://myanimelist.net/anime/producer/255/Imagi" },
                    { 259, null, null, "https://cdn.myanimelist.net/s/common/company_logos/20f33fa2-9d58-491b-a148-0b441d148eff_600x600_i?s=43551f87fd3e3678b940d39e7fe4431e", "鷹の爪", "Kaeruotoko Shokai", "https://myanimelist.net/anime/producer/259/Kaeruotoko_Shokai" },
                    { 269, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "DiC Entertainment", "https://myanimelist.net/anime/producer/269/DiC_Entertainment" },
                    { 276, null, new DateTime(2001, 12, 26, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0cd055ea-accb-475d-9166-799d9a71dd03_600x600_i?s=f528187fc57470f5e6e63712cd37466d", "ディー・エル・イー", "DLE", "https://myanimelist.net/anime/producer/276/DLE" },
                    { 282, null, new DateTime(2001, 10, 21, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/1faeaf77-216d-47d1-b6b4-2c6ab89feccc_600x600_i?s=bd26f416c4b3d3f6df70254a8ba65988", "幻冬舎コミックス", "Gentosha Comics", "https://myanimelist.net/anime/producer/282/Gentosha_Comics" },
                    { 284, null, null, "https://cdn.myanimelist.net/s/common/company_logos/8d69628b-afa7-40d6-a5ae-f144958e2644_600x600_i?s=4d3cf3320a2e22db506fd6e305fb908e", "セントラルパークメディア", "Central Park Media", "https://myanimelist.net/anime/producer/284/Central_Park_Media" },
                    { 287, null, new DateTime(2007, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/35b70810-c616-495c-8bee-ad27fe52b273_600x600_i?s=0dccf633ec8318c9ff88f309d332a998", "デイヴィッドプロダクション", "David Production", "https://myanimelist.net/anime/producer/287/David_Production" },
                    { 290, null, new DateTime(2008, 3, 2, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/720b6054-9637-436d-851b-da7a1740828e_600x600_i?s=75114ead680445183b369acd185b7307", "キネマシトラス", "Kinema Citrus", "https://myanimelist.net/anime/producer/290/Kinema_Citrus" },
                    { 291, null, new DateTime(2007, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7a3b5971-939c-456e-8d62-2e09bc8a414c_600x600_i?s=887af1b5bacebab80acdf6c62e73e591", "コミックス・ウェーブ・フィルム", "CoMix Wave Films", "https://myanimelist.net/anime/producer/291/CoMix_Wave_Films" },
                    { 298, null, new DateTime(1997, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/a7fd2062-3b87-4e20-b124-3def56dab2ca_600x600_i?s=026763cbea47e36630dd96105fc1143f", "アニマ", "Anima", "https://myanimelist.net/anime/producer/298/Anima" },
                    { 299, null, new DateTime(2004, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "スタジオパストラル", "Studio Pastoral", "https://myanimelist.net/anime/producer/299/Studio_Pastoral" },
                    { 300, "SILVER LINK. (SILVER LINK., Inc.) is a Japanese animation studio based in based in Mitaka City, Tokyo. The studio was founded by former Frontline animation producer Hayato Kaneko in December 2007 and specialized in subcontracting for drawing work. The company also owned two subsidiary studios, BEEP Co. and CONNECT Inc., both of which have been dissolved. In 2020, Asahi Broadcasting Group Holdings aquired SILVER LINK. \n\nSILVER LINK. began producing anime independently with the 2009 debut of Tayutama: Kiss on My Deity. Other notable anime produced by SILVER LINK. include Kokoro Connect (2012), Masamune-kun no Revenge (2017), and Jahy-sama wa Kujikenai (2021).", new DateTime(2007, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/1a9d42cc-7f3d-4a45-8d4d-137d2594e797_600x600_i?s=6d48b120428087576743810225726392", "シルバーリンク", "SILVER LINK.", "https://myanimelist.net/anime/producer/300/SILVER_LINK" },
                    { 306, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "マジックカプセル", "Magic Capsule", "https://myanimelist.net/anime/producer/306/Magic_Capsule" },
                    { 310, null, null, "https://cdn.myanimelist.net/s/common/company_logos/4c071f8c-7b75-4060-9a68-5010b02226ed_600x600_i?s=f14dd54cb78cf694d8d7874b6834dec3", "AnimEigo", "AnimEigo", "https://myanimelist.net/anime/producer/310/AnimEigo" },
                    { 312, "Life Work was a Japanese animation studio that was founded in 1984.\n\nIt was founded by Yutaka Kanda, who previously worked as a producer for Studio Zero and Sunrise with Toru Komori and Ken Aoki after working on Production Loose.\n\nThe studio was known for producing Shounen Ashibe, Shonan Junai Gumi and many more.\n\nLife Work went bankrupt in 2002.", null, "https://cdn.myanimelist.net/images/company_no_picture.png", "ライフワーク", "Life Work", "https://myanimelist.net/anime/producer/312/Life_Work" },
                    { 314, null, new DateTime(2007, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/40ba3310-9602-47fc-beb2-cc346adada09_600x600_i?s=6e3600896f107186d1a8dad0a3222d43", "WHITE FOX", "White Fox", "https://myanimelist.net/anime/producer/314/White_Fox" },
                    { 315, null, new DateTime(2003, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/868105b2-a815-47fc-bc22-3968175bbb29_600x600_i?s=f78bdbe5d7f907ae2ff518f53320927f", "ダックスプロダクション", "DAX Production", "https://myanimelist.net/anime/producer/315/DAX_Production" },
                    { 316, null, new DateTime(1949, 9, 9, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/56124855-de16-4f33-a335-abc11264f54b_600x600_i?s=fe8f25de8e4e5ec9a8064bfc3514cdea", "日本出版販売", "Nippon Shuppan Hanbai (Nippan) K.K.", "https://myanimelist.net/anime/producer/316/Nippon_Shuppan_Hanbai_Nippan_KK" },
                    { 318, null, new DateTime(1976, 5, 14, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ba92d76b-5305-4b31-b6c8-21676f493720_600x600_i?s=a125e916e78c11c28ad87cd9eafd3448", "ワオ・コーポレーション　ワオワールド事業部", "WAO World", "https://myanimelist.net/anime/producer/318/WAO_World" },
                    { 322, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Bee Media", "https://myanimelist.net/anime/producer/322/Bee_Media" },
                    { 323, null, null, "https://cdn.myanimelist.net/s/common/company_logos/51878b78-2480-4efe-b2f2-2900f476f525_600x600_i?s=c1e6ac66cde7ac51f3a5fab0ed2b8b5e", "日本コロムビア", "Nippon Columbia", "https://myanimelist.net/anime/producer/323/Nippon_Columbia" },
                    { 325, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Code", "https://myanimelist.net/anime/producer/325/Code" },
                    { 330, null, new DateTime(2004, 7, 19, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/c3498b96-f531-45f1-b824-eecdceb80bc4_600x600_i?s=26f3fd8dcb5a5c2c44ee279ffd71bc35", "カナバングラフィックス", "Kanaban Graphics", "https://myanimelist.net/anime/producer/330/Kanaban_Graphics" },
                    { 332, null, new DateTime(1972, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4c63ffa2-0dd3-4c7d-bdde-faa346502b74_600x600_i?s=cead35887a9878133ca77a4be1ccad7c", "竹書房", "Takeshobo", "https://myanimelist.net/anime/producer/332/Takeshobo" },
                    { 342, null, new DateTime(1984, 5, 25, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/a69d1c63-00ee-4460-90c4-092943af883a_600x600_i?s=69895298825cf16ffb3617ba268c2a38", "ジャパンホームビデオ", "Japan Home Video", "https://myanimelist.net/anime/producer/342/Japan_Home_Video" },
                    { 352, null, new DateTime(1941, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/78415cee-c1f1-43cd-99e5-60a6feee4710_600x600_i?s=4a3d5c61a27115284e4feb9bf173aa2c", "角川映画", "Kadokawa Pictures Japan", "https://myanimelist.net/anime/producer/352/Kadokawa_Pictures_Japan" },
                    { 372, null, new DateTime(2003, 12, 23, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/869dcd66-b458-4b5d-ba00-7ba89944aee6_600x600_i?s=f11ca3d6ddb5885c1c52fe1b6d17afb2", "NIS America", "NIS America, Inc.", "https://myanimelist.net/anime/producer/372/NIS_America_Inc" },
                    { 376, null, null, "https://cdn.myanimelist.net/s/common/company_logos/3250532a-40d6-42ef-9745-f10a107ce07b_600x600_i?s=89043e9e5f916392922083136d38463d", "センタイ・フィルムワークス", "Sentai Filmworks", "https://myanimelist.net/anime/producer/376/Sentai_Filmworks" },
                    { 381, null, new DateTime(2012, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/bf84b1ef-560b-4593-b86b-437b24af3c1e_600x600_i?s=29f047bd0677cac4a2ad4294df67e86c", "YAMATOWORKS", "Yamato Works", "https://myanimelist.net/anime/producer/381/Yamato_Works" },
                    { 382, null, new DateTime(1954, 3, 18, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d707b480-f493-4524-bc3a-76e8da510e36_600x600_i?s=2647eb018b8e805721f759f2ca94ee9a", "徳間書店", "Tokuma Shoten", "https://myanimelist.net/anime/producer/382/Tokuma_Shoten" },
                    { 386, "In 2007, Animaruya changed it's name to Ekura Animal.", new DateTime(1982, 12, 12, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "アニマル屋", "Animaruya", "https://myanimelist.net/anime/producer/386/Animaruya" },
                    { 392, null, new DateTime(2013, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "エンターブレイン", "Enterbrain", "https://myanimelist.net/anime/producer/392/Enterbrain" },
                    { 397, null, new DateTime(2007, 8, 9, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/76ea23c5-cf21-49d6-bf83-14ff85be4e7b_600x600_i?s=42f88fd0bace82f4c48400128b29cc20", "ブリッジ", "Bridge", "https://myanimelist.net/anime/producer/397/Bridge" },
                    { 399, null, new DateTime(1999, 8, 5, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "ドリーム・フォース", "Dream Force", "https://myanimelist.net/anime/producer/399/Dream_Force" },
                    { 400, null, new DateTime(2015, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/00cb140b-f776-4807-8aa2-fcc761f321c6_600x600_i?s=ef6bc86d8258ff3b4ddce0ca276c36ef", "ギャザリング", "Gathering", "https://myanimelist.net/anime/producer/400/Gathering" },
                    { 406, "Asahi Production was founded in 1973, initially establishing itself as a specialized shooting studio and PR movie company. At its inception, Sunrise Inc. (today part of Bandai Namco Filmworks) and Tokyo Movie Shinsha (today TMS Entertainment) were its first affiliates. Production of promotional videos for large companies and industry organizations, such as the Japan Insurance Association and Asahi Chemical, was the studio's main business.\n\n(Source: Wikipedia)", new DateTime(1973, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/89476290-50d8-4494-b37c-15faeea1bf45_600x600_i?s=9cc6e7a25d8849a34ebddc24f381307c", "旭プロダクション", "Asahi Production", "https://myanimelist.net/anime/producer/406/Asahi_Production" },
                    { 413, null, null, "https://cdn.myanimelist.net/s/common/company_logos/115d296a-8f00-4879-bf51-adc1f2e58ff9_600x600_i?s=8f8c8c1ef0437f0821dde8819e47315a", null, "Pastel", "https://myanimelist.net/anime/producer/413/Pastel" },
                    { 415, "Warner Bros. Japan is the Japanese subsidiary of American company Warner Bros. It has four divisions: Warner Bros. Pictures (ワーナー・ブラザース映画), Warner Bros. Home Entertainment (ワーナー・ブラザース ホームエンターテイメント), Warner Bros. Television (ワーナー・ブラザース テレビジョン), and Warner Bros. Consumer Products (ワーナー・ブラザース コンシューマープロダクツ).", new DateTime(1992, 5, 28, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e0f0e234-1559-4972-bd4e-a345427e73c4_600x600_i?s=0be95499dedf10d91cf0a18d75f0820c", "ワーナーブラザースジャパン", "Warner Bros. Japan", "https://myanimelist.net/anime/producer/415/Warner_Bros_Japan" },
                    { 416, null, new DateTime(1986, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "Toei Animation Phils.", "TAP", "https://myanimelist.net/anime/producer/416/TAP" },
                    { 417, null, null, "https://cdn.myanimelist.net/s/common/company_logos/d9addd15-cd6a-4582-a929-8c0ddb003af5_600x600_i?s=d5e36b887febeac63e38e2020046eb2d", "ウォルト・ディズニー・スタジオ", "Disney Platform Distribution", "https://myanimelist.net/anime/producer/417/Disney_Platform_Distribution" },
                    { 426, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Filmlink International", "https://myanimelist.net/anime/producer/426/Filmlink_International" },
                    { 434, null, new DateTime(1998, 9, 27, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "シナジージャパン", "Synergy Japan", "https://myanimelist.net/anime/producer/434/Synergy_Japan" },
                    { 435, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "スタジオゼロ", "Studio Zero", "https://myanimelist.net/anime/producer/435/Studio_Zero" },
                    { 437, null, new DateTime(2003, 5, 20, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b139f933-1cee-4933-9611-e77034afdea2_600x600_i?s=13bb4c831168eff3f8cfc20835fd8809", "神風動画", "Kamikaze Douga", "https://myanimelist.net/anime/producer/437/Kamikaze_Douga" },
                    { 438, null, null, "https://cdn.myanimelist.net/s/common/company_logos/79fa5111-6a86-4c45-87c2-49e4a83f3e44_600x600_i?s=e55fc8955d1762925729f09525134c24", "スタジオシグナル", "Studio Signal", "https://myanimelist.net/anime/producer/438/Studio_Signal" },
                    { 439, null, new DateTime(2009, 2, 8, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e103b47a-6028-4ea9-b45a-803b1f942171_600x600_i?s=7a08ad10e2c520209736b409b6b237f0", "project No.9", "Project No.9", "https://myanimelist.net/anime/producer/439/Project_No9" },
                    { 441, "Eight Bit was originally Satelight's first studio and was involved in the production of several works including Noein, Sousei no Aquarion and Macross F. It became independent in September 2008 under producer Kasai Tsutomu. Its headquarters is located in Suginami, Tokyo, Japan. The major line of work is planning and production of animation programs and 3DCG work.", new DateTime(2008, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/dc72518a-32a4-4b00-b1df-a8e57d193530_600x600_i?s=00055fe35cb1438d41eb5a80b539fafa", "エイトビット", "8bit", "https://myanimelist.net/anime/producer/441/8bit" },
                    { 442, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "南町奉行所", "Minami Machi Bugyousho", "https://myanimelist.net/anime/producer/442/Minami_Machi_Bugyousho" },
                    { 443, null, new DateTime(2007, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d7096d2a-266f-43f4-8a5e-192f458d69ee_600x600_i?s=25029437f07462c4597a9adee18d78a6", "スタジオぷゆかい", "Studio PuYUKAI", "https://myanimelist.net/anime/producer/443/Studio_PuYUKAI" },
                    { 453, "Tsuburaya Productions is a Japanese special effects studio founded in 1963 by special effects wizard Eiji Tsuburaya and was run by his family, until October 2007, when the family sold the company to advertising agency TYO Inc. The studio is best known for producing the Ultra Series. Since 2007, the head office has been located in Hachimanyama, Setagaya, Tokyo.\n\nThe company also owns an animation studio of the same name where they work on anime series along with OLM, Bee Media, Madhouse and many more.\n\n(Source: Wikipedia)", new DateTime(1963, 4, 11, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ac31ad80-2599-4629-8e46-921e4c5ff176_600x600_i?s=d221b8db8e5b9828b158a74aa77e195c", "株式会社円谷プロダクション", "Tsuburaya Productions", "https://myanimelist.net/anime/producer/453/Tsuburaya_Productions" },
                    { 456, null, null, "https://cdn.myanimelist.net/s/common/company_logos/b8b87c77-acfd-4b97-8838-de5dfdf1e92b_600x600_i?s=a9a7b78dbb45c0fb0d793ac97f8b63df", "ラルケ", "Lerche", "https://myanimelist.net/anime/producer/456/Lerche" },
                    { 459, null, new DateTime(2000, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/292824fe-28f0-4606-91f9-2bed72fb8000_600x600_i?s=cc2b1cbeba5108792705012e6a9977da", "ニトロプラス", "Nitroplus", "https://myanimelist.net/anime/producer/459/Nitroplus" },
                    { 460, null, new DateTime(1997, 1, 23, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d5e6833e-74cb-471b-96d5-5bca02a69523_600x600_i?s=e45af2662fecf00eccf33bf44a7a10d5", "クロックワークス", "KlockWorx", "https://myanimelist.net/anime/producer/460/KlockWorx" },
                    { 463, null, new DateTime(1999, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0cdb4ce2-17bb-4e29-985c-3587b8e229bd_600x600_i?s=7d1d6490ad93cde4f34cbf91268a6304", "M.S.C", "M.S.C", "https://myanimelist.net/anime/producer/463/MSC" },
                    { 464, null, new DateTime(1997, 2, 2, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/096a6434-77f4-4704-baf0-6e8a92200fe2_600x600_i?s=f66123625f26fc953f43bb1b1a5c18da", "フライングドッグ", "flying DOG", "https://myanimelist.net/anime/producer/464/flying_DOG" },
                    { 467, null, null, "https://cdn.myanimelist.net/s/common/company_logos/4d74d6c2-0016-4198-8f7f-2eedb9acd3dd_600x600_i?s=57337d1e794cf16bb67e8b36bcb612f6", "Discotek Media", "Discotek Media", "https://myanimelist.net/anime/producer/467/Discotek_Media" },
                    { 470, null, new DateTime(1986, 1, 27, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3091f3c7-99e7-4b94-8ce6-07bcc4a566ec_600x600_i?s=23da71184e9951395e4d22ea23ba38e0", "ギャガ", "GAGA", "https://myanimelist.net/anime/producer/470/GAGA" },
                    { 474, null, new DateTime(1998, 8, 2, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e1d7d76f-73a5-4ed1-a23c-7d80f5e5483e_600x600_i?s=99bc317fc9a7533b5f0b803690954f34", "小学館ミュージック＆デジタル エンタテイメント", "Shogakukan Music & Digital Entertainment", "https://myanimelist.net/anime/producer/474/Shogakukan_Music___Digital_Entertainment" },
                    { 479, null, new DateTime(1993, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3b5fe315-6bda-41d1-a058-bece1d96b972_600x600_i?s=e3623176712765350c7d332bac76a621", "ドーガ", "DOGA Productions", "https://myanimelist.net/anime/producer/479/DOGA_Productions" },
                    { 484, null, null, "https://cdn.myanimelist.net/s/common/company_logos/1eae1ea1-ebed-4db9-9d44-876edc9ae13f_600x600_i?s=27636b23d2eaf1680224f2a2b8930ad6", "Tokyopop", "Tokyopop", "https://myanimelist.net/anime/producer/484/Tokyopop" },
                    { 486, null, new DateTime(2000, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/82001d59-4e13-41b0-a0e3-931200dc54f6_600x600_i?s=a35ad1e6174ec64ac9c4f60ccfabfe50", "デジタル・フロンティア", "Digital Frontier", "https://myanimelist.net/anime/producer/486/Digital_Frontier" },
                    { 489, "TCJ was an anime studio established in 1952. In 1969, the company's name was changed to Eiken.", new DateTime(1952, 10, 7, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3ed20a83-c085-4478-b403-95cccc19212b_600x600_i?s=c3a3602ec0b71560ea5e3eea26f520e8", "テイ・シー・ジェー", "TCJ", "https://myanimelist.net/anime/producer/489/TCJ" },
                    { 490, null, null, "https://cdn.myanimelist.net/s/common/company_logos/92fa236e-5dc3-493e-af26-aee31285d514_600x600_i?s=24daebbacc8467b92cb396cc7ddbb245", null, "Maiden Japan", "https://myanimelist.net/anime/producer/490/Maiden_Japan" },
                    { 493, null, new DateTime(2005, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/837c71b2-7f72-45b6-a962-4b2f8a6c44d4_600x600_i?s=6d8d6b7a16f67790ca739fc0c97e6aa7", "Aniplex of America", "Aniplex of America", "https://myanimelist.net/anime/producer/493/Aniplex_of_America" },
                    { 494, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Studio Take Off", "https://myanimelist.net/anime/producer/494/Studio_Take_Off" },
                    { 513, null, new DateTime(1912, 9, 9, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3e87cf71-6f79-4475-a7f1-7a9b4d4d6bfd_600x600_i?s=c797a8050b9ce6ba07403534e246a944", "日活", "Nikkatsu", "https://myanimelist.net/anime/producer/513/Nikkatsu" },
                    { 517, null, new DateTime(1985, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/76439beb-12b2-441b-83f4-b1a89f9ee72f_600x600_i?s=8608ca25fe1592f1140a0217755e70e7", "アスミック・エース", "Asmik Ace", "https://myanimelist.net/anime/producer/517/Asmik_Ace" },
                    { 531, null, null, "https://cdn.myanimelist.net/s/common/company_logos/0def2ab9-ad95-4a90-ab6f-3090a1b79bf9_600x600_i?s=5cb41ee169927c63c510798ac6f83383", "イレブンアーツ", "Eleven Arts", "https://myanimelist.net/anime/producer/531/Eleven_Arts" },
                    { 537, null, new DateTime(2006, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/6921c34e-b14f-458e-beb8-9d2d2726002e_600x600_i?s=114602e03869bb7b00da6d57c8c1940c", "サンジゲン", "SANZIGEN", "https://myanimelist.net/anime/producer/537/SANZIGEN" },
                    { 539, null, new DateTime(2011, 10, 26, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ea9ad038-d76e-4996-a89b-f4efab6afce2_600x600_i?s=d7bbbad342101c01497c89c19f17ef9f", "ウルトラスーパーピクチャーズ", "Ultra Super Pictures", "https://myanimelist.net/anime/producer/539/Ultra_Super_Pictures" },
                    { 547, null, new DateTime(1969, 9, 26, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/a6f365ab-81ec-47de-823b-2c7452e2e558_600x600_i?s=6d605acf25a039860489c3c596ccffdf", "ホビージャパン", "Hobby Japan", "https://myanimelist.net/anime/producer/547/Hobby_Japan" },
                    { 553, null, new DateTime(2003, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/27f5d351-6e3f-45dd-bdd1-1eab9470a6eb_600x600_i?s=daaf1edc3d6a60a0437ba3c95f2f331f", "マーヴィージャック", "Marvy Jack", "https://myanimelist.net/anime/producer/553/Marvy_Jack" },
                    { 567, null, new DateTime(1986, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", null, "D.A.S.T Corporation", "https://myanimelist.net/anime/producer/567/DAST_Corporation" },
                    { 569, "MAPPA (MAPPA Co., Ltd.) is a Japanese animation studio founded by Masao Maruyama in June 2011, following his departure from Madhouse. It employs 408 people as of April 2024 between its Tokyo, Osaka and Sendai studios. Maruyama's intent was for the film Kono Sekai no Katasumi ni (In This Corner of the World) to be the studio's first release, though the project would not be complete until 2016. By that time, the studio had already co-produced Sakamichi no Apollon (Kids on the Slope) and Hajime no Ippo: Rising, and released its first original anime—Zankyou no Terror (Terror in Resonance). \n\nThe name MAPPA is an acronym for Maruyama Animation Produce Project Association. Maruyama stepped down as president in 2016 to form Studio M2. He was replaced by former Studio 4°C employee Manabu Ootsuka.", new DateTime(2011, 6, 13, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e3a5163d-3b09-4e98-922b-79180a75539f_600x600_i?s=3289c478fd611569ebccd7ff076151df", "MAPPA", "MAPPA", "https://myanimelist.net/anime/producer/569/MAPPA" },
                    { 577, null, new DateTime(1961, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "東北新社", "Tohokushinsha Film Corporation", "https://myanimelist.net/anime/producer/577/Tohokushinsha_Film_Corporation" },
                    { 587, null, new DateTime(1988, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/08617f06-d3bb-43ea-bdb6-12e15eb7e638_600x600_i?s=98bd72e364bcd0391953bc7b2f743f8c", "トマソン", "Tomason", "https://myanimelist.net/anime/producer/587/Tomason" },
                    { 595, null, null, "https://cdn.myanimelist.net/s/common/company_logos/cdeabbe6-4d42-49ea-b978-b7e9c49ab855_600x600_i?s=e6b68b0abf64de83998180812da51d41", null, "NYAV Post", "https://myanimelist.net/anime/producer/595/NYAV_Post" },
                    { 605, "Established as a subsidiary of Triple A in May 2009 , with the goal of creating original works from the company by Ryosuke Yamada, who was the production desk of Triple A, Takuya Ono, who was in charge of production, and Takeshi Oda, an animator.\n\nThe company name is an abbreviation of \"C hallenge To C hallenge\", and is influenced by the parent company TripleA's corporate philosophy of \"without challenge there is no success\". \nAlthough the business was animation planning and production, after its establishment, it mainly worked as a gross contract for other companies, just like the parent company. Since 2012, he has been in charge of the production of five-minute short animations such as \"Yurumeitsu Kare wa 3D\", and in the form of joint production with other companies, he is in charge of the prime contract production of TV animation series . He often collaborates with production companies and satellites , and has been in charge of many gross contracts for satellite productions even after the start of production.  With the goal of \" someday becoming a prime contractor production company\", we have continued to produce gross contracts, co-productions, and short animations for other companies . Achieved the goal by doing the independent production of TV animation works. Since then, I have mainly been working as a prime contractor, but I have also continued to undertake gross contracts as before. \n\nIn February 2022, we established a finishing department within the company.\n\n(Source: Wikipedia, translated)", new DateTime(2009, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/16a0962f-7718-4824-9453-c0a314238a5c_600x600_i?s=5ac3a45fb6ee57ff7e89ebb95e64c73c", "C2C", "C2C", "https://myanimelist.net/anime/producer/605/C2C" },
                    { 611, null, null, "https://cdn.myanimelist.net/s/common/company_logos/748d22ca-013e-42fd-996b-39e885526908_600x600_i?s=17e4451e3b702d8cb02352504045e1ce", "Sakura Production", "Sakura Production", "https://myanimelist.net/anime/producer/611/Sakura_Production" },
                    { 619, null, new DateTime(1998, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/fd28a1bc-b350-42f6-8d74-2470d3648e0a_600x600_i?s=f2abda523ef986a6eb4e6e4ff1fa614d", "コスパ", "Cospa", "https://myanimelist.net/anime/producer/619/Cospa" },
                    { 621, null, new DateTime(1999, 3, 23, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9bac3f39-5be6-4398-a97a-71ff166c2074_600x600_i?s=fa682f0ed221f885bdc3be6187e3f6a7", "SBクリエイティブ", "SoftBank Creative", "https://myanimelist.net/anime/producer/621/SoftBank_Creative" },
                    { 643, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Trinity Sound", "https://myanimelist.net/anime/producer/643/Trinity_Sound" },
                    { 647, null, new DateTime(2010, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/00fa9fb7-a76c-4522-9a32-c27b3677f34c_600x600_i?s=cd7edcb338e99ad92435018c123da017", "メモリーテック", "Memory-Tech", "https://myanimelist.net/anime/producer/647/Memory-Tech" },
                    { 665, null, new DateTime(1999, 11, 23, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/6617669c-3040-4ad0-b4fd-ec1a785f135e_600x600_i?s=caea514b22ca1d8bc9cac5a95b05efdc", "キャラアニ", "chara-ani.com", "https://myanimelist.net/anime/producer/665/chara-anicom" },
                    { 681, null, new DateTime(2013, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/77d42c8c-21fd-4f71-8f77-ceeb29c18ce0_600x600_i?s=c4373951b399d40919079d3ed2b5bda3", "アスキー・メディアワークス", "ASCII Media Works", "https://myanimelist.net/anime/producer/681/ASCII_Media_Works" },
                    { 689, null, new DateTime(1992, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/2a7a9f1f-18f0-42da-9aa6-9d1deda56ff5_600x600_i?s=857c0a4debf3b1ac2a6594305e1f8e96", "NTTドコモ", "NTT Docomo", "https://myanimelist.net/anime/producer/689/NTT_Docomo" },
                    { 699, null, new DateTime(2003, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/37144a20-e86e-4d26-a61b-915fa8953385_600x600_i?s=db9d52a91e2d3862171eb3e0bac254d7", "feng", "feng", "https://myanimelist.net/anime/producer/699/feng" },
                    { 711, null, new DateTime(2005, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9fbb5f9e-20fb-48d7-b945-e44003fb95ce_600x600_i?s=b21f1aed74c855f49254406bc46ef384", "デルファイサウンド", "Delfi Sound", "https://myanimelist.net/anime/producer/711/Delfi_Sound" },
                    { 715, null, new DateTime(1997, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "ドワンゴ", "Dwango", "https://myanimelist.net/anime/producer/715/Dwango" },
                    { 717, null, new DateTime(1969, 8, 24, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/74a8d097-166b-4420-9272-376f71af134d_600x600_i?s=898ea2e1a289d5587a30436fb361962c", "テレビ東京ミュージック", "TV Tokyo Music", "https://myanimelist.net/anime/producer/717/TV_Tokyo_Music" },
                    { 719, null, new DateTime(2005, 3, 2, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/59a04984-1483-4f46-972c-94318b1022a3_600x600_i?s=2cf2592574130be2768167f301936ac6", "スタジオマウス", "Studio Mausu", "https://myanimelist.net/anime/producer/719/Studio_Mausu" },
                    { 721, null, new DateTime(1998, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "ガンジス", "GANSIS", "https://myanimelist.net/anime/producer/721/GANSIS" },
                    { 737, null, new DateTime(1987, 8, 20, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "ソニー・ミュージックコミュニケーションズ", "Sony Music Communications", "https://myanimelist.net/anime/producer/737/Sony_Music_Communications" },
                    { 741, null, new DateTime(2003, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "東芝エンタテインメント株式会社", "Toshiba Entertainment", "https://myanimelist.net/anime/producer/741/Toshiba_Entertainment" },
                    { 747, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Apollon", "https://myanimelist.net/anime/producer/747/Apollon" },
                    { 751, null, new DateTime(2011, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/195e6608-f8bd-4856-808b-30c24219e1e8_600x600_i?s=de6a20e7dc34fd887267c97b864a73de", "マーベラスAQL", "Marvelous AQL", "https://myanimelist.net/anime/producer/751/Marvelous_AQL" },
                    { 753, null, new DateTime(2008, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ca92bf2e-cf49-4c47-bff7-b12f2821d48e_600x600_i?s=1f0c55c5d97da0bdbad4ee4681db82cc", "ピー・アール・エー", "PRA", "https://myanimelist.net/anime/producer/753/PRA" },
                    { 755, "Jumondo (寿門堂) is a fairly recent Japanese support studio, established in the tail end of 2009. Like many studios similar to them, there's not a great deal of information out there. They usually work with Dogakobo and J.C. Staff, and have a Korean branch based out of Seoul.\n\nDo not confuse with Pixomondo, a visual effects company.", new DateTime(2009, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e944826b-2f6b-40bf-b118-a3e8aa670f06_600x600_i?s=fc6c6252b5a22caad12b058907f42b2e", "寿門堂", "Jumondo", "https://myanimelist.net/anime/producer/755/Jumondo" },
                    { 757, null, new DateTime(1968, 2, 29, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9a1fc97b-4e07-47dc-8728-e8f9dec7818a_600x600_i?s=bca2a2bdee61914596c454e8b096f6bd", "ソニー・ミュージックエンタテインメント", "Sony Music Entertainment", "https://myanimelist.net/anime/producer/757/Sony_Music_Entertainment" },
                    { 761, null, new DateTime(2019, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7688f13c-4600-4841-b3cc-e42f1ec95fd2_600x600_i?s=3590a71887ba474330339eed447d0b7f", "サニーサイドアップ", "Sunny Side Up", "https://myanimelist.net/anime/producer/761/Sunny_Side_Up" },
                    { 763, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Miracle Robo", "https://myanimelist.net/anime/producer/763/Miracle_Robo" },
                    { 769, null, new DateTime(1966, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f0d866b9-654e-4654-a314-5cd8295a84d6_600x600_i?s=0bd143470b293eef040111bcb3c3e2f7", "フジパシフィックミュージック", "Fujipacific Music", "https://myanimelist.net/anime/producer/769/Fujipacific_Music" },
                    { 775, null, new DateTime(2007, 5, 17, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/aa493a7d-bc0b-4105-8a35-da374a159fb3_600x600_i?s=117fc55b45ed7500daaad9b0cd0c017a", "ブシロード", "Bushiroad", "https://myanimelist.net/anime/producer/775/Bushiroad" },
                    { 777, "Showgate is the former name of Hakuhodo DY Music &amp; Partners, a Japanese production company and distributor of films and series.", new DateTime(2003, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/aaca2a95-01e2-4305-87d4-005fa410c6e3_600x600_i?s=059336e35c8866b1edac3ada3a287241", "ショウゲート", "Showgate", "https://myanimelist.net/anime/producer/777/Showgate" },
                    { 783, null, null, "https://cdn.myanimelist.net/s/common/company_logos/991ecebd-8e54-4265-877c-98a081692dd2_600x600_i?s=2d04099541573a3d64480841bf321c20", "GKIDS", "GKIDS", "https://myanimelist.net/anime/producer/783/GKIDS" },
                    { 787, null, new DateTime(1969, 6, 6, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4123a5bd-5e50-4fa3-9056-950ba771f4e2_600x600_i?s=3786c5e6de479063de43cbfcff244add", "ハピネットピクチャーズ", "Happinet Pictures", "https://myanimelist.net/anime/producer/787/Happinet_Pictures" },
                    { 791, null, null, "https://cdn.myanimelist.net/s/common/company_logos/74fa04e6-14ee-4b76-b7db-5b8f7daa7bbf_600x600_i?s=c5e1a4dba8a308c18caaec727bd6f721", "Dentsu Entertainment USA", "Dentsu Entertainment USA", "https://myanimelist.net/anime/producer/791/Dentsu_Entertainment_USA" },
                    { 795, null, new DateTime(1995, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/71adef14-e3fc-4ade-83cd-a01586f7ee4f_600x600_i?s=98d81b7d29d3bbc605cf51035ea5c3c2", "ヤフージャパン", "Yahoo! Japan", "https://myanimelist.net/anime/producer/795/Yahoo_Japan" },
                    { 797, null, new DateTime(1950, 7, 9, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/75e08009-cf3c-47ae-b91b-591131379db1_600x600_i?s=de2b09d0a1c662486624a488810eba68", "芳文社", "Houbunsha", "https://myanimelist.net/anime/producer/797/Houbunsha" },
                    { 799, null, new DateTime(2008, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4bb8a265-7614-4946-8b92-aa60df43112b_600x600_i?s=ac960408f124f844b3c29d973c0adc47", "indigo line", "indigo line", "https://myanimelist.net/anime/producer/799/indigo_line" },
                    { 803, null, new DateTime(2011, 8, 21, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/bc3f892a-8581-45b1-8a95-81b6ac518f3d_600x600_i?s=d2a2e7f05478dbb999b17d35c44445db", "トリガー", "Trigger", "https://myanimelist.net/anime/producer/803/Trigger" },
                    { 807, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Po10tial", "https://myanimelist.net/anime/producer/807/Po10tial" },
                    { 815, null, null, "https://cdn.myanimelist.net/s/common/company_logos/4326e506-fe6e-4eaf-bc06-103e1d39ef26_600x600_i?s=83aa74d7d6d9bcd42bd6079e88a0b9eb", "EMI", "EMI", "https://myanimelist.net/anime/producer/815/EMI" },
                    { 839, null, new DateTime(2012, 2, 21, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/c7537634-ea2e-4e5b-acb3-53b4fadc8d51_600x600_i?s=80fedafe87a731b52dd7c32f18195f2b", "ライデンフィルム", "LIDENFILMS", "https://myanimelist.net/anime/producer/839/LIDENFILMS" },
                    { 841, null, null, "https://cdn.myanimelist.net/s/common/company_logos/f9cdba0e-6b9f-4c86-af79-949dfea21548_600x600_i?s=6639dd7831fc8e4031c60b5168e2c118", null, "Saban Entertainment", "https://myanimelist.net/anime/producer/841/Saban_Entertainment" },
                    { 843, null, new DateTime(1998, 12, 14, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9da79fec-4404-4a19-a3cd-d2fe24ecf504_600x600_i?s=4532b9579b3e31ea79b21ca95f4b9e90", "ビーエスフジ", "BS Fuji", "https://myanimelist.net/anime/producer/843/BS_Fuji" },
                    { 852, null, null, "https://cdn.myanimelist.net/s/common/company_logos/af804e48-b219-4541-801e-c7414f7659b3_600x600_i?s=a1fea47c396e64aedc314f6d91c7f95a", "Nexus", "Nexus", "https://myanimelist.net/anime/producer/852/Nexus" },
                    { 858, "Wit Studio, Inc., stylized as WIT Studio, is a Japanese animation studio founded on June 1, 2012, by producers at Production I.G as a subsidiary of IG Port. It is headquartered in Musashino, Tokyo, with Production I.G producer George Wada as president and Tetsuya Nakatake, also a producer at Production I.G., as a director of the studio.\n\nThe studio was founded by George Wada, a former employee of Production I.G, in 2012. After its founding, Tetsuya Nakatake was placed as the representative director of the studio. Several other former Production I.G staff members joined Wit after its founding, including animation directors Kyōji Asano and Satoshi Kadowaki, and director Tetsurō Araki, all of whom worked together on Attack on Titan.\n\nWit Studio was funded with an initial investment of ¥30,000,000 in capital from IG Port, Wada and Nakatake, who are reported to own 66.6%, 21.6% and 10.0% equity in the studio respectively.\n\nIn December 2020, Wit Studio established a stop motion studio in partnership with Pui Pui Molcar director Tomoki Misato.\n\nIn May 2022, Wit Studio in partnership with Aniplex, CloverWorks and Shueisha formed a new company called JOEN. The company's objective is to facilitate the planning and production of television anime series, anime films, and short clips.\n\n(Source: Wikipedia)", new DateTime(2012, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e7e64f9e-23f6-4c74-9813-cb4fcdb600cf_600x600_i?s=37f6a1b3342db61d87d4e50803fd6fd6", "ウィットスタジオ", "Wit Studio", "https://myanimelist.net/anime/producer/858/Wit_Studio" },
                    { 882, null, new DateTime(1996, 7, 21, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/be7f0823-488b-4dfe-a1f7-0a7c14183e23_600x600_i?s=fe93aac6a914607b0f2ea2c220955c55", "とらのあな", "Toranoana", "https://myanimelist.net/anime/producer/882/Toranoana" },
                    { 884, null, new DateTime(2001, 2, 18, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b802cf0d-8805-409b-8ec6-fc5954c3e1c9_600x600_i?s=d21b49c09b82c5bbb15cfaf0c7e60c28", "ストロベリー・ミーツ ピクチュアズ", "Strawberry Meets Pictures", "https://myanimelist.net/anime/producer/884/Strawberry_Meets_Pictures" },
                    { 892, null, new DateTime(2012, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "NOTTV", "NOTTV", "https://myanimelist.net/anime/producer/892/NOTTV" },
                    { 894, null, new DateTime(2009, 4, 21, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/66292dc1-5c47-43bf-9054-2eea2c48d308_600x600_i?s=346854943edcbeb56bbf742b5dfdb727", "グラフィニカ", "Graphinica", "https://myanimelist.net/anime/producer/894/Graphinica" },
                    { 911, null, new DateTime(2011, 1, 25, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/66b5651e-4cbd-4ccd-b183-01151cf4b1d5_600x600_i?s=94659e7d2a36afa0ff8fd8df3023679c", "パッショーネ", "Passione", "https://myanimelist.net/anime/producer/911/Passione" },
                    { 921, null, new DateTime(1974, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/74747a13-b929-4760-b36a-4856d70aabb3_600x600_i?s=10c2afbd235454f2a47d339ad09aebb4", "ダイナミック企画", "Dynamic Planning", "https://myanimelist.net/anime/producer/921/Dynamic_Planning" },
                    { 925, null, new DateTime(1939, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e8bcbe5c-5da2-44b1-83c2-c1f3f523be6e_600x600_i?s=15afdfce63771b97e45d4e10df8805d8", "アース・スター　エンターテイメント", "Earth Star Entertainment", "https://myanimelist.net/anime/producer/925/Earth_Star_Entertainment" },
                    { 929, "A former subsidiary of Kyoto Animation formed from their Osaka studio. In 2020, it was announced that the company would be merged back into Kyoto Animation and would continue business as the Animation Do Division.", new DateTime(2000, 4, 6, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/101ea9d3-e18b-42e1-8d19-3fe3d99cd5dd_600x600_i?s=f90da19733b4bc64e7da4cdf6918deae", "アニメーションドゥウ", "Animation Do", "https://myanimelist.net/anime/producer/929/Animation_Do" },
                    { 941, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Iwatobi High School Swimming Club", "https://myanimelist.net/anime/producer/941/Iwatobi_High_School_Swimming_Club" },
                    { 947, null, new DateTime(1991, 1, 16, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e227f18b-8988-4d69-a9a0-b7c7f28b0096_600x600_i?s=6ba8d29e6bd322cc25c4b7000915ba01", null, "Manga Entertainment", "https://myanimelist.net/anime/producer/947/Manga_Entertainment" },
                    { 957, "Connect is an animation production studio and subsidiary of Silver Link. It was announced in July 2020 that the studio was to be absorbed by its mother company.\n\nFollowing Connect's absorption into Silver Link, it ceased as a subsidiary company with legal entity under Silver Link; however, the name \"Connect\" is still used by the same production team as an internal department or brand name.", new DateTime(2012, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0e046b20-034f-4054-9b6a-f96020dfb2c2_600x600_i?s=6de980c8de6bbc23d130f43a8d6fad26", "コネクト", "Connect", "https://myanimelist.net/anime/producer/957/Connect" },
                    { 963, null, null, "https://cdn.myanimelist.net/s/common/company_logos/38cdeb36-26f5-4b8d-a43f-791a93edb057_600x600_i?s=64493f0d2b54469420289247eacb4c68", "MAGES.", "MAGES.", "https://myanimelist.net/anime/producer/963/MAGES" },
                    { 1003, "Nippon Television Network Corporation, also known as Nippon TV, with the call sign JOAX-DTV, is a Japanese commercial broadcast television network. It is a subsidiary of the certified broadcasting holding company Nippon Television Holdings, Inc. and also the flagship station of the Nippon News Network and the Nippon Television Network System.\n\n(Source: Wikipedia)", new DateTime(1952, 10, 27, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/66ccba5e-e559-49f3-9171-50b0d6d32051_600x600_i?s=e6f50a2d81d51832b4e32e38dac440f9", "日本テレビ放送網", "Nippon Television Network", "https://myanimelist.net/anime/producer/1003/Nippon_Television_Network" },
                    { 1005, null, new DateTime(2004, 2, 26, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b5dd4a91-513c-4c0c-b8cc-8cb65e10521e_600x600_i?s=e3bfdd4ff4b26fb45d139af055eb0810", "ODDJOB", "Oddjob", "https://myanimelist.net/anime/producer/1005/Oddjob" },
                    { 1011, null, null, "https://cdn.myanimelist.net/s/common/company_logos/7f89592f-f33d-4aa7-8864-499ca7c46cbc_600x600_i?s=7b27386d06ab1fdb6eecfdb2e300da46", "ワーナーミュージック・ジャパン", "Warner Music Japan", "https://myanimelist.net/anime/producer/1011/Warner_Music_Japan" },
                    { 1013, null, new DateTime(2002, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/da3736f6-edd7-46df-836c-104b3a2adbc6_600x600_i?s=e7f7b9c27c5c73be0896d6e243d9c66b", "オペラハウス", "Opera House", "https://myanimelist.net/anime/producer/1013/Opera_House" },
                    { 1033, null, new DateTime(2011, 8, 21, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/09812f1b-2c12-4a7d-b7fa-a5d9c23b6a9e_600x600_i?s=78e6744a07816511fd59dac872d8e62c", "スタジオコロリド", "Studio Colorido", "https://myanimelist.net/anime/producer/1033/Studio_Colorido" },
                    { 1037, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Japan Vistec", "https://myanimelist.net/anime/producer/1037/Japan_Vistec" },
                    { 1041, null, new DateTime(2012, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/18fd7d07-c89c-4923-b629-e159a81cdc9c_600x600_i?s=9a9ce3fbf4ced14f4cb31f81c23fcb5c", "アイアディクション", "Ai Addiction", "https://myanimelist.net/anime/producer/1041/Ai_Addiction" },
                    { 1045, null, new DateTime(2007, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/1b4389a3-5c6c-4e9d-a8a1-910ee565ba72_600x600_i?s=311ff55bb25607b7747e26f26706f994", "スペースネコカンパニー", "Space Neko Company", "https://myanimelist.net/anime/producer/1045/Space_Neko_Company" },
                    { 1053, "Production IMS (Production IMS Co., Ltd.) was a Japanese animation studio based in Nerima, Tokyo, Japan. Former Anime International Company (AIC) employees led by former AIC Spirits producer Yoshiyuki Matsuzaki established Production IMS Co., Ltd. in February 2013. By 2017, Production IMS began running into financial difficulties. In April 2018, former Production IMS employees led by Naoto Awano and Ougi Jiyu left to establish JFK (AKA Quad) and the studio later closed in October of the same year. In September 2020, Production IMS disappeared as a corporate entity.\n\nThe studio’s notable works included: Inari, Konkon, Koi Iroha (2014), Date A Live II (2014), Shinmai Maou no Testament (2015), and High School Fleet (2016).", new DateTime(2013, 2, 13, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/16e65560-f086-4d66-b13f-c5e168b8da7e_600x600_i?s=32c5938faa4651b4e83a8300efea5e39", "プロダクションアイムズ", "Production IMS", "https://myanimelist.net/anime/producer/1053/Production_IMS" },
                    { 1063, null, new DateTime(2014, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b484b758-f136-4c04-b2e7-7bab9da92ba2_600x600_i?s=f3b5cee7e9c6e00148519ddc1912d4b9", "カーフ", "Calf Studio", "https://myanimelist.net/anime/producer/1063/Calf_Studio" },
                    { 1097, null, new DateTime(2006, 3, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/70e80877-cd88-486e-9cdb-c6fa85822b5f_600x600_i?s=1225aada105614baee0f456a88947e1f", "バンダイナムコゲームス", "Bandai Namco Games", "https://myanimelist.net/anime/producer/1097/Bandai_Namco_Games" },
                    { 1099, null, null, "https://cdn.myanimelist.net/s/common/company_logos/35b2d3d9-b0ed-4655-9ed1-7feea2029316_600x600_i?s=4b58811f34816409e03464e0116f94a8", "サイクロングラフィックス", "Cyclone Graphics", "https://myanimelist.net/anime/producer/1099/Cyclone_Graphics" },
                    { 1103, "TROYCA (TROYCA Inc.) is a Japanese animation studio based in Nerima, Tokyo, Japan. The studio's name is derived from the Russian word for “team of three.”\n\nFormer Anime International Company (AIC) members led by Ei Aoki (former director at AIC), Tomonori Kato (former photography director at AIC), and Toshiyuki Nagano (former producer at AIC Classic) established TROYCA Inc. to continue production of Aldnoah.Zero in May 2013; when GAIA Holdings (now Aplix Corporation) announced it had suspended AIC’s upcoming in-planning production slate in the first quarter of the same year.\n\nIn 2018, the studio absorbed Will Pallete — a Nerima-based animation studio established by former AIC Digital producer Naoto Kasahara in May 2015. As of 2024, TROYCA employs 61 full-time employees between its headquarters in Nerima, Tokyo and Fujisawa Studio in Fujisawa, Kanagawa Prefecture.", new DateTime(2013, 5, 22, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/745cffb8-7566-4cfe-aab2-d89799d04d2b_600x600_i?s=1abac486697415e7c9fbd55622b379a8", "トロイカ", "TROYCA", "https://myanimelist.net/anime/producer/1103/TROYCA" },
                    { 1109, null, new DateTime(2004, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/6de7a3c5-f637-4b16-9237-3fc04f5d66fd_600x600_i?s=c0dcfd48ec1455d2e254b03b0616819e", "オレンジ", "Orange", "https://myanimelist.net/anime/producer/1109/Orange" },
                    { 1113, null, new DateTime(1981, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ae18f3ff-8aac-412d-81e4-6dc19ac4bce5_600x600_i?s=bf418d9d0bf43b6235d852a2bec5ae27", "NBCユニバーサル・エンターテイメントジャパン", "NBCUniversal Entertainment Japan", "https://myanimelist.net/anime/producer/1113/NBCUniversal_Entertainment_Japan" },
                    { 1119, null, new DateTime(2013, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9116fb75-b878-41d9-9b2a-e64c00ff25ba_600x600_i?s=54cf1a47f7f6eb91ec6fb2670fc43168", "朱夏", "Shuka", "https://myanimelist.net/anime/producer/1119/Shuka" },
                    { 1121, null, null, "https://cdn.myanimelist.net/s/common/company_logos/87cf5b23-1048-4409-8ecc-4713c43a96a1_600x600_i?s=0a7c8c9cbe19b24721848dd9bf5951db", null, "Banpresto", "https://myanimelist.net/anime/producer/1121/Banpresto" },
                    { 1123, null, new DateTime(2012, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "ルーセント・ピクチャーズエンタテインメント", "Lucent Pictures Entertainment", "https://myanimelist.net/anime/producer/1123/Lucent_Pictures_Entertainment" },
                    { 1127, null, new DateTime(2013, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4ade4ad0-d7ae-4bae-a6d4-a5dae3fa8146_600x600_i?s=fdaaee42ef5c5fb548afa43cc5705e93", "スタジオ３Hz", "Studio 3Hz", "https://myanimelist.net/anime/producer/1127/Studio_3Hz" },
                    { 1129, "Pierrot Plus was a subsidiary of Studio Pierrot previously known as Studio Kikan until 2009. In 2019, it was renamed to Studio Signpost.", new DateTime(2009, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3338164b-f2e1-4883-914e-b4daa334d39f_600x600_i?s=80c357032109185978543e06f4c2dfbb", "ぴえろプラス", "Pierrot Plus", "https://myanimelist.net/anime/producer/1129/Pierrot_Plus" },
                    { 1133, null, new DateTime(2003, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0f3310d2-3878-4884-8e23-a804fe077678_600x600_i?s=f2fabcccb5e842f13b6b032cbf78b8dd", "ドワーフ", "dwarf", "https://myanimelist.net/anime/producer/1133/dwarf" },
                    { 1135, null, new DateTime(2010, 5, 20, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/de3f9d56-10fd-4b04-a619-e67819c5a0ae_600x600_i?s=d1e6ada8aeb9a0a48026afe48138e318", "FOREST Hunting One", "FOREST Hunting One", "https://myanimelist.net/anime/producer/1135/FOREST_Hunting_One" },
                    { 1139, null, new DateTime(2020, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/6b7d9712-f1f3-46fd-8d66-8329e8a3e4ec_600x600_i?s=90c79e7f43c5b429e057f143a1938402", "ビームエンターテインメント", "BEAM Entertainment", "https://myanimelist.net/anime/producer/1139/BEAM_Entertainment" },
                    { 1143, null, null, "https://cdn.myanimelist.net/s/common/company_logos/d6dad436-ee75-4a19-afb3-0e5b6038f786_600x600_i?s=2b69c81d318f0f6a3459b6ee71ed06b5", "東宝アニメーション", "TOHO animation", "https://myanimelist.net/anime/producer/1143/TOHO_animation" },
                    { 1155, null, new DateTime(2009, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/827afc41-5eae-448d-97fc-36de9459eddf_600x600_i?s=42ab64b3ead23ef3c452d071cc46406c", "スタジオモリケン", "Studio Moriken", "https://myanimelist.net/anime/producer/1155/Studio_Moriken" },
                    { 1157, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "ビッグバン", "Big Bang", "https://myanimelist.net/anime/producer/1157/Big_Bang" },
                    { 1163, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Flatiron Film Company", "https://myanimelist.net/anime/producer/1163/Flatiron_Film_Company" },
                    { 1169, null, new DateTime(2010, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/eb18c8d2-677a-4f7a-a5c4-1d00d951af16_600x600_i?s=75b24515822d4e94e9321368b238c8ff", "イルカ", "ILCA", "https://myanimelist.net/anime/producer/1169/ILCA" },
                    { 1175, null, new DateTime(1986, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/bfbc44c1-81f9-40ad-ac2b-ce1c4162a844_600x600_i?s=f4334e4882eaed42ab8aa0d5f1979558", "アトリエムサ", "Atelier Musa", "https://myanimelist.net/anime/producer/1175/Atelier_Musa" },
                    { 1185, null, new DateTime(1981, 2, 2, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/1522d322-af44-4792-b115-3a95ac940991_600x600_i?s=150d2846fc5c276ae2cc0c0883a8da2c", "81プロデュース", "81 Produce", "https://myanimelist.net/anime/producer/1185/81_Produce" },
                    { 1189, null, null, "https://cdn.myanimelist.net/s/common/company_logos/ff260dc0-55b6-4745-bb1b-28d9bc40a4db_600x600_i?s=385ffbecc98036b808bc2a169609d8bb", "SOLA DIGITAL ARTS", "Sola Digital Arts", "https://myanimelist.net/anime/producer/1189/Sola_Digital_Arts" },
                    { 1195, null, new DateTime(2013, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d088e903-ffe4-4cb8-a3fa-69761f90636c_600x600_i?s=c16ec56366f0a9c90f280ea1c0527526", "クリエイターズインパック", "Creators in Pack", "https://myanimelist.net/anime/producer/1195/Creators_in_Pack" },
                    { 1197, null, new DateTime(2011, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/c0c03dec-4153-43f1-a635-7b55b0b2e75a_600x600_i?s=983d2a21cce49ad221d906a917b8efaf", "スティーブンスティーブン", "Steve N' Steven", "https://myanimelist.net/anime/producer/1197/Steve_N_Steven" },
                    { 1201, null, new DateTime(2014, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/c7ff6360-f655-4dbe-966e-312219a5d76a_600x600_i?s=3976b1fc24fbf2ad96972256f2eeadb2", "PONYCANYON USA", "Ponycan USA", "https://myanimelist.net/anime/producer/1201/Ponycan_USA" },
                    { 1209, null, new DateTime(1996, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/04b5237a-4945-46d8-a5a5-9495f337e5d5_600x600_i?s=b39a1fd97a779392f1db8494befc0db6", "studio A-CAT", "Studio A-CAT", "https://myanimelist.net/anime/producer/1209/Studio_A-CAT" },
                    { 1211, null, new DateTime(1993, 4, 29, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/687f2b35-d55b-48e5-8358-f947fddaf402_600x600_i?s=befe79485148f235554c063e5f7b3376", "東京メトロポリタンテレビジョン", "Tokyo MX", "https://myanimelist.net/anime/producer/1211/Tokyo_MX" },
                    { 1213, null, new DateTime(2004, 3, 25, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e85cffda-be77-4e43-b2f8-9cb517efdbd7_600x600_i?s=40bc8d803bfaecd56e040f8eba2ed80f", "モブキャストホールディングス", "Mobcast", "https://myanimelist.net/anime/producer/1213/Mobcast" },
                    { 1215, null, new DateTime(1973, 4, 15, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/6808e287-017e-476e-8c35-a4507a72be1c_600x600_i?s=a8b4051162f7e394c4a4161bc886cf0d", "第一興商", "Daiichikosho", "https://myanimelist.net/anime/producer/1215/Daiichikosho" },
                    { 1225, null, new DateTime(2008, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4d96bdb5-a6c3-4395-8f68-0a5bf0c4f1d8_600x600_i?s=caf427646fa7cb03af7d39afc6291fbb", "Age Global Networks", "Age Global Networks", "https://myanimelist.net/anime/producer/1225/Age_Global_Networks" },
                    { 1229, null, new DateTime(2013, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/adbcca15-ba27-4488-8924-571d51e5ed21_600x600_i?s=993bb94e597658e1a246c427758b0bdc", "Pie in the sky", "Pie in the sky", "https://myanimelist.net/anime/producer/1229/Pie_in_the_sky" },
                    { 1231, null, new DateTime(1994, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d8343586-8ef7-4100-8c10-827bc3d463f0_600x600_i?s=a2ccee2eecd21e2bfa887e2c1237e89a", "オー・エル・エム", "OLM Digital", "https://myanimelist.net/anime/producer/1231/OLM_Digital" },
                    { 1233, null, new DateTime(1955, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/44a10065-d875-40e7-90f3-7f088c767101_600x600_i?s=0e2ff2b9fa67e08c7143af598cc07cdf", "バンダイナムコエンターテインメント", "Bandai Namco Entertainment", "https://myanimelist.net/anime/producer/1233/Bandai_Namco_Entertainment" },
                    { 1235, null, new DateTime(2004, 7, 4, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/748c1739-bb07-49d2-9661-b9049381e909_600x600_i?s=f0cb07536622533bde3323815b9d36be", "アイウォズ・ア・バレリーナ", "I was a Ballerina", "https://myanimelist.net/anime/producer/1235/I_was_a_Ballerina" },
                    { 1237, "Millepensee is an animation planning and production company located in Tanashi, Nishitokyo, Tokyo, Japan.", null, "https://cdn.myanimelist.net/s/common/company_logos/98b0d204-0859-4335-b143-8ac13867a6e3_600x600_i?s=5e28d7eca47a82116131318c70734ed5", "ミルパンセ", "Millepensee", "https://myanimelist.net/anime/producer/1237/Millepensee" },
                    { 1244, null, new DateTime(2014, 8, 11, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/02a37b67-2c69-4acb-9302-06f813b5f739_600x600_i?s=f8c6844a46d9755fbf96f53b97d1e3ea", "スタジオヴォルン", "Studio VOLN", "https://myanimelist.net/anime/producer/1244/Studio_VOLN" },
                    { 1253, null, new DateTime(2012, 4, 4, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/1053f788-fae1-4f70-9e15-753f8c34b170_600x600_i?s=173133d09f6670b9fa7d2c09e2e4e654", "StudioGOONEYS", "Studio GOONEYS", "https://myanimelist.net/anime/producer/1253/Studio_GOONEYS" },
                    { 1254, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Grooove", "https://myanimelist.net/anime/producer/1254/Grooove" },
                    { 1255, null, null, "https://cdn.myanimelist.net/s/common/company_logos/da804d60-57e3-44ca-8cef-b4b0d241928e_600x600_i?s=c3e08875032fc3be0f7aab8a6cb52078", "グロービジョン", "Glovision", "https://myanimelist.net/anime/producer/1255/Glovision" },
                    { 1258, "Bandai Namco Pictures Inc., also known as BN Pictures, is a Japanese animation studio and production company. It is a spinoff of Sunrise, a subsidiary of Bandai Namco Filmworks which is owned by Bandai Namco Holdings. The company was formed as a part of the medium-term management plan of Bandai Namco Holdings on restructuring itself. All the anime intellectual property and production divisions of Sunrise that aims at children and family were transferred to Bandai Namco Pictures. The company began its operations in April 2015.\n\n(Source: Wikipedia)", new DateTime(2015, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0cae085b-c75f-443c-a997-976b354f8cae_600x600_i?s=127539e086823a0c362a8bd7194ae5de", "バンダイナムコピクチャーズ", "Bandai Namco Pictures", "https://myanimelist.net/anime/producer/1258/Bandai_Namco_Pictures" },
                    { 1260, null, null, "https://cdn.myanimelist.net/s/common/company_logos/4e1ad409-e9df-4901-9992-97885cee22f0_600x600_i?s=79b2ea2a7a9f5606dbb22202394bce0f", "中村プロダクション", "Nakamura Production", "https://myanimelist.net/anime/producer/1260/Nakamura_Production" },
                    { 1261, null, new DateTime(2001, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3b817f72-a6fa-436f-86c6-80fd19a12fcd_600x600_i?s=c34da14cee32bd9c1474bafa899cf093", "グッドスマイルカンパニー", "Good Smile Company", "https://myanimelist.net/anime/producer/1261/Good_Smile_Company" },
                    { 1263, "On July 14th 2022, Nintendo acquired all shares of Dynamo Pictures. On October 3rd of the same year, the company changed it's name to Nintendo Pictures.", new DateTime(2011, 3, 17, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3cc64b2f-cd0e-491f-af51-25b03774fec4_600x600_i?s=3094471d1096c4f410c5191160ef061d", "ダイナモピクチャーズ", "Dynamo Pictures", "https://myanimelist.net/anime/producer/1263/Dynamo_Pictures" },
                    { 1270, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Sanctuary", "https://myanimelist.net/anime/producer/1270/Sanctuary" },
                    { 1278, null, new DateTime(2014, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8f777026-a21b-4054-b5f7-e7593a2ab725_600x600_i?s=782209acca45153301750b358825831f", "シグナル・エムディ", "Signal.MD", "https://myanimelist.net/anime/producer/1278/SignalMD" },
                    { 1283, null, new DateTime(2005, 8, 22, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3cb30049-2ff2-4201-81a6-8c149e508b52_600x600_i?s=dc5b9efb6c770bbc65ec7fde2880545a", "TCエンタテインメント", "TC Entertainment", "https://myanimelist.net/anime/producer/1283/TC_Entertainment" },
                    { 1284, null, new DateTime(2014, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/5fb34210-6eb7-454d-ba8e-a3e3cfd79eb1_600x600_i?s=b26272593ed99545857c4834601be2ca", "エイベックスピクチャーズ", "Avex Pictures", "https://myanimelist.net/anime/producer/1284/Avex_Pictures" },
                    { 1286, null, null, "https://cdn.myanimelist.net/s/common/company_logos/1579e9ac-4829-4ff1-98a9-57405014820e_600x600_i?s=ea7f363fcadbb1159e348dd95308acfe", "テンゲージ", "10Gauge", "https://myanimelist.net/anime/producer/1286/10Gauge" },
                    { 1287, null, new DateTime(1989, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d92f878d-464d-4394-b7ed-1b4815d497d4_600x600_i?s=108037f9502f4d964e0644186ccec7ef", "キュー・テック", "Q-Tec", "https://myanimelist.net/anime/producer/1287/Q-Tec" },
                    { 1291, null, null, "https://cdn.myanimelist.net/s/common/company_logos/272592a7-8d28-48e7-a534-a7c79a9e0a0c_600x600_i?s=92f338e58d83dbe3b896a5b9932e4c72", "空気", "KOO-KI", "https://myanimelist.net/anime/producer/1291/KOO-KI" },
                    { 1294, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Sound Team Don Juan", "https://myanimelist.net/anime/producer/1294/Sound_Team_Don_Juan" },
                    { 1296, null, new DateTime(2005, 1, 20, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8d403559-93a8-48cd-8bd2-1eafc32f5a08_600x600_i?s=3ef6a49ba4a861c2976e12e982c9388b", "マーザ・アニメーションプラネット", "Marza Animation Planet", "https://myanimelist.net/anime/producer/1296/Marza_Animation_Planet" },
                    { 1309, null, new DateTime(1992, 7, 22, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8d563ac1-b814-492b-a708-5358d544ef16_600x600_i?s=faa057501bd487eac1804c179c096bb9", "ローソンエンタテインメント", "Lawson HMV Entertainment", "https://myanimelist.net/anime/producer/1309/Lawson_HMV_Entertainment" },
                    { 1313, null, new DateTime(1978, 10, 15, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f7059145-e00e-4306-98aa-a476a562d5f7_600x600_i?s=7a41b26275b0d225e42a9948b07f4e99", "アミューズ", "Amuse", "https://myanimelist.net/anime/producer/1313/Amuse" },
                    { 1314, "Originally was established in 2015 as a managing company to manage a studio and museum in Miharu, Fukushima. On August 20 2018, it was announced that the Kinoshita Group acquired the company and that the company changed its name to Gaina with its new parent company planning to make it the pillar of its anime production to expand its business.", new DateTime(2018, 8, 19, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f12e73b5-72c2-436c-88c7-f51970828b43_600x600_i?s=9b955b550a769b2e8a7e6cbf4c104657", "ガイナ", "Gaina", "https://myanimelist.net/anime/producer/1314/Gaina" },
                    { 1332, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "famima.com", "https://myanimelist.net/anime/producer/1332/famimacom" },
                    { 1333, null, new DateTime(2003, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/52dd9916-9371-46c7-8980-32e00428c10d_600x600_i?s=0da4b67d5216017a32b179715107fe3d", "博報堂DYミュージック＆ピクチャーズ", "Hakuhodo DY Music & Pictures", "https://myanimelist.net/anime/producer/1333/Hakuhodo_DY_Music___Pictures" },
                    { 1334, null, new DateTime(2012, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b356df62-46d3-4c01-a018-336bd7678897_600x600_i?s=e87243568cce1850ca4c1832d10bac9c", "ドコモ・アニメストア", "Docomo Anime Store", "https://myanimelist.net/anime/producer/1334/Docomo_Anime_Store" },
                    { 1336, null, new DateTime(1932, 5, 1, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4887e2fc-8563-42b4-ab7d-f535090f3300_600x600_i?s=a5aad1a6299ab8efdb6e07e84a56b0f8", "中外鉱業", "Chugai Mining", "https://myanimelist.net/anime/producer/1336/Chugai_Mining" },
                    { 1337, null, null, "https://cdn.myanimelist.net/s/common/company_logos/09ff8601-50e9-433a-a4e4-216268ce02b0_600x600_i?s=6441782636285244339b07086074250f", "メディコス・エンタテインメント", "Medicos Entertainment", "https://myanimelist.net/anime/producer/1337/Medicos_Entertainment" },
                    { 1344, null, new DateTime(1951, 10, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/6136b027-5f96-4c19-9b4d-d3f55de46b48_600x600_i?s=1e252563f32844e5e41688114d311f48", "キングレコード", "King Records", "https://myanimelist.net/anime/producer/1344/King_Records" },
                    { 1345, null, new DateTime(1975, 10, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/77b46a00-8654-4a97-86ac-aa3c10b85637_600x600_i?s=b36f2b72418536ffcebf6574eb391e0d", "サミー", "Sammy", "https://myanimelist.net/anime/producer/1345/Sammy" },
                    { 1355, null, new DateTime(1982, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/bc56e795-2f50-45b9-b724-0f80ef1669a7_600x600_i?s=4c6417731c4b06368fbf81bd662f1ca8", "テレビ愛知", "TV Aichi", "https://myanimelist.net/anime/producer/1355/TV_Aichi" },
                    { 1358, null, new DateTime(1988, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/91025bbc-3fec-4ba3-a064-53fe602f0e7c_600x600_i?s=7d92923c133822fd7c08f50a630fd859", "フィールズ", "Fields", "https://myanimelist.net/anime/producer/1358/Fields" },
                    { 1365, null, null, "https://cdn.myanimelist.net/s/common/company_logos/bd877f4d-407e-4385-9a53-1ae9ad453699_600x600_i?s=994d714417bf76d4a6560253c6800f05", "集英社", "Shueisha", "https://myanimelist.net/anime/producer/1365/Shueisha" },
                    { 1366, null, new DateTime(1961, 9, 5, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d2d91943-9b00-438b-abd1-f902da6fd586_600x600_i?s=f0d1365db2a1c0b73c48192475f1a7e2", "名古屋テレビ放送", "Nagoya Broadcasting Network", "https://myanimelist.net/anime/producer/1366/Nagoya_Broadcasting_Network" },
                    { 1372, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "創映新社", "Soeishinsha", "https://myanimelist.net/anime/producer/1372/Soeishinsha" },
                    { 1373, null, new DateTime(1948, 8, 9, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/67634788-a87b-4d0c-8939-dfcd404e872a_600x600_i?s=d0ef9dbff960981b597aa5046ec87af7", "秋田書店", "Akita Shoten", "https://myanimelist.net/anime/producer/1373/Akita_Shoten" },
                    { 1377, null, new DateTime(1948, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ddd85fa1-8fcf-4ab2-9a9a-7a22929eddd4_600x600_i?s=3451e839b58677fa5937a70d9bf0d3b4", "双葉社", "Futabasha", "https://myanimelist.net/anime/producer/1377/Futabasha" },
                    { 1379, "Zero-G (Zero-G Inc.) is a Japanese animation studio based in Suginami, Tokyo, Japan. Since 2013, the studio has been a subsidiary of NOIX and affiliated with Negishi’s Saber Project (formerly AIC Project).\n\nHiroshi Negishi, co-creator of series such as Saber Marionette and director for Tekkaman Blade and several entries of the Tenchi Muyo! franchise, established Zero-G Inc. in June 2011 –  as the spiritual successor that inherited the past skills and knowledge of Negishi’s former studio Zero-G Room, established in 1991 but was later merged into RADIX, founded in 1995 by Negishi for copyright management, to form the now-defunct RADIX, Ltd. (later Radix Ace Entertainment) in 2001. In September of the following year, the studio acquired all of the anime-related copyrights held by Radix Mobanimation.\n\nIn late 2015, former members from AIC PLUS+ transferred to the studio with Sakikawa Yukiya – animation producer for GA: Geijutsuka Art Design Class, Cat Planet Cuties, The Everyday Tales of a Cat God, Place to Place, and Date A Live – assuming the position of representative director in June 2015.", new DateTime(2011, 6, 1, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/5867f6e9-fadb-411e-887a-2aa10f18923b_600x600_i?s=eeb994fc74fbf160a107b8ef798dbe79", "ゼロジー", "Zero-G", "https://myanimelist.net/anime/producer/1379/Zero-G" },
                    { 1381, "Gemba is a CGI animation company located in Shibuya, Tokyo, Japan.", new DateTime(2006, 4, 5, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/315f85e2-c476-4842-8809-31ac97f9b099_600x600_i?s=f40916503f172f45beda1ba6e8319548", "GEMBA", "GEMBA", "https://myanimelist.net/anime/producer/1381/GEMBA" },
                    { 1383, null, new DateTime(1976, 7, 16, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/46f8be4c-f3ab-4e9e-9ec5-bda578efa2ea_600x600_i?s=0b147006fd6bba054e23604f1ea2fa27", "スタジオ・ライブ", "Studio Live", "https://myanimelist.net/anime/producer/1383/Studio_Live" },
                    { 1390, null, new DateTime(1990, 5, 29, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8a6717cd-a796-4180-a993-e2728709aba5_600x600_i?s=66acd1edec6dbd784552b8e8245f722f", "トイズファクトリー", "Toy's Factory", "https://myanimelist.net/anime/producer/1390/Toys_Factory" },
                    { 1392, null, new DateTime(1975, 8, 14, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ad5b03d5-e7c2-47aa-80e8-7da9b7e7b70a_600x600_i?s=b9e550c8aff6d719d55610434737c1f0", "ザック･プロモーション", "Zack Promotion", "https://myanimelist.net/anime/producer/1392/Zack_Promotion" },
                    { 1396, null, new DateTime(2015, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/cec32f9d-f56f-41b6-a399-50b8400d9c9a_600x600_i?s=78e0d54e18804ebd1a1a52ca9a07db9a", "ダブトゥーンスタジオ", "W-Toon Studio", "https://myanimelist.net/anime/producer/1396/W-Toon_Studio" },
                    { 1397, null, new DateTime(1990, 4, 19, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0b51aced-ad33-4a33-8061-e815b2a857a7_600x600_i?s=ba96f58937efada090a6e7b96f5628cb", "ユニバーサル ミュージック合同会社", "Universal Music Japan", "https://myanimelist.net/anime/producer/1397/Universal_Music_Japan" },
                    { 1403, null, new DateTime(1917, 12, 20, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0d3dae9b-8886-42c4-89a1-f49507f64b33_600x600_i?s=21e73abf44888153ff5592ee942cbd16", "明治", "Meiji Seika", "https://myanimelist.net/anime/producer/1403/Meiji_Seika" },
                    { 1406, null, new DateTime(2001, 4, 16, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b148ae9b-6617-43e5-9364-8a982adac6cd_600x600_i?s=b27b9e3555c06ebda2d8015502047db5", "ミラクル・バス", "Miracle Bus", "https://myanimelist.net/anime/producer/1406/Miracle_Bus" },
                    { 1407, null, new DateTime(2010, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/1681b4a6-5e1d-4741-9ac8-602caadc9a48_600x600_i?s=111c9540de68f2a755c700e67c5e51b2", "Children's Playground Entertainment", "Children's Playground Entertainment", "https://myanimelist.net/anime/producer/1407/Childrens_Playground_Entertainment" },
                    { 1411, null, new DateTime(1961, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ed308869-6936-484b-a9f0-79ac7ecc2503_600x600_i?s=b8de604cb41160287dcf220f06e982bd", "京楽産業", "Kyoraku Industrial Holdings", "https://myanimelist.net/anime/producer/1411/Kyoraku_Industrial_Holdings" },
                    { 1412, null, new DateTime(1958, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "関西テレビ", "Kansai Telecasting", "https://myanimelist.net/anime/producer/1412/Kansai_Telecasting" },
                    { 1414, "bilibili (Bilibili Co., Ltd.) is a Chinese barrage video website and a leading cultural community for young people. It was founded on June 26, 2009 and is known as \"Bilibili\".\n\nBstation has 14 major content divisions: animation, fan drama, national innovation, music, dance, games, technology, life, ghosts, fashion, advertising, entertainment, film and television, and screening halls. 70% of the content comes from user-made or original videos, and currently has more than 10 million active video creators (UP masters). At present, there are more than 150 million active users, more than 100 million video views per day, and more than 10 million original submissions. 75% of users of station B are under the age of 24.\n\nThe feature of Bstation is the real-time comment function suspended above the video. Fans call it \"barrage\". This unique video experience enables Internet-based barrage to transcend the limitations of time and space and build a wonderful synchronicity relationship, forming a virtual tribal movie viewing atmosphere, making Bilibili a cultural community with interactive sharing and secondary creation.\n\nThe main body of Bstation has more than 50 foreign investment companies in Shanghai Magic Electric, whose business content includes animation, games, music, recording, movies, information, etc., and involves content planning and investment, production and development, copyright operation, and global distribution. Physical business also includes stage performances, exhibition planning, toy design, etc.", new DateTime(2009, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/594a2902-27ca-4623-b5c1-40ceb6ce2b06_600x600_i?s=695a9a308eb008f8b54aec97f6d69b1e", "哔哩哔哩", "bilibili", "https://myanimelist.net/anime/producer/1414/bilibili" },
                    { 1415, null, new DateTime(1951, 3, 14, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f60c0e4d-17c5-47e1-aa69-a4c38daeaa30_600x600_i?s=9a2ca2af4a23b7f80e586ec526663793", "朝日放送グループホールディングス", "Asahi Broadcasting", "https://myanimelist.net/anime/producer/1415/Asahi_Broadcasting" },
                    { 1416, null, new DateTime(1999, 8, 22, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/50a6e67c-8885-41bb-861b-8b71849a6c2a_600x600_i?s=354c68df943b0a049a83331fcee3f0dd", "日本BS放送", "BS11", "https://myanimelist.net/anime/producer/1416/BS11" },
                    { 1418, null, new DateTime(1969, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ff16274b-193c-4136-baf1-97402c820eb2_600x600_i?s=d1a1ee4767c7225c0b36caae06f96a2e", "日本テレビ音楽", "Nippon Television Music", "https://myanimelist.net/anime/producer/1418/Nippon_Television_Music" },
                    { 1421, null, new DateTime(1988, 2, 8, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/34492791-7164-4bce-97a7-0e191704bda8_600x600_i?s=d9945b9db6e231267595f989f306fb33", "タカラトミーアーツ", "Takara Tomy A.R.T.S", "https://myanimelist.net/anime/producer/1421/Takara_Tomy_ARTS" },
                    { 1422, null, new DateTime(1998, 3, 17, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "サイバーエージェント", "CyberAgent", "https://myanimelist.net/anime/producer/1422/CyberAgent" },
                    { 1428, null, new DateTime(1998, 10, 27, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/97327f56-0f34-4a9b-af2c-613b2888ef35_600x600_i?s=4f4b1c17b853b256e621afb7fd6c68f0", "レベルファイブ", "Level-5", "https://myanimelist.net/anime/producer/1428/Level-5" },
                    { 1430, null, null, "https://cdn.myanimelist.net/s/common/company_logos/511d9205-61e9-49a7-8b83-6ff37f76240e_600x600_i?s=e1b26fb49f243019fd92cd093ef2c805", "小学館", "Shogakukan", "https://myanimelist.net/anime/producer/1430/Shogakukan" },
                    { 1440, null, new DateTime(2014, 5, 13, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/fb8f8ef3-898d-4c36-b4f2-851d3e6748e0_600x600_i?s=b9d3256aa2765be1d0fdf658d84fcc0b", "フェリックスフィルム", "Felix Film", "https://myanimelist.net/anime/producer/1440/Felix_Film" },
                    { 1443, null, new DateTime(2012, 2, 29, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3d465d3c-827e-490f-ab3a-3f6b6dcc9b49_600x600_i?s=6c4a0fa1a61fcf1c93a276d40c435c2b", "オーバーラップ", "Overlap", "https://myanimelist.net/anime/producer/1443/Overlap" },
                    { 1444, null, new DateTime(2015, 3, 9, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/85974255-da7f-4e57-ad37-ceea169b782f_600x600_i?s=c2c98932b1024f53d67a98077d2e4afc", "EGG FIRM", "Egg Firm", "https://myanimelist.net/anime/producer/1444/Egg_Firm" },
                    { 1447, null, new DateTime(1996, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Urban Vision", "https://myanimelist.net/anime/producer/1447/Urban_Vision" },
                    { 1449, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "アニマティック", "Animatic", "https://myanimelist.net/anime/producer/1449/Animatic" },
                    { 1459, "Geneon Entertainment (USA) Inc. was the North American branch of anime producer Geneon Entertainment. The company began as Pioneer Entertainment, who began releasing anime in 1993. In 2003, the company was sold to Dentsu and changed their name to Geneon. Geneon was one of the largest anime distributors, along with ADV Films, Bandai Entertainment, FUNimation Entertainment and Viz Media.", null, "https://cdn.myanimelist.net/s/common/company_logos/c3d1d74f-d0d4-4d46-8039-056f0ae816c4_600x600_i?s=aa41e9b6ed55914b9c89bf357d105925", "Geneon Entertainment USA", "Geneon Entertainment USA", "https://myanimelist.net/anime/producer/1459/Geneon_Entertainment_USA" },
                    { 1461, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Audio Tanaka", "https://myanimelist.net/anime/producer/1461/Audio_Tanaka" },
                    { 1466, null, new DateTime(2005, 1, 4, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/765aa552-3e9a-4c96-b404-79b8c02bbff8_600x600_i?s=b05754b9d0eab01fa539a2c678041bcd", null, "Bandai Visual USA", "https://myanimelist.net/anime/producer/1466/Bandai_Visual_USA" },
                    { 1468, null, new DateTime(2006, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/73f4abea-0377-4362-8bb2-6d6577e9d303_600x600_i?s=30e237ce4c86b2874096c79521c492d2", "クランチロール", "Crunchyroll", "https://myanimelist.net/anime/producer/1468/Crunchyroll" },
                    { 1479, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Studio Core", "https://myanimelist.net/anime/producer/1479/Studio_Core" },
                    { 1487, null, new DateTime(2015, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9eed29b8-74dc-4f9e-ac63-a29f357f30b1_600x600_i?s=34aa3d69015c4fbf52af6146307d3591", "バウンシー", "Bouncy", "https://myanimelist.net/anime/producer/1487/Bouncy" },
                    { 1488, null, new DateTime(2003, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/993c0be8-602f-453b-ab58-555b2ebf1dd0_600x600_i?s=7480fd6a3c9fd88871d160316a0fa7bb", "博報堂DYメディアパートナーズ", "Hakuhodo DY Media Partners", "https://myanimelist.net/anime/producer/1488/Hakuhodo_DY_Media_Partners" },
                    { 1492, null, new DateTime(1970, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/da573007-e0a8-46c5-90c4-bcbd3433e5e0_600x600_i?s=7da90955ee955c3d5661b2c5b974c3eb", "読売テレビエンタープライズ", "Yomiuri TV Enterprise", "https://myanimelist.net/anime/producer/1492/Yomiuri_TV_Enterprise" },
                    { 1493, null, new DateTime(1965, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/c271d36e-bdaf-41ee-8002-dddb252129d9_600x600_i?s=76bb9db994a318939dab0502ccb7b714", "徳間ジャパンコミュニケーションズ", "Tokuma Japan Communications", "https://myanimelist.net/anime/producer/1493/Tokuma_Japan_Communications" },
                    { 1494, null, null, "https://cdn.myanimelist.net/s/common/company_logos/f1ad5888-3269-4a9f-8fd8-5652f952b7c7_600x600_i?s=e48e1604de1996db0e94c63ea5c7b244", "叶音", "Kanon Sound", "https://myanimelist.net/anime/producer/1494/Kanon_Sound" },
                    { 1496, null, new DateTime(1975, 4, 14, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/208a5450-7f48-4021-ae38-3d12bdf1c2f3_600x600_i?s=1dd54175ac5704138ecd9098d8ab2d02", "ローソン", "Lawson", "https://myanimelist.net/anime/producer/1496/Lawson" },
                    { 1498, null, new DateTime(1978, 7, 24, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e6dbdbcb-9239-416f-a633-7f36e84c93ff_600x600_i?s=a568c53ed89310b6c234edab868b586d", "コーエーテクモゲームス", "Koei Tecmo Games", "https://myanimelist.net/anime/producer/1498/Koei_Tecmo_Games" },
                    { 1499, null, null, "https://cdn.myanimelist.net/s/common/company_logos/cf0daf9e-d771-4eca-867e-f7921215883b_600x600_i?s=ee30bfe5a6ccdf587a8969584270452f", "テクノサウンド", "Techno Sound", "https://myanimelist.net/anime/producer/1499/Techno_Sound" },
                    { 1500, null, new DateTime(2016, 4, 4, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/2923bc60-5787-4791-8e04-00e530b98bfd_600x600_i?s=6cc464cff44a872a68908d1733f783c9", "ABCアニメーション", "ABC Animation", "https://myanimelist.net/anime/producer/1500/ABC_Animation" },
                    { 1501, null, new DateTime(1988, 5, 8, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/922216be-d9cc-4066-b166-d4eca1265603_600x600_i?s=cb9a21a0166250244456eca574c626ef", "ジェイアール東日本企画", "JR East Marketing & Communications", "https://myanimelist.net/anime/producer/1501/JR_East_Marketing___Communications" },
                    { 1506, null, new DateTime(1972, 4, 24, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/c48d4e17-5ecb-4574-9b3a-43b3b4fa2e54_600x600_i?s=ce361cd6bffed8f30e071a0338bbb9f0", "オーディオ・プランニングユー", "Audio Planning U", "https://myanimelist.net/anime/producer/1506/Audio_Planning_U" },
                    { 1507, null, new DateTime(1919, 12, 23, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f2155e83-e399-4d0b-b6f3-67f7e900afc1_600x600_i?s=8afe9fe3f8d4f268ea39ce06a985a08d", "住友商事", "Sumitomo", "https://myanimelist.net/anime/producer/1507/Sumitomo" },
                    { 1516, null, new DateTime(1951, 3, 15, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d66a81f3-4395-49c8-a6e7-42e961bf0837_600x600_i?s=a0a36e0762447730f84c62369380db9a", "ソニーPCL", "Sony PCL", "https://myanimelist.net/anime/producer/1516/Sony_PCL" },
                    { 1517, null, new DateTime(1993, 8, 10, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/93149ea2-0f03-42d3-b49b-ee2d8fe18ee1_600x600_i?s=3e9a6e8fcb93be7b27c7d8e679a35217", "神南スタジオ", "Jinnan Studio", "https://myanimelist.net/anime/producer/1517/Jinnan_Studio" },
                    { 1529, "Studio M2 is a Japanese pre-production planning company founded by Maruyama Masao in April 2016.", new DateTime(2016, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7ac6d9e5-8495-4dd6-9ccc-4db2df28a846_600x600_i?s=360daeb7bdbe6bebfb79ed82650b9dd2", "スタジオM2", "Studio M2", "https://myanimelist.net/anime/producer/1529/Studio_M2" },
                    { 1542, null, new DateTime(1999, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9fc2616d-1d9b-4305-8106-4d6f37fbc3ab_600x600_i?s=2ad98c5b4093cf2648e6c93f56805701", "DMM.com", "DMM.com", "https://myanimelist.net/anime/producer/1542/DMMcom" },
                    { 1543, null, new DateTime(2002, 6, 5, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b6636d77-7d09-48c4-bdad-8d9be66630b6_600x600_i?s=37cd3f9684b801f8804104532b78080a", "サンライズミュージック", "Sunrise Music", "https://myanimelist.net/anime/producer/1543/Sunrise_Music" },
                    { 1547, null, new DateTime(1990, 7, 5, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/db884645-6626-4ff3-994b-11482c13758c_600x600_i?s=effaad8ce8a4ca6612c7c0a2ae24472d", "BLADE(ブレイド)", "Blade", "https://myanimelist.net/anime/producer/1547/Blade" },
                    { 1551, null, new DateTime(1983, 6, 7, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/91b983d8-2479-491a-98db-555c984ce251_600x600_i?s=40e4977062af610383ce4291bf177f80", "角川メディアハウス", "Kadokawa Media House", "https://myanimelist.net/anime/producer/1551/Kadokawa_Media_House" },
                    { 1553, null, new DateTime(1945, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/c25ee56b-d06e-45e4-87f1-cab400dbf19e_600x600_i?s=6f4e1561fbb7d9dd1475208577c1e46b", "少年画報社", "Shounen Gahousha", "https://myanimelist.net/anime/producer/1553/Shounen_Gahousha" },
                    { 1554, null, new DateTime(2012, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9560ea10-c5ad-424a-ac60-19d8a5649c65_600x600_i?s=ae75c75610d5b29e4b337c41c7154710", "コンテンツシード", "Contents Seed", "https://myanimelist.net/anime/producer/1554/Contents_Seed" },
                    { 1557, null, new DateTime(1989, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "ポニーキャニオンエンタープライズ", "Pony Canyon Enterprises", "https://myanimelist.net/anime/producer/1557/Pony_Canyon_Enterprises" },
                    { 1560, null, new DateTime(2013, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/27260e22-f739-4854-b298-8be88ff87ca2_600x600_i?s=8afdd5382f9f8eafeefa5baec3e8bd91", "ヤオヨロズ", "Yaoyorozu", "https://myanimelist.net/anime/producer/1560/Yaoyorozu" },
                    { 1561, null, null, "https://cdn.myanimelist.net/s/common/company_logos/597286a9-b7f3-4da8-a06b-38197e8f400a_600x600_i?s=b8729ab1018c418642d8f57243927aaa", "石森プロ", "Ishimori Pro", "https://myanimelist.net/anime/producer/1561/Ishimori_Pro" },
                    { 1563, null, new DateTime(1925, 2, 10, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/20231b44-09c5-41c5-8ba0-b3f6cd67b70e_600x600_i?s=1d3186be845ee64703f9ea55e330b215", "博報堂", "Hakuhodo", "https://myanimelist.net/anime/producer/1563/Hakuhodo" },
                    { 1567, "NUT Co., Ltd. is a Japanese animation studio founded in 2017 by ex-Madhouse producer Takuya Tsunoki.\n\n(source: Wikipedia)", null, "https://cdn.myanimelist.net/s/common/company_logos/03530777-825a-414b-a320-21363dd0ed7b_600x600_i?s=8bb957866ca7a06b05958116dc1516cf", "ナット", "Nut", "https://myanimelist.net/anime/producer/1567/Nut" },
                    { 1569, "Seven Arcs Pictures (Seven Arcs Pictures Co., Ltd.) was the former name of Tokyo-based animation studio Seven Arcs Co., Ltd.\n\nSeven Arcs Pictures Co., Ltd. was established through an incorporation-type company split from Seven Arcs’ animation production business in April 2012. Yasamura Ryou — who had participated in the establishment of Arcturus — was appointed representative director of the new company. In October 2019, Seven Arcs Pictures absorbed Arcturus and Seven Arcs and changed its name to Seven Arcs Co., Ltd.", new DateTime(2012, 4, 22, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/28c51015-10a0-40c7-be1b-df2b651efb9d_600x600_i?s=448775b3e660cccc65eaed15beea35ab", "セブン・アークス・ピクチャーズ", "Seven Arcs Pictures", "https://myanimelist.net/anime/producer/1569/Seven_Arcs_Pictures" },
                    { 1572, null, new DateTime(2015, 7, 14, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/828599d1-6452-4fad-9899-2fac457acd99_600x600_i?s=c02894221031babcddaafc3cf498db41", "XFLAG", "XFLAG", "https://myanimelist.net/anime/producer/1572/XFLAG" },
                    { 1573, null, null, "https://cdn.myanimelist.net/s/common/company_logos/71b7f960-41ed-4980-aa41-62ed32fc855e_600x600_i?s=f85f0aaf5325089357c0ffff5eb933b2", null, "XFLAG Pictures", "https://myanimelist.net/anime/producer/1573/XFLAG_Pictures" },
                    { 1575, null, null, "https://cdn.myanimelist.net/s/common/company_logos/e33c2504-defc-4e24-9a0d-e1561fd7691d_600x600_i?s=ae94afb54a25a4477f5b87ccd04c63ca", "DR Movie", "DR Movie", "https://myanimelist.net/anime/producer/1575/DR_Movie" },
                    { 1576, null, new DateTime(1999, 3, 3, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/38c86a1a-47bb-44bb-b885-4f8d889c8279_600x600_i?s=75ecbc20a5f78816db805402a9da36f2", "ディー・エヌ・エー", "DeNA", "https://myanimelist.net/anime/producer/1576/DeNA" },
                    { 1581, null, new DateTime(1981, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/2b6f8468-d04b-44a2-bcbe-53ce0b21dc02_600x600_i?s=ea963213ed30d6cde75173c6e6f11732", "レイ", "RAY", "https://myanimelist.net/anime/producer/1581/RAY" },
                    { 1583, null, new DateTime(2007, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/2661fad2-8a5b-4823-af2d-cf5a7ff6c7dd_600x600_i?s=0ab6a9df56661f61e09f046dfec6530d", "U-NEXT", "U-NEXT", "https://myanimelist.net/anime/producer/1583/U-NEXT" },
                    { 1584, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Beyond C.", "https://myanimelist.net/anime/producer/1584/Beyond_C" },
                    { 1585, null, new DateTime(1963, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7a88afdc-72e3-4be5-a684-36e9ff1dd90f_600x600_i?s=dac2f165f4179d907cc4202e07f81512", "日音", "Nichion", "https://myanimelist.net/anime/producer/1585/Nichion" },
                    { 1588, null, new DateTime(2002, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ddd3b130-f3d4-4bf4-bbf8-fec515491e68_600x600_i?s=2f244b91860251266f5e17afd6ca687f", "バンダイチャンネル", "Bandai Channel", "https://myanimelist.net/anime/producer/1588/Bandai_Channel" },
                    { 1589, null, new DateTime(1990, 2, 1, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/dfe4c906-0df8-4fd9-8491-2a3fdb832c66_600x600_i?s=daee4ad674527a02920104cfe0033f06", "日本ナレーション演技研究所", "NichiNare", "https://myanimelist.net/anime/producer/1589/NichiNare" },
                    { 1590, null, new DateTime(2007, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "フリュー", "FuRyu", "https://myanimelist.net/anime/producer/1590/FuRyu" },
                    { 1591, "Director Masaaki Yuasa and longtime collaborator Eun-Young Choi founded animation studio Science SARU (Science SARU Inc.) in 2013 while producing \"Food Chain,\" the 163rd episode of the American animated series Adventure Time. The show's host cable television channel, Cartoon Network, requested a studio to credit for the episode's animation, and out of necessity Science SARU was formed. \n\nScience SARU has been home to Yuasa's films and series since, and has welcomed additional directors since 2021—Choi directed \"Akakiri,\" the ninth episode of Disney's Star Wars: Visions, and award-winning director Naoko Yamada helmed the anime series Heike Monogatari (The Heike Story). \n\nChoi is the studio's current president and CEO, having succeeded Yuasa in these roles after he stepped down in March 2020.", new DateTime(2013, 2, 3, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4c810cc0-ae5b-4b4d-98e7-926c719275b9_600x600_i?s=9ab5260497621fcca4a578fed011a1c3", "サイエンスSARU", "Science SARU", "https://myanimelist.net/anime/producer/1591/Science_SARU" },
                    { 1602, null, new DateTime(2008, 10, 21, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3f70023f-84e9-4d76-bbc4-26181ec80e24_600x600_i?s=fce62e7f9afeadbd6290b1a6e88be5e5", "GYAO", "GYAO!", "https://myanimelist.net/anime/producer/1602/GYAO" },
                    { 1603, null, new DateTime(1872, 2, 20, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/27094128-1490-43f4-83b2-d2b0e2d64ecd_600x600_i?s=8937b41b47f1cb6fd6ad39300fd35242", "毎日新聞社", "Mainichi Shimbun", "https://myanimelist.net/anime/producer/1603/Mainichi_Shimbun" },
                    { 1604, null, new DateTime(1969, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ac7dba83-060b-4cba-8a19-69947a265176_600x600_i?s=b16540b5a8dfd1d69802414541f3a8d5", "サンテレビジョン", "Sun TV", "https://myanimelist.net/anime/producer/1604/Sun_TV" },
                    { 1605, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "I Will", "https://myanimelist.net/anime/producer/1605/I_Will" },
                    { 1607, null, new DateTime(2017, 1, 3, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/13fb7dc9-d998-4fe9-bbad-75ae4d27f718_600x600_i?s=ed57cb4d460af97335267354d37269c5", "電通テック", "Dentsu Tec", "https://myanimelist.net/anime/producer/1607/Dentsu_Tec" },
                    { 1614, null, new DateTime(1995, 12, 17, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e57e4330-8ae3-4606-a251-7470a9548dd0_600x600_i?s=8a8a44b0f4877da2c31244ed35efed07", "ぷらら", "NTT Plala", "https://myanimelist.net/anime/producer/1614/NTT_Plala" },
                    { 1615, null, new DateTime(2019, 6, 15, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/64f82ef6-31ed-4156-9133-8dc9f4b85b30_600x600_i?s=71d09670a8bb2b4fa25395368f70a6a7", "USEN", "USEN", "https://myanimelist.net/anime/producer/1615/USEN" },
                    { 1617, null, new DateTime(1998, 10, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d5a49476-980f-415e-aeb4-0cbddffdda76_600x600_i?s=019253d93db770bdc615988602d20edb", "テンセント", "Tencent Japan", "https://myanimelist.net/anime/producer/1617/Tencent_Japan" },
                    { 1632, null, new DateTime(1968, 3, 7, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0f251441-e6c9-4737-a2f5-fe6fba323227_600x600_i?s=de8c3632e890264d2211333112fb46a1", "大一商会", "Daiichi Shokai", "https://myanimelist.net/anime/producer/1632/Daiichi_Shokai" },
                    { 1635, null, new DateTime(2008, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/32bbc774-5db1-4277-b0d5-c363926eb48f_600x600_i?s=f1474d50cfda345e3866b74f3f15d998", "A-Sketch", "A-Sketch", "https://myanimelist.net/anime/producer/1635/A-Sketch" },
                    { 1639, null, new DateTime(2012, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d82f77ac-7e02-4b25-8af7-9e2cad2f39ea_600x600_i?s=3c2da1a3af139d07810709c9c4648550", "チップチューン", "Chiptune", "https://myanimelist.net/anime/producer/1639/Chiptune" },
                    { 1645, null, null, "https://cdn.myanimelist.net/s/common/company_logos/a8a92112-4c2c-4537-9cf2-49fa8962c0eb_600x600_i?s=c9d59bdccbe07126350fc35a4819fde2", "ジャスト プロ", "Just Production", "https://myanimelist.net/anime/producer/1645/Just_Production" },
                    { 1653, null, new DateTime(1990, 10, 3, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8743b03c-3e27-472d-bf55-c90f8a0e9dab_600x600_i?s=a460cb036b4b24f9f4732a7be5007a74", "木下グループ", "Kinoshita Group Holdings", "https://myanimelist.net/anime/producer/1653/Kinoshita_Group_Holdings" },
                    { 1659, null, new DateTime(2015, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/c2cf4f85-7ae0-472c-afdc-79170e9a1b6b_600x600_i?s=8bfa9398fa35e86f787463dc5ef3969b", "AbemaTV（アベマティーヴィー）", "AbemaTV", "https://myanimelist.net/anime/producer/1659/AbemaTV" },
                    { 1664, null, null, "https://cdn.myanimelist.net/s/common/company_logos/571fa04c-d2e2-45f6-ba4c-7932f648b428_600x600_i?s=ba8ad748eebf9cdc1e41696aac727808", "富士見書房", "Fujimi Shobo", "https://myanimelist.net/anime/producer/1664/Fujimi_Shobo" },
                    { 1671, null, new DateTime(1999, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/19a21eb0-3fa9-468a-9f61-427b666b4ec7_600x600_i?s=35db15f691cb1411c46ac631fc1666b6", "DMMピクチャーズ", "DMM pictures", "https://myanimelist.net/anime/producer/1671/DMM_pictures" },
                    { 1672, null, new DateTime(1961, 6, 13, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7674a28f-4299-4b35-8671-c9b64d38ffb8_600x600_i?s=07d453b2bc5ab4e63b6189421d3e54c1", "新書館", "Shinshokan", "https://myanimelist.net/anime/producer/1672/Shinshokan" },
                    { 1673, null, new DateTime(2012, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/296e1bba-ca86-4c3d-ad9a-fe51cd1f1abc_600x600_i?s=4208ed6e89671291567261b638663268", "DMM.futureworks", "DMM.futureworks", "https://myanimelist.net/anime/producer/1673/DMMfutureworks" },
                    { 1680, null, new DateTime(1998, 12, 1, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/bdb6955a-6a8e-4c88-bde3-e123ca891d29_600x600_i?s=d25aaeeb6f03c5f2b69a22d2808c0bae", "ＢＳ日テレ", "BS NTV", "https://myanimelist.net/anime/producer/1680/BS_NTV" },
                    { 1683, null, new DateTime(2016, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/86270050-2d56-4e4e-891e-5f97e9f370c8_600x600_i?s=c772475b5c5bcfba2d2a511562734ac0", "ストレートエッジ", "Straight Edge", "https://myanimelist.net/anime/producer/1683/Straight_Edge" },
                    { 1684, null, new DateTime(2016, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/14e98e41-0872-40e8-bf89-614a2fefbda4_600x600_i?s=51e04aae5df6df019c6e16a178ee12fe", "シンカー", "THINKR", "https://myanimelist.net/anime/producer/1684/THINKR" },
                    { 1687, "Yokohama Animation Laboratory (Yokohama Animation Lab Co., Ltd.) is a Japanese animation studio based in Naka-ku, Yokohama. It was founded on July 2015 by former Production I.G's Division 7 producer Yuma Ogami.\n\nIn 2021, Yokohama animation producer Satoshi Nakatani established the cooperation company CLOUDHEARTS, and then started animation production under the name of co-production.", new DateTime(2015, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/5bee6ffd-6785-4794-8886-497c5c66b31d_600x600_i?s=c36c88eaf49435a17024f58d52a3e04e", "横浜アニメーションラボ", "Yokohama Animation Laboratory", "https://myanimelist.net/anime/producer/1687/Yokohama_Animation_Laboratory" },
                    { 1692, null, new DateTime(2016, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/57005b94-b164-4c6d-9ebd-aab4389fcbf5_600x600_i?s=85c9e5cfca6b1a122c3af0d986c4c25a", "レヴォルト", "Revoroot", "https://myanimelist.net/anime/producer/1692/Revoroot" },
                    { 1693, null, new DateTime(2013, 7, 2, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b3b4f855-0fb3-49bb-b822-7ab2c38da683_600x600_i?s=24c7f4513b444d333a3c1c39ef92245a", "スタジオフラッド", "Studio Flad", "https://myanimelist.net/anime/producer/1693/Studio_Flad" },
                    { 1695, null, new DateTime(2011, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/1fc3de62-65ca-43ff-9419-d0e4777bc5da_600x600_i?s=daf6091971ef289afbf386c63e83eedc", "HJホールディングス", "Hulu", "https://myanimelist.net/anime/producer/1695/Hulu" },
                    { 1696, null, new DateTime(2014, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8a7cb4eb-caa6-46e1-8997-cb1e1ea5ffd2_600x600_i?s=c040c830a2425bb0a280e1f751c43b09", "KADOKAWA", "Kadokawa", "https://myanimelist.net/anime/producer/1696/Kadokawa" },
                    { 1697, null, new DateTime(1984, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/2531a56b-9d3c-44c7-b476-f2f94fe08208_600x600_i?s=0b1720c88025a29570018a0c09b76a7c", "KDDI", "KDDI", "https://myanimelist.net/anime/producer/1697/KDDI" },
                    { 1698, null, new DateTime(1958, 4, 7, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8f6f3ed6-5f6a-48c8-8a3f-744c20b4fe22_600x600_i?s=5cd9f9d63091035cc4f744428c3eb271", "札幌テレビ放送", "Sapporo Television Broadcasting", "https://myanimelist.net/anime/producer/1698/Sapporo_Television_Broadcasting" },
                    { 1699, null, new DateTime(1970, 1, 16, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/fc578bf0-525b-491c-b32d-26ef0758e152_600x600_i?s=8a9acbf72bc0066004ad4b6bee1a2b4f", "宮城テレビ放送", "Miyagi Television Broadcasting", "https://myanimelist.net/anime/producer/1699/Miyagi_Television_Broadcasting" },
                    { 1700, null, new DateTime(1979, 2, 14, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3e46f72c-cec2-4ad3-bd64-9313fea30022_600x600_i?s=ccb1481ef155b32015722e4d8e2a5645", "静岡第一テレビ", "Shizuoka Daiichi Television", "https://myanimelist.net/anime/producer/1700/Shizuoka_Daiichi_Television" },
                    { 1701, null, new DateTime(1968, 2, 29, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3bfe384e-ad9c-455e-8db1-f220cfe69aea_600x600_i?s=bc48f0ddbcd5fb3a20dc047177599ce4", "中京テレビ放送", "Chukyo TV Broadcasting", "https://myanimelist.net/anime/producer/1701/Chukyo_TV_Broadcasting" },
                    { 1702, null, new DateTime(1962, 8, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b8f89b00-7cb6-476b-ad00-4205f8e659ce_600x600_i?s=a9b1c3037edd251e0eb49c55ec2fb2c1", "広島テレビ", "Hiroshima Television", "https://myanimelist.net/anime/producer/1702/Hiroshima_Television" },
                    { 1703, null, new DateTime(1968, 5, 26, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/945b36af-36a3-4dca-8990-d5f9fb6534c7_600x600_i?s=a1b45287a0e79a0358c54b1ecfd74e68", "福岡放送", "Fukuoka Broadcasting System", "https://myanimelist.net/anime/producer/1703/Fukuoka_Broadcasting_System" },
                    { 1707, null, null, "https://cdn.myanimelist.net/s/common/company_logos/4af0755f-b803-466e-9585-99512cdc47b0_600x600_i?s=66749e458087262ab7c245c39f4a8a6b", "AKABEiSOFT2", "AKABEiSOFT2", "https://myanimelist.net/anime/producer/1707/AKABEiSOFT2" },
                    { 1720, null, new DateTime(1969, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/791687ae-5196-4b63-95c9-eb5c2141bc0f_600x600_i?s=a981c95a142cc688e987dee155fd24b5", "青二プロダクション", "Aoni Production", "https://myanimelist.net/anime/producer/1720/Aoni_Production" },
                    { 1723, null, new DateTime(2018, 6, 7, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e41009d8-7afd-4d4d-9da4-c5037236e5c5_600x600_i?s=8c665ae5fbc71282f173860549aa6d0c", "アニメビーンズ", "Anime Beans", "https://myanimelist.net/anime/producer/1723/Anime_Beans" },
                    { 1730, null, null, "https://cdn.myanimelist.net/s/common/company_logos/cc0d5f75-bbb1-41c5-8ec5-6c1abef19083_600x600_i?s=993ce6f3bbc0580724b152133e7f5a6e", "月鈴舎", "Moonbell", "https://myanimelist.net/anime/producer/1730/Moonbell" },
                    { 1732, null, null, "https://cdn.myanimelist.net/s/common/company_logos/6f27b611-94b1-4717-9182-fc67f40ca3ef_600x600_i?s=3b4ec755ef21f95fe0c8fcf5012e3f09", "SPACEY MUSIC ENTERTAINMENT", "Spacey Music Entertainment", "https://myanimelist.net/anime/producer/1732/Spacey_Music_Entertainment" },
                    { 1735, null, null, "https://cdn.myanimelist.net/s/common/company_logos/bf1b2c72-2eaf-457b-b7c9-524a3d363f5d_600x600_i?s=222c628568aef9ed89f4c04793d3391d", "JY Animation", "JY Animation", "https://myanimelist.net/anime/producer/1735/JY_Animation" },
                    { 1737, null, null, "https://cdn.myanimelist.net/s/common/company_logos/44f553f4-bccd-404d-80c7-3bbbc3520dd6_600x600_i?s=51f0671f9137cec82ad9d6c8588a3f5f", "Shout! Factory", "Shout! Factory", "https://myanimelist.net/anime/producer/1737/Shout_Factory" },
                    { 1747, null, new DateTime(2014, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/17df5f92-45a5-4034-9789-c862c09e39bd_600x600_i?s=4b6299d9ca144c853f2f990c9250121a", "ツインエンジン", "Twin Engine", "https://myanimelist.net/anime/producer/1747/Twin_Engine" },
                    { 1753, null, null, "https://cdn.myanimelist.net/s/common/company_logos/be86a6c8-ffbd-4b21-b204-d13e607e9d20_600x600_i?s=0bd984fffc30c7b0d68d5da634b503ce", "デジタル・アンド・デザイン・ピクチャーズ", "D & D Pictures", "https://myanimelist.net/anime/producer/1753/D___D_Pictures" },
                    { 1779, null, new DateTime(2018, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0baf75d2-6cf6-4643-a543-82a003a3ea69_600x600_i?s=77cea269374f160855f00dbd784bd16b", "ニューギンホールディングス", "NewGin", "https://myanimelist.net/anime/producer/1779/NewGin" },
                    { 1783, null, null, "https://cdn.myanimelist.net/s/common/company_logos/00720e7f-d053-4b4b-b92a-83c6c51fd336_600x600_i?s=e8407ca579ea0fde3148ad5a4a63488d", "ONEMUSIC", "ONEMUSIC", "https://myanimelist.net/anime/producer/1783/ONEMUSIC" },
                    { 1784, "Crunchyroll SC Anime Fund was a joint venture company established by Crunchyroll and Sumitomo Corporation to invest anime productions. It was dissolved and merged into Crunchyroll in 2023.", new DateTime(2016, 2, 4, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "クランチロールSCアニメファンド", "Crunchyroll SC Anime Fund", "https://myanimelist.net/anime/producer/1784/Crunchyroll_SC_Anime_Fund" },
                    { 1786, null, new DateTime(1992, 9, 1, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0ab5b912-5121-4e03-a7c3-a5456e360319_600x600_i?s=15c840bf13f5dbee354e1c026c35fa68", "ミューズコミュニケーション", "Muse Communication", "https://myanimelist.net/anime/producer/1786/Muse_Communication" },
                    { 1791, null, null, "https://cdn.myanimelist.net/s/common/company_logos/4dc616ce-57f0-4475-8b00-a75d402c4e64_600x600_i?s=412008bf5023356dcb6a5ec5a5959701", "D.N ドリームパートナーズ", "D.N. Dream Partners", "https://myanimelist.net/anime/producer/1791/DN_Dream_Partners" },
                    { 1797, "The commercial subsidiary of NHK Holdings and affiliate of NHK; NHK Enterprises handles sales and distribution of the company's programming and intellectual property, and manages their copyrights. In addition, it functions as a production contractor for NHK programming.\n\nOriginally founded in 1985 as 'NHK Enterprises', it was merged with NHK Creative in 1995 and was rebranded as 'NHK Enterprises 21'. On April 1st, 2005, it was merged with NHK Software (the corporation's video arm); the resulting company was rebranded once more back to 'NHK Enterprises'. Later, other affiliated companies of NHK were absorbed, including Sogo Vision in 2013 and NHK Planet in 2020.", new DateTime(2005, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "NHKエンタープライズ", "NHK Enterprises", "https://myanimelist.net/anime/producer/1797/NHK_Enterprises" },
                    { 1800, null, new DateTime(1937, 3, 29, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/735cfb00-22d2-4234-99b3-63d82d9b889d_600x600_i?s=d17c7bae2f198c2193f124e0485255c4", "マルイグループ", "Marui Group", "https://myanimelist.net/anime/producer/1800/Marui_Group" },
                    { 1803, null, new DateTime(2011, 7, 14, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/fd6fbc7d-8727-46af-a07c-8c600c578638_600x600_i?s=47dbdceb2c688a3728085aa03774c66a", "ディアステージ", "Dear Stage inc.", "https://myanimelist.net/anime/producer/1803/Dear_Stage_inc" },
                    { 1815, null, new DateTime(2004, 12, 6, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/5510dddb-b23b-4f5c-9d3b-a681272c500c_600x600_i?s=e81c6fdd69fb04531c1bb69b0ca24ae8", "グリー", "GREE", "https://myanimelist.net/anime/producer/1815/GREE" },
                    { 1817, null, new DateTime(1997, 2, 6, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/86fb06d0-ec62-4170-8308-29caa6d8666e_600x600_i?s=a099f45d6afef1888dd487712a93dcfe", "楽天グループ", "Rakuten", "https://myanimelist.net/anime/producer/1817/Rakuten" },
                    { 1821, null, new DateTime(1991, 1, 22, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b0ec1175-806e-4fe6-a018-b90602f2fc6a_600x600_i?s=d22ee7b5ac4e1f6472a18fef63b4cd7e", "メロンブックス", "Melonbooks", "https://myanimelist.net/anime/producer/1821/Melonbooks" },
                    { 1822, null, null, "https://cdn.myanimelist.net/s/common/company_logos/130b486c-885d-4e00-8e26-cbde9433cf03_600x600_i?s=896bdd6e7798abda3f904900a6a991a5", "フジオ・プロダクション", "Fujio Production", "https://myanimelist.net/anime/producer/1822/Fujio_Production" },
                    { 1828, null, new DateTime(2014, 6, 29, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/dc53432e-9634-4762-b6f0-cf42ddbc3cb0_600x600_i?s=51a9a546e0bc0b408ea8150dd2b3f9e2", "ラパントラック", "Lapin Track", "https://myanimelist.net/anime/producer/1828/Lapin_Track" },
                    { 1835, "CloverWorks (CloverWorks, Inc) is a Japanese subsidiary animation company from Suginami, Tokyo. It was original named Kouenji Studio under A-1 Pictures owned by parent company Aniplex. The studio was rebranded as CloverWorks in April 2018. In October 2018, CloverWorks separated from A-1 Pictures while remaining a subsidary of Aniplex. \n\nThe studio has released 25 projects since its rebranding with an additional four projects - Slow Start, Darling in the Franxx, Persona 5: The Animation, and Ace Attorney Season 2 - changing the credited studio from A-1 Pictures to CloverWorks either during or after their original runs.", new DateTime(2018, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/75875b81-17bb-4f7e-a06f-bb149d54687e_600x600_i?s=b90a570d03511f70dbac7e04869f4835", "クローバーワークス", "CloverWorks", "https://myanimelist.net/anime/producer/1835/CloverWorks" },
                    { 1840, null, new DateTime(1983, 8, 22, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/80592a98-9550-4177-ab78-fe62823f362d_600x600_i?s=7f7425f942df08eb1d79257b255bed52", "バンダイナムコアーツ", "Bandai Namco Arts", "https://myanimelist.net/anime/producer/1840/Bandai_Namco_Arts" },
                    { 1846, "Established Tokyo Movie Shinsha in 1976 as its marketing division (acquired by Sega Enterprises in 1992 and by Kyokuichi in 1995; the latter became TMS Entertainment in 2000). Dissolved in 1993-02.", new DateTime(1964, 8, 18, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "東京ムービー", "Tokyo Movie", "https://myanimelist.net/anime/producer/1846/Tokyo_Movie" },
                    { 1856, null, new DateTime(2017, 1, 24, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ed9fa693-d569-4262-9c15-cc73cb961da4_600x600_i?s=014d9db301a40db1455c2d8a23c981b1", "dugout", "dugout", "https://myanimelist.net/anime/producer/1856/dugout" },
                    { 1857, null, new DateTime(2017, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/32186dfd-9d88-40f0-8f63-657aca0c948d_600x600_i?s=f75a41dd8748066f72196a8eaa1b358f", "ギークトイズ", "Geek Toys", "https://myanimelist.net/anime/producer/1857/Geek_Toys" },
                    { 1858, null, new DateTime(2006, 3, 2, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0bb1ac7d-49d2-4f74-8da2-75a916e61ef9_600x600_i?s=f31b74f90ca49f394059dde829db31c3", "ソニルード", "Sonilude", "https://myanimelist.net/anime/producer/1858/Sonilude" },
                    { 1865, null, new DateTime(2011, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/586b2011-f17c-4789-8b8c-e52a95dab894_600x600_i?s=eef274d1da7ae1e5453039af4f539344", "リンクトブレイン", "LinkedBrain", "https://myanimelist.net/anime/producer/1865/LinkedBrain" },
                    { 1873, null, new DateTime(2001, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/cb4c5390-cc47-41de-acba-0f97756e3fdc_600x600_i?s=40ed436a7c788e833bea175afe371295", "シルバー", "Silver", "https://myanimelist.net/anime/producer/1873/Silver" },
                    { 1874, null, new DateTime(2017, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f72d22d4-c30e-45ee-9c13-f6fab2748f35_600x600_i?s=163f161f619d20f3105e21576d3bfa93", "アルボアニメーション", "Arvo Animation", "https://myanimelist.net/anime/producer/1874/Arvo_Animation" },
                    { 1877, null, new DateTime(2000, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e6053840-633b-4631-a19e-83834cad7828_600x600_i?s=d3627d72ee1cdb632ca46b8a33fec212", "祭", "MAZRI", "https://myanimelist.net/anime/producer/1877/MAZRI" },
                    { 1880, null, null, "https://cdn.myanimelist.net/s/common/company_logos/2f45455c-b30a-4ea8-b555-c8c77362d993_600x600_i?s=3a5152bfeecca939abc8be0e1369479f", "Tencent Games", "Tencent Games", "https://myanimelist.net/anime/producer/1880/Tencent_Games" },
                    { 1883, null, new DateTime(2016, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/5653b06e-0cab-4436-a5dc-f514d2879c95_600x600_i?s=e5f56c2beec651a283a70f0a312fbc16", "アップドリーム", "APDREAM", "https://myanimelist.net/anime/producer/1883/APDREAM" },
                    { 1889, null, null, "https://cdn.myanimelist.net/s/common/company_logos/0db0431f-76c7-4037-841d-281bb6b4e36e_600x600_i?s=8242157b48454a78094703ac720cbd60", null, "Warner Bros. Pictures", "https://myanimelist.net/anime/producer/1889/Warner_Bros_Pictures" },
                    { 1896, null, new DateTime(1984, 7, 3, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/2a693b86-d36a-4bb2-9ba3-1b43dbc020c6_600x600_i?s=a616d90ca2616cb9bdde886de4af87c9", "マイクロ・マガジン", "Micro Magazine Publishing", "https://myanimelist.net/anime/producer/1896/Micro_Magazine_Publishing" },
                    { 1908, null, new DateTime(1988, 2, 29, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "レッグス", "Legs", "https://myanimelist.net/anime/producer/1908/Legs" },
                    { 1916, "Kadokawa Animation is Kadokawa's label for theatrical anime releases.", null, "https://cdn.myanimelist.net/images/company_no_picture.png", "角川ANIMATION", "Kadokawa Animation", "https://myanimelist.net/anime/producer/1916/Kadokawa_Animation" },
                    { 1918, null, new DateTime(2003, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8e8a719f-e4cf-4549-bf42-b31bf48a5080_600x600_i?s=e50b235770f7def4792999a15dc29f75", "エスエムイーレコーズ", "SME Records", "https://myanimelist.net/anime/producer/1918/SME_Records" },
                    { 1927, null, new DateTime(2017, 6, 7, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/39709312-12c7-4ae9-aedd-00b7e8ebeb38_600x600_i?s=65e18b6657b2eabc30d80b000c37206b", "サーティースリーコレクティブ", "Studio Crocodile", "https://myanimelist.net/anime/producer/1927/Studio_Crocodile" },
                    { 1934, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "最後の手段", "Saigo no Shudan", "https://myanimelist.net/anime/producer/1934/Saigo_no_Shudan" },
                    { 1947, null, null, "https://cdn.myanimelist.net/s/common/company_logos/5aac4ffa-e1a2-4a1f-bd59-4c28bcadc395_600x600_i?s=72bb48d47d2493fa3340c570d0ed7d31", "ケイトアロー", "Kate Arrow", "https://myanimelist.net/anime/producer/1947/Kate_Arrow" },
                    { 1967, "Drive is a music production, anime production and artist management company situated in Suginami, Tokyo.", new DateTime(2015, 5, 10, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/13a5bc7d-2c3b-4e30-b9e9-8993a0114c30_600x600_i?s=a8fbe1410ee8f600e38fbe77c249767b", "ドライブ", "Drive", "https://myanimelist.net/anime/producer/1967/Drive" },
                    { 1972, null, new DateTime(2016, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e4d249b3-69bc-4a33-9035-25f17f256015_600x600_i?s=7177e083d1f32e5278e99f125032b2b6", "HOT ZIPANG", "HOTZIPANG", "https://myanimelist.net/anime/producer/1972/HOTZIPANG" },
                    { 1974, null, new DateTime(2018, 4, 3, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b744ce42-5dce-4a4f-9eb9-66a48be4fec3_600x600_i?s=555882dbf426ff3256bac9da96cc174d", "ENGI", "ENGI", "https://myanimelist.net/anime/producer/1974/ENGI" },
                    { 1976, null, new DateTime(2003, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f56a4452-a40a-49e5-9ba6-f1e46830839a_600x600_i?s=3ef10e0827e789691ed4e11a9b39e2f8", "CGCGスタジオ", "CGCG Studio", "https://myanimelist.net/anime/producer/1976/CGCG_Studio" },
                    { 1977, "Netflix is an American entertainment company founded by Reed Hastings and Marc Randolph on August 29, 1997, in Scotts Valley, California. It specializes in and provides streaming media and video-on-demand online and DVD by mail. In 2013, Netflix expanded into film and television production as well as online distribution. It is headquartered in Los Gatos, California.", new DateTime(1997, 8, 28, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/a3195da6-2956-4239-a6be-26a683d952af_600x600_i?s=2be280080efdafc78705d23c98bd31ee", "ネットフリックス", "Netflix", "https://myanimelist.net/anime/producer/1977/Netflix" },
                    { 1978, null, new DateTime(2018, 5, 28, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7879474b-7cd9-422c-a13e-01e986639306_600x600_i?s=2d8cf250b0949198b745f79dc54718ff", "ＭＡＨＯ ＦＩＬM", "Maho Film", "https://myanimelist.net/anime/producer/1978/Maho_Film" },
                    { 1982, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "ライデンフィルム大阪スタジオ", "LIDENFILMS Osaka Studio", "https://myanimelist.net/anime/producer/1982/LIDENFILMS_Osaka_Studio" },
                    { 1984, "A production label for Tatsunoko Production.", null, "https://cdn.myanimelist.net/s/common/company_logos/428cae56-b153-4257-a989-0ce14e9a8f07_600x600_i?s=fa723ab99c8f3181c5060150b8ed379e", "BAKKEN RECORD", "Bakken Record", "https://myanimelist.net/anime/producer/1984/Bakken_Record" },
                    { 1986, null, new DateTime(2015, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/a2fb3631-65e9-4c35-ac19-593cdcf5b103_600x600_i?s=cd37382e5e9e3e5796a06621a146bf17", "アルマビアンカ", "arma bianca", "https://myanimelist.net/anime/producer/1986/arma_bianca" },
                    { 1988, null, new DateTime(2003, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/40dd3768-662b-46c0-98ed-47ee1f83800a_600x600_i?s=0ef9b3fcc8e69ca21fda35d543b5c8a4", "TOブックス", "TO Books", "https://myanimelist.net/anime/producer/1988/TO_Books" },
                    { 1992, null, new DateTime(2018, 2, 14, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4e23c624-e75c-4963-bef1-b0ac5f55fe12_600x600_i?s=d5ada21d6a3591ce0b6515dfae0125b9", "BANDAI SPIRITS", "Bandai Spirits", "https://myanimelist.net/anime/producer/1992/Bandai_Spirits" },
                    { 1993, "The company was founded as a joint venture between animation studio White Fox and production, planning and management company Egg Firm.", new DateTime(2018, 10, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/17557685-c55a-4aa3-9990-a13667e7c1b5_600x600_i?s=c81759de42fc570ba43e173dff286257", "スタジオバインド", "Studio Bind", "https://myanimelist.net/anime/producer/1993/Studio_Bind" },
                    { 1996, null, null, "https://cdn.myanimelist.net/s/common/company_logos/6fe747cc-cb59-4043-8188-8265774b22d0_600x600_i?s=5b5ba110dc5466c9b4c44c2cd0ccd787", "MAGNET", "MAGNET", "https://myanimelist.net/anime/producer/1996/MAGNET" },
                    { 1997, null, new DateTime(2019, 5, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0dd31a16-97e4-44af-9bd8-76c3ab8fc307_600x600_i?s=02c61ff2a6d24163f61726b5d31ac0f1", "スタジオ櫂", "Studio Kai", "https://myanimelist.net/anime/producer/1997/Studio_Kai" },
                    { 2004, null, new DateTime(2019, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f8ea055c-a280-4843-a520-c38b4bcb7816_600x600_i?s=50977998adf909fd82ffea708b14e636", "SUNRISE BEYOND", "Sunrise Beyond", "https://myanimelist.net/anime/producer/2004/Sunrise_Beyond" },
                    { 2016, null, new DateTime(2010, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/cdf7268f-a5d2-45ad-95d2-6dd4dab836c6_600x600_i?s=809553b5d6d712db21f0ae9dcb3957bb", "阿部秀司事務所", "Abe Shuuji Jimusho", "https://myanimelist.net/anime/producer/2016/Abe_Shuuji_Jimusho" },
                    { 2018, null, new DateTime(2018, 9, 12, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/2ca62faa-39e1-45ee-ac8e-be5c656cb29e_600x600_i?s=3dea7da8b4c0b5a7af38303c89cd3d0b", "リアルト・エンタテインメント", "Rialto Entertainment", "https://myanimelist.net/anime/producer/2018/Rialto_Entertainment" },
                    { 2019, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Sola Entertainment", "https://myanimelist.net/anime/producer/2019/Sola_Entertainment" },
                    { 2031, null, new DateTime(1992, 7, 22, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/2b6ce6f7-3714-4345-918a-cda9725771d6_600x600_i?s=98affd39659eb55a35e4a453e63bc3b8", "ローソンエンタテインメント", "Lawson Entertainment", "https://myanimelist.net/anime/producer/2031/Lawson_Entertainment" },
                    { 2034, "Akatsuki is a subcontracting studio located in Suginami, Tokyo.", new DateTime(2016, 2, 14, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f70acdd6-9d2f-4059-9e14-7b0726390a7e_600x600_i?s=52fbf4e0c2c42137d443b9f715ffd941", "暁", "Akatsuki", "https://myanimelist.net/anime/producer/2034/Akatsuki" },
                    { 2037, null, new DateTime(2017, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/126e5cf4-6b4c-4bff-893f-c82725c7170a_600x600_i?s=9737208860e8e106c570ce3ba66ce56e", "オクルトノボル", "Okuruto Noboru", "https://myanimelist.net/anime/producer/2037/Okuruto_Noboru" },
                    { 2044, null, null, "https://cdn.myanimelist.net/s/common/company_logos/95995ce8-d293-46b2-8f3f-9f643c419d98_600x600_i?s=19657906e433adb51aeff338d9a35cb9", "webtoon", "Naver Webtoons", "https://myanimelist.net/anime/producer/2044/Naver_Webtoons" },
                    { 2045, null, new DateTime(2001, 7, 17, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/2e90d7c0-ed3c-4227-af36-f80f11dedf2a_600x600_i?s=789318181219d13a74387a080d6243e4", "ミリカ・ミュージック", "Myrica Music", "https://myanimelist.net/anime/producer/2045/Myrica_Music" },
                    { 2051, null, null, "https://cdn.myanimelist.net/s/common/company_logos/0ecb8205-ed91-4e7a-91d0-4223894cfd70_600x600_i?s=0f9ac8589cb029f9db255b350cca4632", "スタジオこあ", "Studio Coa", "https://myanimelist.net/anime/producer/2051/Studio_Coa" },
                    { 2052, null, null, "https://cdn.myanimelist.net/s/common/company_logos/261b4559-fa2f-4aea-81ef-4f98a29abddd_600x600_i?s=da5e072651e90367bdae1b5a6d9ad6d7", "ウルフズベイン", "Wolfsbane", "https://myanimelist.net/anime/producer/2052/Wolfsbane" },
                    { 2054, null, new DateTime(2016, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/6de4037d-86d7-4692-9b37-b2e416e43164_600x600_i?s=dc9584e107ea36726b0ccebf9e2ddc2f", "MORIE", "MORIE Inc.", "https://myanimelist.net/anime/producer/2054/MORIE_Inc" },
                    { 2071, null, new DateTime(2014, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/4570cad3-e0cb-47aa-bfc2-35cad0f68c90_600x600_i?s=d78a2b72864700e917d3807ee4ee3304", "AQUA ARIS", "AQUA ARIS", "https://myanimelist.net/anime/producer/2071/AQUA_ARIS" },
                    { 2074, null, new DateTime(2012, 5, 1, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3674f73b-e8c9-438e-9d27-6aca24c256ee_600x600_i?s=90d812d6ba7637771e5218f1aed3f7ed", "ビットグルーヴプロモーション", "Bit grooove promotion", "https://myanimelist.net/anime/producer/2074/Bit_grooove_promotion" },
                    { 2090, null, new DateTime(2016, 9, 29, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/022352f2-6ce7-4746-8652-336e58538a2d_600x600_i?s=93a2fcbf6ac691ea1becd3026d5e4ad3", "ドリームシフト", "Dream Shift", "https://myanimelist.net/anime/producer/2090/Dream_Shift" },
                    { 2097, "HORNETS (HORNETS Inc.) is a Japanese animation studio based in Koganei, Tokyo, Japan. Former SynergySP employees led by Masanobu Hatta — animation producer for Major (2008-2012) and Beast Saga — established HORNETS Inc. in December of 2013. The studio’s name was inspired by the fictional baseball team — Indiana Hornets — in Takuya Mitsuda's manga series Major.\n\nFrom December 2013 to August 2016, HORNETS had operated a photography department. The studio’s photography department was established when SynergySP transferred its photography department into HORNETS in December of 2013. In August 2016, its photography department was incorporated into a separate company from HORNETS named Tplus, Inc.", new DateTime(2013, 12, 26, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/0b1fd16f-3e33-420f-a252-5ecf62125d33_600x600_i?s=abb82965713b55b24533ddff5d7e71f4", "ホーネッツ", "HORNETS", "https://myanimelist.net/anime/producer/2097/HORNETS" },
                    { 2101, null, new DateTime(1956, 3, 18, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e98d8ee9-9777-48de-b8f4-f946fea23b0d_600x600_i?s=3288150e302eaa88d30e033fe4182737", "ADKホールディングス", "ADK", "https://myanimelist.net/anime/producer/2101/ADK" },
                    { 2102, null, new DateTime(2010, 1, 7, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9811791d-1aa5-4b91-827d-b6caebd0f6bf_600x600_i?s=b2c67f9095a8135e9091a6d77efa3098", "f4samurai", "f4samurai", "https://myanimelist.net/anime/producer/2102/f4samurai" },
                    { 2106, null, new DateTime(1987, 8, 20, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/fffeb106-f9f7-483e-8ccd-d6cc7f22d53c_600x600_i?s=1687a633598c8bf66b7ef3168f1ab786", "ソニー・ミュージックソリューションズ", "Sony Music Solutions", "https://myanimelist.net/anime/producer/2106/Sony_Music_Solutions" },
                    { 2111, null, new DateTime(1974, 12, 19, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e65aa0ce-7334-4fdd-a37f-7cdfcadafd4b_600x600_i?s=4d8c17d984dae2d4baa7797614a3d1f8", "ぴあ", "Pia", "https://myanimelist.net/anime/producer/2111/Pia" },
                    { 2117, null, new DateTime(1999, 3, 23, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8bc53a0d-fa59-4cd4-a6d4-7fa716a4a16b_600x600_i?s=80cfdcb4622f130ac5b0230acab7a0d8", "SBクリエイティブ", "SB Creative", "https://myanimelist.net/anime/producer/2117/SB_Creative" },
                    { 2118, null, null, "https://cdn.myanimelist.net/s/common/company_logos/2c0f20d3-70d5-4cb2-ad66-2f3985dda4fe_600x600_i?s=589c9050e4c1785ac95d20b02bac71d1", "ADKエモーションズ", "ADK Emotions", "https://myanimelist.net/anime/producer/2118/ADK_Emotions" },
                    { 2122, null, null, "https://cdn.myanimelist.net/s/common/company_logos/0b909e6b-814d-4e99-805b-03bef15136fc_600x600_i?s=23f47055656d05d6d9117149b558a3de", "PERIMETRON", "PERIMETRON", "https://myanimelist.net/anime/producer/2122/PERIMETRON" },
                    { 2128, null, null, "https://cdn.myanimelist.net/s/common/company_logos/214037d9-2d5a-4329-8824-f9ecd1687b94_600x600_i?s=d1bfffdd94fa84c3d6c35ea0b6c9e15c", "ファブトーン", "Fabtone", "https://myanimelist.net/anime/producer/2128/Fabtone" },
                    { 2135, null, new DateTime(1986, 10, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/dfc5075a-4e71-4bae-b054-d474c8242565_600x600_i?s=f6f2672faa701592f8794893f4fc3032", "イマジン", "Imagine", "https://myanimelist.net/anime/producer/2135/Imagine" },
                    { 2138, null, new DateTime(1995, 12, 17, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e9fa4739-020c-4309-85ec-40b11c241036_600x600_i?s=0895817d3667d67437c2ff14568e072a", "Hikari TV", "Hikari TV", "https://myanimelist.net/anime/producer/2138/Hikari_TV" },
                    { 2139, null, null, "https://cdn.myanimelist.net/s/common/company_logos/b383ce83-ed40-4c70-a15e-6fc56e6e6303_600x600_i?s=dd33a738b92d94fab6d507e02a9d4378", "DMM music", "DMM Music", "https://myanimelist.net/anime/producer/2139/DMM_Music" },
                    { 2146, null, null, "https://cdn.myanimelist.net/s/common/company_logos/e57c6616-8b04-4f56-9e08-54024fc08463_600x600_i?s=52f7be013310344d5488ed3e6ad47c8a", "ネットイース", "NetEase", "https://myanimelist.net/anime/producer/2146/NetEase" },
                    { 2147, null, new DateTime(2018, 4, 17, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/85898790-5faf-49b6-8d5b-2c3c763ed63e_600x600_i?s=1929aecb30ddc3383e44eae333f56c12", "ハートカンパニー", "Heart Company", "https://myanimelist.net/anime/producer/2147/Heart_Company" },
                    { 2149, null, new DateTime(1987, 12, 14, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "キノシタ・マネージメント", "Kinoshita Management", "https://myanimelist.net/anime/producer/2149/Kinoshita_Management" },
                    { 2152, null, new DateTime(1965, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/56f7599f-6a50-49f4-8503-4116aea65787_600x600_i?s=c6c1f5325c91482581e159f08a61a07c", "Gホールディングス", "G holdings", "https://myanimelist.net/anime/producer/2152/G_holdings" },
                    { 2159, null, null, "https://cdn.myanimelist.net/s/common/company_logos/fb6185f6-721a-4935-b183-eb47e2af0ad6_600x600_i?s=6f9319af1a5984b5357cb1d75ef65b48", "Composition", "Composition Inc.", "https://myanimelist.net/anime/producer/2159/Composition_Inc" },
                    { 2162, null, new DateTime(2009, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/5a628bf8-d9b6-4e36-9c15-510d2aca464b_600x600_i?s=16d76056b0263f45831d8c84ee937e5e", "Helixes inc./ maxilla division", "Maxilla", "https://myanimelist.net/anime/producer/2162/Maxilla" },
                    { 2167, "Hololive Production is a virtual YouTuber agency owned by Japanese tech entertainment company Cover Corporation. In addition to acting as a multi-channel network, Hololive Production also handles licensing, merchandising, music production and concert organization. As of January 2024, the agency manages 80+ VTubers in three target languages (Japanese, Indonesian, and English), totalling over 80 million subscribers, including several of the most subscribed VTubers on YouTube and some of the most watched female streamers in the world.\n\nThe name \"Hololive\" was initially used for Cover's 3D stream distribution app, launched in December 2017, and later its female VTuber agency, whose first generation debuted from May to June 2018. In December 2019, Hololive was merged with Cover's male Holostars agency and INoNaKa music label under the unified \"Hololive Production\" brand.\n\nCover Corporation was founded by Motoaki \"Yagoo\" Tanigo, an entrepreneur who had developed video game characters in collaboration with Sanrio at the content company Imagineer and founded various startup companies. Cover at first focused on augmented (AR) and virtual reality (VR) software, and received funding from incubator firms Tokyo VR Startups and Recruit.\n\nAt the end of March 2017, the company showcased a tech demo for a program enabling real-time avatar motion capture and interactive, two-way live streaming. According to Tanigo, the idea for a \"virtual idol\" agency was inspired by other virtual characters, such as Hatsune Miku. Kizuna AI, who began the virtual YouTuber trend in 2016, was another likely inspiration.\n\nCover debuted Tokino Sora, the first VTuber using the company's avatar capture software, on 7 September 2017. On 21 December, the company released hololive, a smartphone app for iOS and Android enabling users to view virtual character live streams using AR camera technology. On 5 April 2018, Cover removed the application's AR features and changed it into a tool for mapping a user's facial movements onto animated avatars in r", new DateTime(2016, 6, 12, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b4ec9c7c-8ac1-4a64-97e0-44219578e5c9_600x600_i?s=a2a29926fc9bed2d8c3e09534640cddc", "ホロライブプロダクション", "Hololive Production", "https://myanimelist.net/anime/producer/2167/Hololive_Production" },
                    { 2169, null, null, "https://cdn.myanimelist.net/s/common/company_logos/7b72df6d-2d28-42d9-b8cc-294944ca4ccf_600x600_i?s=59031e395cce7bc72a52228eec780850", null, "Studio 88", "https://myanimelist.net/anime/producer/2169/Studio_88" },
                    { 2174, null, new DateTime(1999, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/5c3b256d-133c-4783-885e-97465df8da1b_600x600_i?s=bbd017be58ee837dae7e4148b4a64861", "トムス・ミュージック", "TMS Music", "https://myanimelist.net/anime/producer/2174/TMS_Music" },
                    { 2183, null, new DateTime(1990, 7, 23, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/b7f98540-3433-4bf0-b0ec-a057143cbee4_600x600_i?s=c16cf50b576361fd3e91882277af3c7b", "ケイカ", "Keica", "https://myanimelist.net/anime/producer/2183/Keica" },
                    { 2184, null, null, "https://cdn.myanimelist.net/s/common/company_logos/24284220-380d-4e66-a7ba-636702e6116f_600x600_i?s=e2464441dd36681e2bfe17a3639ae04e", "The Monk Studios", "The Monk Studios", "https://myanimelist.net/anime/producer/2184/The_Monk_Studios" },
                    { 2185, null, new DateTime(1998, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f5bab78d-4661-414c-b76c-f8dff41ef9df_600x600_i?s=1056c4d3025403054fa32e21153f8ff3", "BS朝日", "BS Asahi", "https://myanimelist.net/anime/producer/2185/BS_Asahi" },
                    { 2195, null, null, "https://cdn.myanimelist.net/s/common/company_logos/268f643d-d22c-4574-aa7b-571b1e435dd5_600x600_i?s=b712ac0c00ad3de331b120f058a25670", "ポノス", "PONOS Corporation", "https://myanimelist.net/anime/producer/2195/PONOS_Corporation" },
                    { 2196, null, null, "https://cdn.myanimelist.net/s/common/company_logos/e497f30c-566f-4ac1-920b-f966ec8c4737_600x600_i?s=a7622c320c9bec50c924d9d2162cea59", "ドリアン", "Studio DURIAN", "https://myanimelist.net/anime/producer/2196/Studio_DURIAN" },
                    { 2201, null, new DateTime(2018, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/85aa0db9-a299-409d-8ae8-8d9ff9aa7cf6_600x600_i?s=f1cc78addbd8a502cc4bde6a4ea08699", "studioぱれっと", "Studio Palette", "https://myanimelist.net/anime/producer/2201/Studio_Palette" },
                    { 2219, null, new DateTime(1947, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f156e147-6fed-4370-861b-9e90f9c55126_600x600_i?s=baa64870dd27dd8086c09e559975b87a", "日本経済広告社", "Nihon Keizai Koukokusha", "https://myanimelist.net/anime/producer/2219/Nihon_Keizai_Koukokusha" },
                    { 2228, null, new DateTime(2016, 9, 28, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/5e5b936e-4866-4676-beeb-fce7e8ee6301_600x600_i?s=6f9c60400970aa7e01f79b2f0de0702d", "ブシロードムーブ", "Bushiroad Move", "https://myanimelist.net/anime/producer/2228/Bushiroad_Move" },
                    { 2229, null, new DateTime(1971, 8, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/e5c57de8-91c8-4943-89aa-4cd16cf35090_600x600_i?s=b1cedbf25f5913fc60ab11028d71821d", "東宝ミュージック", "Toho Music", "https://myanimelist.net/anime/producer/2229/Toho_Music" },
                    { 2234, null, new DateTime(1970, 3, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7653da99-05c4-413d-a40a-bf0db76b3a7e_600x600_i?s=9feaddccc77e4ad5e2c2fd38a9aca0d6", "テレビ朝日ミュージック", "TV Asahi Music", "https://myanimelist.net/anime/producer/2234/TV_Asahi_Music" },
                    { 2236, null, new DateTime(2013, 8, 13, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d64d389b-8ac2-4396-b539-8253eeae76ff_600x600_i?s=e3f812e1e6bba52aaed8aea58b9c6f0a", "ＣＴＷ", "CTW", "https://myanimelist.net/anime/producer/2236/CTW" },
                    { 2246, null, new DateTime(2019, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/20a2a278-83af-431d-ae96-817da43ea200_600x600_i?s=f035fdcd58c2c90b7f537f708c3fbecd", "studio MOTHER", "studio MOTHER", "https://myanimelist.net/anime/producer/2246/studio_MOTHER" },
                    { 2256, null, null, "https://cdn.myanimelist.net/s/common/company_logos/a955e0a9-061c-4bd0-b18a-2b4e7b941d9f_600x600_i?s=2792b61eb91cae72e8af177c12e0217b", null, "Kitty Film Mitaka Studio", "https://myanimelist.net/anime/producer/2256/Kitty_Film_Mitaka_Studio" },
                    { 2260, null, new DateTime(2009, 4, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/99990127-ea8e-491c-948f-8ed69e0d204f_600x600_i?s=0f8920897b7e650f192edef95b24bb6c", "サムザップ", "Sumzap", "https://myanimelist.net/anime/producer/2260/Sumzap" },
                    { 2262, null, new DateTime(2005, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/848a9a5a-613c-4f4a-8ec8-34a5f9d7b25f_600x600_i?s=0dc19040d276c1d682b5d78b02879946", "Illumitoon Entertainment", "Illumitoon Entertainment", "https://myanimelist.net/anime/producer/2262/Illumitoon_Entertainment" },
                    { 2263, null, new DateTime(2004, 8, 29, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7edff456-cdf1-4c59-850e-a45defe1528f_600x600_i?s=a1f81f923a2ca550b903af76d3180c44", "ImaginAsian Entertainment", "ImaginAsian Entertainment", "https://myanimelist.net/anime/producer/2263/ImaginAsian_Entertainment" },
                    { 2266, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "PLANET ANKAMA", "Planet Nemo Animation", "https://myanimelist.net/anime/producer/2266/Planet_Nemo_Animation" },
                    { 2268, null, new DateTime(2002, 3, 12, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/579c1b9c-a547-4b70-82b9-08ef7b6af236_600x600_i?s=ac9643cd2a38136343287978ab52dd45", "ポイント・ピクチャーズ", "Point Pictures", "https://myanimelist.net/anime/producer/2268/Point_Pictures" },
                    { 2272, null, null, "https://cdn.myanimelist.net/s/common/company_logos/f3bc1a66-708f-4e2e-b7a9-2872dfda8d1e_600x600_i?s=77b85bceb3f6cae8a213a07f61038458", "AC部", "AC-Bu", "https://myanimelist.net/anime/producer/2272/AC-Bu" },
                    { 2278, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "ハーモニーゴールド", "Harmony Gold", "https://myanimelist.net/anime/producer/2278/Harmony_Gold" },
                    { 2280, null, null, "https://cdn.myanimelist.net/s/common/company_logos/fc43a249-dbb5-43da-830f-5e8aae9e8f76_600x600_i?s=1141c2ea56cd5d263fe4b6e6b5aeaf2c", "Mill Creek Entertainment", "Mill Creek Entertainment", "https://myanimelist.net/anime/producer/2280/Mill_Creek_Entertainment" },
                    { 2288, null, new DateTime(2021, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/dc1b5945-4945-4b07-84b1-43778901de89_600x600_i?s=2dbb221a79270877413d8cc5daadd272", "Qzil.la", "Qzil.la", "https://myanimelist.net/anime/producer/2288/Qzilla" },
                    { 2289, null, new DateTime(2021, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/78d19c95-f9d7-4e5c-9b9b-2a9cae6b0f8d_600x600_i?s=eec18bbdb85ccb447d53abd8c062bbb9", "グリーエンターテインメント", "GREE Entertainment", "https://myanimelist.net/anime/producer/2289/GREE_Entertainment" },
                    { 2290, null, new DateTime(2012, 9, 26, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/f81de2cd-d5eb-42ab-ba34-f6fd6ab3ab76_600x600_i?s=dc52652edc3e97f24c7ee24e190f5458", "A3", "A3", "https://myanimelist.net/anime/producer/2290/A3" },
                    { 2292, null, new DateTime(1957, 3, 12, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/917d4f67-606d-4d39-a022-4524ecbd4dc8_600x600_i?s=3528e27f4f15dfbb62eca0489d17dea7", "東映エージエンシー", "Toei Advertising", "https://myanimelist.net/anime/producer/2292/Toei_Advertising" },
                    { 2298, null, new DateTime(2020, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/9e973474-c5e2-4c53-9eca-ff2e60252f1d_600x600_i?s=a9e0f3b3e08cae1abfaeee0c6d4d77e8", null, "AtelierPontdarc", "https://myanimelist.net/anime/producer/2298/AtelierPontdarc" },
                    { 2300, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "STUDIO JEMI", "Studio Jemi", "https://myanimelist.net/anime/producer/2300/Studio_Jemi" },
                    { 2306, null, new DateTime(2014, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/3f4dbb70-9332-4f6f-9b11-2cef876d58ac_600x600_i?s=973edabe07ca676b17cf3d561a1899e9", "ライデンフィルム京都", "LIDENFILMS Kyoto Studio", "https://myanimelist.net/anime/producer/2306/LIDENFILMS_Kyoto_Studio" },
                    { 2311, null, null, "https://cdn.myanimelist.net/s/common/company_logos/b6d54a31-ddcc-4699-8952-ceda3b62accb_600x600_i?s=a62041ceca04bdcd7c3bc6ba75bb8e7b", "魚雷映蔵", "Gyorai Eizo Inc.", "https://myanimelist.net/anime/producer/2311/Gyorai_Eizo_Inc" },
                    { 2355, null, null, "https://cdn.myanimelist.net/s/common/company_logos/632720bf-9dce-40aa-a90a-4c9716bbcc3b_600x600_i?s=b2c02f55ba31562b24b85d638bcb7279", "Alfred Imageworks", "Alfred Imageworks", "https://myanimelist.net/anime/producer/2355/Alfred_Imageworks" },
                    { 2369, null, new DateTime(1905, 6, 10, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/97442cd6-72eb-4500-b7bf-c67dbe09e0d6_600x600_i?s=0cda4983e1820ca0471b1254991cf378", "IRMA records", "IRMA LA DOUCE", "https://myanimelist.net/anime/producer/2369/IRMA_LA_DOUCE" },
                    { 2370, null, new DateTime(2021, 12, 15, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "ハヤブサフィルム", "Hayabusa Film", "https://myanimelist.net/anime/producer/2370/Hayabusa_Film" },
                    { 2401, null, null, "https://cdn.myanimelist.net/s/common/company_logos/c16b30fb-0d70-4586-97a6-892117699d8c_600x600_i?s=b260b2c3195b2c9ea33ebd781529cd18", null, "YURUPPE Inc.", "https://myanimelist.net/anime/producer/2401/YURUPPE_Inc" },
                    { 2405, null, new DateTime(2020, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/bc83f99d-00f9-4883-afca-4ece89e8e0bb_600x600_i?s=fc6bf2f98fa082cba78b254db6f1fc21", "ステイプルエンタテインメント", "Staple Entertainment", "https://myanimelist.net/anime/producer/2405/Staple_Entertainment" },
                    { 2406, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Eallin", "https://myanimelist.net/anime/producer/2406/Eallin" },
                    { 2411, null, null, "https://cdn.myanimelist.net/s/common/company_logos/89980345-5666-40b2-879b-741f086fae9a_600x600_i?s=9d8d6521b2cfbfb0eb9502becaa812d3", null, "Studio Massket", "https://myanimelist.net/anime/producer/2411/Studio_Massket" },
                    { 2419, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "d00r works", "https://myanimelist.net/anime/producer/2419/d00r_works" },
                    { 2424, null, new DateTime(2022, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/502e09d8-a8e8-4b86-95e3-8cd6ed05efce_600x600_i?s=3e346a1ac513fdf6feba25dd01381b5a", "バンダイナムコフィルムワークス", "Bandai Namco Filmworks", "https://myanimelist.net/anime/producer/2424/Bandai_Namco_Filmworks" },
                    { 2425, null, null, "https://cdn.myanimelist.net/s/common/company_logos/32d2197c-8beb-4b72-99e7-2d76bdc1da94_600x600_i?s=3a44e4d6ca594eaeb190ae5dedf05eb9", "バンダイナムコミュージックライブ", "Bandai Namco Music Live", "https://myanimelist.net/anime/producer/2425/Bandai_Namco_Music_Live" },
                    { 2431, null, new DateTime(2021, 1, 19, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/af14a946-a4ed-4161-bde7-a46f24fb77c9_600x600_i?s=df222a5e93836c8a371c4d90e06e0dd0", "ハピネットファントム・スタジオ", "Happinet Phantom Studios", "https://myanimelist.net/anime/producer/2431/Happinet_Phantom_Studios" },
                    { 2435, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Aiming", "https://myanimelist.net/anime/producer/2435/Aiming" },
                    { 2436, "Frontier One (Frontier One Co., Ltd.) is a Japanese animation studio based in Nerima, Tokyo, Japan, and headquartered in Taito, Tokyo, Japan. Following the disbandment of Anime International Company's animation production department in August 2015, former AIC Frontier producer — Taizo Ohara — established Frontier One Co., Ltd. in August of the following year. As of 2023, the studio's clients include BLADE, DMM.com, GENCO, KADOKAWA CORPORATION, TROYCA, and Yuzu Soft.\n\nIn addition to Frontier One's main animation production business, include its merchandise production/OEM business, collaboration café business, and event business.", new DateTime(2016, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "フロンティアワン", "Frontier One", "https://myanimelist.net/anime/producer/2436/Frontier_One" },
                    { 2437, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Infinity Vision", "https://myanimelist.net/anime/producer/2437/Infinity_Vision" },
                    { 2440, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "マイクロハウス", "Micro House", "https://myanimelist.net/anime/producer/2440/Micro_House" },
                    { 2441, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Bergamo", "https://myanimelist.net/anime/producer/2441/Bergamo" },
                    { 2456, null, null, "https://cdn.myanimelist.net/s/common/company_logos/54cde562-d2b4-4783-9585-3b8489b9dfd9_600x600_i?s=48f5bceca24048788dabdd31a28dfd22", "teamヤマヒツヂ", "team Yamahitsuji", "https://myanimelist.net/anime/producer/2456/team_Yamahitsuji" },
                    { 2474, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Haneda xR Studio", "https://myanimelist.net/anime/producer/2474/Haneda_xR_Studio" },
                    { 2495, "Subsidiary studio under animation company TMS Entertainment; now renamed as Die4Studio\n\nCan be regarded as \"TMS 第4スタジオ\"\n\n(Source: Bangumi)", null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "8PAN", "https://myanimelist.net/anime/producer/2495/8PAN" },
                    { 2512, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "スタジオイースター", "Studio Easter", "https://myanimelist.net/anime/producer/2512/Studio_Easter" },
                    { 2518, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Streamline Pictures", "https://myanimelist.net/anime/producer/2518/Streamline_Pictures" },
                    { 2537, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "USAGI Production", "https://myanimelist.net/anime/producer/2537/USAGI_Production" },
                    { 2539, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "INoNaKa Music", "https://myanimelist.net/anime/producer/2539/INoNaKa_Music" },
                    { 2545, null, new DateTime(1951, 6, 25, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "京都放送", "Kyoto Broadcasting System", "https://myanimelist.net/anime/producer/2545/Kyoto_Broadcasting_System" },
                    { 2548, null, new DateTime(2016, 4, 4, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d8f6e8b0-0fd3-445e-b33b-292ec9380cc2_600x600_i?s=48e0ea7956423eed703ed431758f50c3", "ABCフロンティア", "ABC Frontier", "https://myanimelist.net/anime/producer/2548/ABC_Frontier" },
                    { 2549, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "StudioXD", "https://myanimelist.net/anime/producer/2549/StudioXD" },
                    { 2561, null, new DateTime(2018, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/af374779-fd7c-48e6-b79a-69007e829092_600x600_i?s=f0f93abf97919a9d242e221a7cb55e6b", "OTOIRO", "OTOIRO", "https://myanimelist.net/anime/producer/2561/OTOIRO" },
                    { 2570, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Ijigen Tokyo", "https://myanimelist.net/anime/producer/2570/Ijigen_Tokyo" },
                    { 2592, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "AlphaPolis", "https://myanimelist.net/anime/producer/2592/AlphaPolis" },
                    { 2605, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Tonari Animation", "https://myanimelist.net/anime/producer/2605/Tonari_Animation" },
                    { 2624, null, null, "https://cdn.myanimelist.net/s/common/company_logos/bbdf5913-e91b-4aff-8e5b-3979b27c85c7_600x600_i?s=9a8ec0b74628ac581fe961a584077050", null, "Village Studio", "https://myanimelist.net/anime/producer/2624/Village_Studio" },
                    { 2634, null, new DateTime(2017, 1, 15, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/5bdc00d3-16a7-4251-88b0-24fe280bccbd_600x600_i?s=4b1562540c7a3df66ea9419de2e03808", "ヨースター", "Yostar", "https://myanimelist.net/anime/producer/2634/Yostar" },
                    { 2640, "INSPION Edge works in the following areas: music production, sound design, sound direction, sound production among other related fields.", new DateTime(2018, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "INSPIONエッジ", "INSPION Edge", "https://myanimelist.net/anime/producer/2640/INSPION_Edge" },
                    { 2642, "E&amp;H Production is an animation planning and production company established by director Sunghoo Park.", new DateTime(2021, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/083ce96c-ac4b-4a82-86a6-9cbab41b832b_600x600_i?s=63e2891b5abd02c446ed996404192377", null, "E&H Production", "https://myanimelist.net/anime/producer/2642/E_H_Production" },
                    { 2653, "In 2015 Sega Corporation was renamed Sega Games Co., Ltd., and its arcade, entertainment and toy divisions separated into other companies. In 2020, Sega Games and Sega Interactive merged and were renamed Sega Corporation.", new DateTime(2015, 1, 3, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/dc8a566c-cc60-41e5-b7f1-89728d0e408b_600x600_i?s=aaa193f8136cb3717b70b472b63f7a5a", "セガゲームス", "Sega Games", "https://myanimelist.net/anime/producer/2653/Sega_Games" },
                    { 2657, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "NANON CREATIVE", "https://myanimelist.net/anime/producer/2657/NANON_CREATIVE" },
                    { 2670, null, new DateTime(2007, 2, 4, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "ギークピクチュアズ", "Geek Pictures", "https://myanimelist.net/anime/producer/2670/Geek_Pictures" },
                    { 2671, null, new DateTime(2017, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "セイバーリンクス", "Saber Links", "https://myanimelist.net/anime/producer/2671/Saber_Links" },
                    { 2684, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "チョコレイト", "CHOCOLATE", "https://myanimelist.net/anime/producer/2684/CHOCOLATE" },
                    { 2687, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Forces11", "https://myanimelist.net/anime/producer/2687/Forces11" },
                    { 2695, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "SIGNIF", "https://myanimelist.net/anime/producer/2695/SIGNIF" },
                    { 2696, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "100studio", "https://myanimelist.net/anime/producer/2696/100studio" },
                    { 2705, null, new DateTime(2022, 9, 16, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/d951115c-6e20-47fb-adeb-20c0318fdc49_600x600_i?s=93cf138891ede64a3016c2ccdc63452d", null, "TOHO animation STUDIO", "https://myanimelist.net/anime/producer/2705/TOHO_animation_STUDIO" },
                    { 2760, "Studio add is a small animation production studio that was established in 1992 and turned corporate in 1999. Its office resides in Sakado, Saitama, Japan.\n\nIt was founded by Katou Shigeru, who serves currently as the representative director. \n\n(Source: AniDB)", null, "https://cdn.myanimelist.net/s/common/company_logos/d0dcb4a0-b4bc-444b-b935-d55057fc98d6_600x600_i?s=b47e1f91ed93452076b5d09623be438a", "スタジオアド", "Studio Add", "https://myanimelist.net/anime/producer/2760/Studio_Add" },
                    { 2792, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "INTERFACEDOGS", "https://myanimelist.net/anime/producer/2792/INTERFACEDOGS" },
                    { 2794, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "BUDDHA INC.", "https://myanimelist.net/anime/producer/2794/BUDDHA_INC" },
                    { 2800, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "ANLA", "https://myanimelist.net/anime/producer/2800/ANLA" },
                    { 2812, "Zuiyo is a Japanese animation studio that was founded by Shigeto Takahashi on April 12, 1969 and headquartered in Tokyo.", new DateTime(1969, 4, 11, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "瑞鷹株式会社", "Zuiyo", "https://myanimelist.net/anime/producer/2812/Zuiyo" },
                    { 2821, "Fugaku is an animation/music/event planning and production company.", new DateTime(2019, 10, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/7230a2b8-9d7a-4f2a-a000-6611c9193484_600x600_i?s=abce2237557379f32deae70619e36e6d", "冨嶽", "Fugaku", "https://myanimelist.net/anime/producer/2821/Fugaku" },
                    { 2824, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Production HASU", "https://myanimelist.net/anime/producer/2824/Production_HASU" },
                    { 2830, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Artner", "https://myanimelist.net/anime/producer/2830/Artner" },
                    { 2831, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "uzupiyo Animation & Digital Works", "https://myanimelist.net/anime/producer/2831/uzupiyo_Animation___Digital_Works" },
                    { 2832, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "VROOOOM", "https://myanimelist.net/anime/producer/2832/VROOOOM" },
                    { 2837, "Netmarble is a South Korean mobile game developer.", new DateTime(2000, 2, 29, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ded35de8-f543-40bb-8628-ed15d326141b_600x600_i?s=6dc99db964e612801ea6e194182eeb23", "ネットマーブル", "Netmarble", "https://myanimelist.net/anime/producer/2837/Netmarble" },
                    { 2839, null, new DateTime(2011, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/a8265060-8f89-4da3-ae89-5b74e4d312a3_600x600_i?s=7bb8bc30ad7b4492debaa81526c25d1b", "カカオピッコマ", "Kakao piccoma", "https://myanimelist.net/anime/producer/2839/Kakao_piccoma" },
                    { 2841, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "マル画ファクトリー", "Maruga Factory", "https://myanimelist.net/anime/producer/2841/Maruga_Factory" },
                    { 2844, null, new DateTime(2023, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/858ebc1e-3645-4a0f-b8f9-386dbcef749d_600x600_i?s=41d99bf12e5208c83957f68d4ded375a", "イマジカインフォス", "Imagica Infos", "https://myanimelist.net/anime/producer/2844/Imagica_Infos" },
                    { 2845, "Dimps Corporation is a Japanese video game developer based in Osaka, Japan, with an additional office in Tokyo. It is best known for developing games in the Sonic the Hedgehog, Dragon Ball and Street Fighter franchises. The company was founded on March 6, 2000 by several former SNK and Capcom employees, including Street Fighter, Fatal Fury, Art of Fighting and The King of Fighters co-creator Takashi Nishiyama and Hiroshi Matsumoto.\n\n(Source: Wikipedia)", new DateTime(2000, 3, 5, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/78b6fad8-59ea-42e3-bacb-f55e4e1311ba_600x600_i?s=e14825350905288069b3ff4ca9be25ba", "株式会社ディンプス", "Dimps", "https://myanimelist.net/anime/producer/2845/Dimps" },
                    { 2867, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "UNLIMITED PRODUCE by TMS", "Unlimited Produce by TMS", "https://myanimelist.net/anime/producer/2867/Unlimited_Produce_by_TMS" },
                    { 2868, null, new DateTime(1987, 10, 19, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "ナツメアタリ", "Natsume Atari", "https://myanimelist.net/anime/producer/2868/Natsume_Atari" },
                    { 2869, null, new DateTime(2014, 1, 5, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "かぴばら", "Capibara", "https://myanimelist.net/anime/producer/2869/Capibara" },
                    { 2872, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "D&C Media", "https://myanimelist.net/anime/producer/2872/D_C_Media" },
                    { 2874, null, new DateTime(1988, 8, 23, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "テレビ北海道", "Television Hokkaido Broadcasting", "https://myanimelist.net/anime/producer/2874/Television_Hokkaido_Broadcasting" },
                    { 2876, "Line Digital Frontier is an operator of digital comic service located in Shinjuku, Tokyo. It was established by LINE and Naver Webtoon.", new DateTime(2018, 7, 1, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", null, "Line Digital Frontier", "https://myanimelist.net/anime/producer/2876/Line_Digital_Frontier" },
                    { 2878, null, new DateTime(2016, 2, 29, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "Khaki", "Khaki", "https://myanimelist.net/anime/producer/2878/Khaki" },
                    { 2907, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "スタジオプラセボ", "Studio Placebo", "https://myanimelist.net/anime/producer/2907/Studio_Placebo" },
                    { 2909, null, new DateTime(2014, 6, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/8c497751-9767-49d1-a81a-0a1d02394b1d_600x600_i?s=fd2388be2a85bfa8af82f65b06dfb86a", "テディー", "Teddy", "https://myanimelist.net/anime/producer/2909/Teddy" },
                    { 2912, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "スリーエススタジオ", "Three S Studio", "https://myanimelist.net/anime/producer/2912/Three_S_Studio" },
                    { 2920, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", null, "One Cushion", "https://myanimelist.net/anime/producer/2920/One_Cushion" },
                    { 2927, null, new DateTime(2006, 3, 9, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", null, "DAXEL", "https://myanimelist.net/anime/producer/2927/DAXEL" },
                    { 2951, "Pierrot Films is a sub-studio established by Studio Pierrot.", new DateTime(2024, 1, 31, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/eefeee74-86b6-4094-9a77-60809b979344_600x600_i?s=fed7c2e01c545e96feb36392361bc2d8", "PIERROT FILMS", "Pierrot Films", "https://myanimelist.net/anime/producer/2951/Pierrot_Films" },
                    { 2956, null, new DateTime(2003, 9, 30, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "ジェネオンエンタテインメント", "Geneon Entertainment", "https://myanimelist.net/anime/producer/2956/Geneon_Entertainment" },
                    { 2962, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "東映アカデミー", "Toei Academy", "https://myanimelist.net/anime/producer/2962/Toei_Academy" },
                    { 2975, null, new DateTime(2001, 6, 26, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "ドリーミュージック", "Dreamusic", "https://myanimelist.net/anime/producer/2975/Dreamusic" },
                    { 2976, null, new DateTime(1963, 11, 7, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "JR東海エージェンシー", "JR Tokai Agency", "https://myanimelist.net/anime/producer/2976/JR_Tokai_Agency" },
                    { 2980, null, new DateTime(2008, 6, 15, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "スタジオパブロ", "Studio Pablo", "https://myanimelist.net/anime/producer/2980/Studio_Pablo" },
                    { 2981, null, new DateTime(1963, 7, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "オムニバスプロモーション", "Omnibus Promotion", "https://myanimelist.net/anime/producer/2981/Omnibus_Promotion" },
                    { 3001, "Remow Co., Ltd. is a joint-venture formed by Japanese companies and licensors like TV Tokyo, Toei, Shueshia, MBS Media Holdings among others", null, "https://cdn.myanimelist.net/images/company_no_picture.png", "REMOW", "REMOW Co., Ltd.", "https://myanimelist.net/anime/producer/3001/REMOW_Co_Ltd" },
                    { 3002, null, new DateTime(2006, 10, 23, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "株式会社キュービック", "CUEBiC Inc.", "https://myanimelist.net/anime/producer/3002/CUEBiC_Inc" },
                    { 3009, null, null, "https://cdn.myanimelist.net/s/common/company_logos/04f93736-2de5-407c-8dc1-34d8a8903630_600x600_i?s=44b06f7c2b689901597643e92c2f25d8", null, "Kitchen Ltd.", "https://myanimelist.net/anime/producer/3009/Kitchen_Ltd" },
                    { 3010, null, new DateTime(2016, 5, 5, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/s/common/company_logos/ccff309a-ee05-43e9-b728-640cf549989b_600x600_i?s=967e8984ec853d0792188917db79dce6", "株式会社ドットエムピー", ".MP", "https://myanimelist.net/anime/producer/3010/MP" },
                    { 3017, null, null, "https://cdn.myanimelist.net/images/company_no_picture.png", "ポリドール・レコード", "Polydor Records", "https://myanimelist.net/anime/producer/3017/Polydor_Records" },
                    { 3018, null, new DateTime(1951, 6, 28, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "RKB毎日放送", "RKB Mainichi Broadcasting Corporation", "https://myanimelist.net/anime/producer/3018/RKB_Mainichi_Broadcasting_Corporation" },
                    { 3020, null, new DateTime(2024, 3, 31, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "スカパー・ピクチャーズ", "SKY Perfect Pictures", "https://myanimelist.net/anime/producer/3020/SKY_Perfect_Pictures" },
                    { 3024, null, new DateTime(2004, 5, 6, 17, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "フォニシア", "Fonishia", "https://myanimelist.net/anime/producer/3024/Fonishia" },
                    { 3031, null, new DateTime(2020, 11, 30, 16, 0, 0, 0, DateTimeKind.Local), "https://cdn.myanimelist.net/images/company_no_picture.png", "KASSEN", "Kassen", "https://myanimelist.net/anime/producer/3031/Kassen" }
                });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Original" },
                    { 2, "Manga" },
                    { 3, "Light novel" },
                    { 4, "Game" },
                    { 5, "Web manga" },
                    { 6, "Other" },
                    { 7, "Novel" },
                    { 8, "Unknown" },
                    { 9, "Book" },
                    { 10, "4-koma manga" },
                    { 11, "Mixed media" },
                    { 12, "Music" },
                    { 13, "Visual novel" },
                    { 14, "Card game" },
                    { 15, "Radio" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnimeTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnimeTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AnimeTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AnimeTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AnimeTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AnimeTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AnimeTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AnimeTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AnimeTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("38ac6343-c319-40fc-a62b-fd4c5948f1c6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("44cc80e4-84e1-437a-b943-90730089868a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f1b58bac-8ebe-4db5-a9ed-656326479f62"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1932);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1938);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1944);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1952);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1995);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1999);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2141);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2155);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2168);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2180);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2196);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2197);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2198);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2204);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2213);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2220);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2229);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2233);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2249);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2256);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2308);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2312);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2330);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2331);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2337);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2338);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2339);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2340);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2348);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2357);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2367);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2368);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2373);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2374);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2377);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2385);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2395);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2400);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2405);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2408);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2410);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2415);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2464);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2472);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2478);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2479);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2486);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2493);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2494);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2496);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2522);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2527);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2545);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2564);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2580);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2587);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2593);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2595);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2609);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2611);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2619);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2623);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2650);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2660);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2665);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2666);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2681);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2708);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2709);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2710);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2713);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2731);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2752);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2765);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2785);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2794);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2804);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2805);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2844);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2866);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2872);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2891);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2904);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2906);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2907);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2910);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2912);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2917);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2921);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2933);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2936);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2940);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2941);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2948);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2949);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2950);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2954);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2955);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2979);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2985);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2992);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2994);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3003);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3014);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3020);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3034);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3046);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3050);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3071);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3072);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3073);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3074);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3081);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3084);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3098);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3118);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3132);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3152);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3158);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3161);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3179);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3184);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3212);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3213);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3249);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3251);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3263);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3267);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3328);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3344);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3494);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3506);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3507);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3537);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3543);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3565);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3571);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3633);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3640);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3653);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3659);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3668);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3683);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3687);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3691);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3695);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3703);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3710);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3724);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3738);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3753);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3768);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3776);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3878);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3884);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3907);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3927);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3929);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3930);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3931);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3932);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3943);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4017);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4027);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4098);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4110);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4113);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4142);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4169);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4197);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4224);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4237);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4285);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4340);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4366);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4435);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4452);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4463);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4472);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4484);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4500);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4502);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4522);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4526);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4529);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4556);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4587);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4589);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4608);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4661);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4719);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4766);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4801);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4809);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4853);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4882);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4888);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4931);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4994);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5006);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5015);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5024);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5059);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5082);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5158);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5163);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5199);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5210);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5241);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5254);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5264);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5345);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5348);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5370);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5374);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5392);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5417);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5423);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5478);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5480);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5505);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5559);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5587);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5596);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5643);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5676);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5702);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5715);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5724);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5779);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5945);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6076);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6077);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6151);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6203);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6321);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6328);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6381);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6386);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6417);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6443);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6490);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6503);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6565);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6578);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6604);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6606);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6632);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6642);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6659);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6666);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6749);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6773);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6795);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6854);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6858);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6903);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6929);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6943);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7034);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7124);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7189);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7360);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7375);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7394);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7447);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7567);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7605);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7613);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7622);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7629);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7634);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7650);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7651);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7653);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7706);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7721);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7726);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7729);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7880);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7937);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7973);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7998);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8052);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8161);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8208);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8260);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8262);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8295);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8313);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8321);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8346);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8420);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8559);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8576);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8594);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8611);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8690);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8719);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8738);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8749);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8836);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8908);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8910);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9000);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9030);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9057);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9064);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9067);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9143);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9177);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9198);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9348);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9496);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9515);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9542);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9563);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9602);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9604);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9616);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9655);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9672);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9685);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9737);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9744);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9834);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9848);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9963);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10052);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10153);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10269);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10308);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10310);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10320);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10350);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10351);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10353);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10426);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10512);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10523);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10687);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10695);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10742);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10809);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10812);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10817);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10850);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10875);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10900);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10907);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10915);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10951);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11001);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11023);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11068);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11085);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11089);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11112);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11123);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11163);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11232);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11257);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11272);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11273);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11294);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11323);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11339);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11371);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11423);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11439);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11466);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11470);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11512);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11619);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11687);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11709);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11775);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11831);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11856);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11857);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11939);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11962);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12006);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12032);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12050);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12084);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12131);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12153);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12250);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12253);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12338);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12368);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12410);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12411);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12433);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12482);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12513);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12529);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12592);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12623);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12672);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12773);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12837);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12959);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13031);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13087);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13095);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13131);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13137);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13139);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13163);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13173);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13251);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13289);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13369);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13371);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13427);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13477);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13521);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13523);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13689);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13691);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13731);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13783);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13799);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13805);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13811);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13833);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14013);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14153);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14233);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14271);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14297);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14339);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14347);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14361);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14717);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14799);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15063);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15169);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15227);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15279);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15293);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15333);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15419);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15487);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15505);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15517);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15523);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15591);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15613);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15753);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15763);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15803);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15991);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16255);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16265);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16363);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16435);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16485);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16529);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16569);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16573);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16667);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16805);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16859);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16993);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17031);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17061);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17271);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17289);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17335);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17519);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17555);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17575);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17601);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17647);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17651);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17769);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17827);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17857);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17871);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17885);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17891);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17893);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17923);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17933);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17945);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18099);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18115);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18169);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18193);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18215);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18223);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18237);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18249);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18255);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18277);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18351);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18357);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18409);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18411);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18435);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18553);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18569);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18629);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18635);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18681);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18693);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18697);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18699);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18705);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18707);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18709);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18713);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18715);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18731);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18745);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18757);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18791);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18801);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18817);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18821);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19049);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19051);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19053);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19189);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19197);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19271);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19277);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19349);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19431);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19443);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19497);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19501);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19507);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19523);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19551);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19649);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19695);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19699);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19719);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19721);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19755);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19791);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19864);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19926);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20150);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20152);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20176);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20182);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20186);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20611);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20649);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20727);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20777);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20863);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20893);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21095);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21131);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21273);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21323);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21509);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21681);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21731);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21763);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21791);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21829);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21995);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22125);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22165);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22167);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22171);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22191);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22207);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22227);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22231);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22235);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22237);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22261);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22323);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22431);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22471);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22495);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22575);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22603);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22605);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22631);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22681);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22695);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22697);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22709);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22733);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22737);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22865);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22889);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23109);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23155);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23279);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23289);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23349);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23443);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23473);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23505);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23621);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23699);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23771);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23829);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23955);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24067);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24201);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24221);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24291);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24327);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24365);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24371);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24379);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24385);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24471);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24493);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24539);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24569);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24891);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24923);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25009);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25091);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25135);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25221);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25239);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25251);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25281);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25391);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25491);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25685);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25883);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25887);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25969);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25997);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26031);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26099);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26171);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26179);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26291);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26303);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26407);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26679);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26799);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26893);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27011);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27093);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27167);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27209);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27235);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27517);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27561);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27721);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27741);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27935);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28017);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28223);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28371);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28403);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28661);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28771);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28883);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28977);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29133);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29149);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29289);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29309);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29371);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29403);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29405);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29455);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29487);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29509);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29539);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29559);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29603);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29745);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30507);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30543);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30661);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30673);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30675);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30677);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30779);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30811);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30849);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30983);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30985);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30987);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30989);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30995);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31063);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31087);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31159);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31211);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31245);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31467);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31685);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31719);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31893);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31895);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31927);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31965);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32095);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32119);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32185);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32265);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32463);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32649);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32651);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32699);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32759);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32813);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32817);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32913);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32915);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32917);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33011);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33059);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33097);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33167);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33219);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33535);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33771);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33833);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33843);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34167);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34229);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34287);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34631);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34715);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34719);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34747);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34803);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34965);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35011);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35017);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35063);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35135);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35569);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35701);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35715);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35955);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35997);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36257);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36299);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36303);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36415);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36599);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36661);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36686);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36692);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36700);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36715);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36733);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36857);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36869);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37002);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37114);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37135);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37300);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37316);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37335);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37430);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37509);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37521);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37563);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37564);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37633);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37758);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37790);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37791);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37794);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37817);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37823);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37834);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37840);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37841);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37843);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37853);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37854);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37880);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37902);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38131);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38132);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38145);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38202);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38206);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38222);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38271);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38278);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38364);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38443);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38445);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38459);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38481);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38573);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38574);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38575);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38598);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38610);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38777);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38981);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38982);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39207);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39224);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39266);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39275);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39300);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39385);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39496);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39499);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39511);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39599);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39706);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39719);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39752);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39760);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39884);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39921);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39940);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40025);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40141);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40179);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40217);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40218);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40306);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40314);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40398);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40550);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40594);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40818);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41133);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41158);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41189);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41198);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41240);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41241);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41275);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41278);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41453);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41537);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41590);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41596);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41662);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41727);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41770);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41789);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41803);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41813);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41916);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42031);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42068);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42145);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42170);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42337);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42420);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43150);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43163);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43212);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43216);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43264);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43285);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43396);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43397);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43522);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43690);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43726);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43727);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44119);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44353);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44412);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44442);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44457);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44501);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44615);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44623);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44689);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44835);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44895);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44910);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45171);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45437);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45451);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45507);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45593);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45713);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46082);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46132);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46196);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46230);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46244);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46444);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46458);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46641);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46700);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46792);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46835);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46888);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46945);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46982);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47072);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47150);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47160);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47205);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47228);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47268);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47275);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47297);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47372);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47379);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47494);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47572);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47691);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47848);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47924);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48092);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48119);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48133);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48165);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48195);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48250);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48641);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48846);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48851);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48856);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48970);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49044);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49101);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49103);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49111);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49152);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49173);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49316);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49502);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49504);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49538);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49588);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49592);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49645);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49667);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49668);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49731);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49768);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49771);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49794);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49797);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49798);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49881);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49882);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49897);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49934);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49943);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49959);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50160);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50208);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50306);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50327);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50382);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50439);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50484);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50576);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50587);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50623);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50675);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50851);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50922);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50996);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51072);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51098);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51099);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51146);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51216);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51264);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51303);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51304);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51494);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51496);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51645);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51657);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51720);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51756);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51880);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51985);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52026);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52028);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52099);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52126);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52160);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52174);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52294);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52385);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52401);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52653);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52661);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52663);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52708);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52773);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53122);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53287);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53332);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53460);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53461);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53495);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53653);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53666);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53691);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53716);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53970);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53974);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54004);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54053);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54091);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54184);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54512);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54645);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54697);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54822);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54860);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54967);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54998);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55102);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55132);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55206);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55224);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55291);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55459);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55529);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55530);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55732);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 56017);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 56152);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 56183);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 56226);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 56389);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 56741);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 57013);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 57058);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 57952);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 58144);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 58414);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 58619);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 60477);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 60478);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61353);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61354);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61409);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61555);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61653);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61726);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61728);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61753);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 62196);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 62513);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 62688);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 62741);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 62963);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 63820);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 65405);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 67066);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 67668);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 67703);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 68369);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 69085);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 69420);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 69552);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 69553);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 70353);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 71149);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 71361);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 71563);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 71627);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 73731);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 76140);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 76549);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 76585);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 76909);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 77248);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 77660);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "GenresForAnimes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "GenresForMangas",
                keyColumn: "Id",
                keyValue: 83);

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

            migrationBuilder.DeleteData(
                table: "MangaTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MangaTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MangaTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MangaTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MangaTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MangaTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1916);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1918);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1934);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1972);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1976);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1977);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1978);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1982);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1984);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1986);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1988);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1996);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2146);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2147);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2149);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2152);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2159);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2162);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2167);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2169);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2174);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2183);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2184);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2185);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2195);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2196);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2201);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2219);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2228);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2229);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2234);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2236);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2246);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2256);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2260);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2262);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2263);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2266);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2268);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2272);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2278);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2280);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2288);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2289);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2290);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2292);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2298);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2300);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2306);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2311);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2355);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2369);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2370);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2401);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2405);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2406);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2411);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2419);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2424);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2425);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2431);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2435);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2436);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2437);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2440);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2441);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2456);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2474);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2495);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2512);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2518);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2537);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2539);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2545);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2548);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2549);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2561);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2570);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2592);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2605);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2624);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2634);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2640);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2642);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2653);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2657);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2670);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2671);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2684);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2687);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2695);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2696);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2705);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2760);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2792);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2794);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2800);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2812);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2821);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2824);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2830);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2831);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2832);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2837);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2839);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2841);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2844);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2845);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2867);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2868);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2869);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2872);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2874);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2876);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2878);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2907);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2909);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2912);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2920);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2927);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2951);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2956);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2962);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2975);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2976);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2980);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2981);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3001);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3002);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3009);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3010);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3017);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3018);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3020);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3024);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3031);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
