using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public  class Perro:ClaseAccesoDatos
    {
        public int Id { get; set; }
        public string Nombre {  get; set; }
        public DateTime FechaNac { get; set; }
        public string Sexo { get; set; }
        public double Peso { get; set; }
        public string Raza {  get; set; }
        public string Tamano { get; set; }
        
        public DataSet InsertarPerro(string nombre,string fecha, string sexo, string peso,string raza, string tamano)
        {
            string cadenasql = " INSERT INTO perros (nombre,fechanac,sexo,peso, raza,tamano) values" +
                                               "('#Nombre#','#FechaNac#','#Sexo#','#Peso#','#Raza#','#Tamano#')";
            cadenasql=cadenasql.Replace("#Nombre#",nombre);
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
