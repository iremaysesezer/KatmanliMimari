using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void  Commit();
    }
}
