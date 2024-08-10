using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//USAR LAS LIBRERIAS CORRECTAS
using System.Data;
using System.Data.SqlClient;
namespace CapaAccesoDatos
{
    public class ClaseAccesoDatos
    {      
        string servidor = "D2-02\\SQLEXPRESS";//PONER EL SERVIDOR
        string BaseDeDatos = "hotelperros"; //PONER LA BASE DE DATOS
        private SqlConnection IniciarConexion()
        {
            string CadenaConexion = "server=#Servidor#;database=#BaseDeDatos#; integrated security=true";
            CadenaConexion = CadenaConexion.Replace("#Servidor#", servidor);
            CadenaConexion = CadenaConexion.Replace("#BaseDeDatos#", BaseDeDatos);

            SqlConnection myconnection = new SqlConnection(CadenaConexion);
            myconnection.Open();
            return myconnection;
        }
        protected DataSet Consultar(string CadenaSql)
        {
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter(CadenaSql, IniciarConexion());
            DataSet MyDataSet = new DataSet();
            MyDataAdapter.Fill(MyDataSet);
            return MyDataSet;
        }
        protected int Modidificar(string CadenaSql)
        {
            SqlCommand myCommand = new SqlCommand(CadenaSql, IniciarConexion());
            return myCommand.ExecuteNonQuery();
        }
    }
}
