using CsvHelper;
using System.Globalization;
using SalesAnalyticsAPI.Models;


public class CsvLoaderService
{
    private readonly AppDbContext _context;

    public CsvLoaderService(AppDbContext context)
    {
        _context = context;
    }

    public async Task LoadCsvAsync(string path)
    {
        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<CsvModel>().ToList();



    }
}
