﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio {
    public class ArticuloNegocio {
        public List<Articulo> listar() {
            
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, Nombre, A.Descripcion, ImagenUrl, M.Descripcion Marca, C.Descripcion Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) {
                    Articulo aux = new Articulo();
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripccion = (string)lector["Descripcion"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripccion = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripccion = (String)lector["Categoria"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public void agregar(Articulo nuevoArticulo) {
            AccesoDatos datos = new AccesoDatos();

            try {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion) values('" + nuevoArticulo.CodigoArticulo + "', '" + nuevoArticulo.Nombre + "', '" + nuevoArticulo.Descripccion + "')");
                datos.ejecutarAccion();
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }
        }
    }
}
