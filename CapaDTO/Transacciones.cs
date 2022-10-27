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
        private String notas;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Notas { get => notas; set => notas = value; }
    }
}

