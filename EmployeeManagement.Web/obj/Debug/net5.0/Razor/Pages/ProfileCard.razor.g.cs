#pragma checksum "D:\ASP.NET\NhomNumber4\EmployeeManagement.Web\Pages\ProfileCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea33cc451ffd377bbad6e10ec858f64fa2426e58"
// <auto-generated/>
#pragma warning disable 1591
namespace Amazon.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ASP.NET\NhomNumber4\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET\NhomNumber4\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ASP.NET\NhomNumber4\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ASP.NET\NhomNumber4\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ASP.NET\NhomNumber4\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ASP.NET\NhomNumber4\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ASP.NET\NhomNumber4\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ASP.NET\NhomNumber4\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ASP.NET\NhomNumber4\EmployeeManagement.Web\_Imports.razor"
using Amazon.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ASP.NET\NhomNumber4\EmployeeManagement.Web\_Imports.razor"
using Amazon.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profilecard")]
    public partial class ProfileCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"text\" b-19mef36eou><h2 b-19mef36eou>Danh sách thành viên trong nhóm</h2></div>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"container\" b-19mef36eou><div class=\"tieu_de\" b-19mef36eou><img src=\"images/hau.jpg\" b-19mef36eou>\r\n        <div class=\"noi_dung\" b-19mef36eou><h2 b-19mef36eou>Trần Minh Hậu</h2>\r\n            <h3 class=\"chuyen_dong_text\" b-19mef36eou>\r\n                Code chính\r\n            </h3>\r\n            <p class=\"chuyen_dong_text\" b-19mef36eou>\r\n                Tôi không có tài năng gì cả. Tôi chỉ đam mê hiểu biết<br b-19mef36eou>\r\n                ---Albert Einstein---\r\n            </p>\r\n            <div class=\"icon\" b-19mef36eou><ul b-19mef36eou><li clas=\"facebook\" b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-facebook-square\" aria-hidden=\"true\" b-19mef36eou></i></a></li>\r\n                    <li b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-twitter-square\" aria-hidden=\"true\" b-19mef36eou></i></a></li>\r\n                    <li b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-instagram\" aria-hidden=\"true\" b-19mef36eou></i></a></li></ul></div></div></div>\r\n\r\n    <div class=\"tieu_de\" b-19mef36eou><img src=\"images/loi.jpg\" alt b-19mef36eou>\r\n        <div class=\"noi_dung\" b-19mef36eou><h2 b-19mef36eou>Hồ Phước Lợi</h2>\r\n            <h3 class=\"chuyen_dong_text\" b-19mef36eou>\r\n                Thiết kế page \"Về chúng tôi\"\r\n            </h3>\r\n            <p class=\"chuyen_dong_text\" b-19mef36eou>\r\n                ...\r\n            </p>\r\n            <div class=\"icon\" b-19mef36eou><ul b-19mef36eou><li clas=\"facebook\" b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-facebook-square\" aria-hidden=\"true\" b-19mef36eou></i></a></li>\r\n                    <li b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-twitter-square\" aria-hidden=\"true\" b-19mef36eou></i></a></li>\r\n                    <li b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-instagram\" aria-hidden=\"true\" b-19mef36eou></i></a></li></ul></div></div></div>\r\n\r\n    <div class=\"tieu_de\" b-19mef36eou><img src=\"images/ben.jpg\" alt b-19mef36eou>\r\n        <div class=\"noi_dung\" b-19mef36eou><h2 b-19mef36eou>Phan Vững Bền</h2>\r\n            <h3 class=\"chuyen_dong_text\" b-19mef36eou>\r\n                Thiết Kế Giao Diện\r\n            </h3>\r\n            <p class=\"chuyen_dong_text\" b-19mef36eou>\r\n                ....\r\n            </p>\r\n            <div class=\"icon\" b-19mef36eou><ul b-19mef36eou><li clas=\"facebook\" b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-facebook-square\" aria-hidden=\"true\" b-19mef36eou></i></a></li>\r\n                    <li b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-twitter-square\" aria-hidden=\"true\" b-19mef36eou></i></a></li>\r\n                    <li b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-instagram\" aria-hidden=\"true\" b-19mef36eou></i></a></li></ul></div></div></div>\r\n    \r\n    <div class=\"tieu_de\" b-19mef36eou><img src=\"images/nghiep.jpg\" alt b-19mef36eou>\r\n            <div class=\"noi_dung\" b-19mef36eou><h2 b-19mef36eou>Nguyễn Thiện Nghiệp</h2>\r\n                <h3 class=\"chuyen_dong_text\" b-19mef36eou>\r\n                    Thiết kế Giao Diện\r\n                </h3>\r\n                <p class=\"chuyen_dong_text\" b-19mef36eou>\r\n                    ....\r\n                </p>\r\n                <div class=\"icon\" b-19mef36eou><ul b-19mef36eou><li clas=\"facebook\" b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-facebook-square\" aria-hidden=\"true\" b-19mef36eou></i></a></li>\r\n                        <li b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-twitter-square\" aria-hidden=\"true\" b-19mef36eou></i></a></li>\r\n                        <li b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-instagram\" aria-hidden=\"true\" b-19mef36eou></i></a></li></ul></div></div></div>\r\n\r\n    <div class=\"tieu_de\" b-19mef36eou><img src=\"images/thang.jpg\" alt b-19mef36eou>\r\n            <div class=\"noi_dung\" b-19mef36eou><h2 b-19mef36eou>Trần Hưu Thắng</h2>\r\n                <h3 class=\"chuyen_dong_text\" b-19mef36eou>\r\n                    Thiết Kế Page \"Dịch Vụ\" & \"Liên Hệ\"\r\n                </h3>\r\n                <p class=\"chuyen_dong_text\" b-19mef36eou>\r\n                    ....\r\n                </p>\r\n                <div class=\"icon\" b-19mef36eou><ul b-19mef36eou><li clas=\"facebook\" b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-facebook-square\" aria-hidden=\"true\" b-19mef36eou></i></a></li>\r\n                        <li b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-twitter-square\" aria-hidden=\"true\" b-19mef36eou></i></a></li>\r\n                        <li b-19mef36eou><a href b-19mef36eou><i class=\"fa fa-instagram\" aria-hidden=\"true\" b-19mef36eou></i></a></li></ul></div></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
