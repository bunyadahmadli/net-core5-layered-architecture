using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Concrete.EntityFramework;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Repositories
{
  public  class EfUserRepository:EfEntityRepositoryBase<User>,IUserRepository
    {
        private readonly DbContext _context;

        public EfUserRepository(DbContext context) : base(context)
        {
            _context = context;
        }
    }
}
