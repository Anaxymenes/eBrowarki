using Data.DTO;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Service.utils
{
    public class ClaimsMethods {
        static public List<ClaimDTO> GetClaimsList(IEnumerable<Claim> claims) {
            List<ClaimDTO> resutl = new List<ClaimDTO>();
            foreach (var claim in claims)
                resutl.Add(new ClaimDTO { Type = claim.Type.Substring(claim.Type.LastIndexOf("/")+1), Value = claim.Value });
            return resutl;
        }
    }
}
