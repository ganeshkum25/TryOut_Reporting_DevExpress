#pragma checksum "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\Pages\DocumentVIewer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c422b3a98dfe267e0996276720a029f427a71e55"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\_Imports.razor"
using DevExpress.Blazor.Reporting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/documentviewer")]
    public partial class DocumentVIewer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DevExpress.Blazor.Reporting.DxDocumentViewer>(0);
            __builder.AddAttribute(1, "ReportName", "HelloWorld");
            __builder.AddAttribute(2, "Height", "1000px");
            __builder.AddAttribute(3, "Width", "100%");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<DevExpress.Blazor.Reporting.DxDocumentViewerTabPanelSettings>(5);
                __builder2.AddAttribute(6, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "D:\Workspace_POC\PDF-POCs\DevExpress_OnOwn\DevExpress_TryOut_1\WebApplication1\Pages\DocumentVIewer.razor"
                                             340

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591