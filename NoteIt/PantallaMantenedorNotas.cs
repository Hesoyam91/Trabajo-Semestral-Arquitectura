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
    public partial class PantallaMantenedorNotas : Form
    {
        public PantallaMantenedorNotas()
        {
            InitializeComponent();
        }

        private void btnVolverNotas_Click(object sender, EventArgs e)
        {
            PantallaMantenedorMenu pMenu = new PantallaMantenedorMenu();
            this.Dispose();
            GC.Collect();
            pMenu.Show();
        }
    }
}
