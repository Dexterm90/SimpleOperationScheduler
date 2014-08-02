namespace ClinicaPrivata.View.Medico
{
    partial class MedicoMainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._pazientiButton = new System.Windows.Forms.Button();
            this._interventiPassatiButton = new System.Windows.Forms.Button();
            this.calendarioInterventiButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this._pazientiButton);
            this.flowLayoutPanel1.Controls.Add(this._interventiPassatiButton);
            this.flowLayoutPanel1.Controls.Add(this.calendarioInterventiButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 262);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleziona l\'operazione";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _pazientiButton
            // 
            this._pazientiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pazientiButton.Location = new System.Drawing.Point(3, 23);
            this._pazientiButton.Name = "_pazientiButton";
            this._pazientiButton.Size = new System.Drawing.Size(355, 75);
            this._pazientiButton.TabIndex = 0;
            this._pazientiButton.Text = "Visualizzazione Pazienti";
            this._pazientiButton.UseVisualStyleBackColor = true;
            this._pazientiButton.Click += new System.EventHandler(this.pazientiButton_Click);
            // 
            // _interventiPassatiButton
            // 
            this._interventiPassatiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._interventiPassatiButton.Location = new System.Drawing.Point(3, 104);
            this._interventiPassatiButton.Name = "_interventiPassatiButton";
            this._interventiPassatiButton.Size = new System.Drawing.Size(355, 75);
            this._interventiPassatiButton.TabIndex = 3;
            this._interventiPassatiButton.Text = "Visualizzazione Interventi Passati";
            this._interventiPassatiButton.UseVisualStyleBackColor = true;
            this._interventiPassatiButton.Click += new System.EventHandler(this._interventiPassatiButton_Click);
            // 
            // calendarioInterventiButton
            // 
            this.calendarioInterventiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarioInterventiButton.Location = new System.Drawing.Point(3, 185);
            this.calendarioInterventiButton.Name = "calendarioInterventiButton";
            this.calendarioInterventiButton.Size = new System.Drawing.Size(355, 75);
            this.calendarioInterventiButton.TabIndex = 4;
            this.calendarioInterventiButton.Text = "Visualizzazione Calendario Interventi";
            this.calendarioInterventiButton.UseVisualStyleBackColor = true;
            this.calendarioInterventiButton.Click += new System.EventHandler(this.calendarioInterventiButton_Click);
            // 
            // MedicoMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 264);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MedicoMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MedicoMainForm_FormClosed);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button _pazientiButton;
        private System.Windows.Forms.Button calendarioInterventiButton;
        private System.Windows.Forms.Button _interventiPassatiButton;
        private System.Windows.Forms.Label label1;
    }
}