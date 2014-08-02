namespace ClinicaPrivata.View
{
    partial class InterventiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this._gridInterventi = new System.Windows.Forms.DataGridView();
            this.Interventi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this._salaOperatoriaTextBox = new System.Windows.Forms.TextBox();
            this._statoInterventoGroupBox = new System.Windows.Forms.GroupBox();
            this._buttonSalva = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._esitoTextBox = new System.Windows.Forms.TextBox();
            this._noteTextBox = new System.Windows.Forms.TextBox();
            this._tipologiaGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._descrizioneTipologiaTextBox = new System.Windows.Forms.TextBox();
            this._durataTipologiaTextBox = new System.Windows.Forms.TextBox();
            this._pazienteGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._nomeTextBox = new System.Windows.Forms.TextBox();
            this._cognomeTextBox = new System.Windows.Forms.TextBox();
            this._dataTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridInterventi)).BeginInit();
            this._statoInterventoGroupBox.SuspendLayout();
            this._tipologiaGroupBox.SuspendLayout();
            this._pazienteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _splitContainer
            // 
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.Controls.Add(this._gridInterventi);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this.label8);
            this._splitContainer.Panel2.Controls.Add(this._salaOperatoriaTextBox);
            this._splitContainer.Panel2.Controls.Add(this._statoInterventoGroupBox);
            this._splitContainer.Panel2.Controls.Add(this._tipologiaGroupBox);
            this._splitContainer.Panel2.Controls.Add(this._pazienteGroupBox);
            this._splitContainer.Panel2.Controls.Add(this._dataTextBox);
            this._splitContainer.Panel2.Controls.Add(this.label1);
            this._splitContainer.Size = new System.Drawing.Size(524, 433);
            this._splitContainer.SplitterDistance = 174;
            this._splitContainer.TabIndex = 0;
            // 
            // _gridInterventi
            // 
            this._gridInterventi.AllowUserToAddRows = false;
            this._gridInterventi.AllowUserToDeleteRows = false;
            this._gridInterventi.AllowUserToResizeColumns = false;
            this._gridInterventi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridInterventi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this._gridInterventi.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._gridInterventi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._gridInterventi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gridInterventi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Interventi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._gridInterventi.DefaultCellStyle = dataGridViewCellStyle3;
            this._gridInterventi.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridInterventi.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._gridInterventi.Location = new System.Drawing.Point(0, 0);
            this._gridInterventi.Name = "_gridInterventi";
            this._gridInterventi.ReadOnly = true;
            this._gridInterventi.RowHeadersVisible = false;
            this._gridInterventi.Size = new System.Drawing.Size(174, 433);
            this._gridInterventi.TabIndex = 1;
            this._gridInterventi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._gridInterventi_CellContentClick);
            // 
            // Interventi
            // 
            this.Interventi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Interventi.HeaderText = "Interventi";
            this.Interventi.Name = "Interventi";
            this.Interventi.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "SalaOperatoria";
            this.label8.Visible = false;
            // 
            // _salaOperatoriaTextBox
            // 
            this._salaOperatoriaTextBox.Location = new System.Drawing.Point(164, 70);
            this._salaOperatoriaTextBox.Name = "_salaOperatoriaTextBox";
            this._salaOperatoriaTextBox.ReadOnly = true;
            this._salaOperatoriaTextBox.Size = new System.Drawing.Size(164, 20);
            this._salaOperatoriaTextBox.TabIndex = 8;
            this._salaOperatoriaTextBox.Visible = false;
            // 
            // _statoInterventoGroupBox
            // 
            this._statoInterventoGroupBox.Controls.Add(this._buttonSalva);
            this._statoInterventoGroupBox.Controls.Add(this.label6);
            this._statoInterventoGroupBox.Controls.Add(this.label7);
            this._statoInterventoGroupBox.Controls.Add(this._esitoTextBox);
            this._statoInterventoGroupBox.Controls.Add(this._noteTextBox);
            this._statoInterventoGroupBox.Location = new System.Drawing.Point(14, 321);
            this._statoInterventoGroupBox.Name = "_statoInterventoGroupBox";
            this._statoInterventoGroupBox.Size = new System.Drawing.Size(320, 100);
            this._statoInterventoGroupBox.TabIndex = 7;
            this._statoInterventoGroupBox.TabStop = false;
            this._statoInterventoGroupBox.Visible = false;
            // 
            // _buttonSalva
            // 
            this._buttonSalva.Location = new System.Drawing.Point(101, 71);
            this._buttonSalva.Name = "_buttonSalva";
            this._buttonSalva.Size = new System.Drawing.Size(112, 23);
            this._buttonSalva.TabIndex = 8;
            this._buttonSalva.Text = "Salva modifiche";
            this._buttonSalva.UseVisualStyleBackColor = true;
            this._buttonSalva.Visible = false;
            this._buttonSalva.Click += new System.EventHandler(this._buttonSalva_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Esito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Note";
            // 
            // _esitoTextBox
            // 
            this._esitoTextBox.Location = new System.Drawing.Point(150, 19);
            this._esitoTextBox.Name = "_esitoTextBox";
            this._esitoTextBox.ReadOnly = true;
            this._esitoTextBox.Size = new System.Drawing.Size(164, 20);
            this._esitoTextBox.TabIndex = 2;
            // 
            // _noteTextBox
            // 
            this._noteTextBox.Location = new System.Drawing.Point(150, 45);
            this._noteTextBox.Name = "_noteTextBox";
            this._noteTextBox.ReadOnly = true;
            this._noteTextBox.Size = new System.Drawing.Size(164, 20);
            this._noteTextBox.TabIndex = 3;
            // 
            // _tipologiaGroupBox
            // 
            this._tipologiaGroupBox.Controls.Add(this.label4);
            this._tipologiaGroupBox.Controls.Add(this.label5);
            this._tipologiaGroupBox.Controls.Add(this._descrizioneTipologiaTextBox);
            this._tipologiaGroupBox.Controls.Add(this._durataTipologiaTextBox);
            this._tipologiaGroupBox.Location = new System.Drawing.Point(14, 215);
            this._tipologiaGroupBox.Name = "_tipologiaGroupBox";
            this._tipologiaGroupBox.Size = new System.Drawing.Size(320, 100);
            this._tipologiaGroupBox.TabIndex = 6;
            this._tipologiaGroupBox.TabStop = false;
            this._tipologiaGroupBox.Text = "Tipologia intervento";
            this._tipologiaGroupBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrizione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Durata";
            // 
            // _descrizioneTipologiaTextBox
            // 
            this._descrizioneTipologiaTextBox.Location = new System.Drawing.Point(150, 19);
            this._descrizioneTipologiaTextBox.Name = "_descrizioneTipologiaTextBox";
            this._descrizioneTipologiaTextBox.ReadOnly = true;
            this._descrizioneTipologiaTextBox.Size = new System.Drawing.Size(164, 20);
            this._descrizioneTipologiaTextBox.TabIndex = 2;
            // 
            // _durataTipologiaTextBox
            // 
            this._durataTipologiaTextBox.Location = new System.Drawing.Point(150, 58);
            this._durataTipologiaTextBox.Name = "_durataTipologiaTextBox";
            this._durataTipologiaTextBox.ReadOnly = true;
            this._durataTipologiaTextBox.Size = new System.Drawing.Size(164, 20);
            this._durataTipologiaTextBox.TabIndex = 3;
            // 
            // _pazienteGroupBox
            // 
            this._pazienteGroupBox.Controls.Add(this.label2);
            this._pazienteGroupBox.Controls.Add(this.label3);
            this._pazienteGroupBox.Controls.Add(this._nomeTextBox);
            this._pazienteGroupBox.Controls.Add(this._cognomeTextBox);
            this._pazienteGroupBox.Location = new System.Drawing.Point(14, 109);
            this._pazienteGroupBox.Name = "_pazienteGroupBox";
            this._pazienteGroupBox.Size = new System.Drawing.Size(320, 100);
            this._pazienteGroupBox.TabIndex = 5;
            this._pazienteGroupBox.TabStop = false;
            this._pazienteGroupBox.Text = "Paziente";
            this._pazienteGroupBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cognome";
            // 
            // _nomeTextBox
            // 
            this._nomeTextBox.Location = new System.Drawing.Point(150, 19);
            this._nomeTextBox.Name = "_nomeTextBox";
            this._nomeTextBox.ReadOnly = true;
            this._nomeTextBox.Size = new System.Drawing.Size(164, 20);
            this._nomeTextBox.TabIndex = 2;
            // 
            // _cognomeTextBox
            // 
            this._cognomeTextBox.Location = new System.Drawing.Point(150, 58);
            this._cognomeTextBox.Name = "_cognomeTextBox";
            this._cognomeTextBox.ReadOnly = true;
            this._cognomeTextBox.Size = new System.Drawing.Size(164, 20);
            this._cognomeTextBox.TabIndex = 3;
            // 
            // _dataTextBox
            // 
            this._dataTextBox.Location = new System.Drawing.Point(164, 33);
            this._dataTextBox.Name = "_dataTextBox";
            this._dataTextBox.ReadOnly = true;
            this._dataTextBox.Size = new System.Drawing.Size(164, 20);
            this._dataTextBox.TabIndex = 1;
            this._dataTextBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            this.label1.Visible = false;
            // 
            // InterventiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 433);
            this.Controls.Add(this._splitContainer);
            this.Name = "InterventiForm";
            this.Text = "Interventi";
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel2.ResumeLayout(false);
            this._splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._gridInterventi)).EndInit();
            this._statoInterventoGroupBox.ResumeLayout(false);
            this._statoInterventoGroupBox.PerformLayout();
            this._tipologiaGroupBox.ResumeLayout(false);
            this._tipologiaGroupBox.PerformLayout();
            this._pazienteGroupBox.ResumeLayout(false);
            this._pazienteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _splitContainer;

        public System.Windows.Forms.SplitContainer SplitContainer
        {
            get { return _splitContainer; }
            set { _splitContainer = value; }
        }
        private System.Windows.Forms.DataGridView _gridInterventi;

        public System.Windows.Forms.DataGridView GridInterventi
        {
            get { return _gridInterventi; }
            set { _gridInterventi = value; }
        }
        private System.Windows.Forms.DataGridViewTextBoxColumn Interventi;
        private System.Windows.Forms.TextBox _cognomeTextBox;

        public System.Windows.Forms.TextBox CognomeTextBox
        {
            get { return _cognomeTextBox; }
            set { _cognomeTextBox = value; }
        }
        private System.Windows.Forms.TextBox _nomeTextBox;

        public System.Windows.Forms.TextBox NomeTextBox
        {
            get { return _nomeTextBox; }
            set { _nomeTextBox = value; }
        }
        private System.Windows.Forms.TextBox _dataTextBox;

        public System.Windows.Forms.TextBox DataTextBox
        {
            get { return _dataTextBox; }
            set { _dataTextBox = value; }
        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox _pazienteGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox _statoInterventoGroupBox;

        public System.Windows.Forms.GroupBox StatoInterventoGroupBox
        {
            get { return _statoInterventoGroupBox; }
            set { _statoInterventoGroupBox = value; }
        }
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _esitoTextBox;

        public System.Windows.Forms.TextBox EsitoTextBox
        {
            get { return _esitoTextBox; }
            set { _esitoTextBox = value; }
        }
        private System.Windows.Forms.TextBox _noteTextBox;

        public System.Windows.Forms.TextBox NoteTextBox
        {
            get { return _noteTextBox; }
            set { _noteTextBox = value; }
        }
        private System.Windows.Forms.GroupBox _tipologiaGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _descrizioneTipologiaTextBox;

        public System.Windows.Forms.TextBox DescrizioneTipologiaTextBox
        {
            get { return _descrizioneTipologiaTextBox; }
            set { _descrizioneTipologiaTextBox = value; }
        }
        private System.Windows.Forms.TextBox _durataTipologiaTextBox;

        public System.Windows.Forms.TextBox DurataTipologiaTextBox
        {
            get { return _durataTipologiaTextBox; }
            set { _durataTipologiaTextBox = value; }
        }
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _salaOperatoriaTextBox;
        private System.Windows.Forms.Button _buttonSalva;

        public System.Windows.Forms.Button ButtonSalva
        {
            get { return _buttonSalva; }
            set { _buttonSalva = value; }
        }

        public System.Windows.Forms.TextBox SalaOperatoriaTextBox
        {
            get { return _salaOperatoriaTextBox; }
            set { _salaOperatoriaTextBox = value; }
        }
    }
}