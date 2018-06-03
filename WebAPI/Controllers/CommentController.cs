using AutoMapper;
using Data.DTO.Add;
using Data.DTO.Edit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class CommentController: Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService) {
            this._commentService = commentService;
        }

        [HttpPost]
        public IActionResult AddComment([FromBody]CommentAdd commentAdd) {
            var result = _commentService.Add(commentAdd, ClaimsMethods.GetClaimsList(HttpContext.User.Claims));
            if (result != null)
                return Ok(result);
            return BadRequest();
        }

        [HttpPut]
        public IActionResult EditComment([FromBody]CommentEdit commentEdit) {
            var result = _commentService.Edit(commentEdit, ClaimsMethods.GetClaimsList(HttpContext.User.Claims));
            if (result != null)
                return Ok(result);
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult DeleteComment([FromBody]CommentEdit comment) {
            if (_commentService.Delete(comment, ClaimsMethods.GetClaimsList(HttpContext.User.Claims)) != true)
                return Ok();
            return BadRequest();
        }
    }
}
