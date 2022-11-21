using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteIt
{
    public partial class PantallaMantenedorListarTareas : Form
    {
        public PantallaMantenedorListarTareas()
        {
            InitializeComponent();
        }

        private void PantallaMantenedorListarTareas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'noteItDBDataSetTareas.Tareas' Puede moverla o quitarla según sea necesario.
            this.tareasTableAdapter.Fill(this.noteItDBDataSetTareas.Tareas);

        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de querer eliminar esta nota?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rows = DataGVTareas.RowCount;
                    for(int i = rows - 1; i >= 0; i--)
                    {
                        if (DataGVTareas.Rows[i].Selected) 
                        {
                            ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                            auxNegocio.webEliminarTarea(DataGVTareas.Rows[i].Index.ToString());
                            tareasBindingSource.RemoveAt(DataGVTareas.Rows[i].Index);
                            tareasBindingSource.EndEdit();
                        }
                    }
                     

                    
                }
                //ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient auxNegocio = new ServiceMantenedorCliente.WebServiceMantenedorClienteSoapClient();
                if (String.IsNullOrEmpty(this.DataGVTareas.ToString()))
                {
                    MessageBox.Show("No hay datos por eliminar ", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    //auxNegocio.webEliminarCliente(DataGVTareas.Rows[i]);
                    
                    MessageBox.Show("Los datos han sido eliminados", "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error inesperado, por favor reinicie la aplicación e intente nuevamente" + ex.Message, "NoteIt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
