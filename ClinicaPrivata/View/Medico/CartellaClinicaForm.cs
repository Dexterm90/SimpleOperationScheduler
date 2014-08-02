using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.View.Medico
{
    public partial class CartellaClinicaForm : Form
    {
        private Object _object;

        public CartellaClinicaForm(Object o)
        {
            InitializeComponent();

            _object = o;
        }

        private void CartellaClinicaForm_Load(object sender, EventArgs e)
        {
            CartellaClinicaSetter.GetInstance().SetInfoCartellaClinica(this, _object);
        }

        private void _interventiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedObject = _interventiComboBox.SelectedItem;
            CartellaClinicaSetter.GetInstance().SetInfoIntervento(this, selectedObject);
            this._splitContainer.Visible = true;
        }
    }
}
