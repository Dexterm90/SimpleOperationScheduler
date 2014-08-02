using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.View.Segretario
{
    public partial class PrenotaInterventoForm : Form
    {
        private PrenotaInterventi _helper = Controller.GetInstance().PrenotaInterventiHelper;

        public PrenotaInterventoForm()
        {
            InitializeComponent();
        }

        private void PrenotaInterventoForm_Load(object sender, EventArgs e)
        {
            _helper.setPazienti(_pazientiComboBox);
            _helper.setTipologia(_tipologiaComboBox);

            _pazientiComboBox.SelectedIndex = 0;
            _tipologiaComboBox.SelectedIndex = 0;
        }

        private void _prenotaInterventoButton_Click(object sender, EventArgs e)
        {
            _helper.prenotaIntervento(_pazientiComboBox.SelectedItem, _tipologiaComboBox.SelectedItem, _dateTimePicker.Value, _resultLabel );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
