using DomainLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.BlogVM;
using ServiceLayer.ViewModels.AdminVM.CategoryVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.ViewModels.BlogPageVM;
using ServiceLayer.Helpers;

namespace ServiceLayer.Services.Implementations
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IWebHostEnvironment _env;
        public BlogService(IBlogRepository blogRepository,
                           IWebHostEnvironment env)
        {
            _blogRepository = blogRepository;
            _env = env;
        }

        public async Task AddAsync(BlogAddVM model)
        {
            string fileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
            await model.Image.SaveFileAsync(fileName, _env.WebRootPath, "images/blog");

            Blog blog = new()
            {
                TeamId = model.TeamId,
                Text = model.Text,
                Title = model.Title,
                Image = fileName
            };

            await _blogRepository.AddAsync(blog);
        }

        public async Task DeleteAsync(int id)
        {
            var blog = await _blogRepository.GetByIdAsync(id);

            await _blogRepository.DeleteAsync(blog);

            string directoryPath = Path.Combine(_env.WebRootPath, "images/blog", blog.Image);

            if (System.IO.File.Exists(directoryPath))
            {
                System.IO.File.Delete(directoryPath);
            }
        }

        public async Task EditAsync(int blogId, BlogEditVM model)
        {
            var blog = await _blogRepository.GetByIdAsync(blogId);

            if (model.NewImage != null)
            {
                string oldPath = Path.Combine(_env.WebRootPath, "images/blog", blog.Image);

                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }

                string fileName = Guid.NewGuid().ToString() + "_" + model.NewImage.FileName;
                await model.NewImage.SaveFileAsync(fileName, _env.WebRootPath, "images/blog");

                blog.Image = fileName;
            }

            blog.Text = model.Text;
            blog.Title = model.Title;
            blog.TeamId = model.TeamId;

            await _blogRepository.EditAsync(blog);
        }

        public async Task<IEnumerable<Blog>> GetAllWithIncludes()
        {
            Func<IQueryable<Blog>, IIncludableQueryable<Blog, object>>[] includeFuncs =
            {
                entity => entity.Include(m=>m.Team),
            };

            return await _blogRepository.GetAllWithIncludesAsync(includeFuncs);
        }

        public async Task<Blog> GetByIdWithAllIncludesAsync(int id)
        {
            Func<IQueryable<Blog>, IIncludableQueryable<Blog, object>>[] includeFuncs =
            {
                entity => entity.Include(m=>m.Team),
            };

            return await _blogRepository.GetByIdWithAllIncludesAsync(id, includeFuncs);
        }
    }
}
