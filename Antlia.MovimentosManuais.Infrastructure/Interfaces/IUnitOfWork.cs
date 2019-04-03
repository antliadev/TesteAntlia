using System;

namespace Antlia.MovimentosManuais.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        MMContext DbContext { get; }

        GenericRepository<Produto> ProdutoRepository { get; }
        GenericRepository<ProdutoCosif> ProdutoCosifRepository { get; }
        GenericRepository<MovimentoManual> MovimentoManualRepository { get; }
        void Save();
    }
}
