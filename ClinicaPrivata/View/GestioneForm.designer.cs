namespace ClinicaPrivata.View
{
    partial class GestioneForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this._grid = new System.Windows.Forms.DataGridView();
            this.Interventi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._editingPanel = new System.Windows.Forms.TableLayoutPanel();
            this._buttonsPanel = new System.Windows.Forms.Panel();
            this._annullaModificheButton = new System.Windows.Forms.Button();
            this._aggiungiButton = new System.Windows.Forms.Button();
            this._eliminaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grid)).BeginInit();
            this._buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this._eliminaButton);
            this.splitContainer2.Panel1.Controls.Add(this._aggiungiButton);
            this.splitContainer2.Panel1.Controls.Add(this._grid);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this._editingPanel);
            this.splitContainer2.Panel2.Controls.Add(this._buttonsPanel);
            this.splitContainer2.Size = new System.Drawing.Size(523, 468);
            this.splitContainer2.SplitterDistance = 157;
            this.splitContainer2.TabIndex = 0;
            // 
            // _grid
            // 
            this._grid.AllowUserToAddRows = false;
            this._grid.AllowUserToDeleteRows = false;
            this._grid.AllowUserToResizeColumns = false;
            this._grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this._grid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Interventi});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grid.DefaultCellStyle = dataGridViewCellStyle9;
            this._grid.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._grid.Location = new System.Drawing.Point(3, 0);
            this._grid.Name = "_grid";
            this._grid.ReadOnly = true;
            this._grid.RowHeadersVisible = false;
            this._grid.Size = new System.Drawing.Size(152, 423);
            this._grid.TabIndex = 0;
            this._grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._grid_CellContentClick);
            // 
            // Interventi
            // 
            this.Interventi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Interventi.HeaderText = "GestioneForm";
            this.Interventi.Name = "GestioneForm";
            this.Interventi.ReadOnly = true;
            // 
            // _editingPanel
            // 
            this._editingPanel.AutoScroll = true;
            this._editingPanel.ColumnCount = 1;
            this._editingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._editingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editingPanel.Location = new System.Drawing.Point(0, 0);
            this._editingPanel.Name = "_editingPanel";
            this._editingPanel.RowCount = 1;
            this._editingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._editingPanel.Size = new System.Drawing.Size(362, 424);
            this._editingPanel.TabIndex = 4;
            // 
            // _buttonsPanel
            // 
            this._buttonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._buttonsPanel.Controls.Add(this._annullaModificheButton);
            this._buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._buttonsPanel.Location = new System.Drawing.Point(0, 424);
            this._buttonsPanel.Name = "_buttonsPanel";
            this._buttonsPanel.Size = new System.Drawing.Size(362, 44);
            this._buttonsPanel.TabIndex = 3;
            // 
            // _annullaModificheButton
            // 
            this._annullaModificheButton.Location = new System.Drawing.Point(102, 14);
            this._annullaModificheButton.Name = "_annullaModificheButton";
            this._annullaModificheButton.Size = new System.Drawing.Size(154, 23);
            this._annullaModificheButton.TabIndex = 1;
            this._annullaModificheButton.Text = "Annulla modifiche";
            this._annullaModificheButton.UseVisualStyleBackColor = true;
            this._annullaModificheButton.Click += new System.EventHandler(this._annullaModificheButton_Click_1);
            // 
            // _aggiungiButton
            // 
            this._aggiungiButton.Location = new System.Drawing.Point(4, 430);
            this._aggiungiButton.Name = "_aggiungiButton";
            this._aggiungiButton.Size = new System.Drawing.Size(75, 32);
            this._aggiungiButton.TabIndex = 1;
            this._aggiungiButton.Text = "Aggiungi";
            this._aggiungiButton.UseVisualStyleBackColor = true;
            this._aggiungiButton.Click += new System.EventHandler(this._aggiungiButton_Click);
            // 
            // _eliminaButton
            // 
            this._eliminaButton.Location = new System.Drawing.Point(79, 430);
            this._eliminaButton.Name = "_eliminaButton";
            this._eliminaButton.Size = new System.Drawing.Size(75, 32);
            this._eliminaButton.TabIndex = 2;
            this._eliminaButton.Text = "Elimina";
            this._eliminaButton.UseVisualStyleBackColor = true;
            this._eliminaButton.Click += new System.EventHandler(this._eliminaButton_Click);
            // 
            // GestioneForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(523, 468);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GestioneForm";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grid)).EndInit();
            this._buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView _grid;
        private System.Windows.Forms.Panel _buttonsPanel;
        private System.Windows.Forms.Button _annullaModificheButton;
        private System.Windows.Forms.TableLayoutPanel _editingPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interventi;
        private System.Windows.Forms.Button _eliminaButton;
        private System.Windows.Forms.Button _aggiungiButton;
    }
}