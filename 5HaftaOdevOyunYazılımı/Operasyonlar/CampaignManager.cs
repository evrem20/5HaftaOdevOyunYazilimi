using System;
using System.Collections.Generic;
using System.Text;

namespace _5HaftaOdevOyunYazılımı
{
    class CampaignManager : ICampaingService
    {
        

        public void Add(Campaign campaign, TheGame theGame, Player player)
        {
            Console.WriteLine("Yeni üye olan"+ " " +player.FirstName + " " + player.LastName + " " + theGame.GameName + " " + "satın alarak" + " " + campaign.CampaignName + " ile" +" "+ campaign.CampaignDiscount+ " " +"kazandı.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}
