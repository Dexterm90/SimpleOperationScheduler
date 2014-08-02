using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClinicaPrivata.Persistence;
using ClinicaPrivata.Model;
using ClinicaPrivata.View.Segretario;
using ClinicaPrivata.View.Medico;
using ClinicaPrivata.View;

namespace ClinicaPrivata
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Documento doc = Documento.GetInstance();

            IDocumentoPersister persister = new DocumentoPersister("../../xmls/Pazienti.xml", "../../xmls/Dipendenti.xml", "../../xmls/Interventi.xml", "../../xmls/SaleOperatorie.xml", "../../xmls/TipologieIntervento.xml", "../../xmls/Specializzazioni.xml");

            doc.Load(persister);
    


            Application.Run(new LoginDialog());
        }
    }
}
