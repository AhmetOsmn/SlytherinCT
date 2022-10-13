﻿using CarTender.FluentValidation.DTO.CombineDTO.Bid;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTender.FluentValidation.DAL.CombineDAL.Bid
{
    public class CombineBidCarDAL : AbstractValidator<CombineBidCarDTO>
    {
        public CombineBidCarDAL()
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
