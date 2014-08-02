namespace ClinicaPrivata.View.Medico
{
    partial class CartellaClinicaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._patologieTextBox = new System.Windows.Forms.TextBox();
            this._allergieTextBox = new System.Windows.Forms.TextBox();
            this._rhTextBox = new System.Windows.Forms.TextBox();
            this._gruppoSanguignoTextBox = new System.Windows.Forms.TextBox();
            this._interventiComboBox = new System.Windows.Forms.ComboBox();
            this._interventoPanel = new System.Windows.Forms.Panel();
            this._splitContainer = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._noteTextBox = new System.Windows.Forms.TextBox();
            this._esitoTextBox = new System.Windows.Forms.TextBox();
            this._tipologiaTextBox = new System.Windows.Forms.TextBox();
            this._dataTextBox = new System.Windows.Forms.TextBox();
            this._interventoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).BeginInit();
            this._splitContainer.Panel1.SuspendLayout();
            this._splitContainer.Panel2.SuspendLayout();
            this._splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patologie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Allergie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gruppo Sanguigno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fattore Rh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Interventi";
            // 
            // _patologieTextBox
            // 
            this._patologieTextBox.Location = new System.Drawing.Point(193, 27);
            this._patologieTextBox.Name = "_patologieTextBox";
            this._patologieTextBox.ReadOnly = true;
            this._patologieTextBox.Size = new System.Drawing.Size(252, 20);
            this._patologieTextBox.TabIndex = 6;
            // 
            // _allergieTextBox
            // 
            this._allergieTextBox.Location = new System.Drawing.Point(193, 74);
            this._allergieTextBox.Name = "_allergieTextBox";
            this._allergieTextBox.ReadOnly = true;
            this._allergieTextBox.Size = new System.Drawing.Size(252, 20);
            this._allergieTextBox.TabIndex = 7;
            // 
            // _rhTextBox
            // 
            this._rhTextBox.Location = new System.Drawing.Point(193, 119);
            this._rhTextBox.Name = "_rhTextBox";
            this._rhTextBox.ReadOnly = true;
            this._rhTextBox.Size = new System.Drawing.Size(252, 20);
            this._rhTextBox.TabIndex = 8;
            // 
            // _gruppoSanguignoTextBox
            // 
            this._gruppoSanguignoTextBox.Location = new System.Drawing.Point(193, 162);
            this._gruppoSanguignoTextBox.Name = "_gruppoSanguignoTextBox";
            this._gruppoSanguignoTextBox.ReadOnly = true;
            this._gruppoSanguignoTextBox.Size = new System.Drawing.Size(252, 20);
            this._gruppoSanguignoTextBox.TabIndex = 9;
            // 
            // _interventiComboBox
            // 
            this._interventiComboBox.FormattingEnabled = true;
            this._interventiComboBox.Location = new System.Drawing.Point(193, 231);
            this._interventiComboBox.Name = "_interventiComboBox";
            this._interventiComboBox.Size = new System.Drawing.Size(252, 21);
            this._interventiComboBox.TabIndex = 10;
            this._interventiComboBox.SelectedIndexChanged += new System.EventHandler(this._interventiComboBox_SelectedIndexChanged);
            // 
            // _interventoPanel
            // 
            this._interventoPanel.Controls.Add(this._splitContainer);
            this._interventoPanel.Location = new System.Drawing.Point(12, 304);
            this._interventoPanel.Name = "_interventoPanel";
            this._interventoPanel.Size = new System.Drawing.Size(487, 184);
            this._interventoPanel.TabIndex = 11;
            // 
            // _splitContainer
            // 
            this._splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer.Location = new System.Drawing.Point(0, 0);
            this._splitContainer.Name = "_splitContainer";
            // 
            // _splitContainer.Panel1
            // 
            this._splitContainer.Panel1.AutoScroll = true;
            this._splitContainer.Panel1.Controls.Add(this.label10);
            this._splitContainer.Panel1.Controls.Add(this.label9);
            this._splitContainer.Panel1.Controls.Add(this.label8);
            this._splitContainer.Panel1.Controls.Add(this.label7);
            // 
            // _splitContainer.Panel2
            // 
            this._splitContainer.Panel2.Controls.Add(this._noteTextBox);
            this._splitContainer.Panel2.Controls.Add(this._esitoTextBox);
            this._splitContainer.Panel2.Controls.Add(this._tipologiaTextBox);
            this._splitContainer.Panel2.Controls.Add(this._dataTextBox);
            this._splitContainer.Size = new System.Drawing.Size(487, 184);
            this._splitContainer.SplitterDistance = 213;
            this._splitContainer.TabIndex = 0;
            this._splitContainer.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Note";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Esito";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tipologia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Data";
            // 
            // _noteTextBox
            // 
            this._noteTextBox.Location = new System.Drawing.Point(31, 137);
            this._noteTextBox.Name = "_noteTextBox";
            this._noteTextBox.ReadOnly = true;
            this._noteTextBox.Size = new System.Drawing.Size(218, 20);
            this._noteTextBox.TabIndex = 3;
            // 
            // _esitoTextBox
            // 
            this._esitoTextBox.Location = new System.Drawing.Point(31, 97);
            this._esitoTextBox.Name = "_esitoTextBox";
            this._esitoTextBox.ReadOnly = true;
            this._esitoTextBox.Size = new System.Drawing.Size(218, 20);
            this._esitoTextBox.TabIndex = 2;
            // 
            // _tipologiaTextBox
            // 
            this._tipologiaTextBox.Location = new System.Drawing.Point(31, 60);
            this._tipologiaTextBox.Name = "_tipologiaTextBox";
            this._tipologiaTextBox.ReadOnly = true;
            this._tipologiaTextBox.Size = new System.Drawing.Size(218, 20);
            this._tipologiaTextBox.TabIndex = 1;
            // 
            // _dataTextBox
            // 
            this._dataTextBox.Location = new System.Drawing.Point(31, 22);
            this._dataTextBox.Name = "_dataTextBox";
            this._dataTextBox.ReadOnly = true;
            this._dataTextBox.Size = new System.Drawing.Size(218, 20);
            this._dataTextBox.TabIndex = 0;
            // 
            // CartellaClinicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 500);
            this.Controls.Add(this._interventoPanel);
            this.Controls.Add(this._interventiComboBox);
            this.Controls.Add(this._gruppoSanguignoTextBox);
            this.Controls.Add(this._rhTextBox);
            this.Controls.Add(this._allergieTextBox);
            this.Controls.Add(this._patologieTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CartellaClinicaForm";
            this.Text = "Cartella Clinica";
            this.Load += new System.EventHandler(this.CartellaClinicaForm_Load);
            this._interventoPanel.ResumeLayout(false);
            this._splitContainer.Panel1.ResumeLayout(false);
            this._splitContainer.Panel1.PerformLayout();
            this._splitContainer.Panel2.ResumeLayout(false);
            this._splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer)).EndInit();
            this._splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _patologieTextBox;

        public System.Windows.Forms.TextBox PatologieTextBox
        {
            get { return _patologieTextBox; }
            set { _patologieTextBox = value; }
        }
        private System.Windows.Forms.TextBox _allergieTextBox;

        public System.Windows.Forms.TextBox AllergieTextBox
        {
            get { return _allergieTextBox; }
            set { _allergieTextBox = value; }
        }
        private System.Windows.Forms.TextBox _rhTextBox;

        public System.Windows.Forms.TextBox RhTextBox
        {
            get { return _rhTextBox; }
            set { _rhTextBox = value; }
        }
        private System.Windows.Forms.TextBox _gruppoSanguignoTextBox;

        public System.Windows.Forms.TextBox GruppoSanguignoTextBox
        {
            get { return _gruppoSanguignoTextBox; }
            set { _gruppoSanguignoTextBox = value; }
        }
        private System.Windows.Forms.ComboBox _interventiComboBox;

        public System.Windows.Forms.ComboBox InterventiComboBox
        {
            get { return _interventiComboBox; }
            set { _interventiComboBox = value; }
        }

        private System.Windows.Forms.Panel _interventoPanel;

        public System.Windows.Forms.Panel InterventoPanel
        {
            get { return _interventoPanel; }
            set { _interventoPanel = value; }
        }

        private System.Windows.Forms.SplitContainer _splitContainer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _noteTextBox;

        public System.Windows.Forms.TextBox NoteTextBox
        {
            get { return _noteTextBox; }
            set { _noteTextBox = value; }
        }
        private System.Windows.Forms.TextBox _esitoTextBox;

        public System.Windows.Forms.TextBox EsitoTextBox
        {
            get { return _esitoTextBox; }
            set { _esitoTextBox = value; }
        }
        private System.Windows.Forms.TextBox _tipologiaTextBox;

        public System.Windows.Forms.TextBox TipologiaTextBox
        {
            get { return _tipologiaTextBox; }
            set { _tipologiaTextBox = value; }
        }
        private System.Windows.Forms.TextBox _dataTextBox;

        public System.Windows.Forms.TextBox DataTextBox
        {
            get { return _dataTextBox; }
            set { _dataTextBox = value; }
        }

        public System.Windows.Forms.SplitContainer SplitContainer
        {
            get { return _splitContainer; }
            set { _splitContainer = value; }
        }
    }
}