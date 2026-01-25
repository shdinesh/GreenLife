using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal interface IStockService
    {
        Stock AddNewStock(Stock stock);
        Stock UpdateStock(Stock stock);
        List<StockVo> GetAllStocks();
        Stock GetStockById(int id);
        bool DeleteStock(int id);

    }
}
