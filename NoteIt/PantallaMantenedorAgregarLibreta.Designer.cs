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
            this.lbTituloLibreta = new System.Windows.Forms.Label();
            this.txtTituloLibreta = new System.Windows.Forms.TextBox();
            this.lbLibreta = new System.Windows.Forms.Label();
            this.txtLibreta = new System.Windows.Forms.TextBox();
            this.btnGuardarLibreta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTituloLibreta
            // 
            this.lbTituloLibreta.AutoSize = true;
            this.lbTituloLibreta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloLibreta.Location = new System.Drawing.Point(25, 39);
            this.lbTituloLibreta.Name = "lbTituloLibreta";
            this.lbTituloLibreta.Size = new System.Drawing.Size(81, 16);
            this.lbTituloLibreta.TabIndex = 0;
            this.lbTituloLibreta.Text = "Titulo Libreta";
            // 
            // txtTituloLibreta
            // 
            this.txtTituloLibreta.Location = new System.Drawing.Point(128, 39);
            this.txtTituloLibreta.Name = "txtTituloLibreta";
            this.txtTituloLibreta.Size = new System.Drawing.Size(258, 20);
            this.txtTituloLibreta.TabIndex = 1;
            // 
            // lbLibreta
            // 
            this.lbLibreta.AutoSize = true;
            this.lbLibreta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibreta.Location = new System.Drawing.Point(25, 93);
            this.lbLibreta.Name = "lbLibreta";
            this.lbLibreta.Size = new System.Drawing.Size(46, 16);
            this.lbLibreta.TabIndex = 2;
            this.lbLibreta.Text = "Libreta";
            // 
            // txtLibreta
            // 
            this.txtLibreta.Location = new System.Drawing.Point(128, 93);
            this.txtLibreta.Multiline = true;
            this.txtLibreta.Name = "txtLibreta";
            this.txtLibreta.Size = new System.Drawing.Size(392, 271);
            this.txtLibreta.TabIndex = 3;
            // 
            // btnGuardarLibreta
            // 
            this.btnGuardarLibreta.Location = new System.Drawing.Point(311, 406);
            this.btnGuardarLibreta.Name = "btnGuardarLibreta";
            this.btnGuardarLibreta.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarLibreta.TabIndex = 4;
            this.btnGuardarLibreta.Text = "Guardar";
            this.btnGuardarLibreta.UseMnemonic = false;
            this.btnGuardarLibreta.UseVisualStyleBackColor = true;
            this.btnGuardarLibreta.UseWaitCursor = true;
            // 
            // PantallaMantenedorAgregarLibreta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btnGuardarLibreta);
            this.Controls.Add(this.txtLibreta);
            this.Controls.Add(this.lbLibreta);
            this.Controls.Add(this.txtTituloLibreta);
            this.Controls.Add(this.lbTituloLibreta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaMantenedorAgregarLibreta";
            this.Text = "PantallaMantenedorAgregarLibreta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloLibreta;
        private System.Windows.Forms.TextBox txtTituloLibreta;
        private System.Windows.Forms.Label lbLibreta;
        private System.Windows.Forms.TextBox txtLibreta;
        private System.Windows.Forms.Button btnGuardarLibreta;
    }
}