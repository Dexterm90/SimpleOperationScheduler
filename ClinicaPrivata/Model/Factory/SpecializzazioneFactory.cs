using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaPrivata.Model.Factory
{
    static class SpecializzazioneFactory
    {
        private static Documento _doc = Documento.GetInstance();

        public static Specializzazione getSpecializzazione(int idSpecializzazione)
        {
            foreach (Specializzazione s in _doc.Specializzazioni)
                if (s.Id.Equals(idSpecializzazione))
                    return s;

            return null;
        }
    }
}
