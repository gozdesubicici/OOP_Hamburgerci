using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Hamburgerci
{
    // Bir siparişin ... özellikleri vardır.
    public class Siparis
    {
        public Menu SeciliMenusu { get; set; }
        public List<Ekstra> EkstraMalzemesi { get; set; }
        public Boyut Boyutu { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenusu.Fiyati;
            switch (Boyutu)
            {                
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;            
            }

            foreach (Ekstra ekstra in EkstraMalzemesi)
            {
                ToplamTutar += ekstra.Fiyati;
            }

            ToplamTutar = ToplamTutar * Adet;

        }

        public override string ToString()
        {
            // Nesne adıyla çağırıldığında şu şekilde listbox'a bastırılsın..
            //ekstra malzeme seçiliyse yada değilse diye ikiye ayırıyorum
            if(EkstraMalzemesi.Count<1)   // Ekstra Malzeme yoksa
            {
                return string.Format("{0} Menü x {1} Adet, {2} Boy, Toplam {3}", SeciliMenusu.MenuAdi, Adet, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string ekstraMalzemeler = null;

                foreach (Ekstra ekstra in EkstraMalzemesi)
                {
                    ekstraMalzemeler += ekstra.EkstraAdi + ",";
                }

                ekstraMalzemeler = ekstraMalzemeler.Trim(','); // En son eklenen virgülü temizler.

                return string.Format("{0} Menü x {1} Adet, {2} Boy,({3}) Toplam {4}", SeciliMenusu.MenuAdi, Adet, Boyutu.ToString(),ekstraMalzemeler, ToplamTutar.ToString("C2"));
            }

        }



    }
}
