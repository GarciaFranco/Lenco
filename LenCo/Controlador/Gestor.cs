using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using LenCo.Modelo;

namespace LenCo
{
    class Gestor
    {
        private SqlConnection cn;
        private void abrirConexion()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString.ToString();
            cn = new SqlConnection(cadenaConexion);
            if (cn != null)
            {
                cn.Open();
            }
        }
        private void cerrarConexion()
        {

            try
            {
                if (cn != null)
                {
                    cn.Close();
                }
            }
            catch (Exception)
            { 
                throw;
            }
        }
        // ------------------- USUARIOS -------------------
        public bool existeUsuario(string user, string pass)
        {
            bool existe = false;
            
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Usuarios WHERE usuario = @usuario and password = @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usuario", user);
                cmd.Parameters.AddWithValue("@password", pass);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                abrirConexion();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    if (dr.Read())
                    {
                        Usuario.pIdUsuario = dr.GetInt32(0);
                        Usuario.pUsuario = dr.GetString(1);
                        Usuario.pPassword = dr.GetString(2);
                        Usuario.pIdRol = dr.GetInt32(3);
                        existe = true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cerrarConexion();
            }
            return existe;
        }
        // ------------------- PRODUCTOS -------------------
        public void cargarProducto(Producto nuevo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Productos VALUES (@codigoProv,@idMarca,@idRubro,@articulo,@idTalle,@idColor," +
                                  "                              @idPresentacion,@descripcion,@precioVenta,@activo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoProv", nuevo.pCodigoProv);
                cmd.Parameters.AddWithValue("@idMarca", nuevo.pMarca.pIdMarca);
                cmd.Parameters.AddWithValue("@idRubro", nuevo.pRubro.pIdRubro);
                cmd.Parameters.AddWithValue("@articulo", nuevo.pArticulo);
                cmd.Parameters.AddWithValue("@idTalle", nuevo.pTalle.pIdTalle);
                cmd.Parameters.AddWithValue("@idColor", nuevo.pColor.pIdColor);
                cmd.Parameters.AddWithValue("@idPresentacion", nuevo.pPresent.pIdPresentacion);
                cmd.Parameters.AddWithValue("@descripcion", nuevo.pDescripcion);
                cmd.Parameters.AddWithValue("@precioVenta", nuevo.pPrecioVenta);
                cmd.Parameters.AddWithValue("@activo", nuevo.pActivo);

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cerrarConexion();
            }
        }
        public void modificarProducto(Producto prod)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = @"UPDATE Productos
                                    SET codigoProv = @codigoProv, idMarca = @idMarca, idRubro = @idRubro, articulo = @articulo, idTalle = @idTalle, idColor = @idColor, idPresentacion = @idPresentacion, descripcion = @descripcion, precioVenta = @precioVenta
                                    WHERE idProducto = @idProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoProv", prod.pCodigoProv);
                cmd.Parameters.AddWithValue("@idMarca", prod.pMarca.pIdMarca);
                cmd.Parameters.AddWithValue("@idRubro", prod.pRubro.pIdRubro);
                cmd.Parameters.AddWithValue("@articulo", prod.pArticulo);
                cmd.Parameters.AddWithValue("@idTalle", prod.pTalle.pIdTalle);
                cmd.Parameters.AddWithValue("@idColor", prod.pColor.pIdColor);
                cmd.Parameters.AddWithValue("@idPresentacion", prod.pPresent.pIdPresentacion);
                cmd.Parameters.AddWithValue("@descripcion", prod.pDescripcion);
                cmd.Parameters.AddWithValue("@precioVenta", prod.pPrecioVenta);
                cmd.Parameters.AddWithValue("@idProducto", prod.pIdProducto);

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cerrarConexion();
            }
        }
        public void eliminarProducto(int productoID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = @"UPDATE Productos
                                    SET activo = 0
                                    WHERE idProducto = @idProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", productoID);

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cerrarConexion();
            }
        }
        public void cargarStocks(Stock stock)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Inventarios VALUES (@idSucursal,@idProducto,@cantidad)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idSucursal", stock.pIdSucursal);
                cmd.Parameters.AddWithValue("@idProducto", stock.pIdProducto);
                cmd.Parameters.AddWithValue("@cantidad", stock.pCantidad);
            
                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cerrarConexion();
            }
        }
        public void modificarStock(Stock stock)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = @"UPDATE Inventarios
                                    SET cantidad = @cantidad
                                    WHERE idProducto = @idProducto and idSucursal = @idSucursal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cantidad", stock.pCantidad);
                cmd.Parameters.AddWithValue("@idProducto", stock.pIdProducto);
                cmd.Parameters.AddWithValue("@idSucursal", stock.pIdSucursal);

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cerrarConexion();
            }
        }
        public int verStock(int idProducto, int idSucursal)
        {
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "exec stockPorSucursal @idProducto, @idSucursal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.Parameters.AddWithValue("@idSucursal", idSucursal);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                abrirConexion();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    if (dr.Read())
                    {
                        resultado = dr.GetInt32(0);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }
        public DataTable mostrarConsulta(string consulta)
        {
            DataTable resultado = new DataTable();
            try
            {
                abrirConexion();

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = consulta;
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }
        public void cargarCombo(ComboBox combo,string nombreTabla)
        {
            string consulta = "SELECT * FROM " + nombreTabla;
            DataTable tabla = mostrarConsulta(consulta);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName; // lo que se visualiza
            combo.ValueMember = tabla.Columns[0].ColumnName; // lo que se captura
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }
        public void cargarComboModificar(ComboBox combo, string nombreTabla, int id)
        {
            string consulta = "SELECT * FROM " + nombreTabla + " WHERE 1 = " + id;
            DataTable tabla = mostrarConsulta(consulta);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName; // lo que se visualiza
            combo.ValueMember = tabla.Columns[0].ColumnName; // lo que se captura
        }
        //private Marca buscarMarcaPorID(int marcaID)
        //{
        //    Marca marca = null;
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        string consulta = "SELECT * FROM Marcas WHERE idMarca = @idMarca";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@idMarca", marcaID);

        //        cmd.CommandText = consulta;

        //        abrirConexion();
        //        cmd.Connection = cn;

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr != null)
        //        {
        //            if (dr.Read())
        //            {
        //                int idMarca = Convert.ToInt32(dr["idMarca"].ToString());
        //                string nombre = dr["nombre"].ToString();
        //                marca = new Marca(idMarca, nombre);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        cerrarConexion();
        //    }
        //    return marca;
        //}
        //private Rubro buscarRubroPorID(int rubroID)
        //{
        //    Rubro rubro = null;
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        string consulta = "SELECT * FROM Rubros WHERE idRubro = @idRubro";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@idRubro", rubroID);

        //        cmd.CommandText = consulta;

        //        abrirConexion();
        //        cmd.Connection = cn;

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr != null)
        //        {
        //            if (dr.Read())
        //            {
        //                int idRubro = Convert.ToInt32(dr["idRubro"].ToString());
        //                string nombre = dr["nombre"].ToString();
        //                rubro = new Rubro(idRubro, nombre);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        cerrarConexion();
        //    }
        //    return rubro;
        //}
        //private Talle buscarTallePorID(int talleID)
        //{
        //    Talle talle = null;
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        string consulta = "SELECT * FROM Talles WHERE idTalle = @idTalle";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@idTalle", talleID);

        //        cmd.CommandText = consulta;

        //        abrirConexion();
        //        cmd.Connection = cn;

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr != null)
        //        {
        //            if (dr.Read())
        //            {
        //                int idTalle = Convert.ToInt32(dr["idTalle"].ToString());
        //                string nombre = dr["nombre"].ToString();
        //                talle = new Talle(idTalle, nombre);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        cerrarConexion();
        //    }
        //    return talle;
        //}
        //private Presentacion buscarPresentacionPorID(int presentID)
        //{
        //    Presentacion present = null;
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        string consulta = "SELECT * FROM Presentaciones WHERE idPresentacion = @idPresentacion";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@idPresentacion", presentID);

        //        cmd.CommandText = consulta;

        //        abrirConexion();
        //        cmd.Connection = cn;

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr != null)
        //        {
        //            if (dr.Read())
        //            {
        //                int idPresentacion = Convert.ToInt32(dr["idPresentacion"].ToString());
        //                string nombre = dr["nombre"].ToString();
        //                present = new Presentacion(idPresentacion, nombre);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        cerrarConexion();
        //    }
        //    return present;
        //}
        //private Color buscarColorPorID(int colorID)
        //{
        //    Color color = null;
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();

        //        string consulta = "SELECT * FROM Colores WHERE idColor = @idColor";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@idColor", colorID);

        //        cmd.CommandText = consulta;

        //        abrirConexion();
        //        cmd.Connection = cn;

        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr != null)
        //        {
        //            if (dr.Read())
        //            {
        //                int idColor = Convert.ToInt32(dr["idColor"].ToString());
        //                string nombre = dr["nombre"].ToString();
        //                color = new Color(idColor,nombre);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        cerrarConexion();
        //    }
        //    return color;
        //}
    }
}
