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
        public void guardarCliente(Transacciones transacciones)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO " + this.Conec1.NombreTabla
                                    + " (rut,nombre,notas) VALUES ('" + transacciones.Rut + "','"
                                    + transacciones.Nombre + "','" + transacciones.Notas + "');";
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

        public DataSet listarNotas()
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

        public Transacciones posicionCliente(int fila)
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
                auxCliente.Rut = Convert.ToString(dt.Rows[fila]["rut"]);
                auxCliente.Nombre = Convert.ToString(dt.Rows[fila]["nombre"]);

            }
            else
            {
                auxCliente.Rut = String.Empty;
                auxCliente.Nombre = String.Empty;
            }
            return auxCliente;

        }





    }//fin clase




} //fin space
 
