using Amazon.Models;
using Amazon.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Web.Pages
{
    public class SanphamListBase : ComponentBase
    {
        [Inject]
        public ISanphamService SanphamService { get; set; }

        public IEnumerable<Sanpham> Sanphams { get; set; }

        public bool ShowFooter { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            Sanphams = (await SanphamService.GetSanphams()).ToList();
        }

        protected int SelectedSanphamsCount { get; set; } = 0;

        protected void SanphamSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedSanphamsCount++;
            }
            else
            {
                SelectedSanphamsCount--;
            }
        }
    }

}