using CidadeSemLimites.Communication.Requests.Posts;
using CidadeSemLimites.Exception.ErrorMessagesResources;
using FluentValidation;

namespace CidadeSemLimites.Application.Validators.Posts
{
    public class PostValidator : AbstractValidator<RequestAddPostJson>
    {
        public PostValidator()
        {
            RuleFor(expense => expense.Neighborhood).NotEmpty().WithMessage(PostResource.Empty_Neighborhood);
            RuleFor(expense => expense.Author).NotEmpty().WithMessage(PostResource.Empty_Author);
            RuleFor(expense => expense.Description).NotEmpty().WithMessage(PostResource.Empty_Description);
            RuleFor(expense => expense.CreatedAt).NotEmpty().WithMessage(PostResource.Empty__Creation_Date);
        }
    }
}
