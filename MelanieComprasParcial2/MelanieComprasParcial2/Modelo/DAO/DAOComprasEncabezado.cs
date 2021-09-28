using AS2Parcial2;
using Dapper;
using MelanieComprasParcial2.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelanieComprasParcial2.Modelo.DAO
{
    public class DAOComprasEncabezado
    {
        private ConexionODBC ConexionODBC = new ConexionODBC();

        public DTOComprasEncabezado AgregarDetalle(DTOComprasEncabezado modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
               "INSERT INTO compras_encabezado (documento_compraenca, codigo_proveedor, fecha_compraenca, total_compraenca, estatus_compraenca) " +
               "VALUES (?documento_compraenca?, ?codigo_proveedor?, ?fecha_compraenca?, ?total_compraenca?, ?estatus_compraenca?);";
                var ValorDeVariables = new
                {
                    documento_compraenca = modelo.documento_compraenca,
                    codigo_proveedor = modelo.codigo_proveedor,
                    fecha_compraenca = modelo.fecha_compraenca,
                    total_compraenca = modelo.total_compraenca,
                    estatus_compraenca = modelo.estatus_compraenca,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<DTOComprasEncabezado> MostrarDetalles()
        {
            List<DTOComprasEncabezado> sqlresultado = new List<DTOComprasEncabezado>();
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM compras_encabezado;";
                sqlresultado = conexionODBC.Query<DTOComprasEncabezado>(sqlconsulta).ToList();
                ConexionODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }

        public DTOComprasEncabezado ModificarDetalle(DTOComprasEncabezado modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE compras_encabezado SET codigo_proveedor = ?codigo_proveedor?" +
                ", total_compraenca = ?total_compraenca?, estatus_compraenca = ?estatus_compraenca?" +
                " WHERE documento_compraenca = ?documento_compraenca?;";
                var ValorDeVariables = new
                {
                    documento_compraenca = modelo.documento_compraenca,
                    codigo_proveedor = modelo.codigo_proveedor,
                    total_compraenca = modelo.total_compraenca,
                    estatus_compraenca = modelo.estatus_compraenca,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public DTOComprasEncabezado EliminarDetalle(DTOComprasEncabezado modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM compras_encabezado WHERE documento_compraenca = ?documento_compraenca?;";
                var ValorDeVariables = new
                {
                    documento_compraenca = modelo.documento_compraenca,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
    }
}