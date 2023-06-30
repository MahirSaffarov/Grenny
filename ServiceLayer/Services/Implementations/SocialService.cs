using DomainLayer.Entities;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.DiscountVM;
using ServiceLayer.ViewModels.AdminVM.SocialVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class SocialService : ISocialService
    {
        private readonly ISocialRepository _socialRepository;
        public SocialService(ISocialRepository socialRepository)
        {
            _socialRepository = socialRepository;
        }

        public async Task AddAsync(SocialAddVM model)
        {
            Social social = new()
            {
                Icon = model.Icon,
                Name = model.Name
            };

            await _socialRepository.AddAsync(social);
        }

        public async Task DeleteAsync(int id)
        {
            var discount = await _socialRepository.GetByIdAsync(id);

            await _socialRepository.DeleteAsync(discount);
        }

        public async Task EditAsync(int socialId, SocialEditVM model)
        {
            var social = await _socialRepository.GetByIdAsync(socialId);

            social.Name = model.Name;
            social.Icon = model.Icon;

            await _socialRepository.EditAsync(social);
        }

        public async Task<IEnumerable<Social>> GetAllAsync()
        {
            return await _socialRepository.GetAllAsync();
        }

        public async Task<Social> GetByIdAsync(int id)
        {
            return await _socialRepository.GetByIdAsync(id);
        }
    }
}
