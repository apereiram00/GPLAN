namespace Repository.Interfaces
{
      using System;
      using System.Threading.Tasks;
      
     public interface IUnitOfWork : IDisposable
      {
          Task CommitWork();

          ICamposRepository Campos { get; }
          IOrigenRepository Origen { get; }
          ITiposRepository Tipos { get; }
          IValoresRepository Valores { get; }
          IPlantillasRepository Plantillas { get; }
    }
}
