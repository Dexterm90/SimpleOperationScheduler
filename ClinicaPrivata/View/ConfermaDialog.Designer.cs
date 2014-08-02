namespace ClinicaPrivata.View
{
    partial class ConfermaDialog
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
            this._noButton = new System.Windows.Forms.Button();
            this._siButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vuoi salvare i cambiamenti apportati?";
            // 
            // _noButton
            // 
            this._noButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._noButton.Location = new System.Drawing.Point(209, 94);
            this._noButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._noButton.Name = "_noButton";
            this._noButton.Size = new System.Drawing.Size(100, 28);
            this._noButton.TabIndex = 1;
            this._noButton.Text = "No";
            this._noButton.UseVisualStyleBackColor = true;
            this._noButton.Click += new System.EventHandler(this._noButton_Click);
            // 
            // _siButton
            // 
            this._siButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._siButton.Location = new System.Drawing.Point(31, 94);
            this._siButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._siButton.Name = "_siButton";
            this._siButton.Size = new System.Drawing.Size(100, 28);
            this._siButton.TabIndex = 2;
            this._siButton.Text = "Sì";
            this._siButton.UseVisualStyleBackColor = true;
            this._siButton.Click += new System.EventHandler(this._siButton_Click);
            // 
            // ConfermaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 165);
            this.Controls.Add(this._siButton);
            this.Controls.Add(this._noButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConfermaDialog";
            this.Text = "Uscita";
            this.Load += new System.EventHandler(this.ConfermaDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _noButton;
        private System.Windows.Forms.Button _siButton;
    }
}