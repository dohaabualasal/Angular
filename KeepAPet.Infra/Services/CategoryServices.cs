using KeepAPets.Core.Entity;
using KeepAPets.Core.Repository;
using KeepAPets.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeepAPets.Infra.Services
{
    public class CategoryServices:ICategoryServices
    {
        private readonly ICategoryRepository CategoryRepository;
        public CategoryServices(ICategoryRepository categoryRepository)
        {
            CategoryRepository = categoryRepository;
        }
        public Category Create(Category Category)
        {
            CategoryRepository.Create(Category);
            return Category;
        }
        public List<Category> GetAll()
        {
            return CategoryRepository.GetAll();

        }
        public Category Update(Category Category)
        {
            CategoryRepository.Update(Category);
            return Category;
        }
        //public Category Delete(int id)
        //{
        //    CategoryRepository.Delete(id);
        //    return new Category();
        //}
        //public List<Category> Search(CategoryDTO CategoryDTO)
        //{
        //    return CategoryRepository.Search(CategoryDTO);
        //}
        //public async Task<List<Category>> GetAllCategory()
        //{
        //    return await CategoryRepository.GetAllCategory();
        //}
    }
}
