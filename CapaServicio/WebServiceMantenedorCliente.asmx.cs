using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Util;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceMantenedorCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorCliente : System.Web.Services.WebService
    {

        [WebMethod]
        public void webGuardarCliente(Transacciones transacciones)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            auxNegocio.guardarCliente(transacciones);
        }

        [WebMethod]
        public void webEliminarCliente(String rut)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            auxNegocio.eliminarCliente(rut);
        }

        [WebMethod]
        public void webActualizarCliente(Transacciones transacciones)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            auxNegocio.actualizarCliente(transacciones);
        }

        [WebMethod]
        public DataSet webListarCliente()
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            return auxNegocio.listarCliente();
        }

        [WebMethod]
        public Transacciones webBuscarCliente(String rut)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            return auxNegocio.buscarCliente(rut);
        }
        [WebMethod]
        public Transacciones webBuscarTarea(String titulo_tareas)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            return auxNegocio.buscarTarea(titulo_tareas);
        }
        [WebMethod]
        public Transacciones webBuscarLibreta(String titulo_libretas)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            return auxNegocio.buscarLibreta(titulo_libretas);
        }

        [WebMethod]
        public Transacciones webPosicionCliente(int fila)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            return auxNegocio.posicionCliente(fila);
        }

        [WebMethod]
        public DataSet webRetornarCliente()
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            return auxNegocio.retornaCliente();
        }

        [WebMethod]
        public void webAgregarTarea(Transacciones transacciones)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            auxNegocio.agregarTarea(transacciones);
        }
        [WebMethod]
        public void webAgregarLibreta(Transacciones transacciones)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            auxNegocio.agregarLibreta(transacciones);
        }
        [WebMethod]
        public DataSet webListarTareas()
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            return auxNegocio.listarTareas();
        }

        [WebMethod]
        public DataSet webListarLibretas()
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            return auxNegocio.listarLibretas();
        }
        [WebMethod]
        public void webEliminarTarea(String titulo_tareas)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            auxNegocio.eliminarCliente(titulo_tareas);
        }
        [WebMethod]
        public void webEliminarLibreta(String titulo_libretas)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            auxNegocio.eliminarCliente(titulo_libretas);
        }






    }
}

