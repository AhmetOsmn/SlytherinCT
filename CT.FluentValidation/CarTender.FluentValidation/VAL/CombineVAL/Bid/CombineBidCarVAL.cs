﻿using CarTender.FluentValidation.DTO.CombineDTO.Bid;
using FluentValidation;

namespace CarTender.FluentValidation.VAL.CombineVAL.Bid
{
    public class CombineBidCarVAL : AbstractValidator<CombineBidCarDTO>
    {
        public CombineBidCarVAL()
        {
            #region Admin and User Bid Start Price Car

            RuleFor(x => x.StartPrice)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen Başlangıç Fiyatı Giriniz.");

            #endregion

            #region Admin and User Bid Minimum Price Car

            RuleFor(x => x.MinimumPrice)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("Lütfen Minimum Fiyat Giriniz.");

            #endregion
        }
    }
}
