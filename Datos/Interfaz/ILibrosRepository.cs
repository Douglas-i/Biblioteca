﻿using DataAccess.Contracts;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaz
{
    public interface ILibrosRepository : IGenericRepository<Libro>
    {
        //Otros metodos
    }
}
