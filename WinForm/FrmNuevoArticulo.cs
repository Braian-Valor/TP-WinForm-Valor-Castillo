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
        public Frm_NuevoArticulo() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            Articulo nuevoArticulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try {
                nuevoArticulo.CodigoArticulo = tBox_CodigoArticulo.Text;
                nuevoArticulo.Nombre = tBox_Nombre.Text;
                nuevoArticulo.Descripccion = tBox_Descripcion.Text;
                nuevoArticulo.Marca = (Marca)cBox_Marca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cBox_Categoria.SelectedItem;
                nuevoArticulo.ImagenUrl = tBox_DirImagen.Text;

                negocio.agregar(nuevoArticulo);
                MessageBox.Show("Articulo agregado");
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
                cBox_Categoria.DataSource = categoriaNegocio.listar();
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
