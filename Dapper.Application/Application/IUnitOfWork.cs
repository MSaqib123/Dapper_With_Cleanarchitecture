using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Application.Application
{
    public interface IUnitOfWork
    {
        IContactRepository contactRepo { get; }
    }
}
