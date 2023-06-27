using DomainLayer.Entities;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.ProductVM;
using ServiceLayer.ViewModels.AdminVM.TagVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;
        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task AddAsync(TagAddVM model)
        {
            Tag tag = new()
            {
                Name = model.Name
            };

            await _tagRepository.AddAsync(tag);
        }

        public async Task DeleteAsync(int id)
        {
            var tag = await _tagRepository.GetByIdAsync(id);

            await _tagRepository.DeleteAsync(tag);
        }

        public async Task EditAsync(int tagId, TagEditVM model)
        {
            var tag = await _tagRepository.GetByIdAsync(tagId);

            tag.Name = model.Name;

            await _tagRepository.EditAsync(tag);
        }

        public async Task<IEnumerable<Tag>> GetAllAsync()
        {
            return await _tagRepository.GetAllAsync();
        }

        public async Task<Tag> GetByIdAsync(int id)
        {
            return await _tagRepository.GetByIdAsync(id);
        }
    }
}
