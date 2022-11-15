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
            this.txtListarTareas = new System.Windows.Forms.TextBox();
            this.btnListarTareas = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtListarTareas
            // 
            this.txtListarTareas.Location = new System.Drawing.Point(66, 12);
            this.txtListarTareas.Multiline = true;
            this.txtListarTareas.Name = "txtListarTareas";
            this.txtListarTareas.Size = new System.Drawing.Size(555, 375);
            this.txtListarTareas.TabIndex = 1;
            // 
            // btnListarTareas
            // 
            this.btnListarTareas.Location = new System.Drawing.Point(315, 415);
            this.btnListarTareas.Name = "btnListarTareas";
            this.btnListarTareas.Size = new System.Drawing.Size(75, 23);
            this.btnListarTareas.TabIndex = 2;
            this.btnListarTareas.Text = "Listar";
            this.btnListarTareas.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Location = new System.Drawing.Point(604, 415);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTarea.TabIndex = 3;
            this.btnEliminarTarea.Text = "Eliminar";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            // 
            // PantallaMantenedorListarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnListarTareas);
            this.Controls.Add(this.txtListarTareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaMantenedorListarTareas";
            this.Text = "PantallaMantenedorListarTareas";
            this.Load += new System.EventHandler(this.PantallaMantenedorListarTareas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListarTareas;
        private System.Windows.Forms.Button btnListarTareas;
        private System.Windows.Forms.Button btnEliminarTarea;
    }
}