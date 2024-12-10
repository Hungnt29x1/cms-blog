﻿using TeduBlog.Core.Domain.Royalty;
using TeduBlog.Core.Models;
using TeduBlog.Core.Models.Royalty;
using TeduBlog.Core.SeedWorks;

namespace TeduBlog.Core.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction, Guid>
    {
        Task<PagedResult<TransactionDto>> GetAllPaging(string? userName,
         int fromMonth, int fromYear, int toMonth, int toYear, int pageIndex = 1, int pageSize = 10);
    }
}
