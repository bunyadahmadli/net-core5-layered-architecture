using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
   public interface IUnitOfWork:IAsyncDisposable
   {
       IArticleRepository Articles { get; }
       ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; } //_unitOfWork.Users.AddAsync()
        // _unitOfWork.Categories(category)
        // _unitOfWork.SaveAsync()
        Task<int> SaveAsync();

   }
}
