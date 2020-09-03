using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Concrete.EntityFramework;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Repositories
{
   public class EfCatedosyRepository:EfEntityRepositoryBase<Category>,ICategoryRepository
    {
        private readonly DbContext _context;

        public EfCatedosyRepository(DbContext context) : base(context)
        {
            _context = context;
        }
    }
}
