﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;

namespace ProgrammersBlog.Services.Abstract
{
   public interface ICategoryService
   {
       Task<IDataResult<Category>> Get(int categoryId);
       Task<IDataResult<IList<Category>>> GetAll();
       Task<IResult> Add(CategoryAddDto categoryAddDto,string createByName);
       Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);

       Task<IResult> Delete(int categoryId);
       Task<IResult> HardDelete(int categoryId);
   }
}