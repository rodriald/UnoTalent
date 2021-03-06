﻿using System.Collections.Generic;
using UnoTalent.Data.Entities;
using UnoTalent.Service.Mappers.Abstractions;
using UnoTalent.Service.Models;

namespace UnoTalent.Service.Mappers
{
    public class CategoryMapper : IMapper<Category, CategoryVm>
    {
        private readonly IMapper<Question, QuestionVm> _questionMapper;

        public CategoryMapper(IMapper<Question, QuestionVm> questionMapper)
        {
            _questionMapper = questionMapper;
        }

        public Category Map(CategoryVm model)
        {
            Category category = new Category();
            category.Id = model.Id;
            category.Name = model.Name;
            category.Questions = new List<Question>();
            if (model.Questions != null)
            {
                category.Questions = _questionMapper.Map(model.Questions);
            }
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
                category.Questions = _questionMapper.Map(entity.Questions);
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
