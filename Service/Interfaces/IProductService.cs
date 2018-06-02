using Data.DBModels;
using Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IProductService {
        ProductDTO GetBeerById(int id);
        ProductDTO GetBreweryById(int id);
        List<ProductDTO> GetAllProductByType(bool v, int page, int itemsOnPage);
    }
}
