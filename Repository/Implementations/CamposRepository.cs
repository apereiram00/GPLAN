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

    public class CamposRepository : ICamposRepository
    {
        private readonly GaelDbContext _context;

        public CamposRepository(GaelDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task Create(Campos entity, string user)
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
                Campos EntidadAEliminar = await _context.Campos.FindAsync(id);

                _context.Campos.Remove(EntidadAEliminar);
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
                Campos EntidadAEliminar = await _context.Campos.FindAsync(id);

                if (TieneDatosAsociados(EntidadAEliminar))
                {
                    throw new Exception("No se puede eliminar la Entidad Campos. Tiene datos asociados.");
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

        public async Task<IEnumerable<Campos>> GetAll()
        {
            try
            {
                return await _context.Campos.IgnoreQueryFilters().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Campos>> GetAllActive()
        {
            try
            {
                return await _context.Campos.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Campos>> GetAllInactive()
        {
            try
            {
                var listadoCampos = await _context.Campos.IgnoreQueryFilters().ToListAsync();
                var listadoCamposActivos = await _context.Campos.ToListAsync();

                return listadoCampos.Where(entidad => !listadoCamposActivos.Contains(entidad));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Campos> GetById(decimal id)
        {
            try
            {
                var entidad = await _context.Campos.Where(v => v.Camposid == id).IgnoreQueryFilters().SingleOrDefaultAsync();

                return entidad; ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Campos> Reactivate(decimal id, string user)
        {
            try
            {
                var entidad = await _context.Campos.Where(t => t.Camposid == id).IgnoreQueryFilters().SingleOrDefaultAsync();
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

        public async Task Update(Campos entity, decimal id, string user)
        {
            try
            {
                Campos EntidadAActualizar = await _context.Campos.FindAsync(id);

                EntidadAActualizar.CampoPlantilla = entity.CampoPlantilla;
                EntidadAActualizar.CampoExterno = entity.CampoExterno;
                EntidadAActualizar.PlantillaId = entity.PlantillaId;
                EntidadAActualizar.TipoCampoId = entity.TipoCampoId;

                EntidadAActualizar.UsuarioUltimaModif = user;
                EntidadAActualizar.FechaUltimaModif = DateTime.Now;

                _context.Campos.Update(EntidadAActualizar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool TieneDatosAsociados(Campos entidad)
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
