using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Transacciones
    {
        private String rut;
        private String nombre;
        private String tareas;
        private String libretas;
        private String titulo_tareas;
        private String titulo_libretas;
        private DateTime fecha_tareas;
        private DateTime fecha_libretas;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tareas { get => tareas; set => tareas = value; }
        public string Libretas { get => libretas; set => libretas = value; }
        public string Titulo_tareas { get => titulo_tareas; set => titulo_tareas = value; }
        public string Titulo_libretas { get => titulo_libretas; set => titulo_libretas = value; }
        public DateTime Fecha_tareas { get => fecha_tareas; set => fecha_tareas = value; }
        public DateTime Fecha_libretas { get => fecha_libretas; set => fecha_libretas = value; }
    }
}

