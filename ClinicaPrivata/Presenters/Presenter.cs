using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Model;
using ClinicaPrivata.View.Segretario;
using ClinicaPrivata.View.Medico;
using ClinicaPrivata.View.Segretario.Amministratore;
using System.Windows.Forms;
using ClinicaPrivata.View;
using System.Reflection;
using System.Collections;
using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace ClinicaPrivata.Presenter
{
    class Controller
    {
        private static Controller instance = null;

        private Dipendente _dipendenteLoggato;

        private PazientiHelper _pazientiHelper = new PazientiHelper();
        private SaleHelper _saleHelper = new SaleHelper();
        private TipologieInterventoHelper _tipologieHelper = new TipologieInterventoHelper();
        private InterventiHelper _interventiHelper = new InterventiHelper();
        private MediciHelper _mediciHelper = new MediciHelper();
        private SegretariHelper _segretariHelper = new SegretariHelper();

        private PrenotaInterventi _prenotaInterventiHelper = new PrenotaInterventi();

        private DateTime _dataInizioRicerca;
        private DateTime _dataFineRicerca;

        public DateTime DataFineRicerca
        {
            get { return _dataFineRicerca; }
            set { _dataFineRicerca = value; }
        }
        

        public DateTime DataInizioRicerca
        {
            get { return _dataInizioRicerca; }
            set { _dataInizioRicerca = value; }
        }

        public void setToBeSaved()
        {
            Documento.GetInstance().setToBeSaved();
        }
        

        internal Dipendente DipendenteLoggato
        {
            get { return _dipendenteLoggato; }
            set { _dipendenteLoggato = value; }
        }

        internal MediciHelper MediciHelper
        {
            get { return _mediciHelper; }
        }

        internal InterventiHelper InterventiHelper
        {
            get { return _interventiHelper; }
        }

        internal TipologieInterventoHelper TipologieHelper
        {
            get { return _tipologieHelper; }
        }

        internal SaleHelper SaleHelper
        {
            get { return _saleHelper; }
        }

        internal PazientiHelper PazientiHelper
        {
            get { return _pazientiHelper; }
        }

        internal PrenotaInterventi PrenotaInterventiHelper
        {
            get { return _prenotaInterventiHelper; }
        }

        internal SegretariHelper SegretariHelper
        {
            get { return _segretariHelper; }
        }


        public static Controller GetInstance()
        {
            if (instance == null)
                instance = new Controller();
            return instance;
        }

        public bool login(string username, string password)
        {
            Dipendente d = GestoreLogin.ValidaLogin(username, password);
            if (d == null)
                return false;
            else
            {
                _dipendenteLoggato = d;
                return true;
            }
        }

        public void SetView()
        {
            GestoreLogin.SetView(_dipendenteLoggato);
        }

        public void SalvaModificheEsitoNote(object o, string esito, string note)
        {
            Intervento i = (Intervento)o;

            ((StatoInterventoPassato)i.StatoIntervento).Esito = esito;
            ((StatoInterventoPassato)i.StatoIntervento).Note = note;
            Controller.GetInstance().setToBeSaved();
        }

        public void Edit(Object o, Control contenitore)
        {
            Type type = o.GetType();

            /*EditableAtttribute*/
            EditingControl editingcontrol = new EditingControl();
            if (editingcontrol.SetEditableObject(o) > 0)
            {
                contenitore.Controls.Add(editingcontrol);
                editingcontrol.Dock = DockStyle.Fill;
            }

            /*NotYetEditable*/
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                NotYetEditableAttribute[] attributes = (NotYetEditableAttribute[])propertyInfo.GetCustomAttributes(typeof(NotYetEditableAttribute), false);
                if (attributes.Length == 0)
                    continue;
                if (!propertyInfo.CanRead)
                    throw new ApplicationException("L'attributo Editable non può essere applicato a proprietà write-only");

                CustomGroupBox groupBox = new CustomGroupBox();
                groupBox.Text = attributes[0].Title;
                groupBox.AutoSize = true;
                contenitore.Controls.Add(groupBox);

                this.Edit(propertyInfo.GetValue(o, null), groupBox);
            }


            /*EditableEnumerableAttribute*/
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                EditableEnumerableAttribute[] attributes = (EditableEnumerableAttribute[])propertyInfo.GetCustomAttributes(typeof(EditableEnumerableAttribute), false);
                if (attributes.Length == 0)
                    continue;
                if (!propertyInfo.CanRead)
                    throw new ApplicationException("L'attributo Editable non può essere applicato a proprietà write-only");

                IEnumerable enumerable = (IEnumerable)propertyInfo.GetValue(o, null);

                CustomGroupBox groupBox = new CustomGroupBox();
                groupBox.Text = attributes[0].Title;
                groupBox.AutoSize = true;
                contenitore.Controls.Add(groupBox);

                foreach(Object e in enumerable)
                {
                    this.Edit(e, groupBox);
                }
            }
        }
    }

    


    

    static class GestoreLogin
    {
        //ritorna l'istanza di dipendente se ok
        //altrimenti ritorna null
        public static Dipendente ValidaLogin(string username, string password)
        {
            foreach (Dipendente d in Documento.GetInstance().Dipendenti)
            {
                if (d.Username.Equals(username))
                {
                    if (d.Password.Equals(password))
                        return d;
                    else
                        return null;
                }
            }

            return null;
        }

        public static void SetView(Dipendente d)
        {
            if (d.GetType().Equals(Type.GetType("ClinicaPrivata.Model.Segretario")))
            {
                new SegretarioMainForm().Show();
            }

            if (d.GetType().Equals(Type.GetType("ClinicaPrivata.Model.Amministratore")))
            {
                SegretarioMainForm segretarioMainForm = new SegretarioMainForm();

                Button gestioneDipendentiButton = new Button();
                gestioneDipendentiButton.Text = "Gestione Dipendenti";
                gestioneDipendentiButton.Dock = DockStyle.Bottom;
                gestioneDipendentiButton.Height = 75;
                gestioneDipendentiButton.Width = 345;
               
                gestioneDipendentiButton.Click += clickGestioneDipendentiButton;

                segretarioMainForm.AutoScroll = true;

                segretarioMainForm.Panel.Controls.Add(gestioneDipendentiButton);
                segretarioMainForm.Panel.Height += 80;

                segretarioMainForm.Height += 80;

                segretarioMainForm.Show();
            }

            if (d.GetType().Equals(Type.GetType("ClinicaPrivata.Model.Medico")))
            {
                new MedicoMainForm().Show();
            }

        }

        private static void clickGestioneDipendentiButton(Object sender, EventArgs args)
        {
            new GestioneDipendentiForm().ShowDialog();
        }
    }
}
