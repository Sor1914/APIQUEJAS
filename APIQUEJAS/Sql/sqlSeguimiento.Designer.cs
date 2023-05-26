﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIQUEJAS.Sql {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class sqlSeguimiento {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal sqlSeguimiento() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("APIQUEJAS.Sql.sqlSeguimiento", typeof(sqlSeguimiento).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a UPDATE Encabezado_Queja SET Id_Estado_Externo = {0}, Id_Estado_Interno = {1}, JUSTIFICACION = &apos;{3}&apos;, Respuesta = &apos;{4}&apos;, Id_Punto_Atencion = {5}
        ///WHERE Id_Encabezado = {6}.
        /// </summary>
        internal static string ActualizaQueja {
            get {
                return ResourceManager.GetString("ActualizaQueja", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a UPDATE Encabezado_Queja SET Id_Estado_Externo = {0}, Id_Estado_Interno = {1}, JUSTIFICACION = &apos;{2}&apos; WHERE Id_Encabezado = {3}.
        /// </summary>
        internal static string ActualizarEstadoQueja {
            get {
                return ResourceManager.GetString("ActualizarEstadoQueja", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a UPDATE Encabezado_Queja SET Id_Punto_Atencion = {0}, Id_Estado_Externo = {1}, Id_Estado_Interno = {2}
        ///WHERE Id_Encabezado = {3}.
        /// </summary>
        internal static string ActualizarPuntoEstadoQueja {
            get {
                return ResourceManager.GetString("ActualizarPuntoEstadoQueja", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a INSERT INTO Detalle_Queja(Id_Encabezado, Comentario, Direccion_Archivo, Fecha_Detalle, Id_Usuario)
        ///VALUES ({0}, &apos;{1}&apos;, &apos;{2}&apos;, CURRENT_TIMESTAMP, &apos;{3}&apos;).
        /// </summary>
        internal static string InsertaDetalleQueja {
            get {
                return ResourceManager.GetString("InsertaDetalleQueja", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Encabezado_Queja.CORRELATIVO, Tipo_Queja.Siglas_Tipo FROM Encabezado_Queja 
        ///INNER JOIN Tipo_Queja
        ///	ON Encabezado_Queja.Id_Tipo = Tipo_Queja.Id_Tipo
        ///WHERE Id_Encabezado = {0}.
        /// </summary>
        internal static string ObtieneCorrelativoPorId {
            get {
                return ResourceManager.GetString("ObtieneCorrelativoPorId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT * FROM Detalle_Queja
        ///where Detalle_Queja.Id_Encabezado = {0} ORDER BY Fecha_Detalle DESC.
        /// </summary>
        internal static string ObtieneDetalleQueja {
            get {
                return ResourceManager.GetString("ObtieneDetalleQueja", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Email FROM USUARIO WHERE Id_Punto_Atencion = {0} AND Id_Cargo IN (2,3,4,5,7) AND ESTADO = &apos;A&apos;.
        /// </summary>
        internal static string ObtieneEmailPuntoAtención {
            get {
                return ResourceManager.GetString("ObtieneEmailPuntoAtención", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Encabezado_Queja.*, EstadoExterno.Nombre AS Estado_Externo,
        ///EstadoInterno.Nombre AS Estado_Interno, Region.Nombre_Region, Punto_Atencion.Nombre_Punto_Atencion,  Direccion_Archivo FROM Encabezado_Queja
        ///INNER JOIN Estado EstadoExterno
        ///	ON Id_Estado_Externo = EstadoExterno.Id_Estado
        ///INNER JOIN Estado EstadoInterno
        ///	ON Id_Estado_Externo = EstadoInterno.Id_Estado
        ///INNER JOIN Punto_Atencion
        ///	ON Encabezado_Queja.Id_Punto_Atencion = Punto_Atencion.Id_Punto_Atencion
        ///INNER JOIN Region
        ///	ON Punto_Atencio [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string ObtieneEncabezadoQueja {
            get {
                return ResourceManager.GetString("ObtieneEncabezadoQueja", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Encabezado_Queja.*, EstadoExterno.Nombre AS Estado_Externo,
        ///EstadoInterno.Nombre AS Estado_Interno, Region.Nombre_Region, Punto_Atencion.Nombre_Punto_Atencion,  Direccion_Archivo FROM Encabezado_Queja
        ///INNER JOIN Estado EstadoExterno
        ///	ON Id_Estado_Externo = EstadoExterno.Id_Estado
        ///INNER JOIN Estado EstadoInterno
        ///	ON Id_Estado_Externo = EstadoInterno.Id_Estado
        ///INNER JOIN Punto_Atencion
        ///	ON Encabezado_Queja.Id_Punto_Atencion = Punto_Atencion.Id_Punto_Atencion
        ///INNER JOIN Region
        ///	ON Punto_Atencio [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string ObtieneEncabezadoQuejaPorCorrelativo {
            get {
                return ResourceManager.GetString("ObtieneEncabezadoQuejaPorCorrelativo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Id_Encabezado, Correlativo, 
        ///Fecha_Ingreso AS Fecha,
        ///Correlativo
        ///FROM Encabezado_Queja WHERE Id_Estado_Externo = 1 AND Id_Estado_Interno = 1.
        /// </summary>
        internal static string ObtieneQuejasAsignacion {
            get {
                return ResourceManager.GetString("ObtieneQuejasAsignacion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Id_Encabezado, Correlativo, 
        ///Fecha_Ingreso AS Fecha, Id_Estado_Interno, Estado.Nombre AS Estado_Interno, Encabezado_Queja.Detalle
        ///FROM Encabezado_Queja 
        ///INNER JOIN USUARIO
        ///	ON Encabezado_Queja.Id_Punto_Atencion = USUARIO.Id_Punto_Atencion
        ///INNER JOIN Estado
        ///	ON Encabezado_Queja.Id_Estado_Interno = ESTADO.Id_Estado
        ///WHERE Id_Estado_Externo = 4 AND Id_Estado_Interno IN (7) 
        ///AND USUARIO.Usuario = &apos;{0}&apos;.
        /// </summary>
        internal static string ObtieneQuejasCent {
            get {
                return ResourceManager.GetString("ObtieneQuejasCent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Id_Encabezado, Correlativo, 
        ///Fecha_Ingreso AS Fecha, Id_Estado_Interno, Estado.Nombre  AS Estado_Interno, Encabezado_Queja.Detalle
        ///FROM Encabezado_Queja 
        ///INNER JOIN USUARIO
        ///	ON Encabezado_Queja.Id_Punto_Atencion = USUARIO.Id_Punto_Atencion
        ///INNER JOIN Estado
        ///	ON Encabezado_Queja.Id_Estado_Interno = ESTADO.Id_Estado
        ///WHERE Id_Estado_Externo = 4 AND Id_Estado_Interno IN (2,5,8)  AND USUARIO.Usuario = &apos;{0}&apos;.
        /// </summary>
        internal static string ObtieneQuejasPuntoAtencion {
            get {
                return ResourceManager.GetString("ObtieneQuejasPuntoAtencion", resourceCulture);
            }
        }
    }
}
