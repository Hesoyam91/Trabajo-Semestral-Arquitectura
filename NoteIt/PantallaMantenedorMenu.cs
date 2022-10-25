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
    public partial class PantallaMantenedorMenu : Form
    {
        public PantallaMantenedorMenu()
        {


            InitializeComponent();

        }



        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.GC.Collect(); 
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            PantallaMantenedorAdministrador pAdministrador = new PantallaMantenedorAdministrador();
            this.Hide();
            pAdministrador.Show();

            

        }

        private void btnAdmin_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnIngresarMenu_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnIngresarMenu_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnSalirMenu_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnSalirMenu_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnIngresarMenu_Click(object sender, EventArgs e)
        {
            PantallaMantenedorNotas pNotas = new PantallaMantenedorNotas();
            this.Hide();
            pNotas.Show();
        }
    }
}
