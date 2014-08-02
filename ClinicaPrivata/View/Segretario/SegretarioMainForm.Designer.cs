namespace ClinicaPrivata.View.Segretario
{
    partial class SegretarioMainForm
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
            this._panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._pazientiButton = new System.Windows.Forms.Button();
            this._saleButton = new System.Windows.Forms.Button();
            this._tipologieInterventoButton = new System.Windows.Forms.Button();
            this._interventiFuturiButton = new System.Windows.Forms.Button();
            this._prenotazioneInterventi = new System.Windows.Forms.Button();
            this._panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Controls.Add(this._pazientiButton);
            this._panel.Controls.Add(this._saleButton);
            this._panel.Controls.Add(this._tipologieInterventoButton);
            this._panel.Controls.Add(this._interventiFuturiButton);
            this._panel.Controls.Add(this._prenotazioneInterventi);
            this._panel.Location = new System.Drawing.Point(2, 33);
            this._panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(357, 433);
            this._panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleziona l\'operazione";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _pazientiButton
            // 
            this._pazientiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pazientiButton.Location = new System.Drawing.Point(4, 5);
            this._pazientiButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._pazientiButton.Name = "_pazientiButton";
            this._pazientiButton.Size = new System.Drawing.Size(345, 75);
            this._pazientiButton.TabIndex = 0;
            this._pazientiButton.Text = "Gestione Pazienti";
            this._pazientiButton.UseVisualStyleBackColor = true;
            this._pazientiButton.Click += new System.EventHandler(this.pazientiButton_Click);
            // 
            // _saleButton
            // 
            this._saleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saleButton.Location = new System.Drawing.Point(4, 90);
            this._saleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._saleButton.Name = "_saleButton";
            this._saleButton.Size = new System.Drawing.Size(345, 75);
            this._saleButton.TabIndex = 1;
            this._saleButton.Text = "Gestione Sale Operatorie";
            this._saleButton.UseVisualStyleBackColor = true;
            this._saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // _tipologieInterventoButton
            // 
            this._tipologieInterventoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tipologieInterventoButton.Location = new System.Drawing.Point(4, 175);
            this._tipologieInterventoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._tipologieInterventoButton.Name = "_tipologieInterventoButton";
            this._tipologieInterventoButton.Size = new System.Drawing.Size(345, 75);
            this._tipologieInterventoButton.TabIndex = 2;
            this._tipologieInterventoButton.Text = "Gestione Tipologie Intervento";
            this._tipologieInterventoButton.UseVisualStyleBackColor = true;
            this._tipologieInterventoButton.Click += new System.EventHandler(this.tipologieInterventoButton_Click);
            // 
            // _interventiFuturiButton
            // 
            this._interventiFuturiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._interventiFuturiButton.Location = new System.Drawing.Point(4, 260);
            this._interventiFuturiButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._interventiFuturiButton.Name = "_interventiFuturiButton";
            this._interventiFuturiButton.Size = new System.Drawing.Size(345, 75);
            this._interventiFuturiButton.TabIndex = 3;
            this._interventiFuturiButton.Text = "Visualizzazione Interventi Futuri";
            this._interventiFuturiButton.UseVisualStyleBackColor = true;
            this._interventiFuturiButton.Click += new System.EventHandler(this.interventiFuturiButton_Click);
            // 
            // _prenotazioneInterventi
            // 
            this._prenotazioneInterventi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._prenotazioneInterventi.Location = new System.Drawing.Point(4, 345);
            this._prenotazioneInterventi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._prenotazioneInterventi.Name = "_prenotazioneInterventi";
            this._prenotazioneInterventi.Size = new System.Drawing.Size(345, 75);
            this._prenotazioneInterventi.TabIndex = 4;
            this._prenotazioneInterventi.Text = "Prenotazione Interventi";
            this._prenotazioneInterventi.UseVisualStyleBackColor = true;
            this._prenotazioneInterventi.Click += new System.EventHandler(this.button1_Click);
            // 
            // SegretarioMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 469);
            this.Controls.Add(this._panel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SegretarioMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SegretarioMainForm_FormClosed);
            this._panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _panel;

        public System.Windows.Forms.FlowLayoutPanel Panel
        {
            get { return _panel; }
        }

        private System.Windows.Forms.Button _pazientiButton;
        private System.Windows.Forms.Button _saleButton;
        private System.Windows.Forms.Button _tipologieInterventoButton;
        private System.Windows.Forms.Button _interventiFuturiButton;
        private System.Windows.Forms.Button _prenotazioneInterventi;
        private System.Windows.Forms.Label label1;
    }
}