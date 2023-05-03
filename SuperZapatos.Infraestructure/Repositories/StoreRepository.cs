using Microsoft.EntityFrameworkCore;
using SuperZapatos.Domain.Models;
using SuperZapatos.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperZapatos.Infraestructure.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly AppDBContext _context;
        public StoreRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<bool> EditAsync(Store entity)
        {
            _context.Store.Update(entity);

            var recordsAffected = await _context.SaveChangesAsync();
            return recordsAffected > 0;
        }

        public async Task<IEnumerable<Store>> GetAllAsync()
        {
            var getAll = await _context.Store.AsNoTracking().ToListAsync();
            return getAll;
        }

        public async Task<Store> GetByIdAsync(int id)
        {
            var getById = await _context.Store!.AsNoTracking().FirstOrDefaultAsync(m => m.Id.Equals(id));
            return getById!;
        }

        public async Task<bool> RegisterAsync(Store entity)
        {
            await _context.Store.AddAsync(entity);
            var recordsAffected = await _context.SaveChangesAsync();
            return recordsAffected > 0;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var entity = await GetByIdAsync(id);

            _context.Store.Remove(entity);
            var recordsAffected = await _context.SaveChangesAsync();
            return recordsAffected > 0;
        }
    }
}
