using System;
using System.Numerics;

class TestClass
{
    static void Main(string[] args) // statik bir string dizi üzerinden girdiğimiz isimleri istediğimiz isime eşit olduğu zaman bulunan ismi yazan basit bir örnek
    {
        bool found = false;
        string[] names = { // statik bir dizi şeklinde tanımlıyoruz
            "Aaren",
            "Lynda",
            "Maggi",
            "Giovanna",
            "Neila",
            "Berkan"
        };
        string isim = "berkan"; // küçük harfle aratmak istediğimiz isim
        foreach(string searchname in names) // diziye eklediğimiz bütün isimleri çevireceğimiz döngüyü kuruyoruz
        {
            if(searchname.ToLower() == isim) // burada şartı küçük harfle aratması için ToLower() dönüşümünü kullanıyoruz ve isimler içerisinde "Berkan" var mı? Kontrolü yapıyor.
                found = true;
        }

        if (found)
            Console.WriteLine($"İsmin listede bulundu {isim}!");
        else
            Console.WriteLine($"Üzgünüm aradığın isim listede bulunmuyor...");
    }
}