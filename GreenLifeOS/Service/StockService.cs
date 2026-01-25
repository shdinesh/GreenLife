using GreenLifeOS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GreenLifeOS.Service
{
    internal class StockService : IStockService
    {
        private readonly IStockRepository stockRepository;

        public StockService(IStockRepository stockRepository)
        {
            this.stockRepository = stockRepository ?? throw new ArgumentNullException(nameof(StockRepository));
        }

        public StockService() : this(new StockRepository())
        {
        }

        public Stock AddNewStock(Stock stock)
        {
            if (stock == null)
                throw new ArgumentNullException(nameof(stock));

            var validationResult = ValidateStock(stock);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var result = stockRepository.AddNewStock(stock);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while adding the stock. Please try again.", ex);
            }
        }


        public bool DeleteStock(int id)
        {
            try
            {
                var existingStock = GetStockById(id);
                if (existingStock == null)
                    throw new ArgumentException($"Stock with ID {id} not found.", nameof(id));

                var result = stockRepository.DeleteStock(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while deleting the stock. Please try again.", ex);
            }
        }

        public List<StockVo> GetAllStocks()
        {
            try
            {
                var stocks = stockRepository.GetAllStocks() ??
                    Enumerable.Empty<Stock>();

                return stocks.Select(MapToStockVo).ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving Stocks. Please try again.", ex);
            }
        }


        public Stock GetStockById(int id)
        {
            try
            {
                var category = stockRepository.GetStockById(id);

                if (category == null)
                    throw new ArgumentException($"Stock with ID {id} not found.", nameof(id));

                return category;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while retrieving the Stock22. Please try again.", ex);
            }
        }

        public Stock UpdateStock(Stock Stock)
        {

            var validationResult = ValidateStock(Stock);
            if (!validationResult.IsValid)
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", validationResult.Errors)}");

            try
            {
                var existingCategory = GetStockById(Stock.Id);
                if (existingCategory == null)
                    throw new ArgumentException($"Stock with ID {Stock.Id} not found.", nameof(Stock.Id));


                var result = stockRepository.UpdateStock(Stock);
                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while updating the Stock. Please try again.", ex);
            }
        }


        private ValidationResult ValidateStock(Stock Stock)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }

        private static StockVo MapToStockVo(Stock stock)
        {
            if (stock == null)
                throw new ArgumentNullException(nameof(stock));

            return new StockVo
            {
                Id = stock.Id,
                Product = stock.Product.Name,
                ProductId = stock.Product.Id,
                Quantity = stock.StockQty,
                Price = stock.Price,
                Date = stock.Date,
                Supplier = stock.Supplier.Name,
                SupplierId = stock.Supplier.Id,
            };
        }


    }


}
