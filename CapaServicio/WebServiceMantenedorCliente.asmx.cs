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
            return auxNegocio.listarNotas();
        }

        [WebMethod]
        public Transacciones webBuscarCliente(String rut)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            return auxNegocio.buscarCliente(rut);
        }

        [WebMethod]
        public Transacciones webPosicionCliente(int fila)
        {
            NegocioNotas auxNegocio = new NegocioNotas();
            return auxNegocio.posicionCliente(fila);
        }








    }
}

