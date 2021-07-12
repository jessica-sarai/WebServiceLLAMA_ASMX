using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

namespace SW_ASMX_ALUMNOS
{
    /// <summary>
    /// Descripción breve de WSAlumno
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WSAlumno : System.Web.Services.WebService
    {

        [WebMethod] //exponer el metodo hacia afuera
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        /// <summary>
        /// Recibe un objeto JSON por medio de AJAX, envia respuesta de recibido con exito
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        [WebMethod]
        public string ParserString(string alumno)
        {
            //instancia ese objeto string
            Alumno alum = JsonConvert.DeserializeObject<Alumno>(alumno);

            string respuesta = JsonConvert.SerializeObject(
                new
                {
                    respuesta = "EXITO"
                }
                );
            return respuesta;
        }
        /// <summary>
        /// Enviar un objeto JSON atraves de AJAX
        /// </summary>
        /// <returns></returns>

        [WebMethod]
        public string enviarJson()
        {
            Alumno alumno = new Alumno();
            Alumno alumno2 = new Alumno();
            alumno.nombre = "Jose";
            alumno.edad = 25;
            alumno.estado = "Hidalgo";
            alumno2.nombre = "Maria";
            alumno2.edad = 24;
            alumno2.estado = "Hidalgo";

            List<Alumno> listaAlumno = new List<Alumno>();
            listaAlumno.Add(alumno);
            listaAlumno.Add(alumno2);

            string respuesta = JsonConvert.SerializeObject(
                new
                {
                    respuesta = listaAlumno
                });

            return respuesta;
        }

        /// <summary>
        /// Recibe parametros de un objeto
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        [WebMethod]
        public string parseParametros(int id, string nombre, int edad, string estado)
        {
            string mensaje;
            try
            {
                mensaje = "EXITO";
            }
            catch (Exception)
            {
                mensaje = "Error..";
            }
            string respuesta = JsonConvert.SerializeObject(
                new {
                    respuesta = mensaje
                }
                );

            return respuesta;
        }

        /// <summary>
        /// Recibe un objeto por medio de AJAX
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        [WebMethod]

        public string objeto(Alumno alumno)
        {
            string mensaje;
            try
            {
                mensaje = "EXITO";
            }
            catch (Exception)
            {
                mensaje = "Erro..";
            }
            string respuesta;
            respuesta = JsonConvert.SerializeObject(
                new
                {
                    respuesta = mensaje
                }
                );
            return respuesta;
        }

        /// <summary>
        /// Retorna un objeto d ela clase Alumno
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        [WebMethod]
        public Alumno retornaObjetoAlumno(string nombre, int edad, string estado)
        {
            Alumno alumno = new Alumno();
            alumno.nombre = nombre;
            alumno.edad = edad;
            alumno.estado = estado;

            return alumno;
        }


        [WebMethod]
        public string eliminarModal(int id)
        {

            Alumno alumno = new Alumno(); 

            string mensaje;
            try
            {
                mensaje = "EXITO";
            }
            catch (Exception)
            {
                mensaje = "Error..";
            }
            string respuesta = JsonConvert.SerializeObject(
                new
                {
                    respuesta = mensaje
                }
                );

            return respuesta;
        }



    }
}


