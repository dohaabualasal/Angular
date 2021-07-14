using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Services
{
    public interface ICategoryServices
    {
        Category Create(Category category);
        List<Category> GetAll();
        Category Update(Category category);
        //Category Delete(int id);
        //List<Category> Search(categoryDTO categoryDTO);
        //Task<List<Category>> GetAllcategory();
    }
}
