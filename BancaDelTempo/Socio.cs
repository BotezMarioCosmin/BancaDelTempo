﻿using System;
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
        private string _zona;

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
                _debito = value;
            }
            get { return _debito; }
        }

        public string Zona
        {
            set { _zona = value; }
            get { return _zona; }
        }

        public Socio()
        {
            _cognome = "Non specificato";
            _nome = "Non specificato";
            _telefono = "Non specificato";
            _debito = 0;
            _zona = "Non specificata";
        }

        public Socio(string cognome, string nome, string telefono, int debito, string zona)
        { 
            _cognome = cognome;
            _nome = nome;
            _telefono=telefono;
            _debito = debito;
            _zona = zona;
        }


        public void CambiaTelefono(string nuovoTelefono)
        {
            _telefono = nuovoTelefono;
        }

        public void CambiaDebito(int nuovoDebito)
        { 
            _debito = nuovoDebito;
        }

        public void SottraiDebito(int sottrai)
        {
            _debito -= sottrai;
        }

        public void AggiungiDebito(int aggiungi)
        {
            _debito += aggiungi;
        }

        public override string ToString()
        {
            return string.Format("Socio:\n\tCognome: "+Cognome+"\n\tNome: "+Nome+"\n\tTelefono: "+Telefono+"\n\tDebito: "+Debito+"\n\tZona: "+Zona);
        }
    }
}
