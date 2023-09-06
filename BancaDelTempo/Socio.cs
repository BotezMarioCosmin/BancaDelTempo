using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaDelTempo
{
    public class Socio
    {
        private string _cognome;
        private string _nome;
        private string _telefono;
        private int _debito;

        public string Cognome
        {
            set
            {
                if (value != null)
                {
                    _cognome = value;
                }
                else
                {
                    _cognome = "Nessuna Informazione";
                }
            }
            get { return _cognome; }
        }
        public string Nome
        {
            set
            {
                if (value != null)
                {
                    _nome = value;
                }
                else
                {
                    _nome = "Nessuna Informazione";
                }
            }
            get { return _nome; }
        }

        public string Telefono
        {
            set
            {
                if (value != null)
                {
                    _telefono = value;
                }
                else
                {
                    _telefono = "Nessuna Informazione";
                }
            }
            get { return _telefono; }
        }

        public int Debito
        {
            set
            {
                if (value >= 0)//il debito può essere solo uguale o maggiore di 0
                {
                    _debito = value;
                }
                else
                {
                    throw new Exception("Il debito non può essere negativo");
                }
            }
            get { return _debito; }
        }

        public Socio()
        {
            _cognome = "Non specificato";
            _nome = "Non specificato";
            _telefono = "Non specificato";
            _debito = 0;
        }

        public Socio(string cognome, string nome, string telefono, int debito)
        { 
            _cognome = cognome;
            _nome = nome;
            _telefono=telefono;
            _debito = debito;
        }

        public void CambiaTelefono(string nuovoTelefono)
        {
            _telefono = nuovoTelefono;
        }

        public void CambiaDebito(int nuovoDebito)
        { 
            _debito = nuovoDebito;
        }
    }
}
