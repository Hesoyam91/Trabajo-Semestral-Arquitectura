namespace NoteIt
{
    partial class PantallaMantenedorAgregarTarea
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
            this.lbTituloTarea = new System.Windows.Forms.Label();
            this.txtTituloTarea = new System.Windows.Forms.TextBox();
            this.lbTarea = new System.Windows.Forms.Label();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnGuardarTarea = new System.Windows.Forms.Button();
            this.CPanelAgregarTarea = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbContadorTareas = new System.Windows.Forms.Label();
            this.CPanelAgregarTarea.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTituloTarea
            // 
            this.lbTituloTarea.AutoSize = true;
            this.lbTituloTarea.BackColor = System.Drawing.Color.Transparent;
            this.lbTituloTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloTarea.Location = new System.Drawing.Point(56, 55);
            this.lbTituloTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloTarea.Name = "lbTituloTarea";
            this.lbTituloTarea.Size = new System.Drawing.Size(55, 22);
            this.lbTituloTarea.TabIndex = 0;
            this.lbTituloTarea.Text = "Titulo";
            // 
            // txtTituloTarea
            // 
            this.txtTituloTarea.BackColor = System.Drawing.Color.Azure;
            this.txtTituloTarea.Location = new System.Drawing.Point(216, 54);
            this.txtTituloTarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTituloTarea.Name = "txtTituloTarea";
            this.txtTituloTarea.Size = new System.Drawing.Size(409, 26);
            this.txtTituloTarea.TabIndex = 1;
            // 
            // lbTarea
            // 
            this.lbTarea.AutoSize = true;
            this.lbTarea.BackColor = System.Drawing.Color.Transparent;
            this.lbTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarea.Location = new System.Drawing.Point(56, 128);
            this.lbTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTarea.Name = "lbTarea";
            this.lbTarea.Size = new System.Drawing.Size(58, 22);
            this.lbTarea.TabIndex = 2;
            this.lbTarea.Text = "Tarea";
            // 
            // txtTarea
            // 
            this.txtTarea.BackColor = System.Drawing.Color.Azure;
            this.txtTarea.Location = new System.Drawing.Point(216, 127);
            this.txtTarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTarea.MaxLength = 1000;
            this.txtTarea.Multiline = true;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(588, 367);
            this.txtTarea.TabIndex = 3;
            this.txtTarea.TextChanged += new System.EventHandler(this.txtTarea_TextChanged);
            // 
            // btnGuardarTarea
            // 
            this.btnGuardarTarea.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarTarea.Location = new System.Drawing.Point(440, 534);
            this.btnGuardarTarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarTarea.Name = "btnGuardarTarea";
            this.btnGuardarTarea.Size = new System.Drawing.Size(112, 35);
            this.btnGuardarTarea.TabIndex = 4;
            this.btnGuardarTarea.Text = "Guardar";
            this.btnGuardarTarea.UseVisualStyleBackColor = false;
            this.btnGuardarTarea.Click += new System.EventHandler(this.btnGuardarTarea_Click);
            // 
            // CPanelAgregarTarea
            // 
            this.CPanelAgregarTarea.Controls.Add(this.lbContadorTareas);
            this.CPanelAgregarTarea.Controls.Add(this.btnGuardarTarea);
            this.CPanelAgregarTarea.Controls.Add(this.lbTarea);
            this.CPanelAgregarTarea.Controls.Add(this.txtTarea);
            this.CPanelAgregarTarea.Controls.Add(this.lbTituloTarea);
            this.CPanelAgregarTarea.Controls.Add(this.txtTituloTarea);
            this.CPanelAgregarTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CPanelAgregarTarea.FillColor = System.Drawing.Color.WhiteSmoke;
            this.CPanelAgregarTarea.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.CPanelAgregarTarea.FillColor3 = System.Drawing.Color.LightBlue;
            this.CPanelAgregarTarea.FillColor4 = System.Drawing.Color.LightBlue;
            this.CPanelAgregarTarea.Location = new System.Drawing.Point(0, 0);
            this.CPanelAgregarTarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPanelAgregarTarea.Name = "CPanelAgregarTarea";
            this.CPanelAgregarTarea.Size = new System.Drawing.Size(1308, 762);
            this.CPanelAgregarTarea.TabIndex = 5;
            // 
            // lbContadorTareas
            // 
            this.lbContadorTareas.AutoSize = true;
            this.lbContadorTareas.BackColor = System.Drawing.Color.Transparent;
            this.lbContadorTareas.Location = new System.Drawing.Point(696, 474);
            this.lbContadorTareas.Name = "lbContadorTareas";
            this.lbContadorTareas.Size = new System.Drawing.Size(18, 20);
            this.lbContadorTareas.TabIndex = 5;
            this.lbContadorTareas.Text = "0";
            // 
            // PantallaMantenedorAgregarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1308, 762);
            this.Controls.Add(this.CPanelAgregarTarea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PantallaMantenedorAgregarTarea";
            this.Text = "PantallaMantenedorAgregarTarea";
            this.Load += new System.EventHandler(this.PantallaMantenedorAgregarTarea_Load);
            this.CPanelAgregarTarea.ResumeLayout(false);
            this.CPanelAgregarTarea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTituloTarea;
        private System.Windows.Forms.TextBox txtTituloTarea;
        private System.Windows.Forms.Label lbTarea;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnGuardarTarea;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel CPanelAgregarTarea;
        private System.Windows.Forms.Label lbContadorTareas;
    }
}