using System;

namespace Posts.Comments.Likes.Application.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string entity)
            : base($"{entity} not found.")
        {
        }
    }
}