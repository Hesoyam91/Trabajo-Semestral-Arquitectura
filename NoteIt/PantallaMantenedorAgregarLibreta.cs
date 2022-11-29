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
        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }
        public PantallaMantenedorAgregarLibreta()
        {
            InitializeComponent();
        }

        public void mostrar()
        {
            ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
            ServiceMantenedorCliente.Transacciones auxTransacciones = new ServiceMantenedorCliente.Transacciones();
            this.ultimo = auxNegocio.webRetornarLibretas().Tables["libretas"].Rows.Count - 1;
            if (this.posicion <= 0)
                this.posicion = 0;
            if (this.posicion >= this.ultimo)
                this.posicion = this.ultimo;


            auxTransacciones = auxNegocio.webPosicionLibretas(this.posicion);

            this.txtTituloAgregarLibreta.Text = auxTransacciones.Titulo_libretas;
            this.txtAgregarLibreta.Text = auxTransacciones.Libretas;
            this.txtPosicion.Text = (this.posicion + 1) + "-" + (this.ultimo + 1);
        }



        private void btnGuardarLibreta_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnGuardarLibreta.Text.Equals("Nuevo"))
                {
                    this.habilitar();
                    this.limpiar();
                    this.desHabilitarBotonera();

                    this.btnGuardarLibreta.Text = "Grabar";
                    this.btnPrimero.Enabled = false;
                    this.btnPagAnterior.Enabled = false;
                    this.btnPagSiguiente.Enabled = false;
                    this.btnUltimo.Enabled = false;
                    this.btnEliminar.Enabled = false;
                }
                else
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
                            this.btnGuardarLibreta.Text = "Nuevo";
                            this.btnEliminar.Enabled = true;
                            this.desHabilitar();
                            this.mostrar();
                            this.habilitarBotonera();
                            limpiar();

                        }
                        else
                        {
                            MessageBox.Show("No puede ingresar una libreta con el mismo título de otra ya existente ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            limpiar();

                        }
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
            this.btnGuardarLibreta.Text = "Nuevo";
            this.desHabilitar();
            this.txtPosicion.Enabled = false;
            this.posicion = 0;
            this.mostrar();
        }

        public void desHabilitar()
        {
            this.txtAgregarLibreta.Enabled = false;
            this.txtTituloAgregarLibreta.Enabled = false;

        }


        public void habilitar()
        {
            this.txtAgregarLibreta.Enabled = true;
            this.txtTituloAgregarLibreta.Enabled = true;
            this.txtTituloAgregarLibreta.Focus();

        }
        public void habilitarBotonera()
        {
            this.btnPrimero.Enabled = true;
            this.btnPagAnterior.Enabled = true;
            this.btnPagSiguiente.Enabled = true;
            this.btnUltimo.Enabled = true;
        }

        public void desHabilitarBotonera()
        {
            this.btnPrimero.Enabled = false;
            this.btnPagAnterior.Enabled = false;
            this.btnPagSiguiente.Enabled = false;
            this.btnUltimo.Enabled = false;


        }

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion + 1;
            this.mostrar();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            this.posicion = 0;
            this.mostrar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            this.posicion = this.ultimo;
            this.mostrar();
        }

        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion - 1;
            this.mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                if (String.IsNullOrEmpty(this.txtTituloAgregarLibreta.Text) ||
                             String.IsNullOrEmpty(this.txtAgregarLibreta.Text))
                {
                    MessageBox.Show("No hay libretas por eliminar", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    auxNegocio.webEliminarLibreta(this.txtTituloAgregarLibreta.Text);
                    auxNegocio.webEliminarLibreta(this.txtAgregarLibreta.Text);
                    MessageBox.Show("Libreta Eliminada", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.mostrar();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado, por favor reinicie la aplicación e intente nuevamente" + ex.Message, "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
