using Core.src.Commons;
using System.Data;

namespace Core.src;

public interface IGeneralExport
{
    Task<ExportResult> GetExcelReport(DataSet dataset, string fileName);
}
