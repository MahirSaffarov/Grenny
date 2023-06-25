using DomainLayer.Entities;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class WishlistService : IWishlistService
    {
        private readonly IWishlistRepository _wishlist;
        public WishlistService(IWishlistRepository wishlist)
        {
            _wishlist = wishlist;
        }
        public async Task CreateAsync(AppUser user)
        {
            Wishlist wishlist = new();

            wishlist.AppUserId = user.Id;
            await _wishlist.AddAsync(wishlist);
        }
    }
}
