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

    public class PlantillasRepository : IPlantillasRepository
    {
        private readonly GaelDbContext _context;

        public PlantillasRepository(GaelDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task Create(Plantillas entity, string user)
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
                Plantillas EntidadAEliminar = await _context.Plantillas.FindAsync(id);

                _context.Plantillas.Remove(EntidadAEliminar);
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
                Plantillas EntidadAEliminar = await _context.Plantillas.FindAsync(id);

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

        public async Task<IEnumerable<Plantillas>> GetAll()
        {
            try
            {
                return await _context.Plantillas.Include(p=>p.Origen).Include(p=>p.Estado).Include(p=>p.Campos).IgnoreQueryFilters().ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Plantillas>> GetAllActive()
        {
            try
            {
               return await _context.Plantillas.Include(p => p.Origen).Include(p => p.Estado).Include(p => p.Campos).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
         }
     
        public async Task<IEnumerable<Plantillas>> GetAllInactive()
        {
            try
            {
                var listadoPlantillas = await _context.Plantillas.IgnoreQueryFilters().ToListAsync();
                var listadoPlantillasActivos = await _context.Plantillas.ToListAsync();

                return listadoPlantillas.Where(entidad => !listadoPlantillasActivos.Contains(entidad));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Plantillas> GetById(decimal id)
        {
            try
            {
                var entidad = await _context.Plantillas.Include(p=>p.Campos).Where(v => v.Plantillasid == id).IgnoreQueryFilters().SingleOrDefaultAsync();

                return entidad; ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Plantillas> Reactivate(decimal id, string user)
        {
            try
            {
                var entidad = await _context.Plantillas.Where(t => t.Plantillasid == id).IgnoreQueryFilters().SingleOrDefaultAsync();
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

        public async Task Update(Plantillas entity, decimal id, string user)
        {
            try
            {
                Plantillas EntidadAActualizar = await _context.Plantillas.FindAsync(id);

                EntidadAActualizar.Nombre = entity.Nombre;
                EntidadAActualizar.RutaPlantilla = entity.RutaPlantilla;
                EntidadAActualizar.SeguridadId = entity.SeguridadId;
                EntidadAActualizar.EstadoId = entity.EstadoId;
                //EntidadAActualizar.DepartamentoId = entity.DepartamentoId;

                EntidadAActualizar.UsuarioUltimaModif = user;
                EntidadAActualizar.FechaUltimaModif = DateTime.Now;

                _context.Plantillas.Update(EntidadAActualizar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool TieneDatosAsociados(Plantillas entidad)
        {
            try
            {
                if (entidad.Campos.Count > 0)
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
