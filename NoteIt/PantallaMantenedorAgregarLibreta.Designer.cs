namespace NoteIt
{
    partial class PantallaMantenedorAgregarLibreta
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lbLibreta = new System.Windows.Forms.Label();
            this.lbTituloAgregarTarea = new System.Windows.Forms.Label();
            this.txtAgregarLibreta = new System.Windows.Forms.TextBox();
            this.txtTituloAgregarLibreta = new System.Windows.Forms.TextBox();
            this.btnGuardarLibreta = new System.Windows.Forms.Button();
            this.lbContadorLibretas = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.lbContadorLibretas);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbLibreta);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbTituloAgregarTarea);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtAgregarLibreta);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtTituloAgregarLibreta);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnGuardarLibreta);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LightBlue;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.LightBlue;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1300, 740);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // lbLibreta
            // 
            this.lbLibreta.AutoSize = true;
            this.lbLibreta.BackColor = System.Drawing.Color.Transparent;
            this.lbLibreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibreta.Location = new System.Drawing.Point(56, 149);
            this.lbLibreta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLibreta.Name = "lbLibreta";
            this.lbLibreta.Size = new System.Drawing.Size(65, 22);
            this.lbLibreta.TabIndex = 7;
            this.lbLibreta.Text = "Libreta";
            // 
            // lbTituloAgregarTarea
            // 
            this.lbTituloAgregarTarea.AutoSize = true;
            this.lbTituloAgregarTarea.BackColor = System.Drawing.Color.Transparent;
            this.lbTituloAgregarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloAgregarTarea.Location = new System.Drawing.Point(56, 52);
            this.lbTituloAgregarTarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloAgregarTarea.Name = "lbTituloAgregarTarea";
            this.lbTituloAgregarTarea.Size = new System.Drawing.Size(55, 22);
            this.lbTituloAgregarTarea.TabIndex = 6;
            this.lbTituloAgregarTarea.Text = "Titulo";
            // 
            // txtAgregarLibreta
            // 
            this.txtAgregarLibreta.BackColor = System.Drawing.Color.Azure;
            this.txtAgregarLibreta.Location = new System.Drawing.Point(154, 145);
            this.txtAgregarLibreta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAgregarLibreta.MaxLength = 5000;
            this.txtAgregarLibreta.Multiline = true;
            this.txtAgregarLibreta.Name = "txtAgregarLibreta";
            this.txtAgregarLibreta.Size = new System.Drawing.Size(517, 439);
            this.txtAgregarLibreta.TabIndex = 5;
            this.txtAgregarLibreta.TextChanged += new System.EventHandler(this.txtAgregarLibreta_TextChanged);
            // 
            // txtTituloAgregarLibreta
            // 
            this.txtTituloAgregarLibreta.BackColor = System.Drawing.Color.Azure;
            this.txtTituloAgregarLibreta.Location = new System.Drawing.Point(154, 48);
            this.txtTituloAgregarLibreta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTituloAgregarLibreta.Name = "txtTituloAgregarLibreta";
            this.txtTituloAgregarLibreta.Size = new System.Drawing.Size(475, 26);
            this.txtTituloAgregarLibreta.TabIndex = 4;
            // 
            // btnGuardarLibreta
            // 
            this.btnGuardarLibreta.Location = new System.Drawing.Point(340, 622);
            this.btnGuardarLibreta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarLibreta.Name = "btnGuardarLibreta";
            this.btnGuardarLibreta.Size = new System.Drawing.Size(112, 35);
            this.btnGuardarLibreta.TabIndex = 3;
            this.btnGuardarLibreta.Text = "Guardar";
            this.btnGuardarLibreta.UseVisualStyleBackColor = true;
            this.btnGuardarLibreta.Click += new System.EventHandler(this.btnGuardarLibreta_Click);
            // 
            // lbContadorLibretas
            // 
            this.lbContadorLibretas.AutoSize = true;
            this.lbContadorLibretas.BackColor = System.Drawing.Color.Transparent;
            this.lbContadorLibretas.Location = new System.Drawing.Point(583, 564);
            this.lbContadorLibretas.Name = "lbContadorLibretas";
            this.lbContadorLibretas.Size = new System.Drawing.Size(18, 20);
            this.lbContadorLibretas.TabIndex = 8;
            this.lbContadorLibretas.Text = "0";
            // 
            // PantallaMantenedorAgregarLibreta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 740);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PantallaMantenedorAgregarLibreta";
            this.Text = "PantallaMantenedorAgregarLibreta";
            this.Load += new System.EventHandler(this.PantallaMantenedorAgregarLibreta_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Button btnGuardarLibreta;
        private System.Windows.Forms.TextBox txtAgregarLibreta;
        private System.Windows.Forms.TextBox txtTituloAgregarLibreta;
        private System.Windows.Forms.Label lbLibreta;
        private System.Windows.Forms.Label lbTituloAgregarTarea;
        private System.Windows.Forms.Label lbContadorLibretas;
    }
}