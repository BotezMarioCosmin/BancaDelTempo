using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaDelTempo
{
    public class User : Socio
    {
        private string _username;
        private string _password;
        private bool _admin;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool Admin
        { 
            get { return _admin; }
            set { _admin = value; }
        }

        public User(string cognome, string nome, string telefono, int debito, string zona, string username, string password, bool admin) : base(cognome, nome, telefono, debito, zona)
        {
            _username = username;
            _password = password;
            _admin = admin;
        }


        public override string ToString()
        {
            return string.Format("Username: "+Username+"\n\tPassword :"+Password+"\n\tAdmin: "+Admin+"\n\tSocio:\n\tCognome: " + Cognome + "\n\tNome: " + Nome + "\n\tTelefono: " + Telefono + "\n\tDebito: " + Debito);
        }
    }
}
