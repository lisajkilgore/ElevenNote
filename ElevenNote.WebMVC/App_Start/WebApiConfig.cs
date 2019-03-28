﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace ElevenNote.WebMVC.App_Start
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            GlobalConfiguration
                .Configure(
                X =>
                {
                    X
                    .Formatters
                    .JsonFormatter
                    .SupportedMediaTypes
                    .Add(new MediaTypeHeaderValue("text/html"));

                    X.MapHttpAttributeRoutes();
                }
                );
        }
    }
}
