﻿using System;

namespace KutuphaneYonetimi1O.Entites.Model
{
    public class KitapHareket
    {
        public int KitapHareketId { get; set; }
        public int KitapId { get; set; }
        public int PersonelId { get; set; }
        public int UyeId { get; set; }
        public DateTime AlmaTarihi { get; set; }
        public DateTime IadeTarihi { get; set; }
        public DateTime KullaniciIadeTarihi { get; set; }
        public bool KitapHareketDurumu { get; set; }

        public decimal CezaUcreti { get; set; }

        public virtual Kitap Kitap { get; set; }
        public virtual Uye Uye { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
