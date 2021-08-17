using Entities.Concrete;

namespace Entities.DTOs
{
    public class productDto:IDto
    {
        public int ProductId{get;set;}
        public string ProductName{get;set;}
        public string BrandName{get;set;}
        public string ColorName{get;set;}
        public string CategoryName { get; set; }
        public int ProductPrice{get;set;}
        public string Description { get; set; }
        public int StockQuantity { get; set; }
    }
}