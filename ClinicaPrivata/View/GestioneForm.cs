using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Presenter;
using System.Reflection;
using ClinicaPrivata.Model;

namespace ClinicaPrivata.View
{
    public partial class GestioneForm : Form
    {
        private IViewHelper _viewHelper ;

        public GestioneForm()
        {
            InitializeComponent();            
        }

        internal IViewHelper ViewHelper
        {
            get { return _viewHelper; }
            set { _viewHelper = value; }
        }

        internal DataGridView Grid
        {
            get { return _grid; }
        }

        public void SetAll()
        {
            _viewHelper.SetAll(_grid);
        }


        private void _salvaButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Annulla(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (!c.GetType().Equals(Type.GetType("ClinicaPrivata.View.EditingControl")))
                    Annulla(c);
                else
                {
                    EditingControl editingControl = (EditingControl)c;
                    editingControl.ResetEditingObject();
                }
            }
        }


        private void _grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*al click su un paziente devo richiedere al presenter di 
            visualizzare a destra i suo dettagli*/

            /*gli devo passare: l'oggetto rappresentante il paziente editing control*/
            int riga = e.RowIndex;

            Object o = _grid.Rows[riga].Cells[0].Value;

            Type type = o.GetType();

            _editingPanel.Controls.Clear();

            Controller.GetInstance().Edit(o, _editingPanel);
        }



        private void _annullaModificheButton_Click_1(object sender, EventArgs e)
        {
            Annulla(_editingPanel);
        }

        private void _eliminaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non ancora implementato");
        }

        private void _aggiungiButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non ancora implementato");
        }


    }
}
