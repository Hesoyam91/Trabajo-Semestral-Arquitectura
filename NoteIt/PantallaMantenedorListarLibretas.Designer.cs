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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnListarLibretas = new System.Windows.Forms.Button();
            this.btnEliminarLibretas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 324);
            this.textBox1.TabIndex = 0;
            // 
            // btnListarLibretas
            // 
            this.btnListarLibretas.Location = new System.Drawing.Point(309, 415);
            this.btnListarLibretas.Name = "btnListarLibretas";
            this.btnListarLibretas.Size = new System.Drawing.Size(75, 23);
            this.btnListarLibretas.TabIndex = 1;
            this.btnListarLibretas.Text = "Listar";
            this.btnListarLibretas.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLibretas
            // 
            this.btnEliminarLibretas.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarLibretas.Location = new System.Drawing.Point(604, 415);
            this.btnEliminarLibretas.Name = "btnEliminarLibretas";
            this.btnEliminarLibretas.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLibretas.TabIndex = 2;
            this.btnEliminarLibretas.Text = "Eliminar";
            this.btnEliminarLibretas.UseVisualStyleBackColor = false;
            // 
            // PantallaMantenedorListarLibretas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btnEliminarLibretas);
            this.Controls.Add(this.btnListarLibretas);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaMantenedorListarLibretas";
            this.Text = "PantallaMantenedorListarLibretas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnListarLibretas;
        private System.Windows.Forms.Button btnEliminarLibretas;
    }
}