using System;
using System.Collections.Generic;
using System.Text;

namespace _5HaftaOdevOyunYazılımı
{
    interface IPlayerService     //Operasyonlarda ilk olarak interface oluşturmak lazım.
    {
        void Add(Player player);    //Parametre olarakkim eklenip güncellenecekse içerisine onu yazarız.
        void Update(Player player);   //Bu soyut operasyonları somut hale getirmek için classlaardan manager oluşturduk.
        void Delete(Player player);
    }
}
