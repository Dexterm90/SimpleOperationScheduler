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
    public partial class InfoPazienteForm : Form
    {
        private Object _oggettoInfo;

        public InfoPazienteForm(Object oggettoInfo)
        {
            InitializeComponent();

            _oggettoInfo = oggettoInfo;
        }

        private void _cartellaClinicaButton_Click(object sender, EventArgs e)
        {
            new CartellaClinicaForm(_oggettoInfo).ShowDialog();
        }


    }
}
