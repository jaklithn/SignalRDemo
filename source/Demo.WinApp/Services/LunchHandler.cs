using System;
using System.Windows.Forms;

namespace Demo.WinApp.Services
{
    public static class LunchHandler
    {
        private static readonly Random Randomizer = new Random(DateTime.Now.Millisecond);
        private static readonly string[] MeatMenu =
        {
            "Timjanskryddad Winerfärslåda serveras med skogssvampsås, rostade rotfrukter samt rårörda lingon",
            "Kyckling ballotine fylld med provensalskaörter serveras med rödvinssky vitlöksrostad potatis samt liten sallad på toppen",
            "Grillad fänkålsrubbad fläskfilé serveras med mojo rojo, chilisky samt olivrostade potatishalvor",
            "Klassisk Biff stroganoff serveras med saltgurka, grov senapscréme och paprikafris",
            "Bistrots BBQ- Burger med egengjorddressing, plocksallad, bröd, coleslaw samt klyftpotatis"
        };
        private static readonly string[] FishMenu = {
            "Halstrad socker-saltad kummel serveras med krondillsås, kokt potatis samt ärtor och citronklyfta" ,
            "Sejfilé bakad med en kräm på färskost, basilika och kronärtskocka serveras med vitvinssås och örtslungad potatis",
            "Flundrafilé fylld med laxmousse serveras med gräddig skaldjurssås, kokt potatis, räkor, dill, champinjoner",
            "Vinkokt Torskfile serveras med hackat ägg, brynt smör, kokt potatis samt gräslök",
            "Pestobakad kolja med parmesansmaksatt vitvinssås samt potatisstomp med semitorkade tomater"
        };
        private static readonly string[] VegetarianMenu =
        {
            "Getostsallad med mandel och valnötsgratinerad getost, tunt skivad rödbeta och honungsdressing",
            "Terrin på jordärtskocka, bakat ägg, pressgurka, smörsås, nötter",
            "Ljummen kålsallad, gröna linser, pocherat ägg & bakad fänkål",
            "Avocadosallad, puylinser, citronsås & tomater"
        };
        private static readonly string[] Prices = {
            "89 kr",
            "95 kr",
            "99 kr",
            "105 kr",
            "120 kr" };



        public static void Suggest(TextBox txtMeat, TextBox txtFish, TextBox txtVegetarian, TextBox txtMeatPrice, TextBox txtFishPrice, TextBox txtVegetarianPrice)
        {
            txtMeat.Text = MeatMenu[Randomizer.Next(0, MeatMenu.Length)];
            txtFish.Text = FishMenu[Randomizer.Next(0, FishMenu.Length)];
            txtVegetarian.Text = VegetarianMenu[Randomizer.Next(0, VegetarianMenu.Length)];

            txtMeatPrice.Text = Prices[Randomizer.Next(0, Prices.Length)];
            txtFishPrice.Text = Prices[Randomizer.Next(0, Prices.Length)];
            txtVegetarianPrice.Text = Prices[Randomizer.Next(0, Prices.Length)];
        }
    }
}