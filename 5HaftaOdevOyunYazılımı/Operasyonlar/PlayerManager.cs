using System;
using System.Collections.Generic;
using System.Text;

namespace _5HaftaOdevOyunYazılımı
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;
public PlayerManager(IUserValidationService userValidationService)
        {
            this._userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player) == true)
            {
                Console.WriteLine("Kayıt Oldu");
            }

            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }
           
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }

}
