﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm {
    class Articulo {
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripccion { get; set; }
        public string ImagenUrl { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
    }
}
