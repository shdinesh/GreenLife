using System;

namespace GreenLifeOS
{
    public class StockVo
    {

        public int Id { get; set; }

        public string Product { get; set; }

        public double Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public string Supplier { get; set; }
        public int SupplierId { get; set; }
        public int ProductId { get; set; }

    }
}
