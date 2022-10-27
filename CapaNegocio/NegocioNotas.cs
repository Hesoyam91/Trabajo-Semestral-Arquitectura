using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioNotas
    {
        private ConexionSQL conec1;

        public ConexionSQL Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.Conec1 = new ConexionSQL();
            this.Conec1.NombreBaseDatos = "prueba";
            this.Conec1.NombreTabla = "transaccion";
            this.Conec1.CadenaConexion = "Data Source=UNI\\SQLEXPRESS;Initial Catalog=prueba;Integrated Security=True";

        }

        


    } //fin clase
} //fin space
