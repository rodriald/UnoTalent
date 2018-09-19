using System.Collections.Generic;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    class CategoryMapper : IMapper<Category, CategoryVm>
    {
        public Category Map(CategoryVm model)
        {
            Category category = new Category();
            category.Id = model.Id;
            category.Name = model.Name;
            return category;
        }

        public CategoryVm Map(Category entity)
        {
            CategoryVm category = new CategoryVm();
            category.Id = entity.Id;
            category.Name = entity.Name;
            return category;
        }

        public List<Category> Map(List<CategoryVm> models)
        {
            List<Category> categories = new List<Category>();
            foreach (CategoryVm category in models)
            {
                Category newCategory = new Category();
                newCategory.Id = category.Id;
                newCategory.Name = category.Name;
                categories.Add(newCategory);
            }

            return categories;
        }

        public List<CategoryVm> Map(List<Category> entities)
        {
            List<CategoryVm> categories = new List<CategoryVm>();
            foreach (Category category in entities)
            {
                CategoryVm newCategory = new CategoryVm();
                newCategory.Id = category.Id;
                newCategory.Name = category.Name;
                categories.Add(newCategory);
            }

            return categories;
        }
    }
}
