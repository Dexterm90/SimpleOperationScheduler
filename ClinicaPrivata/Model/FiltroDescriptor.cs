using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaPrivata.Model
{
    class FiltroDescriptor
    {
        private Medico _medico = null;
        private SalaOperatoria _salaOperatoria = null;
        private DateTime _dallaData = DateTime.MinValue;
        private DateTime _allaData = DateTime.MinValue;

        public Medico Medico
        {
            get { return _medico; }
            set { _medico = value; }
        }

        public SalaOperatoria SalaOperatoria
        {
            get { return _salaOperatoria; }
            set { _salaOperatoria = value; }
        }

        public DateTime DallaData
        {
            get { return _dallaData; }
            set { _dallaData = value; }
        }

        public DateTime AllaData
        {
            get { return _allaData; }
            set { _allaData = value; }
        }

    }
}
