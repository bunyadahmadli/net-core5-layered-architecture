
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Concrete.EntityFramework;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Repositories
{
   public class EfCommentRepository:EfEntityRepositoryBase<Comment>,ICommentRepository
    {
        private readonly DbContext _context;

        public EfCommentRepository(DbContext context) : base(context)
        {
            _context = context;
        }
    }
}
