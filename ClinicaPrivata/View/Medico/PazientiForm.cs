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
    public partial class PazientiForm : Form
    {
        public PazientiForm()
        {
            InitializeComponent();
        }

        private void PazientiForm_Load(object sender, EventArgs e)
        {
            Controller.GetInstance().PazientiHelper.SetAll(_grid);
            _grid.Dock = DockStyle.Fill;
        }

        private void _grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            Object o = _grid.Rows[riga].Cells[0].Value;
            InfoPazienteForm infoPaziente = new InfoPazienteForm(o);
            Controller.GetInstance().PazientiHelper.SetInfoPaziente(infoPaziente, o);

            infoPaziente.ShowDialog();
        }
    }
}
