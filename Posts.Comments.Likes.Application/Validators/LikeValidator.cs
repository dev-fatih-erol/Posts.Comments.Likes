using FluentValidation;
using Posts.Comments.Likes.Application.Commands;

namespace Posts.Comments.Likes.Application.Validators
{
    public class LikeValidator : AbstractValidator<LikeCommand>
    {
        public LikeValidator()
        {
            RuleFor(l => l.User)
                .NotNull()
                .WithMessage("{PropertyName} is required.");

            RuleFor(l => l.CommentId)
                .NotEmpty()
                .WithMessage("{PropertyName} is required.");
        }
    }
}