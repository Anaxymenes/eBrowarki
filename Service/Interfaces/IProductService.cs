using Data.DBModels;
using Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IProductService {
        ProductDTO GetById(int id);
        List<ProductDTO> GetAllProductByType(bool isBeer);

    }
}
