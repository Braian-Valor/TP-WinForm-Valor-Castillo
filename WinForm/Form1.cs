using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Agregar_Articulo = new Form2();
            Agregar_Articulo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Modificar_Articulo = new Form3();
            Modificar_Articulo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Eliminar_Articulo = new Form4();
            Eliminar_Articulo.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Listar_Articulo = new Form5();
            Listar_Articulo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Busqueda_Articulo = new Form6();
            Busqueda_Articulo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form Articulo_detallado = new Form7();
            Articulo_detallado.Show();
        }
    }
}
