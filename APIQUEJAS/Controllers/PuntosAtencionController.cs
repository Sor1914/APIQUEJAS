﻿using APIQUEJAS.Clases;
using APIQUEJAS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace APIQUEJAS.Controllers
{
    [Authorize]
    [RoutePrefix("API/PUNTOSATENCION")]
    public class PuntosAtencionController : ApiController
    {
        string mensaje;
        clsPuntoAtencion _Consultas = new clsPuntoAtencion();
        [HttpPost]
        [Route("AgregarPunto")]
        public IHttpActionResult agregarPuntoAtencion([FromBody] PuntoAtencion Punto)
        {
            if (!ModelState.IsValid)
            {
                var mensaje = string.Format("Verifique todos los parámetros de entrada.");
                throw new HttpResponseException(
                   Request.CreateErrorResponse(HttpStatusCode.BadRequest, mensaje));
            }
            try
            {
                bool resultado = _Consultas.insertarPunto(Punto);
                if (resultado)
                    return Content(HttpStatusCode.Created, Punto.NombrePuntoAtencion);
                else
                    return Content(HttpStatusCode.InternalServerError, "Hubo un error");
            } catch(Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }            
        }

        [HttpPost]
        [Route("ActualizarPunto")]
        public IHttpActionResult actualizarPuntoAtencion([FromBody] PuntoAtencion Punto)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Format("Verifique todos los parámetros de entrada.");
                throw new HttpResponseException(
                   Request.CreateErrorResponse(HttpStatusCode.BadRequest, message));
            }
            try
            {
                bool resultado = _Consultas.actualizarPunto(Punto);
                if (resultado)
                    return Ok();
                else
                    return Content(HttpStatusCode.InternalServerError, "Hubo un error");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("EliminarPunto")]
        public IHttpActionResult eliminarPuntoAtencion([FromBody] PuntoAtencion Punto)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Format("Verifique todos los parámetros de entrada.");
                throw new HttpResponseException(
                   Request.CreateErrorResponse(HttpStatusCode.BadRequest, message));
            }
            try
            {
                bool resultado = _Consultas.eliminarPunto(Punto);
                if (resultado)
                    return Ok();
                else
                    return Content(HttpStatusCode.InternalServerError, "Hubo un error");
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("ObtenerPuntos")]
        public IHttpActionResult obtenerPuntosAtencion()
        {
            if (!ModelState.IsValid)
            {
                var message = string.Format("Verifique todos los parámetros de entrada.");
                throw new HttpResponseException(
                   Request.CreateErrorResponse(HttpStatusCode.BadRequest, message));
            }
            try
            {
                DataTable dtResultado = _Consultas.obtenerPuntos();
                if (dtResultado.Rows.Count > 0)
                    return Content(HttpStatusCode.Found, dtResultado);
                else
                    return Content(HttpStatusCode.NotFound, "No existen registros");
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return Content(HttpStatusCode.InternalServerError, mensaje);
            }
        }

        [HttpGet]
        [Route("ObtenerRegiones")]
        public IHttpActionResult obtenerRegiones()
        {
            if (!ModelState.IsValid)
            {
                var message = string.Format("Verifique todos los parámetros de entrada.");
                throw new HttpResponseException(
                   Request.CreateErrorResponse(HttpStatusCode.BadRequest, message));
            }
            try
            {
                DataTable dtResultado = _Consultas.obtenerRegiones();
                if (dtResultado.Rows.Count > 0)
                    return Content(HttpStatusCode.Found, dtResultado);
                else
                    return Content(HttpStatusCode.NotFound, "No existen registros");
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return Content(HttpStatusCode.InternalServerError, mensaje);
            }
        }
    }
}
