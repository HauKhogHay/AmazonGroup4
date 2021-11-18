    using Amazon.Api.Models;
using Amazon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Api
{
    public class SanphamRepository : ISanphamRepository
    {
        private readonly AppDbContext appDbContext;

        public SanphamRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Sanpham> AddSanpham(Sanpham sanpham)
        {
            var result = await appDbContext.Sanphams.AddAsync(sanpham);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Sanpham> DeleteSanpham(int sanphamId)
        {
            var result = await appDbContext.Sanphams
                .FirstOrDefaultAsync(e => e.SanphamId == sanphamId);
            if (result != null)
            {
                appDbContext.Sanphams.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<Sanpham> GetSanpham(int sanphamId)
        {
            return await appDbContext.Sanphams
             .Include(e => e.Color)
             .FirstOrDefaultAsync(e => e.SanphamId == sanphamId);
        }
        /*
        public async Task<Sanpham> GetEmployeeByEmail(string email)
        {
            return await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.Email == email);
        }*/

        public async Task<IEnumerable<Sanpham>> GetSanphams()
        {
            return await appDbContext.Sanphams.ToListAsync();
        }

        public async Task<Sanpham> UpdateSanpham(Sanpham sanpham)
        {
            var result = await appDbContext.Sanphams
                .FirstOrDefaultAsync(e => e.SanphamId == sanpham.SanphamId);

            if (result != null)
            {
                result.TenSP = sanpham.TenSP;
                result.GiaSP = sanpham.GiaSP;          
                result.Color = sanpham.Color;
                result.ColorId = sanpham.ColorId;
                result.PhotoPath = sanpham.PhotoPath;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
        public async Task<IEnumerable<Sanpham>> Search(string name, Color? color)
        {
            IQueryable<Sanpham> query = appDbContext.Sanphams;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.TenSP.Contains(name)
                            /*|| e.GiaSP.Contains(name)*/);
            }

            if (color != null)
            {
                query = query.Where(e => e.Color == color);
            }

            return await query.ToListAsync();
        }
    }
}