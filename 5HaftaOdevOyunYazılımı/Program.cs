using System;

namespace _5HaftaOdevOyunYazılımı
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player { Id = 1, FirstName = "Engin", LastName = "Demiroğ", BirthYear = 1985, IdentityNumber = 123456 }; //Oyuncu tanımladım.

            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(new Player { Id = 1, FirstName = "Engin", LastName = "Demiroğ", BirthYear = 1985, IdentityNumber = 123456 });


            TheGame theGame = new TheGame {GameName =   "ODK", GameSale=100};  //Oyun tanımladım.
            

            GameManager gameManager = new GameManager();
            gameManager.Sale(theGame, player1);

            Campaign campaign = new Campaign { CampaignName = "Yeni üyelere özel kampanya", CampaignDiscount = "%30 indirim" };  //Kampanya girişi.

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign, theGame, player1);







        }
    }
}
