using ActCourse.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ActCourse.Backend.Data
{
    public class CourseData : ICourse
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CourseData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Course> Add(Course entity)
        {
            try
            {
                _applicationDbContext.Courses.Add(entity);
                await _applicationDbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public async Task<Course> Delete(int id)
        {
            try
            {
                var course = await GetById(id);
                if (course == null)
                {
                    throw new Exception("Course not found");
                }
                _applicationDbContext.Courses.Remove(course);
                await _applicationDbContext.SaveChangesAsync();
                return course;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            try
            {
                var courses = await _applicationDbContext.Courses.ToListAsync();
                return courses;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public Task<Course> GetById(int id)
        {
            try
            {
                var course = _applicationDbContext.Courses.FirstOrDefaultAsync(c => c.CourseId == id);
                if (course == null)
                {
                    throw new Exception("Course not found");
                }
                return course;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public async Task<Course> Update(Course entity)
        {
            try
            {
                var course = await GetById(entity.CourseId);
                if (course == null)
                {
                    throw new Exception("Course not found");
                }
                _applicationDbContext.Courses.Update(entity);
                await _applicationDbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}
