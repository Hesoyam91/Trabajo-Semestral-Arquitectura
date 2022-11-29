namespace NoteIt
{
    partial class PantallaMantenedorListarTareas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.DataGVTareas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.titulotareasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechatareasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteItDBDataSetTareas = new NoteIt.NoteItDBDataSetTareas();
            this.tareasTableAdapter = new NoteIt.NoteItDBDataSetTareasTableAdapters.TareasTableAdapter();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteItDBDataSetTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.DataGVTareas);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LightBlue;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.LightBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1308, 762);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // DataGVTareas
            // 
            this.DataGVTareas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DataGVTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGVTareas.AutoGenerateColumns = false;
            this.DataGVTareas.BackgroundColor = System.Drawing.Color.Azure;
            this.DataGVTareas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGVTareas.ColumnHeadersHeight = 15;
            this.DataGVTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGVTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulotareasDataGridViewTextBoxColumn,
            this.tareasDataGridViewTextBoxColumn,
            this.fechatareasDataGridViewTextBoxColumn});
            this.DataGVTareas.DataSource = this.tareasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGVTareas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGVTareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DataGVTareas.Location = new System.Drawing.Point(18, 18);
            this.DataGVTareas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGVTareas.Name = "DataGVTareas";
            this.DataGVTareas.RowHeadersVisible = false;
            this.DataGVTareas.RowHeadersWidth = 62;
            this.DataGVTareas.Size = new System.Drawing.Size(843, 612);
            this.DataGVTareas.TabIndex = 0;
            this.DataGVTareas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.DataGVTareas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DataGVTareas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGVTareas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGVTareas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGVTareas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGVTareas.ThemeStyle.BackColor = System.Drawing.Color.Azure;
            this.DataGVTareas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DataGVTareas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.DataGVTareas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGVTareas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGVTareas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGVTareas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGVTareas.ThemeStyle.HeaderStyle.Height = 15;
            this.DataGVTareas.ThemeStyle.ReadOnly = false;
            this.DataGVTareas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.DataGVTareas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGVTareas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGVTareas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGVTareas.ThemeStyle.RowsStyle.Height = 22;
            this.DataGVTareas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.DataGVTareas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // titulotareasDataGridViewTextBoxColumn
            // 
            this.titulotareasDataGridViewTextBoxColumn.DataPropertyName = "titulo_tareas";
            this.titulotareasDataGridViewTextBoxColumn.HeaderText = "Título";
            this.titulotareasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titulotareasDataGridViewTextBoxColumn.Name = "titulotareasDataGridViewTextBoxColumn";
            // 
            // tareasDataGridViewTextBoxColumn
            // 
            this.tareasDataGridViewTextBoxColumn.DataPropertyName = "tareas";
            this.tareasDataGridViewTextBoxColumn.HeaderText = "Tareas";
            this.tareasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tareasDataGridViewTextBoxColumn.Name = "tareasDataGridViewTextBoxColumn";
            // 
            // fechatareasDataGridViewTextBoxColumn
            // 
            this.fechatareasDataGridViewTextBoxColumn.DataPropertyName = "fecha_tareas";
            this.fechatareasDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechatareasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechatareasDataGridViewTextBoxColumn.Name = "fechatareasDataGridViewTextBoxColumn";
            // 
            // tareasBindingSource
            // 
            this.tareasBindingSource.DataMember = "Tareas";
            this.tareasBindingSource.DataSource = this.noteItDBDataSetTareas;
            // 
            // noteItDBDataSetTareas
            // 
            this.noteItDBDataSetTareas.DataSetName = "NoteItDBDataSetTareas";
            this.noteItDBDataSetTareas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tareasTableAdapter
            // 
            this.tareasTableAdapter.ClearBeforeFill = true;
            // 
            // PantallaMantenedorListarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1308, 762);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PantallaMantenedorListarTareas";
            this.Text = "PantallaMantenedorListarTareas";
            this.Load += new System.EventHandler(this.PantallaMantenedorListarTareas_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteItDBDataSetTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGVTareas;
        private NoteItDBDataSetTareas noteItDBDataSetTareas;
        private System.Windows.Forms.BindingSource tareasBindingSource;
        private NoteItDBDataSetTareasTableAdapters.TareasTableAdapter tareasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulotareasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechatareasDataGridViewTextBoxColumn;
    }
}