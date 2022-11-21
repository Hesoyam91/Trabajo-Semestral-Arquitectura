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
            this.Conec1.NombreBaseDatos = "NoteItDB";
            this.Conec1.NombreTabla = "Negocios";
            this.Conec1.CadenaConexion = "Data Source=UNI\\SQLEXPRESS;Initial Catalog=NoteItDB;Integrated Security=True";

        }
        public void ConexionTareas()
        {
            this.Conec1 = new ConexionSQL();
            this.Conec1.NombreBaseDatos = "NoteItDB";
            this.Conec1.NombreTabla = "Tareas";
            this.Conec1.CadenaConexion = "Data Source=UNI\\SQLEXPRESS;Initial Catalog=NoteItDB;Integrated Security=True";

        }
        public void ConexionLibretas()
        {
            this.Conec1 = new ConexionSQL();
            this.Conec1.NombreBaseDatos = "NoteItDB";
            this.Conec1.NombreTabla = "Libretas";
            this.Conec1.CadenaConexion = "Data Source=UNI\\SQLEXPRESS;Initial Catalog=NoteItDB;Integrated Security=True";

        }
        public void guardarCliente(Transacciones transacciones)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO " + this.Conec1.NombreTabla
                                    + " (rut,nombre) VALUES ('" + transacciones.Rut + "','"
                                    + transacciones.Nombre +  "');";
            this.Conec1.EsSelect = false;
            this.Conec1.Conectar();
        }

        public void eliminarCliente(String rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM " + this.Conec1.NombreTabla
                                    + " WHERE rut = '" + rut + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.Conectar();
        }

        public void actualizarCliente(Transacciones transacciones)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE " + this.Conec1.NombreTabla
                                   + " SET"
                                   + " nombre = '" + transacciones.Nombre
                                   + "' WHERE rut = '" + transacciones.Rut + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.Conectar();
        }

        public DataSet listarTareas()
        {
            this.ConexionTareas();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla;
            this.Conec1.EsSelect = true;
            this.Conec1.Conectar();
            return this.Conec1.DbDataSet;

        }

        public DataSet listarLibretas()
        {
            this.ConexionLibretas();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla;
            this.Conec1.EsSelect = true;
            this.Conec1.Conectar();
            return this.Conec1.DbDataSet;

        }
        public DataSet listarCliente()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla;
            this.Conec1.EsSelect = true;
            this.Conec1.Conectar();
            return this.Conec1.DbDataSet;

        }


        public Transacciones buscarCliente(String rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla
                                    + " WHERE rut = '" + rut + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.Conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            Transacciones auxCliente = new Transacciones();

            if (dt.Rows.Count > 0)
            {
                auxCliente.Rut = Convert.ToString(dt.Rows[0]["rut"]);
                auxCliente.Nombre = Convert.ToString(dt.Rows[0]["nombre"]);

            }
            else
            {
                auxCliente.Rut = String.Empty;
                auxCliente.Nombre = String.Empty;
            }
            return auxCliente;

        }
        public Transacciones buscarTarea(String titulo_tareas)
        {
            this.ConexionTareas();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla
                                    + " WHERE titulo_tareas = '" + titulo_tareas + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.Conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            Transacciones auxCliente = new Transacciones();

            if (dt.Rows.Count > 0)
            {
                auxCliente.Titulo_tareas = Convert.ToString(dt.Rows[0]["titulo_tareas"]);
                auxCliente.Tareas = Convert.ToString(dt.Rows[0]["tareas"]);
                auxCliente.Fecha_tareas = Convert.ToDateTime(dt.Rows[0]["fecha_tareas"]);

            }
            else
            {
                auxCliente.Titulo_tareas = String.Empty;
                auxCliente.Tareas = String.Empty;
            }
            return auxCliente;

        }
        public Transacciones buscarLibreta(String titulo_libretas)
        {
            this.ConexionLibretas();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla
                                    + " WHERE titulo_libretas = '" + titulo_libretas + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.Conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            Transacciones auxCliente = new Transacciones();

            if (dt.Rows.Count > 0)
            {
                auxCliente.Titulo_libretas = Convert.ToString(dt.Rows[0]["titulo_libretas"]);
                auxCliente.Libretas = Convert.ToString(dt.Rows[0]["libretas"]);
                auxCliente.Fecha_libretas = Convert.ToDateTime(dt.Rows[0]["fecha_libretas"]);

            }
            else
            {
                auxCliente.Titulo_libretas = String.Empty;
                auxCliente.Libretas = String.Empty;
            }
            return auxCliente;

        }

        public Transacciones posicionCliente(int posicion)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla;

            this.Conec1.EsSelect = true;
            this.Conec1.Conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            Transacciones auxCliente = new Transacciones();

            if (dt.Rows.Count > 0)
            {
                auxCliente.Rut = Convert.ToString(dt.Rows[posicion]["rut"]);
                auxCliente.Nombre = Convert.ToString(dt.Rows[posicion]["nombre"]);

            }
            else
            {
                auxCliente.Rut = String.Empty;
                auxCliente.Nombre = String.Empty;
            }
            return auxCliente;

        }

        public DataSet retornaCliente()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM negocios";
            this.Conec1.EsSelect = true;
            this.Conec1.Conectar();

            return this.Conec1.DbDataSet;
        }

        public void agregarTarea(Transacciones transacciones)
        {
            this.ConexionTareas();
            this.Conec1.CadenaSQL = "INSERT INTO " + this.Conec1.NombreTabla
                                    + " (titulo_tareas,tareas,fecha_tareas) VALUES ('" + transacciones.Titulo_tareas + "','" + transacciones.Tareas + "','" + transacciones.Fecha_tareas + "' );";
            this.Conec1.EsSelect = false;
            this.Conec1.Conectar();
        }

        public void agregarLibreta(Transacciones transacciones)
        {
            this.ConexionLibretas();
            this.Conec1.CadenaSQL = "INSERT INTO " + this.Conec1.NombreTabla 
                                    + " (titulo_libretas,libretas,fecha_libretas) VALUES ('" + transacciones.Titulo_libretas + "','" + transacciones.Libretas + "','" + transacciones.Fecha_libretas + "' );";
            this.Conec1.EsSelect = false;
            this.Conec1.Conectar();
        }
        public void eliminarTarea(String titulo_tareas)
        {
            this.ConexionTareas();
            this.Conec1.CadenaSQL = "DELETE FROM " + this.Conec1.NombreTabla
                                    + " WHERE titulo_tareas = '" + titulo_tareas + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.Conectar();
        }
        public void eliminarLibreta(String titulo_libretas)
        {
            this.ConexionLibretas();
            this.Conec1.CadenaSQL = "DELETE FROM " + this.Conec1.NombreTabla
                                    + " WHERE titulo_libretas = '" + titulo_libretas + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.Conectar();
        }





    }//fin clase




} //fin space
 
