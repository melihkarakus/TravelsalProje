﻿using Microsoft.AspNetCore.Mvc;

namespace TravelsalProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutLanguages : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
