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

        private void button1_Click(object sender, EventArgs e) {
            Form AgregarArticulo = new Form2();
            AgregarArticulo.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            Form ModificarArticulo = new Form3();
            ModificarArticulo.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            Form EliminarArticulo = new Form4();
            EliminarArticulo.Show();
        }

        private void button6_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
