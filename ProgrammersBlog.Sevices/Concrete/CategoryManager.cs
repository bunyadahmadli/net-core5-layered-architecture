using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Data.Concrete;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
using ProgrammersBlog.Shared.Utilities.Results.Concrete;

namespace ProgrammersBlog.Services.Concrete
{
  public  class CategoryManager:ICategoryService
  {
      private readonly UnitOfWork _unitOfWork;

      public CategoryManager(UnitOfWork unitOfWork)
      {
          _unitOfWork = unitOfWork;
      }

      public async Task<IDataResult<Category>> Get(int categoryId)
      {
        var category = await _unitOfWork.Categories.GetAsync(c=>c.Id==categoryId,c=>c.Articles);
        if (category != null)
        {
            return new DataResult<Category>(ResultStatus.Success,category);
        }
        return new DataResult<Category>(ResultStatus.Error,"Böyle bir kategori bulunamadı.",null);

      }

        public async Task<IDataResult<IList<Category>>> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c=>c.Articles);

            if (categories.Count>-1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success,categories);
            }
            return new DataResult<IList<Category>>(ResultStatus.Error,"Hiç bir kategori bulunmadı.",null);
        }

        public async Task<IDataResult<IList<Category>>> GetAllByNonDeleted()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c => !c.IsDeleted, c => c.Articles);
            if (categories.Count>-1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success,categories);
            }
            return new DataResult<IList<Category>>(ResultStatus.Error, "Hiç bir kategori bulunmadı.", null);
        }

        public async Task<IResult> Add(CategoryAddDto categoryAddDto, string createByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> Delete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> HardDelete(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
