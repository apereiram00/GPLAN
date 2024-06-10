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

    public class TiposRepository : ITiposRepository
    {
        private readonly GaelDbContext _context;

        public TiposRepository(GaelDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task Create(Tipos entity, string user)
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
                Tipos EntidadAEliminar = await _context.Tipos.FindAsync(id);

                _context.Tipos.Remove(EntidadAEliminar);
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
                Tipos EntidadAEliminar = await _context.Tipos.FindAsync(id);

                if (TieneDatosAsociados(EntidadAEliminar))
                {
                    throw new Exception("No se puede eliminar la Entidad Tipos. Tiene datos asociados.");
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

        public async Task<IEnumerable<Tipos>> GetAll()
        {
            try
            {
                return await _context.Tipos.IgnoreQueryFilters().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Tipos>> GetAllActive()
        {
            try
            {
                return await _context.Tipos.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Tipos>> GetAllInactive()
        {
            try
            {
                var listadoTipos = await _context.Tipos.IgnoreQueryFilters().ToListAsync();
                var listadoTiposActivos = await _context.Tipos.ToListAsync();

                return listadoTipos.Where(entidad => !listadoTiposActivos.Contains(entidad));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Tipos> GetById(decimal id)
        {
            try
            {
                var entidad = await _context.Tipos.Where(v => v.Tiposid == id).IgnoreQueryFilters().SingleOrDefaultAsync();

                return entidad; ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Tipos> Reactivate(decimal id, string user)
        {
            try
            {
                var entidad = await _context.Tipos.Where(t => t.Tiposid == id).IgnoreQueryFilters().SingleOrDefaultAsync();
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

        public async Task Update(Tipos entity, decimal id, string user)
        {
            try
            {
                Tipos EntidadAActualizar = await _context.Tipos.FindAsync(id);

                EntidadAActualizar.CodigoTipo = entity.CodigoTipo;
                EntidadAActualizar.NombreTipo = entity.NombreTipo;
                EntidadAActualizar.DescripcionTipo = entity.DescripcionTipo;

                EntidadAActualizar.UsuarioUltimaModif = user;
                EntidadAActualizar.FechaUltimaModif = DateTime.Now;

                _context.Tipos.Update(EntidadAActualizar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool TieneDatosAsociados(Tipos entidad)
        {
            try
            {
                if (entidad.Valores.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
