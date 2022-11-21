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
        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }
        public PantallaMantenedorAdministrador()
        {
            InitializeComponent();
        }



        private void btnVolverAdmin_Click(object sender, EventArgs e)
        {
            if (this.btnVolverAdmin.Text.Equals("Volver"))
            {
                PantallaMantenedorMenu pMenu = new PantallaMantenedorMenu();
                this.Dispose();
                GC.Collect();
                pMenu.Show();
            }
            else
            {
                this.btnGrabarAdmin.Text = "Nuevo";
                this.btnVolverAdmin.Text = "Volver";
                this.btnActualizarAdmin.Enabled = true;
                this.btnEliminarAdmin.Enabled = true;
                this.btnListarAdminn.Enabled = true;
                this.btnPrimero.Enabled = true;
                this.btnPagAnterior.Enabled = true;
                this.btnPagSiguiente.Enabled = true;
                this.btnUltimo.Enabled = true;
                this.posicion = 0;
                this.mostrar();
            }

        }

        public void limpiar()
        {
            this.txtRutAdmin.Clear();
            this.txtNombreAdmin.Clear();
            this.txtRutAdmin.Focus();
        }


        private void PantallaMantenedorAdministrador_Load(object sender, EventArgs e)
        {
            this.btnGrabarAdmin.Text = "Nuevo";
            this.desHabilitar();
            this.txtPosicionAdmin.Enabled = false;
            this.posicion = 0;
            this.mostrar();
        }
        public void desHabilitar()
        {
            this.txtRutAdmin.Enabled = false;
            this.txtNombreAdmin.Enabled = false;

        }


        public void habilitar()
        {
            this.txtRutAdmin.Enabled = true;
            this.txtNombreAdmin.Enabled = true;
            this.txtRutAdmin.Focus();

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

        public void mostrar()
        {
            ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
            ServiceMantenedorCliente.Transacciones auxTransacciones = new ServiceMantenedorCliente.Transacciones();
            this.ultimo = auxNegocio.webRetornarCliente().Tables["Negocios"].Rows.Count - 1;
            if (this.posicion <= 0)
                this.posicion = 0;
            if (this.posicion >= this.ultimo)
                this.posicion = this.ultimo;


            auxTransacciones = auxNegocio.webPosicionCliente(this.posicion);

            this.txtRutAdmin.Text = auxTransacciones.Rut;
            this.txtNombreAdmin.Text = auxTransacciones.Nombre;
            this.txtPosicionAdmin.Text = (this.posicion + 1) + "-" + (this.ultimo + 1);
        }

        private void btnPagSiguiente_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion + 1;
            this.mostrar();
        }

        private void btnPagAnterior_Click(object sender, EventArgs e)
        {
            this.posicion = this.posicion - 1;
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

        private void btnListarAdminn_Click(object sender, EventArgs e)
        {
            PantallaListadoAdministrador pListado = new PantallaListadoAdministrador();
            this.Hide();
            pListado.Show();
        }

        private void btnGrabarAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnGrabarAdmin.Text.Equals("Nuevo"))
                {
                    this.habilitar();
                    this.limpiar();
                    this.desHabilitarBotonera();

                    this.btnGrabarAdmin.Text = "Grabar";
                    this.btnVolverAdmin.Text = "Cancelar";
                    this.btnActualizarAdmin.Enabled = false;
                    this.btnEliminarAdmin.Enabled = false;
                    this.btnListarAdminn.Enabled = false;
                    this.btnPrimero.Enabled = false;
                    this.btnPagAnterior.Enabled = false;
                    this.btnPagSiguiente.Enabled = false;
                    this.btnUltimo.Enabled = false;
                }
                else
                {

                    if (String.IsNullOrEmpty(this.txtRutAdmin.Text) ||
                         String.IsNullOrEmpty(this.txtNombreAdmin.Text))
                    {
                        MessageBox.Show("Por favor ingrese rut y nombre ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtRutAdmin.Focus();
                    }
                    else
                    {

                        
                        ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                        //Cliente existe
                        if (String.IsNullOrEmpty(auxNegocio.webBuscarCliente(this.txtRutAdmin.Text).Rut))
                        {

                            ServiceMantenedorCliente.Transacciones auxCliente = new ServiceMantenedorCliente.Transacciones();
                            auxCliente.Rut = this.txtRutAdmin.Text;
                            auxCliente.Nombre = this.txtNombreAdmin.Text;

                            auxNegocio.webGuardarCliente(auxCliente);
                            MessageBox.Show("Datos guardados ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.btnGrabarAdmin.Text = "Nuevo";
                            this.desHabilitar();
                            this.mostrar();
                            this.habilitarBotonera();
                            this.btnEliminarAdmin.Enabled = true;
                            this.btnActualizarAdmin.Enabled = true;
                            this.btnListarAdminn.Enabled = true;
                            this.btnVolverAdmin.Text = "Salir";
                        }
                        else
                        {
                            if (!validarRut(this.txtRutAdmin.Text))
                            {
                                MessageBox.Show("Rut Invalido", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.btnVolverAdmin_Click(sender, e);
                            }
                            MessageBox.Show("El cliente que ha tratado de ingresar ya existe ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.btnVolverAdmin_Click(sender, e);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos No guardados " + ex.Message, "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtNombreAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;

            if (Char.IsDigit(letra))
                e.Handled = true;
        }

        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un rut valido" + ex.Message, "NoteIt",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validacion;
        }

        private void btnActualizarAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtRutAdmin.Text) ||
                String.IsNullOrEmpty(this.txtNombreAdmin.Text))
                {
                    MessageBox.Show("No existen datos actualizables ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtRutAdmin.Focus();
                }
                else
                {
                    ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                    if (String.IsNullOrEmpty(auxNegocio.webBuscarCliente(this.txtRutAdmin.Text).Rut))
                    {
                        ServiceMantenedorCliente.Transacciones auxCliente = new ServiceMantenedorCliente.Transacciones();
                        auxCliente.Rut = this.txtRutAdmin.Text;
                        auxCliente.Nombre = this.txtNombreAdmin.Text;
                        this.habilitar();
                        this.habilitarBotonera();

                        auxNegocio.webActualizarCliente(auxCliente);
                        MessageBox.Show("Datos actualizados ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Datos No actualizados " + ex.Message, "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            


        }

        private void btnEliminarAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                if (String.IsNullOrEmpty(this.txtRutAdmin.Text) ||
                             String.IsNullOrEmpty(this.txtNombreAdmin.Text))
                {
                    MessageBox.Show("No hay datos por eliminar ", "NoteIt",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
                else
                {
                    auxNegocio.webEliminarCliente(this.txtRutAdmin.Text);
                    auxNegocio.webEliminarCliente(this.txtNombreAdmin.Text);
                    MessageBox.Show("Los datos han sido eliminados", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.mostrar();
                }
            }

            catch(Exception ex) 
            {
                MessageBox.Show("Se ha producido un error inesperado, por favor reinicie la aplicación e intente nuevamente" + ex.Message, "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            

               


        }

        private void PantallaMantenedorAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer volver a la pantalla de inicio?",
                               "NoteIt",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true; //Cancela el cerrado del formulario
            }
        }
    }
}
