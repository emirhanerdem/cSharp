using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliYikamaTakipSistemi
{
    public enum Durum
    {
        Yikamada,
        TeslimEdildi
    }

    public class Hali
    {
        public double Metrekare { get; set; }
        public DateTime AlinmaTarihi { get; set; }
        public DateTime TahminiTeslimTarihi { get; set; }
        public Durum YikamaDurumu { get; set; } = Durum.Yikamada;

        public double Ucret => Metrekare * 20;

        public override string ToString()
        {
            return $"{Metrekare} m² - {YikamaDurumu} - {Ucret} TL";
        }
    }
}
