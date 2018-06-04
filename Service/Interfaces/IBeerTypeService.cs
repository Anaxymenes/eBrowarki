using Data.DTO.FormList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IBeerTypeService {
        List<BeerTypeFormList> GetAllBeerTypeFormList();
    }
}
