using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.View
{
    public partial class InterventiForm : Form
    {
        private IViewHelper _viewHelper;

        private Object _selectedObject;

        public Object SelectedObject
        {
            get { return _selectedObject; }
            set { _selectedObject = value; }
        }

        internal IViewHelper ViewHelper
        {
            get { return _viewHelper; }
            set { _viewHelper = value; }
        }

        public void SetAll()
        {
            ((InterventiHelper)_viewHelper).SetAllFuturi(_gridInterventi);
        }

        public void SetCalendario()
        {
            ((CalendarioMedicoHelper)_viewHelper).SetAll(_gridInterventi);
        }

        public void SetMedicoPassati()
        {
            ((InterventiHelper)_viewHelper).SetAllMedicoPassati(_gridInterventi);
        }

        public InterventiForm()
        {
            InitializeComponent();
        }

        private void _gridInterventi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this._dataTextBox.Visible = true;
            this._salaOperatoriaTextBox.Visible = true;
            this._pazienteGroupBox.Visible = true;
            this._tipologiaGroupBox.Visible = true;
            this.label1.Visible = true;
            this.label8.Visible = true;
            
            int riga = e.RowIndex;

            Object o = _gridInterventi.Rows[riga].Cells[0].Value;
            _selectedObject = o;

            Type type = o.GetType();

            ((InterventiHelper)_viewHelper).displayInterventoInfo(this, o);
        }

        private void _buttonSalva_Click(object sender, EventArgs e)
        {
            Object o = this.SelectedObject;
            Controller.GetInstance().SalvaModificheEsitoNote(o, this._esitoTextBox.Text, this._noteTextBox.Text);
        }
    }
}
