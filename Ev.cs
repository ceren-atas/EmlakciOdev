using System;

namespace EmlakciUygLib
{
    public class Ev
    {
        public int OdaSayisi { get; set; }

        public int KatNo { get; set; }

        public int Alan { get; set; }

        public Ev()
        {

        }

        public Ev(int odaSayisi, int katNo, int alan)
        {
            this.OdaSayisi = odaSayisi;
            this.KatNo = katNo;
            this.Alan = alan;
        }

        public string EvBil()
        {
            return $" Oda Sayisi : {this.OdaSayisi} \n Kat No : {this.KatNo} \n Alan : {this.Alan}";
        }
    }
}
