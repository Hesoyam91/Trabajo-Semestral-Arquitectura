namespace NoteIt
{
    partial class PantallaMantenedorNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaMantenedorNotas));
            this.CPanelNotas = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnVolverNotas = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CPanelNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPanelNotas
            // 
            this.CPanelNotas.AutoSize = true;
            this.CPanelNotas.BackColor = System.Drawing.Color.Transparent;
            this.CPanelNotas.BorderColor = System.Drawing.Color.Blue;
            this.CPanelNotas.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.CPanelNotas.Controls.Add(this.btnVolverNotas);
            this.CPanelNotas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CPanelNotas.FillColor2 = System.Drawing.Color.CornflowerBlue;
            this.CPanelNotas.Location = new System.Drawing.Point(0, -4);
            this.CPanelNotas.Name = "CPanelNotas";
            this.CPanelNotas.Size = new System.Drawing.Size(1155, 611);
            this.CPanelNotas.TabIndex = 0;
            // 
            // btnVolverNotas
            // 
            this.btnVolverNotas.Animated = true;
            this.btnVolverNotas.AutoRoundedCorners = true;
            this.btnVolverNotas.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverNotas.BorderColor = System.Drawing.Color.Transparent;
            this.btnVolverNotas.BorderRadius = 15;
            this.btnVolverNotas.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnVolverNotas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolverNotas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolverNotas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolverNotas.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolverNotas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolverNotas.FillColor = System.Drawing.Color.Snow;
            this.btnVolverNotas.FillColor2 = System.Drawing.Color.SteelBlue;
            this.btnVolverNotas.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverNotas.ForeColor = System.Drawing.Color.White;
            this.btnVolverNotas.Location = new System.Drawing.Point(488, 528);
            this.btnVolverNotas.Name = "btnVolverNotas";
            this.btnVolverNotas.Size = new System.Drawing.Size(180, 33);
            this.btnVolverNotas.TabIndex = 1;
            this.btnVolverNotas.Text = "Volver";
            this.btnVolverNotas.Click += new System.EventHandler(this.btnVolverNotas_Click);
            // 
            // PantallaMantenedorNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 597);
            this.ControlBox = false;
            this.Controls.Add(this.CPanelNotas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaMantenedorNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteIt";
            this.CPanelNotas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel CPanelNotas;
        private Guna.UI2.WinForms.Guna2GradientButton btnVolverNotas;
    }
}