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
            this.SuspendLayout();
            // 
            // lbTituloTarea
            // 
            this.lbTituloTarea.AutoSize = true;
            this.lbTituloTarea.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloTarea.Location = new System.Drawing.Point(12, 39);
            this.lbTituloTarea.Name = "lbTituloTarea";
            this.lbTituloTarea.Size = new System.Drawing.Size(73, 16);
            this.lbTituloTarea.TabIndex = 0;
            this.lbTituloTarea.Text = "Titulo Tarea";
            // 
            // txtTituloTarea
            // 
            this.txtTituloTarea.Location = new System.Drawing.Point(107, 39);
            this.txtTituloTarea.Name = "txtTituloTarea";
            this.txtTituloTarea.Size = new System.Drawing.Size(274, 20);
            this.txtTituloTarea.TabIndex = 1;
            // 
            // lbTarea
            // 
            this.lbTarea.AutoSize = true;
            this.lbTarea.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTarea.Location = new System.Drawing.Point(12, 111);
            this.lbTarea.Name = "lbTarea";
            this.lbTarea.Size = new System.Drawing.Size(38, 16);
            this.lbTarea.TabIndex = 2;
            this.lbTarea.Text = "Tarea";
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(107, 111);
            this.txtTarea.Multiline = true;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(393, 240);
            this.txtTarea.TabIndex = 3;
            // 
            // btnGuardarTarea
            // 
            this.btnGuardarTarea.Location = new System.Drawing.Point(306, 395);
            this.btnGuardarTarea.Name = "btnGuardarTarea";
            this.btnGuardarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTarea.TabIndex = 4;
            this.btnGuardarTarea.Text = "Guardar";
            this.btnGuardarTarea.UseVisualStyleBackColor = true;
            // 
            // PantallaMantenedorAgregarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btnGuardarTarea);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.lbTarea);
            this.Controls.Add(this.txtTituloTarea);
            this.Controls.Add(this.lbTituloTarea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaMantenedorAgregarTarea";
            this.Text = "PantallaMantenedorAgregarTarea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloTarea;
        private System.Windows.Forms.TextBox txtTituloTarea;
        private System.Windows.Forms.Label lbTarea;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnGuardarTarea;
    }
}