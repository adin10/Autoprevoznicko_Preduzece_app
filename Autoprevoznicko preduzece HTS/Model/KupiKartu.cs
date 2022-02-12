using System;
using System.Collections.Generic;
using System.Text;

namespace Autoprevoznicko_preduzece_HTS.Model
{
   public class KupiKartu
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public TipKarte tipKarte { get; set; }
        public int tipKarteID { get; set; }

        public VrstaKarte vrstaKarte { get; set; }
        public int vrstaKarteID { get; set; }
        public DateTime DatumVadjenjaKarte { get; set; }
        public DateTime DatumVazenjaKarte { get; set; }

        public GradskeLinije gradskaLinija { get; set; }
        public int gradskaLinijaID { get; set; }
        public int BrojPutnika { get; set; }
        public string Pravac { get; set; }
    }
}
