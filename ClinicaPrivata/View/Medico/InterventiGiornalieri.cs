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
    public partial class InterventiGiornalieri : Form
    {   
        //12/09/12
        private int _giorno = 12, _mese = 9, _anno = 2012;

        public InterventiGiornalieri(int giorno, int mese, int anno)
        {
            _giorno = giorno;
            _mese = mese;
            _anno = anno;

            InitializeComponent();
        }

        private void InterventiGiornalieri_Load(object sender, EventArgs e)
        {
            DataGridView interventiGrid = new DataGridView();
            interventiGrid.BackgroundColor = Color.White;
            interventiGrid.Dock = DockStyle.Fill;
            interventiGrid.AutoSize = true;
            interventiGrid.ReadOnly = true;
            interventiGrid.RowHeadersWidth = 70;

            //Rows
            interventiGrid.RowCount = 8;
            for (int i = 1; i <= interventiGrid.Rows.Count; i++)
            {
                interventiGrid.Rows[i-1].HeaderCell.Value = (i+8) + "-" + (i+9);
            }

            //Columns
            DateTime dateTime = new DateTime(_anno, _mese, _giorno);
            InterventiManager.EditSaleOperatorie(dateTime, interventiGrid);
            InterventiManager.EditInterventi(dateTime, interventiGrid);

            this.Controls.Add(interventiGrid);
        }
    }
}
