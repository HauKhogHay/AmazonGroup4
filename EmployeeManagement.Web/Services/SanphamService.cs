using Amazon.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Amazon.Web.Services
{
    public class SanphamService : ISanphamService
    {
        private readonly HttpClient httpClient;

        public SanphamService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Sanpham> GetSanpham(int id)
        {
            return await httpClient.GetJsonAsync<Sanpham>($"api/sanphams/{id}");
        }

        public async Task<IEnumerable<Sanpham>> GetSanphams()
        {
            return await httpClient.GetJsonAsync<Sanpham[]>("api/sanphams");
        }
    }
}
