using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeDbWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AuthorsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
