﻿using Microsoft.AspNetCore.Mvc;
using Portfolyom.DAL.Context;

namespace Portfolyom.ViewComponents
{
    public class _SkillComponentPartial: ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.Skills.ToList();
            return View(values);
        }
    }
}
