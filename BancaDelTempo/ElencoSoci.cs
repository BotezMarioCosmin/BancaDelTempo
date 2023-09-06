using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaDelTempo
{
    public class ElencoSoci
    {
        private List<Socio> _sociList;
        public List<Socio> SociList
        {
            set { _sociList = value; }
            get { return _sociList; }
        }
        public ElencoSoci()
        {
            _sociList = new List<Socio>();
        }

        public ElencoSoci(List<Socio> sociList)
        {
            _sociList = sociList;
        }

        public void AggiungiSocio(Socio socio)
        {
            _sociList.Add(socio);
        }

        public void RimuoviSocio(Socio socio)
        {
            _sociList.Remove(socio);
        }

        public Socio TrovaSocioPerCognome(string cognome)
        {
            return _sociList.Find(s => s.Cognome.Equals(cognome, StringComparison.OrdinalIgnoreCase));
        }

        public Socio TrovaSocioPerNome(string nome)
        {
            return _sociList.Find(s => s.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }

        public Socio TrovaSocioPerTelefono(string telefono)
        {
            return _sociList.Find(s => s.Nome.Equals(telefono, StringComparison.OrdinalIgnoreCase));
        }

        public int NumeroTotaleSoci()
        {
            return _sociList.Count;
        }
    }
}

