using Domen;
using Domen.Komunikacija;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Zaposleni UlogujSe(Zaposleni z)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.UlogujSe,
                Zaposleni = z
            };

            posaljilac.Posalji(zahtev);

            Odgovor odgovor = primalac.Primi<Odgovor>();

            return odgovor.Zaposleni;
    
        }

        public List<Predavac> VratiSvePredavace()
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiSvePredavace
            };

            posaljilac.Posalji(zahtev);

            Odgovor odgovor = primalac.Primi<Odgovor>();

            return odgovor.Predavaci;
        }

        public void KreirajKurs(Kurs kurs)
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.KreirajKurs,
                    Kurs = kurs
                };

                posaljilac.Posalji(zahtev);

                Odgovor odgovor = primalac.Primi<Odgovor>();

                if (odgovor.Operacija == Operacija.KursUspesnoKreiran)
                {
                    MessageBox.Show("Uspesno ste kreirali kurs");
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da kreira kurs");
                }
            }
            catch (IOException ex)
            {
                //OtkacilaSeApp();
            }

        }
    }
}
