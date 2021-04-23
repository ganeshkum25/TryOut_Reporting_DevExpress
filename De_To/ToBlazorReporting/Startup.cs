using System;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.Blazor.Reporting;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ToBlazorReporting.Services;

namespace ToBlazorReporting
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDevExpressControls();
            services.AddScoped<ReportStorageWebExtension, CustomReportStorageWebExtension>();
            services.AddTransient<IWebDocumentViewerReportResolver, CustomWebDocumentViewerReportResolver>();

            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.ConfigureReportingServices(configurator =>
            {
                configurator.ConfigureReportDesigner(designerConfigurator =>
                {
                    designerConfigurator.RegisterDataSourceWizardConfigFileConnectionStringsProvider();
                    designerConfigurator.RegisterObjectDataSourceWizardTypeProvider<ObjectDataSourceWizardCustomTypeProvider>();
                    designerConfigurator.RegisterObjectDataSourceConstructorFilterService<CustomObjectDataSourceConstructorFilterService>();
                });
                configurator.ConfigureWebDocumentViewer(viewerConfigurator =>
                {
                    viewerConfigurator.UseCachedReportSourceBuilder();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            var reportingLogger = loggerFactory.CreateLogger("DXReporting");
            DevExpress.XtraReports.Web.ClientControls.LoggerService.Initialize((exception, message) =>
            {
                var logMessage = $"[{DateTime.Now}]: Exception occurred. Message: '{message}'. Exception Details:\r\n{exception}";
                reportingLogger.LogError(logMessage);
            });
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions;
            app.UseDevExpressControls();
            app.UseDevExpressBlazorReporting();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();
            
            app.UseDevExpressBlazorReporting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
