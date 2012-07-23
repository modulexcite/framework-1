using System;
using FluentValidation;
using ThreeBytes.User.Authentication.Password.Entities;
using ThreeBytes.User.Authentication.Password.Service.Abstract;

namespace ThreeBytes.User.Authentication.Password.Validations.Concrete.Validators
{
    public class UpdatePasswordManagementUserEmailValidator : AbstractValidator<PasswordManagementUser>
    {
        private readonly IPasswordManagementUserService service;

        public UpdatePasswordManagementUserEmailValidator(IPasswordManagementUserService service)
        {
            if (service == null)
                throw new ArgumentNullException("service");

            this.service = service;

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage(Resources.Resources.RequiredEmailValidationMessage)
                .EmailAddress().WithMessage(Resources.Resources.ValidEmailValidationMessage)
                .Must((user, email) => UniqueEmail(user)).WithMessage(Resources.Resources.UnqiueEmailValidationMessage);
        }

        private bool UniqueEmail(PasswordManagementUser user)
        {
            return service.UniqueEmail(user.Email, user.ApplicationName);
        }
    }
}