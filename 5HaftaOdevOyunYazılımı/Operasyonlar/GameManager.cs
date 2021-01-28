using System;
using System.Collections.Generic;
using System.Text;

namespace _5HaftaOdevOyunYazılımı
{
    class GameManager : IGameService
    {
        
        public void Sale(TheGame theGame, Player player)
        {
            Console.WriteLine(player.FirstName + " "+ player.LastName + " " +"Oyun satın aldı.");
        }
    }
}
