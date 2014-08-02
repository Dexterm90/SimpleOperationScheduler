namespace ClinicaPrivata.View.Segretario
{
    partial class PrenotaInterventoForm
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
            this._pazientiComboBox = new System.Windows.Forms.ComboBox();
            this._tipologiaComboBox = new System.Windows.Forms.ComboBox();
            this._prenotaInterventoButton = new System.Windows.Forms.Button();
            this._dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this._resultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pazientiComboBox
            // 
            this._pazientiComboBox.FormattingEnabled = true;
            this._pazientiComboBox.Location = new System.Drawing.Point(157, 37);
            this._pazientiComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._pazientiComboBox.Name = "_pazientiComboBox";
            this._pazientiComboBox.Size = new System.Drawing.Size(212, 28);
            this._pazientiComboBox.TabIndex = 1;
            // 
            // _tipologiaComboBox
            // 
            this._tipologiaComboBox.FormattingEnabled = true;
            this._tipologiaComboBox.Location = new System.Drawing.Point(157, 75);
            this._tipologiaComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._tipologiaComboBox.Name = "_tipologiaComboBox";
            this._tipologiaComboBox.Size = new System.Drawing.Size(212, 28);
            this._tipologiaComboBox.TabIndex = 2;
            // 
            // _prenotaInterventoButton
            // 
            this._prenotaInterventoButton.Location = new System.Drawing.Point(111, 208);
            this._prenotaInterventoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._prenotaInterventoButton.Name = "_prenotaInterventoButton";
            this._prenotaInterventoButton.Size = new System.Drawing.Size(182, 35);
            this._prenotaInterventoButton.TabIndex = 3;
            this._prenotaInterventoButton.Text = "Prenota Intervento";
            this._prenotaInterventoButton.UseVisualStyleBackColor = true;
            this._prenotaInterventoButton.Click += new System.EventHandler(this._prenotaInterventoButton_Click);
            // 
            // _dateTimePicker
            // 
            this._dateTimePicker.Location = new System.Drawing.Point(46, 172);
            this._dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._dateTimePicker.Name = "_dateTimePicker";
            this._dateTimePicker.Size = new System.Drawing.Size(298, 26);
            this._dateTimePicker.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._resultLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._pazientiComboBox);
            this.panel1.Controls.Add(this._prenotaInterventoButton);
            this.panel1.Controls.Add(this._dateTimePicker);
            this.panel1.Controls.Add(this._tipologiaComboBox);
            this.panel1.Location = new System.Drawing.Point(13, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 297);
            this.panel1.TabIndex = 5;
            // 
            // _resultLabel
            // 
            this._resultLabel.AutoSize = true;
            this._resultLabel.Location = new System.Drawing.Point(17, 264);
            this._resultLabel.Name = "_resultLabel";
            this._resultLabel.Size = new System.Drawing.Size(0, 20);
            this._resultLabel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "A partire da";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipologia intervento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Paziente";
            // 
            // PrenotaInterventoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 311);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrenotaInterventoForm";
            this.Text = "Prenota Intervento";
            this.Load += new System.EventHandler(this.PrenotaInterventoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _pazientiComboBox;
        private System.Windows.Forms.ComboBox _tipologiaComboBox;
        private System.Windows.Forms.Button _prenotaInterventoButton;
        private System.Windows.Forms.DateTimePicker _dateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _resultLabel;
    }
}