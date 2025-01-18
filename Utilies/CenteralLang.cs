using System.Collections.Generic;
using KitchenData;

namespace SwimmingSushiReborn.Utilies
{
    public static class CenteralLang
    {
        public static class Unlocks
        {
            public static List<(Locale, UnlockInfo)> SalmonRoll => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Salmon Roll", Description = "Adds Salmon Rolls as a Main", FlavourText = "Fish so fresh, even Poseidon would approve." }),
                (Locale.English, new UnlockInfo { Name = "Salmon Roll", Description = "Adds Salmon Rolls as a Main", FlavourText = "Fish so fresh, even Poseidon would approve." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Rouleau de saumon", Description = "Ajoute des rouleaux de saumon comme plat principal", FlavourText = "Un poisson si frais que même Poséidon l'approuverait." }),
                (Locale.German, new UnlockInfo { Name = "Lachsrolle", Description = "Fügt Lachsröllchen als Hauptgericht hinzu", FlavourText = "So frischer Fisch, dass sogar Poseidon zustimmen würde." }),
                (Locale.Spanish, new UnlockInfo { Name = "Rollo de salmón", Description = "Añade rollitos de salmón como plato principal", FlavourText = "Pescado tan fresco que hasta Poseidón lo aprobaría." }),
                (Locale.Polish, new UnlockInfo { Name = "Bułka z łososiem", Description = "Dodaje Roladki z łososia jako danie główne", FlavourText = "Ryby tak świeże, że nawet Posejdon by je zaakceptował." }),
                (Locale.Russian, new UnlockInfo { Name = "Ролл с лососем", Description = "Добавляет роллы с лососем в качестве основного блюда", FlavourText = "Рыба такой свежести, что ее одобрил бы даже Посейдон." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Enrolado de salmão", Description = "Adiciona rolinhos de salmão como prato principal", FlavourText = "Peixes tão frescos que até Poseidon aprovaria." }),
                (Locale.Japanese, new UnlockInfo { Name = "サーモン・ロール", Description = "メインにサーモンロールを追加", FlavourText = "ポセイドンも認めるほど新鮮な魚。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "三文鱼卷", Description = "添加三文鱼卷作为主菜", FlavourText = "鱼如此新鲜，就连波塞冬也会赞不绝口。" }),
                (Locale.Korean, new UnlockInfo { Name = "연어 롤", Description = "연어 롤을 메인으로 추가", FlavourText = "포세이돈도 인정할 만큼 신선한 생선." }),
                (Locale.Turkish, new UnlockInfo { Name = "Somon Rulo", Description = "Ana Yemek Olarak Somon Ruloları Ekler", FlavourText = "Balık o kadar taze ki, Poseidon bile onaylardı." }),
            };
            
            public static List<(Locale, UnlockInfo)> CrabRoll => new List<(Locale, UnlockInfo)>
{
    (Locale.Default, new UnlockInfo{Name = "Crab Roll", Description = "Adds Crab Rolls as a Main", FlavourText = "Crab your chopsticks and dig in!"}),
    (Locale.English, new UnlockInfo{Name = "Crab Roll", Description = "Adds Crab Rolls as a Main", FlavourText = "Crab your chopsticks and dig in!"}),
    (Locale.BlankText, new UnlockInfo{Name = "", Description = "", FlavourText = ""}),
    (Locale.French, new UnlockInfo{Name = "Rouleau de crabe", Description = "Ajout de rouleaux de crabe comme plat principal", FlavourText = "Mettez vos baguettes dans un crabe et plongez dans l'eau !"}),
    (Locale.German, new UnlockInfo{Name = "Krabbenrolle", Description = "Fügt Krabbenröllchen als Hauptgericht hinzu", FlavourText = "Nehmen Sie Ihre Stäbchen und greifen Sie zu!"}),
    (Locale.Spanish, new UnlockInfo{Name = "Rollo de cangrejo", Description = "Añade rollos de cangrejo como plato principal", FlavourText = "Coge los palillos y ¡a comer!"}),
    (Locale.Polish, new UnlockInfo{Name = "Bułka z krabem", Description = "Dodaje Crab Rolls jako danie główne", FlavourText = "Chwyć pałeczki i zagłęb się!"}),
    (Locale.Russian, new UnlockInfo{Name = "Крабовый ролл", Description = "Добавляет крабовые роллы в качестве основного блюда", FlavourText = "Берите палочки и приступайте!"}),
    (Locale.PortugueseBrazil, new UnlockInfo{Name = "Enrolado de caranguejo", Description = "Adiciona rolinhos de caranguejo como prato principal", FlavourText = "Pegue seus pauzinhos e comece a comer!"}),
    (Locale.Japanese, new UnlockInfo{Name = "蟹ロール", Description = "メインにカニロールを追加", FlavourText = "お箸を持ち、食べよう！"}),
    (Locale.ChineseSimplified, new UnlockInfo{Name = "蟹卷", Description = "添加蟹肉卷作为主菜", FlavourText = "拿起筷子，大快朵颐！"}),
    (Locale.Korean, new UnlockInfo{Name = "크랩 롤", Description = "크랩롤을 메인으로 추가", FlavourText = "젓가락을 들고 맛있게 드세요!"}),
    (Locale.Turkish, new UnlockInfo{Name = "Yengeç Rulo", Description = "Yengeç Rulolarını Ana Yemek Olarak Ekliyor", FlavourText = "Çubuklarınızı alın ve yumulun!"}),
};

            public static List<(Locale, UnlockInfo)> Nigiri => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Nigiri", Description = "Adds Nigiri as a Main", FlavourText = "Fish on top, rice below – it’s the sushi way to go!" }),
                (Locale.English, new UnlockInfo { Name = "Nigiri", Description = "Adds Nigiri as a Main", FlavourText = "Fish on top, rice below – it’s the sushi way to go!" }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Nigiri", Description = "Ajoute le Nigiri comme plat principal", FlavourText = "Le poisson sur le dessus, le riz en dessous - c'est la façon de faire des sushis !" }),
                (Locale.German, new UnlockInfo { Name = "Nigiri", Description = "Fügt Nigiri als Hauptgericht hinzu", FlavourText = "Oben der Fisch, unten der Reis - so geht Sushi!" }),
                (Locale.Spanish, new UnlockInfo { Name = "Nigiri", Description = "Añade Nigiri como plato principal", FlavourText = "Pescado arriba, arroz abajo: ¡así se hace el sushi!" }),
                (Locale.Polish, new UnlockInfo { Name = "Nigiri", Description = "Dodaje Nigiri jako danie główne", FlavourText = "Ryba na wierzchu, ryż pod spodem - to sposób na sushi!" }),
                (Locale.Russian, new UnlockInfo { Name = "Нигири", Description = "Добавляет нигири в качестве основного блюда", FlavourText = "Рыба сверху, рис снизу - вот что такое суши!" }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Nigiri", Description = "Adiciona Nigiri como prato principal", FlavourText = "Peixe em cima, arroz embaixo - é assim que se faz sushi!" }),
                (Locale.Japanese, new UnlockInfo { Name = "握り", Description = "メインに握りを追加", FlavourText = "魚が上、シャリが下-これが寿司の流儀だ！" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "饭团", Description = "增加主菜 Nigiri", FlavourText = "鱼在上面，米饭在下面，这就是寿司的做法！" }),
                (Locale.Korean, new UnlockInfo { Name = "니기리", Description = "메인으로 초밥 추가", FlavourText = "생선은 위에, 밥은 아래에 - 이것이 바로 초밥의 방식입니다!" }),
                (Locale.Turkish, new UnlockInfo { Name = "Nigiri", Description = "Nigiri'yi Ana Yemek Olarak Ekler", FlavourText = "Balık üstte, pirinç altta - suşi böyle yapılır!" }),
            };

            public static List<(Locale, UnlockInfo)> Onigiri => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Onigiri", Description = "Adds Onigiri as a Main", FlavourText = "It’s hip to be triangular." }),
                (Locale.English, new UnlockInfo { Name = "Onigiri", Description = "Adds Onigiri as a Main", FlavourText = "It’s hip to be triangular." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Onigiri", Description = "Ajoute l'Onigiri comme plat principal", FlavourText = "Il est tendance d'être triangulaire." }),
                (Locale.German, new UnlockInfo { Name = "Onigiri", Description = "Fügt Onigiri als Hauptgericht hinzu", FlavourText = "Es ist hip, dreieckig zu sein." }),
                (Locale.Spanish, new UnlockInfo { Name = "Onigiri", Description = "Añade el onigiri como plato principal", FlavourText = "Está de moda ser triangular." }),
                (Locale.Polish, new UnlockInfo { Name = "Onigiri", Description = "Dodaje Onigiri jako danie główne", FlavourText = "Modnie jest być trójkątnym." }),
                (Locale.Russian, new UnlockInfo { Name = "Онигири", Description = "Добавляет онигири в качестве основного блюда", FlavourText = "Бедро должно быть треугольным." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Onigiri", Description = "Adiciona Onigiri como prato principal", FlavourText = "É moderno ser triangular." }),
                (Locale.Japanese, new UnlockInfo { Name = "おにぎり", Description = "メインにおにぎりを追加", FlavourText = "三角形であることがヒップだ。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "饭团", Description = "将饭团作为主菜", FlavourText = "三角形很时髦。" }),
                (Locale.Korean, new UnlockInfo { Name = "오니기리", Description = "주먹밥을 메인으로 추가", FlavourText = "삼각형이 최신 유행입니다." }),
                (Locale.Turkish, new UnlockInfo { Name = "Onigiri", Description = "Onigiri'yi Ana Yemek Olarak Ekler", FlavourText = "Üçgen olmak moda." }),
            };

            public static List<(Locale, UnlockInfo)> SoySauce => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Sushi - Soy Sauce", Description = "Customers can request soy sauce while eating Sushi", FlavourText = "A salty splash of perfection." }),
                (Locale.English, new UnlockInfo { Name = "Sushi - Soy Sauce", Description = "Customers can request soy sauce while eating Sushi", FlavourText = "A salty splash of perfection." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Sushi - Sauce soja", Description = "Les clients peuvent demander de la sauce soja lorsqu'ils mangent des sushis.", FlavourText = "Une touche salée de perfection." }),
                (Locale.German, new UnlockInfo { Name = "Sushi - Sojasoße", Description = "Kunden können beim Essen von Sushi Sojasauce verlangen", FlavourText = "Ein salziger Spritzer von Perfektion." }),
                (Locale.Spanish, new UnlockInfo { Name = "Sushi - Salsa de soja", Description = "Los clientes pueden pedir salsa de soja mientras comen sushi", FlavourText = "Un salpicón salado de perfección." }),
                (Locale.Polish, new UnlockInfo { Name = "Sushi - sos sojowy", Description = "Klienci mogą poprosić o sos sojowy podczas jedzenia sushi", FlavourText = "Słony plusk doskonałości." }),
                (Locale.Russian, new UnlockInfo { Name = "Суши - соевый соус", Description = "Клиенты могут попросить соевый соус, когда едят суши", FlavourText = "Соленые брызги совершенства." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Sushi - Molho de soja", Description = "Os clientes podem solicitar molho de soja ao comer sushi", FlavourText = "Um toque salgado de perfeição." }),
                (Locale.Japanese, new UnlockInfo { Name = "寿司 - しょうゆ", Description = "寿司を食べながら醤油をリクエストできる", FlavourText = "完璧な塩味のスプラッシュ。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "寿司 - 酱油", Description = "顾客可以在吃寿司时要求酱油", FlavourText = "咸香四溢，堪称完美。" }),
                (Locale.Korean, new UnlockInfo { Name = "초밥 - 간장", Description = "초밥을 먹으면서 간장을 요청할 수 있습니다.", FlavourText = "완벽함의 짭짤한 스플래시." }),
                (Locale.Turkish, new UnlockInfo { Name = "Suşi - Soya Sosu", Description = "Müşteriler Suşi yerken soya sosu talep edebilir", FlavourText = "Mükemmelliğin tuzlu bir sıçraması." }),
            };

            public static List<(Locale, UnlockInfo)> Sashimi => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Sashimi", Description = "Adds Sashimi as a Main", FlavourText = "So fresh, it practically swims." }),
                (Locale.English, new UnlockInfo { Name = "Sashimi", Description = "Adds Sashimi as a Main", FlavourText = "So fresh, it practically swims." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Sashimi", Description = "Ajoute le sashimi comme plat principal", FlavourText = "Il est si frais qu'il nage pratiquement." }),
                (Locale.German, new UnlockInfo { Name = "Sashimi", Description = "Fügt Sashimi als Hauptgericht hinzu", FlavourText = "So frisch, dass es praktisch schwimmt." }),
                (Locale.Spanish, new UnlockInfo { Name = "Sashimi", Description = "Añade sashimi como plato principal", FlavourText = "Tan fresco que prácticamente nada." }),
                (Locale.Polish, new UnlockInfo { Name = "Sashimi", Description = "Dodaje Sashimi jako danie główne", FlavourText = "Tak świeży, że praktycznie pływa." }),
                (Locale.Russian, new UnlockInfo { Name = "Сашими", Description = "Добавляет сашими в качестве основного блюда", FlavourText = "Он настолько свеж, что практически плавает." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Sashimi", Description = "Adiciona sashimi como prato principal", FlavourText = "Tão fresco que praticamente nada." }),
                (Locale.Japanese, new UnlockInfo { Name = "刺身", Description = "メインに刺身を追加", FlavourText = "とても新鮮で、まるで泳いでいるようだ。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "刺身", Description = "增加主食刺身", FlavourText = "如此新鲜，几乎可以游泳。" }),
                (Locale.Korean, new UnlockInfo { Name = "사시미", Description = "사시미를 메인으로 추가", FlavourText = "너무 신선해서 거의 헤엄치다시피 합니다." }),
                (Locale.Turkish, new UnlockInfo { Name = "Sashimi", Description = "Sashimi'yi Ana Yemek Olarak Ekler", FlavourText = "O kadar taze ki, neredeyse yüzüyor." }),
            };

            public static List<(Locale, UnlockInfo)> Gunkan => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Gunkan", Description = "Adds Gunkan as a Main", FlavourText = "The unsinkable flavor ship." }),
                (Locale.English, new UnlockInfo { Name = "Gunkan", Description = "Adds Gunkan as a Main", FlavourText = "The unsinkable flavor ship." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Gunkan", Description = "Ajout de Gunkan en tant qu'élément principal", FlavourText = "Le navire insubmersible." }),
                (Locale.German, new UnlockInfo { Name = "Gunkan", Description = "Fügt Gunkan als Hauptrolle hinzu", FlavourText = "Das unsinkbare Geschmacksschiff." }),
                (Locale.Spanish, new UnlockInfo { Name = "Gunkan", Description = "Añade Gunkan como principal", FlavourText = "El insumergible barco del sabor." }),
                (Locale.Polish, new UnlockInfo { Name = "Gunkan", Description = "Dodaje Gunkan jako główną postać", FlavourText = "Niezatapialny statek smakowy." }),
                (Locale.Russian, new UnlockInfo { Name = "Gunkan", Description = "Добавляет Гункан в качестве основного", FlavourText = "Непотопляемый корабль с ароматом." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Gunkan", Description = "Adiciona Gunkan como principal", FlavourText = "O navio de sabor inafundável." }),
                (Locale.Japanese, new UnlockInfo { Name = "軍艦", Description = "メインに軍艦を追加", FlavourText = "不沈艦。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "文化馆", Description = "将 Gunkan 作为主线", FlavourText = "永不沉没的风味船" }),
                (Locale.Korean, new UnlockInfo { Name = "군칸", Description = "군칸을 메인으로 추가", FlavourText = "가라앉지 않는 맛의 배." }),
                (Locale.Turkish, new UnlockInfo { Name = "Gunkan", Description = "Gunkan'ı Ana Ekip Olarak Ekler", FlavourText = "Batmayan lezzet gemisi." }),
            };

            public static List<(Locale, UnlockInfo)> FreshNori => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Fresh Nori", Description = "Create your own Nori instead of using premade", FlavourText = "The leaf that holds it all together." }),
                (Locale.English, new UnlockInfo { Name = "Fresh Nori", Description = "Create your own Nori instead of using premade", FlavourText = "The leaf that holds it all together." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Nori frais", Description = "Créez votre propre Nori au lieu d'utiliser des produits préparés à l'avance", FlavourText = "La feuille qui tient le tout ensemble." }),
                (Locale.German, new UnlockInfo { Name = "Frischer Nori", Description = "Stellen Sie Ihr eigenes Nori her, anstatt vorgefertigte zu verwenden", FlavourText = "Das Blatt, das alles zusammenhält." }),
                (Locale.Spanish, new UnlockInfo { Name = "Nori fresco", Description = "Crea tu propio Nori en lugar de utilizarlo ya hecho", FlavourText = "La hoja que lo mantiene todo unido." }),
                (Locale.Polish, new UnlockInfo { Name = "Świeże Nori", Description = "Stwórz własne Nori zamiast używać gotowych produktów", FlavourText = "Liść, który trzyma wszystko razem." }),
                (Locale.Russian, new UnlockInfo { Name = "Свежие нори", Description = "Создайте свои собственные нори, а не используйте готовые.", FlavourText = "Лист, который держит все вместе." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Nori fresco", Description = "Crie seu próprio Nori em vez de usar o já pronto", FlavourText = "A folha que mantém tudo unido." }),
                (Locale.Japanese, new UnlockInfo { Name = "生海苔", Description = "出来合いの海苔を使わず、自分で海苔を作る", FlavourText = "すべてをまとめる葉。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "新鲜紫菜", Description = "自己制作紫菜，而不是使用预制紫菜", FlavourText = "支撑这一切的树叶" }),
                (Locale.Korean, new UnlockInfo { Name = "신선한 김", Description = "기성품 김 대신 나만의 김을 만들어 보세요.", FlavourText = "이 모든 것을 하나로 묶어주는 잎사귀." }),
                (Locale.Turkish, new UnlockInfo { Name = "Taze Nori", Description = "Hazır gıda kullanmak yerine kendi Nori'nizi yaratın", FlavourText = "Her şeyi bir arada tutan yaprak." }),
            };

            public static List<(Locale, UnlockInfo)> FreshRoe => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Fresh Roe", Description = "Create your own Roe instead of using premade", FlavourText = "Little pops of ocean joy." }),
                (Locale.English, new UnlockInfo { Name = "Fresh Roe", Description = "Create your own Roe instead of using premade", FlavourText = "Little pops of ocean joy." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Chevreuil frais", Description = "Créez votre propre rogue au lieu d'utiliser des produits préparés à l'avance", FlavourText = "Des petites touches de joie océanique." }),
                (Locale.German, new UnlockInfo { Name = "Frischer Rogen", Description = "Stellen Sie Ihr eigenes Roe her, anstatt vorgefertigtes zu verwenden", FlavourText = "Kleine Freudensprünge aus dem Meer." }),
                (Locale.Spanish, new UnlockInfo { Name = "Hueva fresca", Description = "Cree sus propias huevas en lugar de utilizar las ya preparadas", FlavourText = "Pequeños estallidos de alegría oceánica." }),
                (Locale.Polish, new UnlockInfo { Name = "Świeża ikra", Description = "Stwórz własną ikrę zamiast korzystać z gotowych produktów", FlavourText = "Małe kropelki oceanicznej radości." }),
                (Locale.Russian, new UnlockInfo { Name = "Свежая икра", Description = "Создайте свою собственную икру, а не используйте готовую", FlavourText = "Маленькие всплески океанской радости." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Ovas frescas", Description = "Crie seu próprio Roe em vez de usar o pré-fabricado", FlavourText = "Pequenos toques de alegria do oceano." }),
                (Locale.Japanese, new UnlockInfo { Name = "新鮮な卵", Description = "既製品を使わず、自分でローを作る", FlavourText = "小さな海の喜びのポップ。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "新鲜鱼子酱", Description = "制作自己的狍子，而不是使用预制狍子", FlavourText = "小小的海洋欢乐" }),
                (Locale.Korean, new UnlockInfo { Name = "신선한 알", Description = "기성품을 사용하는 대신 나만의 알을 만들어 보세요.", FlavourText = "바다의 작은 기쁨을 만끽하세요." }),
                (Locale.Turkish, new UnlockInfo { Name = "Taze Karaca", Description = "Hazır kullanmak yerine kendi Karaca'nızı yaratın", FlavourText = "Okyanus neşesinin küçük patlamaları." }),
            };

            public static List<(Locale, UnlockInfo)> ChonkyNigiri => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Chonky Nigiri", Description = "Adds Chonky Nigiri as a Main", FlavourText = "Bigger bites, bolder delights." }),
                (Locale.English, new UnlockInfo { Name = "Chonky Nigiri", Description = "Adds Chonky Nigiri as a Main", FlavourText = "Bigger bites, bolder delights." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Chonky Nigiri", Description = "Ajoute le Chonky Nigiri comme plat principal", FlavourText = "De plus grandes bouchées, des délices plus audacieux." }),
                (Locale.German, new UnlockInfo { Name = "Chonky Nigiri", Description = "Fügt Chonky Nigiri als Hauptgericht hinzu", FlavourText = "Größere Bissen, kühneres Vergnügen." }),
                (Locale.Spanish, new UnlockInfo { Name = "Chonky Nigiri", Description = "Añade Chonky Nigiri como plato principal", FlavourText = "Bocados más grandes, delicias más audaces." }),
                (Locale.Polish, new UnlockInfo { Name = "Chonky Nigiri", Description = "Dodaje Chonky Nigiri jako danie główne", FlavourText = "Większe kęsy, odważniejsze rozkosze." }),
                (Locale.Russian, new UnlockInfo { Name = "Чонки нигири", Description = "Добавляет нигири чонки в качестве основного блюда", FlavourText = "Больше укусов, больше удовольствия." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Chonky Nigiri", Description = "Adiciona o Chonky Nigiri como prato principal", FlavourText = "Mordidas maiores, delícias mais ousadas." }),
                (Locale.Japanese, new UnlockInfo { Name = "ちょんまげ握り", Description = "メインに「ちょんまげにぎり」を追加", FlavourText = "より大きな一口、より大胆な喜び。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "Chonky Nigiri", Description = "增加主菜 Chonky Nigiri", FlavourText = "更大的口感，更大胆的享受。" }),
                (Locale.Korean, new UnlockInfo { Name = "촌키 니기리", Description = "촌키 니기리를 메인으로 추가합니다.", FlavourText = "더 큰 한입, 더 대담한 즐거움." }),
                (Locale.Turkish, new UnlockInfo { Name = "Chonky Nigiri", Description = "Chonky Nigiri'yi Ana Yemek Olarak Ekliyor", FlavourText = "Daha büyük ısırıklar, daha cesur lezzetler." }),
            };

            public static List<(Locale, UnlockInfo)> Ginger => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Ginger", Description = "Adds Ginger as a Side", FlavourText = "A palate cleanser with a punch." }),
                (Locale.English, new UnlockInfo { Name = "Ginger", Description = "Adds Ginger as a Side", FlavourText = "A palate cleanser with a punch." }),
                (Locale.BlankText, new UnlockInfo { Name = "", Description = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Gingembre", Description = "Le gingembre en accompagnement", FlavourText = "Un nettoyant pour le palais qui a du punch." }),
                (Locale.German, new UnlockInfo { Name = "Ingwer", Description = "Fügt Ingwer als Beilage hinzu", FlavourText = "Ein Gaumenreiniger mit Pfiff." }),
                (Locale.Spanish, new UnlockInfo { Name = "Jengibre", Description = "Añade jengibre como acompañamiento", FlavourText = "Un limpiador de paladar con garra." }),
                (Locale.Polish, new UnlockInfo { Name = "Imbir", Description = "Dodaje imbir jako dodatek", FlavourText = "Oczyszczacz podniebienia z mocnym uderzeniem." }),
                (Locale.Russian, new UnlockInfo { Name = "Имбирь", Description = "Добавляет имбирь в качестве гарнира", FlavourText = "Очищающее средство для вкуса с сильным ударом." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Gengibre", Description = "Adiciona gengibre como acompanhamento", FlavourText = "Um limpador de paladar com um soco." }),
                (Locale.Japanese, new UnlockInfo { Name = "ジンジャー", Description = "サイドメニューにジンジャーを加える", FlavourText = "パンチのある口直し。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "姜", Description = "添加生姜作为配菜", FlavourText = "是一款极具冲击力的清口饮料。" }),
                (Locale.Korean, new UnlockInfo { Name = "생강", Description = "생강을 사이드 메뉴로 추가", FlavourText = "펀치력이 있는 입천장 클렌저." }),
                (Locale.Turkish, new UnlockInfo { Name = "Zencefil", Description = "Yan Olarak Zencefil Ekler", FlavourText = "Güçlü bir damak temizleyicisi." }),
            };
            
            public static List<(Locale, UnlockInfo)> Wasabi => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo{Name = "Wasabi", Description = "Adds Wasabi as a Side", FlavourText = "A fiery kick in a tiny dollop."}),
                (Locale.English, new UnlockInfo{Name = "Wasabi", Description = "Adds Wasabi as a Side", FlavourText = "A fiery kick in a tiny dollop."}),
                (Locale.BlankText, new UnlockInfo{Name = "", Description = "", FlavourText = ""}),
                (Locale.French, new UnlockInfo{Name = "Wasabi", Description = "Ajoute du wasabi en accompagnement", FlavourText = "Un coup de fouet dans une petite cuillerée."}),
                (Locale.German, new UnlockInfo{Name = "Wasabi", Description = "Fügt Wasabi als Beilage hinzu", FlavourText = "Ein feuriger Kick in einer winzigen Portion."}),
                (Locale.Spanish, new UnlockInfo{Name = "Wasabi", Description = "Añade Wasabi como guarnición", FlavourText = "Una patada ardiente en una pequeña porción."}),
                (Locale.Polish, new UnlockInfo{Name = "Wasabi", Description = "Dodaje wasabi jako dodatek", FlavourText = "Ognisty kop w małej porcji."}),
                (Locale.Russian, new UnlockInfo{Name = "Васаби", Description = "Добавляет васаби в качестве гарнира", FlavourText = "Жаркий удар в крошечной ложечке."}),
                (Locale.PortugueseBrazil, new UnlockInfo{Name = "Wasabi", Description = "Adiciona wasabi como acompanhamento", FlavourText = "Um chute ardente em uma pequena porção."}),
                (Locale.Japanese, new UnlockInfo{Name = "わさび", Description = "わさびをサイドメニューに加える", FlavourText = "小さな一滴の中に、燃えるようなキックがある。"}),
                (Locale.ChineseSimplified, new UnlockInfo{Name = "山葵", Description = "添加山葵作为配菜", FlavourText = "小小一勺，火辣辣的。"}),
                (Locale.Korean, new UnlockInfo{Name = "와사비", Description = "와사비를 사이드 메뉴로 추가", FlavourText = "작은 덩어리에서 불 같은 킥을 날립니다."}),
                (Locale.Turkish, new UnlockInfo{Name = "Wasabi", Description = "Wasabi'yi Yan Olarak Ekler", FlavourText = "Küçük bir topakta ateşli bir tekme."}),
            };
            
            public static List<(Locale, UnlockInfo)> RecipeMayonnaise => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo{Name = "Mayonnaise", Description = "", FlavourText = ""}),
                (Locale.English, new UnlockInfo{Name = "Mayonnaise", Description = "", FlavourText = ""}),
                (Locale.BlankText, new UnlockInfo{Name = "", Description = "", FlavourText = ""}),
                (Locale.French, new UnlockInfo{Name = "Mayonnaise", Description = "", FlavourText = ""}),
                (Locale.German, new UnlockInfo{Name = "Mayonnaise", Description = "", FlavourText = ""}),
                (Locale.Spanish, new UnlockInfo{Name = "Mayonesa", Description = "", FlavourText = ""}),
                (Locale.Polish, new UnlockInfo{Name = "Majonez", Description = "", FlavourText = ""}),
                (Locale.Russian, new UnlockInfo{Name = "Майонез", Description = "", FlavourText = ""}),
                (Locale.PortugueseBrazil, new UnlockInfo{Name = "Maionese", Description = "", FlavourText = ""}),
                (Locale.Japanese, new UnlockInfo{Name = "マヨネーズ", Description = "", FlavourText = ""}),
                (Locale.ChineseSimplified, new UnlockInfo{Name = "蛋黄酱", Description = "", FlavourText = ""}),
                (Locale.Korean, new UnlockInfo{Name = "마요네즈", Description = "", FlavourText = ""}),
                (Locale.Turkish, new UnlockInfo{Name = "Mayonez", Description = "", FlavourText = ""}),
            };
        }

        public static class Recipes
        {
            public static Dictionary<Locale, string> SalmonRoll => new Dictionary<Locale, string>
            {
                { Locale.Default, "Combine Rice and Water in a Pot and Cook. Portion onto a Nori sheet, and add chopped Salmon and Avocado, Roll, Chop, and Portion." },
                { Locale.English, "Combine Rice and Water in a Pot and Cook. Portion onto a Nori sheet, and add chopped Salmon and Avocado, Roll, Chop, and Portion." },
                { Locale.BlankText, "" },
                { Locale.French, "Mélanger le riz et l'eau dans une casserole et faire cuire. Répartir sur une feuille de nori, ajouter du saumon et de l'avocat hachés, rouler, hacher et répartir." },
                { Locale.German, "Reis und Wasser in einem Topf vermengen und kochen. Auf ein Nori-Blatt portionieren und gehackten Lachs und Avocado hinzufügen, rollen, hacken und portionieren." },
                { Locale.Spanish, "Combine el arroz y el agua en una olla y cocine. Porcionar en una hoja de Nori, y añadir Salmón picado y Aguacate, Enrollar, Picar, y Porcionar." },
                { Locale.Polish, "Połącz ryż i wodę w garnku i ugotuj. Przełożyć na arkusz nori, dodać pokrojonego łososia i awokado, zrolować, posiekać i przełożyć." },
                { Locale.Russian, "Соедините рис и воду в кастрюле и варите. Выложите порционно на лист нори, добавьте нарезанный лосось и авокадо, сверните, нарежьте и выложите порционно." },
                { Locale.PortugueseBrazil, "Combine arroz e água em uma panela e cozinhe. Distribua em uma folha de Nori e adicione salmão e abacate picados, enrole, corte e distribua." },
                { Locale.Japanese, "鍋に米と水を入れて炊く。海苔の上に盛り付け、刻んだサーモンとアボカドを加え、巻いて刻んで盛り付ける。" },
                { Locale.ChineseSimplified, "将米和水放入锅中煮。分装在紫菜片上，加入切碎的三文鱼和牛油果，卷起，切碎，分装。" },
                { Locale.Korean, "냄비에 쌀과 물을 넣고 끓입니다. 김 시트에 나누어 담고 다진 연어와 아보카도를 넣고 굴려서 잘게 자른 후 나누어 담습니다." },
                { Locale.Turkish, "Pirinç ve Suyu bir tencerede karıştırın ve pişirin. Nori yaprağına paylaştırın ve doğranmış Somon ve Avokado ekleyin, Yuvarlayın, Doğrayın ve Paylaştırın." },
            };
            
            public static Dictionary<Locale, string> CrabRoll => new Dictionary<Locale, string>
            {
                {Locale.Default, "Combine Rice and Water in a Pot and Cook. Portion onto a Nori sheet, and add chopped Crab and Mayonnaise, Roll, Chop, and Portion."},
                {Locale.English, "Combine Rice and Water in a Pot and Cook. Portion onto a Nori sheet, and add chopped Crab and Mayonnaise, Roll, Chop, and Portion."},
                {Locale.BlankText, ""},
                {Locale.French, "Mélanger le riz et l'eau dans une casserole et faire cuire. Répartir sur une feuille de nori, ajouter du crabe haché et de la mayonnaise, rouler, hacher et répartir."},
                {Locale.German, "Reis und Wasser in einem Topf vermengen und kochen. Auf ein Nori-Blatt portionieren, gehackte Krabben und Mayonnaise hinzufügen, rollen, hacken und portionieren."},
                {Locale.Spanish, "Combine el Arroz y el Agua en una Olla y Cocine. Porcionar en una hoja de Nori, y añadir Cangrejo picado y Mayonesa, Enrollar, Picar, y Porcionar."},
                {Locale.Polish, "Połącz ryż i wodę w garnku i ugotuj. Przełożyć na arkusz nori, dodać posiekany krab i majonez, zwinąć, posiekać i przełożyć."},
                {Locale.Russian, "Соедините рис и воду в кастрюле и варите. Выложите порционно на лист нори, добавьте измельченный краб и майонез, сверните, нарежьте и выложите порционно."},
                {Locale.PortugueseBrazil, "Combine arroz e água em uma panela e cozinhe. Distribua em uma folha de Nori e adicione caranguejo picado e maionese, enrole, corte e distribua."},
                {Locale.Japanese, "米と水を鍋に入れて炊く。海苔の上に盛り付け、刻んだカニとマヨネーズを加え、巻いて刻んで盛り付ける。"},
                {Locale.ChineseSimplified, "将米和水放入锅中煮。分装在紫菜片上，加入切碎的蟹肉和蛋黄酱，卷起，切碎，分装。"},
                {Locale.Korean, "냄비에 쌀과 물을 넣고 끓입니다. 김 시트에 나누어 담고 다진 게와 마요네즈를 넣고 굴려서 잘게 자른 후 나누어 담습니다."},
                {Locale.Turkish, "Pirinç ve Suyu bir tencerede karıştırın ve pişirin. Nori yaprağına paylaştırın ve doğranmış Yengeç ve Mayonez ekleyin, Yuvarlayın, Doğrayın ve Paylaştırın."},
            };

            public static Dictionary<Locale, string> Nigiri => new Dictionary<Locale, string>
            {
                { Locale.Default, "Combine Rice and Water in a Pot and Cook. Portion and roll, and combine with Chopped Salmon" },
                { Locale.English, "Combine Rice and Water in a Pot and Cook. Portion and roll, and combine with Chopped Salmon" },
                { Locale.BlankText, "" },
                { Locale.French, "Mélanger le riz et l'eau dans une casserole et faire cuire. Portionner et rouler, et combiner avec le saumon haché." },
                { Locale.German, "Reis und Wasser in einem Topf vermengen und kochen. Portionieren, rollen und mit dem gehackten Lachs kombinieren." },
                { Locale.Spanish, "Combine el Arroz y el Agua en una Olla y Cocine. Porcionar y enrollar, y combinar con Salmón picado." },
                { Locale.Polish, "Połączyć ryż i wodę w garnku i ugotować. Porcjować, zwijać i łączyć z posiekanym łososiem" },
                { Locale.Russian, "Соедините рис и воду в кастрюле и варите. Порционируйте, сверните в рулет и соедините с нарезанным лососем." },
                { Locale.PortugueseBrazil, "Misture o arroz e a água em uma panela e cozinhe. Divida em porções, enrole e combine com o salmão picado" },
                { Locale.Japanese, "米と水を鍋に入れて炊く。鮭のみじん切りと合わせる。" },
                { Locale.ChineseSimplified, "将米和水放入锅中煮。分装、卷起，与切碎的三文鱼一起食用" },
                { Locale.Korean, "냄비에 밥과 물을 넣고 조리합니다. 나누어 말아서 다진 연어와 섞어줍니다." },
                { Locale.Turkish, "Pirinç ve suyu bir tencerede karıştırın ve pişirin. Porsiyonlayın, yuvarlayın ve Doğranmış Somon ile birleştirin" },
            };

            public static Dictionary<Locale, string> Onigiri => new Dictionary<Locale, string>
            {
                { Locale.Default, "Combine Rice and Water in a Pot and Cook. Portion, Roll into ball, and combine with Cooked Seaweed" },
                { Locale.English, "Combine Rice and Water in a Pot and Cook. Portion, Roll into ball, and combine with Cooked Seaweed" },
                { Locale.BlankText, "" },
                { Locale.French, "Mélanger le riz et l'eau dans une casserole et faire cuire. Portionner, rouler en boule et combiner avec les algues cuites." },
                { Locale.German, "Reis und Wasser in einem Topf vermengen und kochen. Portionieren, zu einer Kugel rollen und mit gekochtem Seetang kombinieren." },
                { Locale.Spanish, "Mezclar el arroz y el agua en una olla y cocer. Porcionar, hacer una bola y mezclar con las algas cocidas." },
                { Locale.Polish, "Połącz ryż i wodę w garnku i ugotuj. Porcjować, zwijać w kulki i łączyć z ugotowanymi wodorostami." },
                { Locale.Russian, "Соедините рис и воду в кастрюле и варите. Отделите порцию, скатайте в шарик и соедините с приготовленными морскими водорослями." },
                { Locale.PortugueseBrazil, "Combine arroz e água em uma panela e cozinhe. Divida em porções, enrole em uma bola e combine com algas marinhas cozidas" },
                { Locale.Japanese, "米と水を鍋に入れて炊く。分量に分け、丸め、茹でた海苔と合わせる。" },
                { Locale.ChineseSimplified, "将米和水放入锅中煮。取适量，搓成球状，与煮熟的海藻一起食用。" },
                { Locale.Korean, "냄비에 밥과 물을 넣고 조리합니다. 나누어 공 모양으로 말아 익힌 김과 섞어줍니다." },
                { Locale.Turkish, "Pirinç ve suyu bir tencerede karıştırın ve pişirin. Porsiyonlara ayırın, top haline getirin ve Pişmiş Deniz Yosunu ile birleştirin" },
            };

            public static Dictionary<Locale, string> SoySauce => new Dictionary<Locale, string>
            {
                { Locale.Default, "Customers may order Soy Sauce while eating." },
                { Locale.English, "Customers may order Soy Sauce while eating." },
                { Locale.BlankText, "" },
                { Locale.French, "Les clients peuvent commander de la sauce soja pendant qu'ils mangent." },
                { Locale.German, "Kunden können während des Essens Sojasoße bestellen." },
                { Locale.Spanish, "Los clientes pueden pedir salsa de soja mientras comen." },
                { Locale.Polish, "Klienci mogą zamówić sos sojowy podczas jedzenia." },
                { Locale.Russian, "Клиенты могут заказать соевый соус во время еды." },
                { Locale.PortugueseBrazil, "Os clientes podem pedir molho de soja enquanto comem." },
                { Locale.Japanese, "食べながら醤油を注文することもできる。" },
                { Locale.ChineseSimplified, "顾客可在用餐时点酱油。" },
                { Locale.Korean, "고객은 식사 중에 간장을 주문할 수 있습니다." },
                { Locale.Turkish, "Müşteriler yemek yerken Soya Sosu sipariş edebilirler." },
            };

            public static Dictionary<Locale, string> Sashimi => new Dictionary<Locale, string>
            {
                { Locale.Default, "Double Chop Salmon, Plate and Serve" },
                { Locale.English, "Double Chop Salmon, Plate and Serve" },
                { Locale.BlankText, "" },
                { Locale.French, "Couper le saumon en deux, le mettre en assiette et le servir" },
                { Locale.German, "Lachs doppelt hacken, plattieren und servieren" },
                { Locale.Spanish, "Cortar el salmón en dos trozos, emplatar y servir" },
                { Locale.Polish, "Podwójnie posiekaj łososia, nałóż na talerz i podawaj" },
                { Locale.Russian, "Нарежьте лосося на две части, разложите по тарелкам и подавайте." },
                { Locale.PortugueseBrazil, "Corte o salmão duas vezes, coloque no prato e sirva" },
                { Locale.Japanese, "サーモンをダブルチョップし、皿に盛り付ける。" },
                { Locale.ChineseSimplified, "将三文鱼切成两半，装盘上桌" },
                { Locale.Korean, "연어를 두 번 자르고 접시에 담아 제공" },
                { Locale.Turkish, "Somonu İkili Doğrayın, Tabaklayın ve Servis Edin" },
            };

            public static Dictionary<Locale, string> Gunkan => new Dictionary<Locale, string>
            {
                { Locale.Default, "Combine Rice and Water in a Pot and Cook. Portion, and combine with Cooked Seaweed, and Roe" },
                { Locale.English, "Combine Rice and Water in a Pot and Cook. Portion, and combine with Cooked Seaweed, and Roe" },
                { Locale.BlankText, "" },
                { Locale.French, "Mélanger le riz et l'eau dans une casserole et faire cuire. Portionner et combiner avec les algues cuites et la rogue." },
                { Locale.German, "Reis und Wasser in einem Topf vermengen und kochen. Portionieren und mit gekochtem Seetang und Rogen kombinieren" },
                { Locale.Spanish, "Mezcle el arroz y el agua en una olla y cuézalo. Porcionar y combinar con las algas cocidas y las huevas." },
                { Locale.Polish, "Połącz ryż i wodę w garnku i ugotuj. Porcjować i połączyć z ugotowanymi wodorostami i ikrą." },
                { Locale.Russian, "Соедините рис и воду в кастрюле и варите. Разделите на порции и соедините с приготовленными морскими водорослями и икрой." },
                { Locale.PortugueseBrazil, "Misture o arroz e a água em uma panela e cozinhe. Divida em porções e combine com algas marinhas cozidas e ovas" },
                { Locale.Japanese, "米と水を鍋に入れて炊く。茹でたわかめ、卵と合わせる。" },
                { Locale.ChineseSimplified, "将米和水放入锅中煮。分装，与煮熟的海藻和鱼子一起食用" },
                { Locale.Korean, "냄비에 밥과 물을 넣고 조리합니다. 나누어 익힌 김과 알을 넣고 섞어줍니다." },
                { Locale.Turkish, "Pirinç ve Suyu Bir Tencerede Birleştirin ve Pişirin. Porsiyonlayın ve Pişmiş Deniz Yosunu ve Karaca ile birleştirin" },
            };

            public static Dictionary<Locale, string> FreshNori => new Dictionary<Locale, string>
            {
                { Locale.Default, "Cook 2 Seaweed and Combine" },
                { Locale.English, "Cook 2 Seaweed and Combine" },
                { Locale.BlankText, "" },
                { Locale.French, "Cuire 2 algues et les mélanger" },
                { Locale.German, "2 Seegras kochen und kombinieren" },
                { Locale.Spanish, "Cocer 2 algas y combinar" },
                { Locale.Polish, "Ugotować 2 wodorosty i połączyć" },
                { Locale.Russian, "Приготовьте 2 морских водоросли и соедините их" },
                { Locale.PortugueseBrazil, "Cozinhe 2 algas marinhas e misture" },
                { Locale.Japanese, "わかめ2枚を茹でて混ぜる" },
                { Locale.ChineseSimplified, "煮 2 海藻并混合" },
                { Locale.Korean, "해초 2개를 익혀 섞습니다." },
                { Locale.Turkish, "2 Deniz Yosununu Pişirin ve Birleştirin" },
            };

            public static Dictionary<Locale, string> FreshRoe => new Dictionary<Locale, string>
            {
                { Locale.Default, "Use Fish Knife to chop Salmon, portion Roe." },
                { Locale.English, "Use Fish Knife to chop Salmon, portion Roe." },
                { Locale.BlankText, "" },
                { Locale.French, "Utiliser le couteau à poisson pour hacher le saumon, portionner les œufs de poisson." },
                { Locale.German, "Verwenden Sie das Fischmesser, um Lachs und Rogen zu zerteilen." },
                { Locale.Spanish, "Utilice el Cuchillo de Pescado para trocear Salmón, porción de Huevas." },
                { Locale.Polish, "Użyj noża do ryb, aby posiekać łososia i porcjować ikrę." },
                { Locale.Russian, "Используйте нож для рыбы, чтобы нарезать лосося, порционно икру." },
                { Locale.PortugueseBrazil, "Use a Fish Knife para cortar o salmão, porções de ovas." },
                { Locale.Japanese, "フィッシュナイフでサーモンと卵を切る。" },
                { Locale.ChineseSimplified, "用鱼刀切碎鲑鱼和鱼子酱。" },
                { Locale.Korean, "피시 나이프를 사용하여 연어를 자르고 알을 자릅니다." },
                { Locale.Turkish, "Somon balığını doğramak için Balık Bıçağı kullanın." },
            };

            public static Dictionary<Locale, string> ChonkyNigiri => new Dictionary<Locale, string>
            {
                { Locale.Default, "Combine Rice and Water in a Pot and Cook. Portion and roll, Portion and roll another, combine with Chopped Salmon." },
                { Locale.English, "Combine Rice and Water in a Pot and Cook. Portion and roll, Portion and roll another, combine with Chopped Salmon." },
                { Locale.BlankText, "" },
                { Locale.French, "Mélanger le riz et l'eau dans une casserole et faire cuire. Portionner et rouler, portionner et rouler à nouveau, combiner avec du saumon haché." },
                { Locale.German, "Reis und Wasser in einem Topf vermengen und kochen. Portionieren und rollen, weitere Portionieren und rollen, mit dem gehackten Lachs kombinieren." },
                { Locale.Spanish, "Combine Arroz y Agua en una Olla y Cocine. Porcionar y enrollar, Porcionar y enrollar otro, combinar con Salmón picado." },
                { Locale.Polish, "Połączyć ryż i wodę w garnku i ugotować. Porcjować i zwijać, porcjować i zwijać kolejne porcje, połączyć z posiekanym łososiem." },
                { Locale.Russian, "Соедините рис и воду в кастрюле и варите. Нарежьте порционно и сверните в рулет, нарежьте еще порционно и сверните в рулет, соедините с нарезанным лососем." },
                { Locale.PortugueseBrazil, "Combine arroz e água em uma panela e cozinhe. Porcione e enrole, porcione e enrole outro, combine com o salmão picado." },
                { Locale.Japanese, "米と水を鍋に入れて炊く。鮭のみじん切りと合わせる。" },
                { Locale.ChineseSimplified, "将米和水放入锅中煮。分量后卷起，再分量卷起，与切碎的三文鱼混合。" },
                { Locale.Korean, "냄비에 밥과 물을 넣고 조리합니다. 한 숟가락씩 떠서 굴리고, 또 한 숟가락씩 떠서 굴려 다진 연어와 섞어줍니다." },
                { Locale.Turkish, "Pirinç ve suyu bir tencerede karıştırın ve pişirin. Porsiyonlayın ve yuvarlayın, başka bir porsiyonlayın ve yuvarlayın, Doğranmış Somon ile birleştirin." },
            };

            public static Dictionary<Locale, string> Ginger => new Dictionary<Locale, string>
            {
                { Locale.Default, "Add Chopped Ginger to a Plate when requested." },
                { Locale.English, "Add Chopped Ginger to a Plate when requested." },
                { Locale.BlankText, "" },
                { Locale.French, "Ajouter du gingembre haché à l'assiette sur demande." },
                { Locale.German, "Auf Wunsch gehackten Ingwer auf den Teller geben." },
                { Locale.Spanish, "Añada jengibre picado al plato cuando lo solicite." },
                { Locale.Polish, "Na życzenie dodaj posiekany imbir do talerza." },
                { Locale.Russian, "По желанию добавьте нарезанный имбирь в тарелку." },
                { Locale.PortugueseBrazil, "Adicione gengibre picado em um prato quando solicitado." },
                { Locale.Japanese, "リクエストに応じて、刻んだ生姜を皿に加える。" },
                { Locale.ChineseSimplified, "如有要求，可在餐盘中加入切碎的生姜。" },
                { Locale.Korean, "요청이 있으면 다진 생강을 접시에 추가합니다." },
                { Locale.Turkish, "İstenildiğinde Tabağa Doğranmış Zencefil Ekleyin." },
            };
            
            public static Dictionary<Locale, string> Wasabi => new Dictionary<Locale, string>
            {
                {Locale.Default, "Add Chopped Wasabi to a Plate when requested."},
                {Locale.English, "Add Chopped Wasabi to a Plate when requested."},
                {Locale.BlankText, ""},
                {Locale.French, "Ajouter du Wasabi haché à l'assiette sur demande."},
                {Locale.German, "Auf Wunsch gehackten Wasabi auf den Teller geben."},
                {Locale.Spanish, "Añada Wasabi picado al plato cuando lo solicite."},
                {Locale.Polish, "Na życzenie do talerza można dodać posiekane wasabi."},
                {Locale.Russian, "По желанию добавьте в тарелку измельченный васаби."},
                {Locale.PortugueseBrazil, "Adicione Wasabi picado em um prato quando solicitado."},
                {Locale.Japanese, "リクエストに応じて、皿に刻みわさびを加える。"},
                {Locale.ChineseSimplified, "如有要求，可在餐盘中加入切碎的芥末。"},
                {Locale.Korean, "요청이 있으면 다진 와사비를 접시에 추가합니다."},
                {Locale.Turkish, "İstenildiğinde Tabağa Kıyılmış Wasabi ekleyin."},
            };
            
            public static Dictionary<Locale, string> RecipeMayonnaise => new Dictionary<Locale, string>
            {
                {Locale.Default, "Crack an egg, and combine with oil."},
                {Locale.English, "Crack an egg, and combine with oil."},
                {Locale.BlankText, ""},
                {Locale.French, "Casser un œuf et le mélanger à l'huile."},
                {Locale.German, "Ein Ei aufschlagen und mit dem Öl vermengen."},
                {Locale.Spanish, "Cascar un huevo y mezclarlo con el aceite."},
                {Locale.Polish, "Rozbij jajko i połącz z olejem."},
                {Locale.Russian, "Разбейте яйцо и соедините с маслом."},
                {Locale.PortugueseBrazil, "Quebre um ovo e misture com o óleo."},
                {Locale.Japanese, "卵を割りほぐし、油と混ぜ合わせる。"},
                {Locale.ChineseSimplified, "打入一个鸡蛋，与油混合。"},
                {Locale.Korean, "달걀을 깨서 기름과 섞습니다."},
                {Locale.Turkish, "Bir yumurta kırın ve yağ ile karıştırın."},
            };
        }

        public static class Appliances
        {
            public static List<(Locale, ApplianceInfo)> RollingMat => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Rolling Mat", Description = "Keep rolling em' out!" }),
                (Locale.English, new ApplianceInfo { Name = "Rolling Mat", Description = "Keep rolling em' out!" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Tapis roulant", Description = "Continuez à les faire rouler !" }),
                (Locale.German, new ApplianceInfo { Name = "Rollmatte", Description = "Rollt sie weiter aus!" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Estera rodante", Description = "¡Seguid sacándolos!" }),
                (Locale.Polish, new ApplianceInfo { Name = "Rolling Mat", Description = "Rozwijaj je dalej!" }),
                (Locale.Russian, new ApplianceInfo { Name = "Рулонный коврик", Description = "Продолжайте выпускать их!" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Esteira rolante", Description = "Continue lançando-os!" }),
                (Locale.Japanese, new ApplianceInfo { Name = "ローリングマット", Description = "続けてくれ！" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "滚动垫", Description = "继续推出！" }),
                (Locale.Korean, new ApplianceInfo { Name = "롤링 매트", Description = "계속 출시하세요!" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Yuvarlanan Paspas", Description = "Çıkarmaya devam edin!" }),
            };

            public static List<(Locale, ApplianceInfo)> NoriProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Nori", Description = "Provides Nori" }),
                (Locale.English, new ApplianceInfo { Name = "Nori", Description = "Provides Nori" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Nori", Description = "Fournit du nori" }),
                (Locale.German, new ApplianceInfo { Name = "Nori", Description = "Bietet Nori" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Nori", Description = "Proporciona Nori" }),
                (Locale.Polish, new ApplianceInfo { Name = "Nori", Description = "Zapewnia Nori" }),
                (Locale.Russian, new ApplianceInfo { Name = "Нори", Description = "Предоставляет нори" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Nori", Description = "Fornece Nori" }),
                (Locale.Japanese, new ApplianceInfo { Name = "ノリ", Description = "海苔の提供" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "紫菜", Description = "提供紫菜" }),
                (Locale.Korean, new ApplianceInfo { Name = "Nori", Description = "노리 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Nori", Description = "Nori Sağlar" }),
            };
            
            public static List<(Locale, ApplianceInfo)> GingerProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Ginger", Description = "Provides Ginger"}),
                (Locale.English, new ApplianceInfo{Name = "Ginger", Description = "Provides Ginger"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Gingembre", Description = "Apporte du gingembre"}),
                (Locale.German, new ApplianceInfo{Name = "Ingwer", Description = "Liefert Ingwer"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Jengibre", Description = "Proporciona jengibre"}),
                (Locale.Polish, new ApplianceInfo{Name = "Imbir", Description = "Zapewnia imbir"}),
                (Locale.Russian, new ApplianceInfo{Name = "Имбирь", Description = "Обеспечивает имбирь"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Gengibre", Description = "Fornece gengibre"}),
                (Locale.Japanese, new ApplianceInfo{Name = "ジンジャー", Description = "ジンジャー"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "姜", Description = "提供生姜"}),
                (Locale.Korean, new ApplianceInfo{Name = "생강", Description = "생강 제공"}),
                (Locale.Turkish, new ApplianceInfo{Name = "Zencefil", Description = "Zencefil Sağlar"}),
            };

            public static List<(Locale, ApplianceInfo)> SalmonProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Salmon", Description = "Provides Salmon" }),
                (Locale.English, new ApplianceInfo { Name = "Salmon", Description = "Provides Salmon" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Saumon", Description = "Fournit du saumon" }),
                (Locale.German, new ApplianceInfo { Name = "Lachs", Description = "Bietet Lachs" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Salmón", Description = "Proporciona Salmón" }),
                (Locale.Polish, new ApplianceInfo { Name = "Łosoś", Description = "Zapewnia łososia" }),
                (Locale.Russian, new ApplianceInfo { Name = "Лосось", Description = "Предоставляет лосося" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Salmão", Description = "Fornece salmão" }),
                (Locale.Japanese, new ApplianceInfo { Name = "サーモン", Description = "サーモンを提供" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "三文鱼", Description = "提供三文鱼" }),
                (Locale.Korean, new ApplianceInfo { Name = "연어", Description = "연어 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Somon", Description = "Somon Balığı Sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> FishKnifeProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Fish Knife", Description = "Specialty Fish Knife" }),
                (Locale.English, new ApplianceInfo { Name = "Fish Knife", Description = "Specialty Fish Knife" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Couteau à poisson", Description = "Spécialité couteau à poisson" }),
                (Locale.German, new ApplianceInfo { Name = "Fischmesser", Description = "Spezialität Fischmesser" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Cuchillo para pescado", Description = "Cuchillo especial para pescado" }),
                (Locale.Polish, new ApplianceInfo { Name = "Nóż do ryb", Description = "Specjalistyczny nóż do ryb" }),
                (Locale.Russian, new ApplianceInfo { Name = "Нож для рыбы", Description = "Специализированный нож для рыбы" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Faca para peixe", Description = "Faca especial para peixes" }),
                (Locale.Japanese, new ApplianceInfo { Name = "フィッシュナイフ", Description = "スペシャル・フィッシュ・ナイフ" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "鱼刀", Description = "特制鱼刀" }),
                (Locale.Korean, new ApplianceInfo { Name = "피쉬 나이프", Description = "스페셜티 생선 칼" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Balık Bıçağı", Description = "Özel Balık Bıçağı" }),
            };

            public static List<(Locale, ApplianceInfo)> RoeProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Roe", Description = "Provides Roe" }),
                (Locale.English, new ApplianceInfo { Name = "Roe", Description = "Provides Roe" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Roe", Description = "Fournit Roe" }),
                (Locale.German, new ApplianceInfo { Name = "Roe", Description = "Liefert Roe" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Roe", Description = "Proporciona Roe" }),
                (Locale.Polish, new ApplianceInfo { Name = "Roe", Description = "Zapewnia Roe" }),
                (Locale.Russian, new ApplianceInfo { Name = "Косуля", Description = "Обеспечивает Ро" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Roe", Description = "Fornece Roe" }),
                (Locale.Japanese, new ApplianceInfo { Name = "ロー", Description = "ローを提供" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "罗伊", Description = "提供 Roe" }),
                (Locale.Korean, new ApplianceInfo { Name = "Roe", Description = "알 제공" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Roe", Description = "Roe sağlar" }),
            };

            public static List<(Locale, ApplianceInfo)> RollingMachine => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Rolling Machine", Description = "Don't have time to roll sushi?", Tags = new List<string> { "Automatic", "2x <sprite name=\"roll\">" } }),
                (Locale.English, new ApplianceInfo { Name = "Rolling Machine", Description = "Don't have time to roll sushi?", Tags = new List<string> { "Automatic", "2x <sprite name=\"roll\">" } }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "", Tags = new List<string> { } }),
                (Locale.French, new ApplianceInfo { Name = "Machine à rouler", Description = "Vous n'avez pas le temps de rouler des sushis ?", Tags = new List<string> { "Automatique", "2x <sprite name=\"roll\">" } }),
                (Locale.German, new ApplianceInfo { Name = "Walzmaschine", Description = "Sie haben keine Zeit, Sushi zu rollen?", Tags = new List<string> { "Automatisch", "2x <sprite name=\"roll\">" } }),
                (Locale.Spanish, new ApplianceInfo { Name = "Máquina laminadora", Description = "¿No tienes tiempo para enrollar sushi?", Tags = new List<string> { "Automático", "2x <sprite name=\"roll\">" } }),
                (Locale.Polish, new ApplianceInfo { Name = "Walcarka", Description = "Nie masz czasu na rolowanie sushi?", Tags = new List<string> { "Automatyczny", "2x <sprite name=\"roll\">" } }),
                (Locale.Russian, new ApplianceInfo { Name = "Прокатный станок", Description = "У вас нет времени на приготовление суши?", Tags = new List<string> { "Автоматический", "2x <sprite name=\"roll\">" } }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Máquina de laminação", Description = "Não tem tempo para enrolar o sushi?", Tags = new List<string> { "Automático", "2x <sprite name=\"roll\">" } }),
                (Locale.Japanese, new ApplianceInfo { Name = "圧延機", Description = "寿司を巻く時間がない？", Tags = new List<string> { "自動", "2x <sprite name=\"roll\">" } }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "滚压机", Description = "没有时间卷寿司？", Tags = new List<string> { "自动", "2x <sprite name=\"roll\">" } }),
                (Locale.Korean, new ApplianceInfo { Name = "롤링 머신", Description = "초밥을 굴릴 시간이 없으신가요?", Tags = new List<string> { "자동", "2x <sprite name=\"roll\">" } }),
                (Locale.Turkish, new ApplianceInfo { Name = "Haddeleme Makinesi", Description = "Suşi sarmak için vaktiniz yok mu?", Tags = new List<string> { "Otomatik", "2x <sprite name=\"roll\">" } }),
            };

            public static List<(Locale, ApplianceInfo)> FishTank => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Fish Tank", Description = "P. Sherman 42 Wallaby Way" }),
                (Locale.English, new ApplianceInfo { Name = "Fish Tank", Description = "P. Sherman 42 Wallaby Way" }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Réservoir de poissons", Description = "P. Sherman 42 Wallaby Way" }),
                (Locale.German, new ApplianceInfo { Name = "Fischtank", Description = "P. Sherman 42 Wallaby Way" }),
                (Locale.Spanish, new ApplianceInfo { Name = "Pecera", Description = "P. Sherman 42 Wallaby Way" }),
                (Locale.Polish, new ApplianceInfo { Name = "Zbiornik na ryby", Description = "P. Sherman 42 Wallaby Way" }),
                (Locale.Russian, new ApplianceInfo { Name = "Рыбный аквариум", Description = "P. Sherman 42 Wallaby Way" }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Tanque de peixes", Description = "P. Sherman 42 Wallaby Way" }),
                (Locale.Japanese, new ApplianceInfo { Name = "フィッシュタンク", Description = "P. Sherman 42 Wallaby Way" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "鱼缸", Description = "P. Sherman 42 Wallaby Way" }),
                (Locale.Korean, new ApplianceInfo { Name = "어항", Description = "P. Sherman 42 Wallaby Way" }),
                (Locale.Turkish, new ApplianceInfo { Name = "Balık Tankı", Description = "P. Sherman 42 Wallaby Way" }),
            };

            public static List<(Locale, ApplianceInfo)> FishDisplayBoard => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo { Name = "Mounted Fish", Description = "Hooked on making your place look cooler." }),
                (Locale.English, new ApplianceInfo { Name = "Mounted Fish", Description = "Hooked on making your place look cooler." }),
                (Locale.BlankText, new ApplianceInfo { Name = "", Description = "" }),
                (Locale.French, new ApplianceInfo { Name = "Poisson monté", Description = "Accroché à l'idée de rendre votre lieu de vie plus cool." }),
                (Locale.German, new ApplianceInfo { Name = "Montierter Fisch", Description = "Sie sind darauf aus, Ihre Wohnung cooler aussehen zu lassen." }),
                (Locale.Spanish, new ApplianceInfo { Name = "Peces montados", Description = "Enganchado a hacer que tu casa parezca más guay." }),
                (Locale.Polish, new ApplianceInfo { Name = "Zamontowana ryba", Description = "Nastawiony na to, by Twoje mieszkanie wyglądało lepiej." }),
                (Locale.Russian, new ApplianceInfo { Name = "Монтированная рыба", Description = "Нацелены на то, чтобы ваше жилье выглядело круче." }),
                (Locale.PortugueseBrazil, new ApplianceInfo { Name = "Peixe montado", Description = "Viciado em deixar sua casa mais legal." }),
                (Locale.Japanese, new ApplianceInfo { Name = "マウント・フィッシュ", Description = "あなたの場所をよりクールに見せることに夢中。" }),
                (Locale.ChineseSimplified, new ApplianceInfo { Name = "骑鱼", Description = "让你的地方看起来更酷。" }),
                (Locale.Korean, new ApplianceInfo { Name = "기마 물고기", Description = "공간을 더 멋지게 꾸미는 데 푹 빠졌습니다." }),
                (Locale.Turkish, new ApplianceInfo { Name = "Atlı Balık", Description = "Evinizi daha havalı göstermeye odaklanın." }),
            };
            
            public static List<(Locale, ApplianceInfo)> NeonSign => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Neon Sign", Description = "Very helpful if customers don't know what to do"}),
                (Locale.English, new ApplianceInfo{Name = "Neon Sign", Description = "Very helpful if customers don't know what to do"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Panneau néon", Description = "Très utile si les clients ne savent pas quoi faire"}),
                (Locale.German, new ApplianceInfo{Name = "Neon-Schild", Description = "Sehr hilfreich, wenn Kunden nicht wissen, was sie tun sollen"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Cartel de neón", Description = "Muy útil si los clientes no saben qué hacer"}),
                (Locale.Polish, new ApplianceInfo{Name = "Neon Sign", Description = "Bardzo pomocne, jeśli klienci nie wiedzą, co robić"}),
                (Locale.Russian, new ApplianceInfo{Name = "Неоновый знак", Description = "Очень полезно, если клиенты не знают, что делать"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Sinal de néon", Description = "Muito útil se os clientes não souberem o que fazer"}),
                (Locale.Japanese, new ApplianceInfo{Name = "ネオンサイン", Description = "どうすればいいのかわからないときにとても役に立つ"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "霓虹标志", Description = "如果客户不知道该怎么做，非常有帮助"}),
                (Locale.Korean, new ApplianceInfo{Name = "네온 사인", Description = "고객이 무엇을 해야 할지 모르는 경우 매우 유용합니다."}),
                (Locale.Turkish, new ApplianceInfo{Name = "Neon Tabela", Description = "Müşteriler ne yapacaklarını bilmiyorsa çok yardımcı olur"}),
            };
            
            public static List<(Locale, ApplianceInfo)> HangingLamp => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Hanging Lamp", Description = "Hangs like a haiku, glows like a sunrise."}),
                (Locale.English, new ApplianceInfo{Name = "Hanging Lamp", Description = "Hangs like a haiku, glows like a sunrise."}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Lampe suspendue", Description = "Il est suspendu comme un haïku, il brille comme un lever de soleil."}),
                (Locale.German, new ApplianceInfo{Name = "Hängelampe", Description = "Hängt wie ein Haiku, leuchtet wie ein Sonnenaufgang."}),
                (Locale.Spanish, new ApplianceInfo{Name = "Lámpara colgante", Description = "Cuelga como un haiku, brilla como un amanecer."}),
                (Locale.Polish, new ApplianceInfo{Name = "Lampa wisząca", Description = "Wisi jak haiku, świeci jak wschód słońca."}),
                (Locale.Russian, new ApplianceInfo{Name = "Подвесная лампа", Description = "Висит, как хайку, сияет, как рассвет."}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Lâmpada suspensa", Description = "Pendurado como um haiku, brilha como um nascer do sol."}),
                (Locale.Japanese, new ApplianceInfo{Name = "吊りランプ", Description = "俳句のように吊るされ、朝日のように輝く。"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "吊灯", Description = "像俳句一样悬挂，像日出一样闪耀。"}),
                (Locale.Korean, new ApplianceInfo{Name = "행잉 램프", Description = "하이쿠처럼 매달려 있고 일출처럼 빛납니다."}),
                (Locale.Turkish, new ApplianceInfo{Name = "Asma Lamba", Description = "Bir haiku gibi asılı, bir gün doğumu gibi parlıyor."}),
            };
            
            public static List<(Locale, ApplianceInfo)> WasabiProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Wasabi Stem", Description = "Provides Wasabi Stem"}),
                (Locale.English, new ApplianceInfo{Name = "Wasabi Stem", Description = "Provides Wasabi Stem"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Tige de Wasabi", Description = "Fournit des tiges de Wasabi"}),
                (Locale.German, new ApplianceInfo{Name = "Wasabi-Stängel", Description = "Bietet Wasabi-Stängel"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Tallo Wasabi", Description = "Proporciona tallo de wasabi"}),
                (Locale.Polish, new ApplianceInfo{Name = "Łodyga wasabi", Description = "Zapewnia łodygę wasabi"}),
                (Locale.Russian, new ApplianceInfo{Name = "Стебель васаби", Description = "Предоставляет стебель васаби"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Caule de wasabi", Description = "Fornece haste de wasabi"}),
                (Locale.Japanese, new ApplianceInfo{Name = "茎わさび", Description = "茎わさびを提供"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "山葵茎", Description = "提供山葵梗"}),
                (Locale.Korean, new ApplianceInfo{Name = "와사비 줄기", Description = "와사비 줄기 제공"}),
                (Locale.Turkish, new ApplianceInfo{Name = "Wasabi Kök", Description = "Wasabi Sapını Sağlar"}),
            };
        }

        public static class Processes
        {
            public static List<(Locale, ProcessInfo)> Roll => new List<(Locale, ProcessInfo)>
            {
                (Locale.Default, new ProcessInfo { Name = "Roll", Icon = "<sprite name=\"roll\">", }),
                (Locale.English, new ProcessInfo { Name = "Roll", Icon = "<sprite name=\"roll\">", }),
                (Locale.BlankText, new ProcessInfo { Name = "", Icon = "", }),
                (Locale.French, new ProcessInfo { Name = "Rouleau", Icon = "<sprite name=\"roll\">", }),
                (Locale.German, new ProcessInfo { Name = "Rolle", Icon = "<sprite name=\"roll\">", }),
                (Locale.Spanish, new ProcessInfo { Name = "Rollo", Icon = "<sprite name=\"roll\">", }),
                (Locale.Polish, new ProcessInfo { Name = "Rolka", Icon = "<sprite name=\"roll\">", }),
                (Locale.Russian, new ProcessInfo { Name = "Рулон", Icon = "<sprite name=\"roll\">", }),
                (Locale.PortugueseBrazil, new ProcessInfo { Name = "Rolo", Icon = "<sprite name=\"roll\">", }),
                (Locale.Japanese, new ProcessInfo { Name = "ロール", Icon = "<sprite name=\"roll\">", }),
                (Locale.ChineseSimplified, new ProcessInfo { Name = "卷轴", Icon = "<sprite name=\"roll\">", }),
                (Locale.Korean, new ProcessInfo { Name = "롤", Icon = "<sprite name=\"roll\">", }),
                (Locale.Turkish, new ProcessInfo { Name = "Rulo", Icon = "<sprite name=\"roll\">", }),
            };
        }
    }
}