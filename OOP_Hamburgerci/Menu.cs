using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Hamburgerci
{
    public class Menu
    {
        public string MenuAdi { get; set; }
        public decimal Fiyati { get; set; }

        // Nesne adıyla çağırıldığında, comboBox'ta ... Menü şeklinde görünmesi için:
        public override string ToString()
        {
            return MenuAdi + " Menü";
        }
    }
}
