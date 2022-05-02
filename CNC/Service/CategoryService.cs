using CNC.Data;
using CNC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Service
{
    public class CategoryService : ICategoryService
    {
        private ApplicationDbContext _applicationDbContext;
        public CategoryService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void addCategory(Category category)
        {
            _applicationDbContext.Categories.Add(category);
            _applicationDbContext.SaveChanges();
        }

        public int CountCategoryFromName(string name)
        {
            return _applicationDbContext.Categories.Count(c => c.Name == name);
        }

        public void deleteCategory(string idcategory)
        {
            _applicationDbContext.Categories.Remove(getCategoryFromId(idcategory));
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<Category> getAllCategories()
        {
            return _applicationDbContext.Categories.ToList();
        }

        public Category getCategoryFromId(string id)
        {
            return _applicationDbContext.Categories.FirstOrDefault(x => x.Id == id);
        }

        public string TakeLastIDCategory()
        {
            return _applicationDbContext.Categories.OrderByDescending(x=>x.Id).Take(1).First().Id;
        }

        public void updateCategory(string idcategory,string name)
        {
            Category category=getCategoryFromId(idcategory);
            if (category != null)
            {
                category.Name = name;
                _applicationDbContext.SaveChanges();
            }
        }

        public void UpdateStatusCategory(string idcategory, int status)
        {
            Category category = getCategoryFromId(idcategory);
            if(category != null)
            {
                category.Status = status;
                _applicationDbContext.SaveChanges();
            }
        }
    }
}
