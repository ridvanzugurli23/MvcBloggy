﻿using MvcBloggy.API.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Validation.Providers;
using WebAPIDoodle.Http;

namespace MvcBloggy.API.Config {
    
    public static class WebAPIConfig {

        public static void Configure(HttpConfiguration config) {

            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Never;

            //Message Handlers
            config.MessageHandlers.Add(new RemoveServerHeaderMessageHandler());

            //Formatters
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Remove(config.Formatters.FormUrlEncodedFormatter);

            //Filters

            //Default Services
            config.Services.RemoveAll(
                typeof(System.Web.Http.Validation.ModelValidatorProvider), 
                v => v is InvalidModelValidatorProvider);

            // From DefaultContentNegotiator class:
            // If ExcludeMatchOnTypeOnly is true then we don't match on type only which means
            // that we return null if we can't match on anything in the request. This is useful
            // for generating 406 (Not Acceptable) status codes.
            config.Services.Replace(
                typeof(IContentNegotiator),
                new DefaultContentNegotiator(excludeMatchOnTypeOnly: true)
            );
        }
    }
}
