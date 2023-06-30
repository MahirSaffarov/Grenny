using DomainLayer.Entities;
using ServiceLayer.ViewModels.AdminVM.BrandVM;
using ServiceLayer.ViewModels.BrandPageVM;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBrandService
    {
        Task<IEnumerable<Brand>> GetAllAsync();
        Task<Brand> GetByIdAsync(int id);
        Task AddAsync(BrandAddVM model);
        Task DeleteAsync(int id);
        Task EditAsync(int brandId, BrandEditVM model);
        Task<IEnumerable<Brand>> GetAllWithIncludes();
        Task<List<Brand>> GetPaginatedDatasAsync(int page, int take);
        List<BrandPageVM> GetMappedDatas(List<Brand> brands);
        Task<int> GetCountAsync();
    }
}
