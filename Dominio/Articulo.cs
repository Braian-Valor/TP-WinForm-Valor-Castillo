using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio {
    public class Articulo {
        public int Id { get; set; }
        [DisplayName("Codigo de articulo")]
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripccion { get; set; }
        public string ImagenUrl { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
    }
}
