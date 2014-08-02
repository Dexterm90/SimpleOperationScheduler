using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Model;
using System.Windows.Forms;

namespace ClinicaPrivata.Presenter
{
    class InterventiManager
    {
        private static Documento _doc = Documento.GetInstance();

        public static List<Intervento> GetInterventi(Medico medico)
        {
            List<Intervento> res = new List<Intervento>();


            foreach (Intervento i in _doc.Interventi)
                foreach (Medico m in i.Equipe)
                    if (m.Equals(medico))
                        res.Add(i);

            return res;
        }

        public static void EditSaleOperatorie(DateTime date, DataGridView grid)
        {
            List<SalaOperatoria> sale = _doc.SaleOperatorie;

            grid.ColumnCount = sale.Count;
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].HeaderCell.Value = sale[i].ToString();
            }
        }

        public static void EditInterventi(DateTime data, DataGridView grid)
        {
            Medico medico = (Medico) Controller.GetInstance().DipendenteLoggato;
            List<Intervento> interventi = _doc.Interventi;

            ICalendario calendario = new Calendario();
            foreach (SalaOperatoria sala in _doc.SaleOperatorie)
            {
                int colonna = 0;
                for (int k = 0; k < grid.Columns.Count; k++)
                {
                    if (grid.Columns[k].HeaderCell.Value.Equals(sala.ToString()))
                    {
                        colonna = k;
                        break;
                    }
                }
                
                calendario.FiltroInterventi = FiltroBuilder.Build(medico, sala, data, data.AddHours(24));
                foreach (Intervento i in calendario.GetInterventi())
                {
                    int oraInizio = i.Data.Hour;
                    int oraFine = oraInizio + i.Tipologia.Durata;

                    //Stampa nella tabella
                    for (int k = oraInizio; k < oraFine; k++)
                        grid.Rows[k-9].Cells[colonna].Value = i;
                }
            }
        }
    }
}
