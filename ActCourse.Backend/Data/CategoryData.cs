using ActCourse.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ActCourse.Backend.Data
{
    public class CategoryData : ICategory
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CategoryData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Category> Add(Category entity)
        {
            try
            {
                _applicationDbContext.Categories.Add(entity);
                await _applicationDbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public async Task<Category> Delete(int id)
        {
            try
            {
                var category = await GetById(id);
                if (category == null)
                {
                    throw new Exception("Category not found");
                }
                _applicationDbContext.Categories.Remove(category);
                await _applicationDbContext.SaveChangesAsync();
                return category;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            var categories = await _applicationDbContext.Categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetById(int id)
        {
            var category = await _applicationDbContext.Categories.FirstOrDefaultAsync(c => c.CategoryId == id);
            if (category == null)
            {
                throw new Exception("Category not found");
            }
            return category;
        }

        public async Task<Category> Update(Category entity)
        {
            try
            {
                var category = await GetById(entity.CategoryId);
                if (category == null)
                {
                    throw new Exception("Category not found");
                }
                category.Name = entity.Name;
                category.Description = entity.Description;
                await _applicationDbContext.SaveChangesAsync();
                return category;
            }
            catch (Exception ex)
            {

                throw new Exception($"{ex.Message}");
            }
        }
    }
}
