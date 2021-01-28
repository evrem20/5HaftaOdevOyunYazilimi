using System;
using System.Collections.Generic;
using System.Text;

namespace _5HaftaOdevOyunYazılımı
{
    interface ICampaingService
    {
        void Add(Campaign campaign, TheGame theGame, Player player);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
