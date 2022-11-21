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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.DataGVTareas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tareasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteItDBDataSetTareas = new NoteIt.NoteItDBDataSetTareas();
            this.tareasTableAdapter = new NoteIt.NoteItDBDataSetTareasTableAdapters.TareasTableAdapter();
            this.titulotareasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechatareasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteItDBDataSetTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnEliminarTarea);
            this.guna2CustomGradientPanel1.Controls.Add(this.DataGVTareas);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LightBlue;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.LightBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(872, 495);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // DataGVTareas
            // 
            this.DataGVTareas.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DataGVTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGVTareas.AutoGenerateColumns = false;
            this.DataGVTareas.BackgroundColor = System.Drawing.Color.Azure;
            this.DataGVTareas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGVTareas.ColumnHeadersHeight = 15;
            this.DataGVTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGVTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulotareasDataGridViewTextBoxColumn,
            this.tareasDataGridViewTextBoxColumn,
            this.fechatareasDataGridViewTextBoxColumn});
            this.DataGVTareas.DataSource = this.tareasBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGVTareas.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGVTareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DataGVTareas.Location = new System.Drawing.Point(12, 12);
            this.DataGVTareas.Name = "DataGVTareas";
            this.DataGVTareas.RowHeadersVisible = false;
            this.DataGVTareas.Size = new System.Drawing.Size(562, 398);
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
            // titulotareasDataGridViewTextBoxColumn
            // 
            this.titulotareasDataGridViewTextBoxColumn.DataPropertyName = "titulo_tareas";
            this.titulotareasDataGridViewTextBoxColumn.HeaderText = "Título";
            this.titulotareasDataGridViewTextBoxColumn.Name = "titulotareasDataGridViewTextBoxColumn";
            // 
            // tareasDataGridViewTextBoxColumn
            // 
            this.tareasDataGridViewTextBoxColumn.DataPropertyName = "tareas";
            this.tareasDataGridViewTextBoxColumn.HeaderText = "Tareas";
            this.tareasDataGridViewTextBoxColumn.Name = "tareasDataGridViewTextBoxColumn";
            // 
            // fechatareasDataGridViewTextBoxColumn
            // 
            this.fechatareasDataGridViewTextBoxColumn.DataPropertyName = "fecha_tareas";
            this.fechatareasDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechatareasDataGridViewTextBoxColumn.Name = "fechatareasDataGridViewTextBoxColumn";
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Location = new System.Drawing.Point(253, 416);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTarea.TabIndex = 1;
            this.btnEliminarTarea.Text = "Eliminar";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // PantallaMantenedorListarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 495);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btnEliminarTarea;
    }
}