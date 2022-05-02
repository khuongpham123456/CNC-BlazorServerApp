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
        void updateCategory(string idcategory,string name);
        void deleteCategory(string idcategory);
        Category getCategoryFromId(string id);
        void UpdateStatusCategory(string idcategory, int status);
        int CountCategoryFromName(string name);

        string TakeLastIDCategory();
    }
}
