using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinForm {
    public partial class Frm_NuevoArticulo : Form {
        private Articulo articulo = null;
        public Frm_NuevoArticulo() {
            InitializeComponent();
        }

        public Frm_NuevoArticulo(Articulo articulo) {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            //Articulo nuevoArticulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodigoArticulo = tBox_CodigoArticulo.Text;
                articulo.Nombre = tBox_Nombre.Text;
                articulo.Descripccion = tBox_Descripcion.Text;
                articulo.Marca = (Marca)cBox_Marca.SelectedItem;
                articulo.Categoria = (Categoria)cBox_Categoria.SelectedItem;
                articulo.ImagenUrl = tBox_DirImagen.Text;
                articulo.Precio = decimal.Parse(tBox_Precio.Text);

                if (articulo.Id != 0) {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado correctamente");
                }
                else {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado");
                }
                Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Frm_NuevoArticulo_Load(object sender, EventArgs e) {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try {
                cBox_Marca.DataSource = marcaNegocio.listar();
                cBox_Marca.ValueMember = "Id";
                cBox_Marca.DisplayMember = "Descripcion";
                cBox_Categoria.DataSource = categoriaNegocio.listar();
                cBox_Categoria.ValueMember = "Id";
                cBox_Categoria.DisplayMember = "Descripcion";

                if (articulo != null) {
                    tBox_CodigoArticulo.Text = articulo.CodigoArticulo;
                    tBox_Nombre.Text = articulo.Nombre;
                    tBox_Descripcion.Text = articulo.Descripccion;
                    cBox_Marca.SelectedValue = articulo.Marca.Id;
                    cBox_Categoria.SelectedValue = articulo.Categoria.Id;
                    tBox_DirImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    tBox_Precio.Text = Convert.ToString(articulo.Precio);
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tBox_DirImagen_Leave(object sender, EventArgs e) {
            cargarImagen(tBox_DirImagen.Text);
        }

        private void cargarImagen(string imagen) {
            try {
                pBoxAlta.Load(imagen);
            }
            catch (Exception) {
                pBoxAlta.Load("http://atrilco.com/wp-content/uploads/2017/11/ef3-placeholder-image.jpg");
            }
        }
    }
}
