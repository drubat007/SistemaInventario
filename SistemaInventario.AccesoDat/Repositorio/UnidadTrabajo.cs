﻿using SistemaInventario.AccesoDat.Repositorio.IRepositorio;
using SistemaInventario.AccesoDatos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDat.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _db;
        public IBodegaRepositorio Bodega { get; private set; }
        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Bodega = new BodegaRepositorio(_db);
        }

        public void Dispose()
        {
           _db.Dispose();
        }

        public async Task Guardar()
        {
           await _db.SaveChangesAsync();
        }
    }
}
