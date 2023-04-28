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
    internal class sqlPuntosAtencion {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal sqlPuntosAtencion() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("APIQUEJAS.Sql.sqlPuntosAtencion", typeof(sqlPuntosAtencion).Assembly);
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
        ///   Busca una cadena traducida similar a UPDATE Punto_Atencion SET Nombre_Punto_Atencion = &apos;{0}&apos;, Id_Region = {1} WHERE Id_Punto_Atencion = {2}.
        /// </summary>
        internal static string ActualizaPunto {
            get {
                return ResourceManager.GetString("ActualizaPunto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT COUNT(ID_PUNTO_ATENCION) FROM USUARIO WHERE Id_Punto_Atencion = {0}.
        /// </summary>
        internal static string CuentaUsuariosPuntoAtencion {
            get {
                return ResourceManager.GetString("CuentaUsuariosPuntoAtencion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a UPDATE Punto_Atencion SET Estado = &apos;{0}&apos; WHERE Id_Punto_Atencion = {1}.
        /// </summary>
        internal static string EliminaPunto {
            get {
                return ResourceManager.GetString("EliminaPunto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a UPDATE Usuario SET Estado = &apos;I&apos; WHERE Id_Punto_Atencion = {0}.
        /// </summary>
        internal static string InactivaUsuariosPuntoAtencion {
            get {
                return ResourceManager.GetString("InactivaUsuariosPuntoAtencion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a INSERT INTO Punto_Atencion(Nombre_Punto_Atencion, Id_Region, Estado) values (&apos;{0}&apos;, {1}, &apos;A&apos;);.
        /// </summary>
        internal static string InsertaPunto {
            get {
                return ResourceManager.GetString("InsertaPunto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT ROW_NUMBER() OVER(ORDER BY Id_Punto_Atencion) AS FILA, 
        ///Punto.Id_Punto_Atencion AS Id, Punto.Nombre_Punto_Atencion AS NombrePuntoAtencion, Region.Id_Region AS IdRegion,
        ///Region.Nombre_Region AS NombreRegion, Punto.Estado AS Estado
        ///FROM Punto_Atencion Punto
        ///	INNER JOIN Region Region
        ///		ON Punto.Id_Region = Region.Id_Region
        ///	WHERE Punto.Estado = &apos;A&apos; .
        /// </summary>
        internal static string ObtienePuntos {
            get {
                return ResourceManager.GetString("ObtienePuntos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Id_Region, Nombre_Region FROM Region WHERE Estado = &apos;A&apos;;.
        /// </summary>
        internal static string ObtieneRegiones {
            get {
                return ResourceManager.GetString("ObtieneRegiones", resourceCulture);
            }
        }
    }
}
