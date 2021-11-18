using Amazon.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Web.Pages
{
    public class DisplaySanphamBase : ComponentBase
    {
        [Parameter]
        public Sanpham Sanpham { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }

        protected bool IsSelected { get; set; }

        [Parameter]
        public EventCallback<bool> OnSanphamSelection { get; set; }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            IsSelected = (bool)e.Value;
            await OnSanphamSelection.InvokeAsync(IsSelected);
        }
    }
}
