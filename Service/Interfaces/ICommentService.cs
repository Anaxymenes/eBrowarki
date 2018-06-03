using AutoMapper;
using Data.DTO;
using Data.DTO.Add;
using Data.DTO.Edit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface ICommentService {

        CommentDTO Add(CommentAdd commentAdd, List<ClaimDTO> claims);
        CommentDTO Edit(CommentEdit commentEdit, List<ClaimDTO> claims);
        bool Delete(int id, List<ClaimDTO> claims);
    }
}
