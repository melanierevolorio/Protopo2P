using System.Data.Odbc;

namespace AS2Parcial2
{
    public class ConexionODBC
    {
        private string dsn = "Dsn=parcial2mel";

        public OdbcConnection abrirConexion()
        {
            OdbcConnection conexion = new OdbcConnection(dsn);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (OdbcException e)
            {
                return null;
            }
        }

        public void cerrarConexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (OdbcException e)
            {
            }
        }
    }
}