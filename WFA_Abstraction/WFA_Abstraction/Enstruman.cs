using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Abstraction
{
   
    public abstract class Enstruman //bu nesne soyuttur. Tek gorevi bunyesindeki property'lerin miras verildigi class'larda kullanilmasini saglamaktir. Soyut nesneden instance alamayiz.
        //Property'ler de abstract olarak tanimlanabilir. Eger property abstract tanimlandiysa, onu somut hale getirebilmek icin kalitim verdigi class'ta override yapilmasi gerekiyor. bu konuda polymorhism'den farki, istege bagli degil, mecburi olarak ezme islemi yapilmasidir.
    {
        public string Tur { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Fiyat { get; set; }

        public abstract string Cal(); //Abstract olarak tanimlanan bir method'un govdesi olamaz ve kalitim alinan class'larda override edilmelidir. Yalnizca abstract class'larda abstract method tanimlanabilir. Istege bagli degil, mecburi ezme islemi yapildigi icin virtual olarak tanimlanmazlar. Abstract class'lar static olarak tanimlanamaz.(soyut oldugu icin ram uzerine cikarilamiyor.) Base Class'lar cogunlukla abstracttir (soyut oldugu icin, enstruman gibi, canlilar gibi, urunler gibi...)

       
    }
}
