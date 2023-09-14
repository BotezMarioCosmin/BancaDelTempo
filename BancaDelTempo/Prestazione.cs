using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaDelTempo
{
    public class Prestazione
    {
        private int _ore;
        private string _nomePrestazione;
        private DateTime _data;
        private string _prestante;
        private string _beneficiario;
        public int Ore
        { 
            get { return _ore; } 
            set 
            {
                if (value > 0)
                {
                    _ore = value;
                }
                else
                    throw new Exception("Le ore devono essere maggiori di 0");
               
            } 
        }

        public string NomePrestazione
        {
            get { return _nomePrestazione; }
            set
            {
                if (value != null)
                {
                    _nomePrestazione = value;
                }
                else
                    throw new Exception("La prestazione deve avere un nome");

            }
        }

        public DateTime Data
        {
            get { return _data; }
            set
            {
                if (value != null)
                {
                    _data = value;
                }
                else
                    throw new Exception("La data non può essere nulla");

            }
        }

        public string Prestante
        {
            get { return _prestante; }
            set
            {
                if (value != null)
                {
                    _prestante = value;
                }
                else
                    throw new Exception("Il prestante deve avere un nome");

            }
        }

        public string Beneficiario
        {
            get { return _beneficiario; }
            set
            {
                if (value != null)
                {
                    _beneficiario = value;
                }
                else
                    throw new Exception("Il beneficiario deve avere un nome");

            }
        }

        public Prestazione(int ore, string nomePrestazione, DateTime data, string prestante, string beneficiario)
        {
            _ore = ore;
            _nomePrestazione = nomePrestazione;
            _data = data;
            _prestante = prestante;
            _beneficiario = beneficiario;
        }
    }
}
