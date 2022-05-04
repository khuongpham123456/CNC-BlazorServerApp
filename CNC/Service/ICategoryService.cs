using CNC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNC.Service
{
    public interface ICategoryService
    {
        IEnumerable<Category> getAllCategories();
        void addCategory(Category category);
        void updateCategory(int idcategory,string name);
        void deleteCategory(int idcategory);
        Category getCategoryFromId(int id);
        void UpdateStatusCategory(int idcategory, int status);
        int CountCategoryFromName(string name);

        int TakeLastIDCategory();
        Category checkNameInCategory(int id, String name);
    }
}
