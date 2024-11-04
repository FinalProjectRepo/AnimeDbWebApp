using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeDbWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProducersSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
