using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UTB.Eshop.Mikeska.Web.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CarouselSlide",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ImageSrc = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageAltCZ = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageAltEN = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarouselSlide", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    katCZ = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    katEN = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ImageSrc = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameCZ = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameEN = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescriptionCZ = table.Column<string>(type: "varchar(4096)", maxLength: 4096, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescriptionEN = table.Column<string>(type: "varchar(4096)", maxLength: 4096, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false),
                    IdKategories = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "NOW(6)"),
                    OrderNumber = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalPrice = table.Column<double>(type: "double", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "CarouselSlide",
                columns: new[] { "ID", "ImageAltCZ", "ImageAltEN", "ImageSrc" },
                values: new object[,]
                {
                    { 1, "Štěňata pudlů", "Poodle puppies", "/img/carousel/0.jpg" },
                    { 2, "Psi na procházce", "Dogs on a walk", "/img/carousel/1.jpg" },
                    { 3, "Pudl vrh I", "Poodle letter I", "/img/carousel/2.jpg" },
                    { 4, "Pudl vrh L", "Poodle letter L", "/img/carousel/3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "ID", "katCZ", "katEN" },
                values: new object[,]
                {
                    { 1, "Pes", "Dog" },
                    { 2, "Ostatní", "Other" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "DescriptionCZ", "DescriptionEN", "IdKategories", "ImageSrc", "NameCZ", "NameEN", "Price" },
                values: new object[,]
                {
                    { 1, "Želvy se od ostatních plazů odlišují především tím, že je jejich tělo obvykle chráněno kostěným krunýřem, který se dělí na hřbetní (karapax) a břišní (plastron). Vyvinul se z jejich žeber. Do tohoto řádu se zahrnuje i několik dnes již vyhynulých druhů. Nejstarší druhy blízce příbuzné želvám žily před zhruba 220 miliony let v období triasu (rod Odontochelys), což z nich dělá jednu z nejstarších dosud žijících skupin plazů (o mnoho více než ještěři nebo hadi).[1] Příslušníci skupiny Testudines (želvy) se poprvé prokazatelně objevili ve střední juře. Na světě žije více než 350 druhů želv (k roku 2017 odhadem 356 druhů), řada z nich je silně ohrožených.[2][3] Želvy jsou studenokrevní živočichové, což znamená, že teplota jejich těla se mění podle okolního prostředí. Jsou typicky dlouhověké, někteří jedinci se dožili prokazatelně i více než 180 let, např. želva sloní. Želvy jsou rozšířené prakticky po celém světě (mimo polární oblasti), zejména pak v oblastech s teplejším klimatem", "Turtles are distinguished from other reptiles primarily by the fact that their body is usually protected by a bony shell, which is divided into a dorsal (carapace) and ventral (plastron). It evolved from their ribs. Several now extinct species are included in this order. The earliest species closely related to turtles lived about 220 million years ago in the Triassic period (genus Odontochelys), making them one of the oldest groups of reptiles still living (many more than lizards or snakes).Members of the Testudines (turtles) group were first documented in the Middle Jurassic. There are more than 350 species of turtles in the world (an estimated 356 species as of 2017), many of which are highly endangered.[2][3] Turtles are cold-blooded animals, which means that their body temperature varies according to the surrounding environment. They are typically long-lived, with some individuals having been shown to live to more than 180 years, such as the elephant tortoise. Turtles are distributed virtually worldwide (outside the polar regions), especially in areas with warmer climates", 2, "/img/item/zelva.jpg", "Želva", "Tortoise", 500.0 },
                    { 2, "Perská kočka patří mezi nejstarší čistokrevná plemena koček vůbec. Do Evropy se rozšířila, podle některých pramenů v roce 1626 a dle jiných již roku 1520, patrně z Íránu, Arménie, Turecka či Iráku, avšak za její vlast je obecně považována Anglie. Tyto kočky, které dovezl Nicolas Claude Fabri de Peiresac, byly ale spíše podobné turecké angoře než typické peršance. Současně přivezl Pietro de la Valle další kočky s kulatějšími hlavami a mnohem hustší srstí z Persie. A začalo docházet ke křížení obou plemen, jelikož obě měla dlouhou srst a velmi se k sobě hodila. Peršanka se rychle stala symbolem postavení, moci a bohatství, takže není divu, že si brzo našla cestu na evropské dvory a sídla tehdejší šlechty. Perská kočka s krátkou srstí se nazývá exotická kočka. Je ve všech barevných varietách jako kočka perská. Ve FIFe se tato dvě plemena tj. perská a exotická smí křížit mezi sebou, zatímco jiné světové organizace chovatelů koček (CFA) toto přísně odmítají. Ve vrhu perské a exotické kočky nebo ve vrhu dvou exotických koček se mohou objevit obě dvě plemena. Z chovného páru pouze perských koček se mohou narodit jen perská koťata.\r\n\r\nCílené šlechtění počalo teprve kolem roku 1870 a ze začátku bylo jeho snahou jen uchovat roztomilý panenkovský obličej perské kočky, časem se stalo hlavním cílem vyvíjení nových barevných typů, takže v současnosti můžeme obdivovat více než 60 různých zbarvení peršanek. Na první britské výstavě koček roku 1871 bylo vystaveno velké množství těchto koček a krátce poté byly zveřejněny první standardy plemene. Záhy překročily perské kočky Atlantský oceán a dorazily do USA, kde byly roku 1903 vytvořeny americké standardy pro toto plemeno. Ty se od evropských lehce liší. V Evropě dávají chovatelé přednost méně zavalitému typu, zatímco američtí milovníci koček usilují o kompaktnější stavbu a snaží se docílit bohatší srsti. Američané vyšlechtili kočku s extrémně krátkým nosem – tzv. moderní typ. Posuzovatelé – rozhodčí na výstavě velmi pečlivě hodnotí také zdravotní stav kočky, zejména kontrolují jestli nemá kočka příliš úzké nosní dírky a celkově jestli dobře dýchá, bez námahy a chrčení. V Česku se prvně objevily tyto kočky moderního typu až po Sametové revoluci roku 1989, když se výstavy otevřely západním chovatelům. Do té doby v Česku převládaly kočky s nosy podobnými domácím kočkám.", "The Persian cat is one of the oldest purebred cat breeds ever. It spread to Europe, according to some sources in 1626 and according to others as early as 1520, probably from Iran, Armenia, Turkey or Iraq, but its homeland is generally considered to be England. However, these cats, imported by Nicolas Claude Fabri de Peiresac, were more similar to the Turkish Angora than to the typical Persian. At the same time, Pietro de la Valle brought other cats with rounder heads and much thicker coats from Persia. And the two breeds began to interbreed, as they both had long hair and were very well suited to each other. The Persian quickly became a symbol of status, power and wealth, so it is no wonder that it soon found its way into the European courts and residences of the nobility of the time. A Persian cat with a short coat is called an exotic cat. It comes in all colour varieties like the Persian cat. In FIFe, the two breeds, i.e. Persian and exotic, are allowed to interbreed, while other world cat fanciers' organizations (CFA) strictly refuse this. In a litter of a Persian and an exotic cat or in a litter of two exotic cats, both breeds can appear. Only Persian kittens can be born from a breeding pair of Persian-only cats.\n\nTargeted breeding only began around 1870 and at first it was just to preserve the cute doll-like face of the Persian cat, but over time it became the main goal to develop new colour types, so that today we can admire more than 60 different colours of Persian cats. At the first British Cat Show in 1871, a large number of these cats were exhibited and shortly afterwards the first breed standards were published. Soon the Persian cats crossed the Atlantic Ocean and arrived in the USA, where American standards for the breed were established in 1903. These differ slightly from the European ones. In Europe, breeders prefer a less stocky type, while American cat lovers aim for a more compact build and try to achieve a richer coat. The Americans have bred a cat with an extremely short nose - the so-called modern type. The judges at the show also evaluate the cat's health very carefully, especially checking whether the cat's nostrils are too narrow and whether it breathes well overall, without straining or snorting. In the Czech Republic these modern type cats first appeared after the Velvet Revolution in 1989, when shows were opened to western breeders. Until then, cats with noses similar to domestic cats were predominant in the Czech Republic.", 2, "/img/item/perkocka.jpg", "Perská kočka s PP", "Persian cat with PP", 4500.0 },
                    { 3, "Bišonci jsou energičtí a živí psi, kteří potěší každého svým vzhledem. Jsou trpěliví a láskyplní k dětem. Dobře se přizpůsobují novým podmínkám, proto je můžete snadno vzít na společné rodinné výlety.\r\n\r\n\r\nBišonek je také známý jako Tenerife pes nebo kudrnatý bišon. Jedná se o společenské psy, které chtějí být v centru pozornosti. Rychle se učí a získávají nové dovednosti. Jedná se o typické pokojové psy. Nejsou vhodné pro život venku", "Bichons are energetic and lively dogs that please everyone with their appearance. They are patient and affectionate with children. They adapt well to new conditions, so you can easily take them on family outings together.\n\n\nThe Bichon is also known as the Tenerife dog or the curly-haired Bichon. These are social dogs that want to be the center of attention. They learn quickly and pick up new skills. They are typical room dogs. They are not suitable for life in outside.", 1, "/img/item/bisonek.jpg", "Bišonek s PP", "Bichon with PP", 50000.0 },
                    { 4, "Svým vzhledem nijak nepřipomíná známější pandu velkou, i když žije podobně a hrozí jí tedy podobná nebezpečí. Jejím domovem jsou horské lesy a bambusové houštiny v Číně, Indii, Bhútánu a Barmě.  Podobně jako panda velká má zvláštní „palec“, což je výrůstek zápěstní kosti, ovšem daleko menší. Listy bambusu i jiných rostlin tedy není schopna zdrhnout. Místo toho si za pomoci „palce“ tlapou přitáhne větev a listy okusuje. Do jídelníčku pandy červené patří i ptačí vejce a menší živočichové, nepohrdne ani sladkými plody či kořínky a živí se dokonce i lišejníky. Za potravou se vydává za soumraku a v noci. Žije převážně samotářsky, a tak veškerou péči o mláďata obstarává samice. Připravuje pro své potomky pohodlné hnízdo ve stromové dutině a stará se o ně přinejmenším půl roku.", "In appearance it does not resemble the better-known giant panda, although it lives in a similar way and is therefore threatened by similar dangers. Its home is the mountain forests and bamboo thickets of China, India, Bhutan and Burma.  Like the giant panda, it has a distinctive 'thumb', which is an outgrowth of the wrist bone, but much smaller. It is therefore unable to remove the leaves of bamboo and other plants. Instead, she uses her paw to pull the branch with her \"thumb\" and nibbles the leaves. The red panda's diet also includes bird eggs and smaller animals, and it does not disdain sweet fruits or roots and even feeds on lichens. It forages at dusk and at night. It is largely solitary, so the female takes care of the young. She prepares a comfortable nest for her offspring in a tree cavity and cares for them for at least six months.", 2, "/img/item/pandacervena.jpg", "Panda červená", "Red panda", 150000.0 },
                    { 5, "Královský pudl je největší z příslušníků plemene. Jeho velikost se pohybuje od 45 cm do 60 cm s tolerancí +2 cm. Velký pudl musí být zvětšeninou středního pudla se zachováním stejných charakteristických znaků. Hmotnost by měla být do 30 kg. Má protáhlou, vznešenou hlavu přímých linií s mandlovýma očima. Nos je dobře vyvinutý a barva se odvíjí od barvy srsti. Uši jsou celkem dlouhé, na koncích zakulacené, přilehlé k tvářím. Má středně dlouhý, pevný krk. Jeho postava je téměř čtvercového formátu s krátkým hřbetem a hlubokým hrudníkem, má široká a svalnatá bedra. Jeho tělo je pokryto dlouhou kadeřavou, někdy šňůrovitou srstí, která byla vždy rozmanitým způsobem přistřihována. Existuje několik sestřihů např. „lví\" či „na ovečku\" apod. Srst je hustá, pevná, pružná a neustále dorůstá, vyžaduje tedy pravidelné stříhání. Barva srsti může být černá, hnědá, stříbrná, bílá, apricot (meruňková) nebo červená. Ocas je vysoko nasazený, svírající tupý úhel se hřbetem. Nohy má královský pudl rovné a svalnaté.", "The Royal Poodle is the largest of the breed. Its size ranges from 45 cm to 60 cm with a tolerance of +2 cm. The Large Poodle must be an enlargement of the Medium Poodle, retaining the same characteristics. The weight should be up to 30 kg. It has an elongated, noble head of straight lines with almond-shaped eyes. The nose is well developed and the colour is based on the coat colour. The ears are quite long, rounded at the ends, close to the cheeks. It has a medium-long, firm neck. His build is almost square with a short back and deep chest, and his shoulders are broad and muscular. His body is covered with long, curly, sometimes corded hair, which has always been cut in a variety of ways. There are several haircuts, e.g. 'lion' or 'sheep', etc. The coat is thick, strong, flexible and constantly growing back, so it requires regular trimming. The coat colour can be black, brown, silver, white, apricot or red. The tail is high set, forming an obtuse angle with the back. The legs of the Royal Poodle are straight and muscular.", 1, "/img/item/kingpoodle.jpg", "Pudl královský s PP", "Poodl king with PP", 35000.0 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "9cf14c2c-19e7-40d6-b744-8917505c3106", "Admin", "ADMIN" },
                    { 2, "be0efcde-9d0a-461d-8eb6-444b043d6660", "Manager", "MANAGER" },
                    { 3, "29dafca7-cd20-4cd9-a3dd-4779d7bac3ee", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "b09a83ae-cfd3-4ee7-97e6-fbcf0b0fe78c", "admin@admin.cz", true, "Adminek", "Adminovy", true, null, "ADMIN@ADMIN.CZ", "ADMIN", "AQAAAAEAACcQAAAAEM9O98Suoh2o2JOK1ZOJScgOfQ21odn/k6EYUpGWnrbevCaBFFXrNL7JZxHNczhh/w==", null, false, "SEJEPXC646ZBNCDYSM3H5FRK5RWP2TN6", false, "admin" },
                    { 2, 0, "7a8d96fd-5918-441b-b800-cbafa99de97b", "manager@manager.cz", true, "Managerek", "Managerovy", true, null, "MANAGER@MANAGER.CZ", "MANAGER", "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==", null, false, "MAJXOSATJKOEM4YFF32Y5G2XPR5OFEL6", false, "manager" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 2, 2 },
                    { 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductID",
                table: "OrderItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarouselSlide");

            migrationBuilder.DropTable(
                name: "Kategorie");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
