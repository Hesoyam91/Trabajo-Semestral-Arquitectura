using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteIt
{
    public partial class PantallaMantenedorNotas : Form
    {
        public PantallaMantenedorNotas()
        {
            InitializeComponent();
        }

        private void btnVolverNotas_Click(object sender, EventArgs e)
        {
            PantallaMantenedorMenu pMenu = new PantallaMantenedorMenu();
            this.Dispose();
            GC.Collect();
            pMenu.Show();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            AbrirFormHeredado(new PantallaMantenedorAgregarTarea());
        }

        private void AbrirFormHeredado(object formheredado)
        {
            if (this.CPanelPrincipal.Controls.Count > 0)
                this.CPanelPrincipal.Controls.RemoveAt(0);
            Form PantallaMantenedorAgregarTarea = formheredado as Form;
            PantallaMantenedorAgregarTarea.TopLevel = false;
            PantallaMantenedorAgregarTarea.Dock = DockStyle.Fill;
            this.CPanelPrincipal.Controls.Add(PantallaMantenedorAgregarTarea);
            this.CPanelPrincipal.Tag = PantallaMantenedorAgregarTarea;
            PantallaMantenedorAgregarTarea.Show();

        }

        private void btnAgregarLibreta_Click(object sender, EventArgs e)
        {
            AbrirFormHeredado(new PantallaMantenedorAgregarLibreta());
        }

        private void btnListarTareas_Click(object sender, EventArgs e)
        {
            AbrirFormHeredado(new PantallaMantenedorListarTareas());
        }

        private void btnListarLibretas_Click(object sender, EventArgs e)
        {
            AbrirFormHeredado(new PantallaMantenedorListarLibretas());
        }
    }
}
