using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Posts.Comments.Likes.Application.Commands;
using Posts.Comments.Likes.Application.Dtos;
using Posts.Comments.Likes.Infrastructure.Entities;
using Posts.Comments.Likes.Infrastructure.Services;

namespace Posts.Comments.Likes.Application.Handlers
{
    public class LikeHandler : IRequestHandler<LikeCommand, LikeDto>
    {
        private readonly IMapper _mapper;

        private readonly ILikeService _likeService;

        public LikeHandler(IMapper mapper, ILikeService likeService)
        {
            _mapper = mapper;

            _likeService = likeService;
        }

        public async Task<LikeDto> Handle(LikeCommand request, CancellationToken cancellationToken)
        {
            var like = await _likeService.Like(
                new Like
                {
                    User = _mapper.Map<User>(request.User),
                    CreatedDate = DateTime.UtcNow,
                    CommentId = request.CommentId
                });

            var response = _mapper.Map<LikeDto>(like);

            return response;
        }
    }
}