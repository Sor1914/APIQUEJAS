﻿using APIQUEJAS.Clases;
using APIQUEJAS.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http;
using APIQUEJAS.Security;

namespace APIQUEJAS.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("API/LOGIN")]
    public class LoginController : ApiController
    {
        clsLogin _Consultas = new clsLogin();
        clsLog _Log = new clsLog();
        /*
         * Code = "200" - Devuelve el JWT 
         * Code = "401" - Noe está autorizado
         */
        [HttpPost]
        [Route("AUTENTICAR")]
        public IHttpActionResult Autenticar(LoguinRequest login)
        {
            _Log.guardarBitacora("Login");
            _Log.guardarBitacoraCuerpo("Solicitud recibida", "Autenticar", JsonConvert.SerializeObject(login));
            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            if (!validarParametro(login.Usuario) || !validarParametro(login.Pass))
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            bool existe = _Consultas.validarExistenciaUsuario(login.Usuario.Trim(), login.Pass.Trim());

            if (existe)
            {
                var token = TokenGenerator.GeneraTokenJwt(login.Usuario);
                _Log.guardarBitacoraCuerpo("Token generado", "Autenticar", token + " usuario: " + login.Usuario.Trim());
                return Ok(token);
            }
            else
            {
                _Log.guardarBitacoraCuerpo("Solicitud rechazada", "Autenticar", "No autorizado");
                return Unauthorized();
            }

        }

        public bool validarParametro(string valor)
        {
            bool resultado = Regex.IsMatch(valor, @"^([a-z]|[A-Z]|[0-9]){4,20}$");
            return resultado;
        }
    }
}