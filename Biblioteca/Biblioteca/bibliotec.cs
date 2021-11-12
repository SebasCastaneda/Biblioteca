using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class bibliotec
    {
        string nomeB;
        string indirizzo;
        string apertura;
        string chiusura;
        List<libro> lista = new List<libro>();

        public string NomeB
        {
            get;
            set;
        }

        public string Indirizzo
        {
            get;
            set;
        }
        public string Apertura
        {
            get;
            set;
        }
        public string Chiusura
        {
            get;
            set;
        }
        public bibliotec(string nomeB, string indirizzo, string apertura, string chiusura)
        {
            NomeB = nomeB;
            Indirizzo = indirizzo;
            Apertura = apertura;
            Chiusura = chiusura;
        }

        public void add(libro Lista)
        {
            lista.Add(Lista);
        }
        public string ricercaL(string nome)
        {
            string risposta = "si c'e il libro";
            foreach (bibliotec lista in x)
            {
                if (lista.nomeB == nome)
                {
                  risposta="si c'e il libro";
                }
                else
                {
                    risposta = "non c'e";
                    
                }
            }

            return risposta;
        }

        public string RAutore(string Autore)
        {
            string libro="";
            foreach (bibliotec lista in x)
            {
                if (lista.autore == Autore)
                {
                    libro = libro + lista.autore;
                }
               
            }

            return libro;
        }

        public int contare()
        {
           int n=0;
            foreach (bibliotec lista in x)
            {
                if (lista.nomeB != "")
                {
                    n++;
                }
            }

            return n;
        }
    }
}
