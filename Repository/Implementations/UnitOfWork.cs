namespace Repository.Implementations
{
      using System;
      using System.Threading.Tasks;
      using Microsoft.EntityFrameworkCore;
      using Data.Context;
      using Repository.Interfaces;
      
     public class UnitOfWork : IUnitOfWork
      {
          private readonly GaelDbContext _context;
          
          public async Task CommitWork()
          {
              try
              {
                  await _context.SaveChangesAsync();
              }
              catch (DbUpdateException ex)
              {
                  System.Diagnostics.Debug.WriteLine("DbUpdateException: " + ex.Message + " " + ex.StackTrace);
                  foreach (var eve in ex.Entries)
                  {
                      System.Diagnostics.Debug.WriteLine($"Entity of type {eve.Entity.GetType().Name} in state {eve.State} has the following validation errors:");
                  }
                  throw ex;
              }
              catch (Exception ex)
              {
                  System.Diagnostics.Debug.WriteLine("Exception:" + ex.Message + " " + ex.StackTrace);
                  throw ex;
              }
          }
          
          public void Dispose()
          {
              _context.Dispose();
          }
          
          public UnitOfWork(GaelDbContext context, ICamposRepository CamposRepository, IPlantillasRepository PlantillasRepository, ITiposRepository TiposRepository, IValoresRepository ValoresRepository, IOrigenRepository OrigenRepository)
          {
             _context = context;
             Campos = CamposRepository;
             Plantillas = PlantillasRepository;
             Tipos = TiposRepository;
             Valores = ValoresRepository;
             Origen = OrigenRepository;
          }
          public ICamposRepository Campos { get; private set; }
          public IPlantillasRepository Plantillas { get; private set; }
          public ITiposRepository Tipos { get; private set; }
          public IValoresRepository Valores { get; private set; }
          public IOrigenRepository Origen { get; private set; }
    }
}
