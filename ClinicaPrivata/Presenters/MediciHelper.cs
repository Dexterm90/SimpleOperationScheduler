using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Model;
using System.Windows.Forms;
using ClinicaPrivata.View;
using System.Reflection;

namespace ClinicaPrivata.Presenter
{
    class MediciHelper : IViewHelper
    {
        private Documento _doc = Documento.GetInstance();

        public int SetAll(Control control)
        {
            int result = 0;
            List<Medico> medici = _doc.Medici;

            DataGridView grid = (DataGridView) control;

            grid.Columns.RemoveAt(0);

            DataGridViewTextBoxColumn titolo = new DataGridViewTextBoxColumn();
            titolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            titolo.HeaderText = "Medici";
            titolo.Name = "Medici";
            grid.Columns.AddRange(new DataGridViewColumn[] { titolo });

            foreach (Medico m in medici)
            {
                grid.Rows.Add(m);
                result++;
            }

            

            return result;
        }

    }
}
