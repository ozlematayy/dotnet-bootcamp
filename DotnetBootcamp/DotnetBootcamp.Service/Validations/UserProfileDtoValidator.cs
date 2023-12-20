using DotnetBootcamp.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBootcamp.Service.Validations
{
    public class UserProfileDtoValidator:AbstractValidator<UserProfileDto>
    {
        public UserProfileDtoValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Kullanıcının adı boş olamaz!")
               .NotNull().WithMessage("Kullanıcının adı null olamaz!");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Kullanıcının soyadı boş olamaz!")
              .NotNull().WithMessage("Kullanıcının soyadı null olamaz!");
        }
    }
}
