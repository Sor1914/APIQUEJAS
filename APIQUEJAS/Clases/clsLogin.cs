using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using APIQUEJAS.Sql;

namespace APIQUEJAS.Clases
{
    public class clsLogin
    {
        string consulta;
        clsSqlServer _Ad = new clsSqlServer();
        DataTable dtResultado = new DataTable();
        bool respuesta; 
        public bool validarExistenciaUsuario(string usuario, string pass)
        {
            consulta = string.Format(sqlLogin.ValidaExistenciaUsuario, usuario, pass);
            dtResultado = _Ad.realizarConsulta(consulta);
            if (Convert.ToInt32(dtResultado.Rows[0]["EXISTE"]) == 1)
                respuesta = true;
            else
                respuesta = true;
            return respuesta;
        }
    }
}