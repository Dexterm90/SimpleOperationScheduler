using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Model;
using System.Windows.Forms;
using ClinicaPrivata.View;

namespace ClinicaPrivata.Presenter
{
    class SaleHelper : IViewHelper
    {
        private Documento _doc = Documento.GetInstance();

        public int SetAll(Control control)
        {
            int result = 0;
            List<SalaOperatoria> sale = _doc.SaleOperatorie;

            DataGridView grid = (DataGridView) control;

            grid.Columns.RemoveAt(0);

            DataGridViewTextBoxColumn titolo = new DataGridViewTextBoxColumn();
            titolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            titolo.HeaderText = "Sale Operatorie";
            titolo.Name = "SalaOperatorie";
            grid.Columns.AddRange(new DataGridViewColumn[] { titolo });

            foreach (SalaOperatoria sala in sale)
            {
                grid.Rows.Add(sala);
                result++;
            }



            return result;
        }

    }
}
