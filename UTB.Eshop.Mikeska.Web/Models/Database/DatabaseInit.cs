using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Mikeska.Web.Models.Entities;
using UTB.Eshop.Mikeska.Web.Models.Identity;

namespace UTB.Eshop.Mikeska.Web.Models.Database
{
    public class DatabaseInit
    {
        public List<CarouselSlide> CreateCarouselSlides()
        {
            List<CarouselSlide> carouselSlides = new List<CarouselSlide>();


            CarouselSlide cs1 = new CarouselSlide()
            {
                ID = 1,
                ImageSrc = "/img/carousel/0.jpg",
                ImageAltCZ = "Štěňata pudlů",
                ImageAltEN = "Poodle puppies"
            };

            CarouselSlide cs2 = new CarouselSlide()
            {
                ID = 2,
                ImageSrc = "/img/carousel/1.jpg",
                ImageAltCZ = "Psi na procházce",
                ImageAltEN = "Dogs on a walk"
            };

            CarouselSlide cs3 = new CarouselSlide()
            {
                ID = 3,
                ImageSrc = "/img/carousel/2.jpg",
                ImageAltCZ = "Pudl vrh I",
                ImageAltEN = "Poodle letter I"
            };

            CarouselSlide cs4 = new CarouselSlide()
            {
                ID = 4,
                ImageSrc = "/img/carousel/3.jpg",
                ImageAltCZ = "Pudl vrh L",
                ImageAltEN = "Poodle letter L"
            };

            carouselSlides.Add(cs1);
            carouselSlides.Add(cs2);
            carouselSlides.Add(cs3);
            carouselSlides.Add(cs4);

            return carouselSlides;
        }

        public List<Product> CreateProducts()
        {
            List<Product> products = new List<Product>();


            Product cs1 = new Product()
            {
                ID = 1,
                ImageSrc = "/img/item/zelva.jpg",
                NameCZ = "Želva s PP samice",
                NameEN = "Tortoise with PP female",
                DescriptionCZ = "Želvy se od ostatních plazů odlišují především tím, že je jejich tělo obvykle chráněno kostěným krunýřem, který se dělí na hřbetní (karapax) a břišní (plastron). Vyvinul se z jejich žeber. Do tohoto řádu se zahrnuje i několik dnes již vyhynulých druhů. Nejstarší druhy blízce příbuzné želvám žily před zhruba 220 miliony let v období triasu (rod Odontochelys), což z nich dělá jednu z nejstarších dosud žijících skupin plazů (o mnoho více než ještěři nebo hadi).[1] Příslušníci skupiny Testudines (želvy) se poprvé prokazatelně objevili ve střední juře. Na světě žije více než 350 druhů želv (k roku 2017 odhadem 356 druhů), řada z nich je silně ohrožených.[2][3] Želvy jsou studenokrevní živočichové, což znamená, že teplota jejich těla se mění podle okolního prostředí. Jsou typicky dlouhověké, někteří jedinci se dožili prokazatelně i více než 180 let, např. želva sloní. Želvy jsou rozšířené prakticky po celém světě (mimo polární oblasti), zejména pak v oblastech s teplejším klimatem",
                DescriptionEN = "Turtles are distinguished from other reptiles primarily by the fact that their body is usually protected by a bony shell, which is divided into a dorsal (carapace) and ventral (plastron). It evolved from their ribs. Several now extinct species are included in this order. The earliest species closely related to turtles lived about 220 million years ago in the Triassic period (genus Odontochelys), making them one of the oldest groups of reptiles still living (many more than lizards or snakes).Members of the Testudines (turtles) group were first documented in the Middle Jurassic. There are more than 350 species of turtles in the world (an estimated 356 species as of 2017), many of which are highly endangered.[2][3] Turtles are cold-blooded animals, which means that their body temperature varies according to the surrounding environment. They are typically long-lived, with some individuals having been shown to live to more than 180 years, such as the elephant tortoise. Turtles are distributed virtually worldwide (outside the polar regions), especially in areas with warmer climates",
                Price = 500,
                IdKategories = 2
            };

            Product cs2 = new Product()
            {
                ID = 2,
                ImageSrc = "/img/item/perkocka.jpg",
                NameCZ = "Perská kočka s PP samice",
                NameEN = "Persian cat with PP female",
                DescriptionCZ = "Perská kočka patří mezi nejstarší čistokrevná plemena koček vůbec. Do Evropy se rozšířila, podle některých pramenů v roce 1626 a dle jiných již roku 1520, patrně z Íránu, Arménie, Turecka či Iráku, avšak za její vlast je obecně považována Anglie. Tyto kočky, které dovezl Nicolas Claude Fabri de Peiresac, byly ale spíše podobné turecké angoře než typické peršance. Současně přivezl Pietro de la Valle další kočky s kulatějšími hlavami a mnohem hustší srstí z Persie. A začalo docházet ke křížení obou plemen, jelikož obě měla dlouhou srst a velmi se k sobě hodila. Peršanka se rychle stala symbolem postavení, moci a bohatství, takže není divu, že si brzo našla cestu na evropské dvory a sídla tehdejší šlechty. Perská kočka s krátkou srstí se nazývá exotická kočka. Je ve všech barevných varietách jako kočka perská. Ve FIFe se tato dvě plemena tj. perská a exotická smí křížit mezi sebou, zatímco jiné světové organizace chovatelů koček (CFA) toto přísně odmítají. Ve vrhu perské a exotické kočky nebo ve vrhu dvou exotických koček se mohou objevit obě dvě plemena. Z chovného páru pouze perských koček se mohou narodit jen perská koťata.\r\n\r\nCílené šlechtění počalo teprve kolem roku 1870 a ze začátku bylo jeho snahou jen uchovat roztomilý panenkovský obličej perské kočky, časem se stalo hlavním cílem vyvíjení nových barevných typů, takže v současnosti můžeme obdivovat více než 60 různých zbarvení peršanek. Na první britské výstavě koček roku 1871 bylo vystaveno velké množství těchto koček a krátce poté byly zveřejněny první standardy plemene. Záhy překročily perské kočky Atlantský oceán a dorazily do USA, kde byly roku 1903 vytvořeny americké standardy pro toto plemeno. Ty se od evropských lehce liší. V Evropě dávají chovatelé přednost méně zavalitému typu, zatímco američtí milovníci koček usilují o kompaktnější stavbu a snaží se docílit bohatší srsti. Američané vyšlechtili kočku s extrémně krátkým nosem – tzv. moderní typ. Posuzovatelé – rozhodčí na výstavě velmi pečlivě hodnotí také zdravotní stav kočky, zejména kontrolují jestli nemá kočka příliš úzké nosní dírky a celkově jestli dobře dýchá, bez námahy a chrčení. V Česku se prvně objevily tyto kočky moderního typu až po Sametové revoluci roku 1989, když se výstavy otevřely západním chovatelům. Do té doby v Česku převládaly kočky s nosy podobnými domácím kočkám.",
                DescriptionEN = "The Persian cat is one of the oldest purebred cat breeds ever. It spread to Europe, according to some sources in 1626 and according to others as early as 1520, probably from Iran, Armenia, Turkey or Iraq, but its homeland is generally considered to be England. However, these cats, imported by Nicolas Claude Fabri de Peiresac, were more similar to the Turkish Angora than to the typical Persian. At the same time, Pietro de la Valle brought other cats with rounder heads and much thicker coats from Persia. And the two breeds began to interbreed, as they both had long hair and were very well suited to each other. The Persian quickly became a symbol of status, power and wealth, so it is no wonder that it soon found its way into the European courts and residences of the nobility of the time. A Persian cat with a short coat is called an exotic cat. It comes in all colour varieties like the Persian cat. In FIFe, the two breeds, i.e. Persian and exotic, are allowed to interbreed, while other world cat fanciers' organizations (CFA) strictly refuse this. In a litter of a Persian and an exotic cat or in a litter of two exotic cats, both breeds can appear. Only Persian kittens can be born from a breeding pair of Persian-only cats.\n\nTargeted breeding only began around 1870 and at first it was just to preserve the cute doll-like face of the Persian cat, but over time it became the main goal to develop new colour types, so that today we can admire more than 60 different colours of Persian cats. At the first British Cat Show in 1871, a large number of these cats were exhibited and shortly afterwards the first breed standards were published. Soon the Persian cats crossed the Atlantic Ocean and arrived in the USA, where American standards for the breed were established in 1903. These differ slightly from the European ones. In Europe, breeders prefer a less stocky type, while American cat lovers aim for a more compact build and try to achieve a richer coat. The Americans have bred a cat with an extremely short nose - the so-called modern type. The judges at the show also evaluate the cat's health very carefully, especially checking whether the cat's nostrils are too narrow and whether it breathes well overall, without straining or snorting. In the Czech Republic these modern type cats first appeared after the Velvet Revolution in 1989, when shows were opened to western breeders. Until then, cats with noses similar to domestic cats were predominant in the Czech Republic.",
                Price = 4500,
                IdKategories = 2
            };

            Product cs3 = new Product()
            {
                ID = 3,
                ImageSrc = "/img/item/bisonek.jpg",
                NameCZ = "Bišonek s PP fenka",
                NameEN = "Bichon with PP female",
                DescriptionCZ = "Bišonci jsou energičtí a živí psi, kteří potěší každého svým vzhledem. Jsou trpěliví a láskyplní k dětem. Dobře se přizpůsobují novým podmínkám, proto je můžete snadno vzít na společné rodinné výlety.\r\n\r\n\r\nBišonek je také známý jako Tenerife pes nebo kudrnatý bišon. Jedná se o společenské psy, které chtějí být v centru pozornosti. Rychle se učí a získávají nové dovednosti. Jedná se o typické pokojové psy. Nejsou vhodné pro život venku",
                DescriptionEN = "Bichons are energetic and lively dogs that please everyone with their appearance. They are patient and affectionate with children. They adapt well to new conditions, so you can easily take them on family outings together.\n\n\nThe Bichon is also known as the Tenerife dog or the curly-haired Bichon. These are social dogs that want to be the center of attention. They learn quickly and pick up new skills. They are typical room dogs. They are not suitable for life in outside.",

                Price = 50000,
                IdKategories = 1
            };

            Product cs4 = new Product()
            {
                ID = 4,
                ImageSrc = "/img/item/pandacervena.jpg",
                NameCZ = "Panda červená s PP samice",
                NameEN = "Red panda with PP female",
                DescriptionCZ = "Svým vzhledem nijak nepřipomíná známější pandu velkou, i když žije podobně a hrozí jí tedy podobná nebezpečí. Jejím domovem jsou horské lesy a bambusové houštiny v Číně, Indii, Bhútánu a Barmě.  Podobně jako panda velká má zvláštní „palec“, což je výrůstek zápěstní kosti, ovšem daleko menší. Listy bambusu i jiných rostlin tedy není schopna zdrhnout. Místo toho si za pomoci „palce“ tlapou přitáhne větev a listy okusuje. Do jídelníčku pandy červené patří i ptačí vejce a menší živočichové, nepohrdne ani sladkými plody či kořínky a živí se dokonce i lišejníky. Za potravou se vydává za soumraku a v noci. Žije převážně samotářsky, a tak veškerou péči o mláďata obstarává samice. Připravuje pro své potomky pohodlné hnízdo ve stromové dutině a stará se o ně přinejmenším půl roku.",
                DescriptionEN = "In appearance it does not resemble the better-known giant panda, although it lives in a similar way and is therefore threatened by similar dangers. Its home is the mountain forests and bamboo thickets of China, India, Bhutan and Burma.  Like the giant panda, it has a distinctive 'thumb', which is an outgrowth of the wrist bone, but much smaller. It is therefore unable to remove the leaves of bamboo and other plants. Instead, she uses her paw to pull the branch with her \"thumb\" and nibbles the leaves. The red panda's diet also includes bird eggs and smaller animals, and it does not disdain sweet fruits or roots and even feeds on lichens. It forages at dusk and at night. It is largely solitary, so the female takes care of the young. She prepares a comfortable nest for her offspring in a tree cavity and cares for them for at least six months.",
                Price = 150000,
                IdKategories = 2
            };

            Product cs5 = new Product()
            {
                ID = 5,
                ImageSrc = "/img/item/kingpoodle.jpg",
                NameCZ = "Pudl královský s PP fenka",
                NameEN = "Poodl king with PP female",
                DescriptionCZ = "Královský pudl je největší z příslušníků plemene. Jeho velikost se pohybuje od 45 cm do 60 cm s tolerancí +2 cm. Velký pudl musí být zvětšeninou středního pudla se zachováním stejných charakteristických znaků. Hmotnost by měla být do 30 kg. Má protáhlou, vznešenou hlavu přímých linií s mandlovýma očima. Nos je dobře vyvinutý a barva se odvíjí od barvy srsti. Uši jsou celkem dlouhé, na koncích zakulacené, přilehlé k tvářím. Má středně dlouhý, pevný krk. Jeho postava je téměř čtvercového formátu s krátkým hřbetem a hlubokým hrudníkem, má široká a svalnatá bedra. Jeho tělo je pokryto dlouhou kadeřavou, někdy šňůrovitou srstí, která byla vždy rozmanitým způsobem přistřihována. Existuje několik sestřihů např. „lví\" či „na ovečku\" apod. Srst je hustá, pevná, pružná a neustále dorůstá, vyžaduje tedy pravidelné stříhání. Barva srsti může být černá, hnědá, stříbrná, bílá, apricot (meruňková) nebo červená. Ocas je vysoko nasazený, svírající tupý úhel se hřbetem. Nohy má královský pudl rovné a svalnaté.",
                DescriptionEN = "The Royal Poodle is the largest of the breed. Its size ranges from 45 cm to 60 cm with a tolerance of +2 cm. The Large Poodle must be an enlargement of the Medium Poodle, retaining the same characteristics. The weight should be up to 30 kg. It has an elongated, noble head of straight lines with almond-shaped eyes. The nose is well developed and the colour is based on the coat colour. The ears are quite long, rounded at the ends, close to the cheeks. It has a medium-long, firm neck. His build is almost square with a short back and deep chest, and his shoulders are broad and muscular. His body is covered with long, curly, sometimes corded hair, which has always been cut in a variety of ways. There are several haircuts, e.g. 'lion' or 'sheep', etc. The coat is thick, strong, flexible and constantly growing back, so it requires regular trimming. The coat colour can be black, brown, silver, white, apricot or red. The tail is high set, forming an obtuse angle with the back. The legs of the Royal Poodle are straight and muscular.",
                Price = 45000,
                IdKategories = 1
            };

            Product cs6 = new Product()
            {
                ID = 6,
                ImageSrc = "/img/item/zelva.jpg",
                NameCZ = "Želva s PP samec",
                NameEN = "Tortoise with PP male",
                DescriptionCZ = "Želvy se od ostatních plazů odlišují především tím, že je jejich tělo obvykle chráněno kostěným krunýřem, který se dělí na hřbetní (karapax) a břišní (plastron). Vyvinul se z jejich žeber. Do tohoto řádu se zahrnuje i několik dnes již vyhynulých druhů. Nejstarší druhy blízce příbuzné želvám žily před zhruba 220 miliony let v období triasu (rod Odontochelys), což z nich dělá jednu z nejstarších dosud žijících skupin plazů (o mnoho více než ještěři nebo hadi).[1] Příslušníci skupiny Testudines (želvy) se poprvé prokazatelně objevili ve střední juře. Na světě žije více než 350 druhů želv (k roku 2017 odhadem 356 druhů), řada z nich je silně ohrožených.[2][3] Želvy jsou studenokrevní živočichové, což znamená, že teplota jejich těla se mění podle okolního prostředí. Jsou typicky dlouhověké, někteří jedinci se dožili prokazatelně i více než 180 let, např. želva sloní. Želvy jsou rozšířené prakticky po celém světě (mimo polární oblasti), zejména pak v oblastech s teplejším klimatem",
                DescriptionEN = "Turtles are distinguished from other reptiles primarily by the fact that their body is usually protected by a bony shell, which is divided into a dorsal (carapace) and ventral (plastron). It evolved from their ribs. Several now extinct species are included in this order. The earliest species closely related to turtles lived about 220 million years ago in the Triassic period (genus Odontochelys), making them one of the oldest groups of reptiles still living (many more than lizards or snakes).Members of the Testudines (turtles) group were first documented in the Middle Jurassic. There are more than 350 species of turtles in the world (an estimated 356 species as of 2017), many of which are highly endangered.[2][3] Turtles are cold-blooded animals, which means that their body temperature varies according to the surrounding environment. They are typically long-lived, with some individuals having been shown to live to more than 180 years, such as the elephant tortoise. Turtles are distributed virtually worldwide (outside the polar regions), especially in areas with warmer climates",
                Price = 450,
                IdKategories = 2
            };

            Product cs7 = new Product()
            {
                ID = 7,
                ImageSrc = "/img/item/perkocka.jpg",
                NameCZ = "Perská kočka s PP samec",
                NameEN = "Persian cat with PP male",
                DescriptionCZ = "Perská kočka patří mezi nejstarší čistokrevná plemena koček vůbec. Do Evropy se rozšířila, podle některých pramenů v roce 1626 a dle jiných již roku 1520, patrně z Íránu, Arménie, Turecka či Iráku, avšak za její vlast je obecně považována Anglie. Tyto kočky, které dovezl Nicolas Claude Fabri de Peiresac, byly ale spíše podobné turecké angoře než typické peršance. Současně přivezl Pietro de la Valle další kočky s kulatějšími hlavami a mnohem hustší srstí z Persie. A začalo docházet ke křížení obou plemen, jelikož obě měla dlouhou srst a velmi se k sobě hodila. Peršanka se rychle stala symbolem postavení, moci a bohatství, takže není divu, že si brzo našla cestu na evropské dvory a sídla tehdejší šlechty. Perská kočka s krátkou srstí se nazývá exotická kočka. Je ve všech barevných varietách jako kočka perská. Ve FIFe se tato dvě plemena tj. perská a exotická smí křížit mezi sebou, zatímco jiné světové organizace chovatelů koček (CFA) toto přísně odmítají. Ve vrhu perské a exotické kočky nebo ve vrhu dvou exotických koček se mohou objevit obě dvě plemena. Z chovného páru pouze perských koček se mohou narodit jen perská koťata.\r\n\r\nCílené šlechtění počalo teprve kolem roku 1870 a ze začátku bylo jeho snahou jen uchovat roztomilý panenkovský obličej perské kočky, časem se stalo hlavním cílem vyvíjení nových barevných typů, takže v současnosti můžeme obdivovat více než 60 různých zbarvení peršanek. Na první britské výstavě koček roku 1871 bylo vystaveno velké množství těchto koček a krátce poté byly zveřejněny první standardy plemene. Záhy překročily perské kočky Atlantský oceán a dorazily do USA, kde byly roku 1903 vytvořeny americké standardy pro toto plemeno. Ty se od evropských lehce liší. V Evropě dávají chovatelé přednost méně zavalitému typu, zatímco američtí milovníci koček usilují o kompaktnější stavbu a snaží se docílit bohatší srsti. Američané vyšlechtili kočku s extrémně krátkým nosem – tzv. moderní typ. Posuzovatelé – rozhodčí na výstavě velmi pečlivě hodnotí také zdravotní stav kočky, zejména kontrolují jestli nemá kočka příliš úzké nosní dírky a celkově jestli dobře dýchá, bez námahy a chrčení. V Česku se prvně objevily tyto kočky moderního typu až po Sametové revoluci roku 1989, když se výstavy otevřely západním chovatelům. Do té doby v Česku převládaly kočky s nosy podobnými domácím kočkám.",
                DescriptionEN = "The Persian cat is one of the oldest purebred cat breeds ever. It spread to Europe, according to some sources in 1626 and according to others as early as 1520, probably from Iran, Armenia, Turkey or Iraq, but its homeland is generally considered to be England. However, these cats, imported by Nicolas Claude Fabri de Peiresac, were more similar to the Turkish Angora than to the typical Persian. At the same time, Pietro de la Valle brought other cats with rounder heads and much thicker coats from Persia. And the two breeds began to interbreed, as they both had long hair and were very well suited to each other. The Persian quickly became a symbol of status, power and wealth, so it is no wonder that it soon found its way into the European courts and residences of the nobility of the time. A Persian cat with a short coat is called an exotic cat. It comes in all colour varieties like the Persian cat. In FIFe, the two breeds, i.e. Persian and exotic, are allowed to interbreed, while other world cat fanciers' organizations (CFA) strictly refuse this. In a litter of a Persian and an exotic cat or in a litter of two exotic cats, both breeds can appear. Only Persian kittens can be born from a breeding pair of Persian-only cats.\n\nTargeted breeding only began around 1870 and at first it was just to preserve the cute doll-like face of the Persian cat, but over time it became the main goal to develop new colour types, so that today we can admire more than 60 different colours of Persian cats. At the first British Cat Show in 1871, a large number of these cats were exhibited and shortly afterwards the first breed standards were published. Soon the Persian cats crossed the Atlantic Ocean and arrived in the USA, where American standards for the breed were established in 1903. These differ slightly from the European ones. In Europe, breeders prefer a less stocky type, while American cat lovers aim for a more compact build and try to achieve a richer coat. The Americans have bred a cat with an extremely short nose - the so-called modern type. The judges at the show also evaluate the cat's health very carefully, especially checking whether the cat's nostrils are too narrow and whether it breathes well overall, without straining or snorting. In the Czech Republic these modern type cats first appeared after the Velvet Revolution in 1989, when shows were opened to western breeders. Until then, cats with noses similar to domestic cats were predominant in the Czech Republic.",
                Price = 4300,
                IdKategories = 2
            };

            Product cs8 = new Product()
            {
                ID = 8,
                ImageSrc = "/img/item/bisonek.jpg",
                NameCZ = "Bišonek s PP pes",
                NameEN = "Bichon with PP male",
                DescriptionCZ = "Bišonci jsou energičtí a živí psi, kteří potěší každého svým vzhledem. Jsou trpěliví a láskyplní k dětem. Dobře se přizpůsobují novým podmínkám, proto je můžete snadno vzít na společné rodinné výlety.\r\n\r\n\r\nBišonek je také známý jako Tenerife pes nebo kudrnatý bišon. Jedná se o společenské psy, které chtějí být v centru pozornosti. Rychle se učí a získávají nové dovednosti. Jedná se o typické pokojové psy. Nejsou vhodné pro život venku",
                DescriptionEN = "Bichons are energetic and lively dogs that please everyone with their appearance. They are patient and affectionate with children. They adapt well to new conditions, so you can easily take them on family outings together.\n\n\nThe Bichon is also known as the Tenerife dog or the curly-haired Bichon. These are social dogs that want to be the center of attention. They learn quickly and pick up new skills. They are typical room dogs. They are not suitable for life in outside.",

                Price = 48000,
                IdKategories = 1
            };

            Product cs9 = new Product()
            {
                ID = 9,
                ImageSrc = "/img/item/pandacervena.jpg",
                NameCZ = "Panda červená s PP samec",
                NameEN = "Red panda with PP male",
                DescriptionCZ = "Svým vzhledem nijak nepřipomíná známější pandu velkou, i když žije podobně a hrozí jí tedy podobná nebezpečí. Jejím domovem jsou horské lesy a bambusové houštiny v Číně, Indii, Bhútánu a Barmě.  Podobně jako panda velká má zvláštní „palec“, což je výrůstek zápěstní kosti, ovšem daleko menší. Listy bambusu i jiných rostlin tedy není schopna zdrhnout. Místo toho si za pomoci „palce“ tlapou přitáhne větev a listy okusuje. Do jídelníčku pandy červené patří i ptačí vejce a menší živočichové, nepohrdne ani sladkými plody či kořínky a živí se dokonce i lišejníky. Za potravou se vydává za soumraku a v noci. Žije převážně samotářsky, a tak veškerou péči o mláďata obstarává samice. Připravuje pro své potomky pohodlné hnízdo ve stromové dutině a stará se o ně přinejmenším půl roku.",
                DescriptionEN = "In appearance it does not resemble the better-known giant panda, although it lives in a similar way and is therefore threatened by similar dangers. Its home is the mountain forests and bamboo thickets of China, India, Bhutan and Burma.  Like the giant panda, it has a distinctive 'thumb', which is an outgrowth of the wrist bone, but much smaller. It is therefore unable to remove the leaves of bamboo and other plants. Instead, she uses her paw to pull the branch with her \"thumb\" and nibbles the leaves. The red panda's diet also includes bird eggs and smaller animals, and it does not disdain sweet fruits or roots and even feeds on lichens. It forages at dusk and at night. It is largely solitary, so the female takes care of the young. She prepares a comfortable nest for her offspring in a tree cavity and cares for them for at least six months.",
                Price = 150000,
                IdKategories = 2
            };

            Product cs10 = new Product()
            {
                ID = 10,
                ImageSrc = "/img/item/kingpoodle.jpg",
                NameCZ = "Pudl královský s PP pes",
                NameEN = "Poodl king with PP male",
                DescriptionCZ = "Královský pudl je největší z příslušníků plemene. Jeho velikost se pohybuje od 45 cm do 60 cm s tolerancí +2 cm. Velký pudl musí být zvětšeninou středního pudla se zachováním stejných charakteristických znaků. Hmotnost by měla být do 30 kg. Má protáhlou, vznešenou hlavu přímých linií s mandlovýma očima. Nos je dobře vyvinutý a barva se odvíjí od barvy srsti. Uši jsou celkem dlouhé, na koncích zakulacené, přilehlé k tvářím. Má středně dlouhý, pevný krk. Jeho postava je téměř čtvercového formátu s krátkým hřbetem a hlubokým hrudníkem, má široká a svalnatá bedra. Jeho tělo je pokryto dlouhou kadeřavou, někdy šňůrovitou srstí, která byla vždy rozmanitým způsobem přistřihována. Existuje několik sestřihů např. „lví\" či „na ovečku\" apod. Srst je hustá, pevná, pružná a neustále dorůstá, vyžaduje tedy pravidelné stříhání. Barva srsti může být černá, hnědá, stříbrná, bílá, apricot (meruňková) nebo červená. Ocas je vysoko nasazený, svírající tupý úhel se hřbetem. Nohy má královský pudl rovné a svalnaté.",
                DescriptionEN = "The Royal Poodle is the largest of the breed. Its size ranges from 45 cm to 60 cm with a tolerance of +2 cm. The Large Poodle must be an enlargement of the Medium Poodle, retaining the same characteristics. The weight should be up to 30 kg. It has an elongated, noble head of straight lines with almond-shaped eyes. The nose is well developed and the colour is based on the coat colour. The ears are quite long, rounded at the ends, close to the cheeks. It has a medium-long, firm neck. His build is almost square with a short back and deep chest, and his shoulders are broad and muscular. His body is covered with long, curly, sometimes corded hair, which has always been cut in a variety of ways. There are several haircuts, e.g. 'lion' or 'sheep', etc. The coat is thick, strong, flexible and constantly growing back, so it requires regular trimming. The coat colour can be black, brown, silver, white, apricot or red. The tail is high set, forming an obtuse angle with the back. The legs of the Royal Poodle are straight and muscular.",
                Price = 35000,
                IdKategories = 1
            };

            Product cs11 = new Product()
            {
                ID = 11,
                ImageSrc = "/img/item/zelva.jpg",
                NameCZ = "Želva bez PP samice",
                NameEN = "Tortoise withhout PP female",
                DescriptionCZ = "Želvy se od ostatních plazů odlišují především tím, že je jejich tělo obvykle chráněno kostěným krunýřem, který se dělí na hřbetní (karapax) a břišní (plastron). Vyvinul se z jejich žeber. Do tohoto řádu se zahrnuje i několik dnes již vyhynulých druhů. Nejstarší druhy blízce příbuzné želvám žily před zhruba 220 miliony let v období triasu (rod Odontochelys), což z nich dělá jednu z nejstarších dosud žijících skupin plazů (o mnoho více než ještěři nebo hadi).[1] Příslušníci skupiny Testudines (želvy) se poprvé prokazatelně objevili ve střední juře. Na světě žije více než 350 druhů želv (k roku 2017 odhadem 356 druhů), řada z nich je silně ohrožených.[2][3] Želvy jsou studenokrevní živočichové, což znamená, že teplota jejich těla se mění podle okolního prostředí. Jsou typicky dlouhověké, někteří jedinci se dožili prokazatelně i více než 180 let, např. želva sloní. Želvy jsou rozšířené prakticky po celém světě (mimo polární oblasti), zejména pak v oblastech s teplejším klimatem",
                DescriptionEN = "Turtles are distinguished from other reptiles primarily by the fact that their body is usually protected by a bony shell, which is divided into a dorsal (carapace) and ventral (plastron). It evolved from their ribs. Several now extinct species are included in this order. The earliest species closely related to turtles lived about 220 million years ago in the Triassic period (genus Odontochelys), making them one of the oldest groups of reptiles still living (many more than lizards or snakes).Members of the Testudines (turtles) group were first documented in the Middle Jurassic. There are more than 350 species of turtles in the world (an estimated 356 species as of 2017), many of which are highly endangered.[2][3] Turtles are cold-blooded animals, which means that their body temperature varies according to the surrounding environment. They are typically long-lived, with some individuals having been shown to live to more than 180 years, such as the elephant tortoise. Turtles are distributed virtually worldwide (outside the polar regions), especially in areas with warmer climates",
                Price = 200,
                IdKategories = 2
            };

            Product cs12 = new Product()
            {
                ID = 12,
                ImageSrc = "/img/item/perkocka.jpg",
                NameCZ = "Perská kočka bez PP samice",
                NameEN = "Persian cat without PP female",
                DescriptionCZ = "Perská kočka patří mezi nejstarší čistokrevná plemena koček vůbec. Do Evropy se rozšířila, podle některých pramenů v roce 1626 a dle jiných již roku 1520, patrně z Íránu, Arménie, Turecka či Iráku, avšak za její vlast je obecně považována Anglie. Tyto kočky, které dovezl Nicolas Claude Fabri de Peiresac, byly ale spíše podobné turecké angoře než typické peršance. Současně přivezl Pietro de la Valle další kočky s kulatějšími hlavami a mnohem hustší srstí z Persie. A začalo docházet ke křížení obou plemen, jelikož obě měla dlouhou srst a velmi se k sobě hodila. Peršanka se rychle stala symbolem postavení, moci a bohatství, takže není divu, že si brzo našla cestu na evropské dvory a sídla tehdejší šlechty. Perská kočka s krátkou srstí se nazývá exotická kočka. Je ve všech barevných varietách jako kočka perská. Ve FIFe se tato dvě plemena tj. perská a exotická smí křížit mezi sebou, zatímco jiné světové organizace chovatelů koček (CFA) toto přísně odmítají. Ve vrhu perské a exotické kočky nebo ve vrhu dvou exotických koček se mohou objevit obě dvě plemena. Z chovného páru pouze perských koček se mohou narodit jen perská koťata.\r\n\r\nCílené šlechtění počalo teprve kolem roku 1870 a ze začátku bylo jeho snahou jen uchovat roztomilý panenkovský obličej perské kočky, časem se stalo hlavním cílem vyvíjení nových barevných typů, takže v současnosti můžeme obdivovat více než 60 různých zbarvení peršanek. Na první britské výstavě koček roku 1871 bylo vystaveno velké množství těchto koček a krátce poté byly zveřejněny první standardy plemene. Záhy překročily perské kočky Atlantský oceán a dorazily do USA, kde byly roku 1903 vytvořeny americké standardy pro toto plemeno. Ty se od evropských lehce liší. V Evropě dávají chovatelé přednost méně zavalitému typu, zatímco američtí milovníci koček usilují o kompaktnější stavbu a snaží se docílit bohatší srsti. Američané vyšlechtili kočku s extrémně krátkým nosem – tzv. moderní typ. Posuzovatelé – rozhodčí na výstavě velmi pečlivě hodnotí také zdravotní stav kočky, zejména kontrolují jestli nemá kočka příliš úzké nosní dírky a celkově jestli dobře dýchá, bez námahy a chrčení. V Česku se prvně objevily tyto kočky moderního typu až po Sametové revoluci roku 1989, když se výstavy otevřely západním chovatelům. Do té doby v Česku převládaly kočky s nosy podobnými domácím kočkám.",
                DescriptionEN = "The Persian cat is one of the oldest purebred cat breeds ever. It spread to Europe, according to some sources in 1626 and according to others as early as 1520, probably from Iran, Armenia, Turkey or Iraq, but its homeland is generally considered to be England. However, these cats, imported by Nicolas Claude Fabri de Peiresac, were more similar to the Turkish Angora than to the typical Persian. At the same time, Pietro de la Valle brought other cats with rounder heads and much thicker coats from Persia. And the two breeds began to interbreed, as they both had long hair and were very well suited to each other. The Persian quickly became a symbol of status, power and wealth, so it is no wonder that it soon found its way into the European courts and residences of the nobility of the time. A Persian cat with a short coat is called an exotic cat. It comes in all colour varieties like the Persian cat. In FIFe, the two breeds, i.e. Persian and exotic, are allowed to interbreed, while other world cat fanciers' organizations (CFA) strictly refuse this. In a litter of a Persian and an exotic cat or in a litter of two exotic cats, both breeds can appear. Only Persian kittens can be born from a breeding pair of Persian-only cats.\n\nTargeted breeding only began around 1870 and at first it was just to preserve the cute doll-like face of the Persian cat, but over time it became the main goal to develop new colour types, so that today we can admire more than 60 different colours of Persian cats. At the first British Cat Show in 1871, a large number of these cats were exhibited and shortly afterwards the first breed standards were published. Soon the Persian cats crossed the Atlantic Ocean and arrived in the USA, where American standards for the breed were established in 1903. These differ slightly from the European ones. In Europe, breeders prefer a less stocky type, while American cat lovers aim for a more compact build and try to achieve a richer coat. The Americans have bred a cat with an extremely short nose - the so-called modern type. The judges at the show also evaluate the cat's health very carefully, especially checking whether the cat's nostrils are too narrow and whether it breathes well overall, without straining or snorting. In the Czech Republic these modern type cats first appeared after the Velvet Revolution in 1989, when shows were opened to western breeders. Until then, cats with noses similar to domestic cats were predominant in the Czech Republic.",
                Price = 2000,
                IdKategories = 2
            };

            Product cs13 = new Product()
            {
                ID = 13,
                ImageSrc = "/img/item/bisonek.jpg",
                NameCZ = "Bišonek bez PP fenka",
                NameEN = "Bichon without PP female",
                DescriptionCZ = "Bišonci jsou energičtí a živí psi, kteří potěší každého svým vzhledem. Jsou trpěliví a láskyplní k dětem. Dobře se přizpůsobují novým podmínkám, proto je můžete snadno vzít na společné rodinné výlety.\r\n\r\n\r\nBišonek je také známý jako Tenerife pes nebo kudrnatý bišon. Jedná se o společenské psy, které chtějí být v centru pozornosti. Rychle se učí a získávají nové dovednosti. Jedná se o typické pokojové psy. Nejsou vhodné pro život venku",
                DescriptionEN = "Bichons are energetic and lively dogs that please everyone with their appearance. They are patient and affectionate with children. They adapt well to new conditions, so you can easily take them on family outings together.\n\n\nThe Bichon is also known as the Tenerife dog or the curly-haired Bichon. These are social dogs that want to be the center of attention. They learn quickly and pick up new skills. They are typical room dogs. They are not suitable for life in outside.",

                Price = 10000,
                IdKategories = 1
            };

            Product cs14 = new Product()
            {
                ID = 14,
                ImageSrc = "/img/item/pandacervena.jpg",
                NameCZ = "Panda červená bez PP samice",
                NameEN = "Red panda without PP female",
                DescriptionCZ = "Svým vzhledem nijak nepřipomíná známější pandu velkou, i když žije podobně a hrozí jí tedy podobná nebezpečí. Jejím domovem jsou horské lesy a bambusové houštiny v Číně, Indii, Bhútánu a Barmě.  Podobně jako panda velká má zvláštní „palec“, což je výrůstek zápěstní kosti, ovšem daleko menší. Listy bambusu i jiných rostlin tedy není schopna zdrhnout. Místo toho si za pomoci „palce“ tlapou přitáhne větev a listy okusuje. Do jídelníčku pandy červené patří i ptačí vejce a menší živočichové, nepohrdne ani sladkými plody či kořínky a živí se dokonce i lišejníky. Za potravou se vydává za soumraku a v noci. Žije převážně samotářsky, a tak veškerou péči o mláďata obstarává samice. Připravuje pro své potomky pohodlné hnízdo ve stromové dutině a stará se o ně přinejmenším půl roku.",
                DescriptionEN = "In appearance it does not resemble the better-known giant panda, although it lives in a similar way and is therefore threatened by similar dangers. Its home is the mountain forests and bamboo thickets of China, India, Bhutan and Burma.  Like the giant panda, it has a distinctive 'thumb', which is an outgrowth of the wrist bone, but much smaller. It is therefore unable to remove the leaves of bamboo and other plants. Instead, she uses her paw to pull the branch with her \"thumb\" and nibbles the leaves. The red panda's diet also includes bird eggs and smaller animals, and it does not disdain sweet fruits or roots and even feeds on lichens. It forages at dusk and at night. It is largely solitary, so the female takes care of the young. She prepares a comfortable nest for her offspring in a tree cavity and cares for them for at least six months.",
                Price = 50000,
                IdKategories = 2
            };

            Product cs15 = new Product()
            {
                ID = 15,
                ImageSrc = "/img/item/kingpoodle.jpg",
                NameCZ = "Pudl královský bez PP fenka",
                NameEN = "Poodl king without PP female",
                DescriptionCZ = "Královský pudl je největší z příslušníků plemene. Jeho velikost se pohybuje od 45 cm do 60 cm s tolerancí +2 cm. Velký pudl musí být zvětšeninou středního pudla se zachováním stejných charakteristických znaků. Hmotnost by měla být do 30 kg. Má protáhlou, vznešenou hlavu přímých linií s mandlovýma očima. Nos je dobře vyvinutý a barva se odvíjí od barvy srsti. Uši jsou celkem dlouhé, na koncích zakulacené, přilehlé k tvářím. Má středně dlouhý, pevný krk. Jeho postava je téměř čtvercového formátu s krátkým hřbetem a hlubokým hrudníkem, má široká a svalnatá bedra. Jeho tělo je pokryto dlouhou kadeřavou, někdy šňůrovitou srstí, která byla vždy rozmanitým způsobem přistřihována. Existuje několik sestřihů např. „lví\" či „na ovečku\" apod. Srst je hustá, pevná, pružná a neustále dorůstá, vyžaduje tedy pravidelné stříhání. Barva srsti může být černá, hnědá, stříbrná, bílá, apricot (meruňková) nebo červená. Ocas je vysoko nasazený, svírající tupý úhel se hřbetem. Nohy má královský pudl rovné a svalnaté.",
                DescriptionEN = "The Royal Poodle is the largest of the breed. Its size ranges from 45 cm to 60 cm with a tolerance of +2 cm. The Large Poodle must be an enlargement of the Medium Poodle, retaining the same characteristics. The weight should be up to 30 kg. It has an elongated, noble head of straight lines with almond-shaped eyes. The nose is well developed and the colour is based on the coat colour. The ears are quite long, rounded at the ends, close to the cheeks. It has a medium-long, firm neck. His build is almost square with a short back and deep chest, and his shoulders are broad and muscular. His body is covered with long, curly, sometimes corded hair, which has always been cut in a variety of ways. There are several haircuts, e.g. 'lion' or 'sheep', etc. The coat is thick, strong, flexible and constantly growing back, so it requires regular trimming. The coat colour can be black, brown, silver, white, apricot or red. The tail is high set, forming an obtuse angle with the back. The legs of the Royal Poodle are straight and muscular.",
                Price = 15000,
                IdKategories = 1
            };

            Product cs16 = new Product()
            {
                ID = 16,
                ImageSrc = "/img/item/zelva.jpg",
                NameCZ = "Želva bez PP samec",
                NameEN = "Tortoise without PP male",
                DescriptionCZ = "Želvy se od ostatních plazů odlišují především tím, že je jejich tělo obvykle chráněno kostěným krunýřem, který se dělí na hřbetní (karapax) a břišní (plastron). Vyvinul se z jejich žeber. Do tohoto řádu se zahrnuje i několik dnes již vyhynulých druhů. Nejstarší druhy blízce příbuzné želvám žily před zhruba 220 miliony let v období triasu (rod Odontochelys), což z nich dělá jednu z nejstarších dosud žijících skupin plazů (o mnoho více než ještěři nebo hadi).[1] Příslušníci skupiny Testudines (želvy) se poprvé prokazatelně objevili ve střední juře. Na světě žije více než 350 druhů želv (k roku 2017 odhadem 356 druhů), řada z nich je silně ohrožených.[2][3] Želvy jsou studenokrevní živočichové, což znamená, že teplota jejich těla se mění podle okolního prostředí. Jsou typicky dlouhověké, někteří jedinci se dožili prokazatelně i více než 180 let, např. želva sloní. Želvy jsou rozšířené prakticky po celém světě (mimo polární oblasti), zejména pak v oblastech s teplejším klimatem",
                DescriptionEN = "Turtles are distinguished from other reptiles primarily by the fact that their body is usually protected by a bony shell, which is divided into a dorsal (carapace) and ventral (plastron). It evolved from their ribs. Several now extinct species are included in this order. The earliest species closely related to turtles lived about 220 million years ago in the Triassic period (genus Odontochelys), making them one of the oldest groups of reptiles still living (many more than lizards or snakes).Members of the Testudines (turtles) group were first documented in the Middle Jurassic. There are more than 350 species of turtles in the world (an estimated 356 species as of 2017), many of which are highly endangered.[2][3] Turtles are cold-blooded animals, which means that their body temperature varies according to the surrounding environment. They are typically long-lived, with some individuals having been shown to live to more than 180 years, such as the elephant tortoise. Turtles are distributed virtually worldwide (outside the polar regions), especially in areas with warmer climates",
                Price = 200,
                IdKategories = 2
            };

            Product cs17 = new Product()
            {
                ID = 17,
                ImageSrc = "/img/item/perkocka.jpg",
                NameCZ = "Perská kočka bez PP samec",
                NameEN = "Persian cat without PP male",
                DescriptionCZ = "Perská kočka patří mezi nejstarší čistokrevná plemena koček vůbec. Do Evropy se rozšířila, podle některých pramenů v roce 1626 a dle jiných již roku 1520, patrně z Íránu, Arménie, Turecka či Iráku, avšak za její vlast je obecně považována Anglie. Tyto kočky, které dovezl Nicolas Claude Fabri de Peiresac, byly ale spíše podobné turecké angoře než typické peršance. Současně přivezl Pietro de la Valle další kočky s kulatějšími hlavami a mnohem hustší srstí z Persie. A začalo docházet ke křížení obou plemen, jelikož obě měla dlouhou srst a velmi se k sobě hodila. Peršanka se rychle stala symbolem postavení, moci a bohatství, takže není divu, že si brzo našla cestu na evropské dvory a sídla tehdejší šlechty. Perská kočka s krátkou srstí se nazývá exotická kočka. Je ve všech barevných varietách jako kočka perská. Ve FIFe se tato dvě plemena tj. perská a exotická smí křížit mezi sebou, zatímco jiné světové organizace chovatelů koček (CFA) toto přísně odmítají. Ve vrhu perské a exotické kočky nebo ve vrhu dvou exotických koček se mohou objevit obě dvě plemena. Z chovného páru pouze perských koček se mohou narodit jen perská koťata.\r\n\r\nCílené šlechtění počalo teprve kolem roku 1870 a ze začátku bylo jeho snahou jen uchovat roztomilý panenkovský obličej perské kočky, časem se stalo hlavním cílem vyvíjení nových barevných typů, takže v současnosti můžeme obdivovat více než 60 různých zbarvení peršanek. Na první britské výstavě koček roku 1871 bylo vystaveno velké množství těchto koček a krátce poté byly zveřejněny první standardy plemene. Záhy překročily perské kočky Atlantský oceán a dorazily do USA, kde byly roku 1903 vytvořeny americké standardy pro toto plemeno. Ty se od evropských lehce liší. V Evropě dávají chovatelé přednost méně zavalitému typu, zatímco američtí milovníci koček usilují o kompaktnější stavbu a snaží se docílit bohatší srsti. Američané vyšlechtili kočku s extrémně krátkým nosem – tzv. moderní typ. Posuzovatelé – rozhodčí na výstavě velmi pečlivě hodnotí také zdravotní stav kočky, zejména kontrolují jestli nemá kočka příliš úzké nosní dírky a celkově jestli dobře dýchá, bez námahy a chrčení. V Česku se prvně objevily tyto kočky moderního typu až po Sametové revoluci roku 1989, když se výstavy otevřely západním chovatelům. Do té doby v Česku převládaly kočky s nosy podobnými domácím kočkám.",
                DescriptionEN = "The Persian cat is one of the oldest purebred cat breeds ever. It spread to Europe, according to some sources in 1626 and according to others as early as 1520, probably from Iran, Armenia, Turkey or Iraq, but its homeland is generally considered to be England. However, these cats, imported by Nicolas Claude Fabri de Peiresac, were more similar to the Turkish Angora than to the typical Persian. At the same time, Pietro de la Valle brought other cats with rounder heads and much thicker coats from Persia. And the two breeds began to interbreed, as they both had long hair and were very well suited to each other. The Persian quickly became a symbol of status, power and wealth, so it is no wonder that it soon found its way into the European courts and residences of the nobility of the time. A Persian cat with a short coat is called an exotic cat. It comes in all colour varieties like the Persian cat. In FIFe, the two breeds, i.e. Persian and exotic, are allowed to interbreed, while other world cat fanciers' organizations (CFA) strictly refuse this. In a litter of a Persian and an exotic cat or in a litter of two exotic cats, both breeds can appear. Only Persian kittens can be born from a breeding pair of Persian-only cats.\n\nTargeted breeding only began around 1870 and at first it was just to preserve the cute doll-like face of the Persian cat, but over time it became the main goal to develop new colour types, so that today we can admire more than 60 different colours of Persian cats. At the first British Cat Show in 1871, a large number of these cats were exhibited and shortly afterwards the first breed standards were published. Soon the Persian cats crossed the Atlantic Ocean and arrived in the USA, where American standards for the breed were established in 1903. These differ slightly from the European ones. In Europe, breeders prefer a less stocky type, while American cat lovers aim for a more compact build and try to achieve a richer coat. The Americans have bred a cat with an extremely short nose - the so-called modern type. The judges at the show also evaluate the cat's health very carefully, especially checking whether the cat's nostrils are too narrow and whether it breathes well overall, without straining or snorting. In the Czech Republic these modern type cats first appeared after the Velvet Revolution in 1989, when shows were opened to western breeders. Until then, cats with noses similar to domestic cats were predominant in the Czech Republic.",
                Price = 4000,
                IdKategories = 2
            };

            Product cs18 = new Product()
            {
                ID = 18,
                ImageSrc = "/img/item/bisonek.jpg",
                NameCZ = "Bišonek bez PP pes",
                NameEN = "Bichon without PP male",
                DescriptionCZ = "Bišonci jsou energičtí a živí psi, kteří potěší každého svým vzhledem. Jsou trpěliví a láskyplní k dětem. Dobře se přizpůsobují novým podmínkám, proto je můžete snadno vzít na společné rodinné výlety.\r\n\r\n\r\nBišonek je také známý jako Tenerife pes nebo kudrnatý bišon. Jedná se o společenské psy, které chtějí být v centru pozornosti. Rychle se učí a získávají nové dovednosti. Jedná se o typické pokojové psy. Nejsou vhodné pro život venku",
                DescriptionEN = "Bichons are energetic and lively dogs that please everyone with their appearance. They are patient and affectionate with children. They adapt well to new conditions, so you can easily take them on family outings together.\n\n\nThe Bichon is also known as the Tenerife dog or the curly-haired Bichon. These are social dogs that want to be the center of attention. They learn quickly and pick up new skills. They are typical room dogs. They are not suitable for life in outside.",

                Price = 10000,
                IdKategories = 1
            };

            Product cs19 = new Product()
            {
                ID = 19,
                ImageSrc = "/img/item/pandacervena.jpg",
                NameCZ = "Panda červená bez PP samec",
                NameEN = "Red panda without PP male",
                DescriptionCZ = "Svým vzhledem nijak nepřipomíná známější pandu velkou, i když žije podobně a hrozí jí tedy podobná nebezpečí. Jejím domovem jsou horské lesy a bambusové houštiny v Číně, Indii, Bhútánu a Barmě.  Podobně jako panda velká má zvláštní „palec“, což je výrůstek zápěstní kosti, ovšem daleko menší. Listy bambusu i jiných rostlin tedy není schopna zdrhnout. Místo toho si za pomoci „palce“ tlapou přitáhne větev a listy okusuje. Do jídelníčku pandy červené patří i ptačí vejce a menší živočichové, nepohrdne ani sladkými plody či kořínky a živí se dokonce i lišejníky. Za potravou se vydává za soumraku a v noci. Žije převážně samotářsky, a tak veškerou péči o mláďata obstarává samice. Připravuje pro své potomky pohodlné hnízdo ve stromové dutině a stará se o ně přinejmenším půl roku.",
                DescriptionEN = "In appearance it does not resemble the better-known giant panda, although it lives in a similar way and is therefore threatened by similar dangers. Its home is the mountain forests and bamboo thickets of China, India, Bhutan and Burma.  Like the giant panda, it has a distinctive 'thumb', which is an outgrowth of the wrist bone, but much smaller. It is therefore unable to remove the leaves of bamboo and other plants. Instead, she uses her paw to pull the branch with her \"thumb\" and nibbles the leaves. The red panda's diet also includes bird eggs and smaller animals, and it does not disdain sweet fruits or roots and even feeds on lichens. It forages at dusk and at night. It is largely solitary, so the female takes care of the young. She prepares a comfortable nest for her offspring in a tree cavity and cares for them for at least six months.",
                Price = 50000,
                IdKategories = 2
            };

            Product cs20 = new Product()
            {
                ID = 20,
                ImageSrc = "/img/item/kingpoodle.jpg",
                NameCZ = "Pudl královský bez PP pes",
                NameEN = "Poodl king without PP male",
                DescriptionCZ = "Královský pudl je největší z příslušníků plemene. Jeho velikost se pohybuje od 45 cm do 60 cm s tolerancí +2 cm. Velký pudl musí být zvětšeninou středního pudla se zachováním stejných charakteristických znaků. Hmotnost by měla být do 30 kg. Má protáhlou, vznešenou hlavu přímých linií s mandlovýma očima. Nos je dobře vyvinutý a barva se odvíjí od barvy srsti. Uši jsou celkem dlouhé, na koncích zakulacené, přilehlé k tvářím. Má středně dlouhý, pevný krk. Jeho postava je téměř čtvercového formátu s krátkým hřbetem a hlubokým hrudníkem, má široká a svalnatá bedra. Jeho tělo je pokryto dlouhou kadeřavou, někdy šňůrovitou srstí, která byla vždy rozmanitým způsobem přistřihována. Existuje několik sestřihů např. „lví\" či „na ovečku\" apod. Srst je hustá, pevná, pružná a neustále dorůstá, vyžaduje tedy pravidelné stříhání. Barva srsti může být černá, hnědá, stříbrná, bílá, apricot (meruňková) nebo červená. Ocas je vysoko nasazený, svírající tupý úhel se hřbetem. Nohy má královský pudl rovné a svalnaté.",
                DescriptionEN = "The Royal Poodle is the largest of the breed. Its size ranges from 45 cm to 60 cm with a tolerance of +2 cm. The Large Poodle must be an enlargement of the Medium Poodle, retaining the same characteristics. The weight should be up to 30 kg. It has an elongated, noble head of straight lines with almond-shaped eyes. The nose is well developed and the colour is based on the coat colour. The ears are quite long, rounded at the ends, close to the cheeks. It has a medium-long, firm neck. His build is almost square with a short back and deep chest, and his shoulders are broad and muscular. His body is covered with long, curly, sometimes corded hair, which has always been cut in a variety of ways. There are several haircuts, e.g. 'lion' or 'sheep', etc. The coat is thick, strong, flexible and constantly growing back, so it requires regular trimming. The coat colour can be black, brown, silver, white, apricot or red. The tail is high set, forming an obtuse angle with the back. The legs of the Royal Poodle are straight and muscular.",
                Price = 20000,
                IdKategories = 1
            };


            products.Add(cs1);
            products.Add(cs2);
            products.Add(cs3);
            products.Add(cs4);
            products.Add(cs5);
            products.Add(cs6);
            products.Add(cs7);
            products.Add(cs8);
            products.Add(cs9);
            products.Add(cs10);
            products.Add(cs11);
            products.Add(cs12);
            products.Add(cs13);
            products.Add(cs14);
            products.Add(cs15);
            products.Add(cs16);
            products.Add(cs17);
            products.Add(cs18);
            products.Add(cs19);
            products.Add(cs20);


            return products;
        }

        public List<Role> CreateRoles()

        {
            List<Role> roles = new List<Role>();

            Role roleAdmin = new Role()
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "9cf14c2c-19e7-40d6-b744-8917505c3106"
            };

            Role roleManager = new Role()
            {
                Id = 2,
                Name = "Manager",
                NormalizedName = "MANAGER",
                ConcurrencyStamp = "be0efcde-9d0a-461d-8eb6-444b043d6660"
            };

            Role roleCustomer = new Role()
            {
                Id = 3,
                Name = "Customer",
                NormalizedName = "CUSTOMER",
                ConcurrencyStamp = "29dafca7-cd20-4cd9-a3dd-4779d7bac3ee"
            };


            roles.Add(roleAdmin);
            roles.Add(roleManager);
            roles.Add(roleCustomer);

            return roles;
        }


        public (User, List<IdentityUserRole<int>>) CreateAdminWithRoles()
        {
            User admin = new User()
            {
                Id = 1,
                FirstName = "Adminek",
                LastName = "Adminovy",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.cz",
                NormalizedEmail = "ADMIN@ADMIN.CZ",
                EmailConfirmed = true,
                //password abc
                PasswordHash = "AQAAAAEAACcQAAAAEM9O98Suoh2o2JOK1ZOJScgOfQ21odn/k6EYUpGWnrbevCaBFFXrNL7JZxHNczhh/w==",
                SecurityStamp = "SEJEPXC646ZBNCDYSM3H5FRK5RWP2TN6",
                ConcurrencyStamp = "b09a83ae-cfd3-4ee7-97e6-fbcf0b0fe78c",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            List<IdentityUserRole<int>> adminUserRoles = new List<IdentityUserRole<int>>()
            {
                new IdentityUserRole<int>()
                {
                    UserId = 1,
                    RoleId = 1
                },
                new IdentityUserRole<int>()
                {
                    UserId = 1,
                    RoleId = 2
                },
                new IdentityUserRole<int>()
                {
                    UserId = 1,
                    RoleId = 3
                }
            };

            return (admin, adminUserRoles);
        }


        public (User, List<IdentityUserRole<int>>) CreateManagerWithRoles()
        {
            User manager = new User()
            {
                Id = 2,
                FirstName = "Managerek",
                LastName = "Managerovy",
                UserName = "manager",
                NormalizedUserName = "MANAGER",
                Email = "manager@manager.cz",
                NormalizedEmail = "MANAGER@MANAGER.CZ",
                EmailConfirmed = true,
                //password abc
                PasswordHash = "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==",
                SecurityStamp = "MAJXOSATJKOEM4YFF32Y5G2XPR5OFEL6",
                ConcurrencyStamp = "7a8d96fd-5918-441b-b800-cbafa99de97b",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };

            List<IdentityUserRole<int>> managerUserRoles = new List<IdentityUserRole<int>>()
            {
                new IdentityUserRole<int>()
                {
                    UserId = 2,
                    RoleId = 2
                },
                new IdentityUserRole<int>()
                {
                    UserId = 2,
                    RoleId = 3
                }
            };

            return (manager, managerUserRoles);
        }

        public List<Kategorie> CreateKategorie()

        {
            List<Kategorie> kategories = new List<Kategorie>();

            Kategorie kategorie = new Kategorie()
            {
                ID = 1,
                katCZ = "Pes",
                katEN = "Dog"
            };

            Kategorie kategorie1 = new Kategorie()
            {
                ID = 2,
                katCZ = "Ostatní",
                katEN = "Other"
            };



            kategories.Add(kategorie);
            kategories.Add(kategorie1);

            return kategories;
        }
    }
}
