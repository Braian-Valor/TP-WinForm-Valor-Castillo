using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm {
    class Articulo {
        public string codigoArticulo { get; set; }
        public string nombre { get; set; }
        public string descripccion { get; set; }
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }
        public string imagen { get; set; }
        public float precio { get; set; }

    }
}
