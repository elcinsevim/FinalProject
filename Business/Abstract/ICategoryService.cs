using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICategoryService //kategori ile ilgili dış dünyaya neyi servis etmek istersek burada
    {
        List<Category> GetAll();
        Category GetById(int categoryId);

    }
}
