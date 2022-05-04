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

        public Category checkNameInCategory(int id, string name)
        {
            return _applicationDbContext.Categories.Where(x => x.Name == name && x.Id != id).FirstOrDefault();
        }

        public int CountCategoryFromName(string name)
        {
            return _applicationDbContext.Categories.Count(c => c.Name == name);
        }

        public void deleteCategory(int idcategory)
        {
            _applicationDbContext.Categories.Remove(getCategoryFromId(idcategory));
            _applicationDbContext.SaveChanges();
        }

        public Category findByNameCategory(string name)
        {
            return _applicationDbContext.Categories.Where(x => x.Name == name).FirstOrDefault();
        }

        public IEnumerable<Category> getAllCategories()
        {
            return _applicationDbContext.Categories.ToList();
        }

        public Category getCategoryFromId(int id)
        {
            return _applicationDbContext.Categories.FirstOrDefault(x => x.Id == id);
        }

        public int TakeLastIDCategory()
        {
            IEnumerable<Category> categories = getAllCategories();
            if(categories.LongCount() != 0)
            {
                return _applicationDbContext.Categories.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            }
            return 0;
        }

        public void updateCategory(int idcategory,string name)
        {
            Category category=getCategoryFromId(idcategory);
            if (category != null)
            {
                category.Name = name;
                _applicationDbContext.SaveChanges();
            }
        }

        public void UpdateStatusCategory(int idcategory, int status)
        {
            Category category = getCategoryFromId(idcategory);
            if(category != null)
            {
                _applicationDbContext.SaveChanges();
            }
        }
    }
}
