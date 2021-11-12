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
        List<libro> lista = new List<libro>;

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
        public bibliotec(string nomeB,string indirizzo,string apertura,string chiusura )
        {
            NomeB = nomeB;
            Indirizzo = indirizzo;
            Apertura = apertura;
            Chiusura = chiusura;
        }
    }
}
