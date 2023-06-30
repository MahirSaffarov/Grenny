using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.RatingVM;
using ServiceLayer.ViewModels.AdminVM.TagVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;
        public RatingService(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public async Task AddAsync(RatingAddVM model)
        {
            Rating rating = new()
            {
                RatingCount = model.RatingCount
            };

            await _ratingRepository.AddAsync(rating);
        }

        public async Task DeleteAsync(int id)
        {
            var rating = await _ratingRepository.GetByIdAsync(id);

            await _ratingRepository.DeleteAsync(rating);
        }

        public async Task EditAsync(int ratingId, RatingEditVM model)
        {
            var rating = await _ratingRepository.GetByIdAsync(ratingId);

            rating.RatingCount = model.RatingCount;

            await _ratingRepository.EditAsync(rating);
        }

        public async Task<IEnumerable<Rating>> GetAllAsync()
        {
            return await _ratingRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Rating>> GetAllWithIncludes()
        {
            Func<IQueryable<Rating>, IIncludableQueryable<Rating, object>>[] includeFuncs =
{
                entity => entity.Include(m=>m.Products)
            };

            return await _ratingRepository.GetAllWithIncludesAsync(includeFuncs);
        }

        public async Task<Rating> GetByIdAsync(int id)
        {
            return await _ratingRepository.GetByIdAsync(id);
        }
    }   
}
