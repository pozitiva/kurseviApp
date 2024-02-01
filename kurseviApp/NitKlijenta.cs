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
                                        odgovor.Signal = Signal.NeuspesnaPrijava;
                                        odgovor.Zaposleni = null;
                                        provera = false;    
                                        break;
                                    }
                                }  
                                
                                if(z.KorisnickoIme == zahtev.Zaposleni.KorisnickoIme && z.Sifra == zahtev.Zaposleni.Sifra && provera)
                                {
                                    odgovor.Signal = Signal.UspesnaPrijava;
                                    odgovor.Zaposleni = z;
                                    ulogovaniZaposleni.Add(z);
                                    break;
                                }

                                odgovor.Signal = Signal.NeuspesnaPrijava;
                            }

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
