﻿using TeduShop.Data.Infastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repository
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}