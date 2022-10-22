using System.Data.SqlClient;
using System.Data;
using WebApplication1.Modelos;

namespace WebApplication1.Repository
{
    public class ADO_Venta
    {
        public static void CargarVenta(List<ProductoVendido> productos, string comentarios, int idUsuario)
        {
            long idVenta;
            string connectionString = Connection.traerConnection();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //INSERT en tabla venta y obtener el id de la venta
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Venta] (Comentarios, IdUsuario) VALUES (@Comentarios, @IdUsuario); Select scope_identity();", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.NVarChar)).Value = comentarios;
                cmd.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt)).Value = idUsuario;
                idVenta = Convert.ToInt64(cmd.ExecuteScalar());

                ////INSERT en tabla producto vendido con lista de productos enviados
                foreach (ProductoVendido producto in productos)
                {
                    cmd = new SqlCommand("INSERT INTO ProductoVendido (Stock,IdProducto,IdVenta)  VALUES   (@Stock,@IdProducto,@IdVenta) ", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int)).Value = producto.Stock;
                    cmd.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt)).Value = producto.IdProducto;
                    cmd.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt)).Value = idVenta;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

        }
    }
}
