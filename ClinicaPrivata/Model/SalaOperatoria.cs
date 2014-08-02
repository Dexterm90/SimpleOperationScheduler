using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.Model
{
    public class SalaOperatoria
    {
        private string _codice;

        public SalaOperatoria(string codice)
        {
            _codice = codice;
        }

        [Editable("Codice")]
        public string Codice
        {
            get { return _codice; }
            set { _codice = value; }
        }

        public override string ToString()
        {
            return _codice;
        }
        
    }
}
