using Core.src.Commons;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;

namespace Core.src;

public static class DependencyInjection
{
    public static IServiceCollection AddKMExportService(this IServiceCollection services,IConfiguration configuration)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        services.AddScoped<IGeneralExport, GeneralExport>();
        services.AddScoped<IExportObjectManager, ExportObjectManager>();

        return services;
    }
}
