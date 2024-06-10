namespace Repository.Implementations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Data.Context;
    using Data.Entities;
    using Interfaces;

    public class ValoresRepository : IValoresRepository
    {
        private readonly GaelDbContext _context;

        public ValoresRepository(GaelDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task Create(Valores entity, string user)
        {
            try
            {
                entity.FechaAlta = DateTime.Now;
                entity.UsuarioCreacion = user;

                await _context.AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Delete(decimal id)
        {
            try
            {
                Valores EntidadAEliminar = await _context.Valores.FindAsync(id);

                _context.Valores.Remove(EntidadAEliminar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteLogical(decimal id, string motivoBaja, string user)
        {
            try
            {
                Valores EntidadAEliminar = await _context.Valores.FindAsync(id);

                if (TieneDatosAsociados(EntidadAEliminar))
                {
                    throw new Exception("No se puede eliminar la Entidad Valores. Tiene datos asociados.");
                }

                EntidadAEliminar.FechaBaja = DateTime.Now;
                EntidadAEliminar.MotivoBaja = motivoBaja;
                EntidadAEliminar.FechaUltimaModif = DateTime.Now;
                EntidadAEliminar.UsuarioUltimaModif = user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Valores>> GetAll()
        {
            try
            {
                return await _context.Valores.IgnoreQueryFilters().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Valores>> GetAllActive()
        {
            try
            {
                return await _context.Valores.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Valores>> GetAllInactive()
        {
            try
            {
                var listadoValores = await _context.Valores.IgnoreQueryFilters().ToListAsync();
                var listadoValoresActivos = await _context.Valores.ToListAsync();

                return listadoValores.Where(entidad => !listadoValoresActivos.Contains(entidad));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Valores> GetById(decimal id)
        {
            try
            {
                var entidad = await _context.Valores.Where(v => v.Valoresid == id).IgnoreQueryFilters().SingleOrDefaultAsync();

                return entidad; ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Valores> Reactivate(decimal id, string user)
        {
            try
            {
                var entidad = await _context.Valores.Where(t => t.Valoresid == id).IgnoreQueryFilters().SingleOrDefaultAsync();
                if (entidad == null)
                {
                    return null;
                }

                entidad.FechaBaja = null;
                entidad.MotivoBaja = null;
                entidad.FechaUltimaModif = DateTime.Now;
                entidad.UsuarioUltimaModif = user;

                return entidad; ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Update(Valores entity, decimal id, string user)
        {
            try
            {
                Valores EntidadAActualizar = await _context.Valores.FindAsync(id);

                EntidadAActualizar.CodigoValor = entity.CodigoValor;
                EntidadAActualizar.NombreValor = entity.NombreValor;
                EntidadAActualizar.DescripcionValor = entity.DescripcionValor;
                EntidadAActualizar.TiposId = entity.TiposId;

                EntidadAActualizar.UsuarioUltimaModif = user;
                EntidadAActualizar.FechaUltimaModif = DateTime.Now;

                _context.Valores.Update(EntidadAActualizar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool TieneDatosAsociados(Valores entidad)
        {
            try
            {
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
