using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.View.Segretario;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.View.Medico
{
    public partial class CalendarioInterventi : Form
    {
        private int _anno;
        private int _mese;

        private Label _meseLabel;


        public CalendarioInterventi()
        {
            InitializeComponent();
        }


        private void CalendarioInterventi_Load(object sender, EventArgs e)
        {
            _anno = DateTime.Today.Year;
            _mese = DateTime.Today.Month;

            _meseLabel = new Label();
            _meseLabel.Location = new Point(380, 15);
            _meseLabel.Text = getMese(_mese) + " " + _anno;
            this.Controls.Add(_meseLabel);

            AddButtons(_anno, _mese);
        }

        private void button_Click(object sender, System.EventArgs e)
        {
            Button button = (Button) sender;

            new InterventiGiornalieri((int)button.Tag,_mese,_anno).ShowDialog();
        }

        private void _precedenteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //visualizzazione mese precedente
            setMesePrecedente();
        }

        private void _successivoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //visualizzazione mese successivo
            SetMeseSuccessivo();
        }

        private void setMesePrecedente()
        {
            if (_mese > 1)
                _mese--;
            else
            {
                _mese = 12;
                _anno--;
            }

            _meseLabel.Text = getMese(_mese) + " " + _anno;

            _meseTableLayoutPanel.Controls.Clear();

            AddButtons(_anno, _mese);
        }

        private void SetMeseSuccessivo()
        {
            if (_mese == 12)
            {
                _mese = 1;
                _anno++;
            }
            else
                _mese++;

            _meseLabel.Text = getMese(_mese) + " " + _anno;

            _meseTableLayoutPanel.Controls.Clear();

            AddButtons(_anno, _mese);
        }

        private void AddButtons(int year, int mese)
        {
            for (int i = 1; i <= DateTime.DaysInMonth(year, mese); i++)
            {
                Button b = new Button();
                b.Dock = DockStyle.Fill;
                b.Text = i.ToString();
                b.Tag = i;
                b.Click += button_Click;

                _meseTableLayoutPanel.Controls.Add(b);

            }
        }

        private string getMese(int n)
        {
            switch (n)
            {
                case 1:
                    return "Gennaio";
                case 2:
                    return "Febbraio";
                case 3:
                    return "Marzo";
                case 4:
                    return "Aprile";
                case 5:
                    return "Maggio";
                case 6:
                    return "Giugno";
                case 7:
                    return "Luglio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Settembre";
                case 10:
                    return "Ottobre";
                case 11:
                    return "Novembre";
                case 12:
                    return "Dicembre";
                default:
                    return "???";
            }
        }

        private void _calendarioPerIntervalloButton_Click(object sender, EventArgs e)
        {
            DateTime dataInizio = _inizioDateTimePicker.Value;
            DateTime dataFine = _fineDateTimePicker.Value;
            Controller.GetInstance().DataInizioRicerca = dataInizio;
            Controller.GetInstance().DataFineRicerca = dataFine;

            if (dataInizio > dataFine)
            {
                MessageBox.Show("Date non valide.");
                return;
            }

            InterventiForm gestione = new InterventiForm();
            gestione.ViewHelper = new CalendarioMedicoHelper();
            gestione.SetCalendario();
            gestione.ShowDialog();
        }

        



    }


}
