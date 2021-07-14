using KeepAPets.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Core.Repository
{
    public interface ICategoryRepository
    {
        int Create(Category Data);
        List<Category> GetAll();
        int Update(Category Data);
        //int Delete(int id);
        // List<Category> Search(CategoryDTO CategoryDTO);
        //Task<List<Category>> GetAllCategory();
    }
}
