using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;
using System.Drawing;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.View
{
    public partial class EditingControl : UserControl
    {
        //  Oggetto da modificare.
        private object _editingObject = null;
        //  Contiene i valori iniziali delle proprietà dell’oggetto.
        private readonly Dictionary<PropertyInfo, object> _originalValues = new Dictionary<PropertyInfo, object>();
        //  Numero corrente di errori di validazione.
        private int _errorCounter = 0;

        //  Scatta quando cambia il valore di HasChanged.
        public event EventHandler HasErrorChanged;

        public EditingControl()
        {
            InitializeComponent();

        }

        //  Restituisce true se ci sono errori di validazione.
        public bool HasError
        {
            get
            {
                #region ----- TODO -----

                return (_errorCounter > 0);

                #endregion
            }
        }

        //  Associa all'EditingControl l'oggetto da modificare.
        //  Deve poter essere invocato più volte.
        //  Aggiunge all’EditingControl una coppia di controlli (Label, TextBox) per ogni proprietà 'editable' di editingObject
        //ritorna il numero di proprietà editate
        public int SetEditableObject(object editingObject)
        {
            //	Memorizzare in _editingObject l’oggetto da modificare.
            //	Eliminare da _originalValues eventuali valori originali inseriti in precedenza.
            //  Resettare il contatore degli errori di validazione.
            //	Eliminare da _tableLayoutPanel eventuali controlli inseriti in precedenza.
            //	Per ogni proprietà pubblica di _editingObject alla quale è stato associato l’attributo Editable:
            //    se la proprietà è write-only, sollevare un’eccezione;
            //    se la proprietà è writable, salvare nel dizionario _originalValues il valore originale della proprietà,
            //      utilizzando come chiave il descrittore della proprietà;
            //    invocare il metodo AddRow passando come argomenti l’attributo Editable associato alla proprietà e il descrittore della proprietà.
            //	Invocare il metodo RefreshTextBoxes in modo che vengano aggiornati i valori di tutte le TextBox.

            #region ----- TODO -----


            int result = 0;

            if (editingObject == null)
                throw new ArgumentNullException("editingObject");
            SuspendLayout();

            _editingObject = editingObject;
            _originalValues.Clear();
            _errorCounter = 0;
            _tableLayoutPanel.Controls.Clear();

            //Memorizza i valori iniziali
            Type type = _editingObject.GetType();
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                EditableAttribute[] attributes = (EditableAttribute[])propertyInfo.GetCustomAttributes(typeof(EditableAttribute), false);
                if (attributes.Length == 0)
                    continue;
                if (!propertyInfo.CanRead)
                    throw new ApplicationException("L'attributo Editable non può essere applicato a proprietà write-only");

                //Memorizza solo i valori originali che possono essere sovrascritti
                if (propertyInfo.CanWrite)
                {
                    _originalValues.Add(propertyInfo, propertyInfo.GetValue(_editingObject, null));
                }

                AddRow(attributes[0], propertyInfo);
                result++;
            }

            //Inserisce i valori di default
            RefreshTextBoxes(null);

            ResumeLayout(false);

            return result;

            #endregion
        }

        //  Effettua il rollback dei valori inseriti, reimpostando i valori originali (contenuti in _originalValues).
        //  Viene utilizzata dalla EditingDialog in due situazioni diverse:
        //  - Reset - solo nel caso di modifica o inserimento di oggetti con stato iniziale valido (senza errori nei valori delle proprietà);
        //  - Cancel - sia nel caso di modifiche di oggetti esistenti, sia nel caso di inserimento di nuovi oggetti.
        //  Nel caso di modifica di un oggetto esistente, lo stato iniziale è sempre valido.
        //  Nel caso di inserimento di un nuovo oggetto, lo stato iniziale NON è necessariamente valido.
        public void ResetEditingObject()
        {
            //  Prima, ricopiare tutti i valori originali nelle corrispondenti proprietà dell'_editingObject.
            //    ATTENZIONE: nel caso di inserimento di un nuovo oggetto, alcuni valori iniziali potrebbero non essere validi
            //    pertanto, occorre eseguire la copia di ogni valore originale in modo che non venga scatenata alcuna eccezione.
            //  Quindi, invocare il metodo RefreshTextBoxes in modo che vengano aggiornati i valori di tutte le TextBox.

            #region ----- TODO -----

            foreach (KeyValuePair<PropertyInfo, object> entry in _originalValues)
            {
                try
                {
                    PropertyInfo propertyInfo = entry.Key;
                    propertyInfo.SetValue(_editingObject, entry.Value, null);
                }
                catch
                {
                }
            }
            RefreshTextBoxes(null);

            #endregion
        }

        //  Crea, inizializza e aggiunge al _tableLayoutPanel nell’ordine: una Label e una TextBox.
        private void AddRow(EditableAttribute editableAttribute, PropertyInfo propertyInfo)
        {
            //  Per inizializzare la Label:
            // 	  assegnare alla proprietà Text il valore della proprietà Label di editableAttribute; 
            // 	  assegnare alla proprietà AutoSize il valore true, in modo che il testo venga visualizzato correttamente.
            //  Per inizializzare la TextBox:
            // 	  dimensionare il controllo in modo che
            //      la larghezza sia pari al valore della proprietà Width di editableAttribute e
            //      l’altezza sia pari al valore della proprietà PreferredHeight del controllo stesso;
            // 	  se la proprietà di _editingObject descritta da propertyInfo è read-only,
            //      disabilitare la TextBox (utilizzare la proprietà Enabled);
            // 	  assegnare alla proprietà Tag il valore di propertyInfo;
            // 	  infine, collegare all’evento Validating della TextBox il gestore ValidatingHandler.

            #region ----- TODO -----

            Label label = new Label();
            label.Text = editableAttribute.Label;
            label.AutoSize = true;
            _tableLayoutPanel.Controls.Add(label);

            TextBox textBox = new TextBox();
            textBox.Size = new Size(editableAttribute.Width, textBox.PreferredHeight);
            textBox.Enabled = propertyInfo.CanWrite;
            textBox.Tag = propertyInfo;
            textBox.Validating += new CancelEventHandler(ValidatingHandler);
            _tableLayoutPanel.Controls.Add(textBox);

            #endregion
        }

        //  Inserisce nelle TextBox i valori delle corrispondenti proprietà di _editingObject.
        private void RefreshTextBoxes(TextBox excludedTextBox)
        {
            //  Per ogni textBox contenuta in _tableLayoutPanel, ad esclusione di excludedTextBox:
            //	  recuperare la propertyInfo precedentemente salvata nella proprietà Tag di textBox;
            //	  recuperare il valore contenuto in _editingObject della proprietà descritta da propertyInfo;
            //    assegnare il valore recuperato alla proprietà Text di textBox (se il valore è null, assegnare a Text una stringa vuota);
            //	  infine, se la proprietà descritta da propertyInfo è writable, invocare il metodo Validate passando come argomento textBox.

            #region ----- TODO -----

            foreach (Control control in _tableLayoutPanel.Controls)
            {
                if (control is TextBox && control != excludedTextBox)
                {
                    TextBox textBox = (TextBox)control;
                    PropertyInfo propertyInfo = (PropertyInfo)textBox.Tag;
                    object value = propertyInfo.GetValue(_editingObject, null);
                    textBox.Text = value != null ? value.ToString() : "";
                    if (propertyInfo.CanWrite)
                        Validate(textBox);
                }
            }

            #endregion
        }

        //  Viene invocato automaticamente quando una TextBox perde il focus
        //  Coordina la validazione del dato inserito nella TextBox (il sender).
        private void ValidatingHandler(object sender, CancelEventArgs args)
        {
            //  Invocare il metodo Validate passando come argomento il sender.
            //  Se non ci sono errori di validazione, invocare il metodo RefreshTextBoxes passando come argomento il sender.
            //  Si noti che l’invocazione finale del metodo RefreshTextBoxes permette di visualizzare correttamente
            //  i valori di eventuali proprietà calcolabili (cioè che si basano sui valori di altre proprietà).

            #region ----- TODO -----

            TextBox textBox = (TextBox)sender;
            Validate(textBox);
            if (!HasError)
            {
                RefreshTextBoxes(textBox);
            }

            #endregion
        }

        //  Esegue la validazione vera e propria del dato contenuto nella textBox passata come argomento.
        //  Per validare un dato, occorre ‘tentare’ di assegnare il dato alla corrispondente proprietà di _editingObject e
        //  intercettare un’eventuale eccezione.
        private void Validate(TextBox textBox)
        {
            try
            {
                // 	Recuperare la propertyInfo dalla textBox;
                // 	Convertire il valore visualizzato nella textBox (sempre di tipo string)
                //    in un valore (newValue) del tipo della proprietà descritta da propertyInfo (ad es. un int o un double);
                //    per effettuare tutte le possibili conversioni in modo semplice, utilizzare il metodo Convert.ChangeType;
                // 	Assegnare newValue alla proprietà di _editingObject descritta da propertyInfo;
                //  Infine, invocare il metodo SetError in modo da segnalare all'utente che la textBox è senza errori.

                #region ----- TODO -----

                PropertyInfo propertyInfo = (PropertyInfo)textBox.Tag;
                object newValue = Convert.ChangeType(textBox.Text, propertyInfo.PropertyType);
                propertyInfo.SetValue(_editingObject, newValue, null);
                Controller.GetInstance().setToBeSaved();
                SetError(textBox, null);

                #endregion

            }
            catch (Exception exception)
            {
                while (exception.InnerException != null)
                    exception = exception.InnerException;
                SetError(textBox, exception.Message);
            }
        }

        //  Mediante _errorProvider associa a textBox il messaggio newMessage.
        //  Se newMessage è null o "", il valore visualizzato nella textBox è valido;
        //    in caso contrario, il valore NON è valido e newMessage contiene il testo dell'eccezione (exception.Message).
        //  Se necessario, deve aggiornare il contatore degli errori di validazione,
        //  Se necessario, deve scatenare l'evento HasErrorChanged.
        private void SetError(TextBox textBox, string newMessage)
        {
            #region ----- TODO -----

            string previousMessage = _errorProvider.GetError(textBox);
            _errorProvider.SetError(textBox, newMessage);
            if (String.IsNullOrEmpty(previousMessage))
            {
                if (!String.IsNullOrEmpty(newMessage))
                {
                    _errorCounter++;
                    if (_errorCounter == 1)
                        OnHasErrorChanged();
                }
            }
            else
            {
                if (String.IsNullOrEmpty(newMessage))
                {
                    _errorCounter--;
                    if (_errorCounter == 0)
                        OnHasErrorChanged();
                }
            }

            #endregion
        }

        //  Scatena l'evento HasErrorChanged.
        protected virtual void OnHasErrorChanged()
        {
            #region ----- TODO -----

            if (HasErrorChanged != null)
                HasErrorChanged(this, EventArgs.Empty);

            #endregion
        }

        private void EditingControl_Load(object sender, EventArgs e)
        {

        }

    }
}
