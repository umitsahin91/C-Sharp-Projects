﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.BookOperations.UpdateBook
{
    public class UpdateBookCommandValidator:AbstractValidator<UpdateBookCommand>
    {
        public UpdateBookCommandValidator()
        {
            RuleFor(cmd => cmd.BookId).GreaterThan(0);
            RuleFor(cmd => cmd.Model.GenreId).GreaterThan(0);
            RuleFor(cmd => cmd.Model.Title).NotEmpty().MinimumLength(4);

        }
    }
}
