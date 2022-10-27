using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaConexion
{
    public class ConexionSQL
    {
        private string nombreBaseDatos;
        private string nombreTabla;
        private string cadenaConexion;
        private string cadenaSQL;
        private Boolean esSelect;
        private SqlConnection dbConnection;
        private DataSet dbDataSet;
        private SqlDataAdapter dbDataAdapter;

        public string NombreBaseDatos { get => nombreBaseDatos; set => nombreBaseDatos = value; }
        public string NombreTabla { get => nombreTabla; set => nombreTabla = value; }
        public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        public string CadenaSQL { get => cadenaSQL; set => cadenaSQL = value; }
        public bool EsSelect { get => esSelect; set => esSelect = value; }
        public SqlConnection DbConnection { get => dbConnection; set => dbConnection = value; }
        public DataSet DbDataSet { get => dbDataSet; set => dbDataSet = value; }
        public SqlDataAdapter DbDataAdapter { get => dbDataAdapter; set => dbDataAdapter = value; }


        public void Abrir()
        {
            try
            {
                this.dbConnection.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al tratar de abrir conexión" + ex.Message, "Sistema");
            }
        }//abrir conexion

        public void Cerrar()
        {
            try
            {
                this.dbConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al tratar de cerrar conexión" + ex.Message, "Sistema");
            }
        }//cerrar conexion

        public void Conectar()
        {
            if (this.nombreBaseDatos.Length == 0)
            {
                MessageBox.Show("Error nombre base de datos", "Sistema");
                return;
            }
            if (this.nombreTabla.Length == 0)
            {
                MessageBox.Show("Error nombre tabla", "Sistema");
                return;
            }
            if (this.cadenaConexion.Length == 0)
            {
                MessageBox.Show("Error cadena de conexion", "Sistema");
                return;
            }
            if (this.cadenaSQL.Length == 0)
            {
                MessageBox.Show("Error cadena SQL", "Sistema");
                return;
            }

            //Se genera instancia de conexion
            try
            {
                this.dbConnection = new SqlConnection(this.cadenaConexion);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la conexión" + ex.Message, "Sistema");
                return; ;
            }

            this.Abrir();

            //Instrucciones SQL
            if (this.esSelect)//Select
            {
                this.DbDataSet = new DataSet();
                try
                {
                    this.dbDataAdapter = new SqlDataAdapter(this.cadenaSQL, this.dbConnection);
                    this.dbDataAdapter.Fill(this.dbDataSet, this.nombreTabla);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al cargar DataSet" + ex.Message, "Sistema");
                    return; ;
                }
            }
            else//Insert - Update - Delete
            {
                try
                {
                    SqlCommand variableSQL = new SqlCommand(this.cadenaSQL, this.dbConnection);
                    variableSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error instrucción SQL" + ex.Message, "Sistema");
                    return;
                }
            }

            this.Cerrar();

        }//conectar a DB


    }//fin clase
}//fin space
