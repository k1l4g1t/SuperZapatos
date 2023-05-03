using Microsoft.EntityFrameworkCore;
using SuperZapatos.Domain.Models;
using SuperZapatos.Infraestructure.Interfaces;

namespace SuperZapatos.Infraestructure.Repositories
{
    public class ArticlesRepository : IArticlesRepository
    {
        private readonly AppDBContext _context;
        public ArticlesRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<bool> EditAsync(Articles entity)
        {
            _context.Articles.Update(entity);
            
            var recordsAffected = await _context.SaveChangesAsync();
            return recordsAffected > 0;
        }

        public async Task<IEnumerable<Articles>> GetAllAsync()
        {
            var getAll = await _context.Articles.AsNoTracking().ToListAsync();
            return getAll;
        }

        public async Task<Articles> GetByIdAsync(int id)
        {
            var getById = await _context.Articles!.AsNoTracking().FirstOrDefaultAsync(m => m.Id.Equals(id));
            return getById!;
        }

        public async Task<bool> RegisterAsync(Articles entity)
        {
            await _context.Articles.AddAsync(entity);
            var recordsAffected = await _context.SaveChangesAsync();
            return recordsAffected > 0;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var entity = await GetByIdAsync(id);

            _context.Articles.Remove(entity);
            var recordsAffected = await _context.SaveChangesAsync();
            return recordsAffected > 0;
        }

        public async Task<IEnumerable<Articles>> GetArticlesByStoreId(int storeId)
        {
            var getAll = await _context.Articles.Where(m => m.Store_id.Equals(storeId)).AsNoTracking().ToListAsync();
            return getAll;
        }
    }
}
