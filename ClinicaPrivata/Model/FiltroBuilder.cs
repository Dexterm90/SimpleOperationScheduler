using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaPrivata.Model
{
    static class FiltroBuilder
    {
        public static IFiltroInterventi Build(Medico medico = null, SalaOperatoria salaOperatoria = null,
            DateTime dallaData = default(DateTime), DateTime allaData = default(DateTime))
        {
            IFiltroInterventi filtroInterventi = FiltroBase.FiltroSuTutto;
            if (medico != null)
            {
                filtroInterventi = new FiltroPerMedico(filtroInterventi, medico);
            }
            if (salaOperatoria != null)
            {
                filtroInterventi = new FiltroPerSalaOperatoria(filtroInterventi, salaOperatoria);
            }
            if (dallaData != default(DateTime))
            {
                filtroInterventi = new FiltroDallaData(filtroInterventi, dallaData);
            }
            if (allaData != default(DateTime))
            {
                filtroInterventi = new FiltroAllaData(filtroInterventi, allaData);
            }
            else
            {
                return FiltroBase.FiltroSuNiente;
            }
            return filtroInterventi;
        }
    }
}

