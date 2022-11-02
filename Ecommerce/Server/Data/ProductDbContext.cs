using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Server.Data
{
    public class ProductDbContext: DbContext
    {
        public DbSet<Product> Products { get; set;}

        public DbSet<Category> Categorys { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { 
                Id = 1,
                Name = "Books",
                Url= "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Little Nemo",
                    Description = "温瑟·麦凯（1867到1871年间的某一年出生，1934年逝世[a]）是一位多产的商业艺术家和漫画家，他于1904年开始在报纸上刊载漫画《罗彼特·芬德的梦》[b]，1905年开始连载的《小尼莫》是他的代表作[c][6]。1906年，麦凯开始从事杂耍表演，在观众面前现场表演粉笔独角戏[7]。",
                    ImageURL = "https://tse4-mm.cn.bing.net/th/id/OIP-C.h-bG4w6crJYg_a0_8TXDXgHaLP?w=141&h=215&c=7&r=0&o=5&dpr=1.4&pid=1.7",
                    price = 666,
                    CategoryId = 1,

                },
                new Product
                {
                    Id = 2,
                    Title = "Freedom of Worship",
                    Description = "《信仰自由》是诺曼·洛克威尔《四大自由》系列油画的第二幅。这四幅画的灵感源自第32任美国总统富兰克林·德拉诺·罗斯福1941年1月6日向第77届联邦国会发表的演说，演说中倡导的目标便是“四大自由”。",
                    ImageURL = "https://tse4-mm.cn.bing.net/th/id/OIP-C.4xKEgKi7adbQk0yAb82JZgHaJl?w=189&h=245&c=7&r=0&o=5&dpr=1.4&pid=1.7",
                    price = 10,
                    CategoryId = 1,

                },
                new Product
                {
                    Id = 3,
                    Title = "Maus",
                    Description = "情节从1978年的纽约开始，斯皮格曼聆听父亲弗拉德克谈论纳粹大屠杀期间的经历，为准备创作的《鼠族》收集素材。接下来书中根据这些经历从第二次世界大战前几年开始叙述，直至作者的父母从纳粹集中营解放。大部分情节围绕斯皮格曼和父亲之间的紧张关系展开，同时着重描绘20岁那年母亲自尽对作者的影响，弗拉德克悲痛欲绝并毁掉亡妻留下的奥斯威辛集中营回忆录。全书采用极简主义绘画风格，在节奏、结构和页面布局上颇有新意。",
                    ImageURL = "https://tse4-mm.cn.bing.net/th/id/OIP-C.Bd2C8XgJ6Cegh6lRYiAd2QAAAA?w=120&h=180&c=7&r=0&o=5&dpr=1.4&pid=1.7",
                    price = 999,
                    CategoryId = 1


                },
                new Product
                {
                    Id = 4,
                    Title = "钢铁侠",
                    Description = "《钢铁侠》（Iron Man）是由美国漫威电影工作室出品的一部科幻冒险电影，改编自同名系列漫画，由乔恩·费儒执导，小罗伯特·唐尼及格温妮斯·帕特洛、杰夫·布里吉斯等主演。该作也是“漫威电影宇宙”系列的首部电影。该片于2008年4月30日在中国大陆上映、5月2日在美国上映。影片讲述了托尼·史塔克在一次绑架事件后改进了盔甲的功能，化身“钢铁侠”，以一个义务警察的身份保护了这个世界和平的故事。",
                    ImageURL = "https://bkimg.cdn.bcebos.com/pic/dc54564e9258d1097fd45090dc58ccbf6c814dd9?x-bce-process=image/resize,m_lfit,w_345,limit_1",
                    price = 10,
                    CategoryId = 2,

                },
                new Product
                {
                    Id = 5,
                    Title = "雷神",
                    Description = "《雷神》（Thor）是漫威影业出品的一部科幻动作电影，取材自漫威漫画，是漫威电影宇宙的第四部电影。由肯尼思·布拉纳执导，克里斯·海姆斯沃斯，汤姆·希德勒斯顿，娜塔丽·波特曼等主演。影片讲述了被放逐到地球的索尔·奥丁森学习如何成为一个真正英雄的故事。",
                    ImageURL = "https://bkimg.cdn.bcebos.com/pic/9922720e0cf3d7caa0ab50fbfe1fbe096a63a9da?x-bce-process=image/resize,m_lfit,w_1280,limit_1",
                    price = 20,
                    CategoryId = 2,

                },
                new Product
                {
                    Id = 6,
                    Title = "复仇者联盟",
                    Description = "《复仇者联盟》（Marvel's The Avengers）是漫威影业出品的科幻动作片，取材自漫威漫画，是漫威电影宇宙的第六部电影，同时也是第一阶段的收官作品。由乔斯·韦登执导，小罗伯特·唐尼、克里斯·埃文斯、马克·鲁法洛、克里斯·海姆斯沃斯、斯嘉丽·约翰逊、杰瑞米·雷纳、汤姆·希德勒斯顿、塞缪尔·杰克逊、克拉克·格雷格、寇碧·史莫德斯等联袂出演。影片于2012年5月5日在中国内地正式上映",
                    ImageURL = "https://tse4-mm.cn.bing.net/th/id/OIP-C.Bd2C8XgJ6Cegh6lRYiAd2QAAAA?w=120&h=180&c=7&r=0&o=5&dpr=1.4&pid=1.7",
                    price = 30,
                    CategoryId = 2


                },
                new Product
                {
                    Id = 7,
                    Title = "奇异博士",
                    Description = "《奇异博士》是由美国漫威影业制作，迪士尼影业公司出品的奇幻动作电影，由斯科特·德瑞克森执导，本尼迪克特·康伯巴奇、蒂尔达·斯文顿、切瓦特·埃加福特、瑞秋·麦克亚当斯、麦斯·米科尔森、本尼迪特·王联合主演。该片讲述了神经外科医生史蒂芬·斯特兰奇在一次车祸中失去了双手的能力，最后在古一法师的帮助下让他成为了拥有超凡魔力的奇异博士。该片于2016年11月4日在中国、美国同步上映。",
                    ImageURL = "https://bkimg.cdn.bcebos.com/pic/9358d109b3de9c821ad518786481800a18d84391?x-bce-process=image/crop,x_0,y_0,w_756,h_1073/resize,m_lfit,h_780,limit_1/quality,Q_70",
                    price = 666,
                    CategoryId = 2,

                },
                new Product
                {
                    Id = 8,
                    Title = "蚁人",
                    Description = "2015年佩顿·里德执导的电影《蚁人》（Ant-Man）是漫威影业出品的一部科幻动作电影，取材自漫威漫画，是漫威电影宇宙的第十二部电影、同时也是第二阶段的收官作品。由佩顿·里德执导，保罗·路德、伊万杰琳·莉莉、迈克尔·道格拉斯、寇瑞·斯托尔、朱迪·格雷尔、迈克尔·佩纳、艾比·莱德·弗特森、鲍比·坎纳瓦尔、大卫·达斯马齐连等主演。",
                    ImageURL = "https://bkimg.cdn.bcebos.com/pic/622762d0f703918f93b4fe47543d269758eec4d2?x-bce-process=image/resize,m_lfit,h_168,limit_1",
                    price = 10,
                    CategoryId = 2,

                },
                new Product
                {
                    Id = 9,
                    Title = "梦幻西游",
                    Description = "《梦幻西游》是一款由中国网易公司自行开发并营运的网络国产游戏。游戏以著名的章回小说《西游记》故事为背景，透过Q版的人物，试图营造出浪漫的网络游戏风格。",
                    ImageURL = "https://bkimg.cdn.bcebos.com/pic/50da81cb39dbb6fd526690508b74bc18972bd407993f?x-bce-process=image/resize,m_lfit,w_536,limit_1",
                    price = 1999,
                    CategoryId = 3


                },
                new Product
                {
                    Id = 10,
                    Title = "穿越火线",
                    Description = "《穿越火线》（CrossFire，简称CF）是由Smile Gate开发，中国内地由腾讯游戏代理运营的一款第一人称射击游戏。 [81] \r\n游戏讲述了全球两大佣兵集团Global Risk和Black List间的对决。游戏中有团队竞技模式、战队赛、爆破模式、幽灵模式等多种模式。引进了“缺人补充”形式的即时加入系统。 ",
                    ImageURL = "https://bkimg.cdn.bcebos.com/pic/9358d109b3de9c82ac7fd2e16081800a19d84341?x-bce-process=image/resize,m_lfit,w_1280,limit_1",
                    price = 888,
                    CategoryId = 3,

                },
                new Product
                {
                    Id = 11,
                    Title = "地下城与勇士",
                    Description = "《地下城与勇士》（DungeonFighter，简称DNF）是由韩国（Neople）开发、中国内地由腾讯游戏代理运营的动作角色扮演ARPG格斗网游。",
                    ImageURL = "https://bkimg.cdn.bcebos.com/pic/c75c10385343fbf26ba61988b07eca8064388f97?x-bce-process=image/resize,m_lfit,w_536,limit_1",
                    price = 999,
                    CategoryId = 3,

                },
                new Product
                {
                    Id = 12,
                    Title = "魔兽世界",
                    Description = "《魔兽世界》（World of Warcraft）是由著名游戏公司暴雪娱乐所制作的第一款网络游戏，属于大型多人在线角色扮演游戏。游戏以该公司出品的即时战略游戏《魔兽争霸》的剧情为历史背景，依托魔兽争霸的历史事件和英雄人物，魔兽世界有着完整的历史背景时间线",
                    ImageURL = "https://bkimg.cdn.bcebos.com/pic/cf1b9d16fdfaaf519ede95818e5494eef01f7aca?x-bce-process=image/resize,m_lfit,w_440,limit_1",
                    price = 999,
                    CategoryId = 3
                });
        }
    }
}
