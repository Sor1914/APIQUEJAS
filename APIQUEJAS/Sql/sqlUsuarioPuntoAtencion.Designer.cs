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
    internal class sqlUsuarioPuntoAtencion {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal sqlUsuarioPuntoAtencion() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("APIQUEJAS.Sql.sqlUsuarioPuntoAtencion", typeof(sqlUsuarioPuntoAtencion).Assembly);
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
        ///   Busca una cadena traducida similar a UPDATE USUARIO SET Id_Punto_Atencion = {0}, Id_Cargo = {1} WHERE Cui = {2}.
        /// </summary>
        internal static string ActualizaDatosUsuario {
            get {
                return ResourceManager.GetString("ActualizaDatosUsuario", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Id_Area, Nombre_Cargo FROM Cargo WHERE Estado = &apos;A&apos; AND Id_Area &lt;&gt; 1.
        /// </summary>
        internal static string ObtieneCargos {
            get {
                return ResourceManager.GetString("ObtieneCargos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Id_Punto_Atencion Id, Nombre_Punto_Atencion NombrePuntoAtencion, Id_Region IdRegion
        ///FROM Punto_Atencion WHERE ESTADO = &apos;A&apos; AND Id_Punto_Atencion &lt;&gt; 1.
        /// </summary>
        internal static string ObtienePuntosAtencion {
            get {
                return ResourceManager.GetString("ObtienePuntosAtencion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Nombres, Apellidos, Email, Id_Cargo, Punto_Atencion.Nombre_Punto_Atencion, USUARIO.Id_Punto_Atencion FROM USUARIO 
        ///INNER JOIN Punto_Atencion 
        ///	ON Punto_Atencion.Id_Punto_Atencion = Usuario.Id_Punto_Atencion
        ///WHERE Usuario.Estado = &apos;A&apos; AND Cui = &apos;{0}&apos;.
        /// </summary>
        internal static string ObtieneUsuarioPorCui {
            get {
                return ResourceManager.GetString("ObtieneUsuarioPorCui", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT Usuario.Usuario, Usuario.Id_Usuario, Cui, Nombres, Apellidos, CARGO.Nombre_Cargo, Punto_Atencion.Nombre_Punto_Atencion,
        ///REGION.Nombre_Region, USUARIO.Id_Punto_Atencion, Punto_Atencion.Id_Region, usuario.Id_Cargo, Email FROM USUARIO
        ///INNER JOIN CARGO
        ///	ON CARGO.Id_Area = Id_Cargo 
        ///INNER JOIN Punto_Atencion
        ///	ON USUARIO.Id_Punto_Atencion = Punto_Atencion.Id_Punto_Atencion
        ///INNER JOIN Region
        ///	ON Punto_Atencion.Id_Region = REGION.Id_Region AND Punto_Atencion.Id_Punto_Atencion &lt;&gt; 1
        ///WHERE USUARIO.Estad [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string ObtieneUsuarios {
            get {
                return ResourceManager.GetString("ObtieneUsuarios", resourceCulture);
            }
        }
    }
}
