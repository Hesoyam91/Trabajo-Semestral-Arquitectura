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
    public partial class PantallaMantenedorAgregarLibreta : Form
    {
        public PantallaMantenedorAgregarLibreta()
        {
            InitializeComponent();
        }

        private void btnGuardarLibreta_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtTituloAgregarLibreta.Text) ||
                         String.IsNullOrEmpty(this.txtAgregarLibreta.Text))
                {
                    MessageBox.Show("No ha ingresado una libreta ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtTituloAgregarLibreta.Focus();
                }
                else
                {
                    ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                    //Cliente existe
                    if (String.IsNullOrEmpty(auxNegocio.webBuscarLibreta(this.txtTituloAgregarLibreta.Text).Titulo_libretas))
                    {

                        ServiceMantenedorCliente.Transacciones auxCliente = new ServiceMantenedorCliente.Transacciones();
                        auxCliente.Titulo_libretas = this.txtTituloAgregarLibreta.Text;
                        auxCliente.Libretas = this.txtAgregarLibreta.Text;
                        auxCliente.Fecha_libretas.ToString("dd-MM-yyyy");




                        auxNegocio.webAgregarLibreta(auxCliente);
                        MessageBox.Show("Libreta Guardada Exitosamente", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();

                    }
                    else
                    {
                        MessageBox.Show("No puede ingresar una libreta con el mismo título de otra ya existente ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiar();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo ha salido mal, intentelo nuevamente" + ex.Message, "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void limpiar()
        {
            this.txtTituloAgregarLibreta.Clear();
            this.txtAgregarLibreta.Clear();
            this.txtTituloAgregarLibreta.Focus();
        }

        private void txtAgregarLibreta_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= txtAgregarLibreta.TextLength; i++)
            {
                lbContadorLibretas.Text = i.ToString() + "/5000";
            }
        }

        private void PantallaMantenedorAgregarLibreta_Load(object sender, EventArgs e)
        {
            lbContadorLibretas.Text = "0";
        }
    }
    
}
