using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciUygLib
{
    public class KiralikEv : Ev
    {
        public int Kira { get; set; }

        public int Depozito { get; set; }

        public KiralikEv() 
        {

        }

        public KiralikEv(int Kira, int Depozito, int odasayisi, int katno, int alan) :base(odasayisi, katno, alan) 
        {
            this.Kira = Kira;
            this.Depozito = Depozito;
        }

        public string KiralikEvBil()
        {
            return $" Kira: {this.Kira} \n Depozito: {this.Depozito} \n Oda Sayisi: {base.OdaSayisi} \n Kat No: {base.KatNo} \n Alan: {base.Alan}";
        }
    }
}
