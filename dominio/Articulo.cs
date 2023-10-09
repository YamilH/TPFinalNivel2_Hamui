﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo {  get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion {  get; set; }

        public string ImagenUrl { get; set; }

        public Marca Marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }

        public decimal Precio { get; set; }
    }
}
