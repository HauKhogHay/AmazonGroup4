using Amazon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Web.Services
{
    public interface ISanphamService
    {
        Task<IEnumerable<Sanpham>> GetSanphams();
        Task<Sanpham> GetSanpham(int id);
    }
}
