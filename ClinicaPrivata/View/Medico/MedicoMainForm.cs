using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Presenter;
using ClinicaPrivata.Model;

namespace ClinicaPrivata.View.Medico
{
    public partial class MedicoMainForm : Form
    {
        private InterventiForm _interventiForm;

        public MedicoMainForm()
        {
            InitializeComponent();
        }

        private void pazientiButton_Click(object sender, EventArgs e)
        {
            PazientiForm pazientiForm = new PazientiForm();
            pazientiForm.ShowDialog();
        }

        private void _interventiPassatiButton_Click(object sender, EventArgs e)
        {
            _interventiForm = new InterventiForm();
            _interventiForm.ViewHelper = new InterventiHelper();
            _interventiForm.SetMedicoPassati();

            _interventiForm.EsitoTextBox.ReadOnly = false;
            _interventiForm.NoteTextBox.ReadOnly = false;
            _interventiForm.ButtonSalva.Visible = true;

            _interventiForm.ShowDialog();
        }


        private void calendarioInterventiButton_Click(object sender, EventArgs e)
        {
            CalendarioInterventi calendario = new CalendarioInterventi();
            calendario.ShowDialog();
        }

        private void MedicoMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Documento.GetInstance().needToBeSaved())
            {
                ConfermaDialog conferma = new ConfermaDialog();
                conferma.ShowDialog();
            }
            else
                Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MedicoMainForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


    }
}
