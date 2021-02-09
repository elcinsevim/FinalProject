
using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
  public  class ProductDetailDto:IDto   //tablodeğiltekbaşınaoyüzdenıdto
    {
        public int ProductId{ get; set; }

        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName{ get; set; }
        public int UnitsInStock { get; set; }
    }
}
