﻿using System;
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
    public partial class FrmPrincipal : Form {
        private List<Articulo> listaArticulo;
        public FrmPrincipal() {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e) {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            cargarImagen(listaArticulo[0].ImagenUrl);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e) {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen) {
            try {
                pbxArticulos.Load(imagen);
            }
            catch (Exception) {
                pbxArticulos.Load("http://atrilco.com/wp-content/uploads/2017/11/ef3-placeholder-image.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            Frm_NuevoArticulo altaArticulo = new Frm_NuevoArticulo();
            altaArticulo.ShowDialog();
        }
    }
}