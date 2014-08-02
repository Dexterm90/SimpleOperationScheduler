using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaPrivata.Model.Factory
{
    class TipologiaInterventoFactory
    {
        private static Documento _doc = Documento.GetInstance();

        public static TipologiaIntervento getTipologia(int idTipologia)
        {
            foreach (TipologiaIntervento t in _doc.TipologieIntervento)
                if (t.Id.Equals(idTipologia))
                    return t;

            return null;
        }
    }
}
