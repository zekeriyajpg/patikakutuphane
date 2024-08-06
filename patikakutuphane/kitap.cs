using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikakutuphane
{
    internal class kitap
    {
        public string adi {  get; set; }
        public string yazaradi {  get; set; }
        public string soyadi {  get; set; }
        public int sayfasayisi { get; set; }
        public string yayinevi { get; set; }
        public DateTime KayitTarihi { get; set; }


        public kitap()
        {
            this.KayitTarihi = DateTime.Now;
        }

        public kitap(string ktpadi, string yad, string sad, int sayfa, string yevi)
        {
            this.adi = ktpadi;
            this.yazaradi = yad;
            this.soyadi = sad;
            this.sayfasayisi = sayfa;
            this.yayinevi = yevi;
            this.KayitTarihi = DateTime.Now;

        }
        public override string ToString()
        {
            return $"Kitap Adı: {adi} İsim: {yazaradi} Soyisim: {soyadi} Sayfa Sayısı: {sayfasayisi} Yayın evi: {yayinevi} Kayıt tarihi: {KayitTarihi}";
        }



    }
}
