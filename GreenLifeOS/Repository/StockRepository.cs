using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace GreenLifeOS.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly GreenLifeDBContext dbContext;
        private bool disposed = false;

        public StockRepository(GreenLifeDBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public StockRepository() : this(new GreenLifeDBContext())
        {
        }

        public Stock AddNewStock(Stock stock)
        {
            if (stock == null)
                throw new ArgumentNullException(nameof(stock));

            try
            {
                this.dbContext.Stocks.Add(stock);
                this.dbContext.SaveChanges();
                return stock;
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", errorMessages)}", ex);
            }
        }

        public bool DeleteStock(int id)
        {
            var Stock = GetStockById(id);
            if (Stock == null)
                throw new ArgumentException($"Stock with ID {id} not found.", nameof(id));

            this.dbContext.Stocks.Remove(Stock);
            this.dbContext.SaveChanges();
            return true;
        }

        public List<Stock> GetAllStocks()
        {
            return this.dbContext.Stocks
                .AsNoTracking()
                .ToList();
        }

        public Stock GetStockById(int id)
        {
            return this.dbContext.Stocks
                .FirstOrDefault(s => s.Id == id);
        }

        public Stock UpdateStock(Stock stock)
        {
            if (stock == null)
                throw new ArgumentNullException(nameof(Stock));

            var existingStock = GetStockById(stock.Id);
            if (existingStock == null)
                throw new ArgumentException($"Stock with ID {stock.Id} not found.", nameof(Stock.Id));

            try
            {
                this.dbContext.Entry(existingStock).CurrentValues.SetValues(stock);
                this.dbContext.SaveChanges();

                this.dbContext.Entry(existingStock).Reload();
                return existingStock;
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);
                throw new InvalidOperationException($"Validation failed: {string.Join("; ", errorMessages)}", ex);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Concurrency conflict occurred while updating the Stock.", ex);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                this.dbContext?.Dispose();
            }
            disposed = true;
        }
    }


}
