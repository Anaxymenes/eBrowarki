using AutoMapper;
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

        public CommentDTO Add(CommentAdd commentAdd) {
            throw new NotImplementedException();
        }

        public bool Delete(CommentEdit comment) {
            throw new NotImplementedException();
        }

        public CommentDTO Edit(CommentEdit commentEdit) {
            throw new NotImplementedException();
        }
    }
}
