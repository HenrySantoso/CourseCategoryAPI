using ActCourse.Backend.DTO;
using ActCourse.Backend.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;


namespace ActCourse.Backend.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryAddDTO, Category>();
            CreateMap<CategoryUpdateDTO, Category>();
            CreateMap<Course, CourseDTO>();
            CreateMap<CourseAddDTO, Course>();
            CreateMap<CourseUpdateDTO, Course>();
            CreateMap<UserAddDTO, IdentityUser>();
            CreateMap<IdentityUser, UserDTO>();
            CreateMap<IdentityRole, RoleDTO>();
        }
    }
}
