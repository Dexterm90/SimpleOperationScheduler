using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Presenter;
using ClinicaPrivata.Model;

namespace ClinicaPrivata.View.Segretario
{
    public partial class SegretarioMainForm : Form
    {
        public SegretarioMainForm()
        {
            InitializeComponent();
        }

        private void pazientiButton_Click(object sender, EventArgs e)
        {
            GestioneForm gestione = new GestioneForm();
            gestione.ViewHelper = new PazientiHelper();
            gestione.SetAll();
            gestione.ShowDialog();
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            GestioneForm gestione = new GestioneForm();
            gestione.ViewHelper = new SaleHelper();
            gestione.SetAll();
            gestione.ShowDialog();
        }

        private void tipologieInterventoButton_Click(object sender, EventArgs e)
        {
            GestioneForm gestione = new GestioneForm();
            gestione.ViewHelper = new TipologieInterventoHelper();
            gestione.SetAll();
            gestione.ShowDialog();
        }

        private void interventiFuturiButton_Click(object sender, EventArgs e)
        {
            InterventiForm formInterventi = new InterventiForm();
            formInterventi.ViewHelper = new InterventiHelper();
            formInterventi.SetAll();
            formInterventi.ShowDialog();
        }

        private void SegretarioMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Documento.GetInstance().needToBeSaved())
            {
                ConfermaDialog conferma = new ConfermaDialog();
                conferma.ShowDialog();
            }
            else
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PrenotaInterventoForm().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
