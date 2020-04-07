using System;

namespace Domain.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        //IFinancialServiceRepository FinancialServiceRepository { get; }
        int Commit();
    }
}