namespace NoteIt
{
    partial class PantallaMantenedorListarLibretas
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
            this.CPanelListarLibretas = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.DataGVListarLibretas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.titulolibretasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libretasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechalibretasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libretasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteItDBDataSet = new NoteIt.NoteItDBDataSet();
            this.libretasTableAdapter = new NoteIt.NoteItDBDataSetTableAdapters.LibretasTableAdapter();
            this.CPanelListarLibretas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVListarLibretas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libretasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteItDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CPanelListarLibretas
            // 
            this.CPanelListarLibretas.Controls.Add(this.DataGVListarLibretas);
            this.CPanelListarLibretas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CPanelListarLibretas.FillColor = System.Drawing.Color.WhiteSmoke;
            this.CPanelListarLibretas.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.CPanelListarLibretas.FillColor3 = System.Drawing.Color.LightBlue;
            this.CPanelListarLibretas.FillColor4 = System.Drawing.Color.LightBlue;
            this.CPanelListarLibretas.Location = new System.Drawing.Point(0, 0);
            this.CPanelListarLibretas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPanelListarLibretas.Name = "CPanelListarLibretas";
            this.CPanelListarLibretas.Size = new System.Drawing.Size(1308, 762);
            this.CPanelListarLibretas.TabIndex = 0;
            // 
            // DataGVListarLibretas
            // 
            this.DataGVListarLibretas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.DataGVListarLibretas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGVListarLibretas.AutoGenerateColumns = false;
            this.DataGVListarLibretas.BackgroundColor = System.Drawing.Color.Azure;
            this.DataGVListarLibretas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVListarLibretas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGVListarLibretas.ColumnHeadersHeight = 15;
            this.DataGVListarLibretas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGVListarLibretas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulolibretasDataGridViewTextBoxColumn,
            this.libretasDataGridViewTextBoxColumn,
            this.fechalibretasDataGridViewTextBoxColumn});
            this.DataGVListarLibretas.DataSource = this.libretasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGVListarLibretas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGVListarLibretas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.DataGVListarLibretas.Location = new System.Drawing.Point(18, 18);
            this.DataGVListarLibretas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGVListarLibretas.Name = "DataGVListarLibretas";
            this.DataGVListarLibretas.RowHeadersVisible = false;
            this.DataGVListarLibretas.RowHeadersWidth = 62;
            this.DataGVListarLibretas.Size = new System.Drawing.Size(843, 612);
            this.DataGVListarLibretas.TabIndex = 0;
            this.DataGVListarLibretas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Cyan;
            this.DataGVListarLibretas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.DataGVListarLibretas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGVListarLibretas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGVListarLibretas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGVListarLibretas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGVListarLibretas.ThemeStyle.BackColor = System.Drawing.Color.Azure;
            this.DataGVListarLibretas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.DataGVListarLibretas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.DataGVListarLibretas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGVListarLibretas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGVListarLibretas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGVListarLibretas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGVListarLibretas.ThemeStyle.HeaderStyle.Height = 15;
            this.DataGVListarLibretas.ThemeStyle.ReadOnly = false;
            this.DataGVListarLibretas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.DataGVListarLibretas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGVListarLibretas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGVListarLibretas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGVListarLibretas.ThemeStyle.RowsStyle.Height = 22;
            this.DataGVListarLibretas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.DataGVListarLibretas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // titulolibretasDataGridViewTextBoxColumn
            // 
            this.titulolibretasDataGridViewTextBoxColumn.DataPropertyName = "titulo_libretas";
            this.titulolibretasDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.titulolibretasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titulolibretasDataGridViewTextBoxColumn.Name = "titulolibretasDataGridViewTextBoxColumn";
            this.titulolibretasDataGridViewTextBoxColumn.ToolTipText = "El titulo de la libreta";
            // 
            // libretasDataGridViewTextBoxColumn
            // 
            this.libretasDataGridViewTextBoxColumn.DataPropertyName = "libretas";
            this.libretasDataGridViewTextBoxColumn.HeaderText = "Libretas";
            this.libretasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.libretasDataGridViewTextBoxColumn.Name = "libretasDataGridViewTextBoxColumn";
            this.libretasDataGridViewTextBoxColumn.ToolTipText = "Son más extensas que las tareas";
            // 
            // fechalibretasDataGridViewTextBoxColumn
            // 
            this.fechalibretasDataGridViewTextBoxColumn.DataPropertyName = "fecha_libretas";
            this.fechalibretasDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechalibretasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechalibretasDataGridViewTextBoxColumn.Name = "fechalibretasDataGridViewTextBoxColumn";
            this.fechalibretasDataGridViewTextBoxColumn.ToolTipText = "Fecha en que fueron registradas las libretas";
            // 
            // libretasBindingSource
            // 
            this.libretasBindingSource.DataMember = "Libretas";
            this.libretasBindingSource.DataSource = this.noteItDBDataSet;
            // 
            // noteItDBDataSet
            // 
            this.noteItDBDataSet.DataSetName = "NoteItDBDataSet";
            this.noteItDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libretasTableAdapter
            // 
            this.libretasTableAdapter.ClearBeforeFill = true;
            // 
            // PantallaMantenedorListarLibretas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1308, 762);
            this.Controls.Add(this.CPanelListarLibretas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PantallaMantenedorListarLibretas";
            this.Text = "PantallaMantenedorListarLibretas";
            this.Load += new System.EventHandler(this.PantallaMantenedorListarLibretas_Load);
            this.CPanelListarLibretas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVListarLibretas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libretasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteItDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel CPanelListarLibretas;
        private Guna.UI2.WinForms.Guna2DataGridView DataGVListarLibretas;
        private NoteItDBDataSet noteItDBDataSet;
        private System.Windows.Forms.BindingSource libretasBindingSource;
        private NoteItDBDataSetTableAdapters.LibretasTableAdapter libretasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulolibretasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libretasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechalibretasDataGridViewTextBoxColumn;
    }
}