using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteIt
{
    public partial class PantallaMantenedorAgregarTarea : Form
    {
        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }
        public PantallaMantenedorAgregarTarea()
        {
            InitializeComponent();           
        }

        public void mostrar()
        {
            ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
            ServiceMantenedorCliente.Transacciones auxTransacciones = new ServiceMantenedorCliente.Transacciones();
            this.ultimo = auxNegocio.webRetornarTareas().Tables["tareas"].Rows.Count - 1;
            if (this.posicion <= 0)
                this.posicion = 0;
            if (this.posicion >= this.ultimo)
                this.posicion = this.ultimo;


            auxTransacciones = auxNegocio.webPosicionTareas(this.posicion);

            this.txtTituloTarea.Text = auxTransacciones.Titulo_tareas;
            this.txtTarea.Text = auxTransacciones.Tareas;
            this.txtPosicion.Text = (this.posicion + 1) + "-" + (this.ultimo + 1);
        }

        private void btnGuardarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnGuardarTarea.Text.Equals("Nuevo"))
                {
                    this.habilitar();
                    this.limpiar();
                    this.desHabilitarBotonera();

                    this.btnGuardarTarea.Text = "Grabar";
                    this.btnPrimero.Enabled = false;
                    this.btnPagAnterior.Enabled = false;
                    this.btnPagSiguiente.Enabled = false;
                    this.btnUltimo.Enabled = false;
                    this.btnEliminar.Enabled = false;
                }
                else
                {
                    if (String.IsNullOrEmpty(this.txtTituloTarea.Text) ||
                        String.IsNullOrEmpty(this.txtTarea.Text))
                    {
                        MessageBox.Show("No ha ingresado una tarea ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtTituloTarea.Focus();
                    }
                    else
                    {
                        ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                        //Cliente existe
                        if (String.IsNullOrEmpty(auxNegocio.webBuscarTarea(this.txtTituloTarea.Text).Titulo_tareas))
                        {

                            ServiceMantenedorCliente.Transacciones auxCliente = new ServiceMantenedorCliente.Transacciones();
                            auxCliente.Titulo_tareas = this.txtTituloTarea.Text;
                            auxCliente.Tareas = this.txtTarea.Text;
                            auxCliente.Fecha_tareas.ToString("dd-MM-yyyy");




                            auxNegocio.webAgregarTarea(auxCliente);
                            MessageBox.Show("Tarea Guardada Exitosamente", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.btnGuardarTarea.Text = "Nuevo";
                            this.btnEliminar.Enabled = true;
                            this.desHabilitar();
                            this.mostrar();
                            this.habilitarBotonera();
                            limpiar();

                        }
                        else
                        {
                            MessageBox.Show("No puede ingresar una tarea con el mismo titulo de otra ya existente ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            limpiar();

                        }
                    }
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Algo ha salido mal, intentelo nuevamente" + ex.Message, "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

        }

        public void limpiar()
        {
            this.txtTituloTarea.Clear();
            this.txtTarea.Clear();
            this.txtTituloTarea.Focus();
        }



        private void PantallaMantenedorAgregarTarea_Load(object sender, EventArgs e)
        {
            lbContadorTareas.Text = "0";
            this.btnGuardarTarea.Text = "Nuevo";
            this.desHabilitar();
            this.txtPosicion.Enabled = false;
            this.posicion = 0;
            this.mostrar();
        }

        private void txtTarea_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= txtTarea.TextLength; i++)
            {
                lbContadorTareas.Text = i.ToString() + "/1000";
            }
        }


        public void desHabilitar()
        {
            this.txtTarea.Enabled = false;
            this.txtTituloTarea.Enabled = false;

        }


        public void habilitar()
        {
            this.txtTarea.Enabled = true;
            this.txtTituloTarea.Enabled = true;
            this.txtTituloTarea.Focus();

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

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            this.posicion = 0;
            this.mostrar();
        }

        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion - 1;
            this.mostrar();
        }

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion + 1;
            this.mostrar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            this.posicion = this.ultimo;
            this.mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                if (String.IsNullOrEmpty(this.txtTituloTarea.Text) ||
                             String.IsNullOrEmpty(this.txtTarea.Text))
                {
                    MessageBox.Show("No hay tareas por eliminar ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    auxNegocio.webEliminarTarea(this.txtTituloTarea.Text);
                    auxNegocio.webEliminarTarea(this.txtTarea.Text);
                    MessageBox.Show("Tarea Eliminada", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

