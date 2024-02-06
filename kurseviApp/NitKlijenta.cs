using Domen;
using Domen.Komunikacija;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace kurseviApp
{
    public class NitKlijenta
    {
        private Socket klijentskiSocket;
        private Primalac primalac;
        private Posaljilac posaljilac;
        private List<Zaposleni> zaposleni = Kontroler.Instance.VratiSveZaposlene();
        private static List<Zaposleni> ulogovaniZaposleni = new List<Zaposleni>();

        public NitKlijenta(Socket klijentskiSocket)
        {
            this.klijentskiSocket = klijentskiSocket;
            primalac = new Primalac(klijentskiSocket);
            posaljilac= new Posaljilac(klijentskiSocket);
        }

        public void ObradiZahteve()
        {
            while (true)
            {
                Odgovor odgovor = new Odgovor();

                try
                {
                    Zahtev zahtev = primalac.Primi<Zahtev>();
                    switch (zahtev.Operacija)
                    {
                        case Operacija.UlogujSe:

                            bool provera = true;
                            foreach(Zaposleni z in zaposleni)
                            {
                                foreach(Zaposleni ulogovani in ulogovaniZaposleni)
                                {
                                    if(ulogovani.KorisnickoIme == zahtev.Zaposleni.KorisnickoIme && ulogovani.Sifra == zahtev.Zaposleni.Sifra)
                                    {
                                        odgovor.Operacija = Operacija.NeuspesnaPrijava;
                                        odgovor.Zaposleni = null;
                                        provera = false;    
                                        break;
                                    }
                                }  
                                
                                if(z.KorisnickoIme == zahtev.Zaposleni.KorisnickoIme && z.Sifra == zahtev.Zaposleni.Sifra && provera)
                                {
                                    odgovor.Operacija = Operacija.UspesnaPrijava;
                                    odgovor.Zaposleni = z;
                                    ulogovaniZaposleni.Add(z);
                                    break;
                                }

                                odgovor.Operacija = Operacija.NeuspesnaPrijava;
                            }

                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.VratiSvePredavace:

                            odgovor.Predavaci= Kontroler.Instance.VratiSvePredavace();
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.KreirajKurs:
                            odgovor.Operacija = Kontroler.Instance.KreirajKurs(zahtev.Kurs) ? Operacija.KursUspesnoKreiran : Operacija.GreskaUZahtevu;
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.VratiSveKurseve:
                            odgovor.Kursevi = Kontroler.Instance.VratiSveKurseve();
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.PretraziKurs:
                            odgovor.Kursevi = Kontroler.Instance.PretraziKurseve(zahtev.Kurs);
                            odgovor.Operacija = Operacija.KurseviUspesnoPronadjeni;
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.VratiKurs:
                            odgovor.Kurs = Kontroler.Instance.VratiKurs(zahtev.Kurs);
                            odgovor.Operacija = Operacija.KursUspesnoNadjen;
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.IzmeniKurs:
                            odgovor.Operacija = Kontroler.Instance.IzmeniKurs(zahtev.Kurs) ? Operacija.KursUspesnoIzmenjen : Operacija.GreskaUZahtevu;
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.ObrisiKurs:
                            odgovor.Operacija = Kontroler.Instance.ObrisiKurs(zahtev.Kurs) ? Operacija.KursUspesnoObrisan : Operacija.GreskaUZahtevu;
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.KreirajUcenika:
                            odgovor.Operacija = Kontroler.Instance.KreirajUcenika(zahtev.Ucenik) ? Operacija.UcenikUspesnoKreiran : Operacija.GreskaUZahtevu;
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.VratiSveUcenike:
                            odgovor.Ucenici = Kontroler.Instance.VratiSveUcenike();
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.PretraziUcenika:
                            odgovor.Ucenici = Kontroler.Instance.PretraziUcenike(zahtev.Ucenik);
                            odgovor.Operacija = Operacija.UceniciUspesnoPronadjeni;
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.VratiUcenika:
                            odgovor.Ucenik = Kontroler.Instance.VratiUcenika(zahtev.Ucenik);
                            odgovor.Operacija = Operacija.UcenikUspesnoNadjen;
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.IzmeniUcenika:
                            odgovor.Operacija = Kontroler.Instance.IzmeniUcenika(zahtev.Ucenik) ? Operacija.UcenikUspesnoIzmenjen : Operacija.GreskaUZahtevu;
                            posaljilac.Posalji(odgovor);
                            break;
                        case Operacija.ObrisiUcenika:
                            odgovor.Operacija = Kontroler.Instance.ObrisiUcenika(zahtev.Ucenik) ? Operacija.UcenikUspesnoObrisan : Operacija.GreskaUZahtevu;
                            posaljilac.Posalji(odgovor);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
