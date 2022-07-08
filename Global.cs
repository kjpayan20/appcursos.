using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace regiones
{
    class Global
    {
        public static List<Modulo> Modulos = new List<Modulo>()
        {
            new Modulo(1,"Conceptos Básicos de las Bases de Datos"),
            new Modulo(2,"Acciones sobre una Base de Datos"),
            new Modulo(3,"Manejo de Tablas Dinámicas"),
            new Modulo(4,"Acciones sobre una Base de Datos"),

        };
        public static List<DetalleModulo> DModulos = new List<DetalleModulo>()
        {
            new DetalleModulo(1,"Conceptos básicos de Bases de Datos en Excel | Gestión de la Información #1","https://goo.gl/Rof9Yf","No usa una base de datos como ejemplo","N/A",1),
            new DetalleModulo(1,"Ejemplos de Bases de Datos en Excel | Gestión de la Información #2","https://goo.gl/iUF2rL","No 1 EJEMPLO BD","https://www.poli.edu.co/sites/default/files/basesdatos/No-1-EJEMPLO-BD.XLS",1),
            new DetalleModulo(1,"Diversos ejemplos de Bases de Datos en Excel | Gestión de la Información #3","https://goo.gl/baXcJW","EJEMPLO_BANCOS","https://www.poli.edu.co/sites/default/files/basesdatos/EJEMPLO_BANCOS.XLSX",1),
            new DetalleModulo(1,"¿Que es una Tabla Resumen en Excel y que es una Base de Datos? | Gestión de la Información #4","https://goo.gl/hj8vYo","No 3 NO BD","https://www.poli.edu.co/sites/default/files/basesdatos/No-3-NO-BD.XLS",1),
            new DetalleModulo(2,"¿Cómo ingresar datos en una Base de Datos de Excel? | Gestión de la Información #5","https://goo.gl/5kEcGd","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",2),
            new DetalleModulo(2,"Aprende a ordenar Bases de Datos en Excel | Gestión de la Información #6","https://goo.gl/eGZ5j9","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",2),
            new DetalleModulo(2,"¿Cómo generar subtotales en una Base de Datos en Excel? | Gestión de la Información #7	","https://goo.gl/cq9NGR","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",2),
            new DetalleModulo(2,"¿Cómo se generan autofiltros en una Base de Datos en Excel? | Gestión de la Información #8","https://goo.gl/Zcm4r6","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",2),
            new DetalleModulo(2,"¿Cómo crear un filtro avanzado en una Base de Datos en Excel? | Gestión de la Información #9","https://goo.gl/z6Nzwu","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",2),
            new DetalleModulo(2,"Aprende a validar datos en Excel | Gestión de la Información #10","https://goo.gl/JyMCeE","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLS",2),
            new DetalleModulo(3,"¿Cómo crear Tablas Dinámicas en Excel? | Gestión de la Información #11","https://goo.gl/2npG6Y","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",3),
            new DetalleModulo(3,"Agrupar campos en Tablas Dinámicas en Excel | Gestión de la Información #12","https://goo.gl/SKGwGt","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",3),
            new DetalleModulo(3,"Mostrar datos como porcentaje de fila o columna | Gestión de la Información #13","https://goo.gl/urrrP5","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",3),
            new DetalleModulo(3,"Segmentación de Datos en Tablas Dinámicas en Excel | Gestión de la Información #14","https://goo.gl/e5NfSt","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",3),
            new DetalleModulo(4,"Combinando correspondencia con Word y una base de datos en Excel | Gestión de la Información #15","https://goo.gl/LPM51S","No 4.5 TABLA DINAMICA BD PERSONAL","http://comunicaciones.poligran.edu.co/documentacion/No4-5-TABLA-DINAMICA-BD-PERSONAL.xlsm",4),
            new DetalleModulo(4,"Formato condicional en Excel Parte 1 | Gestión de la Información #16","https://goo.gl/fxXnqo","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",4),
            new DetalleModulo(4,"Formato condicional en Excel Parte 2 | Gestión de la Información #17","https://goo.gl/1ybnkZ","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",4),
            new DetalleModulo(4,"Formato condicional en Excel Parte 3 | Gestión de la Información #18","https://goo.gl/HVRNvA","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",4),
            new DetalleModulo(4,"¿Cómo generar minigráficos en Excel? | Gestión de la Información #19","https://goo.gl/wZB4VD","BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",4),
            new DetalleModulo(4,"Cinta y barra de menú rápida en Excel | Gestión de la Información #20","https://goo.gl/pj8wua","Libro limpio Excel","N/A",2),
            new DetalleModulo(4,"Conoce todos los menús en la presentación de excel | Gestión de la Información #21","https://goo.gl/FtMcTZ","Libro limpio Excel & BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",4),
            new DetalleModulo(4,"Conoce todas las opciones de menú en Excel | Gestión de la Información #22","https://goo.gl/XxTo2b","Libro limpio Excel","N/A",2),
            new DetalleModulo(4,"¿Cómo hacer consultas web desde Excel y generar Bases de Datos? | Gestión de la Información #23","https://goo.gl/XnXS9W","CONSULTA_WEB","https://www.poli.edu.co/sites/default/files/basesdatos/CONSULTA_WEB.XLSX",4),
            new DetalleModulo(4,"Creación de Macros en Excel | Gestión de la Información #24","https://goo.gl/NhNsT3","No 4.5 TABLA DINAMICA BD PERSONAL","http://comunicaciones.poligran.edu.co/documentacion/No4-5-TABLA-DINAMICA-BD-PERSONAL.xlsm",4),



        };
    }
    public class Modulo
    {
        //campos
        int id;
        string nombre;

        public Modulo(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
    public class DetalleModulo
    {
        //campos 
        int id;

        string NombreVideo;
        string URLYoutube;
        string NombreBD;
        string URLBD;
        int IdModulo;

        public DetalleModulo(int id, string nombreVideo, string uRLYoutube, string nombreBD, string uRLBD, int idModulo)
        {
            this.Id = id;

            NombreVideo1 = nombreVideo;
            URLYoutube1 = uRLYoutube;
            NombreBD1 = nombreBD;
            URLBD1 = uRLBD;
            IdModulo1 = idModulo;
        }

        public int Id { get => id; set => id = value; }

        public string NombreVideo1 { get => NombreVideo; set => NombreVideo = value; }
        public string URLYoutube1 { get => URLYoutube; set => URLYoutube = value; }
        public string NombreBD1 { get => NombreBD; set => NombreBD = value; }
        public string URLBD1 { get => URLBD; set => URLBD = value; }
        public int IdModulo1 { get => IdModulo; set => IdModulo = value; }
    }
}