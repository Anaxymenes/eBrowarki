using AutoMapper;
using Data.DBModels;
using Data.DTO;
using Data.DTO.Add;
using Data.DTO.Edit;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CommentService : ICommentService {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;

        public CommentService(
                IMapper mapper,
                ICommentRepository commentRepository
            ) {
            this._mapper = mapper;
            this._commentRepository = commentRepository;
        }

        public CommentDTO Add(CommentAdd commentAdd, List<ClaimDTO> claims) {
            Comment comment = _mapper.Map<Comment>(commentAdd);
            comment.AccountId = Convert.ToInt32(claims.Find(x => x.Type == "nameidentifier").Value);
            var result = _commentRepository.Add(comment);
            if (result !=null)
                return _mapper.Map<CommentDTO>(result);
            return null;
        }

        public bool Delete(int id, List<ClaimDTO> claims) {
            return _commentRepository.Delete(id, Convert.ToInt32(claims.Find(x => x.Type == "nameidentifier").Value));
        }

        public CommentDTO Edit(CommentEdit commentEdit, List<ClaimDTO> claims) {
            var results = _commentRepository.Edit(_mapper.Map<Comment>(commentEdit), 
                Convert.ToInt32(claims.Find(x => x.Type == "nameidentifier").Value));
            if (results != null)
                return _mapper.Map<CommentDTO>(results);
            return null;
        }
    }
}
