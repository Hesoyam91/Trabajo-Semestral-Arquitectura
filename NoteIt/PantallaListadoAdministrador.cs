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
    public partial class PantallaListadoAdministrador : Form
    {
        public PantallaListadoAdministrador()
        {
            InitializeComponent();
        }

        private void btnListarAdmin_Click(object sender, EventArgs e)
        {
            ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();

            this.dgbListarAdmin.DataSource = auxNegocio.webListarCliente();
            this.dgbListarAdmin.DataMember = "Negocios";
        }

        private void btnSalirListarAdmin_Click(object sender, EventArgs e)
        {
            PantallaMantenedorAdministrador pAdministrador = new PantallaMantenedorAdministrador();
            this.Hide();
            pAdministrador.Show();
        }
    }
}
