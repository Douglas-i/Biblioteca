﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    //Una entidad por cada tabla de sql, contendra los atributos de las tablas
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
    }
}
