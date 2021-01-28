using System;
using System.Collections.Generic;
using System.Text;

namespace _5HaftaOdevOyunYazılımı
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.BirthYear == 1985 && player.FirstName == "Engin" && player.LastName=="Demiroğ"&& player.IdentityNumber==123456)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}
