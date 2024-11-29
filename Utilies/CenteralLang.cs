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
                (Locale.Default, new UnlockInfo{Name = "Salmon Roll", FlavourText = "Fish so fresh, even Poseidon would approve."}),
                (Locale.English, new UnlockInfo{Name = "Salmon Roll", FlavourText = "Fish so fresh, even Poseidon would approve."}),
                (Locale.BlankText, new UnlockInfo{Name = "", FlavourText = ""}),
                (Locale.French, new UnlockInfo{Name = "Rouleau de saumon", FlavourText = "Un poisson si frais que même Poséidon l'approuverait."}),
                (Locale.German, new UnlockInfo{Name = "Lachsrolle", FlavourText = "So frischer Fisch, dass sogar Poseidon zustimmen würde."}),
                (Locale.Spanish, new UnlockInfo{Name = "Rollo de salmón", FlavourText = "Pescado tan fresco que hasta Poseidón lo aprobaría."}),
                (Locale.Polish, new UnlockInfo{Name = "Bułka z łososiem", FlavourText = "Ryby tak świeże, że nawet Posejdon by je zaakceptował."}),
                (Locale.Russian, new UnlockInfo{Name = "Ролл с лососем", FlavourText = "Рыба такой свежести, что ее одобрил бы даже Посейдон."}),
                (Locale.PortugueseBrazil, new UnlockInfo{Name = "Enrolado de salmão", FlavourText = "Peixes tão frescos que até Poseidon aprovaria."}),
                (Locale.Japanese, new UnlockInfo{Name = "サーモン・ロール", FlavourText = "ポセイドンも認めるほど新鮮な魚。"}),
                (Locale.ChineseSimplified, new UnlockInfo{Name = "三文鱼卷", FlavourText = "鱼如此新鲜，就连波塞冬也会赞不绝口。"}),
                (Locale.Korean, new UnlockInfo{Name = "연어 롤", FlavourText = "포세이돈도 인정할 만큼 신선한 생선."}),
                (Locale.Turkish, new UnlockInfo{Name = "Somon Rulo", FlavourText = "Balık o kadar taze ki, Poseidon bile onaylardı."}),
            };

            public static List<(Locale, UnlockInfo)> Nigiri => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo{Name = "Nigiri", FlavourText = "Fish on top, rice below – it’s the sushi way to go!"}),
                (Locale.English, new UnlockInfo{Name = "Nigiri", FlavourText = "Fish on top, rice below – it’s the sushi way to go!"}),
                (Locale.BlankText, new UnlockInfo{Name = "", FlavourText = ""}),
                (Locale.French, new UnlockInfo{Name = "Nigiri", FlavourText = "Le poisson sur le dessus, le riz en dessous - c'est la façon de faire des sushis !"}),
                (Locale.German, new UnlockInfo{Name = "Nigiri", FlavourText = "Oben der Fisch, unten der Reis - so geht Sushi!"}),
                (Locale.Spanish, new UnlockInfo{Name = "Nigiri", FlavourText = "Pescado arriba, arroz abajo: ¡así se hace el sushi!"}),
                (Locale.Polish, new UnlockInfo{Name = "Nigiri", FlavourText = "Ryba na wierzchu, ryż pod spodem - to sposób na sushi!"}),
                (Locale.Russian, new UnlockInfo{Name = "Нигири", FlavourText = "Рыба сверху, рис снизу - вот что такое суши!"}),
                (Locale.PortugueseBrazil, new UnlockInfo{Name = "Nigiri", FlavourText = "Peixe em cima, arroz embaixo - é assim que se faz sushi!"}),
                (Locale.Japanese, new UnlockInfo{Name = "握り", FlavourText = "魚が上、シャリが下-これが寿司の流儀だ！"}),
                (Locale.ChineseSimplified, new UnlockInfo{Name = "饭团", FlavourText = "鱼在上面，米饭在下面，这就是寿司的做法！"}),
                (Locale.Korean, new UnlockInfo{Name = "니기리", FlavourText = "생선은 위에, 밥은 아래에 - 이것이 바로 초밥의 방식입니다!"}),
                (Locale.Turkish, new UnlockInfo{Name = "Nigiri", FlavourText = "Balık üstte, pirinç altta - suşi böyle yapılır!"}),
            };

            public static List<(Locale, UnlockInfo)> Onigiri => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo{Name = "Onigiri", FlavourText = "It’s hip to be triangular."}),
                (Locale.English, new UnlockInfo{Name = "Onigiri", FlavourText = "It’s hip to be triangular."}),
                (Locale.BlankText, new UnlockInfo{Name = "", FlavourText = ""}),
                (Locale.French, new UnlockInfo{Name = "Onigiri", FlavourText = "Il est tendance d'être triangulaire."}),
                (Locale.German, new UnlockInfo{Name = "Onigiri", FlavourText = "Es ist hip, dreieckig zu sein."}),
                (Locale.Spanish, new UnlockInfo{Name = "Onigiri", FlavourText = "Está de moda ser triangular."}),
                (Locale.Polish, new UnlockInfo{Name = "Onigiri", FlavourText = "Modnie jest być trójkątnym."}),
                (Locale.Russian, new UnlockInfo{Name = "Онигири", FlavourText = "Бедро должно быть треугольным."}),
                (Locale.PortugueseBrazil, new UnlockInfo{Name = "Onigiri", FlavourText = "É moderno ser triangular."}),
                (Locale.Japanese, new UnlockInfo{Name = "おにぎり", FlavourText = "三角形であることがヒップだ。"}),
                (Locale.ChineseSimplified, new UnlockInfo{Name = "饭团", FlavourText = "三角形很时髦。"}),
                (Locale.Korean, new UnlockInfo{Name = "오니기리", FlavourText = "삼각형이 최신 유행입니다."}),
                (Locale.Turkish, new UnlockInfo{Name = "Onigiri", FlavourText = "Üçgen olmak moda."}),
            };
            
            public static List<(Locale, UnlockInfo)> SoySauce => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo{Name = "Soy Sauce", FlavourText = "A salty splash of perfection."}),
                (Locale.English, new UnlockInfo{Name = "Soy Sauce", FlavourText = "A salty splash of perfection."}),
                (Locale.BlankText, new UnlockInfo{Name = "", FlavourText = ""}),
                (Locale.French, new UnlockInfo{Name = "Sauce soja", FlavourText = "Une touche salée de perfection."}),
                (Locale.German, new UnlockInfo{Name = "Sojasoße", FlavourText = "Ein salziger Spritzer von Perfektion."}),
                (Locale.Spanish, new UnlockInfo{Name = "Salsa de soja", FlavourText = "Un salpicón salado de perfección."}),
                (Locale.Polish, new UnlockInfo{Name = "Sos sojowy", FlavourText = "Słony plusk doskonałości."}),
                (Locale.Russian, new UnlockInfo{Name = "Соевый соус", FlavourText = "Соленые брызги совершенства."}),
                (Locale.PortugueseBrazil, new UnlockInfo{Name = "Molho de soja", FlavourText = "Um toque salgado de perfeição."}),
                (Locale.Japanese, new UnlockInfo{Name = "醤油", FlavourText = "完璧な塩味のスプラッシュ。"}),
                (Locale.ChineseSimplified, new UnlockInfo{Name = "酱油", FlavourText = "咸香四溢，堪称完美。"}),
                (Locale.Korean, new UnlockInfo{Name = "간장", FlavourText = "완벽함의 짭짤한 스플래시."}),
                (Locale.Turkish, new UnlockInfo{Name = "Soya Sosu", FlavourText = "Mükemmelliğin tuzlu bir sıçraması."}),
            };
            
            public static List<(Locale, UnlockInfo)> Sashimi => new List<(Locale, UnlockInfo)>
            {
                (Locale.Default, new UnlockInfo{Name = "Sashimi", FlavourText = "So fresh, it practically swims."}),
                (Locale.English, new UnlockInfo{Name = "Sashimi", FlavourText = "So fresh, it practically swims."}),
                (Locale.BlankText, new UnlockInfo{Name = "", FlavourText = ""}),
                (Locale.French, new UnlockInfo{Name = "Sashimi", FlavourText = "Il est si frais qu'il nage pratiquement."}),
                (Locale.German, new UnlockInfo{Name = "Sashimi", FlavourText = "So frisch, dass es praktisch schwimmt."}),
                (Locale.Spanish, new UnlockInfo{Name = "Sashimi", FlavourText = "Tan fresco que prácticamente nada."}),
                (Locale.Polish, new UnlockInfo{Name = "Sashimi", FlavourText = "Tak świeży, że praktycznie pływa."}),
                (Locale.Russian, new UnlockInfo{Name = "Сашими", FlavourText = "Он настолько свеж, что практически плавает."}),
                (Locale.PortugueseBrazil, new UnlockInfo{Name = "Sashimi", FlavourText = "Tão fresco que praticamente nada."}),
                (Locale.Japanese, new UnlockInfo{Name = "刺身", FlavourText = "とても新鮮で、まるで泳いでいるようだ。"}),
                (Locale.ChineseSimplified, new UnlockInfo{Name = "刺身", FlavourText = "如此新鲜，几乎可以游泳。"}),
                (Locale.Korean, new UnlockInfo{Name = "사시미", FlavourText = "너무 신선해서 거의 헤엄칠 정도입니다."}),
                (Locale.Turkish, new UnlockInfo{Name = "Sashimi", FlavourText = "O kadar taze ki, neredeyse yüzüyor."}),
            };
        }

        public static class Recipes
        {
            public static Dictionary<Locale, string> SalmonRoll => new Dictionary<Locale, string>
            {
                {Locale.Default, "Combine Rice and Water and Cook. Portion onto a Nori sheet, and add chopped Salmon and Avocado, Roll, Chop, and Portion."},
                {Locale.English, "Combine Rice and Water and Cook. Portion onto a Nori sheet, and add chopped Salmon and Avocado, Roll, Chop, and Portion."},
                {Locale.BlankText, ""},
                {Locale.French, "Mélanger le riz et l'eau et faire cuire. Répartir sur une feuille Nori, ajouter du saumon et de l'avocat hachés, rouler, hacher et répartir."},
                {Locale.German, "Reis und Wasser vermengen und kochen. Auf ein Nori-Blatt portionieren und gehackten Lachs und Avocado hinzufügen, rollen, hacken und portionieren."},
                {Locale.Spanish, "Combine el Arroz y el Agua y Cocine. Porcionar en una hoja de Nori, y añadir Salmón y Aguacate picados, Enrollar, Picar y Porcionar."},
                {Locale.Polish, "Połączyć ryż z wodą i ugotować. Przełożyć na arkusz nori, dodać pokrojonego łososia i awokado, zrolować, posiekać i przełożyć."},
                {Locale.Russian, "Соедините рис с водой и приготовьте. Выложите порционно на лист нори, добавьте нарезанный лосось и авокадо, сверните, нарежьте и выложите порционно."},
                {Locale.PortugueseBrazil, "Combine arroz e água e cozinhe. Distribua em uma folha de Nori e adicione salmão e abacate picados, enrole, corte e distribua."},
                {Locale.Japanese, "米と水を混ぜて炊く。海苔に盛り、刻んだサーモンとアボカドを加え、巻いて刻んで盛り付ける。"},
                {Locale.ChineseSimplified, "将米和水混合煮熟。分装在紫菜片上，加入切碎的三文鱼和牛油果，卷起，切碎，分装。"},
                {Locale.Korean, "밥과 물을 섞어 조리합니다. 김 시트에 나누어 담고 다진 연어와 아보카도를 넣고 굴려서 잘게 자른 후 나누어 담습니다."},
                {Locale.Turkish, "Pirinç ve Suyu Karıştırın ve Pişirin. Nori yaprağına paylaştırın ve doğranmış Somon ve Avokado ekleyin, Yuvarlayın, Doğrayın ve Paylaştırın."},
            };
        
            public static Dictionary<Locale, string> Nigiri => new Dictionary<Locale, string>
            {
                {Locale.Default, "Combine Rice and Water and Cook. Portion from pot, and combine with Chopped Salmon"},
                {Locale.English, "Combine Rice and Water and Cook. Portion from pot, and combine with Chopped Salmon"},
                {Locale.BlankText, ""},
                {Locale.French, "Mélanger le riz et l'eau et faire cuire. Retirer les portions de la casserole et les combiner avec le saumon haché."},
                {Locale.German, "Reis und Wasser vermengen und kochen. Portion aus dem Topf nehmen und mit dem gehackten Lachs kombinieren"},
                {Locale.Spanish, "Combine el Arroz y el Agua y Cocine. Sacar de la olla y mezclar con el salmón picado."},
                {Locale.Polish, "Połączyć ryż z wodą i ugotować. Wyjąć z garnka i połączyć z posiekanym łososiem"},
                {Locale.Russian, "Соедините рис с водой и варите. Выложите из кастрюли и соедините с нарезанным лососем."},
                {Locale.PortugueseBrazil, "Combine o arroz e a água e cozinhe. Retire uma porção da panela e combine com o salmão picado"},
                {Locale.Japanese, "米と水を混ぜて炊く。鍋から取り出し、刻んだサーモンと合わせる。"},
                {Locale.ChineseSimplified, "将米和水混合煮熟。从锅中取出，与切碎的三文鱼混合"},
                {Locale.Korean, "밥과 물을 섞어 조리합니다. 냄비에서 일부를 덜어낸 후 다진 연어와 섞어줍니다."},
                {Locale.Turkish, "Pirinç ve Suyu Karıştırın ve Pişirin. Tencereden alın ve doğranmış somon balığı ile karıştırın"},
            };
            
            public static Dictionary<Locale, string> Onigiri => new Dictionary<Locale, string>
            {
                {Locale.Default, "Combine Rice and Water and Cook. Portion from pot, and combine with Cooked Seaweed"},
                {Locale.English, "Combine Rice and Water and Cook. Portion from pot, and combine with Cooked Seaweed"},
                {Locale.BlankText, ""},
                {Locale.French, "Mélanger le riz et l'eau et faire cuire. Retirer les portions de la casserole et les combiner avec les algues cuites."},
                {Locale.German, "Reis und Wasser vermengen und kochen. Aus dem Topf nehmen und mit gekochtem Seetang kombinieren."},
                {Locale.Spanish, "Mezclar el arroz y el agua y cocer. Porción de la olla, y se combinan con algas cocidas"},
                {Locale.Polish, "Połączyć ryż z wodą i ugotować. Wyjąć z garnka i połączyć z ugotowanymi wodorostami."},
                {Locale.Russian, "Соедините рис с водой и варите. Выложите из кастрюли и соедините с приготовленными морскими водорослями."},
                {Locale.PortugueseBrazil, "Combine o arroz e a água e cozinhe. Retire uma porção da panela e combine com as algas cozidas"},
                {Locale.Japanese, "米と水を混ぜて炊く。鍋から取り出し、茹でたわかめと合わせる。"},
                {Locale.ChineseSimplified, "将米和水混合煮熟。从锅中取出，与煮熟的海藻混合"},
                {Locale.Korean, "밥과 물을 섞어 조리합니다. 냄비에서 일부를 덜어 익힌 해초와 섞어줍니다."},
                {Locale.Turkish, "Pirinç ve Suyu Karıştırın ve Pişirin. Tencereden alın ve Pişmiş Deniz Yosunu ile birleştirin"},
            };
            
            public static Dictionary<Locale, string> SoySauce => new Dictionary<Locale, string>
            {
                {Locale.Default, "Customers may order Soy Sauce while eating."},
                {Locale.English, "Customers may order Soy Sauce while eating."},
                {Locale.BlankText, ""},
                {Locale.French, "Les clients peuvent commander de la sauce soja pendant qu'ils mangent."},
                {Locale.German, "Kunden können während des Essens Sojasoße bestellen."},
                {Locale.Spanish, "Los clientes pueden pedir salsa de soja mientras comen."},
                {Locale.Polish, "Klienci mogą zamówić sos sojowy podczas jedzenia."},
                {Locale.Russian, "Клиенты могут заказать соевый соус во время еды."},
                {Locale.PortugueseBrazil, "Os clientes podem pedir molho de soja enquanto comem."},
                {Locale.Japanese, "食べながら醤油を注文することもできる。"},
                {Locale.ChineseSimplified, "顾客可在用餐时点酱油。"},
                {Locale.Korean, "고객은 식사 중에 간장을 주문할 수 있습니다."},
                {Locale.Turkish, "Müşteriler yemek yerken Soya Sosu sipariş edebilirler."},
            };
            
            public static Dictionary<Locale, string> Sashimi => new Dictionary<Locale, string>
            {
                {Locale.Default, "Double Chop Salmon, Plate and Serve"},
                {Locale.English, "Double Chop Salmon, Plate and Serve"},
                {Locale.BlankText, ""},
                {Locale.French, "Couper le saumon en deux, le mettre en assiette et le servir"},
                {Locale.German, "Lachs doppelt hacken, plattieren und servieren"},
                {Locale.Spanish, "Cortar el salmón en dos trozos, emplatar y servir"},
                {Locale.Polish, "Podwójnie posiekaj łososia, nałóż na talerz i podawaj"},
                {Locale.Russian, "Нарежьте лосося на две части, разложите по тарелкам и подавайте."},
                {Locale.PortugueseBrazil, "Corte o salmão duas vezes, coloque no prato e sirva"},
                {Locale.Japanese, "サーモンをダブルチョップし、皿に盛り付ける。"},
                {Locale.ChineseSimplified, "将三文鱼切成两半，装盘上桌"},
                {Locale.Korean, "연어를 두 번 자르고 접시에 담아 제공"},
                {Locale.Turkish, "Somonu İkili Doğrayın, Tabaklayın ve Servis Edin"},
            };
        }

        public static class Appliances
        {
            public static List<(Locale, ApplianceInfo)> RollingMat => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Rolling Mat", Description = "Keep rolling em' out!"}),
                (Locale.English, new ApplianceInfo{Name = "Rolling Mat", Description = "Keep rolling em' out!"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Tapis roulant", Description = "Continuez à les faire rouler !"}),
                (Locale.German, new ApplianceInfo{Name = "Rollmatte", Description = "Rollt sie weiter aus!"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Estera rodante", Description = "¡Seguid sacándolos!"}),
                (Locale.Polish, new ApplianceInfo{Name = "Rolling Mat", Description = "Rozwijaj je dalej!"}),
                (Locale.Russian, new ApplianceInfo{Name = "Рулонный коврик", Description = "Продолжайте выпускать их!"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Esteira rolante", Description = "Continue lançando-os!"}),
                (Locale.Japanese, new ApplianceInfo{Name = "ローリングマット", Description = "続けてくれ！"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "滚动垫", Description = "继续推出！"}),
                (Locale.Korean, new ApplianceInfo{Name = "롤링 매트", Description = "계속 출시하세요!"}),
                (Locale.Turkish, new ApplianceInfo{Name = "Yuvarlanan Paspas", Description = "Çıkarmaya devam edin!"}),
            };
            
            public static List<(Locale, ApplianceInfo)> NoriProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Nori", Description = "Provides Nori"}),
                (Locale.English, new ApplianceInfo{Name = "Nori", Description = "Provides Nori"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Nori", Description = "Fournit du nori"}),
                (Locale.German, new ApplianceInfo{Name = "Nori", Description = "Bietet Nori"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Nori", Description = "Proporciona Nori"}),
                (Locale.Polish, new ApplianceInfo{Name = "Nori", Description = "Zapewnia Nori"}),
                (Locale.Russian, new ApplianceInfo{Name = "Нори", Description = "Предоставляет нори"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Nori", Description = "Fornece Nori"}),
                (Locale.Japanese, new ApplianceInfo{Name = "ノリ", Description = "海苔の提供"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "紫菜", Description = "提供紫菜"}),
                (Locale.Korean, new ApplianceInfo{Name = "Nori", Description = "노리 제공"}),
                (Locale.Turkish, new ApplianceInfo{Name = "Nori", Description = "Nori Sağlar"}),
            };
            
            public static List<(Locale, ApplianceInfo)> SalmonProvider => new List<(Locale, ApplianceInfo)>
            {
                (Locale.Default, new ApplianceInfo{Name = "Salmon", Description = "Provides Salmon"}),
                (Locale.English, new ApplianceInfo{Name = "Salmon", Description = "Provides Salmon"}),
                (Locale.BlankText, new ApplianceInfo{Name = "", Description = ""}),
                (Locale.French, new ApplianceInfo{Name = "Saumon", Description = "Fournit du saumon"}),
                (Locale.German, new ApplianceInfo{Name = "Lachs", Description = "Bietet Lachs"}),
                (Locale.Spanish, new ApplianceInfo{Name = "Salmón", Description = "Proporciona Salmón"}),
                (Locale.Polish, new ApplianceInfo{Name = "Łosoś", Description = "Zapewnia łososia"}),
                (Locale.Russian, new ApplianceInfo{Name = "Лосось", Description = "Предоставляет лосося"}),
                (Locale.PortugueseBrazil, new ApplianceInfo{Name = "Salmão", Description = "Fornece salmão"}),
                (Locale.Japanese, new ApplianceInfo{Name = "サーモン", Description = "サーモンを提供"}),
                (Locale.ChineseSimplified, new ApplianceInfo{Name = "三文鱼", Description = "提供三文鱼"}),
                (Locale.Korean, new ApplianceInfo{Name = "연어", Description = "연어 제공"}),
                (Locale.Turkish, new ApplianceInfo{Name = "Somon", Description = "Somon Balığı Sağlar"}),
            };
        }
    }
}