﻿using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Disabling default error responses
            //filters.Add(new HandleErrorAttribute());
        }
    }
}
