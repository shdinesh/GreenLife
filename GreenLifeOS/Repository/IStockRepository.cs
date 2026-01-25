using System.Collections.Generic;

namespace GreenLifeOS.Repository
{
    internal interface IStockRepository
    {
        Stock AddNewStock(Stock stock);
        Stock UpdateStock(Stock stock);
        List<Stock> GetAllStocks();
        Stock GetStockById(int id);
        bool DeleteStock(int id);

    }
}
