using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaAccesoDatos;
namespace CapaLogicaNegocio
{
    public  class Registro:ClaseAccesoDatos
    {
        public int Id { get; set; }
        public string Nombre {  get; set; }
        
        public Registro() { }
    }
    public class Persona: Registro
    {
        public string Apellido { get; set; }
        public int Telefono { get; set; }

        public DataSet InsertarPersona(string id,string nombre,string apellido,string telefono) //ENTRADA DE DATOS
        {
            //SCRIPT SQL
            string cadenasql = "INSERT INTO clientes (CI,nombre,apellido,telefono) values (#Id#,#Nombre#,#Apellido#,#Telefono#)";
            //ASIGNAR DATOS AL OBJETO
            this.Id = Convert.ToInt32(id);
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = Convert.ToInt32(telefono);
            //CAMBIAR DATOS AL SCRIPT
            cadenasql = cadenasql.Replace("#Id#", id);
            cadenasql = cadenasql.Replace("#Nombre#",nombre);
            cadenasql= cadenasql.Replace("#Apellido#",apellido);
            cadenasql = cadenasql.Replace("#Telefono#", telefono);
            //SALIDA DE DATOS          
            return Consultar(cadenasql);
        }
    }
    public class Mascota : Registro 
    { 
        public DateTime Fechanac{ get; set; }
        public string Sexo { get; set; }
        public float Peso { get; set; }
        public string Raza { get; set; }
        public string Tamano { get; set; }


        public DataSet InsertarPerro(string nombre, string fecha, string sexo, string peso, string raza, string tamano)
        {
            string cadenasql = " INSERT INTO perros (nombre,fechanac,sexo,peso, raza,tamano) values" +
                                              "('#Nombre#','#FechaNac#','#Sexo#','#Peso#','#Raza#','#Tamano#')";
            cadenasql = cadenasql.Replace("#Nombre#", nombre);
            cadenasql = cadenasql.Replace("#Fechanac#", fecha);
            cadenasql = cadenasql.Replace("#Sexo#", sexo);
            cadenasql = cadenasql.Replace("#Peso#", peso);
            cadenasql = cadenasql.Replace("#Raza#", raza);
            cadenasql = cadenasql.Replace("#Tamano#", nombre);
            return Consultar(cadenasql);
        }
        public DataSet BorrarPerro()
        {
            string cadenasql = "";
            return Consultar(cadenasql);
        }

        public DataSet ConsultarUsuario(string usuario, string contrasena)
        {
            string cadenasql = "select usuario,contrasena,tipousuario,estado from table usuario WHERE usuario='#usuario#' and contrasena='#contrasena#'";
            cadenasql = cadenasql.Replace("#ususario#", usuario);
            cadenasql = cadenasql.Replace("#contrasena#", contrasena);
            return Consultar(cadenasql);
        }



    }
    
}
