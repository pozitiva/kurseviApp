using Domen;
using Domen.Komunikacija;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Klijent
{
    public class Komunikacija
    {
        private static Komunikacija instance;
        Primalac primalac;
        Posaljilac posaljilac;
        Socket socket;
        public static Komunikacija Instance
        {
            get
            {
                if (instance == null)
                    instance = new Komunikacija();
                return instance;
            }
        }

        public bool PoveziSe()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);

                primalac = new Primalac(socket);
                posaljilac = new Posaljilac(socket);

                return true;
            }catch(Exception ex)
            {
                Debug.Write(ex.Message);
                return false;
            }
        }

        public Odgovor UlogujSe(string korisnickoIme, string sifra)
        {
            Zaposleni z = new Zaposleni
            {
                KorisnickoIme = korisnickoIme,
                Sifra = sifra
            };

            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.UlogujSe,
                Zaposleni = z
            };

            posaljilac.Posalji(zahtev);

            return primalac.Primi<Odgovor>();
    
        }
    }
}
