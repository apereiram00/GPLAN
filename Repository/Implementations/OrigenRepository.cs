namespace Repository.Implementations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Shared;
    using Data.Context;
    using Interfaces;
    using Data.Entities;
    using System.Runtime.Remoting.Contexts;

    public class OrigenRepository : IOrigenRepository
    {
        private readonly GaelDbContext _context;

        public OrigenRepository(GaelDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task Create(Origen entity, string user)
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
                Origen EntidadAEliminar = await _context.Origen.FindAsync(id);

                _context.Origen.Remove(EntidadAEliminar);
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
                Origen EntidadAEliminar = await _context.Origen.FindAsync(id);

                if (TieneDatosAsociados(EntidadAEliminar))
                {
                    throw new Exception("No se puede eliminar la Entidad Origen. Tiene datos asociados.");
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

        public async Task<IEnumerable<Origen>> GetAll()
        {
            try
            {
                return await _context.Origen.IgnoreQueryFilters().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Origen>> GetAllActive()
        {
            try
            {
                return await _context.Origen.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Origen>> GetAllInactive()
        {
            try
            {
                var listadoOrigen = await _context.Origen.IgnoreQueryFilters().ToListAsync();
                var listadoOrigenActivos = await _context.Origen.ToListAsync();

                return listadoOrigen.Where(entidad => !listadoOrigenActivos.Contains(entidad));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Origen> GetById(decimal id)
        {
            try
            {
                var entidad = await _context.Origen.Where(v => v.Origenid == id).IgnoreQueryFilters().SingleOrDefaultAsync();

                return entidad; ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Origen> Reactivate(decimal id, string user)
        {
            try
            {
                var entidad = await _context.Origen.Where(t => t.Origenid == id).IgnoreQueryFilters().SingleOrDefaultAsync();
                if (entidad == null)
                {
                    return null;
                }

                entidad.FechaBaja = DateTime.Now;
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

        public async Task Update(Origen entity, decimal id, string user)
        {
            try
            {
                Origen EntidadAActualizar = await _context.Origen.FindAsync(id);

                EntidadAActualizar.UsuarioUltimaModif = user;
                EntidadAActualizar.FechaUltimaModif = DateTime.Now;

                _context.Origen.Update(EntidadAActualizar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool TieneDatosAsociados(Origen entidad)
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