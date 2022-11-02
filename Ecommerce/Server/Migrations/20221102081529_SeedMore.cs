using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedMore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Title", "price" },
                values: new object[,]
                {
                    { 4, 2, "《钢铁侠》（Iron Man）是由美国漫威电影工作室出品的一部科幻冒险电影，改编自同名系列漫画，由乔恩·费儒执导，小罗伯特·唐尼及格温妮斯·帕特洛、杰夫·布里吉斯等主演。该作也是“漫威电影宇宙”系列的首部电影。该片于2008年4月30日在中国大陆上映、5月2日在美国上映。影片讲述了托尼·史塔克在一次绑架事件后改进了盔甲的功能，化身“钢铁侠”，以一个义务警察的身份保护了这个世界和平的故事。", "https://bkimg.cdn.bcebos.com/pic/dc54564e9258d1097fd45090dc58ccbf6c814dd9?x-bce-process=image/resize,m_lfit,w_345,limit_1", "钢铁侠", 10m },
                    { 5, 2, "《雷神》（Thor）是漫威影业出品的一部科幻动作电影，取材自漫威漫画，是漫威电影宇宙的第四部电影。由肯尼思·布拉纳执导，克里斯·海姆斯沃斯，汤姆·希德勒斯顿，娜塔丽·波特曼等主演。影片讲述了被放逐到地球的索尔·奥丁森学习如何成为一个真正英雄的故事。", "https://bkimg.cdn.bcebos.com/pic/9922720e0cf3d7caa0ab50fbfe1fbe096a63a9da?x-bce-process=image/resize,m_lfit,w_1280,limit_1", "雷神", 20m },
                    { 6, 2, "《复仇者联盟》（Marvel's The Avengers）是漫威影业出品的科幻动作片，取材自漫威漫画，是漫威电影宇宙的第六部电影，同时也是第一阶段的收官作品。由乔斯·韦登执导，小罗伯特·唐尼、克里斯·埃文斯、马克·鲁法洛、克里斯·海姆斯沃斯、斯嘉丽·约翰逊、杰瑞米·雷纳、汤姆·希德勒斯顿、塞缪尔·杰克逊、克拉克·格雷格、寇碧·史莫德斯等联袂出演。影片于2012年5月5日在中国内地正式上映", "https://tse4-mm.cn.bing.net/th/id/OIP-C.Bd2C8XgJ6Cegh6lRYiAd2QAAAA?w=120&h=180&c=7&r=0&o=5&dpr=1.4&pid=1.7", "复仇者联盟", 30m },
                    { 7, 2, "《奇异博士》是由美国漫威影业制作，迪士尼影业公司出品的奇幻动作电影，由斯科特·德瑞克森执导，本尼迪克特·康伯巴奇、蒂尔达·斯文顿、切瓦特·埃加福特、瑞秋·麦克亚当斯、麦斯·米科尔森、本尼迪特·王联合主演。该片讲述了神经外科医生史蒂芬·斯特兰奇在一次车祸中失去了双手的能力，最后在古一法师的帮助下让他成为了拥有超凡魔力的奇异博士。该片于2016年11月4日在中国、美国同步上映。", "https://bkimg.cdn.bcebos.com/pic/9358d109b3de9c821ad518786481800a18d84391?x-bce-process=image/crop,x_0,y_0,w_756,h_1073/resize,m_lfit,h_780,limit_1/quality,Q_70", "奇异博士", 666m },
                    { 8, 2, "2015年佩顿·里德执导的电影《蚁人》（Ant-Man）是漫威影业出品的一部科幻动作电影，取材自漫威漫画，是漫威电影宇宙的第十二部电影、同时也是第二阶段的收官作品。由佩顿·里德执导，保罗·路德、伊万杰琳·莉莉、迈克尔·道格拉斯、寇瑞·斯托尔、朱迪·格雷尔、迈克尔·佩纳、艾比·莱德·弗特森、鲍比·坎纳瓦尔、大卫·达斯马齐连等主演。", "https://bkimg.cdn.bcebos.com/pic/622762d0f703918f93b4fe47543d269758eec4d2?x-bce-process=image/resize,m_lfit,h_168,limit_1", "蚁人", 10m },
                    { 9, 3, "《梦幻西游》是一款由中国网易公司自行开发并营运的网络国产游戏。游戏以著名的章回小说《西游记》故事为背景，透过Q版的人物，试图营造出浪漫的网络游戏风格。", "https://bkimg.cdn.bcebos.com/pic/50da81cb39dbb6fd526690508b74bc18972bd407993f?x-bce-process=image/resize,m_lfit,w_536,limit_1", "梦幻西游", 1999m },
                    { 10, 3, "《穿越火线》（CrossFire，简称CF）是由Smile Gate开发，中国内地由腾讯游戏代理运营的一款第一人称射击游戏。 [81] \r\n游戏讲述了全球两大佣兵集团Global Risk和Black List间的对决。游戏中有团队竞技模式、战队赛、爆破模式、幽灵模式等多种模式。引进了“缺人补充”形式的即时加入系统。 ", "https://bkimg.cdn.bcebos.com/pic/9358d109b3de9c82ac7fd2e16081800a19d84341?x-bce-process=image/resize,m_lfit,w_1280,limit_1", "穿越火线", 888m },
                    { 11, 3, "《地下城与勇士》（DungeonFighter，简称DNF）是由韩国（Neople）开发、中国内地由腾讯游戏代理运营的动作角色扮演ARPG格斗网游。", "https://bkimg.cdn.bcebos.com/pic/c75c10385343fbf26ba61988b07eca8064388f97?x-bce-process=image/resize,m_lfit,w_536,limit_1", "地下城与勇士", 999m },
                    { 12, 3, "《魔兽世界》（World of Warcraft）是由著名游戏公司暴雪娱乐所制作的第一款网络游戏，属于大型多人在线角色扮演游戏。游戏以该公司出品的即时战略游戏《魔兽争霸》的剧情为历史背景，依托魔兽争霸的历史事件和英雄人物，魔兽世界有着完整的历史背景时间线", "https://bkimg.cdn.bcebos.com/pic/cf1b9d16fdfaaf519ede95818e5494eef01f7aca?x-bce-process=image/resize,m_lfit,w_440,limit_1", "魔兽世界", 999m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
