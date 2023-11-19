using Dapper.Application.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IContactRepository contactRepository)
        {
            contactRepo = contactRepository;
        }

        public IContactRepository contactRepo { get; set; }

    }
}
