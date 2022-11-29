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
            if (MessageBox.Show("¿Está seguro de que desea salir?",
                       "NoteIt",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
                System.GC.Collect();
            }
        }


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            PantallaMantenedorAdministrador pAdministrador = new PantallaMantenedorAdministrador();
            this.Hide();
            pAdministrador.Show();

            

        }

        

        private void btnIngresarMenu_Click(object sender, EventArgs e)
        {
            PantallaMantenedorNotas pNotas = new PantallaMantenedorNotas();
            this.Hide();
            pNotas.Show();
        }


    }
}
