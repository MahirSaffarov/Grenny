using DomainLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.TeamVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IWebHostEnvironment _env;
        public TeamService(ITeamRepository teamService,
                                   IWebHostEnvironment env)
        {
            _teamRepository = teamService;
            _env = env;
        }

        public async Task AddAsync(TeamAddVM model)
        {
            string fileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
            await model.Image.SaveFileAsync(fileName, _env.WebRootPath, "images/team");

            Team team = new()
            {
                Name = model.Name,
                Image = fileName,
                About = model.About,
                Position = model.Position
            };

            await _teamRepository.AddAsync(team);
        }

        public async Task DeleteAsync(int id)
        {
            var team = await _teamRepository.GetByIdAsync(id);

            await _teamRepository.DeleteAsync(team);

            string directoryPath = Path.Combine(_env.WebRootPath, "images/team", team.Image);

            if (System.IO.File.Exists(directoryPath))
            {
                System.IO.File.Delete(directoryPath);
            }
        }

        public async Task EditAsync(int teamId, TeamEditVM model)
        {
            var team = await _teamRepository.GetByIdAsync(teamId);

            if (model.NewImage != null)
            {
                string oldPath = Path.Combine(_env.WebRootPath, "images/team", team.Image);

                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }

                string fileName = Guid.NewGuid().ToString() + "_" + model.NewImage.FileName;
                await model.NewImage.SaveFileAsync(fileName, _env.WebRootPath, "images/team");

                team.Image = fileName;
            }

            team.Name = model.Name;
            team.About = model.About;
            team.Position = model.Position;

            await _teamRepository.EditAsync(team);
        }

        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            return await _teamRepository.GetAllAsync();
        }

        public async Task<Team> GetByIdAsync(int id)
        {
            return await _teamRepository.GetByIdAsync(id);
        }
    }
}
