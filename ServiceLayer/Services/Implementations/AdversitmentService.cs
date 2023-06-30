using DomainLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class AdversitmentService : IAdversitmentService
    {
        private readonly IAdversitmentRepository _adversitmentRepository;
        private readonly IWebHostEnvironment _env;
        public AdversitmentService(IAdversitmentRepository adversitmentRepository,
                                   IWebHostEnvironment env)
        {
            _adversitmentRepository = adversitmentRepository;
            _env = env;
        }

        public async Task AddAsync(List<IFormFile> images)
        {
            foreach (var item in images)
            {
                string fileName = Guid.NewGuid().ToString() + "_" + item.FileName;

                await item.SaveFileAsync(fileName, _env.WebRootPath, "images/ads");

                Adversiment adversiment = new()
                {
                    Image = fileName
                };

                await _adversitmentRepository.AddAsync(adversiment);
            }
        }

        public async Task DeleteAsync(int id)
        {
            Adversiment adversiment = await GetByIdAsync(id);

            _adversitmentRepository.DeleteAsync(adversiment);

            string path = Path.Combine(_env.WebRootPath, "images/ads", adversiment.Image);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }

        public async Task EditAsync(Adversiment adversiment, IFormFile newImage)
        {
            string oldPath = Path.Combine(_env.WebRootPath, "images/ads", adversiment.Image);

            if (System.IO.File.Exists(oldPath))
            {
                System.IO.File.Delete(oldPath);
            }

            string fileName = Guid.NewGuid().ToString() + "_" + newImage.FileName;

            await newImage.SaveFileAsync(fileName, _env.WebRootPath, "images/ads");

            adversiment.Image = fileName;

            await _adversitmentRepository.EditAsync(adversiment);
        }

        public async Task<IEnumerable<Adversiment>> GetAllAsync()
        {
            return await _adversitmentRepository.GetAllAsync();
        }

        public async Task<Adversiment> GetByIdAsync(int id)
        {
            return await _adversitmentRepository.GetByIdAsync(id);
        }
    }
}
