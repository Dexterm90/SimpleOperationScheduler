using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Persistence;
using ClinicaPrivata.Model;

namespace ClinicaPrivata.View
{
    public partial class ConfermaDialog : Form
    {
        public ConfermaDialog()
        {
            InitializeComponent();
        }


        private void _noButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _siButton_Click(object sender, EventArgs e)
        {
            IDocumentoPersister persister = new DocumentoPersister("../../xmls/Pazienti.xml", "../../xmls/Dipendenti.xml", "../../xmls/Interventi.xml", "../../xmls/SaleOperatorie.xml", "../../xmls/TipologieIntervento.xml", "../../xmls/Specializzazioni.xml");
            persister.Save(Documento.GetInstance());
            Application.Exit();
        }

        private void ConfermaDialog_Load(object sender, EventArgs e)
        {

        }

    }
}
