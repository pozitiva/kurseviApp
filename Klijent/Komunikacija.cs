using Domen;
using Domen.Komunikacija;
using Klijent.Kontroleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public bool konektovanNaServer = false;
        public bool PoveziSe()
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);

                primalac = new Primalac(socket);
                posaljilac = new Posaljilac(socket);

                konektovanNaServer = true;
                return true;
            }catch(Exception ex)
            {
                Debug.Write(ex.Message);
                return false;
            }
        }

        public Zaposleni UlogujSe(Zaposleni z)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.UlogujSe,
                    Zaposleni = z
                };

                posaljilac.Posalji(zahtev);

                Odgovor odgovor = primalac.Primi<Odgovor>();
                if (odgovor.Operacija == Operacija.NeuspesnaPrijava)
                {
                    return null;
                }

                return odgovor.Zaposleni;
            }catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
    
        }

        public List<Predavac> VratiSvePredavace()
        {
            try
            {
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.VratiSvePredavace
                };

                posaljilac.Posalji(zahtev);

                Odgovor odgovor = primalac.Primi<Odgovor>();

                return odgovor.Predavaci;
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void KreirajKurs(Kurs kurs)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
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
                    throw new Exception("Sistem ne moze da kreira kurs");
                }
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Kurs> VratiSveKurseve()
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.VratiSveKurseve
                };

                posaljilac.Posalji(z);

                Odgovor odgovor = primalac.Primi<Odgovor>();

                return odgovor.Kursevi;
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Kurs> PretraziKurseve(Kurs k)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev
                {
                    Kurs = k,
                    Operacija = Operacija.PretraziKurseve

                };
                posaljilac.Posalji(zahtev);

                Odgovor odgovor = primalac.Primi<Odgovor>();

                List<Kurs> pronadjeniKursevi = odgovor.Kursevi;

                if (odgovor.Operacija == Operacija.KurseviUspesnoPronadjeni)
                {
                    MessageBox.Show("Sistem je nasao kurseve po zadatoj vrednosti");
                }
                else
                {
                    throw new Exception("Sistem ne moze da nadje kurseve po zadatoj vrednosti");
                }

                return pronadjeniKursevi;
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Kurs VratiKurs(Kurs k)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev()
                {
                    Kurs=  k,
                    Operacija = Operacija.VratiKurs
                };

                posaljilac.Posalji(zahtev);

                Odgovor odgovor = primalac.Primi<Odgovor>();

                Kurs kurs = odgovor.Kurs;
                if (odgovor.Operacija == Operacija.KursUspesnoNadjen)
                {
                    MessageBox.Show("Sistem je ucitao kurs");
                }
                else
                {
                    throw new Exception("Sistem ne moze da ucita kurs");
                }

                return kurs;
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IzmeniKurs(Kurs kurs)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.IzmeniKurs,
                    Kurs = kurs
                };

                posaljilac.Posalji(zahtev);
                Odgovor odgovor = primalac.Primi<Odgovor>();
                if (odgovor.Operacija == Operacija.KursUspesnoIzmenjen)
                {
                    MessageBox.Show("Sistem je izmenio podatke o kursu");
                }
                else
                {
                    throw new Exception("Sistem ne moze da izmeni kurs");
                }
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ObrisiKurs(Kurs kurs)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.ObrisiKurs,
                    Kurs = kurs
                };

                posaljilac.Posalji(zahtev);
                Odgovor odgovor = primalac.Primi<Odgovor>();
                if (odgovor.Operacija == Operacija.KursUspesnoObrisan)
                {
                    MessageBox.Show("Sistem je obrisao kurs");
                }
                else
                {
                    throw new Exception("Sistem ne moze da obrise kurs");
                }
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void KreirajUcenika(Ucenik u)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.KreirajUcenika,
                    Ucenik = u
                };

                posaljilac.Posalji(zahtev);

                Odgovor odgovor = primalac.Primi<Odgovor>();

                if (odgovor.Operacija == Operacija.UcenikUspesnoKreiran)
                {
                    MessageBox.Show("Uspesno ste kreirali ucenika");
                }
                else
                {
                    throw new Exception("Sistem ne moze da kreira ucenika");
                }
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Ucenik> VratiSveUcenike()
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.VratiSveUcenike
                };

                posaljilac.Posalji(z);

                Odgovor odgovor = primalac.Primi<Odgovor>();

                return odgovor.Ucenici;
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ucenik> PretraziUcenike(Ucenik u)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev()
                {
                    Ucenik = u,
                    Operacija = Operacija.PretraziUcenike
                };

                posaljilac.Posalji(zahtev);

                Odgovor odgovor = primalac.Primi<Odgovor>();

                List<Ucenik> pronadjeniUcenici = odgovor.Ucenici;

                if (odgovor.Operacija == Operacija.UceniciUspesnoPronadjeni)
                {
                    MessageBox.Show("Sistem je nasao ucenike po zadatoj vrednosti");
                }
                else
                {
                    throw new Exception("Sistem ne moze da nadje ucenike po zadatoj vrednosti");
                }

                return pronadjeniUcenici;
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Ucenik VratiUcenika(Ucenik u)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev()
                {
                    Ucenik= u,
                    Operacija = Operacija.VratiUcenika
                };

                posaljilac.Posalji(zahtev);

                Odgovor odgovor = primalac.Primi<Odgovor>();

                Ucenik ucenik = odgovor.Ucenik;
                if (odgovor.Operacija == Operacija.UcenikUspesnoNadjen)
                {
                    MessageBox.Show("Sistem je ucitao ucenika");
                }
                else
                {
                    throw new Exception("Sistem ne moze da ucita ucenika");
                }

                return ucenik;
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IzmeniUcenika(Ucenik u)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev
                {
                    Ucenik = u,
                    Operacija = Operacija.IzmeniUcenika
                };

                posaljilac.Posalji(zahtev);
                Odgovor odgovor = primalac.Primi<Odgovor>();
                if (odgovor.Operacija == Operacija.UcenikUspesnoIzmenjen)
                {
                    MessageBox.Show("Sistem je izmenio podatke o uceniku");
                }
                else
                {
                    throw new Exception("Sistem ne moze da izmeni ucenika");
                }
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ObrisiUcenika(Ucenik u)
        {
            try 
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev 
                { 
                    Ucenik = u,
                    Operacija= Operacija.ObrisiUcenika
                };

                posaljilac.Posalji(zahtev);
                Odgovor odgovor = primalac.Primi<Odgovor>();
                if (odgovor.Operacija == Operacija.UcenikUspesnoObrisan)
                {
                    MessageBox.Show("Sistem je obrisao ucenika");
                }
                else
                {
                    throw new Exception("Sistem ne moze da obrise ucenika");
                }
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void KreirajGrupu(Grupa grupa)
        {
            try 
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.KreirajGrupu,
                    Grupa = grupa
                };

                posaljilac.Posalji(zahtev);

                Odgovor odgovor = primalac.Primi<Odgovor>();

                if (odgovor.Operacija == Operacija.GrupaUspesnoKreirana)
                {
                    MessageBox.Show("Uspesno ste kreirali grupu");
                }
                else
                {
                    throw new Exception("Sistem ne moze da kreira grupu");
                }
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Grupa> VratiSveGrupe()
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev
                {
                    Operacija = Operacija.VratiSveGrupe
                };

                posaljilac.Posalji(zahtev);
                Odgovor odgovor = primalac.Primi<Odgovor>();
                return odgovor.Grupe;
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Grupa> PretraziGrupe(Grupa g)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");

                Zahtev zahtev = new Zahtev()
                {
                    Grupa = g,
                    Operacija = Operacija.PretraziGrupe
                };

                posaljilac.Posalji(zahtev);

                Odgovor odgovor = primalac.Primi<Odgovor>();

                List<Grupa> pronadjeneGrupe = odgovor.Grupe;

                if (odgovor.Operacija == Operacija.GrupeUspesnoPronadjene)
                {
                    MessageBox.Show("Sistem je nasao grupe za slusanje kurseva po zadatoj vrednosti");
                }
                else
                {
                    throw new Exception("Sistem ne moze da nadje grupe za slusanje kurseva po zadatoj vrednosti");
                }

                return pronadjeneGrupe;
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Grupa VratiGrupu(Grupa grupa)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev
                {
                    Grupa = grupa,
                    Operacija = Operacija.VratiGrupu
                };
                posaljilac.Posalji(zahtev);
                Odgovor odgovor = primalac.Primi<Odgovor>();
                if (odgovor.Operacija == Operacija.GrupaUspesnoNadjena)
                {
                    MessageBox.Show("Sistem je ucitao grupu za slusanje kursa");
                }
                else
                {
                    throw new Exception("Sistem ne moze da ucita grupu za slusanje kursa");
                }

                return odgovor.Grupa;
            }
            catch(IOException ex){
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public void IzmeniGrupu(Grupa grupa)
        {
            try
            {
                if (!SocketPovezan()) throw new IOException("Niste konektovani na server");
                Zahtev zahtev = new Zahtev
                {

                    Grupa = grupa,
                    Operacija = Operacija.IzmeniGrupu
                };
                posaljilac.Posalji(zahtev);

                Odgovor odgovor = primalac.Primi<Odgovor>();
                if (odgovor.Operacija == Operacija.GrupaUspesnoIzmenjena)
                {
                    MessageBox.Show("Sistem je izmenio podatke o grupi za slusanje kursa");
                }
                else
                {
                    throw new Exception("Sistem ne moze da izmeni grupu za slusanje kursa");
                }
            }
            catch (IOException ex)
            {
                OtkacilaSeApp();
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void OdjaviZaposlenog(Zaposleni ulogovaniZaposleni)
        {
            Zahtev z = new Zahtev
            {
                Zaposleni = ulogovaniZaposleni,
                Operacija = Operacija.OdjaviZaposlenog
            };

            posaljilac.Posalji(z);
            Odgovor odgovor = primalac.Primi<Odgovor>();
            

        }

        public bool SocketPovezan()
        {
            if (!konektovanNaServer) return false;
            if (socket == null) return false;
            if (socket.Connected == false) return false;
            bool part1 = socket.Poll(1000, SelectMode.SelectRead);
            bool part2 = (socket.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }

        public void OtkacilaSeApp()
        {
            if (!SocketPovezan())
            {
                MessageBox.Show("Niste konektovani na server. Restartovanje aplikacije.");
                GlavniKoordinator.Instance.frmPrijavljivanje.Close();
            }
        }

    }
}
