using Autoprevoznicko_preduzece_HTS.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAutoprevozncniko.ViewModels;

namespace WebAutoprevozncniko.Controllers
{
    public class KupiKartuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
       
        public IActionResult DodajKartu()
        {
            MyContext db = new MyContext();

            List<ComboBox> tipKarte = db.tipKarte.Select(tk => new ComboBox
            {
                ID = tk.ID,
                naziv = tk.naziv
            }).ToList();
            ViewData["TipKarte"] = tipKarte;
            List<ComboBox> VrstaKarte = db.vrstaKarte.Select(vk => new ComboBox
            {
                ID = vk.ID,
                naziv = vk.naziv
            }).ToList();
            ViewData["VrstaKarte"] = VrstaKarte;

            List<ComboBox> gradskeLinije = db.gradskeLinije.Select(gl => new ComboBox
            {
                ID = gl.ID,
                naziv = gl.zona.BrojZone.ToString()
            }).ToList();
            ViewData["Zona"] = gradskeLinije;
            return View();
        }
        public IActionResult SpasiKartu(
            int RbKarte,
            string ime,
            string prezime,
            string email,
            int TipKarteID,
            int VrstaKarteID,
            DateTime DatumVadjenja,
            DateTime DatumVazenja,
            int ZonaID,
            int brojPutnika,
            string pravac
            )
        {
            MyContext db = new MyContext();
            KupiKartu k = new KupiKartu
            {
                Ime=ime,
                Prezime=prezime,
                Email=email,
                tipKarteID = TipKarteID,
                vrstaKarteID = VrstaKarteID,
                DatumVadjenjaKarte = DatumVadjenja,
                DatumVazenjaKarte = DatumVazenja,
                gradskaLinijaID = ZonaID,
                BrojPutnika = brojPutnika,
                gradskaLinija = db.gradskeLinije.Include("zona").FirstOrDefault(gl => gl.ID == ZonaID),
                vrstaKarte = db.vrstaKarte.FirstOrDefault(vrsta => vrsta.ID == VrstaKarteID),
                tipKarte = db.tipKarte.FirstOrDefault(tip => tip.ID == TipKarteID),
                Pravac = pravac
            };
            db.Add(k);
            db.SaveChanges();
            db.Dispose();
            ViewData["Karta"] = k;
            return View();
        }
        public IActionResult Placanje(
          string VrstaPlacanja,
            int kartaID,
            string ime,
            string tipKarteNaziv,
            string vrstaKarteNaziv
            )
        {
            MyContext db = new MyContext();
            if (VrstaPlacanja.StartsWith("Online"))
            {
                KupiKartu k = db.kupiKartu.Find(kartaID);
                db.SaveChanges();
                EmailController.SendEmail(k.Email, "Potvrda o placanju", "Uspjesno ste kupili kartu " + tipKarteNaziv + "-- " + vrstaKarteNaziv + " na ime: " + k.Ime + " " + k.Prezime);
                return View("OnlinePlacanje");
            }
            else
            {
                return View("PreuzecePlacanje");
            }
        }
    }
}
