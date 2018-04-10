using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artiklRacun
{
    public partial class artiklRacun : Form
    {
        public artiklRacun()
        {
            InitializeComponent();
        }

        List<Artikl> listaArtikala = new List<Artikl>();

        private void gumbUnos_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text;
            int kolicina = Int32.Parse(txtKolicina.Text);
            int cijena = Int32.Parse(txtCijena.Text);

            Artikl artikl = new Artikl(naziv, cijena, kolicina);

            /*ako u listi postoji artikl s tim nazivom */
            if (listaArtikala.Exists(x => x.naziv == artikl.naziv))
            {
                azurirajArtikl(artikl);
            }
            else
            {
                listaArtikala.Add(artikl);
            }
            
            /*nakon dodavanja ažurirati ispis na listBoxu*/
            azuriranjeListeArtiakala(listaArtikala);

            /*
             PROUČI IMPLEMENTIRANE FUNKCIJE I LOGIKU KOJU SAM KORISTIO ZA RAD S LISTBOXOM S POPISOM ARTIKALA
             IMPLEMENTIRAJ NASTAVAK APLIKACIJE KAKO GOD ZNAŠ I UMIJEŠ
             KORISNIK IMA MOGUĆNOST ODABIRA ARTIKALA, TE KOLIČINU TOG ARTIKLA
             KADA KLIKNE GUMB "DODAJ NA RAČUN" - LISTA ARTIKALA SMANJUJE KOLIČINU, A LISTA RAČUNA SE AŽURIRA (POVEĆANJE KOLIČINE ILI DODAVANJE NOVOG ARTIKLA)*/
        }
        
        private void azurirajArtikl(Artikl artikl)
        {
            foreach (var art in listaArtikala)
            {
                /*
                 ako već postoji artikl s tim nazivom
                 povećaj količinu na skladištu
                 ažuriraj cijenu artikla
                 */
                if (art.naziv == artikl.naziv)
                {
                    art.kolicina = art.kolicina + artikl.kolicina;
                    art.cijena = artikl.cijena;
                }
            }
            
        }

        private void azuriranjeListeArtiakala(List<Artikl> listaArtikala)
        {
            /*prvo ćemo obrisati list box i onda dodati ispočetka novi
             kako bi bili sigurni da smo sve ažurirali*/
            listaArtikli.Items.Clear();
            foreach (var x in listaArtikala)
            {
                string upisUListu =
                    "Naziv: " + x.naziv + "; Cijena: " + x.cijena + "; Količina: " + x.kolicina;
                listaArtikli.Items.Add(upisUListu);
            }
        }
    }
}
