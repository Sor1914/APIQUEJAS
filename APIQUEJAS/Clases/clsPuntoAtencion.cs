using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using APIQUEJAS.Models;
using APIQUEJAS.Sql;

namespace APIQUEJAS.Clases
{
    public class clsPuntoAtencion    
    {
        string consulta;
        clsSqlServer _Ad = new clsSqlServer();
        DataTable dtResultado = new DataTable();
        bool respuesta;       

        public bool insertarPunto(PuntoAtencion punto)
        {
            consulta = string.Format(sqlPuntosAtencion.InsertaPunto, punto.NombrePuntoAtencion, punto.IdRegion, punto.Estado);
            respuesta = _Ad.realizarDml(consulta);
            return respuesta;
        }

        public bool actualizarPunto(PuntoAtencion punto)
        {
            consulta = string.Format(sqlPuntosAtencion.ActualizaPunto, punto.NombrePuntoAtencion, punto.IdRegion, punto.Id);
            respuesta = _Ad.realizarDml(consulta);
            return respuesta;
        }

        public bool eliminarPunto(PuntoAtencion punto)
        {
            consulta = string.Format(sqlPuntosAtencion.EliminaPunto, 'E', punto.Id);
            respuesta = _Ad.realizarDml(consulta);
            return respuesta;
        }

        public DataTable obtenerPuntos(PuntoAtencion punto)
        {
            string filtroRegion = "";
            string filtroBusqueda = "";
            if(punto.IdRegion != 0)            
                filtroRegion = string.Format(sqlPuntosAtencion.FiltroRegion, punto.IdRegion);            
            if (!string.IsNullOrEmpty(punto.busqueda))            
                filtroBusqueda = string.Format(sqlPuntosAtencion.FiltroBusqueda, punto.busqueda.Trim().ToUpper());            
            consulta = string.Format(sqlPuntosAtencion.ObtienePuntos, filtroRegion, filtroBusqueda);
            dtResultado = _Ad.realizarConsulta(consulta);
            return dtResultado;
        }

        public DataTable obtenerRegiones()
        {
            consulta = string.Format(sqlPuntosAtencion.ObtieneRegiones);
            dtResultado = _Ad.realizarConsulta(consulta);
            return dtResultado;
        }


    }
}