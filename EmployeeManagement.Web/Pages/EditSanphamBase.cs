using Amazon.Models;
using Amazon.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Web.Pages
{
    public class EditSanphamBase : ComponentBase
    {
        public Sanpham Sanpham { get; set; } = new Sanpham();

        [Inject]
        public ISanphamService SanphamService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Sanpham = await SanphamService.GetSanpham(int.Parse(Id));
        }
    }
}
