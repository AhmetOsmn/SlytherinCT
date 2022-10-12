﻿using CarTender.FluentValidation.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DAL
{
    public class AdminLoginDAL : AbstractValidator<AdminLoginDTO>
    {
        public AdminLoginDAL()
        {
            RuleFor(x => x.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} alanı boş bırakılamaz.")
                .MinimumLength(10).WithMessage("{PropertyName} alanı 10 karakterden küçük olamaz.")
                .MaximumLength(100).WithMessage("{PropertyName} alanı 100 karakterden büyük olamaz.");


            RuleFor(x => x.Password)
            .Cascade(CascadeMode.StopOnFirstFailure)
            .NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.")
            .MinimumLength(8).WithMessage("Şifreniz 8 karakterden küçük olamaz.")
            .MaximumLength(8).WithMessage("Şifreniz 8 karakterden büyük olamaz.")
            .Matches(@"[A-Z]+").WithMessage("Şirenizde en az bir büyük karakter olmalıdır.")
                .Matches(@"[a-z]+").WithMessage("Şifrenizde en az bir küçük karakter olmalıdır.")
                .Matches(@"[0-9]+").WithMessage("Şifrenizde en az biri rakam olmalıdırç")
                .Matches(@"[\!\?\*\.]+").WithMessage("Şifrenizde en az bir özel karakter olmalıdır(!? *.).");
        }
    }
}
