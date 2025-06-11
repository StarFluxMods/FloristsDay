using System.Collections.Generic;
using KitchenData;

namespace ParentsEvent.Utilities
{
    public static class CenteralLang
    {
        public static class Appliances
        {
            public static List<(Locale, ApplianceInfo)> PressedFlowerFrame => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Pressed Flower Frame", Description = "A floral moment, frozen in time" }),
                (Locale.English, new ApplianceInfo { Name = "Pressed Flower Frame", Description = "A floral moment, frozen in time" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Cadre à fleurs pressées", Description = "Un moment floral, figé dans le temps" }),
                (Locale.German, new ApplianceInfo { Name = "Gepresste Blume Rahmen", Description = "Ein blumiger Moment, eingefroren in der Zeit" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Marco de flores prensadas", Description = "Un momento floral, congelado en el tiempo" }),
                (Locale.Polish, new ApplianceInfo { Name = "Ramka z tłoczonym kwiatem", Description = "Kwiatowy moment, zamrożony w czasie" }),
                (Locale.Russian, new ApplianceInfo { Name = "Рамка с прессованными цветами", Description = "Цветочный момент, застывший во времени" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Moldura de flor prensada", Description = "Um momento floral, congelado no tempo" }),
                (Locale.Japanese, new ApplianceInfo { Name = "押し花フレーム", Description = "時が止まったような花の瞬間" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "压制花框", Description = "凝固的花香时刻" }),
                (Locale.Korean, new ApplianceInfo { Name = "압화 프레임", Description = "시간에 멈춰버린 꽃의 순간" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Preslenmiş Çiçek Çerçevesi", Description = "Zamanda donmuş çiçekli bir an" }),
            };

            public static List<(Locale, ApplianceInfo)> Pollen => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Pollen", Description = "The flowers' way of sharing too much." }),
                (Locale.English, new ApplianceInfo { Name = "Pollen", Description = "The flowers' way of sharing too much." }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Pollen", Description = "La façon dont les fleurs partagent trop de choses." }),
                (Locale.German, new ApplianceInfo { Name = "Pollen", Description = "Die Art der Blumen, zu viel zu teilen." }),
                (Locale.Spanish, new ApplianceInfo { Name = "Polen", Description = "La forma que tienen las flores de compartir demasiado." }),
                (Locale.Polish, new ApplianceInfo { Name = "Pyłek", Description = "Kwiaty dzielą się zbyt wiele." }),
                (Locale.Russian, new ApplianceInfo { Name = "Пыльца", Description = "Цветы - это способ поделиться слишком многим." }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Pólen", Description = "A maneira das flores de compartilhar demais." }),
                (Locale.Japanese, new ApplianceInfo { Name = "花粉", Description = "花言葉は \"分かち合い\"。" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "花粉", Description = "花朵分享太多的方式" }),
                (Locale.Korean, new ApplianceInfo { Name = "꽃가루", Description = "너무 많은 것을 나누는 꽃들의 방식." }),
                (Locale.Turkish, new ApplianceInfo { Name = "Polen", Description = "Çiçeklerin çok fazla paylaşma şekli." }),
            };

            public static List<(Locale, ApplianceInfo)> Flowers => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Flower Patch", Description = "A splash of colour that doesn’t judge your cooking." }),
                (Locale.English, new ApplianceInfo { Name = "Flower Patch", Description = "A splash of colour that doesn’t judge your cooking." }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Patch de fleurs", Description = "Une touche de couleur qui ne nuit pas à votre cuisine." }),
                (Locale.German, new ApplianceInfo { Name = "Blumenbeet", Description = "Ein Farbtupfer, der Ihre Kochkünste nicht beeinträchtigt." }),
                (Locale.Spanish, new ApplianceInfo { Name = "Parche de flores", Description = "Un toque de color que no juzga tu cocina." }),
                (Locale.Polish, new ApplianceInfo { Name = "Flower Patch", Description = "Odrobina koloru, która nie ocenia gotowania." }),
                (Locale.Russian, new ApplianceInfo { Name = "Цветочная грядка", Description = "Всплеск цвета, который не будет осуждать вашу кухню." }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Arranjo de flores", Description = "Um toque de cor que não prejudica sua culinária." }),
                (Locale.Japanese, new ApplianceInfo { Name = "フラワー・パッチ", Description = "料理を邪魔しない差し色。" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "花田", Description = "一抹亮色不会影响您的烹饪。" }),
                (Locale.Korean, new ApplianceInfo { Name = "플라워 패치", Description = "요리에 방해가 되지 않는 컬러로 포인트를 줍니다." }),
                (Locale.Turkish, new ApplianceInfo { Name = "Çiçek Yaması", Description = "Yemeklerinizi yargılamayan bir renk sıçraması." }),
            };

            public static List<(Locale, ApplianceInfo)> Grass => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Grass Patch", Description = "Just enough lawn to feel outdoorsy." }),
                (Locale.English, new ApplianceInfo { Name = "Grass Patch", Description = "Just enough lawn to feel outdoorsy." }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "L'herbe en plaques", Description = "Juste assez de pelouse pour se sentir en plein air." }),
                (Locale.German, new ApplianceInfo { Name = "Grasfleck", Description = "Gerade genug Rasen, um sich im Freien zu fühlen." }),
                (Locale.Spanish, new ApplianceInfo { Name = "Parche de hierba", Description = "Lo justo de césped para sentirse al aire libre." }),
                (Locale.Polish, new ApplianceInfo { Name = "Grass Patch", Description = "Wystarczająco dużo trawnika, aby poczuć się jak na świeżym powietrzu." }),
                (Locale.Russian, new ApplianceInfo { Name = "Травяная грядка", Description = "Достаточно газона, чтобы чувствовать себя на природе." }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Remendo de grama", Description = "Gramado suficiente para se sentir ao ar livre." }),
                (Locale.Japanese, new ApplianceInfo { Name = "グラスパッチ", Description = "アウトドア気分を味わうには十分な芝生だ。" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "草地", Description = "恰到好处的草坪让人感受到户外气息。" }),
                (Locale.Korean, new ApplianceInfo { Name = "잔디 패치", Description = "야외에서 느낄 수 있는 충분한 잔디밭." }),
                (Locale.Turkish, new ApplianceInfo { Name = "Çim Yaması", Description = "Açık havada hissetmek için yeterli çim." }),
            };

            public static List<(Locale, ApplianceInfo)> Farmland => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Farmland", Description = "Dirt, but make it productive." }),
                (Locale.English, new ApplianceInfo { Name = "Farmland", Description = "Dirt, but make it productive." }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Terres agricoles", Description = "De la saleté, mais qu'elle soit productive." }),
                (Locale.German, new ApplianceInfo { Name = "Ackerland", Description = "Dreck, aber mach ihn produktiv." }),
                (Locale.Spanish, new ApplianceInfo { Name = "Terrenos agrícolas", Description = "Suciedad, pero que sea productiva." }),
                (Locale.Polish, new ApplianceInfo { Name = "Grunty rolne", Description = "Brud, ale produktywny." }),
                (Locale.Russian, new ApplianceInfo { Name = "Сельскохозяйственные угодья", Description = "Грязь, но пусть она будет продуктивной." }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Terras agrícolas", Description = "Sujeira, mas torne-a produtiva." }),
                (Locale.Japanese, new ApplianceInfo { Name = "農地", Description = "汚れても、生産的なものにする。" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "农田", Description = "脏，但要有成效。" }),
                (Locale.Korean, new ApplianceInfo { Name = "농지", Description = "더럽지만 생산적으로 만드세요." }),
                (Locale.Turkish, new ApplianceInfo { Name = "Tarım Arazileri", Description = "Kirli olsun ama verimli olsun." }),
            };

            public static List<(Locale, ApplianceInfo)> FloristsVaseProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Florist's Vase", Description = "Provides Vases" }),
                (Locale.English, new ApplianceInfo { Name = "Florist's Vase", Description = "Provides Vases" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Vase de fleuriste", Description = "Fournit des vases" }),
                (Locale.German, new ApplianceInfo { Name = "Vase des Floristen", Description = "Bietet Vasen" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Florero", Description = "Proporciona jarrones" }),
                (Locale.Polish, new ApplianceInfo { Name = "Wazon florystyczny", Description = "Zapewnia wazony" }),
                (Locale.Russian, new ApplianceInfo { Name = "Цветочная ваза", Description = "Предоставляет вазы" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Vaso de florista", Description = "Fornece vasos" }),
                (Locale.Japanese, new ApplianceInfo { Name = "花瓶", Description = "花器" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "花瓶", Description = "提供花瓶" }),
                (Locale.Korean, new ApplianceInfo { Name = "플로리스트의 꽃병", Description = "꽃병 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Çiçekçi Vazosu", Description = "Vazolar Sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> FloristsWateringCanProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Watering Can", Description = "Providers Watering Can" }),
                (Locale.English, new ApplianceInfo { Name = "Watering Can", Description = "Providers Watering Can" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Arrosoir", Description = "Fournisseurs Arrosoir" }),
                (Locale.German, new ApplianceInfo { Name = "Gießkanne", Description = "Anbieter Gießkanne" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Regadera", Description = "Proveedores Regadera" }),
                (Locale.Polish, new ApplianceInfo { Name = "Konewka", Description = "Dostawcy Konewka" }),
                (Locale.Russian, new ApplianceInfo { Name = "Лейка", Description = "Поставщики Лейка для полива" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Regador", Description = "Fornecedores Regador" }),
                (Locale.Japanese, new ApplianceInfo { Name = "じょうろ", Description = "給水缶" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "浇水罐", Description = "供应商浇水壶" }),
                (Locale.Korean, new ApplianceInfo { Name = "물 뿌리개", Description = "제공자 급수통" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Sulama Tenekesi", Description = "Sağlayıcılar Sulama Tenekesi" }),
            };

            public static List<(Locale, ApplianceInfo)> SmallSprinklerProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Small Sprinkler", Description = "Provides Small Sprinkler" }),
                (Locale.English, new ApplianceInfo { Name = "Small Sprinkler", Description = "Provides Small Sprinkler" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Petit arroseur", Description = "Fournit un petit arroseur" }),
                (Locale.German, new ApplianceInfo { Name = "Kleiner Rasensprenger", Description = "Bietet kleinen Sprinkler" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Aspersor pequeño", Description = "Proporciona pequeños aspersores" }),
                (Locale.Polish, new ApplianceInfo { Name = "Mały zraszacz", Description = "Zapewnia mały zraszacz" }),
                (Locale.Russian, new ApplianceInfo { Name = "Маленький спринклер", Description = "Обеспечивает небольшой спринклер" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Aspersor pequeno", Description = "Fornece um pequeno sprinkler" }),
                (Locale.Japanese, new ApplianceInfo { Name = "小型スプリンクラー", Description = "小型スプリンクラー" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "小型洒水器", Description = "提供小型洒水器" }),
                (Locale.Korean, new ApplianceInfo { Name = "소형 스프링클러", Description = "소형 스프링클러 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Küçük Fıskiye", Description = "Küçük Sprinkler Sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> FlowerRug => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Flower Rug", Description = "Petal to the metal (but very soft)" }),
                (Locale.English, new ApplianceInfo { Name = "Flower Rug", Description = "Petal to the metal (but very soft)" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Tapis à fleurs", Description = "Pétale au métal (mais très doux)" }),
                (Locale.German, new ApplianceInfo { Name = "Blumenteppich", Description = "Blütenblatt bis zum Metall (aber sehr weich)" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Alfombra de flores", Description = "Pétalo al metal (pero muy suave)" }),
                (Locale.Polish, new ApplianceInfo { Name = "Dywan w kwiaty", Description = "Płatek do metalu (ale bardzo miękki)" }),
                (Locale.Russian, new ApplianceInfo { Name = "Цветочный ковер", Description = "Лепестки до металла (но очень мягкие)" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Tapete de flores", Description = "Pétala ao metal (mas muito macia)" }),
                (Locale.Japanese, new ApplianceInfo { Name = "フラワーラグ", Description = "金属に花びら（しかし非常に柔らかい）" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "花毯", Description = "金属花瓣（但非常柔软）" }),
                (Locale.Korean, new ApplianceInfo { Name = "플라워 러그", Description = "꽃잎에서 금속까지(매우 부드럽지만)" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Çiçek Halı", Description = "Petalden metale (ama çok yumuşak)" }),
            };

            public static List<(Locale, ApplianceInfo)> FlowerGrowthChart => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Flower Growth Chart", Description = "Watch your blooms hit new heights" }),
                (Locale.English, new ApplianceInfo { Name = "Flower Growth Chart", Description = "Watch your blooms hit new heights" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Tableau de croissance des fleurs", Description = "Observez vos fleurs atteindre de nouveaux sommets" }),
                (Locale.German, new ApplianceInfo { Name = "Wachstumsdiagramm für Blumen", Description = "Erleben Sie, wie Ihre Blüten zu neuen Höhen aufsteigen" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Cuadro de crecimiento de las flores", Description = "Observa cómo tus flores alcanzan nuevas alturas" }),
                (Locale.Polish, new ApplianceInfo { Name = "Wykres wzrostu kwiatów", Description = "Obserwuj, jak Twoje kwiaty osiągają nowe szczyty" }),
                (Locale.Russian, new ApplianceInfo { Name = "Диаграмма роста цветов", Description = "Наблюдайте за тем, как ваши цветы достигают новых высот" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Gráfico de crescimento de flores", Description = "Veja suas flores atingirem novos patamares" }),
                (Locale.Japanese, new ApplianceInfo { Name = "花の成長チャート", Description = "あなたの花が新たな高みに到達するのを見届けよう" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "花卉生长图", Description = "看你的花朵绽放新高度" }),
                (Locale.Korean, new ApplianceInfo { Name = "꽃 성장 차트", Description = "새로운 차원의 꽃을 감상하세요" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Çiçek Büyüme Tablosu", Description = "Çiçeklerinizin yeni zirvelere ulaşmasını izleyin" }),
            };

            public static List<(Locale, ApplianceInfo)> MossyLog => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Mossy Log", Description = "Soft, soggy, and suspiciously decorative" }),
                (Locale.English, new ApplianceInfo { Name = "Mossy Log", Description = "Soft, soggy, and suspiciously decorative" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Bûche moussue", Description = "Doux, détrempé et étrangement décoratif" }),
                (Locale.German, new ApplianceInfo { Name = "Mossy Log", Description = "Weich, matschig und verdächtig dekorativ" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Tronco musgoso", Description = "Blando, empapado y sospechosamente decorativo." }),
                (Locale.Polish, new ApplianceInfo { Name = "Mossy Log", Description = "Miękkie, rozmoczone i podejrzanie dekoracyjne" }),
                (Locale.Russian, new ApplianceInfo { Name = "Моховое бревно", Description = "Мягкий, мокрый и подозрительно декоративный" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Registro Mossy", Description = "Macio, encharcado e suspeitamente decorativo" }),
                (Locale.Japanese, new ApplianceInfo { Name = "モッシー・ログ", Description = "やわらかく、グチャグチャで、怪しげな装飾が施されている。" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "苔藓原木", Description = "柔软、潮湿、装饰性可疑" }),
                (Locale.Korean, new ApplianceInfo { Name = "이끼가 낀 로그", Description = "부드럽고 촉촉하며 의심스러운 장식성" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Mossy Log", Description = "Yumuşak, vıcık vıcık ve şüpheli bir şekilde dekoratif" }),
            };

            public static List<(Locale, ApplianceInfo)> GardenGnome => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Garden Gnome", Description = "Lawn enforcement at its finest" }),
                (Locale.English, new ApplianceInfo { Name = "Garden Gnome", Description = "Lawn enforcement at its finest" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Nain de jardin", Description = "L'application de la loi sur les pelouses dans toute sa splendeur" }),
                (Locale.German, new ApplianceInfo { Name = "Gartenzwerg", Description = "Rasenvollzug in seiner schönsten Form" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Gnomo de jardín", Description = "Cumplimiento de la ley en su máxima expresión" }),
                (Locale.Polish, new ApplianceInfo { Name = "Gnom ogrodowy", Description = "Egzekwowanie prawa w najlepszym wydaniu" }),
                (Locale.Russian, new ApplianceInfo { Name = "Садовый гном", Description = "Уход за газонами в лучшем виде" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Gnomo de jardim", Description = "A aplicação do gramado em sua melhor forma" }),
                (Locale.Japanese, new ApplianceInfo { Name = "ガーデンノーム", Description = "最高の芝生施行" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "花园小矮人", Description = "最好的草坪执法" }),
                (Locale.Korean, new ApplianceInfo { Name = "가든 그놈", Description = "최고의 잔디 관리" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Bahçe Cücesi", Description = "En iyi çim uygulaması" }),
            };

            public static List<(Locale, ApplianceInfo)> CardboardBoxProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Cardboard Boxes", Description = "Provides Cardboard Boxes" }),
                (Locale.English, new ApplianceInfo { Name = "Cardboard Boxes", Description = "Provides Cardboard Boxes" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Boîtes en carton", Description = "Fournit des boîtes en carton" }),
                (Locale.German, new ApplianceInfo { Name = "Pappschachteln", Description = "Bietet Kartonagen" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Cajas de cartón", Description = "Suministra cajas de cartón" }),
                (Locale.Polish, new ApplianceInfo { Name = "Pudełka kartonowe", Description = "Dostarcza pudełka kartonowe" }),
                (Locale.Russian, new ApplianceInfo { Name = "Картонные коробки", Description = "Предоставляет картонные коробки" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Caixas de papelão", Description = "Fornece caixas de papelão" }),
                (Locale.Japanese, new ApplianceInfo { Name = "段ボール箱", Description = "段ボール箱を提供" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "纸板箱", Description = "提供纸板箱" }),
                (Locale.Korean, new ApplianceInfo { Name = "골판지 상자", Description = "판지 상자 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Karton Kutular", Description = "Karton Kutular Sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> PeasProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Peas", Description = "Provides Peas" }),
                (Locale.English, new ApplianceInfo { Name = "Peas", Description = "Provides Peas" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Pois", Description = "Fournit des pois" }),
                (Locale.German, new ApplianceInfo { Name = "Erbsen", Description = "Liefert Erbsen" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Guisantes", Description = "Proporciona guisantes" }),
                (Locale.Polish, new ApplianceInfo { Name = "Groszek", Description = "Zapewnia groszek" }),
                (Locale.Russian, new ApplianceInfo { Name = "Горох", Description = "Предоставляет горох" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Ervilhas", Description = "Fornece ervilhas" }),
                (Locale.Japanese, new ApplianceInfo { Name = "エンドウ豆", Description = "エンドウ豆を提供" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "豌豆", Description = "提供豌豆" }),
                (Locale.Korean, new ApplianceInfo { Name = "완두콩", Description = "완두콩 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Bezelye", Description = "Bezelye Sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> SausageProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Sausages", Description = "Provides Sausages" }),
                (Locale.English, new ApplianceInfo { Name = "Sausages", Description = "Provides Sausages" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Saucisses", Description = "Fournit des saucisses" }),
                (Locale.German, new ApplianceInfo { Name = "Würstchen", Description = "Liefert Wurstwaren" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Salchichas", Description = "Proporciona salchichas" }),
                (Locale.Polish, new ApplianceInfo { Name = "Kiełbaski", Description = "Zapewnia kiełbaski" }),
                (Locale.Russian, new ApplianceInfo { Name = "Сосиски", Description = "Предоставляет сосиски" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Salsichas", Description = "Fornece salsichas" }),
                (Locale.Japanese, new ApplianceInfo { Name = "ソーセージ", Description = "ソーセージを提供" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "香肠", Description = "提供香肠" }),
                (Locale.Korean, new ApplianceInfo { Name = "소시지", Description = "소시지 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Sosisler", Description = "Sosis Sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> TurkeyBonesProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Turkey Bones", Description = "Provides Turkey Bones" }),
                (Locale.English, new ApplianceInfo { Name = "Turkey Bones", Description = "Provides Turkey Bones" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Os de dinde", Description = "Fournit des os de dinde" }),
                (Locale.German, new ApplianceInfo { Name = "Putenbeine", Description = "Bietet Truthahnknochen" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Huesos de pavo", Description = "Proporciona huesos de pavo" }),
                (Locale.Polish, new ApplianceInfo { Name = "Kości indyka", Description = "Zapewnia kości indyka" }),
                (Locale.Russian, new ApplianceInfo { Name = "Кости индейки", Description = "Кости индейки" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Ossos de peru", Description = "Fornece ossos de peru" }),
                (Locale.Japanese, new ApplianceInfo { Name = "七面鳥の骨", Description = "七面鳥の骨を提供" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "火鸡骨头", Description = "提供火鸡骨头" }),
                (Locale.Korean, new ApplianceInfo { Name = "칠면조 뼈", Description = "칠면조 뼈 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Hindi Kemikleri", Description = "Hindi Kemikleri Sağlar" }),
            };
        }

        public static class RestaurantSettings
        {
            public static List<(Locale, BasicInfo)> FloristsSetting => new List<(Locale, BasicInfo)>
            {
                (Locale.Default, new BasicInfo { Name = "Florist's Garden", Description = "" }),
                (Locale.English, new BasicInfo { Name = "Florist's Garden", Description = "" }),
                (Locale.BlankText, new BasicInfo { Name = "", Description = "" }),
                (Locale.French, new BasicInfo { Name = "Jardin du fleuriste", Description = "" }),
                (Locale.German, new BasicInfo { Name = "Garten des Floristen", Description = "" }),
                (Locale.Spanish, new BasicInfo { Name = "Jardín de la floristería", Description = "" }),
                (Locale.Polish, new BasicInfo { Name = "Ogród kwiaciarni", Description = "" }),
                (Locale.Russian, new BasicInfo { Name = "Цветочный сад", Description = "" }),
                (Locale.PortugueseBrazil, new BasicInfo { Name = "Jardim da florista", Description = "" }),
                (Locale.Japanese, new BasicInfo { Name = "花屋の庭", Description = "" }),
                (Locale.ChineseSimplified, new BasicInfo { Name = "花匠花园", Description = "" }),
                (Locale.Korean, new BasicInfo { Name = "플로리스트의 정원", Description = "" }),
                (Locale.Turkish, new BasicInfo { Name = "Çiçekçinin Bahçesi", Description = "" }),
            };
        }

        public static class Recipes
        {
            public static Dictionary<Locale, string> DishStuffedMushroom => new Dictionary<Locale, string>
            {
                { Locale.Default, "Combine Chopped Cheese with a Mushroom" },
                { Locale.English, "Combine Chopped Cheese with a Mushroom" },
                { Locale.BlankText, "" },
                { Locale.French, "Combiner du fromage haché avec un champignon" },
                { Locale.German, "Gehackten Käse mit einem Pilz kombinieren" },
                { Locale.Spanish, "Combine el queso picado con un champiñón" },
                { Locale.Polish, "Połącz posiekany ser z grzybem" },
                { Locale.Russian, "Соедините нарезанный сыр с грибами" },
                { Locale.PortugueseBrazil, "Combine o queijo picado com um cogumelo" },
                { Locale.Japanese, "刻んだチーズとマッシュルームを混ぜる" },
                { Locale.ChineseSimplified, "将切碎的奶酪与蘑菇混合" },
                { Locale.Korean, "다진 치즈와 버섯을 섞습니다." },
                { Locale.Turkish, "Doğranmış Peyniri Mantar ile Birleştirin" },
            };

            public static Dictionary<Locale, string> DishWrappedGift => new Dictionary<Locale, string>
            {
                { Locale.Default, "Make space on the table so a child can give you an item, put it in a box, wrap it, and give it back." },
                { Locale.English, "Make space on the table so a child can give you an item, put it in a box, wrap it, and give it back." },
                { Locale.BlankText, "" },
                { Locale.French, "Faites de la place sur la table pour qu'un enfant puisse vous donner un objet, le mettre dans une boîte, l'emballer et le rendre." },
                { Locale.German, "Machen Sie Platz auf dem Tisch, damit ein Kind Ihnen einen Gegenstand geben, ihn in eine Schachtel legen, einpacken und zurückgeben kann." },
                { Locale.Spanish, "Haz sitio en la mesa para que un niño pueda darte un objeto, meterlo en una caja, envolverlo y devolvértelo." },
                { Locale.Polish, "Zrób miejsce na stole, aby dziecko mogło dać ci przedmiot, włożyć go do pudełka, zapakować i oddać." },
                { Locale.Russian, "Выделите место на столе, чтобы ребенок мог отдать вам предмет, положить его в коробку, завернуть и отдать." },
                { Locale.PortugueseBrazil, "Abra espaço na mesa para que uma criança possa lhe dar um item, colocá-lo em uma caixa, embrulhá-lo e devolvê-lo." },
                { Locale.Japanese, "テーブルの上にスペースを作り、子供が品物を渡して箱に入れ、包装して返すことができるようにする。" },
                { Locale.ChineseSimplified, "在桌子上留出空位，让孩子可以给你一件物品，把它放进盒子里，包好，再还给你。" },
                { Locale.Korean, "아이가 물건을 줄 때 상자에 넣고 포장한 후 돌려줄 수 있도록 테이블에 공간을 마련하세요." },
                { Locale.Turkish, "Bir çocuğun size bir eşya verebilmesi, onu bir kutuya koyabilmesi, paketleyebilmesi ve geri verebilmesi için masada yer açın." },
            };

            public static Dictionary<Locale, string> DishPetalSoup => new Dictionary<Locale, string>
            {
                { Locale.Default, "Chop Petals, Add them to a Pot with Water, Cook, Portion, Serve" },
                { Locale.English, "Chop Petals, Add them to a Pot with Water, Cook, Portion, Serve" },
                { Locale.BlankText, "" },
                { Locale.French, "Hacher les pétales, les ajouter à une casserole avec de l'eau, les faire cuire, les répartir, les servir." },
                { Locale.German, "Blütenblätter hacken, in einen Topf mit Wasser geben, kochen, portionieren, servieren" },
                { Locale.Spanish, "Picar los pétalos, añadirlos a una olla con agua, cocer, porcionar y servir" },
                { Locale.Polish, "Posiekaj płatki, dodaj je do garnka z wodą, gotuj, porcjuj i podawaj." },
                { Locale.Russian, "Нарежьте лепестки, добавьте их в кастрюлю с водой, варите, порционируйте, подавайте." },
                { Locale.PortugueseBrazil, "Pique as pétalas, adicione-as a uma panela com água, cozinhe, distribua em porções e sirva" },
                { Locale.Japanese, "花びらを刻み、水と一緒に鍋に入れ、煮る。" },
                { Locale.ChineseSimplified, "将花瓣切碎，放入锅中加水，煮熟，分装，上桌" },
                { Locale.Korean, "꽃잎을 자르고, 물이 담긴 냄비에 넣고, 요리하고, 나눠서 제공합니다." },
                { Locale.Turkish, "Yaprakları Doğrayın, Su ile Tencereye Ekleyin, Pişirin, Porsiyonlayın, Servis Edin" },
            };

            public static Dictionary<Locale, string> DishFloristsFlowers => new Dictionary<Locale, string>
            {
                { Locale.Default, "Add Water to a Watering Can, Prepare the Soil, Wait for flowers to grow!" },
                { Locale.English, "Add Water to a Watering Can, Prepare the Soil, Wait for flowers to grow!" },
                { Locale.BlankText, "" },
                { Locale.French, "Ajouter de l'eau dans un arrosoir, préparer le sol, attendre que les fleurs poussent !" },
                { Locale.German, "Wasser in eine Gießkanne geben, den Boden vorbereiten und warten, bis die Blumen wachsen!" },
                { Locale.Spanish, "Añade agua a una regadera, prepara la tierra, ¡espera a que crezcan las flores!" },
                { Locale.Polish, "Dodaj wodę do konewki, przygotuj glebę i czekaj na wzrost kwiatów!" },
                { Locale.Russian, "Добавьте воду в лейку, подготовьте почву, ждите, пока цветы вырастут!" },
                { Locale.PortugueseBrazil, "Adicione água em um regador, prepare o solo e aguarde o crescimento das flores!" },
                { Locale.Japanese, "じょうろに水を入れ、土を整え、花が育つのを待つ！" },
                { Locale.ChineseSimplified, "在浇水罐中加水，准备土壤，等待花朵生长！" },
                { Locale.Korean, "물뿌리개에 물을 넣고, 흙을 준비하고, 꽃이 자랄 때까지 기다리세요!" },
                { Locale.Turkish, "Sulama Kabına Su Ekleyin, Toprağı Hazırlayın, Çiçeklerin Büyümesini Bekleyin!" },
            };

            public static Dictionary<Locale, string> DishBangersAndMash => new Dictionary<Locale, string>
            {
                { Locale.Default, "Add a Cooked Sausage, and Mash Potato to a plate, and serve." },
                { Locale.English, "Add a Cooked Sausage, and Mash Potato to a plate, and serve." },
                { Locale.BlankText, "" },
                { Locale.French, "Ajouter une saucisse cuite et une purée de pommes de terre dans une assiette et servir." },
                { Locale.German, "Gekochte Wurst und Kartoffelpüree auf einen Teller geben und servieren." },
                { Locale.Spanish, "Añadir una salchicha cocida, y puré de patata en un plato, y servir." },
                { Locale.Polish, "Dodaj ugotowaną kiełbasę i puree ziemniaczane na talerz i podawaj." },
                { Locale.Russian, "Добавьте вареную колбасу и картофельное пюре на тарелку и подавайте." },
                { Locale.PortugueseBrazil, "Acrescente uma salsicha cozida e um purê de batatas em um prato e sirva." },
                { Locale.Japanese, "茹でたソーセージとマッシュポテトを皿に盛り付け、サービスする。" },
                { Locale.ChineseSimplified, "将煮熟的香肠和土豆泥放入盘中，即可食用。" },
                { Locale.Korean, "익힌 소시지와 으깬 감자를 접시에 담고 제공합니다." },
                { Locale.Turkish, "Bir tabağa Pişmiş Sosis ve Patates Püresi ekleyin ve servis edin." },
            };

            public static Dictionary<Locale, string> DishBangersAndMashGravy => new Dictionary<Locale, string>
            {
                { Locale.Default, "Add Gravy to Sausages" },
                { Locale.English, "Add Gravy to Sausages" },
                { Locale.BlankText, "" },
                { Locale.French, "Ajouter de la sauce aux saucisses" },
                { Locale.German, "Bratensoße zu Würstchen hinzufügen" },
                { Locale.Spanish, "Añadir salsa a las salchichas" },
                { Locale.Polish, "Dodaj sos do kiełbasek" },
                { Locale.Russian, "Добавьте соус к сосискам" },
                { Locale.PortugueseBrazil, "Adicionar molho às salsichas" },
                { Locale.Japanese, "ソーセージに肉汁を加える" },
                { Locale.ChineseSimplified, "为香肠添加肉汁" },
                { Locale.Korean, "소시지에 그레이비 추가" },
                { Locale.Turkish, "Sosislere Sos Ekleme" },
            };

            public static Dictionary<Locale, string> DishBangersAndMashPeas => new Dictionary<Locale, string>
            {
                { Locale.Default, "Add Water and Peas to a Pot, Cook, Plate and Serve." },
                { Locale.English, "Add Water and Peas to a Pot, Cook, Plate and Serve." },
                { Locale.BlankText, "" },
                { Locale.French, "Ajouter l'eau et les pois dans une casserole, faire cuire, mettre dans une assiette et servir." },
                { Locale.German, "Wasser und Erbsen in einen Topf geben, kochen, auf einen Teller geben und servieren." },
                { Locale.Spanish, "Añadir agua y guisantes a una olla, cocer, emplatar y servir." },
                { Locale.Polish, "Dodaj wodę i groszek do garnka, ugotuj, przełóż na talerz i podawaj." },
                { Locale.Russian, "Добавьте воду и горох в кастрюлю, варите, разложите по тарелкам и подавайте." },
                { Locale.PortugueseBrazil, "Adicione água e ervilhas em uma panela, cozinhe, sirva em um prato e sirva." },
                { Locale.Japanese, "鍋に水とエンドウ豆を入れ、茹で、皿に盛る。" },
                { Locale.ChineseSimplified, "在锅中加入水和豌豆，煮熟后装盘上桌。" },
                { Locale.Korean, "냄비에 물과 완두콩을 넣고 조리한 후 접시에 담아 제공합니다." },
                { Locale.Turkish, "Bir Tencereye Su ve Bezelye Ekleyin, Pişirin, Tabağa Alın ve Servis Edin." },
            };

            public static Dictionary<Locale, string> DishChocolateBark => new Dictionary<Locale, string>
            {
                { Locale.Default, "Add Melted Chocolate and Chopped Nuts to a Cookie Tray, Let Chill, Remove, Cut, Portion, Serve." },
                { Locale.English, "Add Melted Chocolate and Chopped Nuts to a Cookie Tray, Let Chill, Remove, Cut, Portion, Serve." },
                { Locale.BlankText, "" },
                { Locale.French, "Ajouter le chocolat fondu et les noix hachées à un plateau à biscuits, laisser refroidir, retirer, couper, répartir, servir." },
                { Locale.German, "Geschmolzene Schokolade und gehackte Nüsse auf ein Plätzchentablett geben, abkühlen lassen, herausnehmen, schneiden, portionieren, servieren." },
                { Locale.Spanish, "Añadir el chocolate fundido y las nueces picadas a una bandeja de galletas, dejar enfriar, sacar, cortar, porcionar y servir." },
                { Locale.Polish, "Dodaj roztopioną czekoladę i posiekane orzechy na tackę z ciasteczkami, pozostaw do schłodzenia, wyjmij, pokrój, porcjuj i podawaj." },
                { Locale.Russian, "Добавьте растопленный шоколад и измельченные орехи на поднос с печеньем, дайте остыть, снимите, нарежьте, разделите на порции и подавайте." },
                { Locale.PortugueseBrazil, "Coloque o chocolate derretido e as nozes picadas em uma bandeja de biscoitos, deixe esfriar, retire, corte, distribua e sirva." },
                { Locale.Japanese, "溶かしたチョコレートと刻んだナッツをクッキートレーに入れ、冷やしておく。" },
                { Locale.ChineseSimplified, "将融化的巧克力和切碎的坚果放入饼干托盘，冷却后取出，切块，分装，上桌。" },
                { Locale.Korean, "녹인 초콜릿과 다진 견과류를 쿠키 트레이에 넣고 식힌 후 꺼내서 자르고 나누어 제공합니다." },
                { Locale.Turkish, "Kurabiye tepsisine eritilmiş çikolata ve kıyılmış fındık ekleyin, soğumaya bırakın, çıkarın, kesin, porsiyonlayın, servis edin." },
            };
        }

        public static class Unlocks
        {
            public static List<(Locale, UnlockInfo)> DishStuffedMushroom => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Stuffed Mushroom", Description = "Adds Stuffed Mushroom as a Starter", FlavourText = "Filled with mystery (and cheese)" }),
                (Locale.English, new UnlockInfo { Name = "Stuffed Mushroom", Description = "Adds Stuffed Mushroom as a Starter", FlavourText = "Filled with mystery (and cheese)" }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Champignons farcis", Description = "Ajoute le champignon farci en entrée", FlavourText = "Rempli de mystère (et de fromage)" }),
                (Locale.German, new UnlockInfo { Name = "Gefüllte Champignons", Description = "Fügt gefüllte Champignons als Vorspeise hinzu", FlavourText = "Gefüllt mit Geheimnissen (und Käse)" }),
                (Locale.Spanish, new UnlockInfo { Name = "Champiñón relleno", Description = "Añade champiñón relleno como entrante", FlavourText = "Lleno de misterio (y queso)" }),
                (Locale.Polish, new UnlockInfo { Name = "Pieczarka faszerowana", Description = "Dodaje Pieczarka faszerowana jako przystawka", FlavourText = "Wypełniony tajemnicą (i serem)" }),
                (Locale.Russian, new UnlockInfo { Name = "Фаршированный гриб", Description = "Добавляет фаршированные грибы в качестве закуски", FlavourText = "Наполненный тайнами (и сыром)" }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Cogumelo recheado", Description = "Adiciona cogumelo recheado como entrada", FlavourText = "Cheio de mistério (e queijo)" }),
                (Locale.Japanese, new UnlockInfo { Name = "マッシュルームの肉詰め", Description = "前菜にマッシュルームの肉詰めを加える", FlavourText = "謎（とチーズ）でいっぱい" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "酿蘑菇", Description = "添加酿蘑菇作为开胃菜", FlavourText = "充满神秘（和奶酪）" }),
                (Locale.Korean, new UnlockInfo { Name = "박제 버섯", Description = "박제 버섯을 스타터로 추가합니다.", FlavourText = "미스터리로 가득 찬 (그리고 치즈) 치즈" }),
                (Locale.Turkish, new UnlockInfo { Name = "Mantar Dolması", Description = "Başlangıç Olarak Mantar Dolması Ekler", FlavourText = "Gizemle (ve peynirle) dolu" }),
            };

            public static List<(Locale, UnlockInfo)> DishPetalSoup => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Petal Soup", Description = "Adds Petal Soup as a Starter", FlavourText = "Flowers are food, right?" }),
                (Locale.English, new UnlockInfo { Name = "Petal Soup", Description = "Adds Petal Soup as a Starter", FlavourText = "Flowers are food, right?" }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Soupe aux pétales", Description = "Ajoute la soupe aux pétales en entrée", FlavourText = "Les fleurs sont de la nourriture, n'est-ce pas ?" }),
                (Locale.German, new UnlockInfo { Name = "Blütensuppe", Description = "Fügt Blütensuppe als Vorspeise hinzu", FlavourText = "Blumen sind doch Lebensmittel, oder?" }),
                (Locale.Spanish, new UnlockInfo { Name = "Sopa de pétalos", Description = "Añade sopa de pétalos como entrante", FlavourText = "Las flores son comida, ¿verdad?" }),
                (Locale.Polish, new UnlockInfo { Name = "Zupa z płatków", Description = "Dodaje Zupa z płatków jako przystawkę", FlavourText = "Kwiaty to jedzenie, prawda?" }),
                (Locale.Russian, new UnlockInfo { Name = "Суп из лепестков", Description = "Добавляет лепестковый суп в качестве стартера", FlavourText = "Цветы - это еда, верно?" }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Sopa de pétalas", Description = "Adiciona a sopa de pétalas como entrada", FlavourText = "As flores são alimentos, certo?" }),
                (Locale.Japanese, new UnlockInfo { Name = "花びらのスープ", Description = "前菜に花びらスープを追加", FlavourText = "花は食べ物でしょう？" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "花瓣汤", Description = "添加花瓣汤作为开胃菜", FlavourText = "花也是食物，对吧？" }),
                (Locale.Korean, new UnlockInfo { Name = "꽃잎 수프", Description = "꽃잎 수프를 스타터로 추가합니다.", FlavourText = "꽃은 음식이죠?" }),
                (Locale.Turkish, new UnlockInfo { Name = "Petal Çorbası", Description = "Başlangıç olarak Petal Çorbası ekler", FlavourText = "Çiçekler yemektir, değil mi?" }),
            };


            public static List<(Locale, UnlockInfo)> DishWrappedGift => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Wrapped Gifts", Description = "Children can bring a gift for you to wrap.", FlavourText = "Guaranteed to make you say “aww” or “ugh”" }),
                (Locale.English, new UnlockInfo { Name = "Wrapped Gifts", Description = "Children can bring a gift for you to wrap.", FlavourText = "Guaranteed to make you say “aww” or “ugh”" }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Cadeaux emballés", Description = "Les enfants peuvent apporter un cadeau à emballer.", FlavourText = "Garanti pour vous faire dire \"aww\" ou \"ugh\"." }),
                (Locale.German, new UnlockInfo { Name = "Eingepackte Geschenke", Description = "Kinder können ein Geschenk mitbringen, das Sie einpacken können.", FlavourText = "Garantiert ein \"Pfui\" oder \"Igitt\" für Sie" }),
                (Locale.Spanish, new UnlockInfo { Name = "Regalos envueltos", Description = "Los niños pueden traer un regalo para que lo envuelvan.", FlavourText = "Garantizado para hacerle decir \"aww\" o \"ugh\"." }),
                (Locale.Polish, new UnlockInfo { Name = "Zapakowane prezenty", Description = "Dzieci mogą przynieść prezent do zapakowania.", FlavourText = "Gwarantowane, że powiesz \"aww\" lub \"ugh\"" }),
                (Locale.Russian, new UnlockInfo { Name = "Завернутые подарки", Description = "Дети могут принести подарок, чтобы вы его завернули.", FlavourText = "Гарантированно заставит вас сказать \"ах\" или \"ух\"." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Presentes embrulhados", Description = "As crianças podem trazer um presente para você embrulhar.", FlavourText = "Garantia de fazer você dizer \"aww\" ou \"ugh\"" }),
                (Locale.Japanese, new UnlockInfo { Name = "ラッピングギフト", Description = "子供たちはラッピングしてくれるプレゼントを持ってくることができる。", FlavourText = "思わず \"あー \"とか \"うっ \"と言ってしまうこと請け合いだ。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "包装礼品", Description = "孩子们可以带礼物来让您包装。", FlavourText = "保证让你发出 \"哇 \"或 \"唉 \"的声音" }),
                (Locale.Korean, new UnlockInfo { Name = "포장된 선물", Description = "아이들이 선물을 가져와서 포장할 수 있습니다.", FlavourText = "\"아유\" 또는 \"으악\"이라는 말이 절로 나오게 만드는 보장된 서비스" }),
                (Locale.Turkish, new UnlockInfo { Name = "Paketlenmiş Hediyeler", Description = "Çocuklar paketlemeniz için bir hediye getirebilirler.", FlavourText = "Size \"aww\" ya da \"ugh\" dedirtmesi garanti" }),
            };

            public static List<(Locale, UnlockInfo)> DishFloristsFlowers => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Flowers", Description = "Adds Flowers as a Main", FlavourText = "Nature’s decor, bottled for beauty." }),
                (Locale.English, new UnlockInfo { Name = "Flowers", Description = "Adds Flowers as a Main", FlavourText = "Nature’s decor, bottled for beauty." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Fleurs", Description = "Ajoute des fleurs comme élément principal", FlavourText = "Le décor de la nature, mis en bouteille pour la beauté." }),
                (Locale.German, new UnlockInfo { Name = "Blumen", Description = "Fügt Blumen als Hauptbestandteil hinzu", FlavourText = "Das Dekor der Natur, in Flaschen abgefüllt für die Schönheit." }),
                (Locale.Spanish, new UnlockInfo { Name = "Flores", Description = "Añade Flores como Principal", FlavourText = "Decoración de la naturaleza, embotellada para la belleza." }),
                (Locale.Polish, new UnlockInfo { Name = "Kwiaty", Description = "Dodaje kwiaty jako główny element", FlavourText = "Wystrój natury, butelkowany dla piękna." }),
                (Locale.Russian, new UnlockInfo { Name = "Цветы", Description = "Добавляет цветы в качестве основного", FlavourText = "Природный декор в бутылках для красоты." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Flores", Description = "Adiciona flores como principal", FlavourText = "Decoração da natureza, engarrafada para a beleza." }),
                (Locale.Japanese, new UnlockInfo { Name = "花", Description = "花をメインに加える", FlavourText = "自然の装飾、美のための瓶詰め。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "鲜花", Description = "添加鲜花作为主色调", FlavourText = "大自然的装饰，瓶装的美丽。" }),
                (Locale.Korean, new UnlockInfo { Name = "꽃", Description = "꽃을 메인으로 추가", FlavourText = "아름다움을 위해 병에 담긴 자연의 장식." }),
                (Locale.Turkish, new UnlockInfo { Name = "Çiçekler", Description = "Çiçekleri Ana Unsur Olarak Ekler", FlavourText = "Doğanın dekoru, güzellik için şişelenmiş." }),
            };

            public static List<(Locale, UnlockInfo)> CardChildren => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Children", Description = "Adds Children", FlavourText = "Tiny humans, big opinions." }),
                (Locale.English, new UnlockInfo { Name = "Children", Description = "Adds Children", FlavourText = "Tiny humans, big opinions." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Les enfants", Description = "Ajoute des enfants", FlavourText = "Petits êtres humains, grandes opinions." }),
                (Locale.German, new UnlockInfo { Name = "Kinder", Description = "Fügt Kinder hinzu", FlavourText = "Winzige Menschen, große Meinungen." }),
                (Locale.Spanish, new UnlockInfo { Name = "Niños", Description = "Añade niños", FlavourText = "Pequeños humanos, grandes opiniones." }),
                (Locale.Polish, new UnlockInfo { Name = "Dzieci", Description = "Dodaje dzieci", FlavourText = "Mali ludzie, wielkie opinie." }),
                (Locale.Russian, new UnlockInfo { Name = "Дети", Description = "Добавляет детей", FlavourText = "Маленькие люди, большие мнения." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Crianças", Description = "Adiciona crianças", FlavourText = "Pequenos seres humanos, grandes opiniões." }),
                (Locale.Japanese, new UnlockInfo { Name = "子供たち", Description = "子供を加える", FlavourText = "小さな人間、大きな意見" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "儿童", Description = "添加儿童", FlavourText = "小小人类，大大意见。" }),
                (Locale.Korean, new UnlockInfo { Name = "어린이", Description = "자녀 추가", FlavourText = "작은 인간, 큰 의견." }),
                (Locale.Turkish, new UnlockInfo { Name = "Çocuklar", Description = "Çocuk Ekler", FlavourText = "Küçük insanlar, büyük fikirler." }),
            };

            public static List<(Locale, UnlockInfo)> CardFlowerWiltering => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Wiltering Flowers", Description = "Unwatered flowers will wilter.", FlavourText = "A timeless tribute to forgetting" }),
                (Locale.English, new UnlockInfo { Name = "Wiltering Flowers", Description = "Unwatered flowers will wilter.", FlavourText = "A timeless tribute to forgetting" }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Wiltering Flowers", Description = "Les fleurs non arrosées se flétrissent.", FlavourText = "Un hommage intemporel à l'oubli" }),
                (Locale.German, new UnlockInfo { Name = "Wilde Blumen", Description = "Unbewässerte Blumen werden welk.", FlavourText = "Eine zeitlose Hommage an das Vergessen" }),
                (Locale.Spanish, new UnlockInfo { Name = "Flores de Wiltering", Description = "Las flores sin regar se marchitarán.", FlavourText = "Un homenaje intemporal al olvido" }),
                (Locale.Polish, new UnlockInfo { Name = "Wiltering Flowers", Description = "Niepodlewane kwiaty więdną.", FlavourText = "Ponadczasowy hołd dla zapomnienia" }),
                (Locale.Russian, new UnlockInfo { Name = "Цветы Уилтеринга", Description = "Не политые цветы завянут.", FlavourText = "Вечная дань забвению" }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Flores de Wiltering", Description = "As flores não regadas murcham.", FlavourText = "Um tributo atemporal ao esquecimento" }),
                (Locale.Japanese, new UnlockInfo { Name = "ウィルタリングフラワー", Description = "水をやらない花はしおれてしまう。", FlavourText = "忘却への永遠の賛辞" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "Wiltering Flowers", Description = "不浇水的花朵会枯萎。", FlavourText = "向遗忘致以永恒的敬意" }),
                (Locale.Korean, new UnlockInfo { Name = "시들어가는 꽃", Description = "물을 주지 않으면 꽃이 시들게 됩니다.", FlavourText = "망각에 대한 영원한 헌정" }),
                (Locale.Turkish, new UnlockInfo { Name = "Wiltering Çiçekleri", Description = "Sulanmayan çiçekler solacaktır.", FlavourText = "Unutmaya karşı zamansız bir övgü" }),
            };

            public static List<(Locale, UnlockInfo)> DishBangersAndMash => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Bangers and Mash", Description = "Adds Bangers and Mash as a Main", FlavourText = "A symphony of sizzle and spud" }),
                (Locale.English, new UnlockInfo { Name = "Bangers and Mash", Description = "Adds Bangers and Mash as a Main", FlavourText = "A symphony of sizzle and spud" }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Saucisses à la braise et purée de pommes de terre", Description = "Ajoute les saucisses à la viande comme plat principal", FlavourText = "Une symphonie de grésillements et d'éclats" }),
                (Locale.German, new UnlockInfo { Name = "Würstchen und Kartoffelpüree", Description = "Fügt Würstchen und Kartoffelbrei als Hauptgericht hinzu", FlavourText = "Eine Sinfonie aus Brutzeln und Würstchen" }),
                (Locale.Spanish, new UnlockInfo { Name = "Salchichas y puré", Description = "Añade Bangers and Mash como plato principal", FlavourText = "Una sinfonía de chisporroteo y picante" }),
                (Locale.Polish, new UnlockInfo { Name = "Bangers and Mash", Description = "Dodaje Bangers and Mash jako danie główne", FlavourText = "Symfonia skwierczenia i kiełków" }),
                (Locale.Russian, new UnlockInfo { Name = "Бангеры и пюре", Description = "Добавляет бангеры и пюре в качестве основного блюда", FlavourText = "Симфония шипения и специй" }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Bangers e purê", Description = "Adiciona Bangers and Mash como prato principal", FlavourText = "Uma sinfonia de chiados e salgadinhos" }),
                (Locale.Japanese, new UnlockInfo { Name = "バンガーズ＆マッシュ", Description = "メインにバンガーズ＆マッシュを追加", FlavourText = "シズル感とスパッドのシンフォニー" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "香肠和土豆泥", Description = "添加香肠和土豆泥作为主菜", FlavourText = "嗞嗞作响的交响乐" }),
                (Locale.Korean, new UnlockInfo { Name = "뱅거 앤 매시", Description = "뱅거와 매쉬를 메인으로 추가합니다.", FlavourText = "지글거림과 스퍼드의 교향곡" }),
                (Locale.Turkish, new UnlockInfo { Name = "Bangers ve Mash", Description = "Bangers ve Mash'i Ana Yemek Olarak Ekler", FlavourText = "Cızırtı ve patates senfonisi" }),
            };

            public static List<(Locale, UnlockInfo)> DishBangersAndMashGravy => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Bangers and Mash - Gravy", Description = "Adds Gravy as an Extra", FlavourText = "It’s not bangers and mash without the splash" }),
                (Locale.English, new UnlockInfo { Name = "Bangers and Mash - Gravy", Description = "Adds Gravy as an Extra", FlavourText = "It’s not bangers and mash without the splash" }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Pommes de terre et purée - Sauce", Description = "Ajoute de la sauce en supplément", FlavourText = "Il ne s'agit pas de saucisses et de purée sans les éclaboussures." }),
                (Locale.German, new UnlockInfo { Name = "Würstchen und Kartoffelbrei - Soße", Description = "Bratensoße als Extra", FlavourText = "Es ist kein Würstchen mit Kartoffelbrei ohne den Spritzer" }),
                (Locale.Spanish, new UnlockInfo { Name = "Bangers and Mash - Salsa", Description = "Añade salsa como extra", FlavourText = "No son salchichas y puré sin salpicaduras" }),
                (Locale.Polish, new UnlockInfo { Name = "Bangers and Mash - sos", Description = "Dodaje sos jako dodatek", FlavourText = "To nie jest bangers and mash bez plusku" }),
                (Locale.Russian, new UnlockInfo { Name = "Бангеры и пюре с подливкой", Description = "Добавляет соус в качестве дополнительного блюда", FlavourText = "Это не пюре без брызг." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Bangers and Mash - Molho", Description = "Adiciona molho como um extra", FlavourText = "Não se trata de um bangers and mash sem o respingo" }),
                (Locale.Japanese, new UnlockInfo { Name = "バンガーズ＆マッシュ - グレイビーソース", Description = "グレービーソースを追加", FlavourText = "スプラッシュがなければバンガーズ＆マッシュではない" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "香肠和土豆泥 - 肉汁", Description = "额外添加肉汁", FlavourText = "没有水花就不是香肠和土豆泥了" }),
                (Locale.Korean, new UnlockInfo { Name = "뱅거 앤 매시 - 그레이비", Description = "그레이비를 엑스트라로 추가", FlavourText = "스플래시가 없는 뱅어 앤 매쉬가 아닙니다." }),
                (Locale.Turkish, new UnlockInfo { Name = "Bangers ve Mash - Sos", Description = "Ekstra Olarak Sos Ekler", FlavourText = "Sıçrama olmadan bangers ve püre değil" }),
            };

            public static List<(Locale, UnlockInfo)> DishBangersAndMashPeas => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Bangers and Mash - Peas", Description = "Adds Peas as an Extra", FlavourText = "The mash’s little green backup dancers" }),
                (Locale.English, new UnlockInfo { Name = "Bangers and Mash - Peas", Description = "Adds Peas as an Extra", FlavourText = "The mash’s little green backup dancers" }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Saucisses à la braise et purée de pommes de terre - Pois", Description = "Ajoute des petits pois en supplément", FlavourText = "Les petites danseuses vertes de la purée" }),
                (Locale.German, new UnlockInfo { Name = "Würstchen und Kartoffelpüree - Erbsen", Description = "Erbsen als Extra", FlavourText = "Die kleinen grünen Ersatztänzer des Breis" }),
                (Locale.Spanish, new UnlockInfo { Name = "Bangers and Mash - Guisantes", Description = "Añade guisantes como extra", FlavourText = "Los pequeños bailarines verdes de apoyo del puré" }),
                (Locale.Polish, new UnlockInfo { Name = "Bangers and Mash - Groszek", Description = "Dodaje groszek jako dodatek", FlavourText = "Mali zieloni tancerze rezerwowi zacieru" }),
                (Locale.Russian, new UnlockInfo { Name = "Бангеры и пюре - горох", Description = "Добавляет горох в качестве дополнительного блюда", FlavourText = "Маленькие зеленые танцоры из пюре" }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Bangers and Mash - Ervilhas", Description = "Adiciona ervilhas como um extra", FlavourText = "Os pequenos dançarinos verdes de apoio do purê" }),
                (Locale.Japanese, new UnlockInfo { Name = "バンガーズ＆マッシュ - エンドウ豆", Description = "エンドウ豆を追加", FlavourText = "マッシュの小さな緑のバックダンサーたち" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "香肠和土豆泥 - 豌豆", Description = "添加豌豆作为附加菜", FlavourText = "醪糟的绿色小伴舞" }),
                (Locale.Korean, new UnlockInfo { Name = "뱅거 앤 매시 - 완두콩", Description = "완두콩을 추가로 추가합니다.", FlavourText = "매쉬의 작은 초록색 백업 댄서들" }),
                (Locale.Turkish, new UnlockInfo { Name = "Bangers ve Mash - Bezelye", Description = "Bezelyeyi Ekstra Olarak Ekler", FlavourText = "Püre'nin küçük yeşil yedek dansçıları" }),
            };

            public static List<(Locale, UnlockInfo)> DishChocolateBark => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Chocolate Bark", Description = "Adds Chocolate Bark as a Dessert", FlavourText = "Crunchy, chunky, chocolatey chaos" }),
                (Locale.English, new UnlockInfo { Name = "Chocolate Bark", Description = "Adds Chocolate Bark as a Dessert", FlavourText = "Crunchy, chunky, chocolatey chaos" }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Écorce de chocolat", Description = "Ajoute l'écorce de chocolat comme dessert", FlavourText = "Croustillant, en morceaux, chaos chocolaté" }),
                (Locale.German, new UnlockInfo { Name = "Schokoladenrinde", Description = "Fügt Schokoladenrinde als Dessert hinzu", FlavourText = "Knuspriges, stückiges, schokoladiges Chaos" }),
                (Locale.Spanish, new UnlockInfo { Name = "Corteza de chocolate", Description = "Añade corteza de chocolate como postre", FlavourText = "Crujiente, con trozos, un caos de chocolate" }),
                (Locale.Polish, new UnlockInfo { Name = "Kora czekoladowa", Description = "Dodaje korę czekoladową jako deser", FlavourText = "Chrupiący, gruby, czekoladowy chaos" }),
                (Locale.Russian, new UnlockInfo { Name = "Шоколадная косточка", Description = "Добавьте шоколадную кору в качестве десерта", FlavourText = "Хрустящий, хрустящий, шоколадный хаос" }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Casca de chocolate", Description = "Adiciona casca de chocolate como sobremesa", FlavourText = "Um caos crocante, com pedaços e chocolate" }),
                (Locale.Japanese, new UnlockInfo { Name = "チョコレート・バーク", Description = "デザートとしてチョコレートバークを追加", FlavourText = "サクサク、もっちり、チョコレートのカオス" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "巧克力蛋糕", Description = "添加巧克力蛋糕作为甜点", FlavourText = "脆脆的、块块的、巧克力味的混沌" }),
                (Locale.Korean, new UnlockInfo { Name = "초콜릿 껍질", Description = "초콜릿 껍질을 디저트로 추가합니다.", FlavourText = "바삭하고 두툼한 초콜릿 카오스" }),
                (Locale.Turkish, new UnlockInfo { Name = "Çikolata Kabuğu", Description = "Tatlı Olarak Çikolata Kabuğu Ekler", FlavourText = "Çıtır çıtır, tıknaz, çikolatalı kaos" }),
            };
        }
    }
}