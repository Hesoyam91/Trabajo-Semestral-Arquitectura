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
        public PantallaMantenedorAgregarTarea()
        {
            InitializeComponent();           
        }

        private void btnGuardarTarea_Click(object sender, EventArgs e)
        {
            try
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
                        limpiar();
                        
                    }
                    else
                    {
                        MessageBox.Show("No puede ingresar una tarea con el mismo de otra ya existente ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiar();
                        
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
        }

        private void txtTarea_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= txtTarea.TextLength; i++)
            {
                lbContadorTareas.Text = i.ToString() + "/1000";
            }
        }
    }
}
