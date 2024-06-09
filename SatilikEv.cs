using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciUygLib
{
    public class SatilikEv : Ev
    {
        public int Fiyat { get; set; }

        public int Depozito { get; set; }

        public SatilikEv() 
        {

        }

        public SatilikEv(int fiyat, int depozito, int odasayisi, int katno, int alan) :base(odasayisi,katno,alan)
        {
            this.Fiyat = fiyat;
            this.Depozito = depozito;
        }

        public string SatiliEvBil()
        {
            return $" Fiyat: {this.Fiyat} \n Depozito: {this.Depozito} \n Oda Sayisi: {base.OdaSayisi} \n Kat No: {base.KatNo} \n Alan: {base.Alan}";
        }
    }
}
