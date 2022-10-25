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
    public partial class PantallaMantenedorAdministrador : Form
    {
        public PantallaMantenedorAdministrador()
        {
            InitializeComponent();
        }

        private void btnVolverAdmin_Click(object sender, EventArgs e)
        {
            PantallaMantenedorMenu pMenu = new PantallaMantenedorMenu();
            this.Dispose();
            GC.Collect();
            pMenu.Show();
        }

        private void btnGrabarAdmin_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnGrabarAdmin_MouseLeave(object sender, EventArgs e)
        {
            Cursor=Cursors.Default;
        }

        private void btnActualizarAdmin_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnActualizarAdmin_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnListarAdminn_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnListarAdminn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnEliminarAdmin_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnEliminarAdmin_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnVolverAdmin_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnVolverAdmin_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void PantallaMantenedorAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
