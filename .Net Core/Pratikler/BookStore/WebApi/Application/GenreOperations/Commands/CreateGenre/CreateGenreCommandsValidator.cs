﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Application.GenreOperations.Commands.CreateGenre
{
    public class CreateGenreCommandsValidator:AbstractValidator<CreateGenreCommands>
    {
        public CreateGenreCommandsValidator()
        {
            RuleFor(cmd => cmd.Model.Name)
                .NotEmpty()
                .MinimumLength(4);
        }
    }
}
