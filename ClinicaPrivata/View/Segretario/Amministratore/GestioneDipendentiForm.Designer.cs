namespace ClinicaPrivata.View.Segretario.Amministratore
{
    partial class GestioneDipendentiForm
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
            this._gestioneMediciButton = new System.Windows.Forms.Button();
            this._gestioneSegretariButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _gestioneMediciButton
            // 
            this._gestioneMediciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gestioneMediciButton.Location = new System.Drawing.Point(12, 12);
            this._gestioneMediciButton.Name = "_gestioneMediciButton";
            this._gestioneMediciButton.Size = new System.Drawing.Size(345, 75);
            this._gestioneMediciButton.TabIndex = 0;
            this._gestioneMediciButton.Text = "GestioneMedici";
            this._gestioneMediciButton.UseVisualStyleBackColor = true;
            this._gestioneMediciButton.Click += new System.EventHandler(this._gestioneMediciButton_Click);
            // 
            // _gestioneSegretariButton
            // 
            this._gestioneSegretariButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gestioneSegretariButton.Location = new System.Drawing.Point(12, 101);
            this._gestioneSegretariButton.Name = "_gestioneSegretariButton";
            this._gestioneSegretariButton.Size = new System.Drawing.Size(345, 75);
            this._gestioneSegretariButton.TabIndex = 1;
            this._gestioneSegretariButton.Text = "GestioneSegretari";
            this._gestioneSegretariButton.UseVisualStyleBackColor = true;
            this._gestioneSegretariButton.Click += new System.EventHandler(this._gestioneSegretariButton_Click);
            // 
            // GestioneDipendentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 191);
            this.Controls.Add(this._gestioneSegretariButton);
            this.Controls.Add(this._gestioneMediciButton);
            this.Name = "GestioneDipendentiForm";
            this.Text = "Gestione Dipendenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _gestioneMediciButton;
        private System.Windows.Forms.Button _gestioneSegretariButton;
    }
}