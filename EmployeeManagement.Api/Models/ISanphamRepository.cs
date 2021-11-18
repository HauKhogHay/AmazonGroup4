using Amazon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Api
{
    public interface ISanphamRepository
    {
        Task<IEnumerable<Sanpham>> GetSanphams();
        Task<Sanpham> GetSanpham(int sanphamId);
        Task<Sanpham> AddSanpham(Sanpham sanpham);
        Task<Sanpham> UpdateSanpham(Sanpham sanpham);
        Task<Sanpham> DeleteSanpham(int sanphamId);
        Task<IEnumerable<Sanpham>> Search(string name, Color? color);
    }
}
