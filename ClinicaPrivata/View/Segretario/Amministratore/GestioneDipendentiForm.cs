using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.View.Segretario.Amministratore
{
    public partial class GestioneDipendentiForm : Form
    {
        public GestioneDipendentiForm()
        {
            InitializeComponent();
        }

        private void _gestioneMediciButton_Click(object sender, EventArgs e)
        {
            GestioneForm gestione = new GestioneForm();
            gestione.ViewHelper = new MediciHelper();
            gestione.SetAll();
            gestione.ShowDialog();
        }

        private void _gestioneSegretariButton_Click(object sender, EventArgs e)
        {
            GestioneForm gestione = new GestioneForm();
            gestione.ViewHelper = new SegretariHelper();
            gestione.SetAll();
            gestione.ShowDialog();
        }
    }
}
