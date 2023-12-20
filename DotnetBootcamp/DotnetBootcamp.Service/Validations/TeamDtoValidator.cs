using DotnetBootcamp.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBootcamp.Service.Validations
{
    public class TeamDtoValidator:AbstractValidator<TeamDto>
    {
        public TeamDtoValidator()
        {
            RuleFor(x => x.TeamName).NotNull().WithMessage("{PropertyName} null olamaz!").NotEmpty().WithMessage("{PropertyName} boş geçilemez!");

        }
    }
}
