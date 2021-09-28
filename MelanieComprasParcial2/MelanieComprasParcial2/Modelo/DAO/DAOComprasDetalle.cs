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
    public class DAOComprasDetalle
    {
        private ConexionODBC ConexionODBC = new ConexionODBC();

        public DTOComprasDetalle AgregarDetalle(DTOComprasDetalle modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
               "INSERT INTO compras_detalle (documento_compraenca, codigo_producto, cantidad_compradet, costo_compradet, codigo_bodega) " +
               "VALUES (?documento_compraenca?, ?codigo_producto?, ?cantidad_compradet?, ?costo_compradet?, ?codigo_bodega?);";
                var ValorDeVariables = new
                {
                    documento_compraenca = modelo.documento_compraenca,
                    codigo_producto = modelo.codigo_producto,
                    cantidad_compradet = modelo.cantidad_compradet,
                    costo_compradet = modelo.costo_compradet,
                    codigo_bodega = modelo.codigo_bodega,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<DTOComprasDetalle> MostrarDetalles()
        {
            List<DTOComprasDetalle> sqlresultado = new List<DTOComprasDetalle>();
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM compras_detalle;";
                sqlresultado = conexionODBC.Query<DTOComprasDetalle>(sqlconsulta).ToList();
                ConexionODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }

        public DTOComprasDetalle ModificarDetalle(DTOComprasDetalle modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE compras_detalle SET cantidad_compradet = ?cantidad_compradet?" +
                ", cantidad_compradet = ?cantidad_compradet?, costo_compradet = ?costo_compradet?" +
                " WHERE documento_compraenca = ?documento_compraenca? AND codigo_producto = ?codigo_producto?;";
                var ValorDeVariables = new
                {
                    documento_compraenca = modelo.documento_compraenca,
                    codigo_producto = modelo.codigo_producto,
                    cantidad_compradet = modelo.cantidad_compradet,
                    costo_compradet = modelo.costo_compradet,
                    codigo_bodega = modelo.codigo_bodega,
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public DTOComprasDetalle EliminarDetalle(DTOComprasDetalle modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM compras_detalle WHERE documento_compraenca = ?documento_compraenca? AND codigo_producto = ?codigo_producto?;";
                var ValorDeVariables = new
                {
                    documento_compraenca = modelo.documento_compraenca,
                    codigo_producto = modelo.codigo_producto
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
    }
}