﻿using Core.src.Commons;
using System.Data;

namespace Core.src;

internal class GeneralExport : ExcelExportBase<string>, IGeneralExport
{
    protected override DataTable ListToDataTable(List<string> results)
    {
        throw new NotImplementedException();
    }

    public async Task<ExportResult> GetExcelReport(DataSet dataset, string fileName)
    {

        var rawData = await ExportExcel(dataset.Tables[0], false);

        return new ExportResult(rawData, $"{fileName}.xlsx", DateTime.Now, ExcelContentType);
    }
}
