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
                (Locale.Default, new UnlockInfo { Name = "Salmon Roll", FlavourText = "Fish so fresh, even Poseidon would approve." }),
                (Locale.English, new UnlockInfo { Name = "Salmon Roll", FlavourText = "Fish so fresh, even Poseidon would approve." }),
                (Locale.BlankText, new UnlockInfo { Name = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Rouleau de saumon", FlavourText = "Un poisson si frais que même Poséidon l'approuverait." }),
                (Locale.German, new UnlockInfo { Name = "Lachsrolle", FlavourText = "So frischer Fisch, dass sogar Poseidon zustimmen würde." }),
                (Locale.Spanish, new UnlockInfo { Name = "Rollo de salmón", FlavourText = "Pescado tan fresco que hasta Poseidón lo aprobaría." }),
                (Locale.Polish, new UnlockInfo { Name = "Bułka z łososiem", FlavourText = "Ryby tak świeże, że nawet Posejdon by je zaakceptował." }),
                (Locale.Russian, new UnlockInfo { Name = "Ролл с лососем", FlavourText = "Рыба такой свежести, что ее одобрил бы даже Посейдон." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Enrolado de salmão", FlavourText = "Peixes tão frescos que até Poseidon aprovaria." }),
                (Locale.Japanese, new UnlockInfo { Name = "サーモン・ロール", FlavourText = "ポセイドンも認めるほど新鮮な魚。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "三文鱼卷", FlavourText = "鱼如此新鲜，就连波塞冬也会赞不绝口。" }),
                (Locale.Korean, new UnlockInfo { Name = "연어 롤", FlavourText = "포세이돈도 인정할 만큼 신선한 생선." }),
                (Locale.Turkish, new UnlockInfo { Name = "Somon Rulo", FlavourText = "Balık o kadar taze ki, Poseidon bile onaylardı." }),
            };

            public static List<(Locale, UnlockInfo)> Nigiri => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Nigiri", FlavourText = "Fish on top, rice below – it’s the sushi way to go!" }),
                (Locale.English, new UnlockInfo { Name = "Nigiri", FlavourText = "Fish on top, rice below – it’s the sushi way to go!" }),
                (Locale.BlankText, new UnlockInfo { Name = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Nigiri", FlavourText = "Le poisson sur le dessus, le riz en dessous - c'est la façon de faire des sushis !" }),
                (Locale.German, new UnlockInfo { Name = "Nigiri", FlavourText = "Oben der Fisch, unten der Reis - so geht Sushi!" }),
                (Locale.Spanish, new UnlockInfo { Name = "Nigiri", FlavourText = "Pescado arriba, arroz abajo: ¡así se hace el sushi!" }),
                (Locale.Polish, new UnlockInfo { Name = "Nigiri", FlavourText = "Ryba na wierzchu, ryż pod spodem - to sposób na sushi!" }),
                (Locale.Russian, new UnlockInfo { Name = "Нигири", FlavourText = "Рыба сверху, рис снизу - вот что такое суши!" }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Nigiri", FlavourText = "Peixe em cima, arroz embaixo - é assim que se faz sushi!" }),
                (Locale.Japanese, new UnlockInfo { Name = "握り", FlavourText = "魚が上、シャリが下-これが寿司の流儀だ！" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "饭团", FlavourText = "鱼在上面，米饭在下面，这就是寿司的做法！" }),
                (Locale.Korean, new UnlockInfo { Name = "니기리", FlavourText = "생선은 위에, 밥은 아래에 - 이것이 바로 초밥의 방식입니다!" }),
                (Locale.Turkish, new UnlockInfo { Name = "Nigiri", FlavourText = "Balık üstte, pirinç altta - suşi böyle yapılır!" }),
            };

            public static List<(Locale, UnlockInfo)> Onigiri => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Onigiri", FlavourText = "It’s hip to be triangular." }),
                (Locale.English, new UnlockInfo { Name = "Onigiri", FlavourText = "It’s hip to be triangular." }),
                (Locale.BlankText, new UnlockInfo { Name = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Onigiri", FlavourText = "Il est tendance d'être triangulaire." }),
                (Locale.German, new UnlockInfo { Name = "Onigiri", FlavourText = "Es ist hip, dreieckig zu sein." }),
                (Locale.Spanish, new UnlockInfo { Name = "Onigiri", FlavourText = "Está de moda ser triangular." }),
                (Locale.Polish, new UnlockInfo { Name = "Onigiri", FlavourText = "Modnie jest być trójkątnym." }),
                (Locale.Russian, new UnlockInfo { Name = "Онигири", FlavourText = "Бедро должно быть треугольным." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Onigiri", FlavourText = "É moderno ser triangular." }),
                (Locale.Japanese, new UnlockInfo { Name = "おにぎり", FlavourText = "三角形であることがヒップだ。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "饭团", FlavourText = "三角形很时髦。" }),
                (Locale.Korean, new UnlockInfo { Name = "오니기리", FlavourText = "삼각형이 최신 유행입니다." }),
                (Locale.Turkish, new UnlockInfo { Name = "Onigiri", FlavourText = "Üçgen olmak moda." }),
            };

            public static List<(Locale, UnlockInfo)> SoySauce => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Soy Sauce", FlavourText = "A salty splash of perfection." }),
                (Locale.English, new UnlockInfo { Name = "Soy Sauce", FlavourText = "A salty splash of perfection." }),
                (Locale.BlankText, new UnlockInfo { Name = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Sauce soja", FlavourText = "Une touche salée de perfection." }),
                (Locale.German, new UnlockInfo { Name = "Sojasoße", FlavourText = "Ein salziger Spritzer von Perfektion." }),
                (Locale.Spanish, new UnlockInfo { Name = "Salsa de soja", FlavourText = "Un salpicón salado de perfección." }),
                (Locale.Polish, new UnlockInfo { Name = "Sos sojowy", FlavourText = "Słony plusk doskonałości." }),
                (Locale.Russian, new UnlockInfo { Name = "Соевый соус", FlavourText = "Соленые брызги совершенства." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Molho de soja", FlavourText = "Um toque salgado de perfeição." }),
                (Locale.Japanese, new UnlockInfo { Name = "醤油", FlavourText = "完璧な塩味のスプラッシュ。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "酱油", FlavourText = "咸香四溢，堪称完美。" }),
                (Locale.Korean, new UnlockInfo { Name = "간장", FlavourText = "완벽함의 짭짤한 스플래시." }),
                (Locale.Turkish, new UnlockInfo { Name = "Soya Sosu", FlavourText = "Mükemmelliğin tuzlu bir sıçraması." }),
            };

            public static List<(Locale, UnlockInfo)> Sashimi => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Sashimi", FlavourText = "So fresh, it practically swims." }),
                (Locale.English, new UnlockInfo { Name = "Sashimi", FlavourText = "So fresh, it practically swims." }),
                (Locale.BlankText, new UnlockInfo { Name = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Sashimi", FlavourText = "Il est si frais qu'il nage pratiquement." }),
                (Locale.German, new UnlockInfo { Name = "Sashimi", FlavourText = "So frisch, dass es praktisch schwimmt." }),
                (Locale.Spanish, new UnlockInfo { Name = "Sashimi", FlavourText = "Tan fresco que prácticamente nada." }),
                (Locale.Polish, new UnlockInfo { Name = "Sashimi", FlavourText = "Tak świeży, że praktycznie pływa." }),
                (Locale.Russian, new UnlockInfo { Name = "Сашими", FlavourText = "Он настолько свеж, что практически плавает." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Sashimi", FlavourText = "Tão fresco que praticamente nada." }),
                (Locale.Japanese, new UnlockInfo { Name = "刺身", FlavourText = "とても新鮮で、まるで泳いでいるようだ。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "刺身", FlavourText = "如此新鲜，几乎可以游泳。" }),
                (Locale.Korean, new UnlockInfo { Name = "사시미", FlavourText = "너무 신선해서 거의 헤엄칠 정도입니다." }),
                (Locale.Turkish, new UnlockInfo { Name = "Sashimi", FlavourText = "O kadar taze ki, neredeyse yüzüyor." }),
            };

            public static List<(Locale, UnlockInfo)> Gunkan => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Gunkan", FlavourText = "The unsinkable flavor ship." }),
                (Locale.English, new UnlockInfo { Name = "Gunkan", FlavourText = "The unsinkable flavor ship." }),
                (Locale.BlankText, new UnlockInfo { Name = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Gunkan", FlavourText = "Le navire insubmersible." }),
                (Locale.German, new UnlockInfo { Name = "Gunkan", FlavourText = "Das unsinkbare Geschmacksschiff." }),
                (Locale.Spanish, new UnlockInfo { Name = "Gunkan", FlavourText = "El insumergible barco del sabor." }),
                (Locale.Polish, new UnlockInfo { Name = "Gunkan", FlavourText = "Niezatapialny statek smakowy." }),
                (Locale.Russian, new UnlockInfo { Name = "Gunkan", FlavourText = "Непотопляемый корабль с ароматом." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Gunkan", FlavourText = "O navio de sabor inafundável." }),
                (Locale.Japanese, new UnlockInfo { Name = "軍艦", FlavourText = "不沈艦。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "文化馆", FlavourText = "永不沉没的风味船" }),
                (Locale.Korean, new UnlockInfo { Name = "군칸", FlavourText = "가라앉지 않는 맛의 배." }),
                (Locale.Turkish, new UnlockInfo { Name = "Gunkan", FlavourText = "Batmayan lezzet gemisi." }),
            };

            public static List<(Locale, UnlockInfo)> FreshNori => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Fresh Nori", FlavourText = "The leaf that holds it all together." }),
                (Locale.English, new UnlockInfo { Name = "Fresh Nori", FlavourText = "The leaf that holds it all together." }),
                (Locale.BlankText, new UnlockInfo { Name = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Nori frais", FlavourText = "La feuille qui tient le tout ensemble." }),
                (Locale.German, new UnlockInfo { Name = "Frischer Nori", FlavourText = "Das Blatt, das alles zusammenhält." }),
                (Locale.Spanish, new UnlockInfo { Name = "Nori fresco", FlavourText = "La hoja que lo mantiene todo unido." }),
                (Locale.Polish, new UnlockInfo { Name = "Świeże Nori", FlavourText = "Liść, który trzyma wszystko razem." }),
                (Locale.Russian, new UnlockInfo { Name = "Свежие нори", FlavourText = "Лист, который держит все вместе." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Nori fresco", FlavourText = "A folha que mantém tudo unido." }),
                (Locale.Japanese, new UnlockInfo { Name = "生海苔", FlavourText = "すべてをまとめる葉。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "新鲜紫菜", FlavourText = "支撑这一切的树叶" }),
                (Locale.Korean, new UnlockInfo { Name = "신선한 김", FlavourText = "이 모든 것을 하나로 묶어주는 잎사귀." }),
                (Locale.Turkish, new UnlockInfo { Name = "Taze Nori", FlavourText = "Her şeyi bir arada tutan yaprak." }),
            };

            public static List<(Locale, UnlockInfo)> FreshRoe => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo { Name = "Fresh Roe", FlavourText = "Little pops of ocean joy." }),
                (Locale.English, new UnlockInfo { Name = "Fresh Roe", FlavourText = "Little pops of ocean joy." }),
                (Locale.BlankText, new UnlockInfo { Name = "", FlavourText = "" }),
                (Locale.French, new UnlockInfo { Name = "Chevreuil frais", FlavourText = "Des petites touches de joie océanique." }),
                (Locale.German, new UnlockInfo { Name = "Frischer Rogen", FlavourText = "Kleine Freudensprünge aus dem Meer." }),
                (Locale.Spanish, new UnlockInfo { Name = "Hueva fresca", FlavourText = "Pequeños estallidos de alegría oceánica." }),
                (Locale.Polish, new UnlockInfo { Name = "Świeża ikra", FlavourText = "Małe kropelki oceanicznej radości." }),
                (Locale.Russian, new UnlockInfo { Name = "Свежая икра", FlavourText = "Маленькие всплески океанской радости." }),
                (Locale.PortugueseBrazil, new UnlockInfo { Name = "Ovas frescas", FlavourText = "Pequenos toques de alegria do oceano." }),
                (Locale.Japanese, new UnlockInfo { Name = "新鮮な卵", FlavourText = "小さな海の喜びのポップ。" }),
                (Locale.ChineseSimplified, new UnlockInfo { Name = "新鲜鱼子酱", FlavourText = "小小的海洋欢乐" }),
                (Locale.Korean, new UnlockInfo { Name = "신선한 알", FlavourText = "바다의 작은 기쁨을 만끽하세요." }),
                (Locale.Turkish, new UnlockInfo { Name = "Taze Karaca", FlavourText = "Okyanus neşesinin küçük patlamaları." }),
            };
            
            public static List<(Locale, UnlockInfo)> ChonkyNigiri => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo{Name = "Chonky Nigiri", FlavourText = "Bigger bites, bolder delights."}),
                (Locale.English, new UnlockInfo{Name = "Chonky Nigiri", FlavourText = "Bigger bites, bolder delights."}),
                (Locale.BlankText, new UnlockInfo{Name = "", FlavourText = ""}),
                (Locale.French, new UnlockInfo{Name = "Chonky Nigiri", FlavourText = "De plus grandes bouchées, des délices plus audacieux."}),
                (Locale.German, new UnlockInfo{Name = "Chonky Nigiri", FlavourText = "Größere Bissen, kühneres Vergnügen."}),
                (Locale.Spanish, new UnlockInfo{Name = "Chonky Nigiri", FlavourText = "Bocados más grandes, delicias más audaces."}),
                (Locale.Polish, new UnlockInfo{Name = "Chonky Nigiri", FlavourText = "Większe kęsy, odważniejsze rozkosze."}),
                (Locale.Russian, new UnlockInfo{Name = "Чонки нигири", FlavourText = "Больше укусов, больше удовольствия."}),
                (Locale.PortugueseBrazil, new UnlockInfo{Name = "Chonky Nigiri", FlavourText = "Mordidas maiores, delícias mais ousadas."}),
                (Locale.Japanese, new UnlockInfo{Name = "ちょんまげ握り", FlavourText = "より大きな一口、より大胆な喜び。"}),
                (Locale.ChineseSimplified, new UnlockInfo{Name = "Chonky Nigiri", FlavourText = "更大的口感，更大胆的享受。"}),
                (Locale.Korean, new UnlockInfo{Name = "촌키 니기리", FlavourText = "더 큰 한입, 더 대담한 즐거움."}),
                (Locale.Turkish, new UnlockInfo{Name = "Chonky Nigiri", FlavourText = "Daha büyük ısırıklar, daha cesur lezzetler."}),
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
                {Locale.Default, "Combine Rice and Water in a Pot and Cook. Portion and roll, Portion and roll another, combine with Chopped Salmon."},
                {Locale.English, "Combine Rice and Water in a Pot and Cook. Portion and roll, Portion and roll another, combine with Chopped Salmon."},
                {Locale.BlankText, ""},
                {Locale.French, "Mélanger le riz et l'eau dans une casserole et faire cuire. Portionner et rouler, portionner et rouler à nouveau, combiner avec du saumon haché."},
                {Locale.German, "Reis und Wasser in einem Topf vermengen und kochen. Portionieren und rollen, weitere Portionieren und rollen, mit dem gehackten Lachs kombinieren."},
                {Locale.Spanish, "Combine Arroz y Agua en una Olla y Cocine. Porcionar y enrollar, Porcionar y enrollar otro, combinar con Salmón picado."},
                {Locale.Polish, "Połączyć ryż i wodę w garnku i ugotować. Porcjować i zwijać, porcjować i zwijać kolejne porcje, połączyć z posiekanym łososiem."},
                {Locale.Russian, "Соедините рис и воду в кастрюле и варите. Нарежьте порционно и сверните в рулет, нарежьте еще порционно и сверните в рулет, соедините с нарезанным лососем."},
                {Locale.PortugueseBrazil, "Combine arroz e água em uma panela e cozinhe. Porcione e enrole, porcione e enrole outro, combine com o salmão picado."},
                {Locale.Japanese, "米と水を鍋に入れて炊く。鮭のみじん切りと合わせる。"},
                {Locale.ChineseSimplified, "将米和水放入锅中煮。分量后卷起，再分量卷起，与切碎的三文鱼混合。"},
                {Locale.Korean, "냄비에 밥과 물을 넣고 조리합니다. 한 숟가락씩 떠서 굴리고, 또 한 숟가락씩 떠서 굴려 다진 연어와 섞어줍니다."},
                {Locale.Turkish, "Pirinç ve suyu bir tencerede karıştırın ve pişirin. Porsiyonlayın ve yuvarlayın, başka bir porsiyonlayın ve yuvarlayın, Doğranmış Somon ile birleştirin."},
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
                (Locale.Default, new ApplianceInfo{Name = "Mounted Fish", Description = "Hooked on making your place look cooler."}),
                (Locale.English, new ApplianceInfo{Name = "Mounted Fish", Description = "Hooked on making your place look cooler."}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Poisson monté", Description = "Accroché à l'idée de rendre votre lieu de vie plus cool."}),
                (Locale.German, new ApplianceInfo{Name = "Montierter Fisch", Description = "Sie sind darauf aus, Ihre Wohnung cooler aussehen zu lassen."}),
                (Locale.Spanish, new ApplianceInfo{Name = "Peces montados", Description = "Enganchado a hacer que tu casa parezca más guay."}),
                (Locale.Polish, new ApplianceInfo{Name = "Zamontowana ryba", Description = "Nastawiony na to, by Twoje mieszkanie wyglądało lepiej."}),
                (Locale.Russian, new ApplianceInfo{Name = "Монтированная рыба", Description = "Нацелены на то, чтобы ваше жилье выглядело круче."}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Peixe montado", Description = "Viciado em deixar sua casa mais legal."}),
                (Locale.Japanese, new ApplianceInfo{Name = "マウント・フィッシュ", Description = "あなたの場所をよりクールに見せることに夢中。"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "骑鱼", Description = "让你的地方看起来更酷。"}),
                (Locale.Korean, new ApplianceInfo{Name = "기마 물고기", Description = "공간을 더 멋지게 꾸미는 데 푹 빠졌습니다."}),
                (Locale.Turkish, new ApplianceInfo{Name = "Atlı Balık", Description = "Evinizi daha havalı göstermeye odaklanın."}),
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