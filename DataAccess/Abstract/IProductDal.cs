﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal: TEntityRepository<Product>
    {

        List<ProductDetailDto> GetProductDetails();
    }
       
    }

