using System;
using System.Collections.Generic;
using System.Text;

namespace _5HaftaOdevOyunYazılımı
{
    class Player          //Oyuncu varlığımızı oluşturduk.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }   //Mersis sistemi tc numarayı long veri tipinde tutuyor.


    }
}
