using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimeDbWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class MangaRelationSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MangasRelations",
                columns: new[] { "MangaId", "RelationId", "RelationType" },
                values: new object[,]
                {
                    { 1, 10968, "Side Story" },
                    { 2, 92299, "Other" },
                    { 2, 106677, "Spin-Off" },
                    { 3, 743, "Sequel" },
                    { 3, 15691, "Spin-Off" },
                    { 3, 90757, "Side Story" },
                    { 4, 165348, "Spin-Off" },
                    { 9, 10, "Other" },
                    { 9, 14368, "Spin-Off" },
                    { 9, 74339, "Sequel" },
                    { 10, 9, "Other" },
                    { 10, 10183, "Side Story" },
                    { 10, 14368, "Spin-Off" },
                    { 10, 16010, "Other" },
                    { 10, 32037, "Other" },
                    { 10, 46010, "Sequel" },
                    { 11, 6028, "Alternative Version" },
                    { 11, 6444, "Alternative Version" },
                    { 11, 11926, "Character" },
                    { 11, 23208, "Spin-Off" },
                    { 11, 40225, "Side Story" },
                    { 11, 40549, "Side Story" },
                    { 11, 57095, "Side Story" },
                    { 11, 77273, "Spin-Off" },
                    { 11, 83257, "Side Story" },
                    { 11, 86129, "Side Story" },
                    { 11, 87714, "Side Story" },
                    { 11, 87866, "Side Story" },
                    { 11, 90531, "Side Story" },
                    { 11, 92286, "Side Story" },
                    { 11, 95210, "Sequel" },
                    { 11, 96200, "Side Story" },
                    { 11, 96762, "Side Story" },
                    { 11, 96763, "Side Story" },
                    { 11, 96764, "Side Story" },
                    { 11, 96765, "Side Story" },
                    { 11, 96766, "Side Story" },
                    { 11, 96767, "Side Story" },
                    { 11, 96768, "Side Story" },
                    { 11, 96769, "Side Story" },
                    { 11, 96770, "Side Story" },
                    { 11, 98462, "Side Story" },
                    { 11, 115792, "Side Story" },
                    { 11, 119908, "Side Story" },
                    { 11, 160710, "Side Story" },
                    { 12, 11330, "Alternative Version" },
                    { 12, 22744, "Alternative Version" },
                    { 12, 23355, "Side Story" },
                    { 12, 26133, "Side Story" },
                    { 12, 30541, "Spin-Off" },
                    { 12, 43605, "Side Story" },
                    { 12, 43607, "Side Story" },
                    { 12, 103000, "Side Story" },
                    { 12, 105125, "Side Story" },
                    { 12, 106602, "Side Story" },
                    { 12, 116905, "Side Story" },
                    { 12, 124937, "Side Story" },
                    { 12, 139152, "Sequel" },
                    { 13, 793, "Other" },
                    { 13, 881, "Other" },
                    { 13, 5114, "Alternative Version" },
                    { 13, 14414, "Side Story" },
                    { 13, 17152, "Side Story" },
                    { 13, 23251, "Spin-Off" },
                    { 13, 25146, "Other" },
                    { 13, 52353, "Spin-Off" },
                    { 13, 86972, "Spin-Off" },
                    { 13, 94533, "Side Story" },
                    { 13, 94534, "Side Story" },
                    { 13, 110830, "Side Story" },
                    { 13, 114760, "Side Story" },
                    { 13, 115627, "Other" },
                    { 13, 120401, "Other" },
                    { 13, 120656, "Side Story" },
                    { 13, 122305, "Spin-Off" },
                    { 13, 127114, "Spin-Off" },
                    { 13, 128594, "Other" },
                    { 13, 139972, "Other" },
                    { 13, 141501, "Spin-Off" },
                    { 13, 141511, "Spin-Off" },
                    { 13, 142771, "Spin-Off" },
                    { 13, 142772, "Spin-Off" },
                    { 13, 150042, "Other" },
                    { 13, 152411, "Spin-Off" },
                    { 13, 172694, "Other" },
                    { 14, 15918, "Spin-Off" },
                    { 14, 15921, "Other" },
                    { 14, 108461, "Other" },
                    { 14, 122473, "Other" },
                    { 15, 597, "Alternative Version" },
                    { 15, 21907, "Alternative Setting" },
                    { 15, 35609, "Side Story" },
                    { 15, 57765, "Sequel" },
                    { 16, 5931, "Side Story" },
                    { 16, 21883, "Side Story" },
                    { 16, 78905, "Spin-Off" },
                    { 18, 2957, "Spin-Off" },
                    { 18, 31521, "Other" },
                    { 19, 64849, "Side Story" },
                    { 21, 3645, "Other" },
                    { 21, 7458, "Prequel" },
                    { 21, 8158, "Side Story" },
                    { 21, 70815, "Side Story" },
                    { 21, 102569, "Sequel" },
                    { 21, 132335, "Other" },
                    { 22, 2333, "Sequel" },
                    { 22, 4795, "Side Story" },
                    { 22, 9271, "Sequel" },
                    { 22, 29733, "Side Story" },
                    { 22, 37303, "Alternative Version" },
                    { 22, 73397, "Side Story" },
                    { 22, 105837, "Sequel" },
                    { 24, 5147, "Alternative Version" },
                    { 24, 9114, "Spin-Off" },
                    { 24, 14155, "Character" },
                    { 25, 4658, "Side Story" },
                    { 25, 32409, "Alternative Version" },
                    { 25, 141959, "Other" },
                    { 25, 174108, "Other" },
                    { 25, 174109, "Side Story" },
                    { 26, 45996, "Side Story" },
                    { 26, 145250, "Side Story" },
                    { 27, 133, "Prequel" },
                    { 36, 87623, "Other" },
                    { 42, 796, "Character" },
                    { 42, 881, "Other" },
                    { 42, 2897, "Alternative Version" },
                    { 42, 16038, "Character" },
                    { 42, 16110, "Side Story" },
                    { 42, 23446, "Alternative Version" },
                    { 42, 26373, "Spin-Off" },
                    { 42, 54627, "Prequel" },
                    { 42, 86671, "Spin-Off" },
                    { 42, 88233, "Character" },
                    { 42, 89734, "Sequel" },
                    { 42, 94865, "Other" },
                    { 42, 103047, "Spin-Off" },
                    { 42, 110590, "Spin-Off" },
                    { 42, 110591, "Spin-Off" },
                    { 42, 139066, "Other" },
                    { 43, 11926, "Character" },
                    { 43, 13891, "Other" },
                    { 43, 93595, "Alternative Version" },
                    { 43, 166643, "Sequel" },
                    { 44, 1414, "Character" },
                    { 44, 14022, "Spin-Off" },
                    { 44, 91209, "Other" },
                    { 45, 105579, "Sequel" },
                    { 47, 13891, "Other" },
                    { 47, 17288, "Side Story" },
                    { 47, 23504, "Spin-Off" },
                    { 47, 73115, "Side Story" },
                    { 49, 11153, "Alternative Version" },
                    { 49, 12965, "Sequel" },
                    { 108, 32037, "Sequel" },
                    { 109, 32037, "Alternative Setting" },
                    { 133, 27, "Sequel" },
                    { 160, 9259, "Alternative Setting" },
                    { 160, 18982, "Side Story" },
                    { 160, 80435, "Side Story" },
                    { 173, 174, "Sequel" },
                    { 174, 173, "Prequel" },
                    { 201, 90408, "Alternative Version" },
                    { 206, 9977, "Alternative Version" },
                    { 206, 42571, "Side Story" },
                    { 214, 9889, "Alternative Version" },
                    { 214, 9977, "Alternative Version" },
                    { 214, 104841, "Spin-Off" },
                    { 345, 593, "Prequel" },
                    { 345, 594, "Prequel" },
                    { 345, 10982, "Sequel" },
                    { 349, 454, "Side Story" },
                    { 349, 1546, "Prequel" },
                    { 349, 1936, "Sequel" },
                    { 349, 1938, "Side Story" },
                    { 349, 1939, "Parent Story" },
                    { 349, 1941, "Side Story" },
                    { 349, 65869, "Other" },
                    { 349, 91443, "Alternative Version" },
                    { 351, 408, "Sequel" },
                    { 351, 139018, "Spin-Off" },
                    { 393, 17111, "Sequel" },
                    { 393, 17149, "Sequel" },
                    { 393, 18654, "Spin-Off" },
                    { 393, 18668, "Spin-Off" },
                    { 393, 65669, "Spin-Off" },
                    { 393, 71821, "Spin-Off" },
                    { 393, 111192, "Spin-Off" },
                    { 393, 114862, "Side Story" },
                    { 408, 351, "Prequel" },
                    { 408, 13787, "Alternative Version" },
                    { 408, 169587, "Alternative Version" },
                    { 430, 67019, "Sequel" },
                    { 436, 119534, "Side Story" },
                    { 438, 5733, "Sequel" },
                    { 438, 90065, "Spin-Off" },
                    { 438, 93820, "Alternative Version" },
                    { 438, 94838, "Spin-Off" },
                    { 438, 94865, "Other" },
                    { 438, 109217, "Character" },
                    { 438, 140245, "Spin-Off" },
                    { 438, 142617, "Other" },
                    { 438, 148251, "Spin-Off" },
                    { 454, 349, "Parent Story" },
                    { 556, 557, "Alternative Version" },
                    { 556, 114227, "Alternative Version" },
                    { 557, 556, "Alternative Version" },
                    { 557, 114227, "Sequel" },
                    { 593, 345, "Sequel" },
                    { 593, 594, "Alternative Setting" },
                    { 594, 345, "Sequel" },
                    { 594, 351, "Parent Story" },
                    { 594, 593, "Alternative Setting" },
                    { 597, 15, "Alternative Version" },
                    { 598, 15921, "Other" },
                    { 598, 54697, "Side Story" },
                    { 598, 64565, "Other" },
                    { 598, 69415, "Side Story" },
                    { 598, 69903, "Prequel" },
                    { 598, 75493, "Spin-Off" },
                    { 598, 75495, "Spin-Off" },
                    { 598, 75497, "Spin-Off" },
                    { 598, 78003, "Side Story" },
                    { 598, 87623, "Other" },
                    { 598, 88032, "Other" },
                    { 598, 91971, "Spin-Off" },
                    { 598, 108461, "Side Story" },
                    { 598, 114701, "Sequel" },
                    { 598, 114892, "Spin-Off" },
                    { 598, 116463, "Spin-Off" },
                    { 598, 122473, "Other" },
                    { 598, 145357, "Spin-Off" },
                    { 598, 171740, "Side Story" },
                    { 642, 22527, "Spin-Off" },
                    { 642, 131084, "Other" },
                    { 653, 158887, "Sequel" },
                    { 660, 9820, "Side Story" },
                    { 660, 12842, "Spin-Off" },
                    { 660, 18791, "Alternative Version" },
                    { 660, 80223, "Side Story" },
                    { 671, 13891, "Other" },
                    { 671, 19018, "Alternative Version" },
                    { 671, 22519, "Sequel" },
                    { 671, 56011, "Side Story" },
                    { 671, 140247, "Side Story" },
                    { 676, 56725, "Sequel" },
                    { 676, 140901, "Sequel" },
                    { 698, 760, "Spin-Off" },
                    { 698, 3500, "Spin-Off" },
                    { 698, 5178, "Spin-Off" },
                    { 698, 21753, "Spin-Off" },
                    { 698, 25594, "Alternative Version" },
                    { 698, 25632, "Spin-Off" },
                    { 698, 25633, "Spin-Off" },
                    { 698, 49859, "Other" },
                    { 698, 82801, "Spin-Off" },
                    { 698, 99614, "Spin-Off" },
                    { 698, 137967, "Other" },
                    { 703, 704, "Sequel" },
                    { 703, 44357, "Side Story" },
                    { 704, 703, "Prequel" },
                    { 728, 745, "Spin-Off" },
                    { 728, 3010, "Alternative Version" },
                    { 728, 6488, "Other" },
                    { 728, 83411, "Prequel" },
                    { 728, 100039, "Spin-Off" },
                    { 728, 103910, "Side Story" },
                    { 733, 94865, "Other" },
                    { 733, 102286, "Other" },
                    { 743, 3, "Prequel" },
                    { 745, 728, "Parent Story" },
                    { 760, 698, "Parent Story" },
                    { 760, 3500, "Alternative Version" },
                    { 760, 5178, "Alternative Version" },
                    { 792, 1512, "Spin-Off" },
                    { 792, 17226, "Side Story" },
                    { 792, 108576, "Character" },
                    { 792, 117695, "Spin-Off" },
                    { 793, 13, "Other" },
                    { 793, 5114, "Other" },
                    { 796, 42, "Character" },
                    { 796, 16038, "Character" },
                    { 796, 88233, "Sequel" },
                    { 872, 1630, "Prequel" },
                    { 872, 3006, "Sequel" },
                    { 872, 32347, "Other" },
                    { 872, 57051, "Side Story" },
                    { 872, 75703, "Other" },
                    { 872, 152986, "Spin-Off" },
                    { 881, 13, "Parent Story" },
                    { 881, 42, "Parent Story" },
                    { 1009, 66025, "Sequel" },
                    { 1023, 1028, "Sequel" },
                    { 1023, 3395, "Character" },
                    { 1023, 7848, "Alternative Setting" },
                    { 1023, 10820, "Side Story" },
                    { 1023, 48321, "Alternative Setting" },
                    { 1023, 112031, "Spin-Off" },
                    { 1023, 123157, "Other" },
                    { 1026, 121505, "Prequel" },
                    { 1028, 1023, "Prequel" },
                    { 1028, 121505, "Sequel" },
                    { 1045, 1046, "Prequel" },
                    { 1045, 1047, "Prequel" },
                    { 1045, 1322, "Sequel" },
                    { 1045, 39875, "Side Story" },
                    { 1045, 49551, "Spin-Off" },
                    { 1045, 54761, "Spin-Off" },
                    { 1045, 65169, "Other" },
                    { 1045, 110898, "Prequel" },
                    { 1045, 117130, "Side Story" },
                    { 1045, 123901, "Side Story" },
                    { 1045, 133521, "Spin-Off" },
                    { 1045, 152326, "Spin-Off" },
                    { 1046, 1045, "Sequel" },
                    { 1046, 1047, "Prequel" },
                    { 1046, 1322, "Prequel" },
                    { 1046, 67297, "Sequel" },
                    { 1046, 122239, "Side Story" },
                    { 1047, 1045, "Sequel" },
                    { 1047, 1046, "Sequel" },
                    { 1047, 1322, "Alternative Setting" },
                    { 1047, 25916, "Side Story" },
                    { 1057, 88100, "Alternative Version" },
                    { 1061, 1804, "Alternative Setting" },
                    { 1061, 3202, "Side Story" },
                    { 1061, 11176, "Alternative Version" },
                    { 1061, 109213, "Side Story" },
                    { 1061, 109214, "Side Story" },
                    { 1061, 109215, "Side Story" },
                    { 1061, 109216, "Side Story" },
                    { 1061, 109217, "Side Story" },
                    { 1061, 110644, "Side Story" },
                    { 1061, 112744, "Spin-Off" },
                    { 1061, 114379, "Spin-Off" },
                    { 1061, 117572, "Side Story" },
                    { 1061, 121951, "Spin-Off" },
                    { 1061, 132100, "Side Story" },
                    { 1061, 133341, "Side Story" },
                    { 1061, 133342, "Side Story" },
                    { 1061, 133343, "Side Story" },
                    { 1061, 164976, "Side Story" },
                    { 1061, 167410, "Side Story" },
                    { 1061, 167474, "Side Story" },
                    { 1061, 167477, "Side Story" },
                    { 1224, 97324, "Spin-Off" },
                    { 1298, 94865, "Other" },
                    { 1322, 1045, "Prequel" },
                    { 1322, 1047, "Alternative Setting" },
                    { 1342, 10814, "Alternative Version" },
                    { 1342, 92203, "Alternative Version" },
                    { 1414, 44, "Character" },
                    { 1414, 10105, "Character" },
                    { 1414, 13891, "Other" },
                    { 1414, 20065, "Alternative Version" },
                    { 1414, 23598, "Side Story" },
                    { 1414, 102286, "Other" },
                    { 1442, 1474, "Prequel" },
                    { 1442, 7697, "Sequel" },
                    { 1442, 18991, "Spin-Off" },
                    { 1474, 1442, "Sequel" },
                    { 1474, 1475, "Sequel" },
                    { 1474, 4591, "Spin-Off" },
                    { 1474, 4592, "Side Story" },
                    { 1474, 13753, "Side Story" },
                    { 1474, 26751, "Spin-Off" },
                    { 1474, 37561, "Alternative Version" },
                    { 1474, 75719, "Spin-Off" },
                    { 1474, 92833, "Character" },
                    { 1474, 95091, "Other" },
                    { 1474, 101956, "Alternative Version" },
                    { 1474, 104670, "Other" },
                    { 1474, 146520, "Alternative Version" },
                    { 1475, 1474, "Prequel" },
                    { 1475, 75723, "Spin-Off" },
                    { 1475, 85924, "Sequel" },
                    { 1505, 11210, "Sequel" },
                    { 1505, 33617, "Alternative Version" },
                    { 1505, 75051, "Spin-Off" },
                    { 1505, 94865, "Other" },
                    { 1512, 792, "Parent Story" },
                    { 1512, 34837, "Sequel" },
                    { 1517, 1630, "Sequel" },
                    { 1517, 46604, "Spin-Off" },
                    { 1546, 349, "Sequel" },
                    { 1551, 6891, "Sequel" },
                    { 1551, 7759, "Sequel" },
                    { 1551, 8571, "Sequel" },
                    { 1551, 10447, "Sequel" },
                    { 1551, 15359, "Sequel" },
                    { 1551, 18074, "Other" },
                    { 1551, 26751, "Spin-Off" },
                    { 1551, 37701, "Spin-Off" },
                    { 1551, 87835, "Character" },
                    { 1551, 93088, "Alternative Version" },
                    { 1551, 114435, "Spin-Off" },
                    { 1551, 119385, "Spin-Off" },
                    { 1630, 872, "Sequel" },
                    { 1630, 1517, "Prequel" },
                    { 1630, 46604, "Spin-Off" },
                    { 1630, 150846, "Spin-Off" },
                    { 1639, 42755, "Alternative Version" },
                    { 1639, 56725, "Side Story" },
                    { 1639, 66161, "Sequel" },
                    { 1639, 95091, "Alternative Setting" },
                    { 1639, 169403, "Other" },
                    { 1706, 3009, "Prequel" },
                    { 1706, 25515, "Sequel" },
                    { 1804, 1061, "Alternative Setting" },
                    { 1873, 5202, "Sequel" },
                    { 1932, 58217, "Sequel" },
                    { 1936, 349, "Prequel" },
                    { 1936, 1938, "Side Story" },
                    { 1936, 91444, "Alternative Version" },
                    { 1938, 349, "Parent Story" },
                    { 1938, 1936, "Parent Story" },
                    { 1938, 1939, "Alternative Version" },
                    { 1938, 1941, "Alternative Version" },
                    { 1939, 1938, "Alternative Version" },
                    { 1939, 1941, "Alternative Version" },
                    { 1941, 1938, "Alternative Version" },
                    { 2105, 81575, "Prequel" },
                    { 2144, 31521, "Other" },
                    { 2333, 22, "Prequel" },
                    { 2333, 9271, "Sequel" },
                    { 2845, 5451, "Sequel" },
                    { 2845, 13927, "Side Story" },
                    { 2845, 21599, "Spin-Off" },
                    { 2845, 94865, "Other" },
                    { 2845, 106764, "Spin-Off" },
                    { 2845, 147070, "Spin-Off" },
                    { 2845, 172577, "Spin-Off" },
                    { 2897, 42, "Alternative Version" },
                    { 2957, 18, "Parent Story" },
                    { 3006, 872, "Prequel" },
                    { 3006, 3008, "Sequel" },
                    { 3006, 3578, "Side Story" },
                    { 3006, 19423, "Spin-Off" },
                    { 3006, 32991, "Side Story" },
                    { 3006, 61959, "Spin-Off" },
                    { 3006, 142551, "Spin-Off" },
                    { 3008, 3006, "Prequel" },
                    { 3008, 3009, "Sequel" },
                    { 3008, 35907, "Spin-Off" },
                    { 3008, 41865, "Side Story" },
                    { 3009, 1706, "Sequel" },
                    { 3009, 3008, "Prequel" },
                    { 3009, 47533, "Spin-Off" },
                    { 3009, 142552, "Spin-Off" },
                    { 3010, 728, "Alternative Version" },
                    { 3084, 94865, "Other" },
                    { 3087, 20221, "Prequel" },
                    { 3202, 1061, "Parent Story" },
                    { 3378, 23942, "Alternative Version" },
                    { 3378, 128131, "Sequel" },
                    { 3395, 8350, "Alternative Setting" },
                    { 3500, 698, "Parent Story" },
                    { 3500, 760, "Alternative Version" },
                    { 3500, 5178, "Alternative Version" },
                    { 3510, 91734, "Alternative Version" },
                    { 3537, 62393, "Other" },
                    { 3578, 3006, "Parent Story" },
                    { 3578, 61959, "Other" },
                    { 3645, 21, "Other" },
                    { 3822, 96448, "Side Story" },
                    { 3865, 351, "Alternative Version" },
                    { 3865, 169587, "Sequel" },
                    { 3866, 13450, "Other" },
                    { 4101, 81575, "Alternative Version" },
                    { 4186, 31845, "Side Story" },
                    { 4186, 35281, "Alternative Version" },
                    { 4404, 6732, "Parent Story" },
                    { 4404, 10328, "Side Story" },
                    { 4404, 15148, "Sequel" },
                    { 4591, 1474, "Parent Story" },
                    { 4592, 1474, "Alternative Version" },
                    { 4592, 20581, "Sequel" },
                    { 4658, 25, "Parent Story" },
                    { 4795, 22, "Parent Story" },
                    { 4981, 13787, "Parent Story" },
                    { 5114, 13, "Alternative Version" },
                    { 5114, 793, "Other" },
                    { 5147, 24, "Alternative Version" },
                    { 5177, 18254, "Alternative Version" },
                    { 5177, 135181, "Alternative Version" },
                    { 5177, 137358, "Spin-Off" },
                    { 5177, 148912, "Side Story" },
                    { 5177, 155003, "Spin-Off" },
                    { 5178, 698, "Parent Story" },
                    { 5178, 760, "Alternative Version" },
                    { 5178, 3500, "Alternative Version" },
                    { 5202, 1873, "Prequel" },
                    { 5202, 5203, "Sequel" },
                    { 5202, 16456, "Prequel" },
                    { 5202, 161081, "Side Story" },
                    { 5203, 5202, "Prequel" },
                    { 5203, 5204, "Sequel" },
                    { 5204, 5203, "Prequel" },
                    { 5204, 32799, "Sequel" },
                    { 5204, 172491, "Spin-Off" },
                    { 5206, 30593, "Prequel" },
                    { 5451, 2845, "Prequel" },
                    { 5451, 21608, "Spin-Off" },
                    { 5451, 23234, "Sequel" },
                    { 5664, 16532, "Alternative Version" },
                    { 5664, 22131, "Side Story" },
                    { 5664, 66809, "Other" },
                    { 5664, 102286, "Other" },
                    { 5664, 158125, "Side Story" },
                    { 5733, 438, "Prequel" },
                    { 5733, 24312, "Sequel" },
                    { 5733, 142617, "Other" },
                    { 5756, 88100, "Alternative Version" },
                    { 5931, 16, "Parent Story" },
                    { 6028, 11, "Alternative Version" },
                    { 6444, 11, "Alternative Version" },
                    { 6488, 728, "Other" },
                    { 6732, 4404, "Side Story" },
                    { 6732, 10328, "Side Story" },
                    { 6732, 10720, "Side Story" },
                    { 6732, 11561, "Alternative Version" },
                    { 6732, 15148, "Side Story" },
                    { 6732, 19033, "Sequel" },
                    { 6732, 20467, "Alternative Version" },
                    { 6891, 1551, "Prequel" },
                    { 6891, 7759, "Prequel" },
                    { 6891, 10447, "Prequel" },
                    { 7378, 24294, "Other" },
                    { 7458, 21, "Sequel" },
                    { 7658, 16941, "Sequel" },
                    { 7658, 16942, "Alternative Version" },
                    { 7658, 19870, "Character" },
                    { 7658, 75723, "Spin-Off" },
                    { 7658, 92833, "Character" },
                    { 7658, 96389, "Alternative Version" },
                    { 7658, 119688, "Alternative Version" },
                    { 7666, 8782, "Alternative Version" },
                    { 7666, 92838, "Character" },
                    { 7697, 1442, "Prequel" },
                    { 7747, 14674, "Side Story" },
                    { 7747, 96383, "Side Story" },
                    { 7756, 19870, "Character" },
                    { 7759, 1551, "Prequel" },
                    { 7759, 6891, "Sequel" },
                    { 7759, 8571, "Sequel" },
                    { 7759, 10447, "Sequel" },
                    { 7759, 15359, "Sequel" },
                    { 7759, 18074, "Other" },
                    { 7759, 92838, "Character" },
                    { 7848, 1023, "Alternative Setting" },
                    { 7848, 31935, "Alternative Version" },
                    { 7887, 25146, "Spin-Off" },
                    { 7887, 93982, "Spin-Off" },
                    { 7887, 102846, "Other" },
                    { 7887, 102847, "Alternative Version" },
                    { 8157, 88679, "Side Story" },
                    { 8157, 110668, "Sequel" },
                    { 8158, 21, "Parent Story" },
                    { 8300, 75053, "Other" },
                    { 8300, 88032, "Other" },
                    { 8350, 3395, "Alternative Setting" },
                    { 8558, 8773, "Prequel" },
                    { 8558, 32899, "Alternative Version" },
                    { 8558, 78717, "Alternative Version" },
                    { 8558, 92833, "Character" },
                    { 8558, 171563, "Alternative Version" },
                    { 8571, 7759, "Prequel" },
                    { 8571, 10447, "Sequel" },
                    { 8571, 18074, "Other" },
                    { 8571, 92839, "Character" },
                    { 8772, 92839, "Character" },
                    { 8773, 8558, "Sequel" },
                    { 8773, 37701, "Spin-Off" },
                    { 8773, 87725, "Other" },
                    { 8773, 90885, "Other" },
                    { 8773, 92833, "Character" },
                    { 8773, 98118, "Sequel" },
                    { 8773, 111710, "Prequel" },
                    { 8773, 169920, "Alternative Version" },
                    { 8773, 171477, "Alternative Version" },
                    { 8782, 7666, "Alternative Version" },
                    { 8795, 65643, "Prequel" },
                    { 8795, 86414, "Other" },
                    { 9114, 24, "Parent Story" },
                    { 9259, 160, "Alternative Setting" },
                    { 9271, 22, "Prequel" },
                    { 9271, 2333, "Prequel" },
                    { 9273, 16456, "Sequel" },
                    { 9273, 170875, "Prequel" },
                    { 9711, 13891, "Other" },
                    { 9711, 21274, "Spin-Off" },
                    { 9711, 92905, "Prequel" },
                    { 9711, 92906, "Spin-Off" },
                    { 9711, 93027, "Alternative Version" },
                    { 9726, 18162, "Spin-Off" },
                    { 9726, 87518, "Spin-Off" },
                    { 9726, 117028, "Other" },
                    { 9736, 29391, "Alternative Version" },
                    { 9736, 42439, "Spin-Off" },
                    { 9736, 85391, "Alternative Version" },
                    { 9736, 111971, "Alternative Setting" },
                    { 9736, 132537, "Spin-Off" },
                    { 9736, 148473, "Alternative Version" },
                    { 9736, 162864, "Spin-Off" },
                    { 9820, 660, "Prequel" },
                    { 9889, 214, "Alternative Version" },
                    { 9889, 9977, "Alternative Version" },
                    { 9889, 85391, "Sequel" },
                    { 9889, 93326, "Side Story" },
                    { 9889, 97664, "Spin-Off" },
                    { 9977, 206, "Alternative Version" },
                    { 9977, 214, "Alternative Version" },
                    { 9977, 9889, "Alternative Version" },
                    { 9977, 85033, "Other" },
                    { 9977, 93831, "Spin-Off" },
                    { 9977, 96390, "Spin-Off" },
                    { 9977, 122892, "Other" },
                    { 9977, 150511, "Spin-Off" },
                    { 9977, 161167, "Spin-Off" },
                    { 9977, 162863, "Spin-Off" },
                    { 9977, 163170, "Spin-Off" },
                    { 9977, 166075, "Spin-Off" },
                    { 10010, 36729, "Alternative Version" },
                    { 10010, 77849, "Side Story" },
                    { 10010, 102286, "Other" },
                    { 10105, 1414, "Character" },
                    { 10183, 10, "Parent Story" },
                    { 10328, 4404, "Side Story" },
                    { 10328, 6732, "Parent Story" },
                    { 10328, 15148, "Side Story" },
                    { 10328, 24548, "Side Story" },
                    { 10447, 1551, "Prequel" },
                    { 10447, 6891, "Sequel" },
                    { 10447, 7759, "Prequel" },
                    { 10447, 8571, "Prequel" },
                    { 10447, 15359, "Sequel" },
                    { 10447, 18074, "Other" },
                    { 10720, 6732, "Parent Story" },
                    { 10720, 21911, "Sequel" },
                    { 10814, 1342, "Alternative Version" },
                    { 10820, 1023, "Parent Story" },
                    { 10968, 1, "Prequel" },
                    { 10982, 345, "Prequel" },
                    { 10982, 11971, "Sequel" },
                    { 11153, 49, "Parent Story" },
                    { 11176, 1061, "Alternative Version" },
                    { 11210, 1505, "Prequel" },
                    { 11300, 24312, "Prequel" },
                    { 11330, 12, "Alternative Version" },
                    { 11437, 15305, "Alternative Setting" },
                    { 11561, 4404, "Side Story" },
                    { 11561, 6732, "Alternative Version" },
                    { 11561, 10328, "Prequel" },
                    { 11561, 10720, "Side Story" },
                    { 11561, 18440, "Sequel" },
                    { 11561, 20467, "Alternative Version" },
                    { 11652, 42737, "Side Story" },
                    { 11652, 83807, "Sequel" },
                    { 11926, 11, "Character" },
                    { 11926, 13, "Character" },
                    { 11926, 42, "Character" },
                    { 11926, 43, "Character" },
                    { 11926, 45, "Character" },
                    { 11926, 796, "Character" },
                    { 11926, 1505, "Character" },
                    { 11971, 10982, "Prequel" },
                    { 12336, 79133, "Side Story" },
                    { 12709, 89610, "Sequel" },
                    { 12709, 90883, "Alternative Setting" },
                    { 12709, 90884, "Other" },
                    { 12709, 90885, "Other" },
                    { 12842, 660, "Parent Story" },
                    { 12965, 49, "Prequel" },
                    { 13450, 3866, "Parent Story" },
                    { 13492, 28103, "Side Story" },
                    { 13492, 36277, "Alternative Version" },
                    { 13492, 57927, "Spin-Off" },
                    { 13492, 114679, "Side Story" },
                    { 13492, 152142, "Side Story" },
                    { 13741, 30725, "Alternative Version" },
                    { 13753, 1474, "Parent Story" },
                    { 13787, 408, "Alternative Version" },
                    { 13787, 4981, "Spin-Off" },
                    { 13891, 43, "Parent Story" },
                    { 13891, 47, "Parent Story" },
                    { 13891, 671, "Parent Story" },
                    { 13891, 1414, "Parent Story" },
                    { 13891, 9711, "Parent Story" },
                    { 13927, 2845, "Parent Story" },
                    { 14022, 44, "Parent Story" },
                    { 14022, 159674, "Sequel" },
                    { 14155, 24, "Character" },
                    { 14230, 25541, "Sequel" },
                    { 14230, 65169, "Other" },
                    { 14230, 126241, "Prequel" },
                    { 14231, 14232, "Sequel" },
                    { 14231, 31011, "Other" },
                    { 14231, 65169, "Other" },
                    { 14232, 14231, "Prequel" },
                    { 14368, 9, "Parent Story" },
                    { 14368, 10, "Parent Story" },
                    { 14377, 19870, "Character" },
                    { 14377, 57897, "Sequel" },
                    { 14414, 13, "Parent Story" },
                    { 14674, 7747, "Parent Story" },
                    { 14841, 16816, "Alternative Version" },
                    { 14841, 34335, "Sequel" },
                    { 14893, 23751, "Sequel" },
                    { 14893, 24499, "Side Story" },
                    { 14893, 86670, "Side Story" },
                    { 14893, 90322, "Side Story" },
                    { 14893, 93097, "Side Story" },
                    { 14893, 113010, "Alternative Version" },
                    { 14893, 117028, "Side Story" },
                    { 15018, 16666, "Spin-Off" },
                    { 15106, 8773, "Side Story" },
                    { 15148, 4404, "Prequel" },
                    { 15148, 6732, "Parent Story" },
                    { 15148, 10328, "Side Story" },
                    { 15148, 24548, "Sequel" },
                    { 15200, 117028, "Other" },
                    { 15200, 135567, "Alternative Version" },
                    { 15305, 11437, "Alternative Version" },
                    { 15305, 15315, "Sequel" },
                    { 15315, 15305, "Prequel" },
                    { 15359, 1551, "Prequel" },
                    { 15359, 6891, "Prequel" },
                    { 15359, 7759, "Prequel" },
                    { 15359, 8571, "Prequel" },
                    { 15359, 10447, "Prequel" },
                    { 15359, 18074, "Other" },
                    { 15530, 114372, "Other" },
                    { 15530, 118522, "Alternative Version" },
                    { 15691, 3, "Parent Story" },
                    { 15918, 14, "Parent Story" },
                    { 15921, 14, "Other" },
                    { 15921, 598, "Other" },
                    { 16038, 42, "Character" },
                    { 16038, 796, "Character" },
                    { 16110, 42, "Parent Story" },
                    { 16168, 85393, "Alternative Version" },
                    { 16168, 86844, "Side Story" },
                    { 16168, 97060, "Sequel" },
                    { 16456, 5202, "Sequel" },
                    { 16456, 9273, "Prequel" },
                    { 16456, 97057, "Alternative Version" },
                    { 16456, 158167, "Prequel" },
                    { 16532, 5664, "Alternative Version" },
                    { 16666, 15018, "Spin-Off" },
                    { 16816, 1342, "Alternative Setting" },
                    { 16816, 14841, "Alternative Version" },
                    { 16816, 21132, "Sequel" },
                    { 16816, 21587, "Other" },
                    { 16816, 24901, "Side Story" },
                    { 16816, 34335, "Alternative Version" },
                    { 16816, 49547, "Alternative Version" },
                    { 16816, 69073, "Sequel" },
                    { 16816, 69765, "Spin-Off" },
                    { 16816, 78183, "Side Story" },
                    { 16816, 81485, "Spin-Off" },
                    { 16816, 81551, "Spin-Off" },
                    { 16816, 85707, "Alternative Version" },
                    { 16816, 90870, "Spin-Off" },
                    { 16816, 94392, "Side Story" },
                    { 16816, 113839, "Character" },
                    { 16941, 7658, "Prequel" },
                    { 16941, 19619, "Sequel" },
                    { 16942, 7658, "Alternative Version" },
                    { 16942, 87835, "Side Story" },
                    { 16943, 98118, "Alternative Version" },
                    { 16943, 171477, "Prequel" },
                    { 17111, 393, "Prequel" },
                    { 17149, 393, "Prequel" },
                    { 17149, 21307, "Sequel" },
                    { 17149, 111192, "Spin-Off" },
                    { 17152, 13, "Parent Story" },
                    { 17226, 792, "Parent Story" },
                    { 17288, 47, "Parent Story" },
                    { 18074, 1551, "Other" },
                    { 18074, 7759, "Other" },
                    { 18074, 8571, "Other" },
                    { 18074, 10447, "Other" },
                    { 18074, 15359, "Other" },
                    { 18161, 20983, "Spin-Off" },
                    { 18161, 117028, "Other" },
                    { 18162, 9726, "Parent Story" },
                    { 18162, 28075, "Alternative Version" },
                    { 18162, 70117, "Alternative Version" },
                    { 18162, 117028, "Other" },
                    { 18254, 5177, "Alternative Version" },
                    { 18254, 135181, "Prequel" },
                    { 18440, 11561, "Prequel" },
                    { 18440, 19033, "Alternative Version" },
                    { 18440, 20477, "Alternative Version" },
                    { 18654, 393, "Parent Story" },
                    { 18654, 18668, "Sequel" },
                    { 18668, 393, "Parent Story" },
                    { 18668, 18654, "Prequel" },
                    { 18791, 660, "Parent Story" },
                    { 18982, 160, "Parent Story" },
                    { 18991, 1442, "Spin-Off" },
                    { 19018, 671, "Alternative Version" },
                    { 19033, 6732, "Prequel" },
                    { 19033, 18440, "Alternative Version" },
                    { 19033, 20477, "Alternative Version" },
                    { 19033, 24812, "Sequel" },
                    { 19315, 37999, "Sequel" },
                    { 19315, 62687, "Side Story" },
                    { 19315, 65499, "Alternative Version" },
                    { 19315, 111453, "Alternative Version" },
                    { 19315, 113275, "Alternative Version" },
                    { 19423, 3006, "Parent Story" },
                    { 19619, 16941, "Prequel" },
                    { 19870, 7658, "Character" },
                    { 19870, 7756, "Character" },
                    { 19870, 14377, "Character" },
                    { 20065, 1414, "Alternative Version" },
                    { 20221, 3087, "Sequel" },
                    { 20467, 6732, "Alternative Version" },
                    { 20467, 11561, "Alternative Version" },
                    { 20467, 20477, "Sequel" },
                    { 20477, 18440, "Alternative Version" },
                    { 20477, 19033, "Alternative Version" },
                    { 20477, 20467, "Prequel" },
                    { 20581, 1474, "Parent Story" },
                    { 20581, 4592, "Prequel" },
                    { 20983, 18161, "Parent Story" },
                    { 21115, 117028, "Other" },
                    { 21132, 16816, "Alternative Setting" },
                    { 21132, 21135, "Side Story" },
                    { 21135, 21132, "Parent Story" },
                    { 21274, 9711, "Parent Story" },
                    { 21307, 17149, "Prequel" },
                    { 21307, 90585, "Sequel" },
                    { 21479, 23718, "Alternative Version" },
                    { 21479, 37405, "Side Story" },
                    { 21479, 40053, "Spin-Off" },
                    { 21479, 40281, "Side Story" },
                    { 21479, 41027, "Side Story" },
                    { 21479, 43921, "Side Story" },
                    { 21479, 44733, "Alternative Version" },
                    { 21479, 46222, "Side Story" },
                    { 21479, 46582, "Side Story" },
                    { 21479, 55875, "Side Story" },
                    { 21479, 56169, "Side Story" },
                    { 21479, 60593, "Side Story" },
                    { 21479, 75099, "Alternative Version" },
                    { 21479, 75101, "Alternative Version" },
                    { 21479, 75103, "Alternative Version" },
                    { 21479, 82795, "Spin-Off" },
                    { 21479, 99386, "Alternative Version" },
                    { 21479, 99758, "Spin-Off" },
                    { 21479, 102484, "Spin-Off" },
                    { 21479, 103244, "Side Story" },
                    { 21479, 103807, "Spin-Off" },
                    { 21479, 103808, "Spin-Off" },
                    { 21479, 113491, "Spin-Off" },
                    { 21479, 118123, "Spin-Off" },
                    { 21479, 125767, "Alternative Version" },
                    { 21479, 141953, "Alternative Version" },
                    { 21479, 158357, "Alternative Version" },
                    { 21587, 16816, "Parent Story" },
                    { 21599, 2845, "Parent Story" },
                    { 21599, 156424, "Sequel" },
                    { 21608, 5451, "Parent Story" },
                    { 21753, 698, "Parent Story" },
                    { 21883, 16, "Parent Story" },
                    { 21907, 15, "Alternative Setting" },
                    { 21911, 10720, "Prequel" },
                    { 21911, 18440, "Full Story" },
                    { 21911, 19033, "Full Story" },
                    { 21911, 20477, "Full Story" },
                    { 22131, 5664, "Parent Story" },
                    { 22519, 671, "Prequel" },
                    { 22519, 41835, "Side Story" },
                    { 22519, 122105, "Side Story" },
                    { 22519, 124619, "Side Story" },
                    { 22519, 124620, "Side Story" },
                    { 22519, 155002, "Side Story" },
                    { 22527, 642, "Parent Story" },
                    { 22744, 12, "Alternative Version" },
                    { 22744, 22745, "Sequel" },
                    { 22745, 22744, "Prequel" },
                    { 23208, 11, "Parent Story" },
                    { 23234, 5451, "Prequel" },
                    { 23251, 13, "Parent Story" },
                    { 23251, 52353, "Alternative Setting" },
                    { 23355, 12, "Parent Story" },
                    { 23446, 42, "Parent Story" },
                    { 23504, 47, "Spin-Off" },
                    { 23598, 1414, "Parent Story" },
                    { 23718, 21479, "Alternative Version" },
                    { 23718, 44733, "Sequel" },
                    { 23751, 14893, "Prequel" },
                    { 23751, 44227, "Sequel" },
                    { 23751, 66695, "Other" },
                    { 23751, 90324, "Side Story" },
                    { 23869, 145352, "Alternative Version" },
                    { 23942, 3378, "Alternative Version" },
                    { 24033, 95212, "Spin-Off" },
                    { 24033, 96692, "Other" },
                    { 24294, 7378, "Other" },
                    { 24294, 33297, "Alternative Version" },
                    { 24294, 52389, "Other" },
                    { 24294, 77237, "Side Story" },
                    { 24294, 77239, "Side Story" },
                    { 24295, 24457, "Parent Story" },
                    { 24312, 5733, "Prequel" },
                    { 24312, 11300, "Sequel" },
                    { 24456, 24457, "Parent Story" },
                    { 24456, 65909, "Side Story" },
                    { 24456, 90687, "Prequel" },
                    { 24457, 24295, "Spin-Off" },
                    { 24457, 24456, "Spin-Off" },
                    { 24457, 27861, "Alternative Version" },
                    { 24457, 28961, "Other" },
                    { 24457, 44319, "Alternative Version" },
                    { 24457, 62673, "Spin-Off" },
                    { 24457, 63329, "Spin-Off" },
                    { 24457, 70751, "Spin-Off" },
                    { 24457, 73781, "Spin-Off" },
                    { 24457, 76319, "Spin-Off" },
                    { 24457, 85884, "Spin-Off" },
                    { 24457, 89364, "Spin-Off" },
                    { 24457, 89365, "Spin-Off" },
                    { 24457, 89366, "Spin-Off" },
                    { 24457, 90016, "Spin-Off" },
                    { 24457, 90309, "Sequel" },
                    { 24457, 104509, "Spin-Off" },
                    { 24457, 104925, "Spin-Off" },
                    { 24457, 106374, "Spin-Off" },
                    { 24457, 115774, "Alternative Version" },
                    { 24457, 156089, "Other" },
                    { 24457, 174555, "Spin-Off" },
                    { 24499, 14893, "Parent Story" },
                    { 24548, 15148, "Parent Story" },
                    { 24561, 47363, "Sequel" },
                    { 24561, 103907, "Prequel" },
                    { 24679, 349, "Alternative Version" },
                    { 24812, 19033, "Prequel" },
                    { 24822, 86336, "Side Story" },
                    { 24822, 93698, "Spin-Off" },
                    { 24822, 99853, "Other" },
                    { 24822, 104330, "Spin-Off" },
                    { 24822, 104333, "Spin-Off" },
                    { 24822, 118801, "Spin-Off" },
                    { 24822, 125236, "Spin-Off" },
                    { 24822, 144847, "Spin-Off" },
                    { 24901, 16816, "Parent Story" },
                    { 25096, 56725, "Side Story" },
                    { 25146, 13, "Parent Story" },
                    { 25146, 7887, "Parent Story" },
                    { 25409, 30859, "Alternative Version" },
                    { 25409, 34485, "Spin-Off" },
                    { 25409, 87375, "Side Story" },
                    { 25409, 94864, "Alternative Version" },
                    { 25409, 100790, "Side Story" },
                    { 25409, 110390, "Alternative Setting" },
                    { 25409, 114787, "Sequel" },
                    { 25515, 1706, "Prequel" },
                    { 25515, 139629, "Sequel" },
                    { 25541, 14230, "Prequel" },
                    { 25594, 698, "Alternative Setting" },
                    { 25632, 698, "Parent Story" },
                    { 25632, 25633, "Alternative Version" },
                    { 25633, 698, "Alternative Setting" },
                    { 25633, 25632, "Alternative Version" },
                    { 25916, 1047, "Parent Story" },
                    { 26123, 94865, "Other" },
                    { 26123, 132186, "Character" },
                    { 26133, 12, "Parent Story" },
                    { 26178, 57249, "Prequel" },
                    { 26178, 80469, "Side Story" },
                    { 26178, 132966, "Spin-Off" },
                    { 26373, 42, "Parent Story" },
                    { 26751, 1474, "Spin-Off" },
                    { 26751, 1551, "Spin-Off" },
                    { 27861, 24457, "Alternative Version" },
                    { 28075, 18162, "Alternative Version" },
                    { 28075, 70117, "Sequel" },
                    { 28103, 13492, "Parent Story" },
                    { 28961, 24457, "Parent Story" },
                    { 29391, 9736, "Alternative Version" },
                    { 29391, 85391, "Alternative Version" },
                    { 29733, 22, "Parent Story" },
                    { 30541, 12, "Parent Story" },
                    { 30591, 5206, "Sequel" },
                    { 30591, 30593, "Alternative Version" },
                    { 30591, 68983, "Alternative Version" },
                    { 30591, 85393, "Prequel" },
                    { 30593, 5206, "Sequel" },
                    { 30593, 30591, "Alternative Version" },
                    { 30593, 68983, "Alternative Version" },
                    { 30593, 72431, "Alternative Version" },
                    { 30593, 85393, "Prequel" },
                    { 30723, 37701, "Spin-Off" },
                    { 30723, 153208, "Alternative Version" },
                    { 30725, 13741, "Alternative Version" },
                    { 30725, 163880, "Spin-Off" },
                    { 30859, 25409, "Alternative Version" },
                    { 30987, 35243, "Alternative Version" },
                    { 31011, 14231, "Parent Story" },
                    { 31079, 37755, "Sequel" },
                    { 31499, 35243, "Other" },
                    { 31499, 58193, "Other" },
                    { 31499, 65051, "Side Story" },
                    { 31499, 70251, "Other" },
                    { 31499, 83187, "Spin-Off" },
                    { 31499, 102286, "Other" },
                    { 31499, 117050, "Side Story" },
                    { 31521, 18, "Parent Story" },
                    { 31521, 2144, "Parent Story" },
                    { 31845, 4186, "Parent Story" },
                    { 31935, 7848, "Alternative Version" },
                    { 31935, 80473, "Sequel" },
                    { 31939, 116678, "Parent Story" },
                    { 32037, 108, "Prequel" },
                    { 32037, 109, "Alternative Setting" },
                    { 32347, 872, "Other" },
                    { 32409, 25, "Alternative Version" },
                    { 32799, 5204, "Prequel" },
                    { 32799, 98567, "Sequel" },
                    { 32899, 8558, "Alternative Version" },
                    { 32913, 133638, "Other" },
                    { 32913, 141885, "Spin-Off" },
                    { 32991, 3006, "Parent Story" },
                    { 33297, 24294, "Alternative Version" },
                    { 33327, 74847, "Side Story" },
                    { 33327, 77815, "Side Story" },
                    { 33327, 80909, "Alternative Version" },
                    { 33327, 81117, "Sequel" },
                    { 33617, 1505, "Alternative Version" },
                    { 33699, 34127, "Alternative Version" },
                    { 33699, 60973, "Sequel" },
                    { 34127, 33699, "Alternative Version" },
                    { 34127, 41539, "Spin-Off" },
                    { 34127, 60973, "Alternative Version" },
                    { 34127, 60975, "Alternative Version" },
                    { 34127, 60977, "Alternative Version" },
                    { 34127, 93234, "Alternative Version" },
                    { 34127, 98583, "Side Story" },
                    { 34127, 101482, "Alternative Version" },
                    { 34127, 104234, "Alternative Version" },
                    { 34127, 108530, "Spin-Off" },
                    { 34127, 115017, "Alternative Version" },
                    { 34127, 119295, "Alternative Version" },
                    { 34127, 119296, "Alternative Version" },
                    { 34127, 122557, "Spin-Off" },
                    { 34127, 130314, "Sequel" },
                    { 34127, 133005, "Spin-Off" },
                    { 34127, 135262, "Spin-Off" },
                    { 34127, 135740, "Alternative Version" },
                    { 34127, 135741, "Alternative Version" },
                    { 34127, 135742, "Alternative Version" },
                    { 34127, 157223, "Alternative Version" },
                    { 34127, 157224, "Alternative Version" },
                    { 34127, 157225, "Alternative Version" },
                    { 34127, 161895, "Spin-Off" },
                    { 34335, 14841, "Prequel" },
                    { 34335, 16816, "Alternative Version" },
                    { 34335, 49547, "Sequel" },
                    { 34485, 25409, "Parent Story" },
                    { 34837, 792, "Alternative Version" },
                    { 34837, 1512, "Prequel" },
                    { 35003, 62393, "Other" },
                    { 35003, 75053, "Other" },
                    { 35003, 88032, "Other" },
                    { 35243, 30987, "Alternative Version" },
                    { 35243, 73631, "Side Story" },
                    { 35243, 80163, "Spin-Off" },
                    { 35243, 119852, "Spin-Off" },
                    { 35243, 146284, "Spin-Off" },
                    { 35243, 166983, "Side Story" },
                    { 35243, 167572, "Alternative Version" },
                    { 35281, 4186, "Alternative Version" },
                    { 35317, 30861, "Parent Story" },
                    { 35319, 30861, "Alternative Version" },
                    { 35319, 35317, "Side Story" },
                    { 35319, 35321, "Sequel" },
                    { 35319, 91706, "Alternative Version" },
                    { 35321, 35319, "Prequel" },
                    { 35321, 47248, "Sequel" },
                    { 35321, 91706, "Alternative Version" },
                    { 35609, 15, "Parent Story" },
                    { 35907, 3008, "Parent Story" },
                    { 36277, 13492, "Other" },
                    { 36729, 10010, "Alternative Version" },
                    { 36933, 52389, "Other" },
                    { 36933, 58193, "Other" },
                    { 37303, 22, "Alternative Version" },
                    { 37405, 21479, "Parent Story" },
                    { 37561, 1474, "Alternative Version" },
                    { 37683, 206, "Parent Story" },
                    { 37683, 99593, "Side Story" },
                    { 37701, 1551, "Parent Story" },
                    { 37701, 8773, "Parent Story" },
                    { 37701, 30723, "Parent Story" },
                    { 37755, 31079, "Prequel" },
                    { 37755, 39883, "Character" },
                    { 37755, 107295, "Side Story" },
                    { 37999, 19315, "Prequel" },
                    { 37999, 50161, "Side Story" },
                    { 39875, 1045, "Parent Story" },
                    { 39883, 37755, "Character" },
                    { 39883, 93353, "Spin-Off" },
                    { 39883, 102286, "Other" },
                    { 40053, 21479, "Parent Story" },
                    { 40225, 11, "Parent Story" },
                    { 40281, 21479, "Parent Story" },
                    { 40549, 11, "Parent Story" },
                    { 40549, 96770, "Alternative Version" },
                    { 41027, 21479, "Parent Story" },
                    { 41145, 166056, "Sequel" },
                    { 41145, 166058, "Alternative Version" },
                    { 41539, 34127, "Parent Story" },
                    { 41539, 135743, "Sequel" },
                    { 41835, 22519, "Parent Story" },
                    { 41865, 3008, "Parent Story" },
                    { 42439, 9736, "Parent Story" },
                    { 42439, 30725, "Side Story" },
                    { 42439, 97658, "Alternative Version" },
                    { 42439, 117379, "Side Story" },
                    { 42571, 206, "Side Story" },
                    { 42737, 11652, "Parent Story" },
                    { 42737, 85900, "Alternative Version" },
                    { 42755, 1639, "Alternative Version" },
                    { 43605, 12, "Parent Story" },
                    { 43607, 12, "Parent Story" },
                    { 43921, 21479, "Parent Story" },
                    { 43921, 52277, "Alternative Version" },
                    { 43921, 125770, "Alternative Version" },
                    { 43921, 125771, "Alternative Version" },
                    { 43921, 135893, "Alternative Version" },
                    { 44021, 1442, "Side Story" },
                    { 44227, 23751, "Prequel" },
                    { 44227, 108177, "Sequel" },
                    { 44319, 24457, "Alternative Version" },
                    { 44357, 703, "Parent Story" },
                    { 44357, 704, "Parent Story" },
                    { 44485, 64565, "Other" },
                    { 44485, 75055, "Spin-Off" },
                    { 44485, 81575, "Alternative Version" },
                    { 44485, 84427, "Side Story" },
                    { 44485, 87195, "Other" },
                    { 44485, 93979, "Spin-Off" },
                    { 44485, 96262, "Spin-Off" },
                    { 44485, 103392, "Spin-Off" },
                    { 44485, 115713, "Side Story" },
                    { 44485, 128691, "Sequel" },
                    { 44485, 134732, "Side Story" },
                    { 44485, 138078, "Spin-Off" },
                    { 44733, 21479, "Alternative Version" },
                    { 44733, 23718, "Prequel" },
                    { 44733, 75099, "Sequel" },
                    { 44933, 69371, "Alternative Version" },
                    { 44933, 69375, "Prequel" },
                    { 44933, 74859, "Prequel" },
                    { 44933, 81151, "Sequel" },
                    { 44933, 81153, "Spin-Off" },
                    { 44933, 125108, "Spin-Off" },
                    { 44933, 136106, "Spin-Off" },
                    { 45996, 26, "Parent Story" },
                    { 46010, 10, "Prequel" },
                    { 46010, 74339, "Other" },
                    { 46010, 94856, "Other" },
                    { 46222, 21479, "Parent Story" },
                    { 46582, 21479, "Parent Story" },
                    { 46604, 1517, "Parent Story" },
                    { 46604, 1630, "Parent Story" },
                    { 47102, 75053, "Other" },
                    { 47102, 118326, "Spin-Off" },
                    { 47248, 35321, "Prequel" },
                    { 47248, 91706, "Alternative Version" },
                    { 47363, 24561, "Prequel" },
                    { 47363, 86414, "Other" },
                    { 47533, 3008, "Parent Story" },
                    { 47533, 3009, "Parent Story" },
                    { 47551, 63547, "Sequel" },
                    { 47551, 132343, "Spin-Off" },
                    { 47551, 156258, "Alternative Setting" },
                    { 48321, 1023, "Alternative Setting" },
                    { 49305, 51755, "Alternative Version" },
                    { 49305, 68273, "Alternative Version" },
                    { 49305, 92826, "Spin-Off" },
                    { 49305, 99361, "Spin-Off" },
                    { 49547, 16816, "Alternative Version" },
                    { 49547, 34335, "Prequel" },
                    { 49547, 85707, "Sequel" },
                    { 49551, 1045, "Parent Story" },
                    { 49567, 51309, "Alternative Version" },
                    { 49567, 51313, "Alternative Version" },
                    { 49567, 62083, "Spin-Off" },
                    { 49567, 86353, "Side Story" },
                    { 49859, 698, "Alternative Version" },
                    { 50161, 37999, "Parent Story" },
                    { 51023, 51025, "Alternative Version" },
                    { 51025, 51023, "Alternative Version" },
                    { 51025, 87720, "Spin-Off" },
                    { 51309, 49567, "Alternative Version" },
                    { 51313, 49567, "Alternative Version" },
                    { 51755, 49305, "Alternative Version" },
                    { 52277, 43921, "Alternative Version" },
                    { 52277, 125770, "Sequel" },
                    { 52353, 13, "Parent Story" },
                    { 52353, 23251, "Alternative Setting" },
                    { 52389, 24294, "Parent Story" },
                    { 52389, 36933, "Parent Story" },
                    { 54627, 42, "Sequel" },
                    { 54697, 598, "Parent Story" },
                    { 54761, 1045, "Parent Story" },
                    { 55157, 70307, "Alternative Version" },
                    { 55867, 87678, "Alternative Version" },
                    { 55875, 21479, "Parent Story" },
                    { 56011, 671, "Parent Story" },
                    { 56169, 21479, "Parent Story" },
                    { 56725, 676, "Other" },
                    { 56725, 1639, "Other" },
                    { 56725, 3822, "Other" },
                    { 56725, 7747, "Other" },
                    { 56725, 14124, "Other" },
                    { 56725, 14956, "Other" },
                    { 56725, 17026, "Other" },
                    { 56725, 25096, "Other" },
                    { 56743, 57239, "Alternative Version" },
                    { 56743, 66433, "Side Story" },
                    { 56743, 78475, "Spin-Off" },
                    { 56743, 90180, "Spin-Off" },
                    { 56743, 103045, "Side Story" },
                    { 56743, 128368, "Alternative Version" },
                    { 56743, 138269, "Side Story" },
                    { 56743, 142916, "Side Story" },
                    { 56743, 158345, "Spin-Off" },
                    { 56743, 161010, "Alternative Setting" },
                    { 56743, 173417, "Side Story" },
                    { 57051, 872, "Parent Story" },
                    { 57095, 11, "Parent Story" },
                    { 57101, 69941, "Alternative Version" },
                    { 57239, 56743, "Alternative Version" },
                    { 57239, 128368, "Sequel" },
                    { 57249, 26178, "Sequel" },
                    { 57249, 119886, "Prequel" },
                    { 57765, 15, "Prequel" },
                    { 57897, 14377, "Prequel" },
                    { 57927, 13492, "Parent Story" },
                    { 58193, 31499, "Parent Story" },
                    { 58193, 36933, "Parent Story" },
                    { 58217, 1932, "Prequel" },
                    { 60553, 80385, "Alternative Version" },
                    { 60553, 89768, "Spin-Off" },
                    { 60553, 97200, "Spin-Off" },
                    { 60553, 106218, "Spin-Off" },
                    { 60553, 109014, "Spin-Off" },
                    { 60553, 114219, "Other" },
                    { 60553, 114664, "Spin-Off" },
                    { 60553, 118456, "Other" },
                    { 60553, 124804, "Side Story" },
                    { 60553, 133787, "Spin-Off" },
                    { 60553, 144387, "Spin-Off" },
                    { 60593, 21479, "Parent Story" },
                    { 60973, 33699, "Prequel" },
                    { 60973, 34127, "Alternative Version" },
                    { 60973, 104234, "Sequel" },
                    { 60975, 34127, "Alternative Version" },
                    { 60975, 60977, "Sequel" },
                    { 60975, 115017, "Prequel" },
                    { 60977, 34127, "Alternative Version" },
                    { 60977, 60975, "Prequel" },
                    { 60977, 93234, "Sequel" },
                    { 61959, 3006, "Parent Story" },
                    { 61959, 3578, "Other" },
                    { 61959, 142475, "Side Story" },
                    { 62083, 49567, "Parent Story" },
                    { 62393, 3537, "Parent Story" },
                    { 62393, 35003, "Parent Story" },
                    { 62671, 90309, "Prequel" },
                    { 62673, 24457, "Parent Story" },
                    { 62687, 19315, "Parent Story" },
                    { 63329, 24457, "Parent Story" },
                    { 63547, 47551, "Prequel" },
                    { 64565, 598, "Parent Story" },
                    { 64565, 44485, "Parent Story" },
                    { 65051, 31499, "Parent Story" },
                    { 65169, 1045, "Parent Story" },
                    { 65169, 14230, "Parent Story" },
                    { 65169, 14231, "Parent Story" },
                    { 65169, 24881, "Parent Story" },
                    { 65169, 27643, "Parent Story" },
                    { 65499, 19315, "Alternative Version" },
                    { 65499, 111453, "Alternative Version" },
                    { 65643, 8795, "Sequel" },
                    { 65669, 393, "Parent Story" },
                    { 65685, 86414, "Other" },
                    { 65869, 349, "Parent Story" },
                    { 65909, 24456, "Parent Story" },
                    { 66025, 1009, "Prequel" },
                    { 66161, 1639, "Prequel" },
                    { 66433, 56743, "Parent Story" },
                    { 66433, 71253, "Alternative Version" },
                    { 66695, 23751, "Parent Story" },
                    { 66695, 86670, "Other" },
                    { 66809, 5664, "Other" },
                    { 66809, 74157, "Other" },
                    { 66879, 86367, "Alternative Version" },
                    { 67019, 430, "Prequel" },
                    { 67019, 75053, "Other" },
                    { 67019, 86414, "Other" },
                    { 67019, 88032, "Other" },
                    { 67019, 116987, "Spin-Off" },
                    { 67297, 1046, "Prequel" },
                    { 67297, 124340, "Sequel" },
                    { 67545, 102286, "Other" },
                    { 67615, 67617, "Alternative Version" },
                    { 67617, 67615, "Alternative Version" },
                    { 67617, 108167, "Spin-Off" },
                    { 67617, 115900, "Spin-Off" },
                    { 67617, 123452, "Spin-Off" },
                    { 67617, 127222, "Other" },
                    { 67617, 132079, "Other" },
                    { 67617, 148724, "Spin-Off" },
                    { 68273, 49305, "Alternative Version" },
                    { 68983, 30591, "Alternative Version" },
                    { 68983, 30593, "Alternative Version" },
                    { 68983, 97060, "Prequel" },
                    { 68983, 146554, "Sequel" },
                    { 69073, 16816, "Prequel" },
                    { 69371, 44933, "Alternative Version" },
                    { 69371, 69375, "Prequel" },
                    { 69371, 81157, "Side Story" },
                    { 69371, 88478, "Side Story" },
                    { 69375, 44933, "Sequel" },
                    { 69375, 69371, "Sequel" },
                    { 69375, 74859, "Prequel" },
                    { 69415, 598, "Parent Story" },
                    { 69503, 90585, "Prequel" },
                    { 69503, 112322, "Sequel" },
                    { 69765, 16816, "Parent Story" },
                    { 69903, 598, "Sequel" },
                    { 69941, 57101, "Alternative Version" },
                    { 70117, 18162, "Alternative Version" },
                    { 70117, 28075, "Prequel" },
                    { 70251, 31499, "Other" },
                    { 70259, 70261, "Alternative Version" },
                    { 70259, 142765, "Side Story" },
                    { 70261, 70259, "Alternative Version" },
                    { 70261, 115498, "Spin-Off" },
                    { 70261, 125735, "Spin-Off" },
                    { 70261, 142765, "Alternative Version" },
                    { 70261, 145006, "Spin-Off" },
                    { 70261, 159387, "Side Story" },
                    { 70307, 55157, "Alternative Version" },
                    { 70751, 24457, "Parent Story" },
                    { 70815, 21, "Parent Story" },
                    { 71253, 66433, "Alternative Version" },
                    { 71821, 393, "Parent Story" },
                    { 72431, 30593, "Alternative Version" },
                    { 73115, 47, "Parent Story" },
                    { 73397, 22, "Parent Story" },
                    { 73631, 35243, "Parent Story" },
                    { 73781, 24457, "Parent Story" },
                    { 74157, 66809, "Other" },
                    { 74339, 9, "Prequel" },
                    { 74339, 46010, "Other" },
                    { 74339, 86232, "Side Story" },
                    { 74695, 74697, "Alternative Version" },
                    { 74695, 80719, "Sequel" },
                    { 74697, 74695, "Alternative Version" },
                    { 74697, 80719, "Alternative Version" },
                    { 74697, 89960, "Alternative Version" },
                    { 74697, 95243, "Side Story" },
                    { 74697, 99446, "Side Story" },
                    { 74697, 115765, "Other" },
                    { 74697, 124470, "Alternative Version" },
                    { 74697, 124743, "Spin-Off" },
                    { 74697, 152303, "Spin-Off" },
                    { 74697, 167582, "Alternative Version" },
                    { 74697, 170477, "Alternative Version" },
                    { 74847, 33327, "Parent Story" },
                    { 74859, 44933, "Sequel" },
                    { 74859, 69375, "Sequel" },
                    { 75051, 1505, "Parent Story" },
                    { 75051, 90908, "Sequel" },
                    { 75053, 8300, "Parent Story" },
                    { 75053, 35003, "Parent Story" },
                    { 75053, 47102, "Parent Story" },
                    { 75053, 67019, "Parent Story" },
                    { 75055, 44485, "Parent Story" },
                    { 75099, 21479, "Alternative Version" },
                    { 75099, 44733, "Prequel" },
                    { 75099, 75103, "Sequel" },
                    { 75101, 21479, "Alternative Version" },
                    { 75101, 75103, "Prequel" },
                    { 75101, 99386, "Sequel" },
                    { 75103, 21479, "Alternative Version" },
                    { 75103, 75099, "Prequel" },
                    { 75103, 75101, "Sequel" },
                    { 75493, 598, "Parent Story" },
                    { 75495, 598, "Parent Story" },
                    { 75497, 598, "Parent Story" },
                    { 75703, 872, "Parent Story" },
                    { 75719, 1474, "Parent Story" },
                    { 75723, 1475, "Parent Story" },
                    { 75723, 7658, "Parent Story" },
                    { 76319, 24457, "Parent Story" },
                    { 77213, 81611, "Other" },
                    { 77213, 83729, "Spin-Off" },
                    { 77213, 91562, "Sequel" },
                    { 77213, 94540, "Side Story" },
                    { 77237, 24294, "Parent Story" },
                    { 77239, 24294, "Parent Story" },
                    { 77273, 11, "Parent Story" },
                    { 77815, 33327, "Parent Story" },
                    { 77849, 10010, "Parent Story" },
                    { 78003, 598, "Parent Story" },
                    { 78183, 16816, "Parent Story" },
                    { 78475, 56743, "Parent Story" },
                    { 78717, 8558, "Alternative Version" },
                    { 78905, 16, "Parent Story" },
                    { 79133, 12336, "Parent Story" },
                    { 80163, 35243, "Parent Story" },
                    { 80223, 660, "Parent Story" },
                    { 80385, 60553, "Alternative Version" },
                    { 80435, 160, "Parent Story" },
                    { 80469, 26178, "Parent Story" },
                    { 80473, 31935, "Prequel" },
                    { 80719, 74695, "Prequel" },
                    { 80719, 74697, "Alternative Version" },
                    { 80719, 89960, "Sequel" },
                    { 80719, 99446, "Alternative Version" },
                    { 80909, 33327, "Alternative Version" },
                    { 81117, 33327, "Prequel" },
                    { 81117, 115800, "Side Story" },
                    { 81151, 44933, "Prequel" },
                    { 81151, 160723, "Sequel" },
                    { 81153, 44933, "Parent Story" },
                    { 81157, 69371, "Parent Story" },
                    { 81485, 16816, "Parent Story" },
                    { 81551, 16816, "Parent Story" },
                    { 81575, 2105, "Sequel" },
                    { 81575, 4101, "Alternative Version" },
                    { 81575, 44485, "Alternative Version" },
                    { 81611, 77213, "Parent Story" },
                    { 81667, 81669, "Alternative Version" },
                    { 81667, 169454, "Sequel" },
                    { 81669, 81667, "Alternative Version" },
                    { 81669, 116216, "Side Story" },
                    { 81669, 116651, "Spin-Off" },
                    { 81669, 117956, "Other" },
                    { 81669, 119696, "Alternative Version" },
                    { 81669, 169454, "Alternative Version" },
                    { 82283, 82285, "Alternative Version" },
                    { 82283, 82289, "Sequel" },
                    { 82285, 82283, "Alternative Version" },
                    { 82289, 82283, "Prequel" },
                    { 82795, 21479, "Parent Story" },
                    { 82795, 92625, "Alternative Version" },
                    { 82801, 698, "Parent Story" },
                    { 83187, 31499, "Parent Story" },
                    { 83257, 11, "Parent Story" },
                    { 83411, 728, "Sequel" },
                    { 83729, 77213, "Parent Story" },
                    { 83807, 11652, "Prequel" },
                    { 84427, 44485, "Parent Story" },
                    { 85033, 9977, "Other" },
                    { 85391, 9736, "Alternative Version" },
                    { 85391, 9889, "Prequel" },
                    { 85391, 29391, "Alternative Version" },
                    { 85391, 85393, "Sequel" },
                    { 85391, 159536, "Prequel" },
                    { 85393, 16168, "Alternative Version" },
                    { 85393, 30593, "Sequel" },
                    { 85393, 85391, "Prequel" },
                    { 85707, 16816, "Alternative Version" },
                    { 85707, 49547, "Prequel" },
                    { 85781, 173409, "Alternative Version" },
                    { 85884, 24457, "Parent Story" },
                    { 85900, 42737, "Alternative Version" },
                    { 85924, 1475, "Prequel" },
                    { 85931, 95212, "Other" },
                    { 86129, 11, "Parent Story" },
                    { 86232, 74339, "Parent Story" },
                    { 86336, 24822, "Parent Story" },
                    { 86353, 49567, "Parent Story" },
                    { 86353, 104624, "Alternative Version" },
                    { 86367, 66879, "Alternative Version" },
                    { 86414, 8795, "Parent Story" },
                    { 86414, 47363, "Parent Story" },
                    { 86414, 65685, "Parent Story" },
                    { 86414, 67019, "Parent Story" },
                    { 86670, 14893, "Parent Story" },
                    { 86670, 66695, "Other" },
                    { 86671, 42, "Parent Story" },
                    { 86769, 107562, "Alternative Version" },
                    { 86769, 110929, "Alternative Version" },
                    { 86844, 16168, "Parent Story" },
                    { 86972, 13, "Parent Story" },
                    { 87195, 44485, "Parent Story" },
                    { 87375, 25409, "Parent Story" },
                    { 87518, 9726, "Parent Story" },
                    { 87518, 117028, "Other" },
                    { 87623, 36, "Parent Story" },
                    { 87623, 598, "Parent Story" },
                    { 87678, 55867, "Alternative Version" },
                    { 87714, 11, "Parent Story" },
                    { 87720, 51025, "Parent Story" },
                    { 87725, 8773, "Other" },
                    { 87835, 1551, "Character" },
                    { 87835, 16942, "Parent Story" },
                    { 87866, 11, "Parent Story" },
                    { 88032, 598, "Parent Story" },
                    { 88032, 8300, "Parent Story" },
                    { 88032, 35003, "Parent Story" },
                    { 88032, 67019, "Parent Story" },
                    { 88100, 1057, "Alternative Version" },
                    { 88100, 5756, "Alternative Version" },
                    { 88100, 122365, "Other" },
                    { 88100, 132383, "Alternative Version" },
                    { 88233, 42, "Character" },
                    { 88233, 796, "Prequel" },
                    { 88233, 16038, "Character" },
                    { 88478, 69371, "Parent Story" },
                    { 88679, 8157, "Parent Story" },
                    { 88923, 96528, "Alternative Version" },
                    { 88923, 108240, "Spin-Off" },
                    { 88923, 110615, "Side Story" },
                    { 88923, 125234, "Side Story" },
                    { 88923, 128632, "Spin-Off" },
                    { 88930, 98436, "Alternative Version" },
                    { 88930, 114586, "Spin-Off" },
                    { 89357, 96371, "Alternative Version" },
                    { 89357, 108725, "Spin-Off" },
                    { 89357, 123992, "Sequel" },
                    { 89357, 125053, "Other" },
                    { 89357, 154545, "Prequel" },
                    { 89364, 24457, "Parent Story" },
                    { 89365, 24457, "Parent Story" },
                    { 89366, 24457, "Parent Story" },
                    { 89610, 12709, "Prequel" },
                    { 89734, 42, "Prequel" },
                    { 89734, 54627, "Character" },
                    { 89734, 106285, "Spin-Off" },
                    { 89734, 173172, "Spin-Off" },
                    { 89768, 60553, "Parent Story" },
                    { 89768, 97722, "Alternative Version" },
                    { 89768, 114989, "Alternative Version" },
                    { 89960, 74697, "Alternative Version" },
                    { 89960, 80719, "Prequel" },
                    { 89960, 124470, "Sequel" },
                    { 90016, 24457, "Parent Story" },
                    { 90065, 438, "Parent Story" },
                    { 90117, 90118, "Alternative Version" },
                    { 90118, 90117, "Alternative Version" },
                    { 90180, 56743, "Parent Story" },
                    { 90309, 24457, "Prequel" },
                    { 90309, 62671, "Sequel" },
                    { 90322, 14893, "Parent Story" },
                    { 90324, 23751, "Parent Story" },
                    { 90408, 201, "Alternative Version" },
                    { 90531, 11, "Parent Story" },
                    { 90585, 21307, "Prequel" },
                    { 90585, 69503, "Sequel" },
                    { 90687, 24456, "Sequel" },
                    { 90757, 3, "Parent Story" },
                    { 90870, 16816, "Parent Story" },
                    { 90883, 12709, "Alternative Setting" },
                    { 90884, 12709, "Parent Story" },
                    { 90885, 8773, "Parent Story" },
                    { 90885, 12709, "Parent Story" },
                    { 90908, 75051, "Prequel" },
                    { 90993, 94175, "Alternative Version" },
                    { 91209, 44, "Parent Story" },
                    { 91443, 349, "Alternative Version" },
                    { 91443, 91444, "Sequel" },
                    { 91444, 1936, "Alternative Version" },
                    { 91444, 91443, "Prequel" },
                    { 91562, 77213, "Prequel" },
                    { 91706, 35319, "Alternative Version" },
                    { 91706, 35321, "Alternative Version" },
                    { 91706, 47248, "Alternative Version" },
                    { 91734, 3510, "Alternative Version" },
                    { 91971, 598, "Parent Story" },
                    { 92203, 1342, "Alternative Version" },
                    { 92286, 11, "Parent Story" },
                    { 92299, 2, "Other" },
                    { 92625, 82795, "Alternative Version" },
                    { 92826, 49305, "Parent Story" },
                    { 92833, 1474, "Character" },
                    { 92833, 7658, "Character" },
                    { 92833, 8558, "Character" },
                    { 92833, 8773, "Character" },
                    { 92833, 98118, "Character" },
                    { 92838, 7666, "Character" },
                    { 92838, 7759, "Character" },
                    { 92839, 8571, "Character" },
                    { 92839, 8772, "Character" },
                    { 92905, 9711, "Sequel" },
                    { 92906, 9711, "Parent Story" },
                    { 93027, 9711, "Alternative Version" },
                    { 93088, 1551, "Alternative Version" },
                    { 93097, 14893, "Parent Story" },
                    { 93234, 34127, "Alternative Version" },
                    { 93234, 60977, "Prequel" },
                    { 93234, 101482, "Sequel" },
                    { 93314, 103647, "Alternative Version" },
                    { 93314, 108306, "Alternative Version" },
                    { 93326, 9889, "Parent Story" },
                    { 93353, 39883, "Parent Story" },
                    { 93408, 97524, "Spin-Off" },
                    { 93408, 106813, "Sequel" },
                    { 93595, 43, "Alternative Version" },
                    { 93691, 93692, "Alternative Setting" },
                    { 93692, 93691, "Alternative Setting" },
                    { 93692, 104064, "Alternative Version" },
                    { 93698, 24822, "Parent Story" },
                    { 93820, 438, "Alternative Version" },
                    { 93831, 9977, "Parent Story" },
                    { 93979, 44485, "Parent Story" },
                    { 93982, 7887, "Parent Story" },
                    { 94175, 90993, "Alternative Version" },
                    { 94175, 117028, "Other" },
                    { 94392, 16816, "Parent Story" },
                    { 94533, 13, "Parent Story" },
                    { 94534, 13, "Parent Story" },
                    { 94540, 77213, "Parent Story" },
                    { 94838, 438, "Parent Story" },
                    { 94856, 46010, "Parent Story" },
                    { 94864, 25409, "Alternative Version" },
                    { 94865, 42, "Other" },
                    { 94865, 438, "Other" },
                    { 94865, 733, "Other" },
                    { 94865, 1298, "Other" },
                    { 94865, 1505, "Other" },
                    { 94865, 2845, "Other" },
                    { 94865, 3084, "Other" },
                    { 94865, 26123, "Other" },
                    { 94865, 95746, "Other" },
                    { 95016, 115579, "Other" },
                    { 95091, 1474, "Parent Story" },
                    { 95091, 1639, "Parent Story" },
                    { 95210, 11, "Prequel" },
                    { 95210, 98462, "Side Story" },
                    { 95210, 106113, "Alternative Version" },
                    { 95210, 106156, "Spin-Off" },
                    { 95210, 160786, "Sequel" },
                    { 95212, 24033, "Parent Story" },
                    { 95212, 85931, "Other" },
                    { 95212, 96597, "Alternative Version" },
                    { 95212, 133638, "Other" },
                    { 95243, 74697, "Parent Story" },
                    { 95243, 120412, "Alternative Version" },
                    { 95746, 94865, "Other" },
                    { 96200, 11, "Parent Story" },
                    { 96262, 44485, "Parent Story" },
                    { 96371, 89357, "Alternative Version" },
                    { 96371, 142246, "Sequel" },
                    { 96383, 7747, "Parent Story" },
                    { 96389, 7658, "Alternative Version" },
                    { 96390, 9977, "Parent Story" },
                    { 96448, 3822, "Parent Story" },
                    { 96528, 88923, "Alternative Version" },
                    { 96597, 95212, "Alternative Version" },
                    { 96692, 24033, "Parent Story" },
                    { 96762, 11, "Parent Story" },
                    { 96763, 11, "Parent Story" },
                    { 96764, 11, "Parent Story" },
                    { 96765, 11, "Parent Story" },
                    { 96766, 11, "Parent Story" },
                    { 96767, 11, "Parent Story" },
                    { 96768, 11, "Parent Story" },
                    { 96769, 11, "Parent Story" },
                    { 96770, 11, "Parent Story" },
                    { 96770, 40549, "Alternative Version" },
                    { 96792, 121118, "Side Story" },
                    { 96792, 121119, "Side Story" },
                    { 96792, 131706, "Side Story" },
                    { 96792, 133053, "Side Story" },
                    { 96792, 140256, "Spin-Off" },
                    { 96792, 143972, "Other" },
                    { 96792, 153037, "Alternative Version" },
                    { 96792, 160805, "Alternative Version" },
                    { 97057, 16456, "Alternative Version" },
                    { 97057, 158167, "Other" },
                    { 97060, 16168, "Prequel" },
                    { 97060, 68983, "Sequel" },
                    { 97090, 106810, "Alternative Version" },
                    { 97090, 165525, "Sequel" },
                    { 97200, 60553, "Parent Story" },
                    { 97200, 114664, "Alternative Version" },
                    { 97324, 1224, "Parent Story" },
                    { 97524, 93408, "Parent Story" },
                    { 97658, 42439, "Alternative Version" },
                    { 97664, 9889, "Parent Story" },
                    { 97722, 89768, "Alternative Version" },
                    { 97722, 114989, "Sequel" },
                    { 98118, 8773, "Prequel" },
                    { 98118, 16943, "Alternative Version" },
                    { 98118, 92833, "Character" },
                    { 98118, 131678, "Sequel" },
                    { 98425, 107525, "Other" },
                    { 98425, 108274, "Other" },
                    { 98436, 88930, "Alternative Version" },
                    { 98462, 11, "Parent Story" },
                    { 98462, 95210, "Parent Story" },
                    { 98462, 153000, "Alternative Version" },
                    { 98480, 110390, "Alternative Version" },
                    { 98567, 32799, "Prequel" },
                    { 98567, 161080, "Side Story" },
                    { 98583, 34127, "Parent Story" },
                    { 99361, 49305, "Parent Story" },
                    { 99386, 21479, "Alternative Version" },
                    { 99386, 75101, "Prequel" },
                    { 99386, 131396, "Alternative Version" },
                    { 99386, 158357, "Sequel" },
                    { 99446, 74697, "Parent Story" },
                    { 99446, 80719, "Alternative Version" },
                    { 99593, 37683, "Parent Story" },
                    { 99614, 698, "Parent Story" },
                    { 99758, 21479, "Parent Story" },
                    { 99853, 24822, "Parent Story" },
                    { 99891, 103144, "Alternative Version" },
                    { 99891, 127130, "Spin-Off" },
                    { 100039, 728, "Parent Story" },
                    { 100790, 25409, "Parent Story" },
                    { 101476, 121357, "Alternative Version" },
                    { 101482, 34127, "Alternative Version" },
                    { 101482, 93234, "Prequel" },
                    { 101482, 119295, "Sequel" },
                    { 101662, 114925, "Alternative Version" },
                    { 101956, 1474, "Alternative Version" },
                    { 102286, 733, "Parent Story" },
                    { 102286, 1414, "Parent Story" },
                    { 102286, 5664, "Parent Story" },
                    { 102286, 10010, "Parent Story" },
                    { 102286, 31499, "Parent Story" },
                    { 102286, 39883, "Parent Story" },
                    { 102286, 67545, "Parent Story" },
                    { 102484, 21479, "Parent Story" },
                    { 102569, 21, "Prequel" },
                    { 102667, 110288, "Alternative Version" },
                    { 102667, 130174, "Spin-Off" },
                    { 102667, 147192, "Spin-Off" },
                    { 102702, 111587, "Alternative Version" },
                    { 102702, 130370, "Spin-Off" },
                    { 102846, 7887, "Other" },
                    { 102847, 7887, "Alternative Version" },
                    { 103000, 12, "Parent Story" },
                    { 103045, 56743, "Parent Story" },
                    { 103045, 104897, "Alternative Version" },
                    { 103047, 42, "Parent Story" },
                    { 103078, 103392, "Alternative Version" },
                    { 103144, 99891, "Alternative Version" },
                    { 103244, 21479, "Parent Story" },
                    { 103244, 116786, "Side Story" },
                    { 103244, 116788, "Sequel" },
                    { 103392, 44485, "Parent Story" },
                    { 103392, 103078, "Alternative Version" },
                    { 103647, 93314, "Alternative Version" },
                    { 103647, 108306, "Alternative Version" },
                    { 103701, 115996, "Alternative Setting" },
                    { 103761, 116772, "Alternative Version" },
                    { 103807, 21479, "Parent Story" },
                    { 103807, 118123, "Sequel" },
                    { 103808, 21479, "Parent Story" },
                    { 103897, 122464, "Side Story" },
                    { 103907, 24561, "Sequel" },
                    { 103910, 728, "Parent Story" },
                    { 104064, 93692, "Alternative Version" },
                    { 104064, 117445, "Side Story" },
                    { 104234, 34127, "Alternative Version" },
                    { 104234, 60973, "Prequel" },
                    { 104234, 115017, "Sequel" },
                    { 104330, 24822, "Parent Story" },
                    { 104333, 24822, "Parent Story" },
                    { 104509, 24457, "Parent Story" },
                    { 104584, 122943, "Alternative Version" },
                    { 104624, 86353, "Alternative Version" },
                    { 104670, 1474, "Other" },
                    { 104841, 214, "Parent Story" },
                    { 104841, 147111, "Other" },
                    { 104841, 161565, "Other" },
                    { 104897, 103045, "Alternative Version" },
                    { 104925, 24457, "Parent Story" },
                    { 105125, 12, "Parent Story" },
                    { 105579, 45, "Prequel" },
                    { 105837, 22, "Prequel" },
                    { 106113, 95210, "Alternative Version" },
                    { 106156, 95210, "Parent Story" },
                    { 106218, 60553, "Parent Story" },
                    { 106285, 89734, "Parent Story" },
                    { 106285, 117544, "Sequel" },
                    { 106374, 24457, "Parent Story" },
                    { 106602, 12, "Parent Story" },
                    { 106677, 2, "Parent Story" },
                    { 106755, 116943, "Alternative Version" },
                    { 106755, 155020, "Side Story" },
                    { 106764, 2845, "Parent Story" },
                    { 106810, 97090, "Alternative Version" },
                    { 106813, 93408, "Prequel" },
                    { 107295, 37755, "Parent Story" },
                    { 107339, 114393, "Alternative Version" },
                    { 107525, 98425, "Parent Story" },
                    { 107562, 86769, "Alternative Version" },
                    { 108166, 108167, "Alternative Version" },
                    { 108167, 67617, "Parent Story" },
                    { 108167, 108166, "Alternative Version" },
                    { 108177, 44227, "Prequel" },
                    { 108177, 159958, "Sequel" },
                    { 108199, 108406, "Sequel" },
                    { 108199, 126738, "Alternative Version" },
                    { 108240, 88923, "Parent Story" },
                    { 108274, 98425, "Parent Story" },
                    { 108306, 93314, "Alternative Version" },
                    { 108306, 103647, "Alternative Version" },
                    { 108406, 108199, "Prequel" },
                    { 108406, 126738, "Alternative Version" },
                    { 108461, 14, "Other" },
                    { 108461, 598, "Parent Story" },
                    { 108530, 34127, "Parent Story" },
                    { 108576, 792, "Character" },
                    { 108725, 89357, "Parent Story" },
                    { 109014, 60553, "Parent Story" },
                    { 109014, 133788, "Alternative Version" },
                    { 109213, 1061, "Parent Story" },
                    { 109214, 1061, "Parent Story" },
                    { 109215, 1061, "Parent Story" },
                    { 109216, 1061, "Parent Story" },
                    { 109217, 438, "Character" },
                    { 109217, 1061, "Parent Story" },
                    { 109217, 110645, "Sequel" },
                    { 109947, 111225, "Alternative Version" },
                    { 110288, 102667, "Alternative Version" },
                    { 110288, 129262, "Spin-Off" },
                    { 110390, 25409, "Alternative Setting" },
                    { 110390, 98480, "Alternative Version" },
                    { 110390, 128837, "Alternative Version" },
                    { 110590, 42, "Parent Story" },
                    { 110591, 42, "Parent Story" },
                    { 110615, 88923, "Parent Story" },
                    { 110615, 112907, "Alternative Version" },
                    { 110644, 1061, "Parent Story" },
                    { 110645, 109217, "Prequel" },
                    { 110668, 8157, "Prequel" },
                    { 110830, 13, "Parent Story" },
                    { 110898, 1045, "Sequel" },
                    { 110929, 86769, "Alternative Version" },
                    { 111192, 393, "Parent Story" },
                    { 111192, 17149, "Parent Story" },
                    { 111225, 109947, "Alternative Version" },
                    { 111453, 19315, "Alternative Version" },
                    { 111453, 65499, "Alternative Version" },
                    { 111453, 113275, "Prequel" },
                    { 111453, 114927, "Spin-Off" },
                    { 111587, 102702, "Alternative Version" },
                    { 111710, 8773, "Sequel" },
                    { 111970, 111971, "Prequel" },
                    { 111971, 9736, "Alternative Setting" },
                    { 111971, 111970, "Sequel" },
                    { 112031, 1023, "Parent Story" },
                    { 112318, 134556, "Spin-Off" },
                    { 112318, 134557, "Side Story" },
                    { 112318, 157641, "Side Story" },
                    { 112322, 69503, "Prequel" },
                    { 112744, 1061, "Parent Story" },
                    { 112807, 151029, "Character" },
                    { 112907, 110615, "Alternative Version" },
                    { 113010, 14893, "Alternative Version" },
                    { 113138, 115710, "Prequel" },
                    { 113138, 133047, "Side Story" },
                    { 113138, 133048, "Side Story" },
                    { 113275, 19315, "Alternative Version" },
                    { 113275, 111453, "Sequel" },
                    { 113491, 21479, "Parent Story" },
                    { 113839, 16816, "Parent Story" },
                    { 113839, 126738, "Parent Story" },
                    { 114175, 114279, "Alternative Version" },
                    { 114175, 166574, "Spin-Off" },
                    { 114219, 60553, "Parent Story" },
                    { 114219, 118456, "Sequel" },
                    { 114227, 556, "Alternative Version" },
                    { 114227, 557, "Prequel" },
                    { 114279, 114175, "Alternative Version" },
                    { 114372, 15530, "Other" },
                    { 114379, 1061, "Parent Story" },
                    { 114393, 107339, "Alternative Version" },
                    { 114435, 1551, "Parent Story" },
                    { 114548, 122473, "Other" },
                    { 114586, 88930, "Parent Story" },
                    { 114664, 97200, "Alternative Version" },
                    { 114679, 13492, "Parent Story" },
                    { 114701, 598, "Prequel" },
                    { 114745, 144695, "Spin-Off" },
                    { 114745, 153082, "Spin-Off" },
                    { 114745, 154487, "Alternative Version" },
                    { 114745, 174341, "Spin-Off" },
                    { 114745, 174418, "Spin-Off" },
                    { 114760, 13, "Parent Story" },
                    { 114779, 122650, "Alternative Version" },
                    { 114787, 25409, "Prequel" },
                    { 114862, 393, "Parent Story" },
                    { 114892, 598, "Parent Story" },
                    { 114925, 101662, "Alternative Version" },
                    { 114927, 111453, "Parent Story" },
                    { 114989, 89768, "Alternative Version" },
                    { 114989, 97722, "Prequel" },
                    { 115017, 34127, "Alternative Version" },
                    { 115017, 60975, "Sequel" },
                    { 115017, 104234, "Prequel" },
                    { 115498, 70261, "Parent Story" },
                    { 115579, 95016, "Other" },
                    { 115627, 13, "Other" },
                    { 115710, 113138, "Sequel" },
                    { 115710, 146643, "Side Story" },
                    { 115710, 167027, "Alternative Version" },
                    { 115713, 44485, "Parent Story" },
                    { 115765, 74697, "Parent Story" },
                    { 115774, 24457, "Alternative Version" },
                    { 115774, 139665, "Side Story" },
                    { 115792, 11, "Parent Story" },
                    { 115800, 81117, "Parent Story" },
                    { 115900, 67617, "Parent Story" },
                    { 115922, 119022, "Alternative Version" },
                    { 115922, 131215, "Spin-Off" },
                    { 115922, 170680, "Spin-Off" },
                    { 115996, 103701, "Alternative Setting" },
                    { 116216, 81669, "Parent Story" },
                    { 116463, 598, "Parent Story" },
                    { 116651, 81669, "Parent Story" },
                    { 116678, 31939, "Side Story" },
                    { 116678, 168250, "Side Story" },
                    { 116772, 103761, "Alternative Version" },
                    { 116778, 140150, "Side Story" },
                    { 116786, 103244, "Parent Story" },
                    { 116788, 103244, "Prequel" },
                    { 116880, 167571, "Side Story" },
                    { 116905, 12, "Parent Story" },
                    { 116943, 106755, "Alternative Version" },
                    { 116987, 67019, "Parent Story" },
                    { 117028, 9726, "Other" },
                    { 117028, 14893, "Parent Story" },
                    { 117028, 15200, "Other" },
                    { 117028, 18161, "Other" },
                    { 117028, 18162, "Other" },
                    { 117028, 21115, "Other" },
                    { 117028, 87518, "Other" },
                    { 117028, 94175, "Other" },
                    { 117028, 122943, "Other" },
                    { 117050, 31499, "Parent Story" },
                    { 117130, 1045, "Parent Story" },
                    { 117130, 123901, "Sequel" },
                    { 117379, 42439, "Parent Story" },
                    { 117445, 104064, "Parent Story" },
                    { 117544, 106285, "Prequel" },
                    { 117544, 133542, "Sequel" },
                    { 117572, 1061, "Parent Story" },
                    { 117692, 117693, "Alternative Version" },
                    { 117693, 117692, "Alternative Version" },
                    { 117695, 792, "Parent Story" },
                    { 117886, 120548, "Alternative Version" },
                    { 117956, 81669, "Parent Story" },
                    { 118108, 118251, "Alternative Version" },
                    { 118123, 21479, "Parent Story" },
                    { 118123, 103807, "Prequel" },
                    { 118251, 118108, "Alternative Version" },
                    { 118326, 47102, "Parent Story" },
                    { 118456, 60553, "Parent Story" },
                    { 118456, 114219, "Prequel" },
                    { 118522, 15530, "Alternative Version" },
                    { 118801, 24822, "Parent Story" },
                    { 119022, 115922, "Alternative Version" },
                    { 119161, 136660, "Side Story" },
                    { 119161, 165445, "Side Story" },
                    { 119184, 121496, "Alternative Version" },
                    { 119184, 155115, "Side Story" },
                    { 119295, 34127, "Alternative Version" },
                    { 119295, 101482, "Prequel" },
                    { 119295, 119296, "Sequel" },
                    { 119296, 34127, "Alternative Version" },
                    { 119296, 119295, "Prequel" },
                    { 119296, 135740, "Sequel" },
                    { 119385, 1551, "Parent Story" },
                    { 119534, 436, "Parent Story" },
                    { 119688, 7658, "Alternative Version" },
                    { 119696, 81669, "Alternative Version" },
                    { 119852, 35243, "Parent Story" },
                    { 119886, 57249, "Sequel" },
                    { 119908, 11, "Parent Story" },
                    { 119908, 151675, "Alternative Version" },
                    { 120401, 13, "Other" },
                    { 120412, 95243, "Alternative Version" },
                    { 120548, 117886, "Alternative Version" },
                    { 120656, 13, "Parent Story" },
                    { 121118, 96792, "Parent Story" },
                    { 121119, 96792, "Parent Story" },
                    { 121357, 101476, "Alternative Version" },
                    { 121496, 119184, "Alternative Version" },
                    { 121496, 155115, "Alternative Version" },
                    { 121496, 172429, "Sequel" },
                    { 121505, 1026, "Sequel" },
                    { 121505, 1028, "Prequel" },
                    { 121951, 1061, "Parent Story" },
                    { 122058, 131030, "Alternative Version" },
                    { 122105, 22519, "Parent Story" },
                    { 122239, 1046, "Parent Story" },
                    { 122305, 13, "Parent Story" },
                    { 122365, 88100, "Other" },
                    { 122464, 103897, "Parent Story" },
                    { 122473, 14, "Parent Story" },
                    { 122473, 598, "Parent Story" },
                    { 122473, 114548, "Parent Story" },
                    { 122557, 34127, "Parent Story" },
                    { 122557, 133004, "Alternative Version" },
                    { 122650, 114779, "Alternative Version" },
                    { 122892, 9977, "Parent Story" },
                    { 122943, 104584, "Alternative Version" },
                    { 122943, 117028, "Other" },
                    { 123157, 1023, "Parent Story" },
                    { 123318, 123613, "Parent Story" },
                    { 123319, 123613, "Parent Story" },
                    { 123452, 67617, "Parent Story" },
                    { 123456, 144724, "Alternative Version" },
                    { 123613, 123318, "Spin-Off" },
                    { 123613, 123319, "Spin-Off" },
                    { 123613, 130491, "Spin-Off" },
                    { 123613, 135698, "Spin-Off" },
                    { 123901, 1045, "Parent Story" },
                    { 123901, 117130, "Prequel" },
                    { 123992, 89357, "Prequel" },
                    { 123992, 142246, "Alternative Version" },
                    { 124085, 165829, "Side Story" },
                    { 124182, 135242, "Sequel" },
                    { 124182, 160723, "Prequel" },
                    { 124182, 169730, "Alternative Version" },
                    { 124183, 135242, "Prequel" },
                    { 124183, 169728, "Sequel" },
                    { 124183, 169730, "Alternative Version" },
                    { 124305, 126487, "Alternative Version" },
                    { 124340, 67297, "Prequel" },
                    { 124470, 74697, "Alternative Version" },
                    { 124470, 89960, "Prequel" },
                    { 124470, 167582, "Sequel" },
                    { 124619, 22519, "Parent Story" },
                    { 124620, 22519, "Parent Story" },
                    { 124629, 155874, "Sequel" },
                    { 124629, 169726, "Alternative Version" },
                    { 124629, 169728, "Prequel" },
                    { 124743, 74697, "Parent Story" },
                    { 124776, 3510, "Alternative Version" },
                    { 124776, 91734, "Alternative Version" },
                    { 124804, 60553, "Parent Story" },
                    { 124937, 12, "Parent Story" },
                    { 125053, 89357, "Parent Story" },
                    { 125108, 44933, "Parent Story" },
                    { 125234, 88923, "Parent Story" },
                    { 125236, 24822, "Parent Story" },
                    { 125735, 70261, "Parent Story" },
                    { 125767, 21479, "Alternative Version" },
                    { 125770, 43921, "Alternative Version" },
                    { 125770, 52277, "Prequel" },
                    { 125770, 125771, "Sequel" },
                    { 125771, 43921, "Alternative Version" },
                    { 125771, 125770, "Prequel" },
                    { 125771, 135893, "Sequel" },
                    { 126146, 170166, "Spin-Off" },
                    { 126146, 172324, "Side Story" },
                    { 126241, 14230, "Sequel" },
                    { 126241, 170289, "Prequel" },
                    { 126287, 164432, "Other" },
                    { 126287, 169340, "Prequel" },
                    { 126487, 124305, "Alternative Version" },
                    { 126522, 161679, "Alternative Version" },
                    { 126738, 108199, "Alternative Version" },
                    { 126738, 108406, "Alternative Version" },
                    { 126738, 113839, "Character" },
                    { 127114, 13, "Parent Story" },
                    { 127114, 128594, "Alternative Version" },
                    { 127130, 99891, "Parent Story" },
                    { 127222, 67617, "Parent Story" },
                    { 127781, 134946, "Alternative Version" },
                    { 127907, 149898, "Character" },
                    { 127907, 154021, "Spin-Off" },
                    { 127907, 169783, "Spin-Off" },
                    { 128131, 3378, "Prequel" },
                    { 128368, 56743, "Alternative Version" },
                    { 128368, 57239, "Prequel" },
                    { 128594, 13, "Other" },
                    { 128594, 127114, "Alternative Version" },
                    { 128632, 88923, "Parent Story" },
                    { 128691, 44485, "Prequel" },
                    { 128694, 135545, "Alternative Version" },
                    { 128837, 110390, "Alternative Version" },
                    { 129262, 110288, "Parent Story" },
                    { 129262, 130174, "Alternative Version" },
                    { 130174, 102667, "Parent Story" },
                    { 130174, 129262, "Alternative Version" },
                    { 130314, 34127, "Prequel" },
                    { 130370, 102702, "Parent Story" },
                    { 130491, 123613, "Parent Story" },
                    { 131030, 122058, "Alternative Version" },
                    { 131041, 152709, "Alternative Version" },
                    { 131084, 642, "Parent Story" },
                    { 131215, 115922, "Parent Story" },
                    { 131334, 131487, "Alternative Version" },
                    { 131334, 133498, "Character" },
                    { 131334, 171758, "Spin-Off" },
                    { 131334, 172069, "Side Story" },
                    { 131396, 99386, "Alternative Version" },
                    { 131487, 131334, "Alternative Version" },
                    { 131678, 98118, "Prequel" },
                    { 131706, 96792, "Parent Story" },
                    { 131924, 172053, "Prequel" },
                    { 132079, 67617, "Parent Story" },
                    { 132100, 1061, "Parent Story" },
                    { 132335, 21, "Parent Story" },
                    { 132343, 47551, "Parent Story" },
                    { 132383, 88100, "Alternative Version" },
                    { 132500, 132505, "Alternative Version" },
                    { 132505, 132500, "Alternative Version" },
                    { 132537, 9736, "Parent Story" },
                    { 132966, 26178, "Parent Story" },
                    { 133004, 122557, "Alternative Version" },
                    { 133005, 34127, "Parent Story" },
                    { 133005, 134408, "Alternative Version" },
                    { 133047, 113138, "Parent Story" },
                    { 133048, 113138, "Parent Story" },
                    { 133053, 96792, "Parent Story" },
                    { 133167, 152303, "Alternative Version" },
                    { 133341, 1061, "Parent Story" },
                    { 133342, 1061, "Parent Story" },
                    { 133343, 1061, "Parent Story" },
                    { 133352, 136856, "Alternative Version" },
                    { 133498, 131334, "Character" },
                    { 133521, 1045, "Parent Story" },
                    { 133542, 117544, "Prequel" },
                    { 133542, 146846, "Sequel" },
                    { 133638, 32913, "Parent Story" },
                    { 133638, 95212, "Parent Story" },
                    { 133787, 60553, "Parent Story" },
                    { 133788, 109014, "Alternative Version" },
                    { 134341, 137242, "Alternative Version" },
                    { 134341, 149334, "Alternative Version" },
                    { 134408, 133005, "Alternative Version" },
                    { 134556, 112318, "Parent Story" },
                    { 134557, 112318, "Parent Story" },
                    { 134732, 44485, "Parent Story" },
                    { 134946, 127781, "Alternative Version" },
                    { 135181, 5177, "Alternative Version" },
                    { 135181, 18254, "Sequel" },
                    { 135242, 124182, "Prequel" },
                    { 135242, 124183, "Sequel" },
                    { 135242, 169730, "Alternative Version" },
                    { 135262, 34127, "Parent Story" },
                    { 135545, 128694, "Alternative Version" },
                    { 135567, 15200, "Alternative Version" },
                    { 135698, 123613, "Parent Story" },
                    { 135740, 34127, "Alternative Version" },
                    { 135740, 119296, "Prequel" },
                    { 135740, 135741, "Sequel" },
                    { 135741, 34127, "Alternative Version" },
                    { 135741, 135740, "Prequel" },
                    { 135741, 135742, "Sequel" },
                    { 135742, 34127, "Alternative Version" },
                    { 135742, 135741, "Prequel" },
                    { 135742, 157223, "Sequel" },
                    { 135743, 41539, "Prequel" },
                    { 135893, 43921, "Alternative Version" },
                    { 135893, 125771, "Prequel" },
                    { 136106, 44933, "Parent Story" },
                    { 136660, 119161, "Parent Story" },
                    { 136856, 133352, "Alternative Version" },
                    { 137242, 134341, "Alternative Version" },
                    { 137358, 5177, "Parent Story" },
                    { 137967, 698, "Other" },
                    { 138078, 44485, "Parent Story" },
                    { 138269, 56743, "Parent Story" },
                    { 138269, 141272, "Alternative Version" },
                    { 138481, 146732, "Alternative Version" },
                    { 138915, 143426, "Alternative Version" },
                    { 138915, 162007, "Alternative Version" },
                    { 139018, 351, "Parent Story" },
                    { 139066, 42, "Parent Story" },
                    { 139152, 12, "Prequel" },
                    { 139629, 25515, "Prequel" },
                    { 139665, 115774, "Parent Story" },
                    { 139761, 153622, "Alternative Version" },
                    { 139972, 13, "Other" },
                    { 140150, 116778, "Parent Story" },
                    { 140245, 438, "Parent Story" },
                    { 140247, 671, "Parent Story" },
                    { 140256, 96792, "Parent Story" },
                    { 140256, 143972, "Other" },
                    { 140901, 676, "Prequel" },
                    { 141272, 138269, "Alternative Version" },
                    { 141501, 13, "Parent Story" },
                    { 141511, 13, "Parent Story" },
                    { 141885, 32913, "Parent Story" },
                    { 141953, 21479, "Alternative Version" },
                    { 141959, 25, "Parent Story" },
                    { 142246, 96371, "Prequel" },
                    { 142246, 123992, "Alternative Version" },
                    { 142475, 61959, "Parent Story" },
                    { 142551, 3006, "Parent Story" },
                    { 142551, 159777, "Alternative Version" },
                    { 142552, 3009, "Parent Story" },
                    { 142617, 438, "Parent Story" },
                    { 142617, 5733, "Parent Story" },
                    { 142765, 70259, "Parent Story" },
                    { 142765, 70261, "Alternative Version" },
                    { 142771, 13, "Parent Story" },
                    { 142772, 13, "Parent Story" },
                    { 142916, 56743, "Parent Story" },
                    { 143426, 138915, "Alternative Version" },
                    { 143426, 162007, "Alternative Version" },
                    { 143881, 170875, "Sequel" },
                    { 143972, 96792, "Parent Story" },
                    { 143972, 140256, "Other" },
                    { 144387, 60553, "Parent Story" },
                    { 144387, 145444, "Alternative Version" },
                    { 144695, 114745, "Parent Story" },
                    { 144724, 123456, "Alternative Version" },
                    { 144847, 24822, "Parent Story" },
                    { 145006, 70261, "Parent Story" },
                    { 145250, 26, "Parent Story" },
                    { 145352, 23869, "Alternative Version" },
                    { 145357, 598, "Parent Story" },
                    { 145444, 144387, "Alternative Version" },
                    { 146284, 35243, "Parent Story" },
                    { 146520, 1474, "Alternative Version" },
                    { 146554, 68983, "Prequel" },
                    { 146643, 115710, "Parent Story" },
                    { 146732, 138481, "Alternative Version" },
                    { 146846, 133542, "Prequel" },
                    { 146846, 164378, "Sequel" },
                    { 147070, 2845, "Parent Story" },
                    { 147111, 104841, "Other" },
                    { 147111, 161565, "Prequel" },
                    { 147192, 102667, "Parent Story" },
                    { 148251, 438, "Parent Story" },
                    { 148473, 9736, "Alternative Version" },
                    { 148724, 67617, "Parent Story" },
                    { 148912, 5177, "Parent Story" },
                    { 149334, 134341, "Alternative Version" },
                    { 149898, 127907, "Character" },
                    { 150042, 13, "Other" },
                    { 150511, 9977, "Parent Story" },
                    { 150846, 1630, "Parent Story" },
                    { 151029, 112807, "Character" },
                    { 151044, 163625, "Alternative Version" },
                    { 151044, 167272, "Side Story" },
                    { 151675, 119908, "Alternative Version" },
                    { 152142, 13492, "Parent Story" },
                    { 152303, 74697, "Parent Story" },
                    { 152303, 133167, "Alternative Version" },
                    { 152326, 1045, "Parent Story" },
                    { 152411, 13, "Parent Story" },
                    { 152709, 131041, "Alternative Version" },
                    { 152986, 872, "Parent Story" },
                    { 153000, 98462, "Alternative Version" },
                    { 153037, 96792, "Alternative Version" },
                    { 153082, 114745, "Parent Story" },
                    { 153208, 30723, "Alternative Version" },
                    { 153266, 157604, "Spin-Off" },
                    { 153622, 139761, "Alternative Version" },
                    { 154021, 127907, "Parent Story" },
                    { 154021, 165811, "Alternative Version" },
                    { 154487, 114745, "Alternative Version" },
                    { 154545, 89357, "Sequel" },
                    { 155002, 22519, "Parent Story" },
                    { 155003, 5177, "Parent Story" },
                    { 155020, 106755, "Parent Story" },
                    { 155115, 119184, "Parent Story" },
                    { 155115, 121496, "Alternative Version" },
                    { 155874, 124629, "Prequel" },
                    { 155874, 169727, "Alternative Version" },
                    { 156089, 24457, "Parent Story" },
                    { 156258, 47551, "Alternative Setting" },
                    { 156424, 21599, "Prequel" },
                    { 157223, 34127, "Alternative Version" },
                    { 157223, 135742, "Prequel" },
                    { 157223, 157224, "Sequel" },
                    { 157224, 34127, "Alternative Version" },
                    { 157224, 157223, "Prequel" },
                    { 157224, 157225, "Sequel" },
                    { 157225, 34127, "Alternative Version" },
                    { 157225, 157224, "Prequel" },
                    { 157604, 153266, "Parent Story" },
                    { 157641, 112318, "Parent Story" },
                    { 158125, 5664, "Parent Story" },
                    { 158167, 16456, "Sequel" },
                    { 158167, 97057, "Other" },
                    { 158345, 56743, "Parent Story" },
                    { 158357, 21479, "Alternative Version" },
                    { 158357, 99386, "Prequel" },
                    { 158887, 653, "Prequel" },
                    { 159387, 70261, "Parent Story" },
                    { 159536, 85391, "Sequel" },
                    { 159674, 14022, "Prequel" },
                    { 159777, 142551, "Alternative Version" },
                    { 159958, 108177, "Prequel" },
                    { 160710, 11, "Parent Story" },
                    { 160723, 81151, "Prequel" },
                    { 160723, 124182, "Sequel" },
                    { 160786, 95210, "Prequel" },
                    { 160805, 96792, "Alternative Version" },
                    { 161010, 56743, "Alternative Setting" },
                    { 161080, 98567, "Parent Story" },
                    { 161081, 5202, "Parent Story" },
                    { 161167, 9977, "Parent Story" },
                    { 161565, 104841, "Other" },
                    { 161565, 147111, "Sequel" },
                    { 161679, 126522, "Alternative Version" },
                    { 161895, 34127, "Parent Story" },
                    { 161895, 170592, "Alternative Version" },
                    { 162007, 138915, "Alternative Version" },
                    { 162007, 143426, "Alternative Version" },
                    { 162863, 9977, "Parent Story" },
                    { 162864, 9736, "Parent Story" },
                    { 163170, 9977, "Parent Story" },
                    { 163625, 151044, "Alternative Version" },
                    { 163880, 30725, "Parent Story" },
                    { 164378, 146846, "Prequel" },
                    { 164432, 126287, "Parent Story" },
                    { 164976, 1061, "Parent Story" },
                    { 165348, 4, "Parent Story" },
                    { 165445, 119161, "Parent Story" },
                    { 165525, 97090, "Prequel" },
                    { 165811, 154021, "Alternative Version" },
                    { 165829, 124085, "Parent Story" },
                    { 166056, 41145, "Prequel" },
                    { 166056, 166058, "Alternative Version" },
                    { 166058, 41145, "Alternative Version" },
                    { 166058, 166056, "Alternative Version" },
                    { 166075, 9977, "Parent Story" },
                    { 166574, 114175, "Parent Story" },
                    { 166643, 43, "Prequel" },
                    { 166983, 35243, "Parent Story" },
                    { 167027, 115710, "Alternative Version" },
                    { 167272, 151044, "Parent Story" },
                    { 167410, 1061, "Parent Story" },
                    { 167474, 1061, "Parent Story" },
                    { 167477, 1061, "Parent Story" },
                    { 167571, 116880, "Parent Story" },
                    { 167572, 35243, "Alternative Version" },
                    { 167582, 74697, "Alternative Version" },
                    { 167582, 124470, "Prequel" },
                    { 168250, 116678, "Parent Story" },
                    { 169340, 126287, "Sequel" },
                    { 169403, 1639, "Other" },
                    { 169454, 81667, "Prequel" },
                    { 169454, 81669, "Alternative Version" },
                    { 169587, 408, "Alternative Version" },
                    { 169587, 3865, "Prequel" },
                    { 169587, 169625, "Sequel" },
                    { 169625, 169587, "Prequel" },
                    { 169726, 124629, "Alternative Version" },
                    { 169726, 169727, "Sequel" },
                    { 169727, 155874, "Alternative Version" },
                    { 169727, 169726, "Prequel" },
                    { 169728, 124183, "Prequel" },
                    { 169728, 124629, "Sequel" },
                    { 169730, 124182, "Alternative Version" },
                    { 169730, 124183, "Alternative Version" },
                    { 169730, 135242, "Alternative Version" },
                    { 169783, 127907, "Parent Story" },
                    { 169920, 8773, "Alternative Version" },
                    { 170166, 126146, "Parent Story" },
                    { 170289, 126241, "Sequel" },
                    { 170477, 74697, "Alternative Version" },
                    { 170592, 161895, "Alternative Version" },
                    { 170680, 115922, "Parent Story" },
                    { 170875, 9273, "Sequel" },
                    { 170875, 143881, "Prequel" },
                    { 171477, 8773, "Alternative Version" },
                    { 171477, 16943, "Sequel" },
                    { 171563, 8558, "Alternative Version" },
                    { 171740, 598, "Parent Story" },
                    { 171758, 131334, "Parent Story" },
                    { 172053, 131924, "Sequel" },
                    { 172069, 131334, "Parent Story" },
                    { 172324, 126146, "Parent Story" },
                    { 172429, 121496, "Prequel" },
                    { 172491, 5204, "Parent Story" },
                    { 172577, 2845, "Parent Story" },
                    { 172694, 13, "Other" },
                    { 173172, 89734, "Parent Story" },
                    { 173409, 85781, "Alternative Version" },
                    { 173417, 56743, "Parent Story" },
                    { 174108, 25, "Parent Story" },
                    { 174109, 25, "Parent Story" },
                    { 174341, 114745, "Parent Story" },
                    { 174418, 114745, "Parent Story" },
                    { 174555, 24457, "Parent Story" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1, 10968 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2, 92299 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2, 106677 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3, 743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3, 15691 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3, 90757 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4, 165348 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9, 14368 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9, 74339 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10, 10183 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10, 14368 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10, 16010 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10, 32037 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10, 46010 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 6028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 6444 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 11926 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 23208 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 40225 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 40549 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 57095 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 77273 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 83257 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 86129 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 87714 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 87866 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 90531 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 92286 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 95210 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 96200 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 96762 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 96763 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 96764 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 96765 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 96766 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 96767 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 96768 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 96769 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 96770 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 98462 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 115792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 119908 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11, 160710 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 11330 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 22744 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 23355 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 26133 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 30541 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 43605 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 43607 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 103000 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 105125 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 106602 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 116905 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 124937 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12, 139152 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 793 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 881 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 5114 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 14414 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 17152 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 23251 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 25146 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 52353 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 86972 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 94533 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 94534 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 110830 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 114760 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 115627 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 120401 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 120656 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 122305 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 127114 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 128594 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 139972 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 141501 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 141511 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 142771 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 142772 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 150042 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 152411 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13, 172694 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14, 15918 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14, 15921 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14, 108461 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14, 122473 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15, 597 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15, 21907 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15, 35609 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15, 57765 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16, 5931 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16, 21883 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16, 78905 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18, 2957 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18, 31521 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19, 64849 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21, 3645 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21, 7458 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21, 8158 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21, 70815 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21, 102569 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21, 132335 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22, 2333 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22, 4795 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22, 9271 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22, 29733 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22, 37303 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22, 73397 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22, 105837 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24, 5147 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24, 9114 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24, 14155 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25, 4658 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25, 32409 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25, 141959 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25, 174108 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25, 174109 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 26, 45996 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 26, 145250 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 27, 133 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 36, 87623 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 796 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 881 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 2897 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 16038 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 16110 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 23446 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 26373 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 54627 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 86671 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 88233 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 89734 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 94865 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 103047 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 110590 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 110591 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42, 139066 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 43, 11926 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 43, 13891 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 43, 93595 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 43, 166643 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44, 1414 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44, 14022 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44, 91209 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 45, 105579 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47, 13891 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47, 17288 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47, 23504 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47, 73115 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49, 11153 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49, 12965 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108, 32037 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 109, 32037 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133, 27 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 160, 9259 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 160, 18982 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 160, 80435 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 173, 174 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 174, 173 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 201, 90408 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 206, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 206, 42571 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 214, 9889 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 214, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 214, 104841 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 345, 593 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 345, 594 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 345, 10982 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 349, 454 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 349, 1546 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 349, 1936 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 349, 1938 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 349, 1939 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 349, 1941 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 349, 65869 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 349, 91443 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 351, 408 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 351, 139018 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 393, 17111 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 393, 17149 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 393, 18654 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 393, 18668 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 393, 65669 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 393, 71821 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 393, 111192 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 393, 114862 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 408, 351 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 408, 13787 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 408, 169587 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 430, 67019 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 436, 119534 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 438, 5733 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 438, 90065 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 438, 93820 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 438, 94838 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 438, 94865 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 438, 109217 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 438, 140245 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 438, 142617 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 438, 148251 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 454, 349 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 556, 557 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 556, 114227 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 557, 556 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 557, 114227 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 593, 345 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 593, 594 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 594, 345 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 594, 351 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 594, 593 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 597, 15 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 15921 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 54697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 64565 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 69415 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 69903 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 75493 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 75495 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 75497 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 78003 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 87623 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 88032 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 91971 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 108461 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 114701 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 114892 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 116463 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 122473 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 145357 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 598, 171740 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 642, 22527 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 642, 131084 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 653, 158887 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 660, 9820 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 660, 12842 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 660, 18791 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 660, 80223 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 671, 13891 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 671, 19018 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 671, 22519 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 671, 56011 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 671, 140247 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 676, 56725 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 676, 140901 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 698, 760 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 698, 3500 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 698, 5178 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 698, 21753 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 698, 25594 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 698, 25632 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 698, 25633 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 698, 49859 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 698, 82801 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 698, 99614 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 698, 137967 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 703, 704 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 703, 44357 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 704, 703 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 728, 745 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 728, 3010 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 728, 6488 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 728, 83411 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 728, 100039 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 728, 103910 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 733, 94865 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 733, 102286 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 743, 3 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 745, 728 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 760, 698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 760, 3500 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 760, 5178 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 792, 1512 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 792, 17226 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 792, 108576 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 792, 117695 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 793, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 793, 5114 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 796, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 796, 16038 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 796, 88233 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 872, 1630 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 872, 3006 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 872, 32347 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 872, 57051 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 872, 75703 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 872, 152986 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 881, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 881, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1009, 66025 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1023, 1028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1023, 3395 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1023, 7848 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1023, 10820 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1023, 48321 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1023, 112031 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1023, 123157 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1026, 121505 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1028, 1023 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1028, 121505 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 1046 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 1047 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 1322 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 39875 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 49551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 54761 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 65169 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 110898 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 117130 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 123901 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 133521 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1045, 152326 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1046, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1046, 1047 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1046, 1322 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1046, 67297 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1046, 122239 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1047, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1047, 1046 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1047, 1322 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1047, 25916 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1057, 88100 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 1804 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 3202 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 11176 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 109213 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 109214 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 109215 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 109216 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 109217 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 110644 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 112744 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 114379 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 117572 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 121951 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 132100 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 133341 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 133342 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 133343 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 164976 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 167410 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 167474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1061, 167477 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1224, 97324 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1298, 94865 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1322, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1322, 1047 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1342, 10814 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1342, 92203 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1414, 44 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1414, 10105 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1414, 13891 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1414, 20065 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1414, 23598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1414, 102286 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1442, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1442, 7697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1442, 18991 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 1442 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 1475 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 4591 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 4592 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 13753 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 26751 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 37561 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 75719 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 92833 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 95091 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 101956 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 104670 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1474, 146520 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1475, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1475, 75723 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1475, 85924 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1505, 11210 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1505, 33617 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1505, 75051 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1505, 94865 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1512, 792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1512, 34837 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1517, 1630 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1517, 46604 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1546, 349 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 6891 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 7759 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 8571 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 10447 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 15359 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 18074 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 26751 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 37701 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 87835 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 93088 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 114435 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1551, 119385 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1630, 872 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1630, 1517 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1630, 46604 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1630, 150846 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1639, 42755 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1639, 56725 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1639, 66161 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1639, 95091 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1639, 169403 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1706, 3009 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1706, 25515 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1804, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1873, 5202 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1932, 58217 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1936, 349 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1936, 1938 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1936, 91444 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1938, 349 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1938, 1936 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1938, 1939 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1938, 1941 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1939, 1938 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1939, 1941 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 1941, 1938 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2105, 81575 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2144, 31521 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2333, 22 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2333, 9271 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2845, 5451 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2845, 13927 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2845, 21599 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2845, 94865 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2845, 106764 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2845, 147070 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2845, 172577 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2897, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 2957, 18 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3006, 872 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3006, 3008 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3006, 3578 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3006, 19423 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3006, 32991 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3006, 61959 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3006, 142551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3008, 3006 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3008, 3009 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3008, 35907 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3008, 41865 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3009, 1706 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3009, 3008 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3009, 47533 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3009, 142552 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3010, 728 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3084, 94865 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3087, 20221 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3202, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3378, 23942 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3378, 128131 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3395, 8350 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3500, 698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3500, 760 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3500, 5178 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3510, 91734 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3537, 62393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3578, 3006 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3578, 61959 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3645, 21 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3822, 96448 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3865, 351 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3865, 169587 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 3866, 13450 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4101, 81575 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4186, 31845 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4186, 35281 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4404, 6732 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4404, 10328 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4404, 15148 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4591, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4592, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4592, 20581 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4658, 25 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4795, 22 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 4981, 13787 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5114, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5114, 793 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5147, 24 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5177, 18254 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5177, 135181 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5177, 137358 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5177, 148912 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5177, 155003 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5178, 698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5178, 760 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5178, 3500 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5202, 1873 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5202, 5203 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5202, 16456 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5202, 161081 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5203, 5202 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5203, 5204 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5204, 5203 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5204, 32799 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5204, 172491 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5206, 30593 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5451, 2845 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5451, 21608 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5451, 23234 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5664, 16532 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5664, 22131 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5664, 66809 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5664, 102286 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5664, 158125 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5733, 438 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5733, 24312 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5733, 142617 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5756, 88100 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 5931, 16 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6028, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6444, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6488, 728 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6732, 4404 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6732, 10328 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6732, 10720 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6732, 11561 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6732, 15148 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6732, 19033 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6732, 20467 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6891, 1551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6891, 7759 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 6891, 10447 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7378, 24294 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7458, 21 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7658, 16941 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7658, 16942 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7658, 19870 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7658, 75723 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7658, 92833 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7658, 96389 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7658, 119688 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7666, 8782 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7666, 92838 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7697, 1442 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7747, 14674 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7747, 96383 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7756, 19870 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7759, 1551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7759, 6891 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7759, 8571 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7759, 10447 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7759, 15359 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7759, 18074 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7759, 92838 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7848, 1023 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7848, 31935 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7887, 25146 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7887, 93982 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7887, 102846 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 7887, 102847 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8157, 88679 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8157, 110668 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8158, 21 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8300, 75053 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8300, 88032 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8350, 3395 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8558, 8773 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8558, 32899 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8558, 78717 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8558, 92833 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8558, 171563 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8571, 7759 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8571, 10447 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8571, 18074 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8571, 92839 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8772, 92839 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8773, 8558 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8773, 37701 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8773, 87725 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8773, 90885 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8773, 92833 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8773, 98118 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8773, 111710 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8773, 169920 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8773, 171477 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8782, 7666 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8795, 65643 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 8795, 86414 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9114, 24 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9259, 160 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9271, 22 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9271, 2333 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9273, 16456 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9273, 170875 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9711, 13891 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9711, 21274 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9711, 92905 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9711, 92906 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9711, 93027 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9726, 18162 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9726, 87518 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9726, 117028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9736, 29391 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9736, 42439 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9736, 85391 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9736, 111971 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9736, 132537 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9736, 148473 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9736, 162864 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9820, 660 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9889, 214 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9889, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9889, 85391 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9889, 93326 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9889, 97664 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 206 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 214 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 9889 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 85033 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 93831 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 96390 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 122892 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 150511 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 161167 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 162863 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 163170 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 9977, 166075 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10010, 36729 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10010, 77849 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10010, 102286 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10105, 1414 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10183, 10 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10328, 4404 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10328, 6732 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10328, 15148 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10328, 24548 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10447, 1551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10447, 6891 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10447, 7759 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10447, 8571 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10447, 15359 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10447, 18074 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10720, 6732 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10720, 21911 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10814, 1342 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10820, 1023 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10968, 1 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10982, 345 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 10982, 11971 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11153, 49 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11176, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11210, 1505 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11300, 24312 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11330, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11437, 15305 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11561, 4404 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11561, 6732 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11561, 10328 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11561, 10720 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11561, 18440 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11561, 20467 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11652, 42737 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11652, 83807 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11926, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11926, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11926, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11926, 43 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11926, 45 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11926, 796 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11926, 1505 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 11971, 10982 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12336, 79133 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12709, 89610 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12709, 90883 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12709, 90884 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12709, 90885 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12842, 660 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 12965, 49 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13450, 3866 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13492, 28103 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13492, 36277 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13492, 57927 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13492, 114679 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13492, 152142 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13741, 30725 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13753, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13787, 408 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13787, 4981 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13891, 43 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13891, 47 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13891, 671 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13891, 1414 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13891, 9711 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 13927, 2845 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14022, 44 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14022, 159674 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14155, 24 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14230, 25541 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14230, 65169 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14230, 126241 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14231, 14232 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14231, 31011 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14231, 65169 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14232, 14231 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14368, 9 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14368, 10 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14377, 19870 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14377, 57897 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14414, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14674, 7747 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14841, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14841, 34335 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14893, 23751 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14893, 24499 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14893, 86670 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14893, 90322 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14893, 93097 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14893, 113010 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 14893, 117028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15018, 16666 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15106, 8773 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15148, 4404 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15148, 6732 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15148, 10328 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15148, 24548 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15200, 117028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15200, 135567 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15305, 11437 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15305, 15315 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15315, 15305 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15359, 1551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15359, 6891 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15359, 7759 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15359, 8571 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15359, 10447 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15359, 18074 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15530, 114372 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15530, 118522 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15691, 3 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15918, 14 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15921, 14 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 15921, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16038, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16038, 796 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16110, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16168, 85393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16168, 86844 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16168, 97060 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16456, 5202 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16456, 9273 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16456, 97057 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16456, 158167 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16532, 5664 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16666, 15018 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 1342 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 14841 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 21132 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 21587 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 24901 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 34335 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 49547 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 69073 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 69765 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 78183 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 81485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 81551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 85707 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 90870 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 94392 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16816, 113839 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16941, 7658 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16941, 19619 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16942, 7658 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16942, 87835 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16943, 98118 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 16943, 171477 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 17111, 393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 17149, 393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 17149, 21307 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 17149, 111192 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 17152, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 17226, 792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 17288, 47 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18074, 1551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18074, 7759 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18074, 8571 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18074, 10447 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18074, 15359 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18161, 20983 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18161, 117028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18162, 9726 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18162, 28075 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18162, 70117 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18162, 117028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18254, 5177 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18254, 135181 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18440, 11561 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18440, 19033 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18440, 20477 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18654, 393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18654, 18668 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18668, 393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18668, 18654 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18791, 660 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18982, 160 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 18991, 1442 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19018, 671 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19033, 6732 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19033, 18440 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19033, 20477 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19033, 24812 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19315, 37999 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19315, 62687 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19315, 65499 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19315, 111453 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19315, 113275 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19423, 3006 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19619, 16941 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19870, 7658 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19870, 7756 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 19870, 14377 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 20065, 1414 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 20221, 3087 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 20467, 6732 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 20467, 11561 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 20467, 20477 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 20477, 18440 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 20477, 19033 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 20477, 20467 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 20581, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 20581, 4592 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 20983, 18161 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21115, 117028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21132, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21132, 21135 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21135, 21132 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21274, 9711 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21307, 17149 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21307, 90585 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 23718 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 37405 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 40053 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 40281 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 41027 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 43921 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 44733 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 46222 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 46582 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 55875 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 56169 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 60593 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 75099 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 75101 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 75103 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 82795 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 99386 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 99758 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 102484 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 103244 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 103807 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 103808 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 113491 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 118123 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 125767 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 141953 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21479, 158357 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21587, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21599, 2845 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21599, 156424 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21608, 5451 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21753, 698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21883, 16 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21907, 15 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21911, 10720 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21911, 18440 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21911, 19033 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 21911, 20477 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22131, 5664 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22519, 671 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22519, 41835 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22519, 122105 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22519, 124619 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22519, 124620 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22519, 155002 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22527, 642 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22744, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22744, 22745 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 22745, 22744 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23208, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23234, 5451 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23251, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23251, 52353 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23355, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23446, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23504, 47 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23598, 1414 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23718, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23718, 44733 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23751, 14893 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23751, 44227 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23751, 66695 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23751, 90324 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23869, 145352 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 23942, 3378 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24033, 95212 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24033, 96692 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24294, 7378 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24294, 33297 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24294, 52389 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24294, 77237 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24294, 77239 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24295, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24312, 5733 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24312, 11300 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24456, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24456, 65909 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24456, 90687 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 24295 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 24456 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 27861 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 28961 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 44319 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 62673 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 63329 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 70751 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 73781 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 76319 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 85884 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 89364 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 89365 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 89366 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 90016 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 90309 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 104509 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 104925 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 106374 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 115774 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 156089 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24457, 174555 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24499, 14893 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24548, 15148 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24561, 47363 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24561, 103907 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24679, 349 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24812, 19033 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24822, 86336 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24822, 93698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24822, 99853 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24822, 104330 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24822, 104333 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24822, 118801 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24822, 125236 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24822, 144847 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 24901, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25096, 56725 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25146, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25146, 7887 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25409, 30859 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25409, 34485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25409, 87375 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25409, 94864 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25409, 100790 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25409, 110390 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25409, 114787 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25515, 1706 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25515, 139629 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25541, 14230 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25594, 698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25632, 698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25632, 25633 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25633, 698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25633, 25632 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 25916, 1047 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 26123, 94865 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 26123, 132186 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 26133, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 26178, 57249 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 26178, 80469 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 26178, 132966 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 26373, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 26751, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 26751, 1551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 27861, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 28075, 18162 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 28075, 70117 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 28103, 13492 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 28961, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 29391, 9736 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 29391, 85391 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 29733, 22 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30541, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30591, 5206 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30591, 30593 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30591, 68983 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30591, 85393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30593, 5206 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30593, 30591 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30593, 68983 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30593, 72431 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30593, 85393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30723, 37701 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30723, 153208 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30725, 13741 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30725, 163880 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30859, 25409 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 30987, 35243 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31011, 14231 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31079, 37755 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31499, 35243 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31499, 58193 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31499, 65051 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31499, 70251 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31499, 83187 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31499, 102286 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31499, 117050 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31521, 18 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31521, 2144 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31845, 4186 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31935, 7848 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31935, 80473 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 31939, 116678 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 32037, 108 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 32037, 109 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 32347, 872 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 32409, 25 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 32799, 5204 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 32799, 98567 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 32899, 8558 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 32913, 133638 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 32913, 141885 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 32991, 3006 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 33297, 24294 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 33327, 74847 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 33327, 77815 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 33327, 80909 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 33327, 81117 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 33617, 1505 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 33699, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 33699, 60973 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 33699 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 41539 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 60973 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 60975 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 60977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 93234 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 98583 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 101482 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 104234 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 108530 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 115017 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 119295 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 119296 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 122557 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 130314 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 133005 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 135262 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 135740 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 135741 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 135742 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 157223 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 157224 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 157225 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34127, 161895 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34335, 14841 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34335, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34335, 49547 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34485, 25409 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34837, 792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 34837, 1512 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35003, 62393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35003, 75053 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35003, 88032 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35243, 30987 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35243, 73631 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35243, 80163 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35243, 119852 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35243, 146284 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35243, 166983 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35243, 167572 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35281, 4186 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35317, 30861 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35319, 30861 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35319, 35317 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35319, 35321 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35319, 91706 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35321, 35319 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35321, 47248 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35321, 91706 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35609, 15 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 35907, 3008 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 36277, 13492 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 36729, 10010 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 36933, 52389 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 36933, 58193 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37303, 22 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37405, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37561, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37683, 206 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37683, 99593 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37701, 1551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37701, 8773 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37701, 30723 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37755, 31079 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37755, 39883 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37755, 107295 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37999, 19315 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 37999, 50161 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 39875, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 39883, 37755 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 39883, 93353 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 39883, 102286 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 40053, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 40225, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 40281, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 40549, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 40549, 96770 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 41027, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 41145, 166056 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 41145, 166058 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 41539, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 41539, 135743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 41835, 22519 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 41865, 3008 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42439, 9736 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42439, 30725 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42439, 97658 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42439, 117379 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42571, 206 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42737, 11652 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42737, 85900 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 42755, 1639 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 43605, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 43607, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 43921, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 43921, 52277 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 43921, 125770 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 43921, 125771 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 43921, 135893 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44021, 1442 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44227, 23751 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44227, 108177 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44319, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44357, 703 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44357, 704 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 64565 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 75055 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 81575 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 84427 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 87195 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 93979 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 96262 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 103392 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 115713 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 128691 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 134732 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44485, 138078 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44733, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44733, 23718 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44733, 75099 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44933, 69371 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44933, 69375 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44933, 74859 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44933, 81151 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44933, 81153 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44933, 125108 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 44933, 136106 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 45996, 26 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 46010, 10 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 46010, 74339 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 46010, 94856 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 46222, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 46582, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 46604, 1517 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 46604, 1630 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47102, 75053 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47102, 118326 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47248, 35321 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47248, 91706 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47363, 24561 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47363, 86414 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47533, 3008 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47533, 3009 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47551, 63547 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47551, 132343 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 47551, 156258 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 48321, 1023 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49305, 51755 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49305, 68273 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49305, 92826 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49305, 99361 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49547, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49547, 34335 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49547, 85707 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49551, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49567, 51309 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49567, 51313 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49567, 62083 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49567, 86353 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 49859, 698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 50161, 37999 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 51023, 51025 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 51025, 51023 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 51025, 87720 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 51309, 49567 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 51313, 49567 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 51755, 49305 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 52277, 43921 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 52277, 125770 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 52353, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 52353, 23251 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 52389, 24294 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 52389, 36933 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 54627, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 54697, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 54761, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 55157, 70307 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 55867, 87678 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 55875, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56011, 671 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56169, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56725, 676 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56725, 1639 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56725, 3822 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56725, 7747 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56725, 14124 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56725, 14956 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56725, 17026 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56725, 25096 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56743, 57239 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56743, 66433 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56743, 78475 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56743, 90180 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56743, 103045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56743, 128368 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56743, 138269 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56743, 142916 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56743, 158345 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56743, 161010 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 56743, 173417 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 57051, 872 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 57095, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 57101, 69941 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 57239, 56743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 57239, 128368 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 57249, 26178 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 57249, 119886 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 57765, 15 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 57897, 14377 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 57927, 13492 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 58193, 31499 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 58193, 36933 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 58217, 1932 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60553, 80385 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60553, 89768 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60553, 97200 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60553, 106218 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60553, 109014 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60553, 114219 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60553, 114664 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60553, 118456 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60553, 124804 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60553, 133787 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60553, 144387 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60593, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60973, 33699 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60973, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60973, 104234 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60975, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60975, 60977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60975, 115017 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60977, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60977, 60975 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 60977, 93234 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 61959, 3006 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 61959, 3578 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 61959, 142475 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 62083, 49567 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 62393, 3537 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 62393, 35003 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 62671, 90309 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 62673, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 62687, 19315 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 63329, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 63547, 47551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 64565, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 64565, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65051, 31499 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65169, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65169, 14230 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65169, 14231 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65169, 24881 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65169, 27643 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65499, 19315 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65499, 111453 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65643, 8795 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65669, 393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65685, 86414 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65869, 349 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 65909, 24456 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 66025, 1009 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 66161, 1639 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 66433, 56743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 66433, 71253 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 66695, 23751 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 66695, 86670 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 66809, 5664 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 66809, 74157 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 66879, 86367 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67019, 430 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67019, 75053 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67019, 86414 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67019, 88032 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67019, 116987 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67297, 1046 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67297, 124340 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67545, 102286 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67615, 67617 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67617, 67615 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67617, 108167 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67617, 115900 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67617, 123452 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67617, 127222 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67617, 132079 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 67617, 148724 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 68273, 49305 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 68983, 30591 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 68983, 30593 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 68983, 97060 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 68983, 146554 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69073, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69371, 44933 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69371, 69375 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69371, 81157 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69371, 88478 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69375, 44933 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69375, 69371 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69375, 74859 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69415, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69503, 90585 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69503, 112322 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69765, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69903, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 69941, 57101 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70117, 18162 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70117, 28075 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70251, 31499 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70259, 70261 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70259, 142765 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70261, 70259 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70261, 115498 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70261, 125735 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70261, 142765 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70261, 145006 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70261, 159387 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70307, 55157 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70751, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 70815, 21 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 71253, 66433 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 71821, 393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 72431, 30593 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 73115, 47 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 73397, 22 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 73631, 35243 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 73781, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74157, 66809 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74339, 9 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74339, 46010 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74339, 86232 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74695, 74697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74695, 80719 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74697, 74695 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74697, 80719 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74697, 89960 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74697, 95243 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74697, 99446 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74697, 115765 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74697, 124470 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74697, 124743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74697, 152303 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74697, 167582 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74697, 170477 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74847, 33327 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74859, 44933 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 74859, 69375 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75051, 1505 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75051, 90908 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75053, 8300 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75053, 35003 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75053, 47102 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75053, 67019 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75055, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75099, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75099, 44733 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75099, 75103 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75101, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75101, 75103 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75101, 99386 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75103, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75103, 75099 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75103, 75101 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75493, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75495, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75497, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75703, 872 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75719, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75723, 1475 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 75723, 7658 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 76319, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 77213, 81611 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 77213, 83729 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 77213, 91562 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 77213, 94540 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 77237, 24294 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 77239, 24294 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 77273, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 77815, 33327 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 77849, 10010 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 78003, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 78183, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 78475, 56743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 78717, 8558 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 78905, 16 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 79133, 12336 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 80163, 35243 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 80223, 660 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 80385, 60553 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 80435, 160 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 80469, 26178 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 80473, 31935 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 80719, 74695 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 80719, 74697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 80719, 89960 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 80719, 99446 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 80909, 33327 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81117, 33327 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81117, 115800 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81151, 44933 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81151, 160723 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81153, 44933 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81157, 69371 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81485, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81551, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81575, 2105 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81575, 4101 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81575, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81611, 77213 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81667, 81669 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81667, 169454 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81669, 81667 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81669, 116216 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81669, 116651 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81669, 117956 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81669, 119696 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 81669, 169454 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 82283, 82285 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 82283, 82289 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 82285, 82283 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 82289, 82283 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 82795, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 82795, 92625 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 82801, 698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 83187, 31499 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 83257, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 83411, 728 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 83729, 77213 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 83807, 11652 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 84427, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85033, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85391, 9736 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85391, 9889 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85391, 29391 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85391, 85393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85391, 159536 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85393, 16168 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85393, 30593 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85393, 85391 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85707, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85707, 49547 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85781, 173409 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85884, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85900, 42737 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85924, 1475 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 85931, 95212 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86129, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86232, 74339 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86336, 24822 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86353, 49567 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86353, 104624 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86367, 66879 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86414, 8795 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86414, 47363 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86414, 65685 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86414, 67019 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86670, 14893 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86670, 66695 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86671, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86769, 107562 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86769, 110929 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86844, 16168 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 86972, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87195, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87375, 25409 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87518, 9726 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87518, 117028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87623, 36 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87623, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87678, 55867 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87714, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87720, 51025 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87725, 8773 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87835, 1551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87835, 16942 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 87866, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88032, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88032, 8300 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88032, 35003 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88032, 67019 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88100, 1057 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88100, 5756 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88100, 122365 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88100, 132383 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88233, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88233, 796 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88233, 16038 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88478, 69371 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88679, 8157 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88923, 96528 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88923, 108240 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88923, 110615 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88923, 125234 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88923, 128632 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88930, 98436 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 88930, 114586 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89357, 96371 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89357, 108725 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89357, 123992 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89357, 125053 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89357, 154545 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89364, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89365, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89366, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89610, 12709 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89734, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89734, 54627 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89734, 106285 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89734, 173172 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89768, 60553 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89768, 97722 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89768, 114989 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89960, 74697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89960, 80719 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 89960, 124470 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90016, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90065, 438 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90117, 90118 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90118, 90117 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90180, 56743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90309, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90309, 62671 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90322, 14893 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90324, 23751 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90408, 201 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90531, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90585, 21307 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90585, 69503 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90687, 24456 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90757, 3 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90870, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90883, 12709 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90884, 12709 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90885, 8773 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90885, 12709 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90908, 75051 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 90993, 94175 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 91209, 44 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 91443, 349 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 91443, 91444 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 91444, 1936 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 91444, 91443 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 91562, 77213 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 91706, 35319 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 91706, 35321 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 91706, 47248 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 91734, 3510 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 91971, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92203, 1342 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92286, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92299, 2 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92625, 82795 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92826, 49305 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92833, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92833, 7658 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92833, 8558 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92833, 8773 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92833, 98118 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92838, 7666 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92838, 7759 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92839, 8571 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92839, 8772 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92905, 9711 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 92906, 9711 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93027, 9711 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93088, 1551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93097, 14893 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93234, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93234, 60977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93234, 101482 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93314, 103647 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93314, 108306 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93326, 9889 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93353, 39883 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93408, 97524 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93408, 106813 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93595, 43 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93691, 93692 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93692, 93691 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93692, 104064 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93698, 24822 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93820, 438 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93831, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93979, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 93982, 7887 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94175, 90993 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94175, 117028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94392, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94533, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94534, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94540, 77213 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94838, 438 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94856, 46010 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94864, 25409 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94865, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94865, 438 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94865, 733 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94865, 1298 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94865, 1505 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94865, 2845 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94865, 3084 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94865, 26123 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 94865, 95746 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95016, 115579 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95091, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95091, 1639 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95210, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95210, 98462 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95210, 106113 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95210, 106156 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95210, 160786 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95212, 24033 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95212, 85931 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95212, 96597 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95212, 133638 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95243, 74697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95243, 120412 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 95746, 94865 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96200, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96262, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96371, 89357 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96371, 142246 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96383, 7747 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96389, 7658 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96390, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96448, 3822 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96528, 88923 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96597, 95212 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96692, 24033 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96762, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96763, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96764, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96765, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96766, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96767, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96768, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96769, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96770, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96770, 40549 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96792, 121118 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96792, 121119 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96792, 131706 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96792, 133053 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96792, 140256 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96792, 143972 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96792, 153037 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 96792, 160805 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97057, 16456 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97057, 158167 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97060, 16168 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97060, 68983 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97090, 106810 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97090, 165525 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97200, 60553 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97200, 114664 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97324, 1224 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97524, 93408 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97658, 42439 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97664, 9889 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97722, 89768 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 97722, 114989 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98118, 8773 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98118, 16943 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98118, 92833 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98118, 131678 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98425, 107525 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98425, 108274 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98436, 88930 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98462, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98462, 95210 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98462, 153000 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98480, 110390 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98567, 32799 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98567, 161080 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 98583, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99361, 49305 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99386, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99386, 75101 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99386, 131396 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99386, 158357 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99446, 74697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99446, 80719 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99593, 37683 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99614, 698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99758, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99853, 24822 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99891, 103144 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 99891, 127130 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 100039, 728 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 100790, 25409 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 101476, 121357 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 101482, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 101482, 93234 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 101482, 119295 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 101662, 114925 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 101956, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102286, 733 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102286, 1414 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102286, 5664 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102286, 10010 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102286, 31499 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102286, 39883 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102286, 67545 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102484, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102569, 21 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102667, 110288 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102667, 130174 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102667, 147192 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102702, 111587 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102702, 130370 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102846, 7887 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 102847, 7887 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103000, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103045, 56743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103045, 104897 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103047, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103078, 103392 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103144, 99891 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103244, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103244, 116786 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103244, 116788 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103392, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103392, 103078 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103647, 93314 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103647, 108306 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103701, 115996 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103761, 116772 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103807, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103807, 118123 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103808, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103897, 122464 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103907, 24561 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 103910, 728 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104064, 93692 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104064, 117445 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104234, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104234, 60973 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104234, 115017 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104330, 24822 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104333, 24822 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104509, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104584, 122943 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104624, 86353 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104670, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104841, 214 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104841, 147111 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104841, 161565 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104897, 103045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 104925, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 105125, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 105579, 45 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 105837, 22 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106113, 95210 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106156, 95210 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106218, 60553 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106285, 89734 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106285, 117544 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106374, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106602, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106677, 2 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106755, 116943 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106755, 155020 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106764, 2845 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106810, 97090 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 106813, 93408 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 107295, 37755 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 107339, 114393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 107525, 98425 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 107562, 86769 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108166, 108167 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108167, 67617 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108167, 108166 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108177, 44227 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108177, 159958 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108199, 108406 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108199, 126738 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108240, 88923 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108274, 98425 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108306, 93314 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108306, 103647 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108406, 108199 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108406, 126738 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108461, 14 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108461, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108530, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108576, 792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 108725, 89357 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 109014, 60553 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 109014, 133788 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 109213, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 109214, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 109215, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 109216, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 109217, 438 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 109217, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 109217, 110645 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 109947, 111225 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110288, 102667 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110288, 129262 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110390, 25409 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110390, 98480 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110390, 128837 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110590, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110591, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110615, 88923 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110615, 112907 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110644, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110645, 109217 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110668, 8157 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110830, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110898, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 110929, 86769 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111192, 393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111192, 17149 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111225, 109947 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111453, 19315 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111453, 65499 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111453, 113275 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111453, 114927 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111587, 102702 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111710, 8773 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111970, 111971 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111971, 9736 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 111971, 111970 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 112031, 1023 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 112318, 134556 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 112318, 134557 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 112318, 157641 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 112322, 69503 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 112744, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 112807, 151029 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 112907, 110615 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 113010, 14893 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 113138, 115710 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 113138, 133047 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 113138, 133048 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 113275, 19315 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 113275, 111453 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 113491, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 113839, 16816 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 113839, 126738 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114175, 114279 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114175, 166574 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114219, 60553 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114219, 118456 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114227, 556 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114227, 557 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114279, 114175 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114372, 15530 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114379, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114393, 107339 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114435, 1551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114548, 122473 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114586, 88930 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114664, 97200 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114679, 13492 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114701, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114745, 144695 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114745, 153082 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114745, 154487 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114745, 174341 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114745, 174418 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114760, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114779, 122650 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114787, 25409 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114862, 393 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114892, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114925, 101662 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114927, 111453 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114989, 89768 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 114989, 97722 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115017, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115017, 60975 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115017, 104234 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115498, 70261 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115579, 95016 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115627, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115710, 113138 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115710, 146643 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115710, 167027 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115713, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115765, 74697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115774, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115774, 139665 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115792, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115800, 81117 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115900, 67617 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115922, 119022 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115922, 131215 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115922, 170680 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 115996, 103701 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116216, 81669 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116463, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116651, 81669 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116678, 31939 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116678, 168250 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116772, 103761 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116778, 140150 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116786, 103244 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116788, 103244 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116880, 167571 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116905, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116943, 106755 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 116987, 67019 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117028, 9726 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117028, 14893 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117028, 15200 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117028, 18161 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117028, 18162 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117028, 21115 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117028, 87518 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117028, 94175 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117028, 122943 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117050, 31499 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117130, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117130, 123901 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117379, 42439 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117445, 104064 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117544, 106285 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117544, 133542 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117572, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117692, 117693 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117693, 117692 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117695, 792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117886, 120548 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 117956, 81669 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 118108, 118251 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 118123, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 118123, 103807 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 118251, 118108 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 118326, 47102 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 118456, 60553 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 118456, 114219 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 118522, 15530 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 118801, 24822 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119022, 115922 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119161, 136660 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119161, 165445 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119184, 121496 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119184, 155115 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119295, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119295, 101482 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119295, 119296 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119296, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119296, 119295 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119296, 135740 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119385, 1551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119534, 436 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119688, 7658 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119696, 81669 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119852, 35243 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119886, 57249 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119908, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 119908, 151675 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 120401, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 120412, 95243 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 120548, 117886 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 120656, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 121118, 96792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 121119, 96792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 121357, 101476 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 121496, 119184 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 121496, 155115 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 121496, 172429 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 121505, 1026 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 121505, 1028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 121951, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122058, 131030 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122105, 22519 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122239, 1046 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122305, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122365, 88100 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122464, 103897 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122473, 14 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122473, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122473, 114548 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122557, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122557, 133004 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122650, 114779 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122892, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122943, 104584 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 122943, 117028 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123157, 1023 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123318, 123613 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123319, 123613 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123452, 67617 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123456, 144724 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123613, 123318 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123613, 123319 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123613, 130491 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123613, 135698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123901, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123901, 117130 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123992, 89357 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 123992, 142246 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124085, 165829 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124182, 135242 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124182, 160723 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124182, 169730 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124183, 135242 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124183, 169728 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124183, 169730 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124305, 126487 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124340, 67297 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124470, 74697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124470, 89960 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124470, 167582 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124619, 22519 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124620, 22519 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124629, 155874 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124629, 169726 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124629, 169728 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124743, 74697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124776, 3510 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124776, 91734 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124804, 60553 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 124937, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125053, 89357 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125108, 44933 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125234, 88923 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125236, 24822 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125735, 70261 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125767, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125770, 43921 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125770, 52277 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125770, 125771 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125771, 43921 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125771, 125770 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 125771, 135893 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 126146, 170166 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 126146, 172324 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 126241, 14230 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 126241, 170289 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 126287, 164432 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 126287, 169340 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 126487, 124305 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 126522, 161679 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 126738, 108199 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 126738, 108406 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 126738, 113839 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 127114, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 127114, 128594 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 127130, 99891 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 127222, 67617 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 127781, 134946 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 127907, 149898 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 127907, 154021 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 127907, 169783 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 128131, 3378 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 128368, 56743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 128368, 57239 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 128594, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 128594, 127114 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 128632, 88923 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 128691, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 128694, 135545 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 128837, 110390 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 129262, 110288 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 129262, 130174 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 130174, 102667 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 130174, 129262 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 130314, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 130370, 102702 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 130491, 123613 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131030, 122058 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131041, 152709 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131084, 642 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131215, 115922 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131334, 131487 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131334, 133498 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131334, 171758 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131334, 172069 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131396, 99386 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131487, 131334 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131678, 98118 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131706, 96792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 131924, 172053 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 132079, 67617 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 132100, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 132335, 21 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 132343, 47551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 132383, 88100 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 132500, 132505 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 132505, 132500 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 132537, 9736 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 132966, 26178 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133004, 122557 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133005, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133005, 134408 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133047, 113138 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133048, 113138 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133053, 96792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133167, 152303 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133341, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133342, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133343, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133352, 136856 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133498, 131334 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133521, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133542, 117544 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133542, 146846 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133638, 32913 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133638, 95212 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133787, 60553 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 133788, 109014 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 134341, 137242 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 134341, 149334 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 134408, 133005 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 134556, 112318 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 134557, 112318 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 134732, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 134946, 127781 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135181, 5177 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135181, 18254 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135242, 124182 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135242, 124183 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135242, 169730 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135262, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135545, 128694 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135567, 15200 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135698, 123613 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135740, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135740, 119296 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135740, 135741 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135741, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135741, 135740 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135741, 135742 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135742, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135742, 135741 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135742, 157223 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135743, 41539 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135893, 43921 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 135893, 125771 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 136106, 44933 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 136660, 119161 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 136856, 133352 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 137242, 134341 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 137358, 5177 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 137967, 698 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 138078, 44485 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 138269, 56743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 138269, 141272 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 138481, 146732 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 138915, 143426 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 138915, 162007 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 139018, 351 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 139066, 42 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 139152, 12 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 139629, 25515 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 139665, 115774 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 139761, 153622 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 139972, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 140150, 116778 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 140245, 438 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 140247, 671 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 140256, 96792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 140256, 143972 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 140901, 676 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 141272, 138269 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 141501, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 141511, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 141885, 32913 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 141953, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 141959, 25 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142246, 96371 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142246, 123992 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142475, 61959 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142551, 3006 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142551, 159777 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142552, 3009 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142617, 438 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142617, 5733 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142765, 70259 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142765, 70261 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142771, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142772, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 142916, 56743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 143426, 138915 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 143426, 162007 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 143881, 170875 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 143972, 96792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 143972, 140256 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 144387, 60553 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 144387, 145444 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 144695, 114745 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 144724, 123456 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 144847, 24822 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 145006, 70261 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 145250, 26 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 145352, 23869 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 145357, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 145444, 144387 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 146284, 35243 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 146520, 1474 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 146554, 68983 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 146643, 115710 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 146732, 138481 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 146846, 133542 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 146846, 164378 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 147070, 2845 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 147111, 104841 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 147111, 161565 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 147192, 102667 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 148251, 438 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 148473, 9736 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 148724, 67617 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 148912, 5177 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 149334, 134341 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 149898, 127907 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 150042, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 150511, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 150846, 1630 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 151029, 112807 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 151044, 163625 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 151044, 167272 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 151675, 119908 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 152142, 13492 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 152303, 74697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 152303, 133167 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 152326, 1045 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 152411, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 152709, 131041 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 152986, 872 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 153000, 98462 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 153037, 96792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 153082, 114745 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 153208, 30723 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 153266, 157604 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 153622, 139761 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 154021, 127907 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 154021, 165811 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 154487, 114745 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 154545, 89357 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 155002, 22519 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 155003, 5177 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 155020, 106755 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 155115, 119184 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 155115, 121496 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 155874, 124629 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 155874, 169727 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 156089, 24457 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 156258, 47551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 156424, 21599 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 157223, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 157223, 135742 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 157223, 157224 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 157224, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 157224, 157223 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 157224, 157225 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 157225, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 157225, 157224 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 157604, 153266 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 157641, 112318 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 158125, 5664 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 158167, 16456 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 158167, 97057 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 158345, 56743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 158357, 21479 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 158357, 99386 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 158887, 653 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 159387, 70261 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 159536, 85391 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 159674, 14022 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 159777, 142551 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 159958, 108177 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 160710, 11 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 160723, 81151 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 160723, 124182 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 160786, 95210 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 160805, 96792 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 161010, 56743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 161080, 98567 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 161081, 5202 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 161167, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 161565, 104841 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 161565, 147111 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 161679, 126522 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 161895, 34127 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 161895, 170592 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 162007, 138915 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 162007, 143426 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 162863, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 162864, 9736 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 163170, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 163625, 151044 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 163880, 30725 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 164378, 146846 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 164432, 126287 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 164976, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 165348, 4 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 165445, 119161 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 165525, 97090 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 165811, 154021 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 165829, 124085 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 166056, 41145 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 166056, 166058 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 166058, 41145 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 166058, 166056 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 166075, 9977 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 166574, 114175 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 166643, 43 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 166983, 35243 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 167027, 115710 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 167272, 151044 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 167410, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 167474, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 167477, 1061 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 167571, 116880 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 167572, 35243 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 167582, 74697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 167582, 124470 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 168250, 116678 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169340, 126287 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169403, 1639 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169454, 81667 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169454, 81669 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169587, 408 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169587, 3865 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169587, 169625 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169625, 169587 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169726, 124629 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169726, 169727 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169727, 155874 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169727, 169726 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169728, 124183 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169728, 124629 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169730, 124182 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169730, 124183 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169730, 135242 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169783, 127907 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 169920, 8773 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 170166, 126146 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 170289, 126241 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 170477, 74697 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 170592, 161895 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 170680, 115922 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 170875, 9273 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 170875, 143881 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 171477, 8773 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 171477, 16943 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 171563, 8558 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 171740, 598 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 171758, 131334 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 172053, 131924 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 172069, 131334 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 172324, 126146 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 172429, 121496 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 172491, 5204 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 172577, 2845 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 172694, 13 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 173172, 89734 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 173409, 85781 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 173417, 56743 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 174108, 25 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 174109, 25 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 174341, 114745 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 174418, 114745 });

            migrationBuilder.DeleteData(
                table: "MangasRelations",
                keyColumns: new[] { "MangaId", "RelationId" },
                keyValues: new object[] { 174555, 24457 });
        }
    }
}
