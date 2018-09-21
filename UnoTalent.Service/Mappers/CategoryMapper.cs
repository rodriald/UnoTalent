﻿using System.Collections.Generic;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    public class CategoryMapper : IMapper<Category, CategoryVm>
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
            category.Questions = new List<QuestionVm>();

            if (entity.Questions != null)
            {
                IMapper<Question, QuestionVm> mapper = new QuestionMapper();
                category.Questions = mapper.Map(entity.Questions);
            }
            return category;
        }

        public List<Category> Map(List<CategoryVm> models)
        {
            List<Category> categories = new List<Category>();
            foreach (CategoryVm category in models)
            {
                categories.Add(Map(category));
            }

            return categories;
        }

        public List<CategoryVm> Map(List<Category> entities)
        {
            List<CategoryVm> categories = new List<CategoryVm>();
            foreach (Category category in entities)
            {
                categories.Add(Map(category));
            }

            return categories;
        }
    }
}
