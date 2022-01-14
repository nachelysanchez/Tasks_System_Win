
namespace Tasks_System_Win.UI.Consultas
{
    partial class cTareas
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
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.TareaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todos",
            "Id",
            "Nombre",
            "Descripción"});
            this.FiltroComboBox.Location = new System.Drawing.Point(12, 27);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(163, 23);
            this.FiltroComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(197, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 15);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Criterio";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(197, 27);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(196, 23);
            this.CriterioTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(410, 27);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // TareaID
            // 
            this.TareaID.HeaderText = "Tarea Id";
            this.TareaID.Name = "TareaID";
            this.TareaID.ReadOnly = true;
            // 
            // DataGridDatos
            // 
            this.DataGridDatos.AllowUserToAddRows = false;
            this.DataGridDatos.AllowUserToDeleteRows = false;
            this.DataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDatos.Location = new System.Drawing.Point(12, 77);
            this.DataGridDatos.Name = "DataGridDatos";
            this.DataGridDatos.ReadOnly = true;
            this.DataGridDatos.RowTemplate.Height = 25;
            this.DataGridDatos.Size = new System.Drawing.Size(473, 150);
            this.DataGridDatos.TabIndex = 5;
            // 
            // cTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 270);
            this.Controls.Add(this.DataGridDatos);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltroComboBox);
            this.Name = "cTareas";
            this.Text = "cTareas";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareaID;
        private System.Windows.Forms.DataGridView DataGridDatos;
    }
}