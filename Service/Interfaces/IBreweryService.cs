using Data.DTO;
using Data.DTO.Add;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IBreweryService {
        bool Add(BreweryAdd breweryAdd, List<ClaimDTO> claimsList);
    }
}
