using LenCo.Modelo;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LenCo
{
    internal class Gestor
    {
        private SqlConnection cn;

        #region Conexion

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        #endregion Conexion

        #region Usuarios

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return existe;
        }

        #endregion Usuarios

        #region Productos

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                                    SET codigoProv = @codigoProv, idMarca = @idMarca, idRubro = @idRubro, articulo = @articulo, idTalle = @idTalle,
                                    idColor = @idColor, idPresentacion = @idPresentacion, descripcion = @descripcion, precioVenta = @precioVenta
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public int ultimoIDCargado()
        {
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT MAX(idProducto) 'ID Producto'
                                    FROM Productos";

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }

        public Producto cargarDatosDelProducto(int id)
        {
            Producto prod = null;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT idProducto 'ID', codigoProv 'Cod Producto', descripcion 'Descripcion',  idMarca 'ID Marca', idRubro 'ID Rubro', articulo 'Articulo',  idTalle 'ID Talle', idColor 'ID Color',  idPresentacion 'ID Presentacion',  precioVenta 'Precio Venta'
                                    FROM Productos
                                    WHERE idProducto = @idProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                abrirConexion();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    if (dr.Read())
                    {
                        Producto p = new Producto();
                        p.pIdProducto = dr.GetInt32(0);
                        p.pCodigoProv = dr.GetString(1);
                        p.pDescripcion = dr.GetString(2);
                        p.pMarca.pIdMarca = dr.GetInt32(3);
                        p.pRubro.pIdRubro = dr.GetInt32(4);
                        p.pArticulo = dr.GetInt32(5);
                        p.pTalle.pIdTalle = dr.GetInt32(6);
                        p.pColor.pIdColor = dr.GetInt32(7);
                        p.pPresent.pIdPresentacion = dr.GetInt32(8);
                        p.pPrecioVenta = (double)dr.GetDecimal(9);
                        prod = p;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return prod;
        }

        public Producto buscarProducto(string codigo)
        {
            Producto prod = null;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT pd.idProducto 'ID', pd.articulo 'Articulo', pd.descripcion 'Descripcion', m.nombre 'Marca', r.nombre 'Rubro', t.nombre 'Talle', c.nombre 'Color',  p.nombre 'Presentacion',  precioVenta 'Precio Venta'
                                        FROM Productos pd
                                        JOIN Marcas m ON pd.idMarca = m.idMarca
                                        JOIN Rubros r ON pd.idRubro = r.idRubro
                                        JOIN Talles t ON pd.idTalle = t.idTalle
                                        JOIN Colores c ON pd.idColor = c.idColor
                                        JOIN Presentaciones p ON pd.idPresentacion = p.idPresentacion
                                        WHERE codigoProv = @codigoProv";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigoProv", codigo);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                abrirConexion();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    if (dr.Read())
                    {
                        Producto p = new Producto();
                        p.pIdProducto = dr.GetInt32(0);
                        p.pArticulo = dr.GetInt32(1);
                        p.pDescripcion = dr.GetString(2);
                        p.pMarca.pNombre = dr.GetString(3);
                        p.pRubro.pNombre = dr.GetString(4);
                        p.pTalle.pNombre = dr.GetString(5);
                        p.pColor.pNombre = dr.GetString(6);
                        p.pPresent.pNombre = dr.GetString(7);
                        p.pPrecioVenta = (double)dr.GetDecimal(8);
                        prod = p;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return prod;
        }

        public bool existeProducto(string codigo)
        {
            bool existe = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT idProducto FROM Productos WHERE codigoProv = @codigo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codigo);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                abrirConexion();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return existe;
        }

        #endregion Productos

        #region Stocks

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }

        public int verStock(string codigo, int idSucursal)
        {
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT inv.cantidad 'Stock'
                                    FROM Productos p
                                    RIGHT JOIN Inventarios inv ON p.idProducto = inv.idProducto
                                    RIGHT JOIN Sucursales s ON inv.idSucursal = s.idSucursal
                                    WHERE p.codigoProv = @codigo and s.idSucursal = @idSucursal";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codigo);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }

        public bool primeraCarga(int idProducto)
        {
            bool resultado = true;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT DISTINCT idProducto FROM Inventarios WHERE idProducto = @idProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", idProducto);

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    resultado = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }

        #endregion Stocks

        #region Compras

        public void cargarCompra(Compra nueva)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Compras VALUES (@nroComprobante, @fecha_compra, @idProveedor)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroComprobante", nueva.pNroComprobante);
                cmd.Parameters.AddWithValue("@fecha_compra", nueva.pFecha_compra);
                cmd.Parameters.AddWithValue("@idProveedor", nueva.pIdProveedor);

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public bool existeCompra(int nro, DateTime fecha, int idProv)
        {
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT * FROM Compras
                                    WHERE num_comprobante = @nro
	                                      and fecha_compra = @fecha
	                                      and idProveedor = @proveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro", nro);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@proveedor", idProv);

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }

        public double calcularMontoUltimaCompra()
        {
            double total = 0;
            try
            {
                abrirConexion();
                string consulta = @"SELECT SUM(dc.cantidadUnit* dc.precioUnit) 'Total'
                                    FROM DetallesCompra dc
                                    WHERE idCompra = (SELECT MAX(idCompra) FROM DetallesCompra)";
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = consulta;
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    if (dr.Read())
                    {
                        double aux = (double)dr.GetDecimal(0);
                        total = Math.Round(aux, 2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return total;
        }

        #endregion Compras

        #region Detalle compras

        public void cargarDetalleCompra(DetalleCompra nuevo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO DetallesCompra VALUES (@idProducto, @precio, @cantidad, @idCompra)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", nuevo.pProducto.pIdProducto);
                cmd.Parameters.AddWithValue("@precio", nuevo.pPrecioUnit);
                cmd.Parameters.AddWithValue("@cantidad", nuevo.pCantidadUnit);
                cmd.Parameters.AddWithValue("@idCompra", nuevo.pCompra.pIdCompra);

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        public bool existeDetalle()
        {
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT MAX(idDetalleCompra) FROM DetallesCompra";

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    if (dr.Read())
                    {
                        bool c = Convert.ToBoolean(dr.GetInt32(0));
                        resultado = c;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }

        #endregion Detalle compras

        #region Ventas

        public void agregarVenta(Venta venta)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "exec InsertarVenta @fechaVenta,@idSucursal,@montoDescuento,@idFormaPago";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechaVenta", venta.pFechaVenta);
                cmd.Parameters.AddWithValue("@idSucursal", venta.pIdSucursal);
                cmd.Parameters.AddWithValue("@montoDescuento", venta.pMontoDescuento);
                cmd.Parameters.AddWithValue("@idFormaPago", venta.pIdformaPago);

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        #endregion Ventas

        #region Detalle ventas

        public void agregarDetalleVenta(DetalleVenta detalle)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "exec InsertarDetalleVenta @idProducto,@cantidad,@idVenta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idProducto", detalle.pProducto.pIdProducto);
                cmd.Parameters.AddWithValue("@cantidad", detalle.pCantidad);
                cmd.Parameters.AddWithValue("@idVenta", detalle.pVenta.pIdVenta);

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
        }

        #endregion Detalle ventas

        #region Metodos genericos

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }

        public void cargarCombo(ComboBox combo, string nombreTabla)
        {
            string consulta = "SELECT * FROM " + nombreTabla;
            DataTable tabla = mostrarConsulta(consulta);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName; // lo que se visualiza
            combo.ValueMember = tabla.Columns[0].ColumnName; // lo que se captura
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.SelectedIndex = -1;
        }
        public void cargarComboFormasPago(ComboBox combo)
        {
            string sql = @"SELECT fp.idFormaPago 'Forma de pago', (fp.nombre + ' - ' + CAST(i.porcentaje AS varchar(5)) + '%') 'Nombre'
                                FROM FormasPago fp JOIN Intereses i ON fp.idInteres = i.idInteres";
            DataTable tabla = mostrarConsulta(sql);
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
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
        }

        public int nuevoID(string columna, string nombreTabla)
        {
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = @"SELECT MAX(" + columna + ") 'ID' FROM " + nombreTabla;

                abrirConexion();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }

        #endregion Metodos genericos

        #region Listados

        public DataTable listadoCompras()
        {
            DataTable resultado = new DataTable();
            try
            {
                abrirConexion();

                string consulta = @"SELECT co.num_comprobante 'N° Comprobante', co.fecha_compra 'Fecha', pr.nombre 'Proveedor', CAST(SUM(dc.cantidadUnit*dc.precioUnit) AS DECIMAL(8,2)) 'Total de la compra'
                                    FROM Compras co
                                    JOIN DetallesCompra dc ON co.idCompra = dc.idCompra
                                    JOIN Proveedores pr ON pr.idProveedor = co.idProveedor
                                    GROUP BY co.num_comprobante, co.fecha_compra, pr.nombre";
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = consulta;
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }
        public DataTable listadoDetalleCompras()
        {
            DataTable resultado = new DataTable();
            try
            {
                abrirConexion();

                string consulta = @"SELECT pd.articulo 'Articulo', pd.descripcion 'Descripcion', dc.cantidadUnit 'Cantidad', CAST ((dc.precioUnit) AS decimal(8,2)) 'Precio', CAST ((dc.cantidadUnit * dc.precioUnit) AS decimal(6,2)) 'Subtotal'
                                    FROM Productos pd
                                    JOIN DetallesCompra dc ON pd.idProducto = dc.idProducto
                                    JOIN Compras c ON c.idCompra = dc.idCompra
                                    WHERE c.idCompra = (SELECT MAX(IdCompra) From Compras)";
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = consulta;
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }
        public DataTable listadoVentaDiaria()
        {
            DataTable resultado = new DataTable();
            try
            {
                abrirConexion();

                string consulta = @"SELECT v.idVenta 'ID Venta', v.fecha_venta 'Fecha', CAST(SUM(p.precioVenta*dv.cantidadUnit) AS decimal(8,2)) 'Monto venta', CAST ((v.montoDescuento) AS decimal(8,2)) 'Descuento',
	                                       fp.nombre 'Forma de pago', i.porcentaje '% interes', CAST(((SUM(p.precioVenta*dv.cantidadUnit) - v.montoDescuento) * (1 + i.porcentaje/100.00))AS decimal(8,2)) 'Totales'
                                    FROM Productos p
                                    JOIN DetallesVenta dv ON p.idProducto = dv.idProducto
                                    JOIN Ventas v on v.idVenta = dv.idVenta
                                    JOIN FormasPago fp on fp.idFormaPago = v.idFormaPago
                                    LEFT JOIN Intereses i ON i.idInteres = fp.idInteres
									WHERE CONVERT(date,v.fecha_venta) = CONVERT(date,GETDATE())
                                    GROUP BY v.idVenta,v.fecha_venta, v.montoDescuento,fp.nombre, i.porcentaje";
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = consulta;
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }
        public DataTable listadosStockBajo()
        {
            DataTable resultado = new DataTable();
            try
            {
                abrirConexion();

                string consulta = @"SELECT p.articulo 'Articulo' , m.nombre 'Marca', co.nombre 'Color', i.cantidad 'Stock', s.nombre 'Sucursal'
                            FROM Productos p 
                            JOIN Inventarios i ON p.idProducto = i.idProducto
                            JOIN Colores co ON p.idColor = co.idColor
                            JOIN Marcas m ON p.idMarca = m.idMarca
                            JOIN Sucursales s ON i.idSucursal = s.idSucursal
                            WHERE i.cantidad <= 2";
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = consulta;
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cerrarConexion();
            }
            return resultado;
        }

        #endregion Listados
    }
}