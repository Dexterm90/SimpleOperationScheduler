namespace ClinicaPrivata.View.Medico
{
    partial class CalendarioInterventi
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
            this._successivoLinkLabel = new System.Windows.Forms.LinkLabel();
            this._precedenteLinkLabel = new System.Windows.Forms.LinkLabel();
            this._meseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._inizioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._fineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._calendarioPerIntervalloButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _successivoLinkLabel
            // 
            this._successivoLinkLabel.AutoSize = true;
            this._successivoLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._successivoLinkLabel.Location = new System.Drawing.Point(675, 203);
            this._successivoLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._successivoLinkLabel.Name = "_successivoLinkLabel";
            this._successivoLinkLabel.Size = new System.Drawing.Size(113, 16);
            this._successivoLinkLabel.TabIndex = 1;
            this._successivoLinkLabel.TabStop = true;
            this._successivoLinkLabel.Text = "Mese successivo";
            this._successivoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._successivoLinkLabel_LinkClicked);
            // 
            // _precedenteLinkLabel
            // 
            this._precedenteLinkLabel.AutoSize = true;
            this._precedenteLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._precedenteLinkLabel.Location = new System.Drawing.Point(55, 203);
            this._precedenteLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._precedenteLinkLabel.Name = "_precedenteLinkLabel";
            this._precedenteLinkLabel.Size = new System.Drawing.Size(114, 16);
            this._precedenteLinkLabel.TabIndex = 2;
            this._precedenteLinkLabel.TabStop = true;
            this._precedenteLinkLabel.Text = "Mese precedente";
            this._precedenteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._precedenteLinkLabel_LinkClicked);
            // 
            // _meseTableLayoutPanel
            // 
            this._meseTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this._meseTableLayoutPanel.ColumnCount = 7;
            this._meseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._meseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._meseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._meseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._meseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._meseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._meseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._meseTableLayoutPanel.Location = new System.Drawing.Point(177, 39);
            this._meseTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._meseTableLayoutPanel.Name = "_meseTableLayoutPanel";
            this._meseTableLayoutPanel.RowCount = 5;
            this._meseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._meseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._meseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._meseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._meseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._meseTableLayoutPanel.Size = new System.Drawing.Size(490, 350);
            this._meseTableLayoutPanel.TabIndex = 0;
            // 
            // _inizioDateTimePicker
            // 
            this._inizioDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._inizioDateTimePicker.Location = new System.Drawing.Point(185, 420);
            this._inizioDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._inizioDateTimePicker.Name = "_inizioDateTimePicker";
            this._inizioDateTimePicker.Size = new System.Drawing.Size(265, 20);
            this._inizioDateTimePicker.TabIndex = 3;
            // 
            // _fineDateTimePicker
            // 
            this._fineDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._fineDateTimePicker.Location = new System.Drawing.Point(499, 418);
            this._fineDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._fineDateTimePicker.Name = "_fineDateTimePicker";
            this._fineDateTimePicker.Size = new System.Drawing.Size(265, 20);
            this._fineDateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Visualizza interventi in programma da";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 420);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "fino a";
            // 
            // _calendarioPerIntervalloButton
            // 
            this._calendarioPerIntervalloButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._calendarioPerIntervalloButton.Location = new System.Drawing.Point(772, 412);
            this._calendarioPerIntervalloButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._calendarioPerIntervalloButton.Name = "_calendarioPerIntervalloButton";
            this._calendarioPerIntervalloButton.Size = new System.Drawing.Size(43, 28);
            this._calendarioPerIntervalloButton.TabIndex = 7;
            this._calendarioPerIntervalloButton.Text = "Vai";
            this._calendarioPerIntervalloButton.UseVisualStyleBackColor = true;
            this._calendarioPerIntervalloButton.Click += new System.EventHandler(this._calendarioPerIntervalloButton_Click);
            // 
            // CalendarioInterventi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 463);
            this.Controls.Add(this._calendarioPerIntervalloButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._fineDateTimePicker);
            this.Controls.Add(this._inizioDateTimePicker);
            this.Controls.Add(this._meseTableLayoutPanel);
            this.Controls.Add(this._precedenteLinkLabel);
            this.Controls.Add(this._successivoLinkLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalendarioInterventi";
            this.Text = "CalendarioInterventi";
            this.Load += new System.EventHandler(this.CalendarioInterventi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel _successivoLinkLabel;
        private System.Windows.Forms.LinkLabel _precedenteLinkLabel;
        private System.Windows.Forms.TableLayoutPanel _meseTableLayoutPanel;
        private System.Windows.Forms.DateTimePicker _inizioDateTimePicker;
        private System.Windows.Forms.DateTimePicker _fineDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _calendarioPerIntervalloButton;


    }
}